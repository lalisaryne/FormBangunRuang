using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBangunRuang
{
	public partial class formrectangle : Form
	{
		public formrectangle()
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
			double l, b, area, perimeter;


			bool isLValid = double.TryParse(textBox1.Text, out l);
			bool isBValid = double.TryParse(textBox4.Text, out b);

			if (isLValid && isBValid)
			{

				area = l * b;
				perimeter = 2 * (l + b);


				textBox3.Text = perimeter.ToString();
				textBox3.ReadOnly = true;

				textBox2.Text = area.ToString();
				textBox2.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai l dan b!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				if (!isLValid) textBox1.Focus();
				else if (!isBValid) textBox4.Focus();
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
