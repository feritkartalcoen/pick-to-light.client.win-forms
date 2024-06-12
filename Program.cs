namespace PickToLight.Client.WinForms {
	using PickToLight.Client.WinForms.Forms;
	using System;
	using System.Windows.Forms;
	internal static class Program {
		#region Methods
		[STAThread]
		public static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
		#endregion
	}
}