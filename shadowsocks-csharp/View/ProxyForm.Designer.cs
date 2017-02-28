﻿namespace Shadowsocks.View
{
    partial class ProxyForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.UseProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProxyAddrLabel = new System.Windows.Forms.Label();
            this.ProxyServerTextBox = new System.Windows.Forms.TextBox();
            this.ProxyPortLabel = new System.Windows.Forms.Label();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ProxyTypeLabel = new System.Windows.Forms.Label();
            this.ProxyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProxyTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.ProxyTimeoutLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UseProxyCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(236, 94);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(159, 26);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyCancelButton.Location = new System.Drawing.Point(84, 3);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(75, 23);
            this.MyCancelButton.TabIndex = 13;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UseProxyCheckBox
            // 
            this.UseProxyCheckBox.AutoSize = true;
            this.UseProxyCheckBox.Location = new System.Drawing.Point(3, 3);
            this.UseProxyCheckBox.Name = "UseProxyCheckBox";
            this.UseProxyCheckBox.Size = new System.Drawing.Size(78, 16);
            this.UseProxyCheckBox.TabIndex = 0;
            this.UseProxyCheckBox.Text = "Use Proxy";
            this.UseProxyCheckBox.UseVisualStyleBackColor = true;
            this.UseProxyCheckBox.CheckedChanged += new System.EventHandler(this.UseProxyCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ProxyAddrLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProxyServerTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProxyPortLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProxyPortTextBox, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 27);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ProxyAddrLabel
            // 
            this.ProxyAddrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyAddrLabel.AutoSize = true;
            this.ProxyAddrLabel.Location = new System.Drawing.Point(3, 7);
            this.ProxyAddrLabel.Name = "ProxyAddrLabel";
            this.ProxyAddrLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyAddrLabel.TabIndex = 0;
            this.ProxyAddrLabel.Text = "Proxy Addr";
            // 
            // ProxyServerTextBox
            // 
            this.ProxyServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyServerTextBox.Location = new System.Drawing.Point(74, 3);
            this.ProxyServerTextBox.MaxLength = 512;
            this.ProxyServerTextBox.Name = "ProxyServerTextBox";
            this.ProxyServerTextBox.Size = new System.Drawing.Size(135, 21);
            this.ProxyServerTextBox.TabIndex = 1;
            this.ProxyServerTextBox.WordWrap = false;
            // 
            // ProxyPortLabel
            // 
            this.ProxyPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyPortLabel.AutoSize = true;
            this.ProxyPortLabel.Location = new System.Drawing.Point(215, 7);
            this.ProxyPortLabel.Name = "ProxyPortLabel";
            this.ProxyPortLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyPortLabel.TabIndex = 2;
            this.ProxyPortLabel.Text = "Proxy Port";
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyPortTextBox.Location = new System.Drawing.Point(286, 3);
            this.ProxyPortTextBox.MaxLength = 10;
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(100, 21);
            this.ProxyPortTextBox.TabIndex = 3;
            this.ProxyPortTextBox.WordWrap = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.ProxyTypeLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ProxyTypeComboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ProxyTimeoutTextBox, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.ProxyTimeoutLabel, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(387, 30);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // ProxyTypeLabel
            // 
            this.ProxyTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTypeLabel.AutoSize = true;
            this.ProxyTypeLabel.Location = new System.Drawing.Point(3, 9);
            this.ProxyTypeLabel.Name = "ProxyTypeLabel";
            this.ProxyTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyTypeLabel.TabIndex = 1;
            this.ProxyTypeLabel.Text = "Proxy Type";
            // 
            // ProxyTypeComboBox
            // 
            this.ProxyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProxyTypeComboBox.FormattingEnabled = true;
            this.ProxyTypeComboBox.Items.AddRange(new object[] {
            "SOCKS5",
            "HTTP"});
            this.ProxyTypeComboBox.Location = new System.Drawing.Point(74, 5);
            this.ProxyTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ProxyTypeComboBox.Name = "ProxyTypeComboBox";
            this.ProxyTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.ProxyTypeComboBox.TabIndex = 2;
            // 
            // ProxyTimeoutTextBox
            // 
            this.ProxyTimeoutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTimeoutTextBox.Location = new System.Drawing.Point(284, 4);
            this.ProxyTimeoutTextBox.Name = "ProxyTimeoutTextBox";
            this.ProxyTimeoutTextBox.Size = new System.Drawing.Size(100, 21);
            this.ProxyTimeoutTextBox.TabIndex = 3;
            // 
            // ProxyTimeoutLabel
            // 
            this.ProxyTimeoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTimeoutLabel.AutoSize = true;
            this.ProxyTimeoutLabel.Location = new System.Drawing.Point(201, 9);
            this.ProxyTimeoutLabel.Name = "ProxyTimeoutLabel";
            this.ProxyTimeoutLabel.Size = new System.Drawing.Size(77, 12);
            this.ProxyTimeoutLabel.TabIndex = 4;
            this.ProxyTimeoutLabel.Text = "Timeout(Sec)";
            // 
            // ProxyForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.MyCancelButton;
            this.ClientSize = new System.Drawing.Size(441, 165);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProxyForm";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Proxy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProxyForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox UseProxyCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ProxyAddrLabel;
        private System.Windows.Forms.TextBox ProxyServerTextBox;
        private System.Windows.Forms.Label ProxyPortLabel;
        private System.Windows.Forms.TextBox ProxyPortTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label ProxyTypeLabel;
        private System.Windows.Forms.ComboBox ProxyTypeComboBox;
        private System.Windows.Forms.TextBox ProxyTimeoutTextBox;
        private System.Windows.Forms.Label ProxyTimeoutLabel;
    }
}