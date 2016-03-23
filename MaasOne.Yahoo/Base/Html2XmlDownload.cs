// ******************************************************************************
// ** 
// **  Yahoo! Managed
// **  Originally written by Marius Häusler 2012
// **  Now it is maintained by the public community on GitHub
// **  Any contributions will be greatly appreciated.  Please go to be project home below and create a fork, make your change and merge back.
// **  Project Home: https://github.com/RickyGAkl/yahoo-finance-managed
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius Häusler
// **  
// **  Licensed under the Apache License, Version 2.0 (the "License");
// **  you may not use this file except in compliance with the License.
// **  You may obtain a copy of the License at
// **  
// **    http://www.apache.org/licenses/LICENSE-2.0
// **  
// **  Unless required by applicable law or agreed to in writing, software
// **  distributed under the License is distributed on an "AS IS" BASIS,
// **  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// **  See the License for the specific language governing permissions and
// **  limitations under the License.
// ** 
// ******************************************************************************

using YahooManaged.Base;
using YahooManaged.Xml;

namespace YahooManaged.Services.Base
{
    internal partial class Html2XmlDownload : DownloadClient<XDocument>
    {

        public Html2XmlDownloadSettings Settings { get { return (Html2XmlDownloadSettings)base.Settings; } set { base.SetSettings(value); } }

        public Html2XmlDownload()
        {
            this.Settings = new Html2XmlDownloadSettings();
        }

        protected override XDocument ConvertResult(ConnectionInfo connInfo, System.IO.Stream stream, SettingsBase settings)
        {
            return MyHelper.ParseXmlDocument(stream);
        }

    }





    internal class Html2XmlDownloadSettings : SettingsBase
    {
        public YahooManaged.IAccountManager Account { get; set; }
        public string Url { get; set; }
        public bool DownloadStream { get; set; }
        protected override System.Net.CookieContainer Cookies { get { return this.Account != null ? this.Account.Cookies : null; } }
        protected override bool DownloadResponseStream { get { return this.DownloadStream; } }

        public Html2XmlDownloadSettings()
        {
            this.DownloadStream = true;
        }

        protected override string GetUrl()
        {
            return this.Url;
        }

        public override object Clone()
        {
            return new Html2XmlDownloadSettings() { Account = this.Account, Url = this.Url };
        }
    }
}
