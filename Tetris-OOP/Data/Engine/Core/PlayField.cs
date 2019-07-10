using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Engine
{
	/// <summary>Представляет собой игровое поле.</summary> 
	public class PlayField : GameBoard
	{
		#region Переменные
		/// <summary>Текущая фигура на игровом поле.</summary>
		private GameShape Current;
		/// <summary>Если текущая фигура упала и можно добавлять новую, имеет значение false.</summary>
		public bool IsFigureFalling { get; private set; }

		/// <summary>Если true - показывает подсказку, куда упадет фигура</summary>
		private readonly bool ShowTips;
		#endregion


		/// <summary>Инициализирует игровое поле.</summary> 
		public PlayField(int height, int width) : base(height, width)
		{
			IsFigureFalling = false;
			ShowTips = true;
			Current = GameShape.Zero;
		}


		#region Действия с фигурой
		/// <summary>Помещает новую фигуру на верх поля.</summary>
		/// <param name="shape">Новая фигура.</param>
		/// <returns>true, если фигуру удалось полностью поместить на поле, иначе - false.</returns>
		public bool PlaceShape(GameShape shape)
		{
			shape = shape.MoveTo(0, BoardWidth / 2 - 1);
			int scs = SetFigure(shape, false);
			Current = shape;
			if (scs != 4) return false; // конец игры! 
			IsFigureFalling = true;
			return true;
		}

		/// <summary>Заменяет текущую фигуру на новую.</summary>
		/// <param name="newShape">Новая фигура.</param>
		/// <returns>Предыдущую фигуру или GameShape.Zero, если новую фигуру не удалось поместить.</returns>
		public GameShape ChangeFigure(GameShape newShape)
		{
			if (Current == GameShape.Zero) return Current;
			GameShape old = Current;
			EraseFigure(old);
			if (!PlaceShape(newShape))
				return GameShape.Zero;
			return old;
		}

		/// <summary>Поворачивает текущую фигуру по часовой стрелке.</summary>
		/// <returns>true в случае успеха и false - в случае неудачи.</returns>
		public bool RotateFigure()
		{
			if (Current == GameShape.Zero) return false;
			GameShape t = RotateFigure(Current);
			if (t == GameShape.Zero) return false;
			Current = t;
			return true;
		}

		/// <summary>Смещает фигуру вниз до предела.</summary>
		/// <returns>true в случае успеха и false - в случае неудачи</returns>
		public bool Drop()
		{
			if (Current == GameShape.Zero) return false;
			while (Current != GameShape.Zero)
				DoStep();
			return true;
		}


		/// <summary>Сдвигает фигуру.</summary>
		public void DoStep()
		{
			if (Current != GameShape.Zero)
			{
				IsFigureFalling = MoveDown(Current); // пытаемся сдвинуть вниз
				Current = IsFigureFalling ? Current.MoveDown() : GameShape.Zero;
				// если фигура упала, то передвигаем указатель, иначе двигать больше некуда и фигура опустилась
			}
			else IsFigureFalling = false;
		}

		#endregion

		#region Поворот фигуры
		/// <summary>Смещает фигуру влево.</summary>
		/// <returns>true в случае успеха и false - в случае неудачи.</returns>
		public bool MoveLeft()
		{
			if (Current == GameShape.Zero) return false;
			if (!MoveLeft(Current)) return false;
			Current = Current.MoveLeft();
			return true;
		}

		/// <summary>Смещает фигуру вправо.</summary>
		/// <returns>true в случае успеха и false - в случае неудачи.</returns>
		public bool MoveRight()
		{
			if (Current == GameShape.Zero) return false;
			if (!MoveRight(Current)) return false;
			Current = Current.MoveRight();
			return true;
		}

		/// <summary>Смещает фигуру вниз.</summary>
		/// <returns>true в случае успеха и false - в случае неудачи.</returns>
		public bool MoveDown()
		{
			if (Current == GameShape.Zero) return false;
			if (!MoveDown(Current)) return false;
			Current = Current.MoveDown();
			return true;
		}
		#endregion

		#region Действия с полем
		/// <summary>Очищает игровое поле.</summary>
		public override void Clear()
		{
			base.Clear();
			Current = GameShape.Zero;
			IsFigureFalling = false;
		}

		/// <summary>Очищает самую нижнию линию и смещает все клетки вниз.</summary>
		public void RemoveOneRows()
		{
			for (int i = 0; i < 10; i++)
			{
				_cells[BoardHeight - 1, i] = CellType.Empty;
			}

			// смещаем все клетки вниз
			for (int row = BoardHeight - 2; row > 0; row--)
			{
				for (int col = 0; col < BoardWidth; col++)
				{
					if (IsRowEmpty(row))
					{
						for (int i = 0; i < BoardWidth; i++)
						{
							_cells[row+1, i] = CellType.Empty;
						}
						goto LoopEnd;
					}
					_cells[row+1, col] = _cells[row, col];
				}
			}
			LoopEnd: ;
		}
		#endregion

		#region Рисование
		/// <summary>Рисование подсказки(тени от фигуры)</summary>
		/// <param name="g"></param>
		public override void Paint(Graphics g)
		{
			base.Paint(g);

			if (!ShowTips 
			    || !IsFigureFalling
			    || !Tetris.Properties.Settings.Default.ShadowShape) return;

			GameShape tip = Current;
			// временно удаляем текущую фигуру, потом всё вернём
			EraseFigure(Current);

			while (IsEmpty(tip)) // смещаем ниже, пока не натолкнёмся на препятствие
			{
				tip = tip.MoveDown();
			}

			tip = tip.MoveUp(); // натолкнулись, надо фигуру в последнее свободное место (оно выше)

			SetFigure(Current, false); // возвращаем, как и обещалось

			Point[] cells =
			{
				new Point(tip.X0, tip.Y0), new Point(tip.X1, tip.Y1),
				new Point(tip.X2, tip.Y2), new Point(tip.X3, tip.Y3)
			};

			// подсказка прозрачным квадратом
			Brush colorShadowPen = new SolidBrush(Color.FromArgb(70, 255,255,255));

			foreach (Point cell in cells)
			{
				if (!IsEmpty(cell.Y, cell.X)) continue;
				// подсказка прозрачным квадратом
				g.FillRectangle(colorShadowPen, 8 + cell.X * CellSize, 8 + cell.Y * CellSize, CellSize, CellSize);
			}
		}

		#endregion
	}
}