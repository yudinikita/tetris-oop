namespace Tetris.Data.GUI.UserControl
{
	partial class FUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserControl));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.btnEntry = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegistr = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassReg = new System.Windows.Forms.TextBox();
			this.tbLoginReg = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbPass);
			this.groupBox1.Controls.Add(this.tbLogin);
			this.groupBox1.Controls.Add(this.btnEntry);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 133);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Вход";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Никнейм";
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(91, 57);
			this.tbPass.MaxLength = 100;
			this.tbPass.Name = "tbPass";
			this.tbPass.PasswordChar = '•';
			this.tbPass.Size = new System.Drawing.Size(120, 26);
			this.tbPass.TabIndex = 2;
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(91, 25);
			this.tbLogin.MaxLength = 12;
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(120, 26);
			this.tbLogin.TabIndex = 0;
			// 
			// btnEntry
			// 
			this.btnEntry.Location = new System.Drawing.Point(13, 89);
			this.btnEntry.Name = "btnEntry";
			this.btnEntry.Size = new System.Drawing.Size(198, 32);
			this.btnEntry.TabIndex = 3;
			this.btnEntry.Text = "Войти";
			this.btnEntry.UseVisualStyleBackColor = true;
			this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnRegistr);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbPassReg);
			this.groupBox2.Controls.Add(this.tbLoginReg);
			this.groupBox2.Location = new System.Drawing.Point(238, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(218, 133);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Регистрация";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Пароль";
			// 
			// btnRegistr
			// 
			this.btnRegistr.Location = new System.Drawing.Point(6, 89);
			this.btnRegistr.Name = "btnRegistr";
			this.btnRegistr.Size = new System.Drawing.Size(203, 32);
			this.btnRegistr.TabIndex = 6;
			this.btnRegistr.Text = "Зарегистрироваться";
			this.btnRegistr.UseVisualStyleBackColor = true;
			this.btnRegistr.Click += new System.EventHandler(this.BtnRegistr_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Никнейм";
			// 
			// tbPassReg
			// 
			this.tbPassReg.Location = new System.Drawing.Point(89, 54);
			this.tbPassReg.MaxLength = 100;
			this.tbPassReg.Name = "tbPassReg";
			this.tbPassReg.PasswordChar = '•';
			this.tbPassReg.Size = new System.Drawing.Size(120, 26);
			this.tbPassReg.TabIndex = 5;
			// 
			// tbLoginReg
			// 
			this.tbLoginReg.Location = new System.Drawing.Point(89, 22);
			this.tbLoginReg.MaxLength = 12;
			this.tbLoginReg.Name = "tbLoginReg";
			this.tbLoginReg.Size = new System.Drawing.Size(120, 26);
			this.tbLoginReg.TabIndex = 4;
			// 
			// FUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::Tetris.Properties.Settings.Default.Background;
			this.ClientSize = new System.Drawing.Size(465, 153);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FUserControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тетрис | Выбор пользователя";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Button btnEntry;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRegistr;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbPassReg;
		private System.Windows.Forms.TextBox tbLoginReg;
	}
}