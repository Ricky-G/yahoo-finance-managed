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

namespace YahooManaged.Services.Base
{

    internal class PostDataUpload : DownloadClient<System.IO.Stream>
    {
        public PostDataUploadSettings Settings { get { return (PostDataUploadSettings)base.Settings; } set { base.SetSettings(value); } }

        public PostDataUpload()
        {
            this.Settings = new PostDataUploadSettings();
        }

        protected override System.IO.Stream ConvertResult(ConnectionInfo connInfo, System.IO.Stream stream, SettingsBase settings)
        {
            return MyHelper.CopyStream(stream);
        }

    }

    
    internal class PostDataUploadSettings : SettingsBase
    {
        public YahooManaged.IAccountManager Account { get; set; }
        public string PostStringData { get; set; }
        public string UrlString { get; set; }
        public bool DownloadResponse { get; set; }
        protected override System.Net.CookieContainer Cookies { get { return this.Account != null ? this.Account.Cookies : null; } }
        protected override RequestMethod Method { get { return RequestMethod.POST; } }
        protected override string PostData { get { return this.PostStringData; } }
        protected override string ContentType { get { return "application/x-www-form-urlencoded"; } }
        protected override bool DownloadResponseStream { get { return this.DownloadResponse; } }

        public PostDataUploadSettings()
        {
            this.PostStringData = string.Empty;
            this.UrlString = string.Empty;
            this.DownloadResponse = false;
        }

        protected override string GetUrl()
        {
            return this.UrlString;
        }

        public override object Clone()
        {
            return new PostDataUploadSettings() { Account = this.Account, PostStringData = this.PostStringData, UrlString = this.UrlString, DownloadResponse = this.DownloadResponse };
        }
    }


}
