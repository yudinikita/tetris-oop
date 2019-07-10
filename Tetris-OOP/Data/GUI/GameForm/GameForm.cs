//*********************************************************
//
// Название: Тетрис
// Разработчик: Юдин Никита
// Дата начала разработки: 20.04.2019
// Авторское право (c) Юдин Никита. Все права защищены.
//
//*********************************************************

using System;
using Engine;
using GameTetris;
using System.Drawing;
using Engine.Commands;
using System.Windows.Forms;
using Tetris.Data.GUI.GameResultForm;
using Tetris.Data.Modules.Users;

namespace Tetris
{
	/// <summary>Форма с игрой.</summary>
	public partial class GameForm : Form
	{
		#region Переменные
		/// <summary>Игровое поле с фигурами.</summary>
		private readonly PlayField _playField;

		/// <summary>Поле со следующей фигурой.</summary>
		private readonly GameBoard _nextShape;

		/// <summary>Паттерн Команда для управления фигурами.</summary>
		private readonly Invoker shapeControl = new Invoker();

		/// <summary>Активная игра.</summary>
		private Game _game;

		/// <summary>Количество уничтоженных линий за всю игру.</summary>
		private int _countRemoveRows;

		/// <summary>Время, которое прошло со старта игры.</summary>
		private DateTime ElapsedTime = new DateTime(0, 0);

		//private NewRecordDialog NRDialog;
		//private RecordsForm RForm;

		//private Image PausedImage, GameOverImage;
		#endregion /Переменные


		#region Инициализация формы
		public GameForm()
		{
			_game = new Game(); // создаем новую игру

			//Saver.Load();

			_playField = new PlayField(20, 10); // создаем игровое поле
			_nextShape = new GameBoard(2, 4); // создаем поле для следующей фигуры
			_game.StateChanged += Game_StateChanged;

			_game.StateChanged += Game_StateChanged;

			InitializeComponent();

			NewGame();
		}
		#endregion /Инициализация


		#region Методы
		/// <summary>Запуск новой игры.</summary>
		private void NewGame()
		{
			_game = new Game
			{
				Score = Properties.Game.Default.CountScore,
				Lines = 0
			};
			_game.StateChanged += Game_StateChanged;
			_game.NextShape = GameShape.RandomFigure();

			GameTimer.Enabled = false;
			GameTimer.Enabled = true;
			RealTimer.Enabled = true;

			_playField.Clear();
		}

		/// <summary>Устанавливает время игровой сессии.</summary>
		private void SetTime()
		{
			GameTimer.Interval = _game.Time;
		}

		/// <summary>Устанавливает количество уничтоженных линий у игрока.</summary>
		private void SetLines()
		{
			_game.Lines += _countRemoveRows;
		}

		/// <summary>Устанавливает количество очков у игрока.</summary>
		/// <param name="nowScore">Текущий счет</param>
		private void SetScore(int nowScore)
		{
			_game.Score = nowScore;
		}

		/// <summary>Расчитывает количество очков у игрока в данный момент.</summary>
		/// <returns>Текущее количество очков.</returns>
		private int GetNowScore()
		{
			int scoreForLines;
			_countRemoveRows = _playField.RemoveFullRows() / 10;
			switch (_countRemoveRows)
			{
				case 1: scoreForLines = 100; break;
				case 2: scoreForLines = 300; break;
				case 3: scoreForLines = 500; break;
				case 4: scoreForLines = 800; break;
				default: scoreForLines = 1; break;
			}
			return _game.Score + scoreForLines * _game.Level;
		}

		/// <summary>Завершение игры.</summary>
		private void OnGameOver()
		{
			_game.Over();
			GameTimer.Enabled = false;
			RealTimer.Enabled = false;

			// складывание очков за игру в общее количество
			Properties.Settings.Default.UserScore = (int.Parse(Properties.Settings.Default.UserScore) + _game.Score).ToString();

			// слкадывание общего времени в игре
			DateTime AllTime = Properties.Settings.Default.TimeInGame;

			AllTime = AllTime.AddHours(ElapsedTime.Hour);
			AllTime = AllTime.AddMinutes(ElapsedTime.Minute);
			AllTime = AllTime.AddSeconds(ElapsedTime.Second);

			Properties.Settings.Default.TimeInGame = AllTime;

			lbElapsedTime.Text = ElapsedTime.ToString("mm:ss");
			
			// проверка и установка результата на рекорд
			int record = int.Parse(Properties.Settings.Default.UserRecord);
			if (record < _game.Score) Properties.Settings.Default.UserRecord = _game.Score.ToString();

			// увеличение количество сыгранных игр
			Properties.Settings.Default.NumberOfGames++;

			// добавление денег = очки * 0.001 + СЛУЧАЙНОЕ(0, уровень)
			Random r = new Random();
			double money = _game.Score * 0.001 + r.Next(0, int.Parse(Properties.Settings.Default.Level));
			Properties.Settings.Default.Money += money;

			// сохранение результата
			Properties.Game.Default.GameMoney = Math.Round(money);
			Properties.Game.Default.CountScore = _game.Score;
			Properties.Game.Default.GameTime = ElapsedTime;
			Properties.Game.Default.GameLevel = _game.Level;


			// результат игры
			var gameResultForm = new GameResultForm();
			DialogResult dialogResult = gameResultForm.ShowDialog();
			switch (dialogResult)
			{
				case DialogResult.OK: NewGame(); break;
				case DialogResult.Cancel: Close(); break;
			}

			//DialogResult dialogResult = MessageBox.Show("Начать новую игру?", "Конец игры", MessageBoxButtons.YesNo);
			//switch (dialogResult)
			//{
			//	case DialogResult.Yes: NewGame(); break;
			//	case DialogResult.No: Close(); break;
			//}


			// Сохранение

			//TetrisSave test = new TetrisSave("---", Game.Score, DateTime.Now - Game.GameStarted);

			//if (Saver.HighScores.CanAdd(test) || Saver.HighTimes.CanAdd(test))
			//{
			//	NRDialog = new NewRecordDialog();
			//	if (NRDialog.ShowDialog() == DialogResult.OK)
			//	{
			//		test.UserName = NRDialog.UserName;
			//		Saver.Save(test);

			//		RForm = new RecordsForm(test);
			//		if (RForm.ShowDialog() == DialogResult.OK)
			//		{
			//			NewGame();
			//		}
			//	}
			//}
		}
		#endregion /методы


