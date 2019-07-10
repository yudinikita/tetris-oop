using System;

namespace Tetris.Data.Modules.Users
{
	internal class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public int Score { get; set; }
		public int Record { get; set; }
		public int Level { get; set; }
		public int LevelScore { get; set; }
		public DateTime TimeInGame { get; set; }
		public int NumberOfGames { get; set; }
		public double Money { get; set; }
		public bool Last { get; set; }
	}
}
