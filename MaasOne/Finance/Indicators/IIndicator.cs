// ******************************************************************************
// ** 
// **  YahooManaged WebServices
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;


namespace YahooManaged.Finance.Indicators
{

	public interface IIndicator
	{
		string Name { get; }
		double ScaleMinimum { get; }
		double ScaleMaximum { get; }
		int Period { get; set; }
		bool IsRealative { get; }
	}

	public interface ISingleValueIndicator : IIndicator
	{
		Dictionary<System.DateTime, double>[] Calculate(IEnumerable<KeyValuePair<System.DateTime, double>> values);
	}

	public interface IHistQuoteIndicator : IIndicator
	{
        bool CloseAdjusted { get; set; }
        Dictionary<System.DateTime, double>[] Calculate(IEnumerable<HistQuotesData> values);
	}

}
