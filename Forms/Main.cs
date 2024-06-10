using PickToLight.Client.WinForms.Pages;
using System.Windows.Forms;
namespace PickToLight.Client.WinForms.Forms {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}
		private void ButtonAddController_Click(object sender, System.EventArgs e) {
			AddController addController = new();
			if (addController.ShowDialog() == DialogResult.OK) {
				var controllerPage = new ControllerPage(addController.IpAddress, addController.Port, addController.ControllerModel, addController.PickTagsCount);
				var tabPage = new TabPage($"Controller {TabControlControllers.TabPages.Count + 1}");
				tabPage.Controls.Add(controllerPage);
				tabPage.Padding = new Padding(3);
				controllerPage.Dock = DockStyle.Fill;
				TabControlControllers.TabPages.Add(tabPage);
			}
		}
		private void ButtonRemoveController_Click(object sender, System.EventArgs e) {
			if (TabControlControllers.TabPages.Count > 0) {
				TabControlControllers.TabPages.RemoveAt(TabControlControllers.TabPages.Count - 1);
			}
		}
	}
}