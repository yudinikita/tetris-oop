using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris.Data.GUI.SplashScreen
{
	public partial class SplashScreen : Form
	{
		private Timer _timer;

		public SplashScreen()
		{
			InitializeComponent();
			SetSettingsThisForm();
		}

		private void SetSettingsThisForm()
		{
			// делает форму прозрачной
			Color bgColor = Color.Red;
			BackColor = bgColor;
			TransparencyKey = bgColor;

			// убирает рамку
			FormBorderStyle = FormBorderStyle.None;

			// устанавливает картинку на заставку
			BackgroundImage = Properties.Resources.logo; // картинка на заставке
			BackgroundImageLayout = ImageLayout.Stretch; // картинка растягивается по всей форме
		}

		private void ShowMainForm()
		{
			_timer.Stop(); // после заданного времени оставливает таймер
			Hide(); // скрывает заставку
			new MainForm().ShowDialog(); // показывает главную форму
			Application.Exit();
		}

		private void SplashScreen_Shown(object sender, EventArgs e)
		{
			_timer = new Timer
			{
				Interval = 3000 // 1000 = 1 секунда
			};
			_timer.Start(); // запускаем отсчет
			_timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			ShowMainForm();
		}

		private void SplashScreen_Click(object sender, EventArgs e)
		{
			ShowMainForm();
		}
	}
}
