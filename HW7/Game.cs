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
	public partial class Doubler : Form
	{
		private int _k;
		private int _countclick;
		private Random rnd = new Random();
		private int _lastDo;
		private int _numberToReach;

		public void WinCheck() 
		{ 
			if(_k == _numberToReach)
			{
				this.Hide();
				MessageBox.Show("You win!");
				this.Close();
				_countclick = 0;
				_k = 0;
			}
		}
		public Doubler()
		{
			InitializeComponent();
			_numberToReach = rnd.Next(100, 900);
			label1.Text = $"Дойдите до числа: {Convert.ToString(_numberToReach)}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_countclick++;
			_lastDo = _k;
			_k++;
			CountViewer.Text = Convert.ToString(_k);
			ClickCount.Text = Convert.ToString($"Кол-во отданных команд: {_countclick}");
			WinCheck();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_countclick++;
			_lastDo = _k;
			_k *= 2;
			CountViewer.Text = Convert.ToString(_k);
			ClickCount.Text = Convert.ToString($"Кол-во отданных команд: {_countclick}");
			WinCheck();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_countclick=0;
			_k = 0;
			_lastDo = _k;
			CountViewer.Text = Convert.ToString(_k);
			ClickCount.Text = Convert.ToString($"Кол-во отданных команд: {_countclick}");
			_numberToReach = rnd.Next(100, 900);
			label1.Text = $"Дойдите до числа: {Convert.ToString(_numberToReach)}";
		}

		private void Undo_Click(object sender, EventArgs e)
		{
			_k = _lastDo;
			CountViewer.Text = Convert.ToString(_k);
		}
	}
}
