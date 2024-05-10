using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeeShopApp
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void bttnOrder_Click(object sender, EventArgs e)
		{
			OrderScreen order = new OrderScreen();
			order.Show();
			this.Hide();
		}

		private void bttnClose_Click(object sender, EventArgs e)
		{
			Close close = new Close();
			close.Show();
			this.Close();
		}

		private void bttnCompleteOrder_Click(object sender, EventArgs e)
		{
			List<Order> orders = new List<Order>();
			Receipt receipt = new Receipt(orders);
			receipt.Show();
			this.Hide();
		}
	}
}
