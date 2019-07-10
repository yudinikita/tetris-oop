using System;
using System.Windows.Forms;
using Tetris.Data.Modules.Users;

namespace Tetris.Data.GUI.UserControl
{
	public partial class FUserControl : Form
	{
		public FUserControl()
		{
			InitializeComponent();
		}

		private void BtnEntry_Click(object sender, EventArgs e)
		{
			string name = tbLogin.Text;
			string pass = tbPass.Text;

			if (UserManager.Auth(name, pass)) Close();
			else MessageBox.Show("Неверный пароль или имя пользователя.", "Неверные данные.");
		}

		private void BtnRegistr_Click(object sender, EventArgs e)
		{
			string name = tbLoginReg.Text;
			string pass = tbPassReg.Text;

			UserManager.ChangeLastUser();
			UserManager.AddNewUser(name, UserManager._users.Count.ToString(), pass, "0","0", "1", "0", "0:00:00",0,0, "true");
			UserManager.Auth(name, pass);
			Close();
		}
	}
}
