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
using System.Collections.Generic;
using YahooManaged.Finance;
using YahooManaged.Services.Finance.YahooScreener.Criterias;

namespace YahooManaged.Services.Finance.YahooScreener
{
    public partial class StockScreenerDownload 
    {


        public YahooManaged.Base.Response<StockScreenerResult> Download(IEnumerable<StockCriteriaDefinition> criterias)
        {
            if (criterias == null)
                throw new ArgumentNullException("criterias", "The criterias enumerable is null.");
            return base.Download(new StockScreenerDownloadSettings() { Criterias = MyHelper.EnumToArray(criterias) });
        }
        public YahooManaged.Base.Response<StockScreenerResult> Download(IEnumerable<IID> ids, IEnumerable<StockCriteriaDefinition> criterias)
        {
            if (ids == null)
                throw new ArgumentNullException("ids", "The ID Enumerable is null.");
            List<string> strIDs = new List<string>();
            foreach (IID id in ids)
            {
                strIDs.Add(id.ID);
            }
            return this.Download(strIDs, criterias);
        }
        public YahooManaged.Base.Response<StockScreenerResult> Download(IEnumerable<string> ids, IEnumerable<StockCriteriaDefinition> criterias)
        {
            if (criterias == null)
                throw new ArgumentNullException("criterias", "The criterias enumerable is null.");
            if (ids == null)
                throw new ArgumentNullException("ids", "The ID Enumerable is null.");
            List<string> strIDs = new List<string>(ids);
            if (strIDs.Count == 0)
                throw new ArgumentException("ids", "There must be minimum one ID available for downloading.");
            return base.Download(new StockScreenerDownloadSettings() { IDs = strIDs.ToArray(), Criterias = MyHelper.EnumToArray(criterias) });
        }

    }
}
