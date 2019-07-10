namespace Engine
{
	public struct GameShape
	{
		#region Ячейки фигуры
		public int X0 { get; private set; }
		public int Y0 { get; private set; }

		public int X1 { get; private set; }
		public int Y1 { get; private set; }

		public int X2 { get; private set; }
		public int Y2 { get; private set; }

		public int X3 { get; private set; }
		public int Y3 { get; private set; }
		#endregion

		#region Переменные
		/// <summary>Получает или устанавливает тип клетки.</summary> 
		public CellType Type { get; set; }

		/// <summary>Создание новой пустой фигуры.</summary> 
		public static readonly GameShape Zero = new GameShape(CellType.Empty);

		/// <summary>Генерирует случайное число от 1 до 8</summary>
		private static readonly RandomBag _random = new RandomBag(1, 8);

		#endregion


		/// <summary>Инициализирует форму фигуры по цвету.</summary> 
		private GameShape(CellType type):this()
		{
			Type = type;
			// Начальные координаты
			X0 = Y0 = 0;

			// Создаём форму фигуры согласно её цвету
			CreateTetromino(type);
		}


		#region Действия с фигурой
		/// <summary>Создаёт форму фигуры согласно её цвету.</summary> 
		private void CreateTetromino(CellType type)
		{
			switch (type)
			{
				case CellType.Red: // S
				{
					X1 = X0 - 1;
					X2 = X0;
					X3 = X0 + 1;
					Y1 = Y0;
					Y2 = Y3 = Y0 + 1;
					break;
				}
				case CellType.Green: // Z
				{
					X1 = X0 - 1;
					X2 = X0;
					X3 = Y1 = Y2 = Y0 + 1;
					Y3 = Y0;
					break;
				}
				case CellType.Blue: // Г
				{
					X1 = X0 - 1;
					X2 = X3 = X0 + 1;
					Y1 = Y2 = Y0;
					Y3 = Y0 + 1;
					break;
				}
				case CellType.Yellow: // []
				{
					X1 = X0 + 1;
					X2 = X0;
					X3 = X0 + 1;
					Y1 = Y0;
					Y2 = Y3 = Y0 + 1;
					break;
				}
				case CellType.Orange: // L
				{
					X1 = X2 = X0 - 1;
					X3 = X0 + 1;
					Y1 = Y0 + 1;
					Y2 = Y3 = Y0;
					break;
				}
				case CellType.Purple: // T
				{
					X1 = X0 - 1;
					X2 = X0;
					X3 = X0 + 1;
					Y1 = Y0;
					Y2 = Y0 + 1;
					Y3 = Y0;
					break;
				}
				case CellType.LightBlue: // I
				{
					X1 = X0 - 1;
					X2 = X0 + 1;
					X3 = X0 + 2;
					Y1 = Y2 = Y3 = Y0;
					break;
				}
				default: // Остались Wall и Empty
				{
					X3 = X2 = X1 = X0 = 0;
					Y3 = Y2 = Y1 = Y0 = 0;
					break;
				}
			}
		}

		/// <summary>Генерируется случайная фигура из мешка, исходя из истории.</summary> 
		/// <returns>Возвращается случайное число от 1 до 8.</returns>
		public static GameShape RandomFigure()
		{
			int rnd = _random.Next();
			_random.AddShapeToHistory(rnd);
			if (Tetris.Properties.Game.Default.CheatSquare) return new GameShape((CellType)4);
			if (Tetris.Properties.Game.Default.CheatLine) return new GameShape((CellType)7);
			return new GameShape((CellType)rnd);
		}

		/// <summary>Проверка двух фигур на равность по типу и каждой координате.</summary>
		/// <param name="s1">Первая фигура.</param>
		/// <param name="s2">Вторая фигура.</param>
		/// <returns>true - фигуры равны, false - фигуры не равны.</returns>
		public static bool operator ==(GameShape s1, GameShape s2)
		{
			if (s1.Type != s2.Type) return false;
			return s1.X0 == s2.X0 &&
			       s1.Y0 == s2.Y0 &&
			       s1.X1 == s2.X1 &&
			       s1.X2 == s2.X2 &&
			       s1.X3 == s2.X3 &&
			       s1.Y1 == s2.Y1 &&
			       s1.Y2 == s2.Y2 &&
			       s1.Y3 == s2.Y3;
		}

		/// <summary>Проверка двух фигур на НЕ равность по типу и каждой координате.</summary>
		/// <param name="s1">Первая фигура.</param>
		/// <param name="s2">Вторая фигура.</param>
		/// <returns>true - фигуры НЕ равны, false - фигуры равны.</returns>
		public static bool operator !=(GameShape s1, GameShape s2)
		{
			return !(s1 == s2);
		}

		/// <summary>Создает копию фигуры.</summary>
		/// <returns>Возвращается копия фигуры.</returns>
		private GameShape Clone()
		{
			GameShape clonedShape = new GameShape(Type)
			{
				X0 = X0,
				Y0 = Y0,
				X1 = X1,
				Y1 = Y1,
				X2 = X2,
				Y2 = Y2,
				X3 = X3,
				Y3 = Y3
			};
			return clonedShape;
		}
		#endregion


		#region Перемещение фигуры
		/// <summary>Перемещает фигуру в положение y = row, x = col.</summary>
		/// <returns>Возвращается перемещенная фигура.</returns>
		public GameShape MoveTo(int row, int col)
		{
			int dx = col - X0;
			int dy = row - Y0;

			GameShape movedShape = new GameShape(Type)
			{
				X0 = col,
				Y0 = row,
				X1 = X1 + dx,
				Y1 = Y1 + dy,
				X2 = X2 + dx,
				Y2 = Y2 + dy,
				X3 = X3 + dx,
				Y3 = Y3 + dy
			};

			return movedShape;
		}

		/// <summary>Смещает фигуру вниз.</summary>
		/// <returns>Возвращается смещенная вниз фигура.</returns>
		public GameShape MoveDown()
		{
			return MoveTo(Y0 + 1, X0);
		}

		/// <summary>Смещает фигуру вверх.</summary>
		/// <returns>Возвращается смещенная вверх фигура.</returns>
		public GameShape MoveUp()
		{
			return MoveTo(Y0 - 1, X0);
		}

		/// <summary>Смещает фигуру вправо.</summary>
		/// <returns>Возвращается смещенная вправо фигура.</returns>
		public GameShape MoveRight()
		{
			return MoveTo(Y0, X0 + 1);
		}

		/// <summary>Смещает фигуру вправо.</summary>
		/// <returns>Возвращается смещенная вправо фигура.</returns>
		public GameShape MoveLeft()
		{
			return MoveTo(Y0, X0 - 1);
		}

		#endregion


		#region Поворот фигуры
		/// <summary>Горизонтальный поворот клетки относительно центра на 90 градусов.</summary>
		/// <param name="col">Координата по вертикали.</param>
		/// <returns>Возвращается координата клетки.</returns>
		private int RotateCol(int col)
		{
			return Y0 - X0 + col;
		}

		/// <summary>Вертикальный поворот клетки относительно центра на 90 градусов.</summary>
		/// <param name="row">Координата по горизонтали.</param>
		/// <returns>Возвращается пе клетка.</returns>
		private int RotateRow(int row)
		{
			return X0 - row + Y0;
		}

		/// <summary>Осуществляет поворот фигуры по часовой стрелке на 90 градусов.</summary>
		/// <returns>Повёрнутую фигуру.</returns>
		public GameShape Rotate()
		{
			GameShape res = Clone();
			res.X1 = RotateRow(Y1);
			res.Y1 = RotateCol(X1);
			res.X2 = RotateRow(Y2);
			res.Y2 = RotateCol(X2);
			res.X3 = RotateRow(Y3);
			res.Y3 = RotateCol(X3);
			return res;
		}
		#endregion
	}
}
