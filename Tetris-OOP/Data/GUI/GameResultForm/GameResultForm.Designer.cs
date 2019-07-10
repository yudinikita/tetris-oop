namespace Tetris.Data.GUI.GameResultForm
{
	partial class GameResultForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResultForm));
			this.btMenu = new System.Windows.Forms.Button();
			this.btNewGame = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbGameTime = new System.Windows.Forms.Label();
			this.lbGameLevel = new System.Windows.Forms.Label();
			this.lbGameMoney = new System.Windows.Forms.Label();
			this.lbGameScore = new System.Windows.Forms.Label();
			this.lbScoreForNextLevel = new System.Windows.Forms.Label();
			this.lbScore = new System.Windows.Forms.Label();
			this.lbPlayerLevelPercent = new System.Windows.Forms.Label();
			this.lbPlayerLevel = new System.Windows.Forms.Label();
			this.prbPlayerLevel = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// btMenu
			// 
			this.btMenu.Location = new System.Drawing.Point(12, 309);
			this.btMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btMenu.Name = "btMenu";
			this.btMenu.Size = new System.Drawing.Size(112, 35);
			this.btMenu.TabIndex = 0;
			this.btMenu.Text = "В меню";
			this.btMenu.UseVisualStyleBackColor = true;
			// 
			// btNewGame
			// 
			this.btNewGame.Location = new System.Drawing.Point(129, 309);
			this.btNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btNewGame.Name = "btNewGame";
			this.btNewGame.Size = new System.Drawing.Size(112, 35);
			this.btNewGame.TabIndex = 0;
			this.btNewGame.Text = "Новая игра";
			this.btNewGame.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Получено очков";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Уровень игры";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(117, 268);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "/";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(47, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Уровень";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Время игры";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Получено денег";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label7.Location = new System.Drawing.Point(86, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 24);
			this.label7.TabIndex = 1;
			this.label7.Text = "Результат";
			// 
			// lbGameTime
			// 
			this.lbGameTime.BackColor = System.Drawing.Color.Transparent;
			this.lbGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbGameTime.Location = new System.Drawing.Point(154, 49);
			this.lbGameTime.Name = "lbGameTime";
			this.lbGameTime.Size = new System.Drawing.Size(87, 20);
			this.lbGameTime.TabIndex = 9;
			this.lbGameTime.Text = "0";
			this.lbGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbGameLevel
			// 
			this.lbGameLevel.BackColor = System.Drawing.Color.Transparent;
			this.lbGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbGameLevel.Location = new System.Drawing.Point(154, 84);
			this.lbGameLevel.Name = "lbGameLevel";
			this.lbGameLevel.Size = new System.Drawing.Size(87, 20);
			this.lbGameLevel.TabIndex = 9;
			this.lbGameLevel.Text = "0";
			this.lbGameLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbGameMoney
			// 
			this.lbGameMoney.BackColor = System.Drawing.Color.Transparent;
			this.lbGameMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbGameMoney.Location = new System.Drawing.Point(150, 119);
			this.lbGameMoney.Name = "lbGameMoney";
			this.lbGameMoney.Size = new System.Drawing.Size(91, 20);
			this.lbGameMoney.TabIndex = 9;
			this.lbGameMoney.Text = "0";
			this.lbGameMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbGameScore
			// 
			this.lbGameScore.BackColor = System.Drawing.Color.Transparent;
			this.lbGameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbGameScore.Location = new System.Drawing.Point(150, 154);
			this.lbGameScore.Name = "lbGameScore";
			this.lbGameScore.Size = new System.Drawing.Size(91, 20);
			this.lbGameScore.TabIndex = 9;
			this.lbGameScore.Text = "0";
			this.lbGameScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbScoreForNextLevel
			// 
			this.lbScoreForNextLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "scoreForNextLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbScoreForNextLevel.Location = new System.Drawing.Point(133, 268);
			this.lbScoreForNextLevel.Name = "lbScoreForNextLevel";
			this.lbScoreForNextLevel.Size = new System.Drawing.Size(108, 20);
			this.lbScoreForNextLevel.TabIndex = 12;
			this.lbScoreForNextLevel.Text = global::Tetris.Properties.Settings.Default.ScoreForNextLevel;
			this.lbScoreForNextLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbScore
			// 
			this.lbScore.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "UserScore", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbScore.Location = new System.Drawing.Point(11, 268);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(100, 20);
			this.lbScore.TabIndex = 13;
			this.lbScore.Text = global::Tetris.Properties.Settings.Default.UserScore;
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbPlayerLevelPercent
			// 
			this.lbPlayerLevelPercent.BackColor = System.Drawing.Color.Transparent;
			this.lbPlayerLevelPercent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "levelScorePerc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbPlayerLevelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbPlayerLevelPercent.Location = new System.Drawing.Point(192, 205);
			this.lbPlayerLevelPercent.Name = "lbPlayerLevelPercent";
			this.lbPlayerLevelPercent.Size = new System.Drawing.Size(49, 20);
			this.lbPlayerLevelPercent.TabIndex = 9;
			this.lbPlayerLevelPercent.Text = global::Tetris.Properties.Settings.Default.LevelScorePerc;
			this.lbPlayerLevelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbPlayerLevel
			// 
			this.lbPlayerLevel.BackColor = System.Drawing.Color.Transparent;
			this.lbPlayerLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tetris.Properties.Settings.Default, "Level", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lbPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPlayerLevel.Location = new System.Drawing.Point(12, 201);
			this.lbPlayerLevel.Name = "lbPlayerLevel";
			this.lbPlayerLevel.Size = new System.Drawing.Size(32, 24);
			this.lbPlayerLevel.TabIndex = 10;
			this.lbPlayerLevel.Text = global::Tetris.Properties.Settings.Default.Level;
			// 
			// prbPlayerLevel
			// 
			this.prbPlayerLevel.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", global::Tetris.Properties.Settings.Default, "LevelScoreMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.prbPlayerLevel.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Tetris.Properties.Settings.Default, "LevelScore", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.prbPlayerLevel.Location = new System.Drawing.Point(12, 240);
			this.prbPlayerLevel.Maximum = global::Tetris.Properties.Settings.Default.LevelScoreMax;
			this.prbPlayerLevel.Name = "prbPlayerLevel";
			this.prbPlayerLevel.Size = new System.Drawing.Size(229, 23);
			this.prbPlayerLevel.Step = 100;
			this.prbPlayerLevel.TabIndex = 8;
			this.prbPlayerLevel.Value = global::Tetris.Properties.Settings.Default.LevelScore;
			// 
			// GameResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 361);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbScoreForNextLevel);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.lbGameScore);
			this.Controls.Add(this.lbGameMoney);
			this.Controls.Add(this.lbGameLevel);
			this.Controls.Add(this.lbGameTime);
			this.Controls.Add(this.lbPlayerLevelPercent);
			this.Controls.Add(this.lbPlayerLevel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.prbPlayerLevel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btNewGame);
			this.Controls.Add(this.btMenu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "GameResultForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тетрис | Результат";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btMenu;
		private System.Windows.Forms.Button btNewGame;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbScoreForNextLevel;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label lbPlayerLevelPercent;
		private System.Windows.Forms.Label lbPlayerLevel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar prbPlayerLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbGameTime;
		private System.Windows.Forms.Label lbGameLevel;
		private System.Windows.Forms.Label lbGameMoney;
		private System.Windows.Forms.Label lbGameScore;
	}
}