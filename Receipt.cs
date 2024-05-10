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
	public partial class Receipt : Form
	{
		private List<Order> orderlist;
		public Receipt(List<Order> orders)
		{
			InitializeComponent();
			orderlist = orders;
			DisplayOrders();
		}

		private void bttnClose_Click(object sender, EventArgs e)
		{
			Close close = new Close();
			close.Show();
			this.Hide();
		}

		public void DisplayOrders()
		{
			lbReciept.Items.Clear();

			foreach (Order order in orderlist)
			{
				order.CalculateTotal(order.itemSelect);

				lbReciept.Items.Add(order.DisplayReceipt());
			}
		}

		private void lbReciept_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
