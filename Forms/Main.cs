using PickToLight.Core.Models;
using PickToLight.Core.Models.Enums;
using System.Windows.Forms;

namespace PickToLight.Client.WinForms.Forms {
	public partial class Main : Form {
		private readonly Controller controller;
		private readonly PickTag pickTag014;
		private readonly PickTag pickTag053;
		public Main() {
			InitializeComponent();
			controller = new(ControllerModel.AT500Plus, "192.168.1.11", 4660);
			pickTag014 = new PickTag() { NodeAddress = 14 };
			pickTag053 = new PickTag() { NodeAddress = 53 };
		}

		private void ButtonConnect_Click(object sender, System.EventArgs e) {
			controller.Connect();
		}

		private void ButtonDisconnect_Click(object sender, System.EventArgs e) {
			controller.Disconnect();
		}

		private void ButtonDisplay_Click(object sender, System.EventArgs e) {
			controller.Display("burcu", pickTag014);
			controller.Display("ferit", pickTag053);
		}

		private void ButtonClear_Click(object sender, System.EventArgs e) {
			controller.Clear();
		}
	}
}
