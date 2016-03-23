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
    internal partial class WebFormUpload
    {


        public Response<XDocument> Upload(WebFormDownloadSettings settings)
        {
            AsyncArgs args = new AsyncArgs(null) { Settings = settings };
            if (settings.Account.Crumb == string.Empty)
            {
                Html2XmlDownload html = new Html2XmlDownload();
                html.Settings.Account = settings.Account;
                html.Settings.Url = settings.Url;
                Response<XDocument> resp = html.Download();
                this.ConvertHtml(resp.Result, args);
            }
            PostDataUpload dl = new PostDataUpload();
            this.PrepareDownloader(dl, args);
            if (dl.Settings.PostStringData != string.Empty)
            {
                DefaultResponse<System.IO.Stream> resp = (DefaultResponse<System.IO.Stream>)dl.Download();
                return resp.CreateNew(MyHelper.ParseXmlDocument(resp.Result));
            }
            else
            {
                return null;
            }
        }
    }
}
