namespace PickToLight.Client.WinForms.Controls {
	partial class PickTagControl {
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
		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			GroupBoxPickTag = new System.Windows.Forms.GroupBox();
			SuspendLayout();
			// 
			// GroupBoxPickTag
			// 
			GroupBoxPickTag.Dock = System.Windows.Forms.DockStyle.Fill;
			GroupBoxPickTag.Location = new System.Drawing.Point(0, 0);
			GroupBoxPickTag.Margin = new System.Windows.Forms.Padding(0);
			GroupBoxPickTag.Name = "GroupBoxPickTag";
			GroupBoxPickTag.Padding = new System.Windows.Forms.Padding(0);
			GroupBoxPickTag.Size = new System.Drawing.Size(150, 150);
			GroupBoxPickTag.TabIndex = 0;
			GroupBoxPickTag.TabStop = false;
			GroupBoxPickTag.Text = "Node Address";
			// 
			// PickTagControl
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(GroupBoxPickTag);
			Margin = new System.Windows.Forms.Padding(0);
			Name = "PickTagControl";
			ResumeLayout(false);
		}
		#endregion

		private System.Windows.Forms.GroupBox GroupBoxPickTag;
	}
}