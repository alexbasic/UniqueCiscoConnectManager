﻿namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    partial class SettingsForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.pathToClient_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pingAddress_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.calcel_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.vpnProfileName_textBox = new System.Windows.Forms.TextBox();
            this.reconnectDelay_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.verifyPeriod_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableBaypassTime_checkBox = new System.Windows.Forms.CheckBox();
            this.bypassFrom_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bypassTo_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reconnectDelay_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifyPeriod_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathToClient_textBox
            // 
            this.pathToClient_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathToClient_textBox.Location = new System.Drawing.Point(135, 12);
            this.pathToClient_textBox.Name = "pathToClient_textBox";
            this.pathToClient_textBox.Size = new System.Drawing.Size(387, 20);
            this.pathToClient_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to VPN client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping address";
            // 
            // pingAddress_textBox
            // 
            this.pingAddress_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingAddress_textBox.Location = new System.Drawing.Point(135, 38);
            this.pingAddress_textBox.Name = "pingAddress_textBox";
            this.pingAddress_textBox.Size = new System.Drawing.Size(387, 20);
            this.pingAddress_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reconnect delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verify period";
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(369, 250);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // calcel_button
            // 
            this.calcel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calcel_button.Location = new System.Drawing.Point(450, 250);
            this.calcel_button.Name = "calcel_button";
            this.calcel_button.Size = new System.Drawing.Size(75, 23);
            this.calcel_button.TabIndex = 9;
            this.calcel_button.Text = "Cancel";
            this.calcel_button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "VPN profile name";
            // 
            // vpnProfileName_textBox
            // 
            this.vpnProfileName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vpnProfileName_textBox.Location = new System.Drawing.Point(135, 116);
            this.vpnProfileName_textBox.Name = "vpnProfileName_textBox";
            this.vpnProfileName_textBox.Size = new System.Drawing.Size(387, 20);
            this.vpnProfileName_textBox.TabIndex = 10;
            // 
            // reconnectDelay_numericUpDown
            // 
            this.reconnectDelay_numericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.reconnectDelay_numericUpDown.Location = new System.Drawing.Point(293, 65);
            this.reconnectDelay_numericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.reconnectDelay_numericUpDown.Name = "reconnectDelay_numericUpDown";
            this.reconnectDelay_numericUpDown.Size = new System.Drawing.Size(229, 20);
            this.reconnectDelay_numericUpDown.TabIndex = 12;
            // 
            // verifyPeriod_numericUpDown
            // 
            this.verifyPeriod_numericUpDown.Location = new System.Drawing.Point(293, 91);
            this.verifyPeriod_numericUpDown.Name = "verifyPeriod_numericUpDown";
            this.verifyPeriod_numericUpDown.Size = new System.Drawing.Size(229, 20);
            this.verifyPeriod_numericUpDown.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bypassTo_maskedTextBox);
            this.groupBox1.Controls.Add(this.bypassFrom_maskedTextBox);
            this.groupBox1.Controls.Add(this.enableBaypassTime_checkBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baypass time";
            // 
            // enableBaypassTime_checkBox
            // 
            this.enableBaypassTime_checkBox.AutoSize = true;
            this.enableBaypassTime_checkBox.Location = new System.Drawing.Point(11, 19);
            this.enableBaypassTime_checkBox.Name = "enableBaypassTime_checkBox";
            this.enableBaypassTime_checkBox.Size = new System.Drawing.Size(123, 17);
            this.enableBaypassTime_checkBox.TabIndex = 18;
            this.enableBaypassTime_checkBox.Text = "Enable baypass time";
            this.enableBaypassTime_checkBox.UseVisualStyleBackColor = true;
            // 
            // bypassFrom_maskedTextBox
            // 
            this.bypassFrom_maskedTextBox.Location = new System.Drawing.Point(44, 45);
            this.bypassFrom_maskedTextBox.Mask = "00:00:00";
            this.bypassFrom_maskedTextBox.Name = "bypassFrom_maskedTextBox";
            this.bypassFrom_maskedTextBox.Size = new System.Drawing.Size(199, 20);
            this.bypassFrom_maskedTextBox.TabIndex = 19;
            // 
            // bypassTo_maskedTextBox
            // 
            this.bypassTo_maskedTextBox.Location = new System.Drawing.Point(285, 45);
            this.bypassTo_maskedTextBox.Mask = "00:00:00";
            this.bypassTo_maskedTextBox.Name = "bypassTo_maskedTextBox";
            this.bypassTo_maskedTextBox.Size = new System.Drawing.Size(216, 20);
            this.bypassTo_maskedTextBox.TabIndex = 20;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.calcel_button;
            this.ClientSize = new System.Drawing.Size(537, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verifyPeriod_numericUpDown);
            this.Controls.Add(this.reconnectDelay_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vpnProfileName_textBox);
            this.Controls.Add(this.calcel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pingAddress_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathToClient_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.reconnectDelay_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifyPeriod_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathToClient_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pingAddress_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button calcel_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vpnProfileName_textBox;
        private System.Windows.Forms.NumericUpDown reconnectDelay_numericUpDown;
        private System.Windows.Forms.NumericUpDown verifyPeriod_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox enableBaypassTime_checkBox;
        private System.Windows.Forms.MaskedTextBox bypassTo_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox bypassFrom_maskedTextBox;
    }
}