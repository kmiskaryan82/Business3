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
using System.Data.SqlClient;
using System.Configuration;
using Business3.DataModel;

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
			BusinessContetx db = new BusinessContetx();
			gridControl1.DataSource = db.Customers.ToList();

		}

		private void SaveXML_button_Click(object sender, EventArgs e)
		{
			SaveToXml();
		}

		void SaveToXml()
		{
			string connString = ConfigurationManager.ConnectionStrings["Business1Entities"].ConnectionString;
			SqlConnection con = new SqlConnection(connString);

			string ReadQuery = "SELECT * FROM [Business1].[dbo].[Customer_Tb]";
			con.Open();
			SqlCommand cmd = new SqlCommand(ReadQuery, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds);
			con.Close();
			string textXML = ds.GetXmlSchema();
			using (System.IO.StreamWriter file =
			new System.IO.StreamWriter(@"C:\Users\Karen\source\repos\Business3\Business3\Customers.xml"))
			{
				file.Write(textXML);
			}
			MessageBox.Show("Successfully Exported");
		}
	}
}
