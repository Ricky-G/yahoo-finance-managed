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

namespace YahooManaged.Services.Weather.YahooWeather
{
    public partial class WeatherFeedDownload
    {

        public YahooManaged.Base.Response<WeatherFeedResult> Download(IEnumerable<long> woeids, bool metricValues)
        {
            if (woeids == null)
            {
                throw new ArgumentNullException("woeids", "The passed list is null.");
            }
            else
            {
                return base.Download(new WeatherFeedWOEIDDownloadSettings() { WOEIDS = MyHelper.EnumToArray(woeids), IsMetric = metricValues });
            }
        }
        public YahooManaged.Base.Response<WeatherFeedResult> Download(IEnumerable<LocationIDData> locations, bool metricValues)
        {
            return base.Download(new WeatherFeedLocationIDDownloadSettings() { Locations = MyHelper.EnumToArray(locations), IsMetric = metricValues });
        }
        public YahooManaged.Base.Response<WeatherFeedResult> Download(string keyword, bool metricValues, IResultIndexSettings opt)
        {
            return this.Download(new string[] { keyword }, metricValues, opt);
        }
        public YahooManaged.Base.Response<WeatherFeedResult> Download(IEnumerable<string> keywords, bool metricValues, IResultIndexSettings opt)
        {
            return base.Download(new WeatherFeedKeywordDownloadSettings() { Keywords = MyHelper.EnumToArray(keywords), IsMetric = metricValues });
        }
    

    }
}
