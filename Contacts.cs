using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP_Notifier
{
    class Contacts
    {
        XmlDocument document = new XmlDocument();

        public Contacts()
        {
        }

        public string lookup(string number)
        {
            
            try
            {
                string homedir = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                document.Load(homedir + "\\contacts.xml");
                XmlNode person = document.SelectSingleNode("/contacts/person[@number = '" + number.Trim() + "']/name");
                return person.InnerText;
            }
            catch (Exception e)
            {
                return number;
            }
        }
    }
}
