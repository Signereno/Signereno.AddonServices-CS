/*
 * SignereNoAccont.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/25/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signere.no;
using Signere.no.Utilities;
using Signere.no.Http.Request;
using Signere.no.Http.Response;
using Signere.no.Http.Client;
using Signere.no.Models;

namespace Signere.no.Controllers
{
    public partial interface ISignatureRolesCheck
    {
        /// <summary>
        /// Get rights
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Set to false if you want to use the test environment, else true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureRights response from the API call</return>
        SignatureRights SignatureRolesCheckGetRights(
                Guid accountId,
                string orgnumber,
                bool? isprod = null,
                string countrycode = null);

        /// <summary>
        /// Get rights
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="orgnumber">Required parameter: Example: </param>
        /// <param name="isprod">Optional parameter: Set to false if you want to use the test environment, else true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureRights response from the API call</return>
        Task<SignatureRights> SignatureRolesCheckGetRightsAsync(
                Guid accountId,
                string orgnumber,
                bool? isprod = null,
                string countrycode = null);

        /// <summary>
        /// Check signatures / prokura
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="data">Required parameter: An array including all the organizations you want to check</param>
        /// <param name="isprod">Optional parameter: Test environment if false</param>
        /// <param name="includereport">Optional parameter: Returns a pdf report explaining the validity of the checked signatures, default value is true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureStatusResponse response from the API call</return>
        SignatureStatusResponse SignatureRolesCheckCheckSignatures(
                Guid accountId,
                SignatureCheckRequest data,
                bool? isprod = null,
                bool? includereport = null,
                string countrycode = null);

        /// <summary>
        /// Check signatures / prokura
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="data">Required parameter: An array including all the organizations you want to check</param>
        /// <param name="isprod">Optional parameter: Test environment if false</param>
        /// <param name="includereport">Optional parameter: Returns a pdf report explaining the validity of the checked signatures, default value is true</param>
        /// <param name="countrycode">Optional parameter: Default value is "NO"</param>
        /// <return>Returns the SignatureStatusResponse response from the API call</return>
        Task<SignatureStatusResponse> SignatureRolesCheckCheckSignaturesAsync(
                Guid accountId,
                SignatureCheckRequest data,
                bool? isprod = null,
                bool? includereport = null,
                string countrycode = null);

    }
} 