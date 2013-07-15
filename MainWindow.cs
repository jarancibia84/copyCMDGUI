using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		//new ControllerGUI.confViaje ();
		string viaje = "{\"CMD\":15,\"DGV\":0,\"CHMOD\":1,}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", viaje);

	}

	protected void OnIniviajeButtonClicked (object sender, EventArgs e)
	{
		//INICIAR VIAJE
		string viaje = "{\"CMD\":15,\"DGV\":0,\"CHMOD\":1,}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", viaje);
	}


	protected void OnSleepButtonClicked (object sender, EventArgs e)
	{
		//PONER EN SLEEP
		string sleep = "{\"CMD\":15,\"DGV\":0,\"CHMOD\":0,}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", sleep);
	}

	protected void OnStatusClicked (object sender, EventArgs e)
	{
		//SOLICITAR STATUS
		string status = "{\"CMD\":20,\"DGV\":0}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", status);
	}

	protected void OnWconfigviajeButtonClicked (object sender, EventArgs e)
	{
		//CONFIGURAR VIAJE
		new ControllerGUI.confViaje ();
	}

	protected void OnRconfigviajeButtonClicked (object sender, EventArgs e)
	{
		//LEER CONFIGURACION DE VIAJE
		string rconfigviaje = "{\"CMD\":23,\"DGV\":0}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", rconfigviaje);
	}

	protected void OnWconfigsisButtonClicked (object sender, EventArgs e)
	{
		//COMPLETAR
		throw new NotImplementedException ();
	}

	protected void OnRconfigsisButtonClicked (object sender, EventArgs e)
	{
		//LEER CONFIGURACION SISTEMA
		string rconfigsis = "{\"CMD\":26,\"DGV\":0}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", rconfigsis);
	}

	protected void OnValonButtonClicked (object sender, EventArgs e)
	{
		//ABRIR VALVULA
		string valOn = "{\"CMD\":70,\"DGV\":0,\"STAT\":1}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", valOn);
	}

	protected void OnValOffButtonClicked (object sender, EventArgs e)
	{
		//cERRAR VALVULA
		string valOFF = "{\"CMD\":70,\"DGV\":0,\"STAT\":0}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", valOFF);
	}

	protected void OnScrubboffButtonClicked (object sender, EventArgs e)
	{
		//ACTIVAR SCRUBBER
		string scrubOn = "{\"CMD\":71,\"DGV\":0,\"TPSCRUB\":1,\"STAT\":1}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", scrubOn);
	}

	protected void OnScrubbonButtonClicked (object sender, EventArgs e)
	{
		//DES-ACTIVAR SCRUBBER
		string scrubOff = "{\"CMD\":71,\"DGV\":0,\"TPSCRUB\":1,\"STAT\":0}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", scrubOff);
	}

	protected void OnSincronismoButtonClicked (object sender, EventArgs e)
	{
		string year = DateTime.Now.Year.ToString ();
		string mes = DateTime.Now.Month.ToString ();
		if (mes.Length == 1) {mes = "0" + mes;}
		string dia = DateTime.Now.Day.ToString ();
		if (dia.Length == 1) {dia = "0" + dia;}
		string horas = DateTime.Now.Hour.ToString ();
		if (horas.Length == 1) {horas = "0" + horas;};
		string minutos = DateTime.Now.Minute.ToString ();
		if (minutos.Length == 1) {minutos = "0" + minutos;}
		string segundos = DateTime.Now.Second.ToString ();
		if (segundos.Length == 1) {segundos = "0" + minutos;}
		string fecha = year + mes + dia;
		string hora = horas + minutos + segundos;
		string sincronismo = "{\"CMD\":80,\"DGV\":0,\"DATE\":"+ fecha + ",\"TIME\":" + hora + "}";
		System.IO.File.WriteAllText (@"cmd\cmd.txt", sincronismo);

	}


	protected void OnButton33Clicked (object sender, EventArgs e)
	{
		new ControllerGUI.confViaje ();
	}


}
