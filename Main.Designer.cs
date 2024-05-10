namespace CofeeShopApp
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblHeading = new Label();
			bttnOrder = new Button();
			bttnCompleteOrder = new Button();
			bttnClose = new Button();
			SuspendLayout();
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Font = new Font("Segoe UI", 30F);
			lblHeading.Location = new Point(171, 32);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(241, 54);
			lblHeading.TabIndex = 0;
			lblHeading.Text = "Coffee Shop";
			// 
			// bttnOrder
			// 
			bttnOrder.Font = new Font("Segoe UI", 20F);
			bttnOrder.Location = new Point(193, 155);
			bttnOrder.Name = "bttnOrder";
			bttnOrder.Size = new Size(232, 62);
			bttnOrder.TabIndex = 1;
			bttnOrder.Text = "Order";
			bttnOrder.UseVisualStyleBackColor = true;
			bttnOrder.Click += bttnOrder_Click;
			// 
			// bttnCompleteOrder
			// 
			bttnCompleteOrder.Font = new Font("Segoe UI", 20F);
			bttnCompleteOrder.Location = new Point(193, 270);
			bttnCompleteOrder.Name = "bttnCompleteOrder";
			bttnCompleteOrder.Size = new Size(232, 62);
			bttnCompleteOrder.TabIndex = 2;
			bttnCompleteOrder.Text = "Complete Order";
			bttnCompleteOrder.UseVisualStyleBackColor = true;
			bttnCompleteOrder.Click += bttnCompleteOrder_Click;
			// 
			// bttnClose
			// 
			bttnClose.Font = new Font("Segoe UI", 20F);
			bttnClose.Location = new Point(193, 367);
			bttnClose.Name = "bttnClose";
			bttnClose.Size = new Size(232, 62);
			bttnClose.TabIndex = 3;
			bttnClose.Text = "Close";
			bttnClose.UseVisualStyleBackColor = true;
			bttnClose.Click += bttnClose_Click;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 580);
			Controls.Add(bttnClose);
			Controls.Add(bttnCompleteOrder);
			Controls.Add(bttnOrder);
			Controls.Add(lblHeading);
			Name = "Main";
			Text = "Main";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeading;
		private Button bttnOrder;
		private Button bttnCompleteOrder;
		private Button bttnClose;
	}
}