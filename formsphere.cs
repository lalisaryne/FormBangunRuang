using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBangunRuang
{
	public partial class formsphere : Form
	{
		public formsphere()
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
			double r, SA, volume;

			if (double.TryParse(textBox1.Text, out r))
			{

				SA = 4 * Math.PI * Math.Pow(r, 2);
				volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

				textBox2.Text = SA.ToString();
				textBox2.ReadOnly = true;
				textBox3.Text = volume.ToString();
				textBox3.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai r!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox1.Focus();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
