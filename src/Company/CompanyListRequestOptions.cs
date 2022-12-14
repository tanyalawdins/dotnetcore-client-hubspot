using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Company
{
    public class CompanyListRequestOptions
    {
        private int _numberOfCompaniesToReturn = 100;

        /// <summary>
        /// Gets or sets the number of companies to return.
        /// </summary>
        /// <remarks>
        /// Defaults to 20 which is also the hubspot api default. Max value is 100
        /// </remarks>
        /// <value>
        /// The number of companies to return.
        /// </value>
        public int NumberOfCompaniesToReturn
        {
            get => _numberOfCompaniesToReturn;
            set
            {
                if (value < 1 || value > 250)
                {
                    throw new ArgumentException(
                        $"Number of companies to return must be a positive ingeteger greater than 0 and less than 251 - you provided {value}");
                }
                _numberOfCompaniesToReturn = value;
            }
        }

        /// <summary>
        /// Get or set the continuation offset when calling list many times to enumerate all your companies
        /// </summary>
        /// <remarks>
        /// The return DTO from List contains the current "offset" that you can inject into your next list call 
        /// to continue the listing process
        /// </remarks>
        public long? CompanyOffset { get; set; } = null;
        public List<string> PropertiesToInclude { get; set; } = new List<string>();

    }
}
