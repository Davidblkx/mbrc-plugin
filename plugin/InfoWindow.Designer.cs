namespace MusicBeeRemoteCore
{
    partial class InfoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.internalIPList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.allowedLabel = new System.Windows.Forms.Label();
            this.allowedAddressesComboBox = new System.Windows.Forms.ComboBox();
            this.removeAddressButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ipAddressInputTextBox = new System.Windows.Forms.TextBox();
            this.allowLabel = new System.Windows.Forms.Label();
            this.selectionFilteringComboBox = new System.Windows.Forms.ComboBox();
            this.seperator2 = new System.Windows.Forms.Label();
            this.addressFilteringCategoryLabel = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            this.seperator1 = new System.Windows.Forms.Label();
            this.connectionSettingsCategoryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cached_tracks_label = new System.Windows.Forms.Label();
            this.cached_covers_label = new System.Windows.Forms.Label();
            this.cachedTracksValue = new System.Windows.Forms.Label();
            this.cachedCoversValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.httpPortInput = new System.Windows.Forms.NumericUpDown();
            this.updateFirewallRules = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpPortInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plugin Version:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(122, 331);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(40, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "0.0.0.0";
            // 
            // internalIPList
            // 
            this.internalIPList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.internalIPList.FormattingEnabled = true;
            this.internalIPList.Location = new System.Drawing.Point(325, 136);
            this.internalIPList.Name = "internalIPList";
            this.internalIPList.Size = new System.Drawing.Size(119, 158);
            this.internalIPList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Green;
            this.statusLabel.Location = new System.Drawing.Point(66, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Private address list";
            // 
            // rangeNumericUpDown
            // 
            this.rangeNumericUpDown.Location = new System.Drawing.Point(241, 260);
            this.rangeNumericUpDown.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.rangeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeNumericUpDown.Name = "rangeNumericUpDown";
            this.rangeNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.rangeNumericUpDown.TabIndex = 28;
            this.rangeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(241, 291);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(21, 21);
            this.addAddressButton.TabIndex = 15;
            this.addAddressButton.Text = "+";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.AddAddressButtonClick);
            // 
            // allowedLabel
            // 
            this.allowedLabel.AutoSize = true;
            this.allowedLabel.Location = new System.Drawing.Point(21, 294);
            this.allowedLabel.Name = "allowedLabel";
            this.allowedLabel.Size = new System.Drawing.Size(47, 13);
            this.allowedLabel.TabIndex = 30;
            this.allowedLabel.Text = "Allowed:";
            // 
            // allowedAddressesComboBox
            // 
            this.allowedAddressesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowedAddressesComboBox.FormattingEnabled = true;
            this.allowedAddressesComboBox.Location = new System.Drawing.Point(125, 291);
            this.allowedAddressesComboBox.Name = "allowedAddressesComboBox";
            this.allowedAddressesComboBox.Size = new System.Drawing.Size(110, 21);
            this.allowedAddressesComboBox.TabIndex = 19;
            // 
            // removeAddressButton
            // 
            this.removeAddressButton.Location = new System.Drawing.Point(263, 291);
            this.removeAddressButton.Name = "removeAddressButton";
            this.removeAddressButton.Size = new System.Drawing.Size(21, 21);
            this.removeAddressButton.TabIndex = 17;
            this.removeAddressButton.Text = "-";
            this.removeAddressButton.UseVisualStyleBackColor = true;
            this.removeAddressButton.Click += new System.EventHandler(this.RemoveAddressButtonClick);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 263);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 27;
            this.addressLabel.Text = "Address:";
            // 
            // ipAddressInputTextBox
            // 
            this.ipAddressInputTextBox.Location = new System.Drawing.Point(125, 260);
            this.ipAddressInputTextBox.Name = "ipAddressInputTextBox";
            this.ipAddressInputTextBox.Size = new System.Drawing.Size(110, 20);
            this.ipAddressInputTextBox.TabIndex = 26;
            this.ipAddressInputTextBox.TextChanged += new System.EventHandler(this.HandleIpAddressInputTextBoxTextChanged);
            // 
            // allowLabel
            // 
            this.allowLabel.AutoSize = true;
            this.allowLabel.Location = new System.Drawing.Point(20, 233);
            this.allowLabel.Name = "allowLabel";
            this.allowLabel.Size = new System.Drawing.Size(35, 13);
            this.allowLabel.TabIndex = 25;
            this.allowLabel.Text = "Allow:";
            // 
            // selectionFilteringComboBox
            // 
            this.selectionFilteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionFilteringComboBox.FormattingEnabled = true;
            this.selectionFilteringComboBox.Items.AddRange(new object[] {
            "All",
            "Range",
            "Specified"});
            this.selectionFilteringComboBox.Location = new System.Drawing.Point(125, 230);
            this.selectionFilteringComboBox.Name = "selectionFilteringComboBox";
            this.selectionFilteringComboBox.Size = new System.Drawing.Size(159, 21);
            this.selectionFilteringComboBox.TabIndex = 24;
            this.selectionFilteringComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionFilteringComboBoxSelectedIndexChanged);
            // 
            // seperator2
            // 
            this.seperator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seperator2.Location = new System.Drawing.Point(19, 216);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(265, 1);
            this.seperator2.TabIndex = 23;
            // 
            // addressFilteringCategoryLabel
            // 
            this.addressFilteringCategoryLabel.AutoSize = true;
            this.addressFilteringCategoryLabel.Location = new System.Drawing.Point(20, 202);
            this.addressFilteringCategoryLabel.Name = "addressFilteringCategoryLabel";
            this.addressFilteringCategoryLabel.Size = new System.Drawing.Size(85, 13);
            this.addressFilteringCategoryLabel.TabIndex = 22;
            this.addressFilteringCategoryLabel.Text = "Address Allowed";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(125, 136);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(159, 20);
            this.portNumericUpDown.TabIndex = 21;
            this.portNumericUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(20, 138);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(66, 13);
            this.portLabel.TabIndex = 20;
            this.portLabel.Text = "Socket Port:";
            // 
            // seperator1
            // 
            this.seperator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seperator1.Location = new System.Drawing.Point(19, 126);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(265, 1);
            this.seperator1.TabIndex = 18;
            // 
            // connectionSettingsCategoryLabel
            // 
            this.connectionSettingsCategoryLabel.AutoSize = true;
            this.connectionSettingsCategoryLabel.Location = new System.Drawing.Point(20, 112);
            this.connectionSettingsCategoryLabel.Name = "connectionSettingsCategoryLabel";
            this.connectionSettingsCategoryLabel.Size = new System.Drawing.Size(102, 13);
            this.connectionSettingsCategoryLabel.TabIndex = 16;
            this.connectionSettingsCategoryLabel.Text = "Connection Settings";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(209, 326);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.HandleSaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cache";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(19, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 1);
            this.label5.TabIndex = 37;
            // 
            // cached_tracks_label
            // 
            this.cached_tracks_label.AutoSize = true;
            this.cached_tracks_label.Location = new System.Drawing.Point(21, 74);
            this.cached_tracks_label.Name = "cached_tracks_label";
            this.cached_tracks_label.Size = new System.Drawing.Size(43, 13);
            this.cached_tracks_label.TabIndex = 38;
            this.cached_tracks_label.Text = "Tracks:";
            // 
            // cached_covers_label
            // 
            this.cached_covers_label.AutoSize = true;
            this.cached_covers_label.Location = new System.Drawing.Point(21, 87);
            this.cached_covers_label.Name = "cached_covers_label";
            this.cached_covers_label.Size = new System.Drawing.Size(43, 13);
            this.cached_covers_label.TabIndex = 39;
            this.cached_covers_label.Text = "Covers:";
            // 
            // cachedTracksValue
            // 
            this.cachedTracksValue.AutoSize = true;
            this.cachedTracksValue.Location = new System.Drawing.Point(122, 74);
            this.cachedTracksValue.Name = "cachedTracksValue";
            this.cachedTracksValue.Size = new System.Drawing.Size(13, 13);
            this.cachedTracksValue.TabIndex = 40;
            this.cachedTracksValue.Text = "0";
            // 
            // cachedCoversValue
            // 
            this.cachedCoversValue.AutoSize = true;
            this.cachedCoversValue.Location = new System.Drawing.Point(122, 87);
            this.cachedCoversValue.Name = "cachedCoversValue";
            this.cachedCoversValue.Size = new System.Drawing.Size(13, 13);
            this.cachedCoversValue.TabIndex = 41;
            this.cachedCoversValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Http Port:";
            // 
            // httpPortInput
            // 
            this.httpPortInput.Location = new System.Drawing.Point(125, 164);
            this.httpPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.httpPortInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.httpPortInput.Name = "httpPortInput";
            this.httpPortInput.Size = new System.Drawing.Size(159, 20);
            this.httpPortInput.TabIndex = 43;
            this.httpPortInput.Value = new decimal(new int[] {
            8188,
            0,
            0,
            0});
            // 
            // updateFirewallRules
            // 
            this.updateFirewallRules.AutoSize = true;
            this.updateFirewallRules.Checked = true;
            this.updateFirewallRules.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateFirewallRules.Location = new System.Drawing.Point(315, 332);
            this.updateFirewallRules.Name = "updateFirewallRules";
            this.updateFirewallRules.Size = new System.Drawing.Size(129, 17);
            this.updateFirewallRules.TabIndex = 44;
            this.updateFirewallRules.Text = "Update Firewall Rules";
            this.updateFirewallRules.UseVisualStyleBackColor = true;
            // 
            // InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 356);
            this.Controls.Add(this.updateFirewallRules);
            this.Controls.Add(this.httpPortInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cachedCoversValue);
            this.Controls.Add(this.cachedTracksValue);
            this.Controls.Add(this.cached_covers_label);
            this.Controls.Add(this.cached_tracks_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rangeNumericUpDown);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.allowedLabel);
            this.Controls.Add(this.allowedAddressesComboBox);
            this.Controls.Add(this.removeAddressButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ipAddressInputTextBox);
            this.Controls.Add(this.allowLabel);
            this.Controls.Add(this.selectionFilteringComboBox);
            this.Controls.Add(this.seperator2);
            this.Controls.Add(this.addressFilteringCategoryLabel);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.seperator1);
            this.Controls.Add(this.connectionSettingsCategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.internalIPList);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MusicBee Remote: plugin";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.InfoWindow_HelpButtonClicked);
            this.Load += new System.EventHandler(this.InfoWindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpPortInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ListBox internalIPList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rangeNumericUpDown;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.Label allowedLabel;
        private System.Windows.Forms.ComboBox allowedAddressesComboBox;
        private System.Windows.Forms.Button removeAddressButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox ipAddressInputTextBox;
        private System.Windows.Forms.Label allowLabel;
        private System.Windows.Forms.ComboBox selectionFilteringComboBox;
        private System.Windows.Forms.Label seperator2;
        private System.Windows.Forms.Label addressFilteringCategoryLabel;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label seperator1;
        private System.Windows.Forms.Label connectionSettingsCategoryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cached_tracks_label;
        private System.Windows.Forms.Label cached_covers_label;
        private System.Windows.Forms.Label cachedTracksValue;
        private System.Windows.Forms.Label cachedCoversValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown httpPortInput;
        private System.Windows.Forms.CheckBox updateFirewallRules;
    }
}