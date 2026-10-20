using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBangunRuang
{
	public partial class formcone : Form
	{
		public formcone()
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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double l, r, h, CSA, volume;

			bool isLValid = double.TryParse(textBox1.Text, out l);
			bool isRValid = double.TryParse(textBox4.Text, out r);
			bool isHValid = double.TryParse(textBox5.Text, out h);

			if (isLValid && isRValid && isHValid)
			{

				CSA = Math.PI * r * l;
				volume = (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;


				textBox3.Text = volume.ToString();
				textBox3.ReadOnly = true;

				textBox2.Text = CSA.ToString();
				textBox2.ReadOnly = true;
			}
			else
			{
				MessageBox.Show("Tolong masukkan angka yang valid pada Nilai l, h dan r!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				if (!isLValid) textBox1.Focus();
				else if (!isRValid) textBox4.Focus();
				else if (!isHValid) textBox5.Focus();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
