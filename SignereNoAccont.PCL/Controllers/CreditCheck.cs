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
    public partial class CreditCheck: BaseController, ICreditCheck
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CreditCheck instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CreditCheck Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CreditCheck();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Private credit check
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="socialSecurityNumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <param name="userId">Optional parameter: Override bisnode user Id</param>
        /// <param name="password">Optional parameter: Override bisnode password</param>
        /// <param name="phonenumber">Optional parameter: Specify this to use electronic duplicate letters</param>
        /// <param name="email">Optional parameter: Specify this to use electronic duplicate letters</param>
        /// <return>Returns the PersonCreditCheckPersonResponse response from the API call</return>
        public PersonCreditCheckPersonResponse CreditCheckPrivateCreditCheck(
                Guid accountId,
                long socialSecurityNumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                int? phonenumber = null,
                string email = null)
        {
            Task<PersonCreditCheckPersonResponse> t = CreditCheckPrivateCreditCheckAsync(accountId, socialSecurityNumber, isprod, userId, password, phonenumber, email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Private credit check
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="socialSecurityNumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <param name="userId">Optional parameter: Override bisnode user Id</param>
        /// <param name="password">Optional parameter: Override bisnode password</param>
        /// <param name="phonenumber">Optional parameter: Specify this to use electronic duplicate letters</param>
        /// <param name="email">Optional parameter: Specify this to use electronic duplicate letters</param>
        /// <return>Returns the PersonCreditCheckPersonResponse response from the API call</return>
        public async Task<PersonCreditCheckPersonResponse> CreditCheckPrivateCreditCheckAsync(
                Guid accountId,
                long socialSecurityNumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                int? phonenumber = null,
                string email = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/creditcheck/private/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "socialSecurityNumber", socialSecurityNumber },
                { "isprod", isprod },
                { "userId", userId },
                { "password", password },
                { "phonenumber", phonenumber },
                { "email", email }
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
                return APIHelper.JsonDeserialize<PersonCreditCheckPersonResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Business credit check
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <param name="userId">Optional parameter: Override bisnode user Id</param>
        /// <param name="password">Optional parameter: Override bisnode password</param>
        /// <param name="countryCode">Optional parameter: Default = "NO"</param>
        /// <return>Returns the CreditCheckCompanyResponse response from the API call</return>
        public CreditCheckCompanyResponse CreditCheckBusinessCreditCheck(
                Guid accountId,
                int orgnumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                string countryCode = null)
        {
            Task<CreditCheckCompanyResponse> t = CreditCheckBusinessCreditCheckAsync(accountId, orgnumber, isprod, userId, password, countryCode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Business credit check
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <param name="userId">Optional parameter: Override bisnode user Id</param>
        /// <param name="password">Optional parameter: Override bisnode password</param>
        /// <param name="countryCode">Optional parameter: Default = "NO"</param>
        /// <return>Returns the CreditCheckCompanyResponse response from the API call</return>
        public async Task<CreditCheckCompanyResponse> CreditCheckBusinessCreditCheckAsync(
                Guid accountId,
                int orgnumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                string countryCode = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/creditcheck/business/{accountId}");

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
                { "userId", userId },
                { "password", password },
                { "countryCode", countryCode }
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
                return APIHelper.JsonDeserialize<CreditCheckCompanyResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 