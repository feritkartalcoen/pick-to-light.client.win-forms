namespace PickToLight.Client.WinForms.Forms {
	partial class AddController {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			TextBoxIpAddress = new System.Windows.Forms.TextBox();
			TextBoxPort = new System.Windows.Forms.TextBox();
			ComboBoxControllerModel = new System.Windows.Forms.ComboBox();
			TextBoxPickTagsCount = new System.Windows.Forms.TextBox();
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			ButtonAccept = new System.Windows.Forms.Button();
			ButtonCancel = new System.Windows.Forms.Button();
			flowLayoutPanel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel1.Controls.Add(TextBoxIpAddress);
			flowLayoutPanel1.Controls.Add(TextBoxPort);
			flowLayoutPanel1.Controls.Add(ComboBoxControllerModel);
			flowLayoutPanel1.Controls.Add(TextBoxPickTagsCount);
			flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
			flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// TextBoxIpAddress
			// 
			TextBoxIpAddress.Dock = System.Windows.Forms.DockStyle.Top;
			TextBoxIpAddress.Location = new System.Drawing.Point(3, 3);
			TextBoxIpAddress.Name = "TextBoxIpAddress";
			TextBoxIpAddress.PlaceholderText = "IP Address";
			TextBoxIpAddress.Size = new System.Drawing.Size(203, 23);
			TextBoxIpAddress.TabIndex = 0;
			// 
			// TextBoxPort
			// 
			TextBoxPort.Dock = System.Windows.Forms.DockStyle.Top;
			TextBoxPort.Location = new System.Drawing.Point(3, 32);
			TextBoxPort.Name = "TextBoxPort";
			TextBoxPort.PlaceholderText = "Port";
			TextBoxPort.Size = new System.Drawing.Size(203, 23);
			TextBoxPort.TabIndex = 1;
			// 
			// ComboBoxControllerModel
			// 
			ComboBoxControllerModel.FormattingEnabled = true;
			ComboBoxControllerModel.Location = new System.Drawing.Point(3, 61);
			ComboBoxControllerModel.Name = "ComboBoxControllerModel";
			ComboBoxControllerModel.Size = new System.Drawing.Size(203, 23);
			ComboBoxControllerModel.TabIndex = 2;
			// 
			// TextBoxPickTagsCount
			// 
			TextBoxPickTagsCount.Dock = System.Windows.Forms.DockStyle.Top;
			TextBoxPickTagsCount.Location = new System.Drawing.Point(3, 90);
			TextBoxPickTagsCount.Name = "TextBoxPickTagsCount";
			TextBoxPickTagsCount.PlaceholderText = "Pick Tags Count";
			TextBoxPickTagsCount.Size = new System.Drawing.Size(203, 23);
			TextBoxPickTagsCount.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.AutoSize = true;
			tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(ButtonAccept, 0, 0);
			tableLayoutPanel1.Controls.Add(ButtonCancel, 1, 0);
			tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel1.Location = new System.Drawing.Point(3, 119);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel1.Size = new System.Drawing.Size(203, 31);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// ButtonAccept
			// 
			ButtonAccept.AutoSize = true;
			ButtonAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
			ButtonAccept.Location = new System.Drawing.Point(3, 3);
			ButtonAccept.Name = "ButtonAccept";
			ButtonAccept.Size = new System.Drawing.Size(95, 25);
			ButtonAccept.TabIndex = 0;
			ButtonAccept.Text = "Accept";
			ButtonAccept.UseVisualStyleBackColor = true;
			ButtonAccept.Click += ButtonAccept_Click;
			// 
			// ButtonCancel
			// 
			ButtonCancel.AutoSize = true;
			ButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			ButtonCancel.Location = new System.Drawing.Point(104, 3);
			ButtonCancel.Name = "ButtonCancel";
			ButtonCancel.Size = new System.Drawing.Size(96, 25);
			ButtonCancel.TabIndex = 1;
			ButtonCancel.Text = "Cancel";
			ButtonCancel.UseVisualStyleBackColor = true;
			ButtonCancel.Click += ButtonCancel_Click;
			// 
			// AddController
			// 
			AcceptButton = ButtonAccept;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			CancelButton = ButtonCancel;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "AddController";
			ShowIcon = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Add Controller";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox TextBoxIpAddress;
		private System.Windows.Forms.TextBox TextBoxPort;
		private System.Windows.Forms.ComboBox ComboBoxControllerModel;
		private System.Windows.Forms.TextBox TextBoxPickTagsCount;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button ButtonAccept;
		private System.Windows.Forms.Button ButtonCancel;
	}
}