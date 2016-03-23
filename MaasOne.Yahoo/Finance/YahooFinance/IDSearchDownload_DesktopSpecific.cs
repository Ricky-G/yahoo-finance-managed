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

using System;
using YahooManaged.Finance;

namespace YahooManaged.Services.Finance.YahooFinance
{
    public partial class IDSearchDownload
    {

        /// <summary>
        /// Downloads search results for Yahoo IDs by keyword and other options
        /// </summary>
        /// <param name="text">The used search text</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public YahooManaged.Base.Response<IDSearchResult> Download(string text)
        {
            if (text.Trim() == string.Empty)
                throw new ArgumentNullException("text", "The text is empty.");
            IDSearchBaseSettings<IDSearchResult> settings = null;
            if (this.Settings != null && this.Settings is IQuerySettings)
            {
                settings = (IDSearchBaseSettings<IDSearchResult>)this.Settings.Clone();
            }
            else
            {
                settings = new IDInstantSearchDownloadSettings();
            }
            ((IQuerySettings)settings).Query = text;
            return this.Download(settings);
        }
        public YahooManaged.Base.Response<IDSearchResult> Download(AlphabeticalIndex index)
        {
            return this.Download(new IDAlphabeticSearchDownloadSettings() { Index = index });
        }
        public YahooManaged.Base.Response<IDSearchResult> Download(IDSearchBaseSettings<IDSearchResult> settings)
        {
            return base.Download(settings);
        }



    }
}
