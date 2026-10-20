using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormBangunRuang
{
	public partial class formcylinder : Form
	{
		public formcylinder()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 shape = new Form1();
			shape.Show();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double h, r, CSA, volume;

			bool isHValid = double.TryParse(textBox4.Text, out h);
			bool isRValid = double.TryParse(textBox1.Text, out r);

			if (isHValid && isRValid)
			{

				CSA = 2 * Math.PI * r * h;
				volume = Math.PI * Math.Pow(r, 2) * h;

				textBox3.Text = volume.ToString();
				textBox3.ReadOnly = true;

				textBox2.Text = CSA.ToString();
				textBox2.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai h dan r dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);


				if (!isHValid) textBox4.Focus();
				else if (!isRValid) textBox1.Focus();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}