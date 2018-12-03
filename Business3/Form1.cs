using Business3.UserControlls;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Business3
{
	public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{

		}

		private void aceCustomers_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(ucCustomers.Instance))
			{
				container.Controls.Add(ucCustomers.Instance);
				ucCustomers.Instance.Dock = DockStyle.Fill;
				ucCustomers.Instance.BringToFront();
			}
			ucCustomers.Instance.BringToFront();
		}

		private void aceVehicles_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(ucVehicles.Instance))
			{
				container.Controls.Add(ucVehicles.Instance);
				ucVehicles.Instance.Dock = DockStyle.Fill;
				ucVehicles.Instance.BringToFront();
			}
			ucVehicles.Instance.BringToFront();
		}

		private void aceAddCustomer_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(ucAddCustomer.Instance))
			{
				container.Controls.Add(ucAddCustomer.Instance);
				ucAddCustomer.Instance.Dock = DockStyle.Fill;
				ucAddCustomer.Instance.BringToFront();
			}
		}

		private void aceAddProduct_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(ucAddVehicle.Instance))
			{
				container.Controls.Add(ucAddVehicle.Instance);
				ucAddVehicle.Instance.Dock = DockStyle.Fill;
				ucAddVehicle.Instance.BringToFront();
			}
		}
	}
}
