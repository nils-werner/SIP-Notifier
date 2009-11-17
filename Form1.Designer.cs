namespace SIP_Notifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxRegState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCallState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastCallNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLastCallDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelCancel = new System.Windows.Forms.LinkLabel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRegState
            // 
            this.textBoxRegState.Location = new System.Drawing.Point(232, 298);
            this.textBoxRegState.Name = "textBoxRegState";
            this.textBoxRegState.ReadOnly = true;
            this.textBoxRegState.Size = new System.Drawing.Size(122, 20);
            this.textBoxRegState.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registration Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Call Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCallState
            // 
            this.textBoxCallState.Location = new System.Drawing.Point(232, 332);
            this.textBoxCallState.Name = "textBoxCallState";
            this.textBoxCallState.ReadOnly = true;
            this.textBoxCallState.Size = new System.Drawing.Size(122, 20);
            this.textBoxCallState.TabIndex = 6;
            this.textBoxCallState.Text = "IDLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Call";
            // 
            // textBoxLastCallNumber
            // 
            this.textBoxLastCallNumber.Location = new System.Drawing.Point(97, 17);
            this.textBoxLastCallNumber.Name = "textBoxLastCallNumber";
            this.textBoxLastCallNumber.ReadOnly = true;
            this.textBoxLastCallNumber.Size = new System.Drawing.Size(228, 20);
            this.textBoxLastCallNumber.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxLastCallDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLastCallNumber);
            this.panel1.Location = new System.Drawing.Point(10, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 89);
            this.panel1.TabIndex = 9;
            // 
            // textBoxLastCallDate
            // 
            this.textBoxLastCallDate.Location = new System.Drawing.Point(97, 51);
            this.textBoxLastCallDate.Name = "textBoxLastCallDate";
            this.textBoxLastCallDate.ReadOnly = true;
            this.textBoxLastCallDate.Size = new System.Drawing.Size(228, 20);
            this.textBoxLastCallDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabelCancel);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxHostName);
            this.panel2.Location = new System.Drawing.Point(10, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 156);
            this.panel2.TabIndex = 12;
            // 
            // linkLabelCancel
            // 
            this.linkLabelCancel.AutoSize = true;
            this.linkLabelCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelCancel.Location = new System.Drawing.Point(158, 122);
            this.linkLabelCancel.Name = "linkLabelCancel";
            this.linkLabelCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabelCancel.TabIndex = 15;
            this.linkLabelCancel.TabStop = true;
            this.linkLabelCancel.Text = "Cancel";
            this.linkLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCancel_LinkClicked);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(221, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 24);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(97, 85);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(228, 20);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(97, 51);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(228, 20);
            this.textBoxUserName.TabIndex = 11;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Server";
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.HideSelection = false;
            this.textBoxHostName.Location = new System.Drawing.Point(97, 17);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(228, 20);
            this.textBoxHostName.TabIndex = 7;
            this.textBoxHostName.TextChanged += new System.EventHandler(this.textBoxHostName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCallState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegState);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SIP Notifier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCallState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastCallNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLastCallDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelCancel;
    }
}

