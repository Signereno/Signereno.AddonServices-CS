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
    public partial class SignatureRolesCheck: BaseController, ISignatureRolesCheck
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SignatureRolesCheck instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SignatureRolesCheck Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SignatureRolesCheck();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get rights
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Set to false if you want to use the test environment, else true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureRights response from the API call</return>
        public SignatureRights SignatureRolesCheckGetRights(
                Guid accountId,
                string orgnumber,
                bool? isprod = null,
                string countrycode = null)
        {
            Task<SignatureRights> t = SignatureRolesCheckGetRightsAsync(accountId, orgnumber, isprod, countrycode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get rights
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Set to false if you want to use the test environment, else true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureRights response from the API call</return>
        public async Task<SignatureRights> SignatureRolesCheckGetRightsAsync(
                Guid accountId,
                string orgnumber,
                bool? isprod = null,
                string countrycode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/signroles/rights/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orgnumber", orgnumber },
                { "isprod", isprod },
                { "countrycode", countrycode }
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
                throw new APIException(@"Internal server error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SignatureRights>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Check signatures / prokura
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="data">Required parameter: An array including all the organizations you want to check</param>
        /// <param name="isprod">Optional parameter: Test environment if false</param>
        /// <param name="includereport">Optional parameter: Returns a pdf report explaining the validity of the checked signatures, default value is true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureStatusResponse response from the API call</return>
        public SignatureStatusResponse SignatureRolesCheckCheckSignatures(
                Guid accountId,
                SignatureCheckRequest data,
                bool? isprod = null,
                bool? includereport = null,
                string countrycode = null)
        {
            Task<SignatureStatusResponse> t = SignatureRolesCheckCheckSignaturesAsync(accountId, data, isprod, includereport, countrycode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Check signatures / prokura
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="data">Required parameter: An array including all the organizations you want to check</param>
        /// <param name="isprod">Optional parameter: Test environment if false</param>
        /// <param name="includereport">Optional parameter: Returns a pdf report explaining the validity of the checked signatures, default value is true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureStatusResponse response from the API call</return>
        public async Task<SignatureStatusResponse> SignatureRolesCheckCheckSignaturesAsync(
                Guid accountId,
                SignatureCheckRequest data,
                bool? isprod = null,
                bool? includereport = null,
                string countrycode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/signroles/signature/check/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "isprod", isprod },
                { "includereport", includereport },
                { "countrycode", countrycode }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(data);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
                throw new APIException(@"Internal server error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SignatureStatusResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 