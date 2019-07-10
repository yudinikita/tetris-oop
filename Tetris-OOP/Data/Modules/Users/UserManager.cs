using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Tetris.Properties;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tetris.Data.Modules.Users
{
	internal class UserManager
	{
		/// <summary>Все зарегистрированные пользователи.</summary>
		public static List<User> _users = new List<User>();

		/// <summary>Последний вошедший пользователь (Last)</summary>
		private static int L = 0;

		public UserManager()
		{
			LoadUsers();
			InitUser(L);
		}

		/// <summary>Загружает всех пользователей из файла в активный список.</summary>
		private void LoadUsers()
		{
			try
			{
				if (!File.Exists("users.xml")) CreateDefaultFileUsers();

				XmlDocument doc = new XmlDocument();
				doc.Load("users.xml");

				foreach (XmlNode node in doc.DocumentElement)
				{
					string name = node.Attributes[0].Value;
					int id = int.Parse(node["id"].InnerText);
					string password = node["pass"].InnerText;
					int score = int.Parse(node["score"].InnerText);
					int record = int.Parse(node["record"].InnerText);
					int level = int.Parse(node["level"].InnerText);
					int levelScore = int.Parse(node["levelScore"].InnerText);
					DateTime timeInGame = DateTime.Parse(node["timeInGame"].InnerText);
					int numberOfGames = int.Parse(node["numberOfGames"].InnerText);
					double money = double.Parse(node["money"].InnerText);
					bool last = bool.Parse(node["last"].InnerText);

					var user = new User
					{
						Id = id,
						Name = name,
						Password = password,
						Score = score,
						Record = record,
						Level = level,
						LevelScore = levelScore,
						TimeInGame = timeInGame,
						NumberOfGames = numberOfGames,
						Money = money,
						Last = last
					};
					_users.Add(user);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(@"Ошибка при загрузке пользователей. " + e);
				throw;
			}
		}

		private void CreateDefaultFileUsers()
		{
			// Создаем новый Xml документ.
			var doc = new XmlDocument();
			// Создаем Xml заголовок.
			var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			// Добавляем заголовок перед корневым элементом.
			doc.AppendChild(xmlDeclaration);
			// Создаем Корневой элемент
			var root = doc.CreateElement("users");

			doc.AppendChild(root);
			doc.Save("users.xml");

			AddNewUser("Безымянный", "0", "", "0", "0", "1", "0", "0:00:00", 0,0, "true");
		}

		public static void AddNewUser(string name, string id, string pass, string score, string record, string level, string lvlScoreTxt, string timeInGame, int numberOfGames, double money, string last)
		{
			XDocument xdoc = XDocument.Load("users.xml");
			XElement root = xdoc.Element("users");

			root.Add(new XElement("user",
					new XAttribute("name", name),
					new XElement("id", id),
					new XElement("pass", pass),
					new XElement("score", score),
					new XElement("record", record),
					new XElement("level", level),
					new XElement("levelScore", lvlScoreTxt),
					new XElement("timeInGame", timeInGame),
					new XElement("numberOfGames", numberOfGames),
					new XElement("money", money),
					new XElement("last", last)
					));

			xdoc.Save("users.xml");

			var user = new User
			{
				Id = int.Parse(id),
				Name = name,
				Password = pass,
				Score = int.Parse(score),
				Record = int.Parse(record),
				Level = int.Parse(level),
				LevelScore = int.Parse(lvlScoreTxt),
				TimeInGame = DateTime.Parse(timeInGame),
				NumberOfGames = numberOfGames,
				Money = money,
				Last = bool.Parse(last)
			};
			_users.Add(user);
		}

		public static bool Auth(string name, string pass)
		{
			XDocument xdoc = XDocument.Load("users.xml");

			foreach (XElement userElement in xdoc.Element("users").Elements("user"))
			{
				XAttribute nameAtr = userElement.Attribute("name");
				XElement passElem = userElement.Element("pass");
				XElement idElem = userElement.Element("id");

				if (nameAtr.Value == name)
				{
					if (passElem.Value == pass)
					{
						ChangeLastUser(int.Parse(idElem.Value));
						InitUser(int.Parse(idElem.Value));
						return true;
					}
				}
			}

			return false;
		}

		public static void SaveUserData()
		{
			XDocument xdoc = XDocument.Load("users.xml");

			foreach (XElement userElement in xdoc.Element("users").Elements("user"))
			{
				string name = Settings.Default.UserName;
				string userScore = Settings.Default.UserScore;
				string userRecord = Settings.Default.UserRecord;
				string level = Settings.Default.Level;
				string levelScore = Settings.Default.LevelScore.ToString();
				string timeInGame = Settings.Default.TimeInGame.ToString();
				string numberOfGames = Settings.Default.NumberOfGames.ToString();
				string money = Settings.Default.Money.ToString();

				XAttribute nameAtr = userElement.Attribute("name");
				XElement idElem = userElement.Element("id");
				XElement scoreElem = userElement.Element("score");
				XElement recordElem = userElement.Element("record");
				XElement levelElem = userElement.Element("level");
				XElement levelScoreElem = userElement.Element("levelScore");
				XElement timeInGameElem = userElement.Element("timeInGame");
				XElement numberOfGamesElem = userElement.Element("numberOfGames");
				XElement moneyElem = userElement.Element("money");

				if (nameAtr.Value == name)
				{
					ChangeLastUser(int.Parse(idElem.Value));
					scoreElem.Value = userScore;
					recordElem.Value = userRecord;
					levelElem.Value = level;
					levelScoreElem.Value = levelScore;
					timeInGameElem.Value = timeInGame;
					numberOfGamesElem.Value = numberOfGames;
					moneyElem.Value = money;
				}
			}

			xdoc.Save("users.xml");
		}

		/// <summary>Изменяет у всех пользователей last на false.</summary>
		public static void ChangeLastUser()
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load("users.xml");
			XmlElement xRoot = xDoc.DocumentElement;

			XmlNodeList childnodes = xRoot.SelectNodes("//user/last");
			foreach (XmlNode n in childnodes)
				n.InnerText = "false";

			xDoc.Save("users.xml");
		}

		/// <summary>Изменяет у всех пользователей last на false, а по указанному id делает true.</summary>
		/// <param name="id">Номер пользователя, которому оставить true</param>
		private static void ChangeLastUser(int id)
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load("users.xml");
			XmlElement xRoot = xDoc.DocumentElement;

			XmlNodeList childnodes = xRoot.SelectNodes("//user/last");

			int i = 0;
			foreach (XmlNode n in childnodes)
			{
				n.InnerText = "false";
				if (i++ == id) n.InnerText = "true";
			}

			xDoc.Save("users.xml");
		}


		public static void CheckOnLevel()
		{
			int score = int.Parse(Settings.Default.UserScore);

			int max_level = 50;
			double[] ranges = new double[max_level];

			for (int i = 1; i <= max_level; i++)
			{
				ranges[i-1] = Math.Round(10000 * Math.Pow(1.15, i));
			}
			
			for (int i = 0; i < max_level; i++)
			{
				if (score <= ranges[i])
				{
					Settings.Default.Level = (i + 1).ToString();
					Settings.Default.ScoreForNextLevel = ranges[i].ToString();
					Settings.Default.LevelScoreMax = Convert.ToInt32(ranges[i]);
					Settings.Default.LevelScore = score;

					double perc = Math.Round(Convert.ToDouble(score) / Convert.ToDouble(Settings.Default.LevelScoreMax) * 100);
					Settings.Default.LevelScorePerc = perc + "%";

					goto end;
				}
			}

			end: ;
		}

		private static double GetRangeForLevel(int level)
		{
			double range = 10000;
			for (int i = 1; i < level; i++)
			{
				range = Math.Round(range * 1.15);
			}
			return range;
		}

		/// <summary>Заносит информацию о пользователи с указанным номером в активную сессию.</summary>
		private static void InitUser(int id)
		{
			Settings.Default.UserName = _users[id].Name;
			Settings.Default.NumberUsers = _users.Count.ToString();
			Settings.Default.UserScore = _users[id].Score.ToString();
			Settings.Default.UserRecord = _users[id].Record.ToString();
			Settings.Default.Level = _users[id].Level.ToString();
			Settings.Default.LevelScore = _users[id].LevelScore;
			Settings.Default.LevelScorePerc = (_users[id].LevelScore / 1000) + "%";
			Settings.Default.TimeInGame = _users[id].TimeInGame;
			Settings.Default.NumberOfGames = _users[id].NumberOfGames;
			Settings.Default.Money = _users[id].Money;
		}

		/// <summary>Заносит номер последнего игравшего в переменную.</summary>
		private static void SetLastUser()
		{
			for (int i = 0; i < _users.Count; i++)
			{
				if (_users[i].Last) L = i;
			}
		}
	}
}
