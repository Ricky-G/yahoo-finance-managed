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
using System.Collections.Generic;
using System.Text;
using System.Net;


namespace YahooManaged.Base
{
    public partial class ConnectionInfo
    {
        private KeyValuePair<HttpResponseHeader, string>[] mResponseHeaders = null;
        public KeyValuePair<HttpResponseHeader, string>[] ResponseHeaders { get { return mResponseHeaders; } }

        public ConnectionInfo(Exception exception, int timeout, int size, DateTime startTime, DateTime endTime, KeyValuePair<HttpResponseHeader, string>[] respHeaders)
        {
            mException = exception;
            mResponseHeaders = respHeaders;
            mTimeout = timeout;
            mSizeInBytes = size;
            mEndTime = endTime;
            mStartTime = startTime;
            mTimeSpan = mEndTime - mStartTime;
        }

    

    }
}
