﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using Business3.DataModel;

namespace Business3
{
	static class Program
	{
		
		[STAThread]
		static void Main()
		{
			using (BusinessContetx context = new BusinessContetx())
			{
				Customer customer = new Customer();
				Vehicle vehicle = new Vehicle();

				context.Customers.Add(customer);
				context.Vehicles.Add(vehicle);
				context.SaveChanges();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			Application.Run(new Form1());
		}
	}
}