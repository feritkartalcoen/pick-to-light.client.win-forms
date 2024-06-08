namespace PickToLight.Client.WinForms.Forms {
	partial class Main {
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
			ButtonConnect = new System.Windows.Forms.Button();
			ButtonDisconnect = new System.Windows.Forms.Button();
			ButtonClear = new System.Windows.Forms.Button();
			ButtonDisplay = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// ButtonConnect
			// 
			ButtonConnect.AutoSize = true;
			ButtonConnect.Location = new System.Drawing.Point(12, 12);
			ButtonConnect.Name = "ButtonConnect";
			ButtonConnect.Size = new System.Drawing.Size(75, 25);
			ButtonConnect.TabIndex = 2;
			ButtonConnect.Text = "Connect";
			ButtonConnect.UseVisualStyleBackColor = true;
			ButtonConnect.Click += ButtonConnect_Click;
			// 
			// ButtonDisconnect
			// 
			ButtonDisconnect.AutoSize = true;
			ButtonDisconnect.Location = new System.Drawing.Point(93, 12);
			ButtonDisconnect.Name = "ButtonDisconnect";
			ButtonDisconnect.Size = new System.Drawing.Size(76, 25);
			ButtonDisconnect.TabIndex = 3;
			ButtonDisconnect.Text = "Disconnect";
			ButtonDisconnect.UseVisualStyleBackColor = true;
			ButtonDisconnect.Click += ButtonDisconnect_Click;
			// 
			// ButtonClear
			// 
			ButtonClear.AutoSize = true;
			ButtonClear.Location = new System.Drawing.Point(93, 43);
			ButtonClear.Name = "ButtonClear";
			ButtonClear.Size = new System.Drawing.Size(76, 25);
			ButtonClear.TabIndex = 5;
			ButtonClear.Text = "Clear";
			ButtonClear.UseVisualStyleBackColor = true;
			ButtonClear.Click += ButtonClear_Click;
			// 
			// ButtonDisplay
			// 
			ButtonDisplay.AutoSize = true;
			ButtonDisplay.Location = new System.Drawing.Point(12, 43);
			ButtonDisplay.Name = "ButtonDisplay";
			ButtonDisplay.Size = new System.Drawing.Size(75, 25);
			ButtonDisplay.TabIndex = 4;
			ButtonDisplay.Text = "Display";
			ButtonDisplay.UseVisualStyleBackColor = true;
			ButtonDisplay.Click += ButtonDisplay_Click;
			// 
			// Main
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(ButtonClear);
			Controls.Add(ButtonDisplay);
			Controls.Add(ButtonDisconnect);
			Controls.Add(ButtonConnect);
			Name = "Main";
			Text = "Pick-to-Light";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button ButtonConnect;
		private System.Windows.Forms.Button ButtonDisconnect;
		private System.Windows.Forms.Button ButtonClear;
		private System.Windows.Forms.Button ButtonDisplay;
	}
}