﻿namespace Business3.UserControlls
{
	partial class ucAddVehicle
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.textEdit2);
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.dateTimePicker1);
			this.layoutControl1.Controls.Add(this.textEdit4);
			this.layoutControl1.Controls.Add(this.textEdit3);
			this.layoutControl1.Controls.Add(this.textEdit1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 78, 650, 400);
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(486, 357);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(486, 357);
			this.Root.TextVisible = false;
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(132, 12);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(168, 20);
			this.textEdit1.StyleController = this.layoutControl1;
			this.textEdit1.TabIndex = 4;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.textEdit1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(292, 24);
			this.layoutControlItem1.Text = "Model name";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 98);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(466, 239);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// textEdit3
			// 
			this.textEdit3.Location = new System.Drawing.Point(132, 36);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Size = new System.Drawing.Size(342, 20);
			this.textEdit3.StyleController = this.layoutControl1;
			this.textEdit3.TabIndex = 6;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.textEdit3;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(466, 24);
			this.layoutControlItem3.Text = "VIN";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 13);
			// 
			// textEdit4
			// 
			this.textEdit4.Location = new System.Drawing.Point(132, 60);
			this.textEdit4.Name = "textEdit4";
			this.textEdit4.Size = new System.Drawing.Size(109, 20);
			this.textEdit4.StyleController = this.layoutControl1;
			this.textEdit4.TabIndex = 7;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.textEdit4;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(233, 24);
			this.layoutControlItem4.Text = "Price (USD)";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 13);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(365, 60);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(109, 21);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.dateTimePicker1;
			this.layoutControlItem5.Location = new System.Drawing.Point(233, 48);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(233, 24);
			this.layoutControlItem5.Text = "Date of manufacturing";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 13);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(12, 84);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(462, 22);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Add";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.simpleButton1;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(466, 26);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(424, 12);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Size = new System.Drawing.Size(50, 20);
			this.textEdit2.StyleController = this.layoutControl1;
			this.textEdit2.TabIndex = 10;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.textEdit2;
			this.layoutControlItem2.Location = new System.Drawing.Point(292, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(174, 24);
			this.layoutControlItem2.Text = "Color";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 13);
			// 
			// ucAddVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "ucAddVehicle";
			this.Size = new System.Drawing.Size(486, 357);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private DevExpress.XtraEditors.TextEdit textEdit4;
		private DevExpress.XtraEditors.TextEdit textEdit3;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}
