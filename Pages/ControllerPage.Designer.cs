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
			GroupBoxConnection = new System.Windows.Forms.GroupBox();
			FlowLayoutPanelConnection = new System.Windows.Forms.FlowLayoutPanel();
			LabelIpAddressAndPort = new System.Windows.Forms.Label();
			ButtonConnect = new System.Windows.Forms.Button();
			ButtonDisconnect = new System.Windows.Forms.Button();
			GroupBoxPickTags = new System.Windows.Forms.GroupBox();
			TableLayoutPanelPickTags = new System.Windows.Forms.TableLayoutPanel();
			GroupBoxConnection.SuspendLayout();
			FlowLayoutPanelConnection.SuspendLayout();
			GroupBoxPickTags.SuspendLayout();
			SuspendLayout();
			// 
			// GroupBoxConnection
			// 
			GroupBoxConnection.AutoSize = true;
			GroupBoxConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			GroupBoxConnection.Controls.Add(FlowLayoutPanelConnection);
			GroupBoxConnection.Dock = System.Windows.Forms.DockStyle.Top;
			GroupBoxConnection.Location = new System.Drawing.Point(0, 0);
			GroupBoxConnection.Margin = new System.Windows.Forms.Padding(0);
			GroupBoxConnection.Name = "GroupBoxConnection";
			GroupBoxConnection.Padding = new System.Windows.Forms.Padding(0);
			GroupBoxConnection.Size = new System.Drawing.Size(1159, 41);
			GroupBoxConnection.TabIndex = 0;
			GroupBoxConnection.TabStop = false;
			GroupBoxConnection.Text = "Connection";
			// 
			// FlowLayoutPanelConnection
			// 
			FlowLayoutPanelConnection.AutoSize = true;
			FlowLayoutPanelConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			FlowLayoutPanelConnection.Controls.Add(LabelIpAddressAndPort);
			FlowLayoutPanelConnection.Controls.Add(ButtonConnect);
			FlowLayoutPanelConnection.Controls.Add(ButtonDisconnect);
			FlowLayoutPanelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
			FlowLayoutPanelConnection.Location = new System.Drawing.Point(0, 16);
			FlowLayoutPanelConnection.Name = "FlowLayoutPanelConnection";
			FlowLayoutPanelConnection.Size = new System.Drawing.Size(1159, 25);
			FlowLayoutPanelConnection.TabIndex = 0;
			// 
			// LabelIpAddressAndPort
			// 
			LabelIpAddressAndPort.Anchor = System.Windows.Forms.AnchorStyles.None;
			LabelIpAddressAndPort.AutoSize = true;
			LabelIpAddressAndPort.Location = new System.Drawing.Point(0, 5);
			LabelIpAddressAndPort.Margin = new System.Windows.Forms.Padding(0);
			LabelIpAddressAndPort.Name = "LabelIpAddressAndPort";
			LabelIpAddressAndPort.Size = new System.Drawing.Size(93, 15);
			LabelIpAddressAndPort.TabIndex = 2;
			LabelIpAddressAndPort.Text = "IP Address : Port";
			// 
			// ButtonConnect
			// 
			ButtonConnect.AutoSize = true;
			ButtonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonConnect.Location = new System.Drawing.Point(93, 0);
			ButtonConnect.Margin = new System.Windows.Forms.Padding(0);
			ButtonConnect.Name = "ButtonConnect";
			ButtonConnect.Size = new System.Drawing.Size(62, 25);
			ButtonConnect.TabIndex = 0;
			ButtonConnect.Text = "Connect";
			ButtonConnect.UseVisualStyleBackColor = true;
			ButtonConnect.Click += ButtonConnect_Click;
			// 
			// ButtonDisconnect
			// 
			ButtonDisconnect.AutoSize = true;
			ButtonDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonDisconnect.Location = new System.Drawing.Point(155, 0);
			ButtonDisconnect.Margin = new System.Windows.Forms.Padding(0);
			ButtonDisconnect.Name = "ButtonDisconnect";
			ButtonDisconnect.Size = new System.Drawing.Size(76, 25);
			ButtonDisconnect.TabIndex = 1;
			ButtonDisconnect.Text = "Disconnect";
			ButtonDisconnect.UseVisualStyleBackColor = true;
			ButtonDisconnect.Click += ButtonDisconnect_Click;
			// 
			// GroupBoxPickTags
			// 
			GroupBoxPickTags.Controls.Add(TableLayoutPanelPickTags);
			GroupBoxPickTags.Dock = System.Windows.Forms.DockStyle.Fill;
			GroupBoxPickTags.Location = new System.Drawing.Point(0, 41);
			GroupBoxPickTags.Margin = new System.Windows.Forms.Padding(0);
			GroupBoxPickTags.Name = "GroupBoxPickTags";
			GroupBoxPickTags.Padding = new System.Windows.Forms.Padding(0);
			GroupBoxPickTags.Size = new System.Drawing.Size(1159, 608);
			GroupBoxPickTags.TabIndex = 1;
			GroupBoxPickTags.TabStop = false;
			GroupBoxPickTags.Text = "Pick Tags";
			// 
			// TableLayoutPanelPickTags
			// 
			TableLayoutPanelPickTags.ColumnCount = 15;
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.66666746F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			TableLayoutPanelPickTags.Dock = System.Windows.Forms.DockStyle.Fill;
			TableLayoutPanelPickTags.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			TableLayoutPanelPickTags.Location = new System.Drawing.Point(0, 16);
			TableLayoutPanelPickTags.Margin = new System.Windows.Forms.Padding(0);
			TableLayoutPanelPickTags.Name = "TableLayoutPanelPickTags";
			TableLayoutPanelPickTags.RowCount = 8;
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			TableLayoutPanelPickTags.Size = new System.Drawing.Size(1159, 592);
			TableLayoutPanelPickTags.TabIndex = 0;
			// 
			// ControllerPage
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(GroupBoxPickTags);
			Controls.Add(GroupBoxConnection);
			Margin = new System.Windows.Forms.Padding(0);
			Name = "ControllerPage";
			Size = new System.Drawing.Size(1159, 649);
			GroupBoxConnection.ResumeLayout(false);
			GroupBoxConnection.PerformLayout();
			FlowLayoutPanelConnection.ResumeLayout(false);
			FlowLayoutPanelConnection.PerformLayout();
			GroupBoxPickTags.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion
		private System.Windows.Forms.GroupBox GroupBoxConnection;
		private System.Windows.Forms.Button ButtonConnect;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelConnection;
		private System.Windows.Forms.Button ButtonDisconnect;
		private System.Windows.Forms.GroupBox GroupBoxPickTags;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanelPickTags;
		private System.Windows.Forms.Label LabelIpAddressAndPort;
	}
}