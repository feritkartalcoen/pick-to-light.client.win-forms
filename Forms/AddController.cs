using PickToLight.Core.Models.Enums;
using System;
using System.Windows.Forms;
namespace PickToLight.Client.WinForms.Forms {
	public partial class AddController : Form {
		public string IpAddress { get; private set; } = string.Empty;
		public int Port { get; private set; }
		public ControllerModel ControllerModel { get; private set; }
		public int PickTagsCount { get; private set; }
		public AddController() {
			InitializeComponent();
			TextBoxIpAddress.Text = "192.168.1.11";
			TextBoxPort.Text = "4660";
			ComboBoxControllerModel.Items.AddRange(Enum.GetNames(typeof(ControllerModel)));
			ComboBoxControllerModel.SelectedIndex = 2;
			TextBoxPickTagsCount.Text = "120";
		}
		private void ButtonAccept_Click(object sender, EventArgs e) {
			IpAddress = TextBoxIpAddress.Text;
			Port = int.Parse(TextBoxPort.Text);
			ControllerModel = (ControllerModel)Enum.Parse(typeof(ControllerModel), ComboBoxControllerModel.Text);
			PickTagsCount = int.Parse(TextBoxPickTagsCount.Text);
			DialogResult = DialogResult.OK;
			Close();
		}
		private void ButtonCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}