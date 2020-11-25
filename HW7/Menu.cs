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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Play_Click(object sender, EventArgs e)
		{
			//this.Close();
			Doubler game = new Doubler();
			game.Show(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GuessNumber guess = new GuessNumber();
			guess.Show(this);
		}
	}
}
