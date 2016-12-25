/*
 * SignereNoAccont.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/25/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Signere.no;
using Signere.no.Utilities;
using Signere.no.Http.Request;
using Signere.no.Http.Response;
using Signere.no.Http.Client;
using Signere.no.Exceptions;
using Signere.no.Models;

namespace Signere.no.Controllers
{
    public partial class CompanyInfo: BaseController, ICompanyInfo
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CompanyInfo instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CompanyInfo Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CompanyInfo();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Difi
        /// </summary>
        /// <param name="orgnumber">Optional parameter: Example: </param>
        /// <param name="companyname">Optional parameter: Example: </param>
        /// <return>Returns the DifiResponse response from the API call</return>
        public DifiResponse CompanyInfoGetOrgInfoDifi(string orgnumber = null, string companyname = null)
        {
            Task<DifiResponse> t = CompanyInfoGetOrgInfoDifiAsync(orgnumber, companyname);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Difi
        /// </summary>
        /// <param name="orgnumber">Optional parameter: Example: </param>
        /// <param name="companyname">Optional parameter: Example: </param>
        /// <return>Returns the DifiResponse response from the API call</return>
        public async Task<DifiResponse> CompanyInfoGetOrgInfoDifiAsync(string orgnumber = null, string companyname = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/orginfo/querydifi");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orgnumber", orgnumber },
                { "companyname", companyname }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            else if (_response.StatusCode == 400)
                throw new APIException(@"Bad request", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Internal Server Error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<DifiResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Matchit
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="companyname">Optional parameter: query param</param>
        /// <param name="orgnumber">Optional parameter: query param</param>
        /// <return>Returns the CompanyInformationResponse response from the API call</return>
        public CompanyInformationResponse CompanyInfoGetOrgInfoBisnode(Guid accountId, string companyname = null, string orgnumber = null)
        {
            Task<CompanyInformationResponse> t = CompanyInfoGetOrgInfoBisnodeAsync(accountId, companyname, orgnumber);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Matchit
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="companyname">Optional parameter: query param</param>
        /// <param name="orgnumber">Optional parameter: query param</param>
        /// <return>Returns the CompanyInformationResponse response from the API call</return>
        public async Task<CompanyInformationResponse> CompanyInfoGetOrgInfoBisnodeAsync(Guid accountId, string companyname = null, string orgnumber = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/orginfo/querybisnode/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "companyname", companyname },
                { "orgnumber", orgnumber }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            else if (_response.StatusCode == 400)
                throw new APIException(@"Bad request", _context);

            else if (_response.StatusCode == 401)
                throw new APIException(@"Not authorized", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Internal Server Error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<CompanyInformationResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 