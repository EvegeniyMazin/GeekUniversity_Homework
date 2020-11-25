using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
	public partial class GuessNumber : Form
	{
		private int _rightAnswer;
		private Random rnd = new Random();
		private int _userAnswer;
		public GuessNumber()
		{
			InitializeComponent();
			_rightAnswer = rnd.Next(1, 100);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{

				_userAnswer = Convert.ToInt32(textBox1.Text);
				if (_userAnswer == _rightAnswer)
				{
					this.Hide();
					MessageBox.Show("You win!");
					this.Close();
				}
				else
				{
					if (_userAnswer > _rightAnswer)
					{
						MessageBox.Show("Your number is too big! Try again!");
						textBox1.Text = "";
					}
					else
					{
						MessageBox.Show("Your number is too small! Try again!");
						textBox1.Text = "";
					}
				}
			}
			catch { Exception pizdets; MessageBox.Show("It is not a number! Try again!"); }
		}
	}
}
