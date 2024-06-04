using PickToLight.Client.WinForms.Pages;
namespace PickToLight.Client.WinForms {
    partial class FormPickToLight {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent() {
            TableLayoutPanelFormPickToLightControls = new TableLayoutPanel();
            TableLayoutPanelEditControllersControls = new TableLayoutPanel();
            ButtonAddController = new Button();
            ButtonRemoveController = new Button();
            TabControlControllers = new TabControl();
            TabPage1 = new TabPage();
            ControllerPage1 = new ControllerPage();
            TableLayoutPanelFormPickToLightControls.SuspendLayout();
            TableLayoutPanelEditControllersControls.SuspendLayout();
            TabControlControllers.SuspendLayout();
            TabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelFormPickToLightControls
            // 
            TableLayoutPanelFormPickToLightControls.ColumnCount = 1;
            TableLayoutPanelFormPickToLightControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelFormPickToLightControls.Controls.Add(TableLayoutPanelEditControllersControls, 0, 0);
            TableLayoutPanelFormPickToLightControls.Controls.Add(TabControlControllers, 0, 1);
            TableLayoutPanelFormPickToLightControls.Dock = DockStyle.Fill;
            TableLayoutPanelFormPickToLightControls.Location = new Point(0, 0);
            TableLayoutPanelFormPickToLightControls.Name = "TableLayoutPanelFormPickToLightControls";
            TableLayoutPanelFormPickToLightControls.RowCount = 2;
            TableLayoutPanelFormPickToLightControls.RowStyles.Add(new RowStyle());
            TableLayoutPanelFormPickToLightControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelFormPickToLightControls.Size = new Size(1129, 641);
            TableLayoutPanelFormPickToLightControls.TabIndex = 0;
            // 
            // TableLayoutPanelEditControllersControls
            // 
            TableLayoutPanelEditControllersControls.AutoSize = true;
            TableLayoutPanelEditControllersControls.ColumnCount = 3;
            TableLayoutPanelEditControllersControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEditControllersControls.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEditControllersControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelEditControllersControls.Controls.Add(ButtonAddController, 0, 0);
            TableLayoutPanelEditControllersControls.Controls.Add(ButtonRemoveController, 1, 0);
            TableLayoutPanelEditControllersControls.Dock = DockStyle.Fill;
            TableLayoutPanelEditControllersControls.Location = new Point(3, 3);
            TableLayoutPanelEditControllersControls.Name = "TableLayoutPanelEditControllersControls";
            TableLayoutPanelEditControllersControls.RowCount = 1;
            TableLayoutPanelEditControllersControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelEditControllersControls.Size = new Size(1123, 31);
            TableLayoutPanelEditControllersControls.TabIndex = 0;
            // 
            // ButtonAddController
            // 
            ButtonAddController.AutoSize = true;
            ButtonAddController.Location = new Point(3, 3);
            ButtonAddController.Name = "ButtonAddController";
            ButtonAddController.Size = new Size(95, 25);
            ButtonAddController.TabIndex = 0;
            ButtonAddController.Text = "Add Controller";
            ButtonAddController.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveController
            // 
            ButtonRemoveController.AutoSize = true;
            ButtonRemoveController.Location = new Point(104, 3);
            ButtonRemoveController.Name = "ButtonRemoveController";
            ButtonRemoveController.Size = new Size(116, 25);
            ButtonRemoveController.TabIndex = 1;
            ButtonRemoveController.Text = "Remove Controller";
            ButtonRemoveController.UseVisualStyleBackColor = true;
            // 
            // TabControlControllers
            // 
            TabControlControllers.Controls.Add(TabPage1);
            TabControlControllers.Dock = DockStyle.Fill;
            TabControlControllers.Location = new Point(3, 40);
            TabControlControllers.Name = "TabControlControllers";
            TabControlControllers.SelectedIndex = 0;
            TabControlControllers.Size = new Size(1123, 598);
            TabControlControllers.TabIndex = 1;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(ControllerPage1);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1115, 570);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Controller 1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ControllerPage1
            // 
            ControllerPage1.Dock = DockStyle.Fill;
            ControllerPage1.Location = new Point(3, 3);
            ControllerPage1.Name = "ControllerPage1";
            ControllerPage1.Size = new Size(1109, 564);
            ControllerPage1.TabIndex = 0;
            // 
            // FormPickToLight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 641);
            Controls.Add(TableLayoutPanelFormPickToLightControls);
            Name = "FormPickToLight";
            Text = "Pick-to-Light";
            WindowState = FormWindowState.Maximized;
            TableLayoutPanelFormPickToLightControls.ResumeLayout(false);
            TableLayoutPanelFormPickToLightControls.PerformLayout();
            TableLayoutPanelEditControllersControls.ResumeLayout(false);
            TableLayoutPanelEditControllersControls.PerformLayout();
            TabControlControllers.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel TableLayoutPanelFormPickToLightControls;
        private TableLayoutPanel TableLayoutPanelEditControllersControls;
        private Button ButtonAddController;
        private Button ButtonRemoveController;
        private TabControl TabControlControllers;
        private TabPage TabPage1;
        private ControllerPage ControllerPage1;
    }
}