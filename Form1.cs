/* 
 * Copyright (C) 2008 Sasa Coh <sasacoh@gmail.com>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 
 * 
 * 
 * @see http://sites.google.com/site/sipekvoip/Home/documentation/tutorial
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common.CallControl;
using Sipek.Sip;
using Sipek.Common;

namespace SIP_Notifier
{
    public partial class Form1 : Form
    {
        #region Properties
        // Get call manager instance
        CCallManager CallManager = CCallManager.Instance;

        private PhoneConfig _config = new PhoneConfig();
        internal PhoneConfig Config
        {
            get { return _config; }
        }

        // instance of incoming call
        IStateMachine incall = null;

        private bool registered = false;

        private Contacts contacts = new Contacts();
        private NotifyIcon notifyIcon1 = new NotifyIcon();
        private ContextMenu contextMenu = new ContextMenu();
        #endregion

        #region Constructor
        public Form1()
        {
            try
            {
                InitializeComponent();

                InitializeWindow();

                InitializeSip();

            }
            catch (BadImageFormatException)
            {
            }
        }
        #endregion

        #region Methods
        private void InitializeWindow()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;

            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Text = "SIP Notifier";   // Eigenen Text einsetzen
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += new EventHandler(NotifyIconDoubleClick);



            contextMenu.MenuItems.Add(0,
                new MenuItem("Show/Hide", new System.EventHandler(NotifyIconDoubleClick)));
            contextMenu.MenuItems.Add(1,
                new MenuItem("Exit", new System.EventHandler(notifyIcon1_Close_Click)));

            notifyIcon1.ContextMenu = contextMenu;

            if (SIP_Notifier.Accounts.Default.HostName == "localhost")
            {
                notifyIcon1.BalloonTipTitle = "SIP Notifier";
                notifyIcon1.BalloonTipText = "Doubleclick this icon to set up your SIP account!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(30);
            }

        }

        private void InitializeSip() {
            if (registered == true || SIP_Notifier.Accounts.Default.HostName == "")
                return;

            textBoxRegState.Text = "Connecting";
            // register callbacks
            CallManager.CallStateRefresh += new DCallStateRefresh(CallManager_CallStateRefresh);
            CallManager.IncomingCallNotification += new DIncomingCallNotification(CallManager_IncomingCallNotification);

            pjsipRegistrar.Instance.AccountStateChanged += new Sipek.Common.DAccountStateChanged(Instance_AccountStateChanged);

            // Inject VoIP stack engine to CallManager
            CallManager.StackProxy = pjsipStackProxy.Instance;

            // Inject configuration settings SipekSdk
            CallManager.Config = Config;
            pjsipStackProxy.Instance.Config = Config;
            pjsipRegistrar.Instance.Config = Config;

            // Initialize
            CallManager.Initialize();
            // register accounts...
            pjsipRegistrar.Instance.registerAccounts();

            registered = true;
        }

        private void DeinitializeSip()
        {
            if (registered == false)
                return;
            pjsipRegistrar.Instance.unregisterAccounts();
            CallManager.Shutdown();
            pjsipStackProxy.Instance.shutdown();
            textBoxRegState.Text = "Disconnected";

            registered = false;
        }

        private void RestartSip()
        {
            DeinitializeSip();
            InitializeSip();
        }
        #endregion

        #region Callbacks
        void Instance_AccountStateChanged(int accountId, int accState)
        {
            // MUST synchronize threads
            if (InvokeRequired)
                this.BeginInvoke(new DAccountStateChanged(OnRegistrationUpdate), new object[] { accountId, accState });
            else
                OnRegistrationUpdate(accountId, accState);
        }


        void CallManager_CallStateRefresh(int sessionId)
        {
            // MUST synchronize threads
            if (InvokeRequired)
                this.BeginInvoke(new DCallStateRefresh(OnStateUpdate), new object[] { sessionId });
            else
                OnStateUpdate(sessionId);
        }

        void CallManager_IncomingCallNotification(int sessionId, string number, string info)
        {
            // MUST synchronize threads
            if (InvokeRequired)
                this.BeginInvoke(new DIncomingCallNotification(OnIncomingCall), new object[] { sessionId, number, info });
            else
                OnIncomingCall(sessionId, number, info);
        }
        #endregion

        #region Synhronized callbacks
        private void OnRegistrationUpdate(int accountId, int accState)
        {
            string stateDescription = "";
            switch (accState)
            {
                case 200: stateDescription = "OK";
                    break;

                case 408: stateDescription = "Request Timeout";
                    break;

                case 503: stateDescription = "Service Unavailable";
                    break;

                case 401: stateDescription = "Unauthorized";
                    break;

                case 403: stateDescription = "Forbidden";
                    break;

                case -1:
                case 171100: stateDescription = "Login failed";

                    break;

                default: stateDescription = "Unknown";
                    break;
            } 
            textBoxRegState.Text = accState.ToString() + " - " + stateDescription;
        }

        private void OnStateUpdate(int sessionId)
        {
            string text = CallManager.getCall(sessionId).StateId.ToString();
            if(text == "NULL")
                text = "IDLE";

            textBoxCallState.Text = text;
        }

        private void OnIncomingCall(int sessionId, string number, string info)
        {
            incall = CallManager.getCall(sessionId);
            string contact = contacts.lookup(number);
            if (contact != "")
                number = contact + " (" + number + ")";
            
            textBoxCallState.Text = incall.StateId.ToString();
            textBoxLastCallNumber.Text = number;
            textBoxLastCallDate.Text = DateTime.Now.ToString();

            notifyIcon1.BalloonTipTitle = "Eingehender Anruf";
            notifyIcon1.BalloonTipText = "Von: " + number + "\r\n" + info;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(30);
        }

        #endregion

        #region Button Handlers
        private void NotifyIconDoubleClick(object sender, System.EventArgs e)
        {
            if (this.ShowInTaskbar == true)
            {
                this.ShowInTaskbar = false;
                this.Visible = false;
            }
            else
            {
                SIP_Notifier.Accounts settings = SIP_Notifier.Accounts.Default;
                textBoxHostName.Text = settings.HostName;
                textBoxUserName.Text = settings.UserName;
                textBoxPassword.Text = settings.Password;
                buttonSave.Enabled = false;
                this.ShowInTaskbar = true;
                this.Visible = true;
                this.BringToFront();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxHostName.Text == "") {
                MessageBox.Show("Server hostname must not be empty!");
                return;
            }
            buttonSave.Enabled = false;
            SIP_Notifier.Accounts settings = SIP_Notifier.Accounts.Default;
            
            settings.HostName = textBoxHostName.Text;
            settings.UserName = textBoxUserName.Text;
            settings.Id = textBoxUserName.Text;
            settings.Password = textBoxPassword.Text;

            settings.Save();
            RestartSip();
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIP_Notifier.Accounts settings = SIP_Notifier.Accounts.Default;

            textBoxHostName.Text = settings.HostName;
            textBoxUserName.Text = settings.UserName;
            textBoxPassword.Text = settings.Password;
            buttonSave.Enabled = false;
        }

        private void notifyIcon1_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            notifyIcon1.Visible = false;
            base.OnClosing(e);
        }

        private void textBoxHostName_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }
        #endregion
    }
}