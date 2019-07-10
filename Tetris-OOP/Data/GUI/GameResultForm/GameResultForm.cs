using System.Windows.Forms;
using Tetris.Data.Modules.Users;

namespace Tetris.Data.GUI.GameResultForm
{
	public partial class GameResultForm : Form
	{
		public GameResultForm()
		{
			InitializeComponent();
			btMenu.DialogResult = DialogResult.Cancel;
			btNewGame.DialogResult = DialogResult.OK;

			lbGameLevel.Text = Properties.Game.Default.GameLevel.ToString();
			lbGameTime.Text = Properties.Game.Default.GameTime.ToString("mm:ss");
			lbGameMoney.Text = Properties.Game.Default.GameMoney.ToString();
			lbGameScore.Text = Properties.Game.Default.CountScore.ToString();
			UserManager.CheckOnLevel();
		}
	}
}
