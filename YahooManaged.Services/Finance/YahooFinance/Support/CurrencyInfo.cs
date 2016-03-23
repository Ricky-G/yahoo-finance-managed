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

namespace YahooManaged.Services.Finance.YahooFinance.Support
{
    /// <summary>
    /// Provides the description of a currency of YahooManaged.Finance.Currency.
    /// </summary>
    /// <remarks></remarks>
    public class CurrencyInfo
    {

        private string mID = string.Empty;
        /// <summary>
        /// The currency ID.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ID
        {
            get { return mID; }
            set { mID = value.ToUpper(); }
        }
        /// <summary>
        /// The currency name/description.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Description { get; set; }

        /// <summary>
        /// Defaul constructor
        /// </summary>
        /// <remarks></remarks>
        public CurrencyInfo(string curID, string curDesc)
        {
            this.ID = curID;
            this.Description = curDesc;
        }

        /// <summary>
        /// Returns Description and ID.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            if (this.Description != string.Empty)
            {
                return this.Description + " (" + this.ID.ToString() + ")";
            }
            else
            {
                return this.ID.ToString();
            }
        }

    }
}
