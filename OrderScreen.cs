namespace CofeeShopApp
{
    public partial class OrderScreen : Form
    {
		
		public OrderScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Confirmation confirm = new Confirmation();
            confirm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			List<Order> list = new List<Order>();

			Order order = new Order(tbEnterName.Text, cmbItemSelect.Text, int.Parse(txbQuantity.Text));
            list.Add(order);

            Receipt recieptForm = new Receipt(list);
            recieptForm.Show();

            this.Close();
        }
    }
}
