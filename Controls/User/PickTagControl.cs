namespace PickToLight.Client.WinForms.Controls.User {
    public partial class PickTagControl : UserControl {
        public Color HeaderColor {
            get {
                return GroupBoxPickTag.ForeColor;
            }
            set {
                GroupBoxPickTag.ForeColor = value;
                LabelValue.ForeColor = SystemColors.ControlText;
                Invalidate();
            }
        }
        public string NodeAddress {
            get {
                return GroupBoxPickTag.Text;
            }
            set {
                GroupBoxPickTag.Text = value;
                GroupBoxPickTag.Name = $"PickTag{value}";
                Invalidate();
            }
        }
        public string Value {
            get {
                return LabelValue.Text;
            }
            set {
                LabelValue.Text = value;
                Invalidate();
            }
        }
        public PickTagControl() {
            InitializeComponent();
        }
    }
}