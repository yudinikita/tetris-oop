using System;
using Engine;

namespace GameTetris
{
	/// <summary>Представляет игровую логику.</summary> 
	public class Game
	{
		#region Переменные
		/// <summary>Следующая фигура.</summary>
		public GameShape NextShape;

		/// <summary>Время старта игры.</summary>
		public DateTime GameStarted;

		/// <summary>Время нахождения игры при паузе.</summary>
		public DateTime GamePaused;

		private bool _gameOver;
		/// <summary>Если true - игра продолжается, иначе - завершение игры.</summary>
		public bool GameOver
		{
			get => _gameOver;
			set
			{
				_gameOver = value;
				OnStateChanged();
			}
		}
		
		private bool _paused;
		/// <summary>Если true - игра ставится на паузу, иначе - игра продолжается.</summary>
		public bool Paused
		{
			get => _paused;
			set
			{
				if (!_paused && value)
				{
					GamePaused = DateTime.Now;
					_paused = value;
					OnStateChanged();
				}

				if (!_paused || value) return;

				GameStarted = GameStarted + (DateTime.Now - GamePaused);
				_paused = value;
				OnStateChanged();
			}
		}

		private bool _figChanged;
		/// <summary>Если true - фигура изменилась, иначе - ничего.</summary>
		public bool FigureChanged
		{
			get => _figChanged;
			set
			{
				_figChanged = value;
				OnStateChanged();
			}
		}

		private int _score;
		/// <summary>Игровой счет.</summary>
		public int Score
		{
			get => _score;
			set
			{
				_score = value;
				OnStateChanged();
			}
		}

		private int _time;
		/// <summary>Уровень сложности игры.</summary>
		public int Time
		{
			get => (int)(Math.Pow(0.8 - ((_level - 1) * 0.007), _level - 1) * 1000);
			set
			{
				_time = value;
				OnStateChanged();
			}
		}

		private int _level;
		/// <summary>Уровень сложности игры.</summary>
		public int Level
		{
			get
			{
				const int MAX_LEVEL = 10;
				_level = (_lines + 10) / 10; // каждые 10 уничтоженных линий увеличивать уровень на 1
				if(_level > MAX_LEVEL) _level = MAX_LEVEL; // максимальный уровень сложности
				return _level;
			}
			set
			{
				_level = value;
				OnStateChanged();
			}
		}

		private int _lines;
		/// <summary>Количество всех уничтоженных линий за игру.</summary>
		public int Lines
		{
			get => _lines;
			set
			{
				_lines = value;
				OnStateChanged();
			}
		}

		private int _shapeDropped;
		/// <summary>Количество фигур, которые упали.</summary>
		public int ShapeDropped
		{
			get => _shapeDropped;
			set
			{
				_shapeDropped = value;
				OnStateChanged();
			}
		}
		#endregion

		#region Инициализация

		public Game()
		{
			Score = 0;
			Lines = 0;
			Level = 1;
			Paused = false;
			GameOver = false;
			FigureChanged = false;
			GameStarted = DateTime.Now;
			NextShape = GameShape.RandomFigure();
		}

		#endregion /инициализация

		#region Методы
		/// <summary>Завершает игру.</summary>
		public void Over()
		{
			GameOver = true;
		}

		/// <summary>Событие изменения состояния.</summary>
		public event EventHandler StateChanged;
		/// <summary>Если состояние изменилось, то добавляем новое событие.</summary>
		private void OnStateChanged()
		{
			StateChanged?.Invoke(this, new EventArgs());
		}
		#endregion
	}
}
