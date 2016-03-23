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

namespace YahooManaged.Services.Finance.YahooFinance
{
    public partial class QuoteOptionsDownload
    {

        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IID managedID)
        {
            if (managedID == null)
            {
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            }
            else
            {
                return this.Download(managedID.ID);
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IEnumerable<IID> managedIDs)
        {
            if (managedIDs == null)
            {
                throw new ArgumentNullException("managedIDs", "The passed list is null.");
            }
            else
            {
                return this.Download(FinanceHelper.IIDsToStrings(managedIDs));
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IID managedID, System.DateTime expirationDate)
        {
            if (managedID == null)
            {
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            }
            else
            {
                return this.Download(managedID.ID, expirationDate);
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IEnumerable<IID> managedIDs, System.DateTime expirationDate)
        {
            if (managedIDs == null)
            {
                throw new ArgumentNullException("managedIDs", "The passed list is null.");
            }
            else
            {
                return this.Download(FinanceHelper.IIDsToStrings(managedIDs), expirationDate);
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IID managedID, IEnumerable<System.DateTime> expirationDates)
        {
            if (managedID == null)
            {
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            }
            else
            {
                return this.Download(managedID.ID, expirationDates);
            }
        }

        public YahooManaged.Base.Response<QuoteOptionsResult> Download(string unmanagedID)
        {
            if (unmanagedID == string.Empty)
            {
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            }
            else
            {
                return this.Download(new string[] { unmanagedID });
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IEnumerable<string> unmanagedIDs)
        {
            if (unmanagedIDs == null)
            {
                throw new ArgumentNullException("unmanagedIDs", "The passed list is null.");
            }
            else
            {
                return this.Download(new QuoteOptionsDownloadSettings() { IDs = MyHelper.EnumToArray(unmanagedIDs) });
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(string unmanagedID, System.DateTime expirationDate)
        {
            if (unmanagedID == string.Empty)
            {
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            }
            else
            {
                return this.Download(new string[] { unmanagedID }, expirationDate);
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(IEnumerable<string> unmanagedIDs, System.DateTime expirationDate)
        {
            if (unmanagedIDs == null)
            {
                throw new ArgumentNullException("unmanagedIDs", "The passed list is null.");
            }
            else
            {
                return this.Download(new QuoteOptionsDownloadSettings() { IDs = MyHelper.EnumToArray(unmanagedIDs), ExpirationDates = new System.DateTime[] { expirationDate } });
            }
        }
        public YahooManaged.Base.Response<QuoteOptionsResult> Download(string unmanagedID, IEnumerable<System.DateTime> expirationDates)
        {
            if (unmanagedID == string.Empty)
            {
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            }
            else
            {
                return this.Download(new QuoteOptionsDownloadSettings() { IDs = new string[] { unmanagedID }, ExpirationDates = MyHelper.EnumToArray(expirationDates) });
            }
        }

        public YahooManaged.Base.Response<QuoteOptionsResult> Download(QuoteOptionsDownloadSettings settings)
        {
            return base.Download(settings);
        }

    }
}
