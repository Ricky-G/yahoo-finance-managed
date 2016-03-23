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
    public partial class CompanyStatisticsDownload 
    {

        /// <summary>
        /// Downloads company statistic data.
        /// </summary>
        /// <param name="managedID">The managed ID</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public YahooManaged.Base.Response<CompanyStatisticsResult> Download(IID managedID)
        {
            if (managedID == null)
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            return this.Download(managedID.ID);
        }
        /// <summary>
        /// Downloads company statistic data.
        /// </summary>
        /// <param name="unmanagedID">The unmanaged ID</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public YahooManaged.Base.Response<CompanyStatisticsResult> Download(string unmanagedID)
        {
            if (unmanagedID == string.Empty)
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            return this.Download(new CompanyStatisticsDownloadSettings(unmanagedID));
        }
        public YahooManaged.Base.Response<CompanyStatisticsResult> Download(CompanyStatisticsDownloadSettings settings)
        {
            return base.Download(settings);
        }

    }
}
