using System;

namespace ControllerGUI
{
	public partial class confViaje : Gtk.Window
	{
		public confViaje () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

	
		protected void OnOkButtonClicked (object sender, EventArgs e)
		{
			string numViaje = viajeEntry.Text;
			string spo2 = spo2Entry.Text;
			string spco2Scrubb = spco2scrubbEntry.Text;
			string spco2 = spco2Entry.Text;
			string hs = hsEntry.Text;
			//string confVIaje = "holamundo";
			string confViaje = "{\"CMD\":10,\"DGV\":0,\"TRN\":" + numViaje + ",\"SPO2\":" + spo2 + ",\"HSO2\":" + hs + ",\"SPCO2.SCRUB\":" + spco2Scrubb +  ",\"HSCO2.SCRUB\":" + hs + ",\"SPCO2.VALV\":" + spco2 + ",\"HSCO2.VALV\":" + hs + ",\"TMAX\":400,\"INFO\":\"Informacion\"}";
			System.IO.File.WriteAllText (@"cmd\cmd.txt", confViaje);
			this.Destroy ();

		//{"CMD":10,"DGV":0,"TRN":1,"SPO2":3000,"HSO2":50,"SPCO2.SCRUB":5000,"HSCO2.SCRUB":50,"SPCO2.VALV":6000,"HSCO2.VALV":50,"TMAX":400,"INFO":"Informacion"}
		}




		protected void OnCancelButtonClicked (object sender, EventArgs e)
		{
			/*

				string numViaje = viajeEntry.Text;
				string spo2 = spo2Entry.Text;
				string spco2Scrubb = spco2scrubbEntry.Text;
				string spco2 = spco2Entry.Text;
				string hs = hsEntry.Text;
				//string confVIaje = "holamundo";
				string confViaje = "{\"CMD\":10,\"DGV\":0,\"TRN\":" + numViaje + ",\"SPO2\":" + spo2 + ",\"HSO2\":" + hs + ",\"SPCO2.SCRUB\":" + spco2Scrubb +  ",\"HSCO2.SCRUB\":" + hs + ",\"SPCO2.VALV\":" + spco2 + ",\"HSCO2.VALV\":" + hs + ",\"TMAX\":400,\"INFO\":\"Informacion\"}";
			System.IO.File.WriteAllText (@"cmd\cmd.txt", confViaje);
			*/
				this.Destroy ();


		}
	}
}

