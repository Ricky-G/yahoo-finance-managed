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
using System.Data;

namespace YahooManaged.Services.Finance.YahooPortfolio
{
    public partial class Portfolio
    {

        public DataTable GetTable()
        {           
            DataTable dt = new DataTable();
            if (mRows.Length > 0)
            {
                Dictionary<PortfolioColumnType, int> colDict = new Dictionary<PortfolioColumnType, int>(); foreach (PortfolioColumnType ct in Enum.GetValues(typeof(PortfolioColumnType))) colDict.Add(ct, -1);

                foreach (PortfolioColumnType colType in mColumns)
                {
                    colDict[colType] += 1;
                    string colName = colType.ToString();
                    if (colDict[colType] > 0) colName += "_" + colDict[colType].ToString();
                    dt.Columns.Add(colName, typeof(object)).Caption = Portfolio.GetColumnTypeTitle(colType, System.Globalization.CultureInfo.CurrentUICulture);
                }

                foreach (PortfolioDataRow pfRow in mRows)
                {
                    DataRow r = dt.NewRow();
                    for (int i = 0; i < mColumns.Length; i++)
                    {
                        r[i] = pfRow[mColumns[i]];
                    }
                    dt.Rows.Add(r);
                }

            }
            return dt;
        }

    }
}
