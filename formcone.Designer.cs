namespace FormBangunRuang
{
	partial class formcone
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
			label1 = new Label();
			panel1 = new Panel();
			textBox5 = new TextBox();
			label6 = new Label();
			textBox4 = new TextBox();
			label5 = new Label();
			button3 = new Button();
			button2 = new Button();
			textBox3 = new TextBox();
			label4 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			panel2 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(309, 19);
			label1.Name = "label1";
			label1.Size = new Size(131, 54);
			label1.TabIndex = 0;
			label1.Text = "CONE";
			label1.Click += label1_Click;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(textBox5);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(textBox4);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(textBox3);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(31, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(743, 849);
			panel1.TabIndex = 1;
			panel1.Paint += panel1_Paint;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(178, 361);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(366, 39);
			textBox5.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(178, 323);
			label6.Name = "label6";
			label6.Size = new Size(95, 32);
			label6.TabIndex = 11;
			label6.Text = "Nilai h :";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(178, 260);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(366, 39);
			textBox4.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(178, 225);
			label5.Name = "label5";
			label5.Size = new Size(89, 32);
			label5.TabIndex = 9;
			label5.Text = "Nilai r :";
			// 
			// button3
			// 
			button3.BackColor = Color.ForestGreen;
			button3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = SystemColors.ButtonHighlight;
			button3.Location = new Point(506, 768);
			button3.Name = "button3";
			button3.Size = new Size(179, 60);
			button3.TabIndex = 8;
			button3.Text = "KEMBALI";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(192, 0, 0);
			button2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(44, 768);
			button2.Name = "button2";
			button2.Size = new Size(179, 60);
			button2.TabIndex = 7;
			button2.Text = "RESET";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(178, 688);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(366, 39);
			textBox3.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(178, 653);
			label4.Name = "label4";
			label4.Size = new Size(107, 32);
			label4.TabIndex = 5;
			label4.Text = "Volume :";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(178, 596);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(366, 39);
			textBox2.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(178, 561);
			label3.Name = "label3";
			label3.Size = new Size(69, 32);
			label3.TabIndex = 3;
			label3.Text = "CSA :";
			label3.Click += label3_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(192, 64, 0);
			button1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(251, 456);
			button1.Name = "button1";
			button1.Size = new Size(201, 69);
			button1.TabIndex = 2;
			button1.Text = "HITUNG";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(178, 162);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(366, 39);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(178, 127);
			label2.Name = "label2";
			label2.Size = new Size(87, 32);
			label2.TabIndex = 0;
			label2.Text = "Nilai l :";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(128, 64, 0);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(-1, -1);
			panel2.Name = "panel2";
			panel2.Size = new Size(742, 96);
			panel2.TabIndex = 13;
			// 
			// formcone
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(813, 889);
			Controls.Add(panel1);
			Name = "formcone";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "formcone";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Button button3;
		private Button button2;
		private TextBox textBox3;
		private Label label4;
		private TextBox textBox2;
		private Label label3;
		private Button button1;
		private TextBox textBox1;
		private Label label2;
		private TextBox textBox4;
		private Label label5;
		private TextBox textBox5;
		private Label label6;
		private Panel panel2;
	}
}