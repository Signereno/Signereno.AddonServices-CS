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
    public partial class OfficialPersonRegistry: BaseController, IOfficialPersonRegistry
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static OfficialPersonRegistry instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static OfficialPersonRegistry Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new OfficialPersonRegistry();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Social Security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="socialSecurityNumber">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetBySocialSec(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string reason,
                string system,
                bool? isprod = null)
        {
            Task<PersonOfficialPersonRegistryResponse> t = OfficialPersonRegistryGetBySocialSecAsync(accountId, username, password, socialSecurityNumber, reason, system, isprod);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Social Security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="socialSecurityNumber">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public async Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetBySocialSecAsync(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string reason,
                string system,
                bool? isprod = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/officialregistryquery/socialsec/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username },
                { "password", password },
                { "socialSecurityNumber", socialSecurityNumber },
                { "reason", reason },
                { "system", system },
                { "isprod", isprod }
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
                return APIHelper.JsonDeserialize<PersonOfficialPersonRegistryResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Social security and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="socialSecurityNumber">Required parameter: Query param</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByNameAndSocialSec(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null)
        {
            Task<PersonOfficialPersonRegistryResponse> t = OfficialPersonRegistryGetByNameAndSocialSecAsync(accountId, username, password, socialSecurityNumber, firstname, lastname, reason, system, isprod);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Social security and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="socialSecurityNumber">Required parameter: Query param</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public async Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByNameAndSocialSecAsync(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/officialregistryquery/nameandsocialsec/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username },
                { "password", password },
                { "socialSecurityNumber", socialSecurityNumber },
                { "firstname", firstname },
                { "lastname", lastname },
                { "reason", reason },
                { "system", system },
                { "isprod", isprod }
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
                return APIHelper.JsonDeserialize<PersonOfficialPersonRegistryResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Date of birth and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="dateofbirth">Required parameter: Query param</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByDateofBirthAndName(
                Guid accountId,
                string username,
                string password,
                int dateofbirth,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null)
        {
            Task<PersonOfficialPersonRegistryResponse> t = OfficialPersonRegistryGetByDateofBirthAndNameAsync(accountId, username, password, dateofbirth, firstname, lastname, reason, system, isprod);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Date of birth and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="dateofbirth">Required parameter: Query param</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public async Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByDateofBirthAndNameAsync(
                Guid accountId,
                string username,
                string password,
                int dateofbirth,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/officialregistryquery/dateofbirth/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username },
                { "password", password },
                { "dateofbirth", dateofbirth },
                { "firstname", firstname },
                { "lastname", lastname },
                { "reason", reason },
                { "system", system },
                { "isprod", isprod }
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
                return APIHelper.JsonDeserialize<PersonOfficialPersonRegistryResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Name and full address
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="address">Required parameter: Query param</param>
        /// <param name="postalcode">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByAddress(
                Guid accountId,
                string username,
                string password,
                string firstname,
                string lastname,
                string address,
                string postalcode,
                string reason,
                string system,
                bool? isprod = null)
        {
            Task<PersonOfficialPersonRegistryResponse> t = OfficialPersonRegistryGetByAddressAsync(accountId, username, password, firstname, lastname, address, postalcode, reason, system, isprod);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Name and full address
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="username">Required parameter: Infotorget username</param>
        /// <param name="password">Required parameter: Infotorget password</param>
        /// <param name="firstname">Required parameter: Query param</param>
        /// <param name="lastname">Required parameter: Query param</param>
        /// <param name="address">Required parameter: Query param</param>
        /// <param name="postalcode">Required parameter: Query param</param>
        /// <param name="reason">Required parameter: Reason for request</param>
        /// <param name="system">Required parameter: Your system name (Cannot contain any special characters or numbers)</param>
        /// <param name="isprod">Optional parameter: Test environment when false or undefined</param>
        /// <return>Returns the PersonOfficialPersonRegistryResponse response from the API call</return>
        public async Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByAddressAsync(
                Guid accountId,
                string username,
                string password,
                string firstname,
                string lastname,
                string address,
                string postalcode,
                string reason,
                string system,
                bool? isprod = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/officialregistryquery/address/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username },
                { "password", password },
                { "firstname", firstname },
                { "lastname", lastname },
                { "address", address },
                { "postalcode", postalcode },
                { "reason", reason },
                { "system", system },
                { "isprod", isprod }
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
                return APIHelper.JsonDeserialize<PersonOfficialPersonRegistryResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 