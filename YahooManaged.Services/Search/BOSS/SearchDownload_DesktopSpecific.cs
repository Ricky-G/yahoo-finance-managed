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

using System.Collections.Generic;

namespace YahooManaged.Services.Search.BOSS
{
    public partial class SearchDownload
    {


        public YahooManaged.Base.Response<SearchResult> Download(SearchService service)
        {
            return this.Download(new SearchService[] { service });
        }
        public YahooManaged.Base.Response<SearchResult> Download(IEnumerable<SearchService> services)
        {
            SearchDownloadSettings set = (SearchDownloadSettings)this.Settings.Clone();
            set.Services.Clear();
            foreach (SearchService service in services)
            {
                set.Services.Add(service);
            }
            return this.Download(set);
        }

        public YahooManaged.Base.Response<SearchResult> Download(SearchDownloadSettings settings)
        {
            return base.Download(settings);
        }

    }
}
