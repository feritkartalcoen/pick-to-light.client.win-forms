using PickToLight.Client.WinForms.Controls.User;
using PickToLight.Core;
using PickToLight.Core.Utilities.Converters;
namespace PickToLight.Client.WinForms.Pages {
    public partial class ControllerPage : UserControl {
        public Controller controller = new();
        public List<PickTag> pickTags = PickTag.CreatePickTags(120);
        public ControllerPage() {
            InitializeComponent();
            controller.ReadAction += (ReceivedBytes) => {
                ListBoxReceivedBytes.Invoke(new Action(() => ListBoxReceivedBytes.Items.Add(CommunicationControlBlockConverter.ToString(ReceivedBytes))));
            };
            foreach (var pickTag in pickTags) {
                PickTagControl pickTagControl = new() {
                    NodeAddress = pickTag.NodeAddress.ToString("D3"),
                    HeaderColor = pickTag.IsConnected ? Color.Green : Color.Red,
                    Value = ValueConverter.BytesToStringDisplayValue(pickTag.Data)
                };
                TableLayoutPanelPickTagsControls.Controls.Add(pickTagControl);
            }
        }
        private async void ButtonConnect_Click(object sender, EventArgs e) {
            controller.Connect(ipAddress: TextBoxIpAddress.Text, int.Parse(TextBoxPort.Text));
            controller.GetConnectedPickTagsNodeAddresses();
            await Task.Delay(100);
            byte[] bytes = CommunicationControlBlockConverter.ToByte((string)(ListBoxReceivedBytes.Items[ListBoxReceivedBytes.Items.Count - 1]));
            byte[] data = new byte[32];
            for (int i = 0; i < 32; i++) {
                data[i] = bytes[i + 11];
            }
            DetectPickTags(data);
        }
        private void ButtonDisconnect_Click(object sender, EventArgs e) {
            ListBoxReceivedBytes.Items.Clear();
            controller.Clear();
            controller.Disconnect();
        }
        private List<int> DetectPickTags(byte[] DetectedPickTagsInformation) {
            List<int> ConnectedPickTags = [];
            for (int byteIndex = 0; byteIndex < DetectedPickTagsInformation.Length; byteIndex++) {
                byte currentByte = DetectedPickTagsInformation[byteIndex];
                for (int bitIndex = 0; bitIndex < 8; bitIndex++) {
                    if ((currentByte & (1 << bitIndex)) == 0) {
                        int deviceId = byteIndex * 8 + bitIndex + 1;
                        ConnectedPickTags.Add(deviceId);
                    }
                }
            }
            return ConnectedPickTags;
        }
    }
}