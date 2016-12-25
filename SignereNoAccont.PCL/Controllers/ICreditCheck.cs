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
    public partial interface ICreditCheck
    {
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
        PersonCreditCheckPersonResponse CreditCheckPrivateCreditCheck(
                Guid accountId,
                long socialSecurityNumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                int? phonenumber = null,
                string email = null);

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
        Task<PersonCreditCheckPersonResponse> CreditCheckPrivateCreditCheckAsync(
                Guid accountId,
                long socialSecurityNumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                int? phonenumber = null,
                string email = null);

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
        CreditCheckCompanyResponse CreditCheckBusinessCreditCheck(
                Guid accountId,
                int orgnumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                string countryCode = null);

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
        Task<CreditCheckCompanyResponse> CreditCheckBusinessCreditCheckAsync(
                Guid accountId,
                int orgnumber,
                bool? isprod = null,
                string userId = null,
                string password = null,
                string countryCode = null);

    }
} 