		#region События
		/// <summary>Событие при изменение состояния игры.</summary>
		private void Game_StateChanged(object sender, EventArgs e)
		{
			lbScore.Text = _game.Score.ToString();
			lbLinesDestroy.Text = _game.Lines.ToString();
			lbLevel.Text = _game.Level.ToString();

			if (_game.Paused) // если активирована пауза
			{
				GameTimer.Enabled = false;
				RealTimer.Enabled = false;
				pbPauseOff.Visible = false;
				pbPauseOn.Visible = true;
			}
			else
			{
				GameTimer.Enabled = true;
				RealTimer.Enabled = true;
				pbPauseOff.Visible = true;
				pbPauseOn.Visible = false;
			}
		}


		#region Таймеры
		/// <summary>Игровой цикл.</summary>
		private void GameTimer_Tick(object sender, EventArgs e)
		{
			if (_game.Paused) return;

			SetScore(GetNowScore());
			SetLines();
			SetTime();

			_playField.DoStep();

			if (!_playField.IsFigureFalling)
			{
				// если не удалось поместить новую фигуру на поле, то игра окончена
				if (!_playField.PlaceShape(_game.NextShape)) OnGameOver();
				else // если удалось
				{
					_game.NextShape = GameShape.RandomFigure();
					_game.ShapeDropped++;
					_nextShape.Clear();
					if(Properties.Settings.Default.NextShape) _nextShape.SetFigure(_game.NextShape.MoveTo(0, 1), false);

					// если фигура изменилась или упала, то фигура не изменилась
					if (_game.FigureChanged && _game.ShapeDropped % 5 == 0) _game.FigureChanged = false;
				}
			}
			Refresh();
		}

		/// <summary>Таймер для отображения реального времени.</summary>
		private void RealTimer_Tick(object sender, EventArgs e)
		{
			// сколько прошло с начала игры
			ElapsedTime = ElapsedTime.AddSeconds(1);
			lbElapsedTime.Text = ElapsedTime.ToString("mm:ss");
			// текущее системное время
			lbNowTime.Text = DateTime.Now.ToString(@"HH:mm");
		}
		#endregion /таймеры

		/// <summary>Управление фигурой.</summary>
		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;

			// бонус - удалить линию !!!
			if (e.KeyData == Keys.W) _playField.RemoveOneRows();


			if (_game.GameOver) return;

			if (e.KeyData == Keys.Escape) shapeControl.Command = new MovePause(_game);

			if (!_game.Paused)
			{
				if (e.KeyData == Properties.Controls.Default.KeyLeft)   shapeControl.Command = new MoveLeft(_playField);
				if (e.KeyData == Properties.Controls.Default.KeyRight)  shapeControl.Command = new MoveRight(_playField);
				if (e.KeyData == Properties.Controls.Default.KeyDown)   shapeControl.Command = new MoveDown(_playField);
				if (e.KeyData == Properties.Controls.Default.KeyUp)     shapeControl.Command = new MoveDrop(_playField);
				if (e.KeyData == Properties.Controls.Default.KeyRotate) shapeControl.Command = new MoveRotate(_playField);
			}

			shapeControl.Run();
			Refresh();
		}

		private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			UserManager.CheckOnLevel();
		}
		#endregion /события


		#region Рисование
		/// <summary>Рисование игрового поля.</summary>
		private void PbGameField_Paint(object sender, PaintEventArgs e)
		{
			_playField.Paint(e.Graphics);
		}

		/// <summary>Рисование следующей фигуры.</summary>
		private void PbNextFigure_Paint(object sender, PaintEventArgs e)
		{
			Properties.Game.Default.BorderColor = _game.FigureChanged ? Color.FromArgb(160, 128, 128) : Tetris.Properties.Game.Default.BackColor;
			_nextShape.Paint(e.Graphics);
		}
		#endregion /рисование
	}
}

/* Структура
 * Engine - Соединение игровой логики и модулей
 * Core - Игровая логика
 * Modules - Модули (музыка, набор очков, настройка, жизни, имя, уровни)
 * GUI-Form - Отображение интерфейса (настройки формы, расположение кнопок)
 * Game - Связка между движком и интерфейсом
 * GUI-Game - Отображение игры
 * MainForm - Вход в программу, инициализация формы, вызов Game
 * 
 * Game
 * - MainForm
 * - - GUI-Form
 * - - GUI-Game
 * - Engine
 * - - Core
 * - - Modules
 * Settings
 * Resources
 * 
 
 * Цвета
 * Зеленый-фон-тетриса = Color.FromArgb(156, 172, 135
 *
 * )

 */
