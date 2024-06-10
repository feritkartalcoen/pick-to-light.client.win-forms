namespace PickToLight.Client.WinForms.Forms {
	partial class Main {
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		#region Windows Form Designer generated code
		private void InitializeComponent() {
			FlowLayoutPanelControllerControlButtons = new System.Windows.Forms.FlowLayoutPanel();
			ButtonAddController = new System.Windows.Forms.Button();
			ButtonRemoveController = new System.Windows.Forms.Button();
			TabControlControllers = new System.Windows.Forms.TabControl();
			FlowLayoutPanelControllerControlButtons.SuspendLayout();
			SuspendLayout();
			// 
			// FlowLayoutPanelControllerControlButtons
			// 
			FlowLayoutPanelControllerControlButtons.AutoSize = true;
			FlowLayoutPanelControllerControlButtons.Controls.Add(ButtonAddController);
			FlowLayoutPanelControllerControlButtons.Controls.Add(ButtonRemoveController);
			FlowLayoutPanelControllerControlButtons.Dock = System.Windows.Forms.DockStyle.Top;
			FlowLayoutPanelControllerControlButtons.Location = new System.Drawing.Point(0, 0);
			FlowLayoutPanelControllerControlButtons.Margin = new System.Windows.Forms.Padding(0);
			FlowLayoutPanelControllerControlButtons.Name = "FlowLayoutPanelControllerControlButtons";
			FlowLayoutPanelControllerControlButtons.Size = new System.Drawing.Size(800, 25);
			FlowLayoutPanelControllerControlButtons.TabIndex = 0;
			// 
			// ButtonAddController
			// 
			ButtonAddController.AutoSize = true;
			ButtonAddController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonAddController.Location = new System.Drawing.Point(0, 0);
			ButtonAddController.Margin = new System.Windows.Forms.Padding(0);
			ButtonAddController.Name = "ButtonAddController";
			ButtonAddController.Size = new System.Drawing.Size(95, 25);
			ButtonAddController.TabIndex = 0;
			ButtonAddController.Text = "Add Controller";
			ButtonAddController.UseVisualStyleBackColor = true;
			ButtonAddController.Click += ButtonAddController_Click;
			// 
			// ButtonRemoveController
			// 
			ButtonRemoveController.AutoSize = true;
			ButtonRemoveController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonRemoveController.Location = new System.Drawing.Point(95, 0);
			ButtonRemoveController.Margin = new System.Windows.Forms.Padding(0);
			ButtonRemoveController.Name = "ButtonRemoveController";
			ButtonRemoveController.Size = new System.Drawing.Size(116, 25);
			ButtonRemoveController.TabIndex = 1;
			ButtonRemoveController.Text = "Remove Controller";
			ButtonRemoveController.UseVisualStyleBackColor = true;
			ButtonRemoveController.Click += ButtonRemoveController_Click;
			// 
			// TabControlControllers
			// 
			TabControlControllers.Dock = System.Windows.Forms.DockStyle.Fill;
			TabControlControllers.Location = new System.Drawing.Point(0, 25);
			TabControlControllers.Margin = new System.Windows.Forms.Padding(0);
			TabControlControllers.Name = "TabControlControllers";
			TabControlControllers.Padding = new System.Drawing.Point(0, 0);
			TabControlControllers.SelectedIndex = 0;
			TabControlControllers.Size = new System.Drawing.Size(800, 425);
			TabControlControllers.TabIndex = 1;
			// 
			// Main
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(TabControlControllers);
			Controls.Add(FlowLayoutPanelControllerControlButtons);
			Name = "Main";
			ShowIcon = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Pick-to-Light";
			FlowLayoutPanelControllerControlButtons.ResumeLayout(false);
			FlowLayoutPanelControllerControlButtons.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelControllerControlButtons;
		private System.Windows.Forms.Button ButtonAddController;
		private System.Windows.Forms.Button ButtonRemoveController;
		private System.Windows.Forms.TabControl TabControlControllers;
	}
}