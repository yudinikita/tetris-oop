using System.Drawing;
using System.Windows.Forms;

namespace Engine
{
	/// <summary>Представляет настройки приложения.</summary> 
	public class Settings
	{
		#region Переменные

		/// <summary>Текущее качество графики: 0 - низкая, 1 - средняя, 2 - высокая.</summary>
		private int _quality;

		/// <summary>Текущее состояние экрана.</summary>
		private FormWindowState _sizeScreen;

		/// <summary>Устаналивает или убирает рамку приложения.</summary>
		private bool _borderScreen;

		private FormBorderStyle _borderStyle;

		/// <summary>Устаналивает или убирает показ следующей фигуры.</summary>
		private bool _nextShape;

		/// <summary>Устаналивает или убирает тень от фигуры.</summary>
		private bool _shadowShape;

		#endregion


		public Settings()
		{
			Read();
		}


		#region Методы
		/// <summary>Получает параметры из файла с настройками.</summary>
		public void Read()
		{
			#region Игра
			_nextShape = Tetris.Properties.Settings.Default.NextShape;
			_shadowShape = Tetris.Properties.Settings.Default.ShadowShape;
			#endregion

			#region Графика
			_quality = Tetris.Properties.Settings.Default.Quality;
			_sizeScreen = Tetris.Properties.Settings.Default.SizeScreen;
			_borderScreen = Tetris.Properties.Settings.Default.BorderScreen;
			_borderStyle = Tetris.Properties.Settings.Default.BorderStyle;

			_borderStyle = _borderScreen ? FormBorderStyle.None : FormBorderStyle.Sizable;
			_borderStyle = Tetris.Properties.Settings.Default.BorderStyle;

			_sizeScreen = _borderScreen ? FormWindowState.Maximized : FormWindowState.Normal;
			_sizeScreen = Tetris.Properties.Settings.Default.SizeScreen;
			#endregion
		}

		/// <summary>Задает параметры из файла с настройками.</summary>
		public void Apply()
		{
			#region Игра
			Tetris.Properties.Settings.Default.NextShape = _nextShape;
			Tetris.Properties.Settings.Default.ShadowShape = _shadowShape;
			#endregion

			#region Графика
			Tetris.Properties.Settings.Default.Quality = _quality;
			Tetris.Properties.Settings.Default.BorderScreen = _borderScreen;

			_borderStyle = _borderScreen ? FormBorderStyle.None : FormBorderStyle.Sizable;
			Tetris.Properties.Settings.Default.BorderStyle = _borderStyle;

			_sizeScreen = _borderScreen ? FormWindowState.Maximized : FormWindowState.Normal;
			Tetris.Properties.Settings.Default.SizeScreen = _sizeScreen;
			#endregion

			Graphic();
			ControlsGame();
		}

		/// <summary>Сбрасывает значение настроек по умолчанию.</summary>
		public static void Reset()
		{
			Tetris.Properties.Settings.Default.Reset();
		}

		/// <summary>Устаналиваем управление, в зависимости от выбор в настройках</summary>
		private static void ControlsGame()
		{
			if (Tetris.Properties.Settings.Default.Arrow)
			{
				Tetris.Properties.Controls.Default.KeyDown = Keys.Down;
				Tetris.Properties.Controls.Default.KeyLeft = Keys.Left;
				Tetris.Properties.Controls.Default.KeyRight = Keys.Right;
				Tetris.Properties.Controls.Default.KeyUp = Keys.Up;
			}
			else if(Tetris.Properties.Settings.Default.WASD)
			{
				Tetris.Properties.Controls.Default.KeyDown = Keys.S;
				Tetris.Properties.Controls.Default.KeyLeft = Keys.A;
				Tetris.Properties.Controls.Default.KeyRight = Keys.D;
				Tetris.Properties.Controls.Default.KeyUp = Keys.W;
			}


		}

		/// <summary>Устанавливает настройки графики.</summary>
		private static void Graphic()
		{
			// если графика низкая, то фигуры черно-белые
			Tetris.Properties.Settings.Default.ShapeBlack = Tetris.Properties.Settings.Default.Quality == 0;
			Tetris.Properties.Settings.Default.SpriteShape = Tetris.Properties.Settings.Default.Quality == 2;
			Tetris.Properties.Settings.Default.BackColor 
				= Tetris.Properties.Settings.Default.Quality == 2 
				? Color.FromArgb(255, 25, 45, 75) 
				: Color.FromArgb(255, 156, 172, 135);
			Tetris.Properties.Settings.Default.Background
				= Tetris.Properties.Settings.Default.Quality == 2
					? Color.FromArgb(255, 0, 0, 64)
					: Color.FromArgb(255, 10, 150, 140);
		}

		#endregion
	}
}
