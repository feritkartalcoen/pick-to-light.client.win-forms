using PickToLight.Core.Models;
using System.Windows.Forms;
namespace PickToLight.Client.WinForms.Controls {
	public partial class PickTagControl : UserControl {
		public PickTag PickTag { get; set; }
		public PickTagControl(PickTag pickTag) {
			InitializeComponent();
			PickTag = pickTag;
			GroupBoxPickTag.Text = PickTag.NodeAddress.ToString("D3");
		}
	}
}