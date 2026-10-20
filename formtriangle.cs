using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBangunRuang
{
	public partial class formtriangle : Form
	{
		public formtriangle()
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
			textBox5.Clear();
			textBox6.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double h, b, a, c, area, perimeter;


			bool isHValid = double.TryParse(textBox1.Text, out h);
			bool isBValid = double.TryParse(textBox4.Text, out b);
			bool isAValid = double.TryParse(textBox6.Text, out a);
			bool isCValid = double.TryParse(textBox5.Text, out c);

			if (isHValid && isBValid && isAValid && isCValid)
			{

				area = 0.5 * b * h;
				perimeter = a + b + c;


				textBox3.Text = perimeter.ToString();
				textBox3.ReadOnly = true;

				textBox2.Text = area.ToString();
				textBox2.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai h, a, c dan b!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				if (!isHValid) textBox1.Focus();
				else if (!isBValid) textBox4.Focus();
				else if (!isAValid) textBox6.Focus();
				else if (!isCValid) textBox5.Focus();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
