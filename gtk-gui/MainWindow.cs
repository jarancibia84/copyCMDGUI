
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button iniviajeButton;
	private global::Gtk.Button sleepButton;
	private global::Gtk.Button statusButton;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button wconfigviajeButton;
	private global::Gtk.Button rconfigviajeButton;
	private global::Gtk.Button wconfigsisButton;
	private global::Gtk.Button rconfigsisButton;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button valOffButton;
	private global::Gtk.Button valonButton;
	private global::Gtk.Button scrubboffButton;
	private global::Gtk.Button scrubbonButton;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Button sincronismoButton;
	private global::Gtk.Button descargaButton;
	private global::Gtk.Button borrardbButton;
	private global::Gtk.Button button26;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.iniviajeButton = new global::Gtk.Button ();
		this.iniviajeButton.WidthRequest = 100;
		this.iniviajeButton.HeightRequest = 70;
		this.iniviajeButton.CanFocus = true;
		this.iniviajeButton.Name = "iniviajeButton";
		this.iniviajeButton.UseUnderline = true;
		this.iniviajeButton.Label = global::Mono.Unix.Catalog.GetString ("Iniciar VIaje");
		this.hbox1.Add (this.iniviajeButton);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.iniviajeButton]));
		w1.Position = 0;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.sleepButton = new global::Gtk.Button ();
		this.sleepButton.WidthRequest = 100;
		this.sleepButton.CanFocus = true;
		this.sleepButton.Name = "sleepButton";
		this.sleepButton.UseUnderline = true;
		this.sleepButton.Label = global::Mono.Unix.Catalog.GetString ("Poner Sleep");
		this.hbox1.Add (this.sleepButton);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.sleepButton]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.statusButton = new global::Gtk.Button ();
		this.statusButton.WidthRequest = 100;
		this.statusButton.CanFocus = true;
		this.statusButton.Events = ((global::Gdk.EventMask)(16384));
		this.statusButton.Name = "statusButton";
		this.statusButton.UseUnderline = true;
		// Container child statusButton.Gtk.Container+ContainerChild
		global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w4 = new global::Gtk.HBox ();
		w4.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w5 = new global::Gtk.Image ();
		w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-connect", global::Gtk.IconSize.Menu);
		w4.Add (w5);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w7 = new global::Gtk.Label ();
		w7.LabelProp = global::Mono.Unix.Catalog.GetString ("STATUS");
		w7.UseUnderline = true;
		w4.Add (w7);
		w3.Add (w4);
		this.statusButton.Add (w3);
		this.hbox1.Add (this.statusButton);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.statusButton]));
		w11.Position = 2;
		w11.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.wconfigviajeButton = new global::Gtk.Button ();
		this.wconfigviajeButton.WidthRequest = 95;
		this.wconfigviajeButton.CanFocus = true;
		this.wconfigviajeButton.Name = "wconfigviajeButton";
		this.wconfigviajeButton.UseUnderline = true;
		this.wconfigviajeButton.Label = global::Mono.Unix.Catalog.GetString ("Conf. viaje");
		this.hbox2.Add (this.wconfigviajeButton);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.wconfigviajeButton]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.rconfigviajeButton = new global::Gtk.Button ();
		this.rconfigviajeButton.WidthRequest = 95;
		this.rconfigviajeButton.HeightRequest = 50;
		this.rconfigviajeButton.CanFocus = true;
		this.rconfigviajeButton.Name = "rconfigviajeButton";
		this.rconfigviajeButton.UseUnderline = true;
		this.rconfigviajeButton.Label = global::Mono.Unix.Catalog.GetString ("Leer conf viaje");
		this.hbox2.Add (this.rconfigviajeButton);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.rconfigviajeButton]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.wconfigsisButton = new global::Gtk.Button ();
		this.wconfigsisButton.WidthRequest = 95;
		this.wconfigsisButton.CanFocus = true;
		this.wconfigsisButton.Name = "wconfigsisButton";
		this.wconfigsisButton.UseUnderline = true;
		this.wconfigsisButton.Label = global::Mono.Unix.Catalog.GetString ("Conf. Sistema");
		this.hbox2.Add (this.wconfigsisButton);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.wconfigsisButton]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.rconfigsisButton = new global::Gtk.Button ();
		this.rconfigsisButton.WidthRequest = 99;
		this.rconfigsisButton.CanFocus = true;
		this.rconfigsisButton.Name = "rconfigsisButton";
		this.rconfigsisButton.Label = global::Mono.Unix.Catalog.GetString ("       Leer \nConfig Sistema");
		this.hbox2.Add (this.rconfigsisButton);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.rconfigsisButton]));
		w16.Position = 3;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Homogeneous = true;
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.valOffButton = new global::Gtk.Button ();
		this.valOffButton.WidthRequest = 95;
		this.valOffButton.HeightRequest = 50;
		this.valOffButton.CanFocus = true;
		this.valOffButton.Name = "valOffButton";
		this.valOffButton.UseUnderline = true;
		this.valOffButton.Label = global::Mono.Unix.Catalog.GetString ("Valv OFF");
		this.hbox3.Add (this.valOffButton);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.valOffButton]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.valonButton = new global::Gtk.Button ();
		this.valonButton.WidthRequest = 90;
		this.valonButton.CanFocus = true;
		this.valonButton.Name = "valonButton";
		this.valonButton.UseUnderline = true;
		this.valonButton.Label = global::Mono.Unix.Catalog.GetString ("Valv ON");
		this.hbox3.Add (this.valonButton);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.valonButton]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.scrubboffButton = new global::Gtk.Button ();
		this.scrubboffButton.WidthRequest = 90;
		this.scrubboffButton.CanFocus = true;
		this.scrubboffButton.Name = "scrubboffButton";
		this.scrubboffButton.UseUnderline = true;
		this.scrubboffButton.Label = global::Mono.Unix.Catalog.GetString ("Scrubber OFF");
		this.hbox3.Add (this.scrubboffButton);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.scrubboffButton]));
		w20.Position = 2;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.scrubbonButton = new global::Gtk.Button ();
		this.scrubbonButton.CanFocus = true;
		this.scrubbonButton.Name = "scrubbonButton";
		this.scrubbonButton.UseUnderline = true;
		this.scrubbonButton.Label = global::Mono.Unix.Catalog.GetString ("Scrubber ON");
		this.hbox3.Add (this.scrubbonButton);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.scrubbonButton]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.sincronismoButton = new global::Gtk.Button ();
		this.sincronismoButton.WidthRequest = 95;
		this.sincronismoButton.HeightRequest = 50;
		this.sincronismoButton.CanFocus = true;
		this.sincronismoButton.Name = "sincronismoButton";
		this.sincronismoButton.UseUnderline = true;
		this.sincronismoButton.Label = global::Mono.Unix.Catalog.GetString ("Sincronismo");
		this.hbox4.Add (this.sincronismoButton);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.sincronismoButton]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.descargaButton = new global::Gtk.Button ();
		this.descargaButton.WidthRequest = 95;
		this.descargaButton.CanFocus = true;
		this.descargaButton.Name = "descargaButton";
		this.descargaButton.UseUnderline = true;
		this.descargaButton.Label = global::Mono.Unix.Catalog.GetString ("Descargar \n   Fichas");
		this.hbox4.Add (this.descargaButton);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.descargaButton]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.borrardbButton = new global::Gtk.Button ();
		this.borrardbButton.WidthRequest = 95;
		this.borrardbButton.CanFocus = true;
		this.borrardbButton.Name = "borrardbButton";
		this.borrardbButton.UseUnderline = true;
		this.borrardbButton.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox4.Add (this.borrardbButton);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.borrardbButton]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.button26 = new global::Gtk.Button ();
		this.button26.WidthRequest = 95;
		this.button26.CanFocus = true;
		this.button26.Name = "button26";
		this.button26.UseUnderline = true;
		this.button26.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox4.Add (this.button26);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.button26]));
		w26.Position = 3;
		w26.Expand = false;
		w26.Fill = false;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w28.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 429;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.iniviajeButton.Clicked += new global::System.EventHandler (this.OnIniviajeButtonClicked);
		this.sleepButton.Clicked += new global::System.EventHandler (this.OnSleepButtonClicked);
		this.statusButton.Clicked += new global::System.EventHandler (this.OnStatusClicked);
		this.wconfigviajeButton.Clicked += new global::System.EventHandler (this.OnWconfigviajeButtonClicked);
		this.rconfigviajeButton.Clicked += new global::System.EventHandler (this.OnRconfigviajeButtonClicked);
		this.wconfigsisButton.Clicked += new global::System.EventHandler (this.OnWconfigsisButtonClicked);
		this.rconfigsisButton.Clicked += new global::System.EventHandler (this.OnRconfigsisButtonClicked);
		this.valOffButton.Clicked += new global::System.EventHandler (this.OnValOffButtonClicked);
		this.valonButton.Clicked += new global::System.EventHandler (this.OnValonButtonClicked);
		this.scrubboffButton.Clicked += new global::System.EventHandler (this.OnScrubboffButtonClicked);
		this.scrubbonButton.Clicked += new global::System.EventHandler (this.OnScrubbonButtonClicked);
		this.sincronismoButton.Clicked += new global::System.EventHandler (this.OnSincronismoButtonClicked);
	}
}