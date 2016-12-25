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
    public partial interface IOfficialPersonRegistry
    {
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
        PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetBySocialSec(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string reason,
                string system,
                bool? isprod = null);

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
        Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetBySocialSecAsync(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string reason,
                string system,
                bool? isprod = null);

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
        PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByNameAndSocialSec(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null);

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
        Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByNameAndSocialSecAsync(
                Guid accountId,
                string username,
                string password,
                string socialSecurityNumber,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null);

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
        PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByDateofBirthAndName(
                Guid accountId,
                string username,
                string password,
                int dateofbirth,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null);

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
        Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByDateofBirthAndNameAsync(
                Guid accountId,
                string username,
                string password,
                int dateofbirth,
                string firstname,
                string lastname,
                string reason,
                string system,
                bool? isprod = null);

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
        PersonOfficialPersonRegistryResponse OfficialPersonRegistryGetByAddress(
                Guid accountId,
                string username,
                string password,
                string firstname,
                string lastname,
                string address,
                string postalcode,
                string reason,
                string system,
                bool? isprod = null);

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
        Task<PersonOfficialPersonRegistryResponse> OfficialPersonRegistryGetByAddressAsync(
                Guid accountId,
                string username,
                string password,
                string firstname,
                string lastname,
                string address,
                string postalcode,
                string reason,
                string system,
                bool? isprod = null);

    }
} 