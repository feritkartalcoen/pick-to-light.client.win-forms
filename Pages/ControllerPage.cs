using PickToLight.Client.WinForms.Controls;
using PickToLight.Core.Models;
using PickToLight.Core.Models.Enums;
using System.Windows.Forms;
namespace PickToLight.Client.WinForms.Pages {
	public partial class ControllerPage : UserControl {
		private readonly Controller _controller;
		public ControllerPage(string ipAddress, int port, ControllerModel controllerModel, int pickTagsCount) {
			InitializeComponent();
			_controller = new(controllerModel, pickTagsCount, ipAddress, port);
			LabelIpAddressAndPort.Text = $"{ipAddress}:{port}";
			foreach (PickTag pickTag in _controller.PickTags) {
				TableLayoutPanelPickTags.Controls.Add(new PickTagControl(pickTag));
			}
		}
		private void ButtonConnect_Click(object sender, System.EventArgs e) {
			_controller.Connect();
		}
		private void ButtonDisconnect_Click(object sender, System.EventArgs e) {
			_controller.Disconnect();
		}
	}
}