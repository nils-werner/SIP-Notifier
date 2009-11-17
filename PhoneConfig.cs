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
using System.Text;
using System.Xml;
using Sipek.Common;

namespace SIP_Notifier
{
    internal class PhoneConfig : IConfiguratorInterface
    {

        SIP_Notifier.Phone settings = SIP_Notifier.Phone.Default;

        List<IAccount> _acclist = new List<IAccount>();

        internal PhoneConfig()
        {
            _acclist.Add(new AccountConfig());
        }

        #region IConfiguratorInterface Members

        public bool AAFlag
        {
            get
            {
                return false;
            }
            set { }
        }

        public List<IAccount> Accounts
        {
            get { return _acclist; }
        }

        public bool CFBFlag
        {
            get { return settings.CFBFlag; }
            set { settings.CFBFlag = value; }
        }

        public string CFBNumber
        {
            get { return settings.CFBNumber; }
            set { settings.CFBNumber = value; }
        }

        public bool CFNRFlag
        {
            get { return settings.CFNRFlag; }
            set { settings.CFNRFlag = value; }
        }

        public string CFNRNumber
        {
            get { return settings.CFNRNumber; }
            set { settings.CFNRNumber = value; }
        }

        public bool CFUFlag
        {
            get { return settings.CFUFlag; }
            set { settings.CFUFlag = value; }
        }

        public string CFUNumber
        {
            get { return settings.CFUNumber; }
            set { settings.CFUNumber = value; }
        }

        public List<string> CodecList
        {
            get
            {
                List<String> cl = new List<string>();
                cl.Add("PCMA");
                return cl;
            }
            set { }
        }

        public bool DNDFlag
        {
            get { return settings.DNDFlag; }
            set { settings.DNDFlag = value; }
        }

        public int DefaultAccountIndex
        {
            get { return 0; }
        }

        public bool IsNull
        {
            get { return false; }
        }

        public bool PublishEnabled
        {
            get { return settings.PublishEnabled; }
            set { settings.PublishEnabled = value; }
        }

        public int SIPPort
        {
            get { return settings.SIPPort; }
            set { settings.SIPPort = value; }
        }

        public void Save()
        {
            settings.Save();
            _acclist.ForEach(delegate(IAccount account)
            {
            });
        }

        #endregion
    }

    class AccountConfig : IAccount
    {
        SIP_Notifier.Accounts settings = SIP_Notifier.Accounts.Default;

        #region IAccount Members

        public string AccountName
        {
            get { return settings.AccountName; }
            set { settings.AccountName = value; }
        }

        public string DisplayName
        {
            get { return settings.DisplayName; }
            set { settings.DisplayName = value; }
        }

        public string DomainName
        {
            get { return settings.DomainName; }
            set { settings.DomainName = value; }
        }

        public bool Enabled
        {
            get { return settings.Enabled; }
            set { settings.Enabled = value; }
        }

        public string HostName
        {
            get { return settings.HostName; }
            set { settings.HostName = value; }
        }

        public string Id
        {
            get { return settings.Id; }
            set { settings.Id = value; }
        }

        public int Index
        {
            get { return settings.Index; }
            set { }
        }

        public string Password
        {
            get { return settings.Password; }
            set { settings.Password = value; }
        }

        public string ProxyAddress
        {
            get { return settings.ProxyAddress; }
            set { settings.ProxyAddress = value; }
        }

        public int RegState
        {
            get { return settings.RegState; }
            set { settings.RegState = value; }
        }

        public ETransportMode TransportMode
        {
            get 
            {
                return ETransportMode.TM_UDP;
            }
            set { }
        }

        public string UserName
        {
            get { return settings.UserName; }
            set { settings.UserName = value; }
        }

        public void Save()
        {
            settings.Save();
        }

        #endregion
    }
}
