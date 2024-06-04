namespace PickToLight.Client.WinForms.Controls.User {
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
            GroupBoxPickTag = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            LabelValue = new Label();
            GroupBoxPickTag.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxPickTag
            // 
            GroupBoxPickTag.Controls.Add(tableLayoutPanel1);
            GroupBoxPickTag.Dock = DockStyle.Fill;
            GroupBoxPickTag.Location = new Point(0, 0);
            GroupBoxPickTag.Name = "GroupBoxPickTag";
            GroupBoxPickTag.Size = new Size(150, 150);
            GroupBoxPickTag.TabIndex = 0;
            GroupBoxPickTag.TabStop = false;
            GroupBoxPickTag.Text = "Node Address";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(LabelValue, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(144, 128);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelValue
            // 
            LabelValue.Anchor = AnchorStyles.None;
            LabelValue.AutoSize = true;
            LabelValue.Font = new Font("Segoe UI", 20F);
            LabelValue.Location = new Point(31, 45);
            LabelValue.Name = "LabelValue";
            LabelValue.Size = new Size(82, 37);
            LabelValue.TabIndex = 0;
            LabelValue.Text = "Value";
            // 
            // PickTagControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxPickTag);
            Name = "PickTagControl";
            GroupBoxPickTag.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxPickTag;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LabelValue;
    }
}
