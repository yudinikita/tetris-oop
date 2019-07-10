using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris.Data.GUI.AboutGame
{
	public partial class AboutGame : Form
	{
		public AboutGame()
		{
			InitializeComponent();
		}

		private void AboutGame_Load(object sender, EventArgs e)
		{

		}

		/// <summary>По нажатию на форму, закрываем ее.</summary>
		private void AboutGame_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
