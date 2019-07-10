using System;
using System.Windows.Forms;

namespace Tetris.Data.GUI
{
	public partial class MenuPauseForm : Form
	{
		public MenuPauseForm()
		{
			InitializeComponent();
		}

		#region События
		/// <summary>Игра продолжается.</summary>
		private void BtContinue_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>Игра продолжается.</summary>
		private void MenuPauseForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
		}

		/// <summary>Открывается меню с настройками.</summary>
		private void BtSettings_Click(object sender, EventArgs e)
		{
			SettingsForm.SettingsForm settings = new SettingsForm.SettingsForm();
			settings.ShowDialog();
		}

		/// <summary>Завершение текущей игры.</summary>
		private void BtConcede_Click(object sender, EventArgs e)
		{
			// предупреждение и закрытие
			DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите завершить текущую игру?\nРезультат не будет сохранен.", "Завершение игры", MessageBoxButtons.YesNo);
			switch (dialogResult)
			{
				case DialogResult.Yes:
					Form gameForm = Application.OpenForms[2];// закрываем форму с игрой
					gameForm.Close();
					Close(); // закрываем форму с паузой
					break;
				case DialogResult.No: break;
			}
		}
		#endregion
	}
}
