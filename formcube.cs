using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBangunRuang
{
	public partial class formcube : Form
	{
		public formcube()
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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double a, TSA, volume;

			if (double.TryParse(textBox1.Text, out a))
			{

				TSA = 6 * Math.Pow(a, 2);
				volume = Math.Pow(a, 3);

				textBox2.Text = TSA.ToString();
				textBox2.ReadOnly = true;
				textBox3.Text = volume.ToString();
				textBox3.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai a!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox1.Focus();
			}
		}
	}
}
