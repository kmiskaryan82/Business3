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

namespace Business3
{
	public partial class ucCustomers : DevExpress.XtraEditors.XtraUserControl
	{
		private static ucCustomers instance;
		public static ucCustomers Instance
		{
			get
			{
				if (instance == null)
					instance = new ucCustomers();
				return instance;
			}
		}
		public ucCustomers()
		{
			InitializeComponent();
		}

		private void ucCustomers_Load(object sender, EventArgs e)
		{
			Business1Entities db = new Business1Entities();
			gridControl1.DataSource = db.Customer_Tb.ToList();

		}
	}
}
