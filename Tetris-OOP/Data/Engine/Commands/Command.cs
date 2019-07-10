using GameTetris;
using Tetris.Data.GUI;

namespace Engine.Commands
{
	/// <summary>Класс Команды объявляет метод для выполнения команд.</summary>
	public abstract class Command
	{
		protected readonly PlayField _playField;
		protected readonly Game _game;

		protected Command(PlayField playField)
		{
			_playField = playField;
		}

		protected Command(Game game)
		{
			_game = game;
		}

		public abstract void Execute();
	}

	/// <summary>Класс инициализатор команд, отправляет запрос на команду.</summary>
	public class Invoker
	{
		private Command _command;
		/// <summary>Команда поступившая на выполнение.</summary>
		public Command Command
		{
			set => _command = value;
		}

		/// <summary>Запуск команды.</summary>
		public void Run()
		{
			_command?.Execute(); // если команда не пустая, то выполняется
			_command = null; // после выполнения обнуляем команду
		}
	}

	#region Команды движения и пауза
	public class MoveLeft : Command
	{
		public MoveLeft(PlayField playField) : base(playField){ }

		public override void Execute()
		{
			_playField.MoveLeft();
		}
	}

	public class MoveRight : Command
	{
		public MoveRight(PlayField playField) : base(playField) { }

		public override void Execute()
		{
			_playField.MoveRight();
		}
	}

	public class MoveDown : Command
	{
		public MoveDown(PlayField playField) : base(playField) { }

		public override void Execute()
		{
			_playField.MoveDown();
		}
	}

	public class MoveDrop : Command
	{
		public MoveDrop(PlayField playField) : base(playField) { }

		public override void Execute()
		{
			_playField.Drop();
		}
	}

	public class MoveRotate : Command
	{
		public MoveRotate(PlayField playField) : base(playField) { }

		public override void Execute()
		{
			_playField.RotateFigure();
		}
	}

	public class MovePause : Command
	{
		public MovePause(Game game) : base(game) { }

		public override void Execute()
		{
			// меняем значение на противоположное
			_game.Paused = !_game.Paused;

			// открываем форму с паузой
			MenuPauseForm menu = new MenuPauseForm();
			menu.ShowDialog();

			// после закрытия меню - игра продолжается
			_game.Paused = !_game.Paused;
		}
	}
	#endregion
}