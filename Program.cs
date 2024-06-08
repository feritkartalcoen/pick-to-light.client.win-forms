using PickToLight.Client.WinForms.Forms;
using System;
using System.Windows.Forms;

namespace PickToLight.Client.WinForms {
	internal static class Program {
		[STAThread]
		static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new Main());
		}
	}
}
