namespace PickToLight.Client.WinForms.Forms {
	using PickToLight.Core.Models;
	using PickToLight.Core.Models.Enums;
	using System.Drawing;
	using System;
	using System.Windows.Forms;
	public partial class MainForm : Form {
		#region Fields
		private readonly Controller _controller;
		#endregion
		#region Constructors
		public MainForm() {
			InitializeComponent();
			_controller = new(
				ipAddress: "192.168.1.11",
				port: 4660,
				controllerModel: ControllerModel.AT500Plus,
				pickTagsCount: 2
			);
			_controller.Update += () => {
				DataGridViewPickTags.Invoke(() => {
					DataGridViewPickTags.Refresh();
				});
			};
			DataGridViewPickTags.EnabledChanged += DataGridViewPickTags_EnabledChanged!;
			DataGridViewPickTags.Enabled = false;
			DataGridViewPickTags.DataSource = _controller.PickTags;
		}
		#endregion
		#region Methods
		private void ButtonClear_Click(object sender, EventArgs e) {
			_controller.Clear();
		}
		private void ButtonConnect_Click(object sender, EventArgs e) {
			_controller.Connect();
			if (_controller.IsConnected) {
				ButtonConnect.Enabled = false;
				ButtonDisconnect.Enabled = true;
				FlowLayoutPanelCommunicationControlBlockButtons.Enabled = true;
				DataGridViewPickTags.Enabled = true;
			}
		}
		private void ButtonDisconnect_Click(object sender, EventArgs e) {
			_controller.Disconnect();
			if (!_controller.IsConnected) {
				ButtonConnect.Enabled = true;
				ButtonDisconnect.Enabled = false;
				FlowLayoutPanelCommunicationControlBlockButtons.Enabled = false;
				DataGridViewPickTags.Enabled = false;
			}
		}
		private void ButtonDisplay_Click(object sender, EventArgs e) {
			_controller.Display("01234", 1);
			_controller.Display("56789", 2);
		}
		#endregion
		private void ButtonChangeAvailableDigitsForCounting_Click(object sender, EventArgs e) {
			_controller.ChangeAvailableDigitsForCounting(5);
		}
		private void ButtonChangeBlinkingTimeInterval_Click(object sender, EventArgs e) {
			_controller.ChangeBlinkingTimeInterval(BlinkingTimeInterval.OneSecond, 1);
			_controller.ChangeBlinkingTimeInterval(BlinkingTimeInterval.TwoSeconds, 2);
		}
		private void ButtonChangeColor_Click(object sender, EventArgs e) {
			_controller.ChangeColor(Core.Models.Enums.Color.Green, 1);
			_controller.ChangeColor(Core.Models.Enums.Color.Orange, 2);
		}
		private void ButtonChangeDigitsBrightness_Click(object sender, EventArgs e) {
			_controller.ChangeDigitsBrightness(new() {
				ShouldDimFifthDigitBrightness = false,
				ShouldDimFirstDigitBrightness = false,
				ShouldDimFourthDigitBrightness = false,
				ShouldDimSecondDigitBrightness = false,
				ShouldDimThirdDigitBrightness = false,
				ShouldDimSixthDigitBrightness = false
			}, 1);
			_controller.ChangeDigitsBrightness(new() {
				ShouldDimFifthDigitBrightness = true,
				ShouldDimFirstDigitBrightness = true,
				ShouldDimFourthDigitBrightness = true,
				ShouldDimSecondDigitBrightness = true,
				ShouldDimThirdDigitBrightness = true,
				ShouldDimSixthDigitBrightness = true
			}, 2);
		}
		private void ButtonChangeFlashingTimeInterval_Click(object sender, EventArgs e) {
			_controller.ChangeFlashingTimeInterval(FlashingTimeInterval.OneSecond, 1);
			_controller.ChangeFlashingTimeInterval(FlashingTimeInterval.TwoSeconds, 2);
		}
		private void ButtonChangeNodeAddress_Click(object sender, EventArgs e) {
			//
		}
		private void ButtonChangePickTagConfigurationWithSpecialFunctionOne_Click(object sender, EventArgs e) {
			_controller.ChangePickTagConfigurationWithSpecialFunctionOne(new() {
				PickTagMode = PickTagMode.Picking
			}, 1);
			_controller.ChangePickTagConfigurationWithSpecialFunctionOne(new() {
				PickTagMode = PickTagMode.Stock
			}, 2);
		}
		private void ButtonChangePickTagConfigurationWithSpecialFunctionTwo_Click(object sender, EventArgs e) {
			_controller.ChangePickTagConfigurationWithSpecialFunctionTwo(new() {
				IsAliveIndicatorEnabled = true
			}, 1);
			_controller.ChangePickTagConfigurationWithSpecialFunctionTwo(new() {
				IsAliveIndicatorEnabled = false
			}, 2);
		}
		private void ButtonChangePickTagModeConfiguration_Click(object sender, EventArgs e) {
			_controller.ChangePickTagModeConfiguration(new() {
				IsKeyCodeReturnEnabled = true,
			}, 1);
			_controller.ChangePickTagModeConfiguration(new() {
				IsKeyCodeReturnEnabled = false,
			}, 2);
		}
		private void ButtonChangePollingRange_Click(object sender, EventArgs e) {
			_controller.ChangePollingRange(2);
		}
		private void ButtonChangeValidDigitsForCounting_Click(object sender, EventArgs e) {
			_controller.ChangeValidDigitsForCounting(new() {
				IsFirstDigitValid = true,
				IsSecondDigitValid = false,
				IsThirdDigitValid = false,
				IsFourthDigitValid = false,
				IsFifthDigitValid = false,
				IsSixthDigitValid = false,
				IsSeventhValid = false,
				IsEighthValid = false,
			}, 1);
			_controller.ChangeValidDigitsForCounting(new() {
				IsFirstDigitValid = true,
				IsSecondDigitValid = true,
				IsThirdDigitValid = true,
				IsFourthDigitValid = false,
				IsFifthDigitValid = false,
				IsSixthDigitValid = false,
				IsSeventhValid = false,
				IsEighthValid = false,
			}, 2);
		}
		private void ButtonDisableConfirmationButton_Click(object sender, EventArgs e) {
			_controller.DisableConfirmationButton();
		}
		private void ButtonDisableShortageButton_Click(object sender, EventArgs e) {
			_controller.DisableShortageButton();
		}
		private void ButtonDisplayNodeAddress_Click(object sender, EventArgs e) {
			_controller.DisplayNodeAddress();
		}
		private void ButtonEmulateConfirmationButtonPressing_Click(object sender, EventArgs e) {
			_controller.EmulateConfirmationButtonPressing();
		}
		private void ButtonEmulateShortageButtonPressing_Click(object sender, EventArgs e) {
			_controller.EmulateShortageButtonPressing();
		}
		private void ButtonEnableConfirmationButton_Click(object sender, EventArgs e) {
			_controller.EnableConfirmationButton();
		}
		private void ButtonEnableShortageButton_Click(object sender, EventArgs e) {
			_controller.EnableShortageButton();
		}
		private void ButtonFlash_Click(object sender, EventArgs e) {
			_controller.Flash();
		}
		private void ButtonRequestConnectedPickTags_Click(object sender, EventArgs e) {
			_controller.RequestConnectedPickTags();
		}
		private void ButtonRequestPickTagDetails_Click(object sender, EventArgs e) {
			_controller.RequestPickTagDetails();
		}
		private void ButtonRequestPickTagModel_Click(object sender, EventArgs e) {
			_controller.RequestPickTagModel();
		}
		private void ButtonReset_Click(object sender, EventArgs e) {
			_controller.Reset();
		}
		private void ButtonSwitchToPickingMode_Click(object sender, EventArgs e) {
			_controller.SwitchToPickingMode();
		}
		private void ButtonSwitchToStockMode_Click(object sender, EventArgs e) {
			_controller.SwitchToStockMode();
		}
		private void ButtonTurnBuzzerOff_Click(object sender, EventArgs e) {
			_controller.TurnBuzzerOff();
		}
		private void ButtonTurnBuzzerOn_Click(object sender, EventArgs e) {
			_controller.TurnBuzzerOn();
		}
		private void ButtonTurnLedOff_Click(object sender, EventArgs e) {
			_controller.TurnLedOff();
		}
		private void ButtonTurnLedOn_Click(object sender, EventArgs e) {
			_controller.TurnLedOn();
		}
		private void DataGridViewPickTags_EnabledChanged(object sender, EventArgs e) {
			DataGridView? dataGridView = sender as DataGridView;
			if (!dataGridView!.Enabled) {
				dataGridView.DefaultCellStyle.BackColor = SystemColors.Control;
				dataGridView.DefaultCellStyle.ForeColor = SystemColors.GrayText;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
			} else {
				dataGridView.DefaultCellStyle.BackColor = SystemColors.Window;
				dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
			}
		}
	}
}