﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RapidCore.Network;
using Skarp.HubSpotClient.Core;

namespace Skarp.HubSpotClient.FunctionalTests.Mocks.Company
{
    public class GetCompanyMockTestCase : IMockRapidHttpClientTestCase
    {
        public bool IsMatch(HttpRequestMessage request)
        {
            return request.RequestUri.AbsolutePath.Contains("/companies/v2/companies/10444744") && request.Method == HttpMethod.Get;
        }

        public Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage request)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            const string jsonResponse = "{'portalId': 62515,'companyId': 10444744,'isDeleted': false,'properties': {'description': {'value': 'A far better description than before',      'timestamp': 1403218621658,'source': 'API','sourceId': null,'versions': [{'name': 'description','value': 'A far better description than before','timestamp': 1403218621658,'source': 'API','sourceVid': []}]},'name': {'value': 'A company name','timestamp': 1403217668394,'source': 'API','sourceId': null,'versions': [{'name': 'name','value': 'A company name','timestamp': 1403217668394,'source': 'API','sourceVid': []}]},'createdate': {'value': '1403217668394','timestamp': 1403217668394,'source': 'API','sourceId': null,'versions': [{'name': 'createdate','value': '1403217668394','timestamp': 1403217668394,'source': 'API','sourceVid': []}]}}}";
            response.Content = new JsonContent(jsonResponse);
            response.RequestMessage = request;

            return Task.FromResult(response);
        }
    }
}