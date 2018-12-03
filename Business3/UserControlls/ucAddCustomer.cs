using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Business3.DataModel;

namespace Business3
{
	public partial class ucAddCustomer : DevExpress.XtraEditors.XtraUserControl
	{
		private static ucAddCustomer instance;
		public static ucAddCustomer Instance
		{
			get
			{
				if (instance == null)
					instance = new ucAddCustomer();
				return instance;
			}
		}
		
		public ucAddCustomer()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			using (BusinessContetx context = new BusinessContetx())
			{
				Customer customer = new Customer();

				customer.FirstName = textEdit1.Text;
				customer.LastName = textEdit2.Text;
				customer.Phone = Convert.ToInt64(textEdit3.Text);
				customer.Email = textEdit4.Text;
				customer.DoB = Convert.ToDateTime(dateTimePicker1.Text);

				context.Customers.Add(customer);
				
				context.SaveChanges();
			}
			
			
		}
	}
}
