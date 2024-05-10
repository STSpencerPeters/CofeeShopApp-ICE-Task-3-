using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShopApp
{
    public class Order
    {
        //Variables to capture order
        public string customerName { get; set; }
        public string itemSelect { get; set; }
        public int quantity { get; set; }

        //Constants for menu items
        const int coffee = 20;
        const int tea = 15;
        const int cakes = 10;

        public int finalPrice = 0;

        public Order(string customerName, string itemSelect, int quantity)
        {
            this.customerName = customerName;
            this.itemSelect = itemSelect;
            this.quantity = quantity;
        }


        public void CalculateTotal(string itemSelect)
        {
            if (itemSelect.Equals("Coffee"))
            {
                this.finalPrice = this.quantity * coffee;
            }
            else if (itemSelect.Equals("Tea"))
            {
                finalPrice = quantity * tea;
            }
            else if (itemSelect.Equals("Cakes"))
            {
                finalPrice = quantity * cakes;
            }
        }

        public string DisplayReceipt()
        {
			return $"Customer Name: {customerName}\nOrder Item: {itemSelect}\nQuantity: {quantity}\n\nTotal: R{finalPrice}";
		}
    }
}
