using System;
using System.Drawing;
using Engine;
using System.Windows.Forms;

namespace Tetris.Data.GUI.SettingsForm
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private readonly Settings _settings = new Settings();

		#region События
		/// <summary>Открытие и загрузка формы</summary>
		private void SettingsForm_Load(object sender, EventArgs e)
		{
			// ставим выделенный элемент в списке из того, что сейчас установлено
			cbGraphics.SelectedIndex = Properties.Settings.Default.Quality;
		}

		/// <summary>Сохраняет выбранные настройки</summary>
		private void BtSave_Click(object sender, EventArgs e)
		{
			_settings.Read();
			_settings.Apply();
			Properties.Settings.Default.Save();
		}

		/// <summary>Сбрасывает все настройки по умолчанию.</summary>
		private void BtReset_Click(object sender, EventArgs e)
		{
			Settings.Reset();
			cbGraphics.SelectedIndex = Properties.Settings.Default.Quality;
		}

		/// <summary>Закрытие формы с настройками</summary>
		private void BtBack_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion


		#region Изменения
		/// <summary>При каждом изменении перезаписывает данные в настройки.</summary>
		private void CbFullScreen_CheckedChanged(object sender, EventArgs e)
		{
			_settings.Read();
		}

		/// <summary>Открывает диалоговое окно с выбором фонового цвета.</summary>
		private void PbColorBackground_Click(object sender, EventArgs e)
		{
			ColorDialog clrDlg = new ColorDialog();
			if (clrDlg.ShowDialog() == DialogResult.OK) Properties.Settings.Default.Background = clrDlg.Color;
		}

		/// <summary>Открывает диалоговое окно с выбором цвета игрового поля.</summary>
		private void PbColorField_Click(object sender, EventArgs e)
		{
			ColorDialog clrDlg = new ColorDialog();
			if (clrDlg.ShowDialog() == DialogResult.OK) Properties.Settings.Default.BackColor = clrDlg.Color;
		}

		/// <summary>При выборе графики из списка в меню, меняется значение в настройках.</summary>
		private void CbGraphics_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Quality = cbGraphics.SelectedIndex;

			pGraphicsMedium.Visible = cbGraphics.SelectedIndex == 1;
		}

		/// <summary>Выбор клавиши для поворота фигуры.</summary>
		private void BtInputKeyRotate_Click(object sender, EventArgs e)
		{
			Keys k = Properties.Controls.Default.KeyRotate;

			// создаем форму, в которой покажем выбранную кнопку для поворота фигуры
			using (Form formInputKey = new Form())
			{
				formInputKey.Text = @"Выбор кнопки поворота";
				formInputKey.StartPosition = FormStartPosition.CenterScreen;
				formInputKey.Size = new Size(170, 130);
				formInputKey.Font = new Font("Arial", 14, FontStyle.Bold);
				formInputKey.KeyPreview = true;
				formInputKey.FormBorderStyle = FormBorderStyle.None;
				formInputKey.BackColor = Color.DarkGray;

				Panel pnButtons = new Panel
				{
					BackColor = Color.DarkGray,
					Size = new Size(80, 60),
					Location = new Point(45, 50)
				};

				Label lbInputKey = new Label
				{
					Text = Convert.ToString(Properties.Controls.Default.KeyRotate),
					Location = new Point(30, 20),
					TextAlign = ContentAlignment.MiddleCenter
				};

				Button btOk = new Button
				{
					Text = @"Принять",
					Font = new Font("Arial", 10, FontStyle.Regular),
					Size = new Size(80, 28),
					TabStop = false
				};

				Button btCancel = new Button()
				{
					Text = @"Отмена",
					Font = new Font("Arial", 10, FontStyle.Regular),
					Size = new Size(80, 28),
					Location = new Point(0, 32),
					TabStop = false
				};

				formInputKey.Controls.Add(pnButtons);
				formInputKey.Controls.Add(lbInputKey);
				pnButtons.Controls.Add(btOk);
				pnButtons.Controls.Add(btCancel);

				btCancel.Click += delegate
				{
					formInputKey.Close();
				};

				btOk.Click += delegate
				{
					Properties.Controls.Default.KeyRotate = k;
					formInputKey.Close();
				};

				formInputKey.KeyDown += delegate(object o, KeyEventArgs args)
				{
					k = args.KeyData;
					lbInputKey.Text = args.KeyData.ToString();
				};

				formInputKey.ShowDialog();
			}
		}

		/// <summary>Активирует чит из введенной комбинации.</summary>
		private void BtActivateCheat_Click(object sender, EventArgs e)
		{
			switch (mtbCodes.Text)
			{
				case "11-100":
					Properties.Game.Default.CountScore += 1000;
					MessageBox.Show("очки +1000", "Чит активирован");
					break;
				case "10-1":
					Properties.Game.Default.CountScore = 0;
					MessageBox.Show("очки = 0", "Чит активирован");
					break;
				case "21-1":
					Properties.Game.Default.CheatLine = true;
					MessageBox.Show("все фигуры - палки", "Чит активирован");
					break;
				case "21-2":
					Properties.Game.Default.CheatSquare = true;
					MessageBox.Show("все фигуры - квадраты", "Чит активирован");
					break;
				case "20-1":
					Properties.Game.Default.CheatSquare = false;
					Properties.Game.Default.CheatLine = false;
					MessageBox.Show("все фигуры - разные", "Чит активирован");
					break;
			}
		}
		#endregion

	}
}
