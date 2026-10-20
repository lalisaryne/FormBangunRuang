namespace FormBangunRuang
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			formsquare shape = new formsquare();
			shape.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			formrectangle shape = new formrectangle();
			shape.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			formtriangle shape = new formtriangle();
			shape.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			formcircle shape = new formcircle();
			shape.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			formtrapezium shape = new formtrapezium();
			shape.Show();
			this.Hide();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			formcuboid shape = new formcuboid();
			shape.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			formcube shape = new formcube();
			shape.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			formcylinder shape = new formcylinder();
			shape.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			formcone shape = new formcone();
			shape.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			formsphere shape = new formsphere();
			shape.Show();
			this.Hide();
		}
	}
}
