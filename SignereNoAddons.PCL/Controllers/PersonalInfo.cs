/*
 * SignereNoAddons.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/10/2016
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
    public partial class PersonalInfo: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PersonalInfo instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PersonalInfo Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PersonalInfo();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Phonenumber
        /// </summary>
        /// <param name="accountId">Required parameter: Example: </param>
        /// <param name="phonenumber">Required parameter: Example: </param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public SignereNoAddonservicesModelsPersonPersonInformation GetPersonalInfoPersonInfoPhoneNumber(Guid accountId, string phonenumber)
        {
            Task<SignereNoAddonservicesModelsPersonPersonInformation> t = GetPersonalInfoPersonInfoPhoneNumberAsync(accountId, phonenumber);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Phonenumber
        /// </summary>
        /// <param name="accountId">Required parameter: Example: </param>
        /// <param name="phonenumber">Required parameter: Example: </param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public async Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoPhoneNumberAsync(Guid accountId, string phonenumber)
        {
            //validating required parameters
            if (null == phonenumber)
                throw new ArgumentNullException("phonenumber", "The parameter \"phonenumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/personalinfo/phone/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "phonenumber", phonenumber }
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
            if (_response.StatusCode == 400)
                throw new APIException(@"Bad request", _context);

            else if (_response.StatusCode == 401)
                throw new APIException(@"Not authorized", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Internal server error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SignereNoAddonservicesModelsPersonPersonInformation>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Name and social security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="socialSec">Required parameter: Query param</param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public SignereNoAddonservicesModelsPersonPersonInformation GetPersonalInfoPersonInfoSocialSec(Guid accountId, string name, string socialSec)
        {
            Task<SignereNoAddonservicesModelsPersonPersonInformation> t = GetPersonalInfoPersonInfoSocialSecAsync(accountId, name, socialSec);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Name and social security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="socialSec">Required parameter: Query param</param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public async Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoSocialSecAsync(Guid accountId, string name, string socialSec)
        {
            //validating required parameters
            if (null == name)
                throw new ArgumentNullException("name", "The parameter \"name\" is a required parameter and cannot be null.");

            if (null == socialSec)
                throw new ArgumentNullException("socialSec", "The parameter \"socialSec\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/personalinfo/socialsec/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "socialSec", socialSec }
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
            if (_response.StatusCode == 400)
                throw new APIException(@"Bad request", _context);

            else if (_response.StatusCode == 401)
                throw new APIException(@"Not authorized", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Internal server error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SignereNoAddonservicesModelsPersonPersonInformation>(_response.Body);
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
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="dateOfBirth">Required parameter: Query param</param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public SignereNoAddonservicesModelsPersonPersonInformation GetPersonalInfoPersonInfoDateOfBirth(Guid accountId, string name, string dateOfBirth)
        {
            Task<SignereNoAddonservicesModelsPersonPersonInformation> t = GetPersonalInfoPersonInfoDateOfBirthAsync(accountId, name, dateOfBirth);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Date of birth and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="dateOfBirth">Required parameter: Query param</param>
        /// <return>Returns the SignereNoAddonservicesModelsPersonPersonInformation response from the API call</return>
        public async Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoDateOfBirthAsync(Guid accountId, string name, string dateOfBirth)
        {
            //validating required parameters
            if (null == name)
                throw new ArgumentNullException("name", "The parameter \"name\" is a required parameter and cannot be null.");

            if (null == dateOfBirth)
                throw new ArgumentNullException("dateOfBirth", "The parameter \"dateOfBirth\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/personalinfo/dateofbirth/{accountId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "dateOfBirth", dateOfBirth }
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
            if (_response.StatusCode == 400)
                throw new APIException(@"Bad request", _context);

            else if (_response.StatusCode == 401)
                throw new APIException(@"Not authorized", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Internal server error (Miscellaneous)", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SignereNoAddonservicesModelsPersonPersonInformation>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 