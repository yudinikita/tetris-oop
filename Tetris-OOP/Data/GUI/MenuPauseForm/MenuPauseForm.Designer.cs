namespace Tetris.Data.GUI
{
	partial class MenuPauseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPauseForm));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btContinue = new System.Windows.Forms.Button();
			this.btSettings = new System.Windows.Forms.Button();
			this.btConcede = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(62, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Пауза";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btContinue);
			this.panel1.Controls.Add(this.btSettings);
			this.panel1.Controls.Add(this.btConcede);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(190, 230);
			this.panel1.TabIndex = 2;
			// 
			// btContinue
			// 
			this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btContinue.Location = new System.Drawing.Point(20, 175);
			this.btContinue.Margin = new System.Windows.Forms.Padding(20);
			this.btContinue.Name = "btContinue";
			this.btContinue.Size = new System.Drawing.Size(150, 35);
			this.btContinue.TabIndex = 2;
			this.btContinue.Text = "Продолжить";
			this.btContinue.UseVisualStyleBackColor = true;
			this.btContinue.Click += new System.EventHandler(this.BtContinue_Click);
			// 
			// btSettings
			// 
			this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSettings.Location = new System.Drawing.Point(20, 125);
			this.btSettings.Margin = new System.Windows.Forms.Padding(20);
			this.btSettings.Name = "btSettings";
			this.btSettings.Size = new System.Drawing.Size(150, 35);
			this.btSettings.TabIndex = 1;
			this.btSettings.Text = "Настройки";
			this.btSettings.UseVisualStyleBackColor = true;
			this.btSettings.Click += new System.EventHandler(this.BtSettings_Click);
			// 
			// btConcede
			// 
			this.btConcede.BackColor = System.Drawing.Color.Brown;
			this.btConcede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btConcede.ForeColor = System.Drawing.Color.PapayaWhip;
			this.btConcede.Location = new System.Drawing.Point(20, 50);
			this.btConcede.Margin = new System.Windows.Forms.Padding(20);
			this.btConcede.Name = "btConcede";
			this.btConcede.Size = new System.Drawing.Size(150, 35);
			this.btConcede.TabIndex = 0;
			this.btConcede.Text = "Сдаться";
			this.btConcede.UseVisualStyleBackColor = false;
			this.btConcede.Click += new System.EventHandler(this.BtConcede_Click);
			// 
			// MenuPauseForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::Tetris.Properties.Settings.Default.Background;
			this.ClientSize = new System.Drawing.Size(215, 257);
			this.Controls.Add(this.panel1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MenuPauseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тетрис | Пауза";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPauseForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btContinue;
		private System.Windows.Forms.Button btSettings;
		private System.Windows.Forms.Button btConcede;
	}
}