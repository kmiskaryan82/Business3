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

namespace Business3.UserControlls
{
	public partial class ucAddVehicle : DevExpress.XtraEditors.XtraUserControl
	{
		private static ucAddVehicle instance;
		public static ucAddVehicle Instance
		{
			get
			{
				if (instance == null)
					instance = new ucAddVehicle();
				return instance;
			}
		}
		public ucAddVehicle()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			using (BusinessContetx context = new BusinessContetx())
			{
				Vehicle vehicle = new Vehicle();
				vehicle.ModelName = textEdit1.Text;
				vehicle.V_color = textEdit2.Text;
				vehicle.VIN = Convert.ToInt64(textEdit3.Text);
				vehicle.Price = Convert.ToInt32(textEdit4.Text);
				vehicle.DoM = Convert.ToDateTime(dateTimePicker1.Text);
				context.Vehicles.Add(vehicle);
				context.SaveChanges();
			}
		}
	}
}
