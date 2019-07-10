namespace Tetris
{
	partial class GameForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.lbElapsedTime = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbScore = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnGame = new System.Windows.Forms.Panel();
			this.pbPauseOff = new System.Windows.Forms.PictureBox();
			this.pbPauseOn = new System.Windows.Forms.PictureBox();
			this.lbNowTime = new System.Windows.Forms.Label();
			this.lbLevel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbLinesDestroy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbGameField = new System.Windows.Forms.PictureBox();
			this.pbNextFigure = new System.Windows.Forms.PictureBox();
			this.pnUnderGameBoard = new System.Windows.Forms.Panel();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			this.RealTimer = new System.Windows.Forms.Timer(this.components);
			this.pnGame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPauseOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPauseOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGameField)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNextFigure)).BeginInit();
			this.SuspendLayout();
			// 
			// lbElapsedTime
			// 
			this.lbElapsedTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbElapsedTime.Location = new System.Drawing.Point(250, 315);
			this.lbElapsedTime.Margin = new System.Windows.Forms.Padding(0);
			this.lbElapsedTime.Name = "lbElapsedTime";
			this.lbElapsedTime.Size = new System.Drawing.Size(96, 30);
			this.lbElapsedTime.TabIndex = 5;
			this.lbElapsedTime.Text = "00:00";
			this.lbElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(245, 290);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Прошло";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbScore
			// 
			this.lbScore.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbScore.Location = new System.Drawing.Point(250, 49);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(96, 30);
			this.lbScore.TabIndex = 3;
			this.lbScore.Text = "0";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(245, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Очки";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnGame
			// 
			this.pnGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnGame.BackColor = global::Tetris.Properties.Settings.Default.BackColor;
			this.pnGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnGame.Controls.Add(this.pbPauseOff);
			this.pnGame.Controls.Add(this.pbPauseOn);
			this.pnGame.Controls.Add(this.lbNowTime);
			this.pnGame.Controls.Add(this.lbLevel);
			this.pnGame.Controls.Add(this.label6);
			this.pnGame.Controls.Add(this.label4);
			this.pnGame.Controls.Add(this.lbLinesDestroy);
			this.pnGame.Controls.Add(this.label1);
			this.pnGame.Controls.Add(this.lbElapsedTime);
			this.pnGame.Controls.Add(this.label5);
			this.pnGame.Controls.Add(this.pbGameField);
			this.pnGame.Controls.Add(this.lbScore);
			this.pnGame.Controls.Add(this.label2);
			this.pnGame.Controls.Add(this.pbNextFigure);
			this.pnGame.Controls.Add(this.pnUnderGameBoard);
			this.pnGame.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnGame.Location = new System.Drawing.Point(12, 12);
			this.pnGame.Name = "pnGame";
			this.pnGame.Size = new System.Drawing.Size(364, 436);
			this.pnGame.TabIndex = 4;
			// 
			// pbPauseOff
			// 
			this.pbPauseOff.Image = ((System.Drawing.Image)(resources.GetObject("pbPauseOff.Image")));
			this.pbPauseOff.Location = new System.Drawing.Point(255, 406);
			this.pbPauseOff.Name = "pbPauseOff";
			this.pbPauseOff.Size = new System.Drawing.Size(16, 15);
			this.pbPauseOff.TabIndex = 14;
			this.pbPauseOff.TabStop = false;
			// 
			// pbPauseOn
			// 
			this.pbPauseOn.Image = global::Tetris.Properties.Resources.пауза;
			this.pbPauseOn.Location = new System.Drawing.Point(255, 406);
			this.pbPauseOn.Name = "pbPauseOn";
			this.pbPauseOn.Size = new System.Drawing.Size(16, 15);
			this.pbPauseOn.TabIndex = 13;
			this.pbPauseOn.TabStop = false;
			this.pbPauseOn.Visible = false;
			// 
			// lbNowTime
			// 
			this.lbNowTime.AutoSize = true;
			this.lbNowTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbNowTime.Location = new System.Drawing.Point(274, 398);
			this.lbNowTime.Margin = new System.Windows.Forms.Padding(0);
			this.lbNowTime.Name = "lbNowTime";
			this.lbNowTime.Size = new System.Drawing.Size(72, 29);
			this.lbNowTime.TabIndex = 11;
			this.lbNowTime.Text = "20:04";
			this.lbNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbLevel
			// 
			this.lbLevel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbLevel.Location = new System.Drawing.Point(250, 109);
			this.lbLevel.Margin = new System.Windows.Forms.Padding(0);
			this.lbLevel.Name = "lbLevel";
			this.lbLevel.Size = new System.Drawing.Size(96, 30);
			this.lbLevel.TabIndex = 10;
			this.lbLevel.Text = "1";
			this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(245, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Уровень";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(245, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Далее";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbLinesDestroy
			// 
			this.lbLinesDestroy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbLinesDestroy.Location = new System.Drawing.Point(250, 169);
			this.lbLinesDestroy.Name = "lbLinesDestroy";
			this.lbLinesDestroy.Size = new System.Drawing.Size(96, 30);
			this.lbLinesDestroy.TabIndex = 7;
			this.lbLinesDestroy.Text = "0";
			this.lbLinesDestroy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(245, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Линий";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbGameField
			// 
			this.pbGameField.BackColor = global::Tetris.Properties.Settings.Default.BackColor;
			this.pbGameField.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pbGameField.Location = new System.Drawing.Point(10, 10);
			this.pbGameField.Name = "pbGameField";
			this.pbGameField.Size = new System.Drawing.Size(214, 417);
			this.pbGameField.TabIndex = 0;
			this.pbGameField.TabStop = false;
			this.pbGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.PbGameField_Paint);
			// 
			// pbNextFigure
			// 
			this.pbNextFigure.BackColor = global::Tetris.Properties.Settings.Default.BackColor;
			this.pbNextFigure.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pbNextFigure.Location = new System.Drawing.Point(250, 232);
			this.pbNextFigure.Name = "pbNextFigure";
			this.pbNextFigure.Size = new System.Drawing.Size(96, 50);
			this.pbNextFigure.TabIndex = 1;
			this.pbNextFigure.TabStop = false;
			this.pbNextFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.PbNextFigure_Paint);
			// 
			// pnUnderGameBoard
			// 
			this.pnUnderGameBoard.BackColor = System.Drawing.Color.Black;
			this.pnUnderGameBoard.Location = new System.Drawing.Point(7, 7);
			this.pnUnderGameBoard.Name = "pnUnderGameBoard";
			this.pnUnderGameBoard.Size = new System.Drawing.Size(220, 423);
			this.pnUnderGameBoard.TabIndex = 12;
			// 
			// GameTimer
			// 
			this.GameTimer.Interval = 1000;
			this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
			// 
			// RealTimer
			// 
			this.RealTimer.Enabled = true;
			this.RealTimer.Interval = 1000;
			this.RealTimer.Tick += new System.EventHandler(this.RealTimer_Tick);
			// 
			// GameForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::Tetris.Properties.Settings.Default.Background;
			this.ClientSize = new System.Drawing.Size(384, 461);
			this.Controls.Add(this.pnGame);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::Tetris.Properties.Settings.Default, "SizeScreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::Tetris.Properties.Settings.Default, "BorderStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = global::Tetris.Properties.Settings.Default.BorderStyle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Тетрис | Игра";
			this.WindowState = global::Tetris.Properties.Settings.Default.SizeScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
			this.pnGame.ResumeLayout(false);
			this.pnGame.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPauseOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPauseOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGameField)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNextFigure)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbGameField;
		private System.Windows.Forms.PictureBox pbNextFigure;
		private System.Windows.Forms.Label lbElapsedTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnGame;
		private System.Windows.Forms.Timer GameTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbLinesDestroy;
		private System.Windows.Forms.Label lbNowTime;
		private System.Windows.Forms.Label lbLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pnUnderGameBoard;
		private System.Windows.Forms.Timer RealTimer;
		private System.Windows.Forms.PictureBox pbPauseOn;
		private System.Windows.Forms.PictureBox pbPauseOff;
	}
}

