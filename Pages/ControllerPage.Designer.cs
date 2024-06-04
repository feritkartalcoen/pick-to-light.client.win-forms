namespace PickToLight.Client.WinForms.Pages {
    partial class ControllerPage {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        private void InitializeComponent() {
            TableLayoutPanelControllersPageControls = new TableLayoutPanel();
            GroupBoxConnection = new GroupBox();
            TableLayoutPanelConnectionControls = new TableLayoutPanel();
            LabelIpAddress = new Label();
            TextBoxIpAddress = new TextBox();
            LabelPort = new Label();
            TextBoxPort = new TextBox();
            ButtonConnect = new Button();
            ButtonDisconnect = new Button();
            GroupBoxPickTags = new GroupBox();
            TableLayoutPanelPickTagsControls = new TableLayoutPanel();
            ListBoxReceivedBytes = new ListBox();
            TableLayoutPanelControllersPageControls.SuspendLayout();
            GroupBoxConnection.SuspendLayout();
            TableLayoutPanelConnectionControls.SuspendLayout();
            GroupBoxPickTags.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelControllersPageControls
            // 
            TableLayoutPanelControllersPageControls.ColumnCount = 1;
            TableLayoutPanelControllersPageControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelControllersPageControls.Controls.Add(GroupBoxConnection, 0, 0);
            TableLayoutPanelControllersPageControls.Controls.Add(GroupBoxPickTags, 0, 1);
            TableLayoutPanelControllersPageControls.Controls.Add(ListBoxReceivedBytes, 0, 2);
            TableLayoutPanelControllersPageControls.Dock = DockStyle.Fill;
            TableLayoutPanelControllersPageControls.Location = new Point(0, 0);
            TableLayoutPanelControllersPageControls.Name = "TableLayoutPanelControllersPageControls";
            TableLayoutPanelControllersPageControls.RowCount = 3;
            TableLayoutPanelControllersPageControls.RowStyles.Add(new RowStyle());
            TableLayoutPanelControllersPageControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelControllersPageControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            TableLayoutPanelControllersPageControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelControllersPageControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelControllersPageControls.Size = new Size(1145, 680);
            TableLayoutPanelControllersPageControls.TabIndex = 0;
            // 
            // GroupBoxConnection
            // 
            GroupBoxConnection.AutoSize = true;
            GroupBoxConnection.Controls.Add(TableLayoutPanelConnectionControls);
            GroupBoxConnection.Dock = DockStyle.Fill;
            GroupBoxConnection.Location = new Point(3, 3);
            GroupBoxConnection.Name = "GroupBoxConnection";
            GroupBoxConnection.Size = new Size(1139, 53);
            GroupBoxConnection.TabIndex = 0;
            GroupBoxConnection.TabStop = false;
            GroupBoxConnection.Text = "Connection";
            // 
            // TableLayoutPanelConnectionControls
            // 
            TableLayoutPanelConnectionControls.AutoSize = true;
            TableLayoutPanelConnectionControls.ColumnCount = 7;
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelConnectionControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelConnectionControls.Controls.Add(LabelIpAddress, 0, 0);
            TableLayoutPanelConnectionControls.Controls.Add(TextBoxIpAddress, 1, 0);
            TableLayoutPanelConnectionControls.Controls.Add(LabelPort, 2, 0);
            TableLayoutPanelConnectionControls.Controls.Add(TextBoxPort, 3, 0);
            TableLayoutPanelConnectionControls.Controls.Add(ButtonConnect, 4, 0);
            TableLayoutPanelConnectionControls.Controls.Add(ButtonDisconnect, 5, 0);
            TableLayoutPanelConnectionControls.Dock = DockStyle.Fill;
            TableLayoutPanelConnectionControls.Location = new Point(3, 19);
            TableLayoutPanelConnectionControls.Name = "TableLayoutPanelConnectionControls";
            TableLayoutPanelConnectionControls.RowCount = 1;
            TableLayoutPanelConnectionControls.RowStyles.Add(new RowStyle());
            TableLayoutPanelConnectionControls.Size = new Size(1133, 31);
            TableLayoutPanelConnectionControls.TabIndex = 0;
            // 
            // LabelIpAddress
            // 
            LabelIpAddress.Anchor = AnchorStyles.None;
            LabelIpAddress.AutoSize = true;
            LabelIpAddress.Location = new Point(3, 8);
            LabelIpAddress.Name = "LabelIpAddress";
            LabelIpAddress.Size = new Size(68, 15);
            LabelIpAddress.TabIndex = 0;
            LabelIpAddress.Text = "IP Address: ";
            // 
            // TextBoxIpAddress
            // 
            TextBoxIpAddress.Anchor = AnchorStyles.None;
            TextBoxIpAddress.Location = new Point(77, 4);
            TextBoxIpAddress.Name = "TextBoxIpAddress";
            TextBoxIpAddress.PlaceholderText = "192.168.1.11";
            TextBoxIpAddress.Size = new Size(100, 23);
            TextBoxIpAddress.TabIndex = 1;
            TextBoxIpAddress.Text = "192.168.1.11";
            // 
            // LabelPort
            // 
            LabelPort.Anchor = AnchorStyles.None;
            LabelPort.AutoSize = true;
            LabelPort.Location = new Point(183, 8);
            LabelPort.Name = "LabelPort";
            LabelPort.Size = new Size(35, 15);
            LabelPort.TabIndex = 2;
            LabelPort.Text = "Port: ";
            // 
            // TextBoxPort
            // 
            TextBoxPort.Anchor = AnchorStyles.None;
            TextBoxPort.Location = new Point(224, 4);
            TextBoxPort.Name = "TextBoxPort";
            TextBoxPort.PlaceholderText = "4660";
            TextBoxPort.Size = new Size(100, 23);
            TextBoxPort.TabIndex = 3;
            TextBoxPort.Text = "4660";
            // 
            // ButtonConnect
            // 
            ButtonConnect.Anchor = AnchorStyles.None;
            ButtonConnect.AutoSize = true;
            ButtonConnect.Location = new Point(330, 3);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(62, 25);
            ButtonConnect.TabIndex = 4;
            ButtonConnect.Text = "Connect";
            ButtonConnect.UseVisualStyleBackColor = true;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // ButtonDisconnect
            // 
            ButtonDisconnect.Anchor = AnchorStyles.None;
            ButtonDisconnect.AutoSize = true;
            ButtonDisconnect.Location = new Point(398, 3);
            ButtonDisconnect.Name = "ButtonDisconnect";
            ButtonDisconnect.Size = new Size(76, 25);
            ButtonDisconnect.TabIndex = 5;
            ButtonDisconnect.Text = "Disconnect";
            ButtonDisconnect.UseVisualStyleBackColor = true;
            ButtonDisconnect.Click += ButtonDisconnect_Click;
            // 
            // GroupBoxPickTags
            // 
            GroupBoxPickTags.Controls.Add(TableLayoutPanelPickTagsControls);
            GroupBoxPickTags.Dock = DockStyle.Fill;
            GroupBoxPickTags.Location = new Point(3, 62);
            GroupBoxPickTags.Name = "GroupBoxPickTags";
            GroupBoxPickTags.Size = new Size(1139, 515);
            GroupBoxPickTags.TabIndex = 1;
            GroupBoxPickTags.TabStop = false;
            GroupBoxPickTags.Text = "Pick Tags";
            // 
            // TableLayoutPanelPickTagsControls
            // 
            TableLayoutPanelPickTagsControls.ColumnCount = 10;
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanelPickTagsControls.Dock = DockStyle.Fill;
            TableLayoutPanelPickTagsControls.Location = new Point(3, 19);
            TableLayoutPanelPickTagsControls.Name = "TableLayoutPanelPickTagsControls";
            TableLayoutPanelPickTagsControls.RowCount = 12;
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            TableLayoutPanelPickTagsControls.Size = new Size(1133, 493);
            TableLayoutPanelPickTagsControls.TabIndex = 0;
            // 
            // ListBoxReceivedBytes
            // 
            ListBoxReceivedBytes.Dock = DockStyle.Fill;
            ListBoxReceivedBytes.FormattingEnabled = true;
            ListBoxReceivedBytes.ItemHeight = 15;
            ListBoxReceivedBytes.Location = new Point(3, 583);
            ListBoxReceivedBytes.Name = "ListBoxReceivedBytes";
            ListBoxReceivedBytes.Size = new Size(1139, 94);
            ListBoxReceivedBytes.TabIndex = 2;
            // 
            // ControllerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanelControllersPageControls);
            Name = "ControllerPage";
            Size = new Size(1145, 680);
            TableLayoutPanelControllersPageControls.ResumeLayout(false);
            TableLayoutPanelControllersPageControls.PerformLayout();
            GroupBoxConnection.ResumeLayout(false);
            GroupBoxConnection.PerformLayout();
            TableLayoutPanelConnectionControls.ResumeLayout(false);
            TableLayoutPanelConnectionControls.PerformLayout();
            GroupBoxPickTags.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel TableLayoutPanelControllersPageControls;
        private GroupBox GroupBoxConnection;
        private TableLayoutPanel TableLayoutPanelConnectionControls;
        private Label LabelIpAddress;
        private TextBox TextBoxIpAddress;
        private Label LabelPort;
        private TextBox TextBoxPort;
        private Button ButtonConnect;
        private Button ButtonDisconnect;
        private GroupBox GroupBoxPickTags;
        private TableLayoutPanel TableLayoutPanelPickTagsControls;
        private ListBox ListBoxReceivedBytes;
    }
}