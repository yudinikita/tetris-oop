namespace Tetris.Data.GUI.UserStatistic
{
	partial class UserStatistic
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatistic));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbMaxPerGame = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbNumberOfGame = new System.Windows.Forms.Label();
			this.lbTimeInGame = new System.Windows.Forms.Label();
			this.lbScore = new System.Windows.Forms.Label();
			this.lbPlayerLevel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUserName = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbMoney = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.lbMaxPerGame);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.lbNumberOfGame);
			this.panel1.Controls.Add(this.lbTimeInGame);
			this.panel1.Controls.Add(this.lbMoney);
			this.panel1.Controls.Add(this.lbScore);
			this.panel1.Controls.Add(this.lbPlayerLevel);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lbUserName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 375);
			this.panel1.TabIndex = 0;
			// 
			// lbMaxPerGame
			// 
			this.lbMaxPerGame.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "UserRecord", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbMaxPerGame.Location = new System.Drawing.Point(196, 284);
			this.lbMaxPerGame.Name = "lbMaxPerGame";
			this.lbMaxPerGame.Size = new System.Drawing.Size(130, 20);
			this.lbMaxPerGame.TabIndex = 14;
			this.lbMaxPerGame.Text = global::Tetris.Properties.Settings.Default.UserRecord;
			this.lbMaxPerGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(68, 284);
			this.label8.Margin = new System.Windows.Forms.Padding(25, 0, 3, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "Рекорд за игру";
			// 
			// lbNumberOfGame
			// 
			this.lbNumberOfGame.Location = new System.Drawing.Point(196, 326);
			this.lbNumberOfGame.Name = "lbNumberOfGame";
			this.lbNumberOfGame.Size = new System.Drawing.Size(130, 20);
			this.lbNumberOfGame.TabIndex = 11;
			this.lbNumberOfGame.Text = "0";
			this.lbNumberOfGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTimeInGame
			// 
			this.lbTimeInGame.Location = new System.Drawing.Point(196, 242);
			this.lbTimeInGame.Name = "lbTimeInGame";
			this.lbTimeInGame.Size = new System.Drawing.Size(130, 20);
			this.lbTimeInGame.TabIndex = 10;
			this.lbTimeInGame.Text = "0";
			this.lbTimeInGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbScore
			// 
			this.lbScore.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "UserScore", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbScore.Location = new System.Drawing.Point(196, 116);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(130, 20);
			this.lbScore.TabIndex = 7;
			this.lbScore.Text = global::Tetris.Properties.Settings.Default.UserScore;
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPlayerLevel
			// 
			this.lbPlayerLevel.BackColor = System.Drawing.Color.Transparent;
			this.lbPlayerLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "Level", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbPlayerLevel.Location = new System.Drawing.Point(196, 198);
			this.lbPlayerLevel.Name = "lbPlayerLevel";
			this.lbPlayerLevel.Size = new System.Drawing.Size(130, 24);
			this.lbPlayerLevel.TabIndex = 9;
			this.lbPlayerLevel.Text = global::Tetris.Properties.Settings.Default.Level;
			this.lbPlayerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(61, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Количество игр";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(81, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Время в игре";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(143, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Очки";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(117, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Уровень";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(150, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Статистика";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Имя";
			// 
			// lbUserName
			// 
			this.lbUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "userName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbUserName.Location = new System.Drawing.Point(196, 74);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new System.Drawing.Size(130, 20);
			this.lbUserName.TabIndex = 7;
			this.lbUserName.Text = global::Tetris.Properties.Settings.Default.UserName;
			this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(135, 158);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 20);
			this.label7.TabIndex = 8;
			this.label7.Text = "Денег";
			// 
			// lbMoney
			// 
			this.lbMoney.Location = new System.Drawing.Point(196, 158);
			this.lbMoney.Name = "lbMoney";
			this.lbMoney.Size = new System.Drawing.Size(130, 20);
			this.lbMoney.TabIndex = 7;
			this.lbMoney.Text = "0";
			this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserStatistic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::Tetris.Properties.Settings.Default.Background;
			this.ClientSize = new System.Drawing.Size(424, 401);
			this.Controls.Add(this.panel1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "UserStatistic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тетрис | Статитистика";
			this.Load += new System.EventHandler(this.UserStatistic_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbUserName;
		private System.Windows.Forms.Label lbPlayerLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbMaxPerGame;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbNumberOfGame;
		private System.Windows.Forms.Label lbTimeInGame;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label lbMoney;
		private System.Windows.Forms.Label label7;
	}
}