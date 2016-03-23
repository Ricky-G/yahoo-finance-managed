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
    public partial class ChartDownload
    {

        /// <summary>
        /// Downloads a chart image.
        /// </summary>
        /// <param name="managedID">The managed ID of the stock</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public YahooManaged.Base.Response<ChartResult> Download(IID managedID)
        {
            if (managedID == null)
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            return this.Download(managedID.ID);
        }
        /// <summary>
        /// Downloads a chart image.
        /// </summary>
        /// <param name="unmanagedID">The unmanaged ID of the stock</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public YahooManaged.Base.Response<ChartResult> Download(string unmanagedID)
        {
            if (unmanagedID == string.Empty)
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            ChartDownloadSettings settings = (ChartDownloadSettings)this.Settings.Clone();
            settings.ID = unmanagedID;
            return this.Download(settings);
        }
        public YahooManaged.Base.Response<ChartResult> Download(ChartDownloadSettings settings)
        {
            return base.Download(settings);
        }

    }
}
