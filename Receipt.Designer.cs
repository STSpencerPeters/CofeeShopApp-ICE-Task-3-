namespace CofeeShopApp
{
	partial class Receipt
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
			label1 = new Label();
			lbReciept = new ListBox();
			bttnClose = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F);
			label1.Location = new Point(247, 45);
			label1.Name = "label1";
			label1.Size = new Size(154, 54);
			label1.TabIndex = 0;
			label1.Text = "Reciept";
			// 
			// lbReciept
			// 
			lbReciept.FormattingEnabled = true;
			lbReciept.ItemHeight = 15;
			lbReciept.Location = new Point(164, 136);
			lbReciept.Name = "lbReciept";
			lbReciept.Size = new Size(327, 244);
			lbReciept.TabIndex = 1;
			lbReciept.SelectedIndexChanged += lbReciept_SelectedIndexChanged;
			// 
			// bttnClose
			// 
			bttnClose.Font = new Font("Segoe UI", 20F);
			bttnClose.Location = new Point(267, 406);
			bttnClose.Name = "bttnClose";
			bttnClose.Size = new Size(123, 53);
			bttnClose.TabIndex = 2;
			bttnClose.Text = "Close";
			bttnClose.UseVisualStyleBackColor = true;
			bttnClose.Click += bttnClose_Click;
			// 
			// Receipt
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(708, 533);
			Controls.Add(bttnClose);
			Controls.Add(lbReciept);
			Controls.Add(label1);
			Name = "Receipt";
			Text = "Receipt";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox lbReciept;
		private Button bttnClose;
	}
}