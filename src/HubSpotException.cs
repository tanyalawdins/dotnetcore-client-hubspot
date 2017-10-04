﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient
{
    [Serializable]
    public class HubSpotException : Exception
    {
        public string RawJsonResponse { get; set; }
        public HubSpotException()
        {
        }

        public HubSpotException(string message) : base(message)
        {
        }

        public HubSpotException(string message, string jsonResponse) : base(message)
        {
            RawJsonResponse = jsonResponse;
        }

        public HubSpotException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override String Message
        {
            get
            {
                return base.Message + $", JSONResponse={RawJsonResponse??"Empty"}";
            }
        }
    }
}
