namespace Business3
{
	partial class Form1
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
			this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.aceProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.aceCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.aceAddCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.aceAddProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.container.Location = new System.Drawing.Point(177, 76);
			this.container.Margin = new System.Windows.Forms.Padding(2);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(476, 326);
			this.container.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
			this.accordionControl1.Location = new System.Drawing.Point(0, 30);
			this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(160, 372);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceProducts,
            this.aceCustomers,
            this.aceAddCustomer,
            this.aceAddProduct});
			this.accordionControlElement1.Expanded = true;
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Main";
			this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
			// 
			// aceProducts
			// 
			this.aceProducts.Name = "aceProducts";
			this.aceProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.aceProducts.Text = "Products";
			// 
			// aceCustomers
			// 
			this.aceCustomers.Name = "aceCustomers";
			this.aceCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.aceCustomers.Text = "Customers";
			this.aceCustomers.Click += new System.EventHandler(this.aceCustomers_Click);
			// 
			// aceAddCustomer
			// 
			this.aceAddCustomer.Name = "aceAddCustomer";
			this.aceAddCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.aceAddCustomer.Text = "Add new customer";
			// 
			// aceAddProduct
			// 
			this.aceAddProduct.Name = "aceAddProduct";
			this.aceAddProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.aceAddProduct.Text = "Add new product";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(653, 30);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 402);
			this.ControlContainer = this.container;
			this.Controls.Add(this.container);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Business_App";
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement aceProducts;
		private DevExpress.XtraBars.Navigation.AccordionControlElement aceCustomers;
		private DevExpress.XtraBars.Navigation.AccordionControlElement aceAddCustomer;
		private DevExpress.XtraBars.Navigation.AccordionControlElement aceAddProduct;
	}
}

