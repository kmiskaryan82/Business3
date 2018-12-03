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
	public partial class ucVehicles : DevExpress.XtraEditors.XtraUserControl
	{
		private static ucVehicles instance;
		public static ucVehicles Instance
		{
			get
			{
				if (instance == null)
					instance = new ucVehicles();
				return instance;
			}
		}
		public ucVehicles()
		{
			InitializeComponent();
		}

		private void ucVehicles_Load(object sender, EventArgs e)
		{
			BusinessContetx db = new BusinessContetx();
			gridControl1.DataSource = db.Vehicles.ToList();
		}
	}
}
