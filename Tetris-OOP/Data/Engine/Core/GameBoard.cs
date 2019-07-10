using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Engine
{
	/// <summary>Представляет собой игровую доску.</summary> 
	public class GameBoard
	{
		#region Переменные
		/// <summary>Получает ширину игровой доски в клетках.</summary> 
		protected int BoardWidth { get; }

		/// <summary>Получает высоту игровой доски в клетках.</summary> 
		protected int BoardHeight { get; }

		/// <summary>Получает размер клетки на игровой доске в пикселях.</summary> 
		protected int CellSize { get; } = 20;

		/// <summary>Двумерный массив используемый для хранения всех клеток игровой доски.</summary> 
		protected readonly CellType[,] _cells;

		/// <summary>Получает тип клетки, если находится в пределах игровой доски, иначе клетка - это стена.</summary>
		/// <param name="row">Положение по горизонтали.</param> 
		/// <param name="col">Положение по вертикали.</param> 
		private CellType this[int row, int col]
		{
			get
			{
				try
				{
					return _cells[row, col];
				}
				catch (IndexOutOfRangeException)
				{
					return CellType.Wall;
				}
			}
		}

		#endregion


		/// <summary>Инициализирует игровую доску.</summary> 
		public GameBoard(int height, int width)
		{
			BoardWidth = width;
			BoardHeight = height;
			// Создание игровой доски
			_cells = new CellType[height, width];

			// Заполняем все клетки игровой доски пустым значением
			for (int row = 0; row < BoardHeight; row++)
			{
				for (int col = 0; col < BoardWidth; col++)
				{
					_cells[row, col] = CellType.Empty;
				}
			}
		}


		#region Действия с фигурой на игровой доске
		/// <summary>Помещает фигуру shape на игровую доску.</summary>
		/// <param name="shape">Фигура.</param>
		/// <param name="rewrite">Параметр = true, если нужно при любом условии перезаписать клетку игровой доски.</param>
		/// <returns>Возвращается количество клеток фигуры, которое удалось поместить на поле.</returns>
		public int SetFigure(GameShape shape, bool rewrite)
		{
			int countCellsOfShape = 4;

			if (_cells[shape.Y0, shape.X0] == CellType.Empty || rewrite) _cells[shape.Y0, shape.X0] = shape.Type;
			else --countCellsOfShape;
			if (_cells[shape.Y1, shape.X1] == CellType.Empty || rewrite) _cells[shape.Y1, shape.X1] = shape.Type;
			else --countCellsOfShape;
			if (_cells[shape.Y2, shape.X2] == CellType.Empty || rewrite) _cells[shape.Y2, shape.X2] = shape.Type;
			else --countCellsOfShape;
			if (_cells[shape.Y3, shape.X3] == CellType.Empty || rewrite) _cells[shape.Y3, shape.X3] = shape.Type;
			else --countCellsOfShape;

			return countCellsOfShape;
		}

		/// <summary>Устанавливает тип конкретной клетки игровой доске.</summary>
		/// <param name="row">Положение по горизонтали.</param> 
		/// <param name="col">Положение по вертикали.</param> 
		/// <param name="type">Тип клетки.</param>
		/// <returns>Возвращается истина, если клетка существует, ложь - если клетка вне диапозона игровой доски.</returns>
		private bool SetCell(int row, int col, CellType type)
		{
			try
			{
				_cells[row, col] = type;
				return true;
			}
			catch (IndexOutOfRangeException)
			{
				return false;
			}
		}

		/// <summary>Поворот фигуры на 90 градусов по часовой стрелке.</summary>
		/// <param name="shape">Фигура, которую нужно повернуть.</param>
		/// <returns>Возвращается повернутая фигура.</returns>
		protected GameShape RotateFigure(GameShape shape)
		{
			GameShape rotated = shape.Rotate();
			shape.Type = CellType.Empty;
			SetFigure(shape, true);
			shape.Type = rotated.Type;

			if (IsEmpty(rotated))
			{
				SetFigure(rotated, false);
				return rotated;
			}
			// Если неудача, фигура наткнулась на препятствие,то нужно сместить её вниз
			GameShape rotated2 = rotated.MoveDown();
			if (IsEmpty(rotated2))
			{
				SetFigure(rotated2, false);
				return rotated2;
			}
			// Вправо
			rotated2 = rotated.MoveRight();
			if (IsEmpty(rotated2))
			{
				SetFigure(rotated2, false);
				return rotated2;
			}
			// Влево
			rotated2 = rotated.MoveLeft();
			if (IsEmpty(rotated2))
			{
				SetFigure(rotated2, false);
				return rotated2;
			}
			// Ничего не удалось сделать
			SetFigure(shape, false);
			return GameShape.Zero;
		}

		/// <summary>Проверка фигуры на наличие пустой клетки.</summary>
		/// <param name="shape">Фигура.</param>
		/// <returns>Возвращает истину - если все клетки фигуры пустые, ложь - если хотя бы одна клетка не пустая.</returns>
		protected bool IsEmpty(GameShape shape)
		{
			return this[shape.Y0, shape.X0] == CellType.Empty && 
			       this[shape.Y1, shape.X1] == CellType.Empty && 
			       this[shape.Y2, shape.X2] == CellType.Empty && 
			       this[shape.Y3, shape.X3] == CellType.Empty;
		}

		/// <summary>Проверка клетки по координатам на пустоту.</summary>
		/// <param name="row">Положение по горизонтали.</param>
		/// <param name="col">Положение по вертикали.</param>
		/// <returns>Возвращает истину - если клетка пустая, ложь - если клетка не пустая.</returns>
		protected bool IsEmpty(int row, int col)
		{
			return this[row, col] == CellType.Empty;
		}

		/// <summary>Стирает фигуру с игрового поля.</summary>
		/// <param name="shape">Фигура.</param>
		protected void EraseFigure(GameShape shape)
		{
			shape.Type = CellType.Empty;
			SetFigure(shape, true);
		}
		#endregion


		#region Смещение клеток на игровой доске
		/// <summary>Осуществляет сдвиг выбранной клетки вниз, если это возможно.</summary>
		/// <param name="row">Координата по горизонтали</param>
		/// <param name="col">Координата по вертикали</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вниз, ложь - если сдвиг не возможен.</returns>
		protected bool MoveDown(int row, int col)
		{
			if (_cells[row, col] != CellType.Empty)
			{
				CellType below = _cells[row + 1, col];
				if (below == CellType.Empty)
				{
					_cells[row + 1, col] = _cells[row, col];
					_cells[row, col] = CellType.Empty;
				}
				return _cells[row + 2, col] == CellType.Empty; // true - если может двигаться еще ниже
			}
			return false;
		}

		/// <summary>Передвигает совокупность клеток вниз.</summary>
		/// <param name="shape">Фигура - совокупность клеток</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вниз, ложь - если сдвиг не возможен</returns>
		protected bool MoveDown(GameShape shape)
		{
			GameShape moved = shape.MoveDown();

			shape.Type = CellType.Empty;
			SetFigure(shape, true);

			if (IsEmpty(moved))
			{
				// Свободно, двигаем вниз
				SetFigure(moved, false);
				return true;
			}

			// Занято, останавливаем
			shape.Type = moved.Type;
			SetFigure(shape, false);
			return false;
		}

		/// <summary>Осуществляет сдвиг выбранной клетки вправо, если это возможно</summary>
		/// <param name="row">Координата по горизонтали</param>
		/// <param name="col">Координата по вертикали</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вправо, ложь - если сдвиг не возможен.</returns>
		protected bool MoveRight(int row, int col)
		{
			if (_cells[row, col] != CellType.Empty)
			{
				CellType below = _cells[row, col + 1];
				if (below == CellType.Empty)
				{
					_cells[row, col + 1] = _cells[row, col];
					_cells[row, col] = CellType.Empty;
				}
				return _cells[row, col + 1] == CellType.Empty; // true - если может двигаться еще ниже
			}
			return false;
		}

		/// <summary>Передвигает совокупность клеток вправо.</summary>
		/// <param name="shape">Фигура - совокупность клеток</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вправо, ложь - если сдвиг не возможен</returns>
		protected bool MoveRight(GameShape shape)
		{
			GameShape moved = shape.MoveRight();

			shape.Type = CellType.Empty;
			SetFigure(shape, true);

			if (IsEmpty(moved))
			{
				SetFigure(moved, false);
				return true;
			}
			shape.Type = moved.Type;
			SetFigure(shape, false);
			return false;
		}

		/// <summary>Осуществляет сдвиг выбранной клетки влево, если это возможно.</summary>
		/// <param name="row">Координата по горизонтали</param>
		/// <param name="col">Координата по вертикали</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вправо, ложь - если сдвиг не возможен.</returns>
		protected bool MoveLeft(int row, int col)
		{
			if (_cells[row, col] != CellType.Empty)
			{
				CellType below = _cells[row, col - 1];
				if (below == CellType.Empty)
				{
					_cells[row, col - 1] = _cells[row, col];
					_cells[row, col] = CellType.Empty;
				}
				return _cells[row, col - 1] == CellType.Empty; // true - если может двигаться еще ниже
			}
			return false;
		}

		/// <summary>Передвигает совокупность клеток вправо.</summary>
		/// <param name="shape">Фигура - совокупность клеток</param>
		/// <returns>Возвращается истина - если возможен дальнейший сдвиг вправо, ложь - если сдвиг не возможен</returns>
		protected bool MoveLeft(GameShape shape)
		{
			GameShape moved = shape.MoveLeft();
			shape.Type = CellType.Empty;
			SetFigure(shape, true);
			if (IsEmpty(moved))
			{
				SetFigure(moved, false);
				return true;
			}
			shape.Type = moved.Type;
			SetFigure(shape, false);
			return false;
		}
		#endregion


		#region Действия с клетками на игровой доске
		/// <summary>Удаляет заполненные ряды и столбцы со смещением всех лежащих выше вниз и возвращает количество уничтоженных рядов.</summary>
		/// <returns>Количество уничтоженных ячеек.</returns>
		public int RemoveFullRows()
		{
			// Список заполненных рядов к удалению
			List<int> fullRows = new List<int>();

			for (int row = 0; row < BoardHeight; row++)
			{
				bool fullrow = true;
				for (int col = 0; col < BoardWidth; col++)
				{
					if (_cells[row, col] == CellType.Empty)
					{
						fullrow = false;
						break;
					}
				}
				if (fullrow) fullRows.Add(row);
			}

			// Удаляем со смещением всех остальных рядов вниз
			foreach (int frow in fullRows)
			{
				for (int row = frow - 1; row > 0; row--)
				{
					// Смещаем row = row + 1
					for (int col = 0; col < BoardWidth; col++)
					{
						_cells[row + 1, col] = _cells[row, col];
						// Прошлый ряд пуст, следовательно, все выше лежащие так же пусты
						if (IsRowEmpty(row + 1)) break;
					}
				}
			}

			return BoardWidth * fullRows.Count; // Возвращаем количество уничтоженных клеток
		}

		/// <summary>Проверка ряда на пустые клетки.</summary>
		/// <param name="row">Ряд, в котором проверяется все клетки.</param>
		/// <returns>Возвращается истина - если в ряду есть пустая клетка, ложь - если в ряду все клетки заполненные.</returns>
		protected bool IsRowEmpty(int row)
		{
			for (int col = 0; col < BoardWidth; col++)
			{
				if (_cells[row, col] != CellType.Empty) return false;
			}
			return true;
		}

		/// <summary>Очищает поле от всех фигур.</summary>
		public virtual void Clear()
		{
			for (int row = 0; row < BoardHeight; row++)
			{
				for (int col = 0; col < BoardWidth; col++)
				{
					SetCell(row, col, CellType.Empty);
				}
			}
		}

		#endregion


		#region Отрисовка
		/// <summary>Отрисовка фигуры.</summary>
		/// <param name="g">Поверхность рисования для фигуры.</param>
		public virtual void Paint(Graphics g)
		{
			// рамка во круг игрового поля
			//Pen borderPen = new Pen(Tetris.Properties.Game.Default.BorderColor, 2);
			//g.DrawRectangle(borderPen, 3, 3, BoardWidth * CellSize + 7, BoardHeight * CellSize + 6);

			// цвет пустой клетки
			//Brush sbWall = new SolidBrush(Color.FromArgb(35, 0, 0, 0));
			Brush sbWall = new SolidBrush(Color.FromArgb(35, 0, 0, 0));

			switch (Tetris.Properties.Settings.Default.Quality)
			{
				case 0: PaintBlackShape(g); break;
				case 2: PaintSpriteShape(g, sbWall); break;
				default: // цветные нарисованные программно фигуры
					{
					for (int row = 0; row < BoardHeight; row++)
					{
						for (int col = 0; col < BoardWidth; col++)
						{
							Rectangle tileDraw = new Rectangle(7 + col * CellSize, 7 + row * CellSize, CellSize - 2, CellSize - 2);

							// маленький квадратик внутри фигуры
							Rectangle tileSmall = new Rectangle(10 + col * CellSize, 10 + row * CellSize, CellSize - 8, CellSize - 8);
							Pen p = new Pen(Tetris.Properties.Settings.Default.BackColor, 2);

							switch (_cells[row, col])
							{
								case CellType.Blue:
									g.FillRectangle(Brushes.Blue, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Green:
									g.FillRectangle(Brushes.Green, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Yellow:
									g.FillRectangle(Brushes.Gold, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Purple:
									g.FillRectangle(Brushes.Purple, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Orange:
									g.FillRectangle(Brushes.Orange, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Red:
									g.FillRectangle(Brushes.Red, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.LightBlue:
									g.FillRectangle(Brushes.Aqua, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
								case CellType.Empty:
								case CellType.Wall:
									g.FillRectangle(sbWall, tileDraw);
									g.DrawRectangle(p, tileSmall);
									break;
							}
						}
					}
					break;
				}
			}
		}

		/// <summary>Заполнение поля прозрачными черными фигурами и закраска самой фигуры.</summary>
		/// <param name="g">Поверхность рисования для фигуры.</param>
		private void PaintBlackShape(Graphics g)
		{
			for (int row = 0; row < BoardHeight; row++)
			{
				for (int col = 0; col < BoardWidth; col++)
				{
					if (_cells[row, col] == CellType.Wall) continue;

					Rectangle tileDraw = new Rectangle(7 + col * CellSize, 7 + row * CellSize, CellSize - 2, CellSize - 2);
					Rectangle tileSmall = new Rectangle(10 + col * CellSize, 10 + row * CellSize, CellSize - 8, CellSize - 8);

					Pen p = new Pen(Tetris.Properties.Settings.Default.BackColor, 2);
					SolidBrush b = new SolidBrush(Color.FromArgb(35, 0, 0, 0)); // прозрачный черный

					// закраска фона прозрачными квадратами
					if (_cells[row, col] == CellType.Empty)
					{
						g.FillRectangle(b, tileDraw);
						g.DrawRectangle(p, tileSmall);
					}
					else // заливка фигуры
					{
						g.FillRectangle(Brushes.Black, tileDraw);
						g.DrawRectangle(p, tileSmall);
					}
				}
			}
		}

		/// <summary>Заполнение поля фигурами из спрайта.</summary>
		/// <param name="g">Поверхность рисования для фигуры.</param>
		/// <param name="sbWall"></param>
		private void PaintSpriteShape(Graphics g, Brush sbWall)
		{
			for (int row = 0; row < BoardHeight; row++)
			{
				for (int col = 0; col < BoardWidth; col++)
				{
					if (_cells[row, col] == CellType.Wall) continue;

					Rectangle tileSprite = new Rectangle(7 + col * CellSize, 7 + row * CellSize, CellSize, CellSize);

					switch (_cells[row, col])
					{
						case CellType.Blue:      g.DrawImage(Blue, tileSprite); break;
						case CellType.Green:     g.DrawImage(Green, tileSprite); break;
						case CellType.Yellow:    g.DrawImage(Yellow, tileSprite); break;
						case CellType.Purple:    g.DrawImage(Purple, tileSprite); break;
						case CellType.Orange:    g.DrawImage(Orange, tileSprite); break;
						case CellType.Red:       g.DrawImage(Red, tileSprite); break;
						case CellType.LightBlue: g.DrawImage(LightBlue, tileSprite); break;
						case CellType.Empty:
						case CellType.Wall:
							g.DrawImage(BackField, tileSprite);
							break;
					}
				}
			}
		}
		/// <summary>Спрайты для игровых фигур.</summary>
		public static Bitmap LightBlue, Green, Purple, Blue, Orange, Red, Yellow, BackField, BackBox;

		#endregion
	}
}
