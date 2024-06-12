namespace PickToLight.Client.WinForms.Forms {
	public partial class MainForm {
		#region Fields
		private System.Windows.Forms.Button ButtonClear;
		private System.Windows.Forms.Button ButtonConnect;
		private System.Windows.Forms.Button ButtonDisconnect;
		private System.Windows.Forms.Button ButtonDisplay;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView DataGridViewPickTags;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelCommunicationControlBlockButtons;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelConnectionButtons;
		#endregion
		#region Methods
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			ButtonConnect = new System.Windows.Forms.Button();
			ButtonDisconnect = new System.Windows.Forms.Button();
			FlowLayoutPanelConnectionButtons = new System.Windows.Forms.FlowLayoutPanel();
			ButtonDisplay = new System.Windows.Forms.Button();
			ButtonClear = new System.Windows.Forms.Button();
			DataGridViewPickTags = new System.Windows.Forms.DataGridView();
			FlowLayoutPanelCommunicationControlBlockButtons = new System.Windows.Forms.FlowLayoutPanel();
			ButtonChangeAvailableDigitsForCounting = new System.Windows.Forms.Button();
			ButtonChangeBlinkingTimeInterval = new System.Windows.Forms.Button();
			ButtonChangeColor = new System.Windows.Forms.Button();
			ButtonChangeDigitsBrightness = new System.Windows.Forms.Button();
			ButtonChangeFlashingTimeInterval = new System.Windows.Forms.Button();
			ButtonChangeNodeAddress = new System.Windows.Forms.Button();
			ButtonChangePickTagConfigurationWithSpecialFunctionOne = new System.Windows.Forms.Button();
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo = new System.Windows.Forms.Button();
			ButtonChangePickTagModeConfiguration = new System.Windows.Forms.Button();
			ButtonChangePollingRange = new System.Windows.Forms.Button();
			ButtonChangeValidDigitsForCounting = new System.Windows.Forms.Button();
			ButtonDisableConfirmationButton = new System.Windows.Forms.Button();
			ButtonDisableShortageButton = new System.Windows.Forms.Button();
			ButtonDisplayNodeAddress = new System.Windows.Forms.Button();
			ButtonEmulateConfirmationButtonPressing = new System.Windows.Forms.Button();
			ButtonEmulateShortageButtonPressing = new System.Windows.Forms.Button();
			ButtonEnableConfirmationButton = new System.Windows.Forms.Button();
			ButtonEnableShortageButton = new System.Windows.Forms.Button();
			ButtonFlash = new System.Windows.Forms.Button();
			ButtonRequestConnectedPickTags = new System.Windows.Forms.Button();
			ButtonRequestPickTagDetails = new System.Windows.Forms.Button();
			ButtonRequestPickTagModel = new System.Windows.Forms.Button();
			ButtonReset = new System.Windows.Forms.Button();
			ButtonSwitchToPickingMode = new System.Windows.Forms.Button();
			ButtonSwitchToStockMode = new System.Windows.Forms.Button();
			ButtonTurnBuzzerOff = new System.Windows.Forms.Button();
			ButtonTurnBuzzerOn = new System.Windows.Forms.Button();
			ButtonTurnLedOff = new System.Windows.Forms.Button();
			ButtonTurnLedOn = new System.Windows.Forms.Button();
			FlowLayoutPanelConnectionButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DataGridViewPickTags).BeginInit();
			FlowLayoutPanelCommunicationControlBlockButtons.SuspendLayout();
			SuspendLayout();
			// 
			// ButtonConnect
			// 
			ButtonConnect.AutoSize = true;
			ButtonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonConnect.Location = new System.Drawing.Point(9, 9);
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
			ButtonDisconnect.Enabled = false;
			ButtonDisconnect.Location = new System.Drawing.Point(77, 9);
			ButtonDisconnect.Name = "ButtonDisconnect";
			ButtonDisconnect.Size = new System.Drawing.Size(76, 25);
			ButtonDisconnect.TabIndex = 1;
			ButtonDisconnect.Text = "Disconnect";
			ButtonDisconnect.UseVisualStyleBackColor = true;
			ButtonDisconnect.Click += ButtonDisconnect_Click;
			// 
			// FlowLayoutPanelConnectionButtons
			// 
			FlowLayoutPanelConnectionButtons.AutoSize = true;
			FlowLayoutPanelConnectionButtons.Controls.Add(ButtonConnect);
			FlowLayoutPanelConnectionButtons.Controls.Add(ButtonDisconnect);
			FlowLayoutPanelConnectionButtons.Dock = System.Windows.Forms.DockStyle.Top;
			FlowLayoutPanelConnectionButtons.Location = new System.Drawing.Point(0, 0);
			FlowLayoutPanelConnectionButtons.Name = "FlowLayoutPanelConnectionButtons";
			FlowLayoutPanelConnectionButtons.Padding = new System.Windows.Forms.Padding(6);
			FlowLayoutPanelConnectionButtons.Size = new System.Drawing.Size(800, 43);
			FlowLayoutPanelConnectionButtons.TabIndex = 2;
			// 
			// ButtonDisplay
			// 
			ButtonDisplay.AutoSize = true;
			ButtonDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonDisplay.Location = new System.Drawing.Point(579, 102);
			ButtonDisplay.Name = "ButtonDisplay";
			ButtonDisplay.Size = new System.Drawing.Size(55, 25);
			ButtonDisplay.TabIndex = 2;
			ButtonDisplay.Text = "Display";
			ButtonDisplay.UseVisualStyleBackColor = true;
			ButtonDisplay.Click += ButtonDisplay_Click;
			// 
			// ButtonClear
			// 
			ButtonClear.AutoSize = true;
			ButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonClear.Location = new System.Drawing.Point(205, 102);
			ButtonClear.Name = "ButtonClear";
			ButtonClear.Size = new System.Drawing.Size(44, 25);
			ButtonClear.TabIndex = 3;
			ButtonClear.Text = "Clear";
			ButtonClear.UseVisualStyleBackColor = true;
			ButtonClear.Click += ButtonClear_Click;
			// 
			// DataGridViewPickTags
			// 
			DataGridViewPickTags.AllowUserToAddRows = false;
			DataGridViewPickTags.AllowUserToDeleteRows = false;
			DataGridViewPickTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewPickTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			DataGridViewPickTags.DefaultCellStyle = dataGridViewCellStyle1;
			DataGridViewPickTags.Dock = System.Windows.Forms.DockStyle.Fill;
			DataGridViewPickTags.Location = new System.Drawing.Point(0, 272);
			DataGridViewPickTags.Name = "DataGridViewPickTags";
			DataGridViewPickTags.ReadOnly = true;
			DataGridViewPickTags.Size = new System.Drawing.Size(800, 178);
			DataGridViewPickTags.TabIndex = 3;
			// 
			// FlowLayoutPanelCommunicationControlBlockButtons
			// 
			FlowLayoutPanelCommunicationControlBlockButtons.AutoSize = true;
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeAvailableDigitsForCounting);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeBlinkingTimeInterval);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeColor);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeDigitsBrightness);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeFlashingTimeInterval);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeNodeAddress);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangePickTagConfigurationWithSpecialFunctionOne);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangePickTagConfigurationWithSpecialFunctionTwo);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangePickTagModeConfiguration);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangePollingRange);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonChangeValidDigitsForCounting);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonClear);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonDisableConfirmationButton);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonDisableShortageButton);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonDisplay);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonDisplayNodeAddress);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonEmulateConfirmationButtonPressing);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonEmulateShortageButtonPressing);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonEnableConfirmationButton);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonEnableShortageButton);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonFlash);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonRequestConnectedPickTags);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonRequestPickTagDetails);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonRequestPickTagModel);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonReset);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonSwitchToPickingMode);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonSwitchToStockMode);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonTurnBuzzerOff);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonTurnBuzzerOn);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonTurnLedOff);
			FlowLayoutPanelCommunicationControlBlockButtons.Controls.Add(ButtonTurnLedOn);
			FlowLayoutPanelCommunicationControlBlockButtons.Dock = System.Windows.Forms.DockStyle.Top;
			FlowLayoutPanelCommunicationControlBlockButtons.Enabled = false;
			FlowLayoutPanelCommunicationControlBlockButtons.Location = new System.Drawing.Point(0, 43);
			FlowLayoutPanelCommunicationControlBlockButtons.Name = "FlowLayoutPanelCommunicationControlBlockButtons";
			FlowLayoutPanelCommunicationControlBlockButtons.Padding = new System.Windows.Forms.Padding(6);
			FlowLayoutPanelCommunicationControlBlockButtons.Size = new System.Drawing.Size(800, 229);
			FlowLayoutPanelCommunicationControlBlockButtons.TabIndex = 4;
			// 
			// ButtonChangeAvailableDigitsForCounting
			// 
			ButtonChangeAvailableDigitsForCounting.AutoSize = true;
			ButtonChangeAvailableDigitsForCounting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeAvailableDigitsForCounting.Location = new System.Drawing.Point(9, 9);
			ButtonChangeAvailableDigitsForCounting.Name = "ButtonChangeAvailableDigitsForCounting";
			ButtonChangeAvailableDigitsForCounting.Size = new System.Drawing.Size(213, 25);
			ButtonChangeAvailableDigitsForCounting.TabIndex = 4;
			ButtonChangeAvailableDigitsForCounting.Text = "Change Available Digits for Counting";
			ButtonChangeAvailableDigitsForCounting.UseVisualStyleBackColor = true;
			ButtonChangeAvailableDigitsForCounting.Click += ButtonChangeAvailableDigitsForCounting_Click;
			// 
			// ButtonChangeBlinkingTimeInterval
			// 
			ButtonChangeBlinkingTimeInterval.AutoSize = true;
			ButtonChangeBlinkingTimeInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeBlinkingTimeInterval.Location = new System.Drawing.Point(228, 9);
			ButtonChangeBlinkingTimeInterval.Name = "ButtonChangeBlinkingTimeInterval";
			ButtonChangeBlinkingTimeInterval.Size = new System.Drawing.Size(175, 25);
			ButtonChangeBlinkingTimeInterval.TabIndex = 5;
			ButtonChangeBlinkingTimeInterval.Text = "Change Blinking Time Interval";
			ButtonChangeBlinkingTimeInterval.UseVisualStyleBackColor = true;
			ButtonChangeBlinkingTimeInterval.Click += ButtonChangeBlinkingTimeInterval_Click;
			// 
			// ButtonChangeColor
			// 
			ButtonChangeColor.AutoSize = true;
			ButtonChangeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeColor.Location = new System.Drawing.Point(409, 9);
			ButtonChangeColor.Name = "ButtonChangeColor";
			ButtonChangeColor.Size = new System.Drawing.Size(90, 25);
			ButtonChangeColor.TabIndex = 6;
			ButtonChangeColor.Text = "Change Color";
			ButtonChangeColor.UseVisualStyleBackColor = true;
			ButtonChangeColor.Click += ButtonChangeColor_Click;
			// 
			// ButtonChangeDigitsBrightness
			// 
			ButtonChangeDigitsBrightness.AutoSize = true;
			ButtonChangeDigitsBrightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeDigitsBrightness.Location = new System.Drawing.Point(505, 9);
			ButtonChangeDigitsBrightness.Name = "ButtonChangeDigitsBrightness";
			ButtonChangeDigitsBrightness.Size = new System.Drawing.Size(149, 25);
			ButtonChangeDigitsBrightness.TabIndex = 7;
			ButtonChangeDigitsBrightness.Text = "Change Digits Brightness";
			ButtonChangeDigitsBrightness.UseVisualStyleBackColor = true;
			ButtonChangeDigitsBrightness.Click += ButtonChangeDigitsBrightness_Click;
			// 
			// ButtonChangeFlashingTimeInterval
			// 
			ButtonChangeFlashingTimeInterval.AutoSize = true;
			ButtonChangeFlashingTimeInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeFlashingTimeInterval.Location = new System.Drawing.Point(9, 40);
			ButtonChangeFlashingTimeInterval.Name = "ButtonChangeFlashingTimeInterval";
			ButtonChangeFlashingTimeInterval.Size = new System.Drawing.Size(176, 25);
			ButtonChangeFlashingTimeInterval.TabIndex = 8;
			ButtonChangeFlashingTimeInterval.Text = "Change Flashing Time Interval";
			ButtonChangeFlashingTimeInterval.UseVisualStyleBackColor = true;
			ButtonChangeFlashingTimeInterval.Click += ButtonChangeFlashingTimeInterval_Click;
			// 
			// ButtonChangeNodeAddress
			// 
			ButtonChangeNodeAddress.AutoSize = true;
			ButtonChangeNodeAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeNodeAddress.Location = new System.Drawing.Point(191, 40);
			ButtonChangeNodeAddress.Name = "ButtonChangeNodeAddress";
			ButtonChangeNodeAddress.Size = new System.Drawing.Size(135, 25);
			ButtonChangeNodeAddress.TabIndex = 9;
			ButtonChangeNodeAddress.Text = "Change Node Address";
			ButtonChangeNodeAddress.UseVisualStyleBackColor = true;
			ButtonChangeNodeAddress.Click += ButtonChangeNodeAddress_Click;
			// 
			// ButtonChangePickTagConfigurationWithSpecialFunctionOne
			// 
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.AutoSize = true;
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.Location = new System.Drawing.Point(332, 40);
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.Name = "ButtonChangePickTagConfigurationWithSpecialFunctionOne";
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.Size = new System.Drawing.Size(322, 25);
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.TabIndex = 10;
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.Text = "Change Pick Tag Configuration with Special Function One";
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.UseVisualStyleBackColor = true;
			ButtonChangePickTagConfigurationWithSpecialFunctionOne.Click += ButtonChangePickTagConfigurationWithSpecialFunctionOne_Click;
			// 
			// ButtonChangePickTagConfigurationWithSpecialFunctionTwo
			// 
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.AutoSize = true;
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.Location = new System.Drawing.Point(9, 71);
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.Name = "ButtonChangePickTagConfigurationWithSpecialFunctionTwo";
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.Size = new System.Drawing.Size(321, 25);
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.TabIndex = 11;
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.Text = "Change Pick Tag Configuration with Special Function Two";
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.UseVisualStyleBackColor = true;
			ButtonChangePickTagConfigurationWithSpecialFunctionTwo.Click += ButtonChangePickTagConfigurationWithSpecialFunctionTwo_Click;
			// 
			// ButtonChangePickTagModeConfiguration
			// 
			ButtonChangePickTagModeConfiguration.AutoSize = true;
			ButtonChangePickTagModeConfiguration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangePickTagModeConfiguration.Location = new System.Drawing.Point(336, 71);
			ButtonChangePickTagModeConfiguration.Name = "ButtonChangePickTagModeConfiguration";
			ButtonChangePickTagModeConfiguration.Size = new System.Drawing.Size(215, 25);
			ButtonChangePickTagModeConfiguration.TabIndex = 12;
			ButtonChangePickTagModeConfiguration.Text = "Change Pick Tag Mode Configuration";
			ButtonChangePickTagModeConfiguration.UseVisualStyleBackColor = true;
			ButtonChangePickTagModeConfiguration.Click += ButtonChangePickTagModeConfiguration_Click;
			// 
			// ButtonChangePollingRange
			// 
			ButtonChangePollingRange.AutoSize = true;
			ButtonChangePollingRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangePollingRange.Location = new System.Drawing.Point(557, 71);
			ButtonChangePollingRange.Name = "ButtonChangePollingRange";
			ButtonChangePollingRange.Size = new System.Drawing.Size(134, 25);
			ButtonChangePollingRange.TabIndex = 13;
			ButtonChangePollingRange.Text = "Change Polling Range";
			ButtonChangePollingRange.UseVisualStyleBackColor = true;
			ButtonChangePollingRange.Click += ButtonChangePollingRange_Click;
			// 
			// ButtonChangeValidDigitsForCounting
			// 
			ButtonChangeValidDigitsForCounting.AutoSize = true;
			ButtonChangeValidDigitsForCounting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonChangeValidDigitsForCounting.Location = new System.Drawing.Point(9, 102);
			ButtonChangeValidDigitsForCounting.Name = "ButtonChangeValidDigitsForCounting";
			ButtonChangeValidDigitsForCounting.Size = new System.Drawing.Size(190, 25);
			ButtonChangeValidDigitsForCounting.TabIndex = 14;
			ButtonChangeValidDigitsForCounting.Text = "Change Valid Digits for Counting";
			ButtonChangeValidDigitsForCounting.UseVisualStyleBackColor = true;
			ButtonChangeValidDigitsForCounting.Click += ButtonChangeValidDigitsForCounting_Click;
			// 
			// ButtonDisableConfirmationButton
			// 
			ButtonDisableConfirmationButton.AutoSize = true;
			ButtonDisableConfirmationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonDisableConfirmationButton.Location = new System.Drawing.Point(255, 102);
			ButtonDisableConfirmationButton.Name = "ButtonDisableConfirmationButton";
			ButtonDisableConfirmationButton.Size = new System.Drawing.Size(168, 25);
			ButtonDisableConfirmationButton.TabIndex = 15;
			ButtonDisableConfirmationButton.Text = "Disable Confirmation Button";
			ButtonDisableConfirmationButton.UseVisualStyleBackColor = true;
			ButtonDisableConfirmationButton.Click += ButtonDisableConfirmationButton_Click;
			// 
			// ButtonDisableShortageButton
			// 
			ButtonDisableShortageButton.AutoSize = true;
			ButtonDisableShortageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonDisableShortageButton.Location = new System.Drawing.Point(429, 102);
			ButtonDisableShortageButton.Name = "ButtonDisableShortageButton";
			ButtonDisableShortageButton.Size = new System.Drawing.Size(144, 25);
			ButtonDisableShortageButton.TabIndex = 16;
			ButtonDisableShortageButton.Text = "Disable Shortage Button";
			ButtonDisableShortageButton.UseVisualStyleBackColor = true;
			ButtonDisableShortageButton.Click += ButtonDisableShortageButton_Click;
			// 
			// ButtonDisplayNodeAddress
			// 
			ButtonDisplayNodeAddress.AutoSize = true;
			ButtonDisplayNodeAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonDisplayNodeAddress.Location = new System.Drawing.Point(640, 102);
			ButtonDisplayNodeAddress.Name = "ButtonDisplayNodeAddress";
			ButtonDisplayNodeAddress.Size = new System.Drawing.Size(132, 25);
			ButtonDisplayNodeAddress.TabIndex = 17;
			ButtonDisplayNodeAddress.Text = "Display Node Address";
			ButtonDisplayNodeAddress.UseVisualStyleBackColor = true;
			ButtonDisplayNodeAddress.Click += ButtonDisplayNodeAddress_Click;
			// 
			// ButtonEmulateConfirmationButtonPressing
			// 
			ButtonEmulateConfirmationButtonPressing.AutoSize = true;
			ButtonEmulateConfirmationButtonPressing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonEmulateConfirmationButtonPressing.Location = new System.Drawing.Point(9, 133);
			ButtonEmulateConfirmationButtonPressing.Name = "ButtonEmulateConfirmationButtonPressing";
			ButtonEmulateConfirmationButtonPressing.Size = new System.Drawing.Size(220, 25);
			ButtonEmulateConfirmationButtonPressing.TabIndex = 18;
			ButtonEmulateConfirmationButtonPressing.Text = "Emulate Confirmation Button Pressing";
			ButtonEmulateConfirmationButtonPressing.UseVisualStyleBackColor = true;
			ButtonEmulateConfirmationButtonPressing.Click += ButtonEmulateConfirmationButtonPressing_Click;
			// 
			// ButtonEmulateShortageButtonPressing
			// 
			ButtonEmulateShortageButtonPressing.AutoSize = true;
			ButtonEmulateShortageButtonPressing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonEmulateShortageButtonPressing.Location = new System.Drawing.Point(235, 133);
			ButtonEmulateShortageButtonPressing.Name = "ButtonEmulateShortageButtonPressing";
			ButtonEmulateShortageButtonPressing.Size = new System.Drawing.Size(196, 25);
			ButtonEmulateShortageButtonPressing.TabIndex = 19;
			ButtonEmulateShortageButtonPressing.Text = "Emulate Shortage Button Pressing";
			ButtonEmulateShortageButtonPressing.UseVisualStyleBackColor = true;
			ButtonEmulateShortageButtonPressing.Click += ButtonEmulateShortageButtonPressing_Click;
			// 
			// ButtonEnableConfirmationButton
			// 
			ButtonEnableConfirmationButton.AutoSize = true;
			ButtonEnableConfirmationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonEnableConfirmationButton.Location = new System.Drawing.Point(437, 133);
			ButtonEnableConfirmationButton.Name = "ButtonEnableConfirmationButton";
			ButtonEnableConfirmationButton.Size = new System.Drawing.Size(165, 25);
			ButtonEnableConfirmationButton.TabIndex = 20;
			ButtonEnableConfirmationButton.Text = "Enable Confirmation Button";
			ButtonEnableConfirmationButton.UseVisualStyleBackColor = true;
			ButtonEnableConfirmationButton.Click += ButtonEnableConfirmationButton_Click;
			// 
			// ButtonEnableShortageButton
			// 
			ButtonEnableShortageButton.AutoSize = true;
			ButtonEnableShortageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonEnableShortageButton.Location = new System.Drawing.Point(608, 133);
			ButtonEnableShortageButton.Name = "ButtonEnableShortageButton";
			ButtonEnableShortageButton.Size = new System.Drawing.Size(141, 25);
			ButtonEnableShortageButton.TabIndex = 21;
			ButtonEnableShortageButton.Text = "Enable Shortage Button";
			ButtonEnableShortageButton.UseVisualStyleBackColor = true;
			ButtonEnableShortageButton.Click += ButtonEnableShortageButton_Click;
			// 
			// ButtonFlash
			// 
			ButtonFlash.AutoSize = true;
			ButtonFlash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonFlash.Location = new System.Drawing.Point(9, 164);
			ButtonFlash.Name = "ButtonFlash";
			ButtonFlash.Size = new System.Drawing.Size(44, 25);
			ButtonFlash.TabIndex = 22;
			ButtonFlash.Text = "Flash";
			ButtonFlash.UseVisualStyleBackColor = true;
			ButtonFlash.Click += ButtonFlash_Click;
			// 
			// ButtonRequestConnectedPickTags
			// 
			ButtonRequestConnectedPickTags.AutoSize = true;
			ButtonRequestConnectedPickTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonRequestConnectedPickTags.Location = new System.Drawing.Point(59, 164);
			ButtonRequestConnectedPickTags.Name = "ButtonRequestConnectedPickTags";
			ButtonRequestConnectedPickTags.Size = new System.Drawing.Size(171, 25);
			ButtonRequestConnectedPickTags.TabIndex = 23;
			ButtonRequestConnectedPickTags.Text = "Request Connected Pick Tags";
			ButtonRequestConnectedPickTags.UseVisualStyleBackColor = true;
			ButtonRequestConnectedPickTags.Click += ButtonRequestConnectedPickTags_Click;
			// 
			// ButtonRequestPickTagDetails
			// 
			ButtonRequestPickTagDetails.AutoSize = true;
			ButtonRequestPickTagDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonRequestPickTagDetails.Location = new System.Drawing.Point(236, 164);
			ButtonRequestPickTagDetails.Name = "ButtonRequestPickTagDetails";
			ButtonRequestPickTagDetails.Size = new System.Drawing.Size(143, 25);
			ButtonRequestPickTagDetails.TabIndex = 24;
			ButtonRequestPickTagDetails.Text = "Request Pick Tag Details";
			ButtonRequestPickTagDetails.UseVisualStyleBackColor = true;
			ButtonRequestPickTagDetails.Click += ButtonRequestPickTagDetails_Click;
			// 
			// ButtonRequestPickTagModel
			// 
			ButtonRequestPickTagModel.AutoSize = true;
			ButtonRequestPickTagModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonRequestPickTagModel.Location = new System.Drawing.Point(385, 164);
			ButtonRequestPickTagModel.Name = "ButtonRequestPickTagModel";
			ButtonRequestPickTagModel.Size = new System.Drawing.Size(142, 25);
			ButtonRequestPickTagModel.TabIndex = 25;
			ButtonRequestPickTagModel.Text = "Request Pick Tag Model";
			ButtonRequestPickTagModel.UseVisualStyleBackColor = true;
			ButtonRequestPickTagModel.Click += ButtonRequestPickTagModel_Click;
			// 
			// ButtonReset
			// 
			ButtonReset.AutoSize = true;
			ButtonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonReset.Location = new System.Drawing.Point(533, 164);
			ButtonReset.Name = "ButtonReset";
			ButtonReset.Size = new System.Drawing.Size(45, 25);
			ButtonReset.TabIndex = 26;
			ButtonReset.Text = "Reset";
			ButtonReset.UseVisualStyleBackColor = true;
			ButtonReset.Click += ButtonReset_Click;
			// 
			// ButtonSwitchToPickingMode
			// 
			ButtonSwitchToPickingMode.AutoSize = true;
			ButtonSwitchToPickingMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonSwitchToPickingMode.Location = new System.Drawing.Point(584, 164);
			ButtonSwitchToPickingMode.Name = "ButtonSwitchToPickingMode";
			ButtonSwitchToPickingMode.Size = new System.Drawing.Size(142, 25);
			ButtonSwitchToPickingMode.TabIndex = 27;
			ButtonSwitchToPickingMode.Text = "Switch to Picking Mode";
			ButtonSwitchToPickingMode.UseVisualStyleBackColor = true;
			ButtonSwitchToPickingMode.Click += ButtonSwitchToPickingMode_Click;
			// 
			// ButtonSwitchToStockMode
			// 
			ButtonSwitchToStockMode.AutoSize = true;
			ButtonSwitchToStockMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonSwitchToStockMode.Location = new System.Drawing.Point(9, 195);
			ButtonSwitchToStockMode.Name = "ButtonSwitchToStockMode";
			ButtonSwitchToStockMode.Size = new System.Drawing.Size(132, 25);
			ButtonSwitchToStockMode.TabIndex = 28;
			ButtonSwitchToStockMode.Text = "Switch to Stock Mode";
			ButtonSwitchToStockMode.UseVisualStyleBackColor = true;
			ButtonSwitchToStockMode.Click += ButtonSwitchToStockMode_Click;
			// 
			// ButtonTurnBuzzerOff
			// 
			ButtonTurnBuzzerOff.AutoSize = true;
			ButtonTurnBuzzerOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonTurnBuzzerOff.Location = new System.Drawing.Point(147, 195);
			ButtonTurnBuzzerOff.Name = "ButtonTurnBuzzerOff";
			ButtonTurnBuzzerOff.Size = new System.Drawing.Size(98, 25);
			ButtonTurnBuzzerOff.TabIndex = 29;
			ButtonTurnBuzzerOff.Text = "Turn Buzzer Off";
			ButtonTurnBuzzerOff.UseVisualStyleBackColor = true;
			ButtonTurnBuzzerOff.Click += ButtonTurnBuzzerOff_Click;
			// 
			// ButtonTurnBuzzerOn
			// 
			ButtonTurnBuzzerOn.AutoSize = true;
			ButtonTurnBuzzerOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonTurnBuzzerOn.Location = new System.Drawing.Point(251, 195);
			ButtonTurnBuzzerOn.Name = "ButtonTurnBuzzerOn";
			ButtonTurnBuzzerOn.Size = new System.Drawing.Size(97, 25);
			ButtonTurnBuzzerOn.TabIndex = 30;
			ButtonTurnBuzzerOn.Text = "Turn Buzzer On";
			ButtonTurnBuzzerOn.UseVisualStyleBackColor = true;
			ButtonTurnBuzzerOn.Click += ButtonTurnBuzzerOn_Click;
			// 
			// ButtonTurnLedOff
			// 
			ButtonTurnLedOff.AutoSize = true;
			ButtonTurnLedOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonTurnLedOff.Location = new System.Drawing.Point(354, 195);
			ButtonTurnLedOff.Name = "ButtonTurnLedOff";
			ButtonTurnLedOff.Size = new System.Drawing.Size(83, 25);
			ButtonTurnLedOff.TabIndex = 31;
			ButtonTurnLedOff.Text = "Turn Led Off";
			ButtonTurnLedOff.UseVisualStyleBackColor = true;
			ButtonTurnLedOff.Click += ButtonTurnLedOff_Click;
			// 
			// ButtonTurnLedOn
			// 
			ButtonTurnLedOn.AutoSize = true;
			ButtonTurnLedOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ButtonTurnLedOn.Location = new System.Drawing.Point(443, 195);
			ButtonTurnLedOn.Name = "ButtonTurnLedOn";
			ButtonTurnLedOn.Size = new System.Drawing.Size(82, 25);
			ButtonTurnLedOn.TabIndex = 32;
			ButtonTurnLedOn.Text = "Turn Led On";
			ButtonTurnLedOn.UseVisualStyleBackColor = true;
			ButtonTurnLedOn.Click += ButtonTurnLedOn_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(DataGridViewPickTags);
			Controls.Add(FlowLayoutPanelCommunicationControlBlockButtons);
			Controls.Add(FlowLayoutPanelConnectionButtons);
			Name = "MainForm";
			ShowIcon = false;
			Text = "Pick-to-Light";
			FlowLayoutPanelConnectionButtons.ResumeLayout(false);
			FlowLayoutPanelConnectionButtons.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DataGridViewPickTags).EndInit();
			FlowLayoutPanelCommunicationControlBlockButtons.ResumeLayout(false);
			FlowLayoutPanelCommunicationControlBlockButtons.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion

		private System.Windows.Forms.Button ButtonChangeAvailableDigitsForCounting;
		private System.Windows.Forms.Button ButtonChangeBlinkingTimeInterval;
		private System.Windows.Forms.Button ButtonChangeColor;
		private System.Windows.Forms.Button ButtonChangeDigitsBrightness;
		private System.Windows.Forms.Button ButtonChangeFlashingTimeInterval;
		private System.Windows.Forms.Button ButtonChangeNodeAddress;
		private System.Windows.Forms.Button ButtonChangePickTagConfigurationWithSpecialFunctionOne;
		private System.Windows.Forms.Button ButtonChangePickTagConfigurationWithSpecialFunctionTwo;
		private System.Windows.Forms.Button ButtonChangePickTagModeConfiguration;
		private System.Windows.Forms.Button ButtonChangePollingRange;
		private System.Windows.Forms.Button ButtonChangeValidDigitsForCounting;
		private System.Windows.Forms.Button ButtonDisableConfirmationButton;
		private System.Windows.Forms.Button ButtonDisableShortageButton;
		private System.Windows.Forms.Button ButtonDisplayNodeAddress;
		private System.Windows.Forms.Button ButtonEmulateConfirmationButtonPressing;
		private System.Windows.Forms.Button ButtonEmulateShortageButtonPressing;
		private System.Windows.Forms.Button ButtonEnableConfirmationButton;
		private System.Windows.Forms.Button ButtonEnableShortageButton;
		private System.Windows.Forms.Button ButtonFlash;
		private System.Windows.Forms.Button ButtonRequestConnectedPickTags;
		private System.Windows.Forms.Button ButtonRequestPickTagDetails;
		private System.Windows.Forms.Button ButtonRequestPickTagModel;
		private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.Button ButtonSwitchToPickingMode;
		private System.Windows.Forms.Button ButtonSwitchToStockMode;
		private System.Windows.Forms.Button ButtonTurnBuzzerOff;
		private System.Windows.Forms.Button ButtonTurnBuzzerOn;
		private System.Windows.Forms.Button ButtonTurnLedOff;
		private System.Windows.Forms.Button ButtonTurnLedOn;
	}
}