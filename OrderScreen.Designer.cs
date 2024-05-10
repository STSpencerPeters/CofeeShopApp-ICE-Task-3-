namespace CofeeShopApp
{
    partial class OrderScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			lblItemSelect = new Label();
			bttnConfirm = new Button();
			lblOrderNumber = new Label();
			tbEnterName = new TextBox();
			lblEnterName = new Label();
			lblReciept = new Label();
			cmbItemSelect = new ComboBox();
			lblQuantity = new Label();
			txbQuantity = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F);
			label1.Location = new Point(219, 26);
			label1.Name = "label1";
			label1.Size = new Size(126, 54);
			label1.TabIndex = 0;
			label1.Text = "Order";
			label1.Click += label1_Click;
			// 
			// lblItemSelect
			// 
			lblItemSelect.AutoSize = true;
			lblItemSelect.Font = new Font("Segoe UI", 12F);
			lblItemSelect.Location = new Point(20, 172);
			lblItemSelect.Name = "lblItemSelect";
			lblItemSelect.Size = new Size(110, 21);
			lblItemSelect.TabIndex = 2;
			lblItemSelect.Text = "Select an Item:";
			// 
			// bttnConfirm
			// 
			bttnConfirm.Font = new Font("Segoe UI", 20F);
			bttnConfirm.Location = new Point(219, 306);
			bttnConfirm.Margin = new Padding(3, 2, 3, 2);
			bttnConfirm.Name = "bttnConfirm";
			bttnConfirm.Size = new Size(171, 50);
			bttnConfirm.TabIndex = 6;
			bttnConfirm.Text = "Confirm";
			bttnConfirm.UseVisualStyleBackColor = true;
			bttnConfirm.Click += button1_Click;
			// 
			// lblOrderNumber
			// 
			lblOrderNumber.Location = new Point(0, 0);
			lblOrderNumber.Name = "lblOrderNumber";
			lblOrderNumber.Size = new Size(88, 17);
			lblOrderNumber.TabIndex = 11;
			// 
			// tbEnterName
			// 
			tbEnterName.Location = new Point(336, 112);
			tbEnterName.Margin = new Padding(3, 2, 3, 2);
			tbEnterName.Name = "tbEnterName";
			tbEnterName.Size = new Size(146, 23);
			tbEnterName.TabIndex = 10;
			// 
			// lblEnterName
			// 
			lblEnterName.AutoSize = true;
			lblEnterName.Font = new Font("Segoe UI", 12F);
			lblEnterName.Location = new Point(20, 110);
			lblEnterName.Name = "lblEnterName";
			lblEnterName.Size = new Size(95, 21);
			lblEnterName.TabIndex = 9;
			lblEnterName.Text = "Enter Name:";
			// 
			// lblReciept
			// 
			lblReciept.AutoSize = true;
			lblReciept.Location = new Point(437, 306);
			lblReciept.Name = "lblReciept";
			lblReciept.Size = new Size(0, 15);
			lblReciept.TabIndex = 13;
			// 
			// cmbItemSelect
			// 
			cmbItemSelect.FormattingEnabled = true;
			cmbItemSelect.Items.AddRange(new object[] { "Coffee", "Tea", "Cakes" });
			cmbItemSelect.Location = new Point(336, 172);
			cmbItemSelect.Name = "cmbItemSelect";
			cmbItemSelect.Size = new Size(121, 23);
			cmbItemSelect.TabIndex = 14;
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI", 12F);
			lblQuantity.Location = new Point(20, 231);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(110, 21);
			lblQuantity.TabIndex = 15;
			lblQuantity.Text = "Enter quantity:";
			// 
			// txbQuantity
			// 
			txbQuantity.Location = new Point(336, 233);
			txbQuantity.Margin = new Padding(3, 2, 3, 2);
			txbQuantity.Name = "txbQuantity";
			txbQuantity.Size = new Size(146, 23);
			txbQuantity.TabIndex = 16;
			// 
			// OrderScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(637, 465);
			Controls.Add(txbQuantity);
			Controls.Add(lblQuantity);
			Controls.Add(cmbItemSelect);
			Controls.Add(lblReciept);
			Controls.Add(tbEnterName);
			Controls.Add(lblEnterName);
			Controls.Add(lblOrderNumber);
			Controls.Add(bttnConfirm);
			Controls.Add(lblItemSelect);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "OrderScreen";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label lblItemSelect;
        private Button bttnConfirm;
        private Label lblOrderNumber;
        private TextBox tbEnterName;
        private Label lblEnterName;
        private Label lblReciept;
		private ComboBox cmbItemSelect;
		private Label lblQuantity;
		private TextBox txbQuantity;
	}
}
