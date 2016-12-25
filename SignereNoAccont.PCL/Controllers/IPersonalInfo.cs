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
    public partial interface IPersonalInfo
    {
        /// <summary>
        /// Date of birth and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="dateOfBirth">Required parameter: Query param</param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        PersonPersonInformation PersonalInfoPersonInfoDateOfBirth(Guid accountId, string name, string dateOfBirth);

        /// <summary>
        /// Date of birth and name
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="dateOfBirth">Required parameter: Query param</param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        Task<PersonPersonInformation> PersonalInfoPersonInfoDateOfBirthAsync(Guid accountId, string name, string dateOfBirth);

        /// <summary>
        /// Name and social security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="socialSec">Required parameter: Query param</param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        PersonPersonInformation PersonalInfoPersonInfoSocialSec(Guid accountId, string name, string socialSec);

        /// <summary>
        /// Name and social security number
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="name">Required parameter: Query param</param>
        /// <param name="socialSec">Required parameter: Query param</param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        Task<PersonPersonInformation> PersonalInfoPersonInfoSocialSecAsync(Guid accountId, string name, string socialSec);

        /// <summary>
        /// Phonenumber
        /// </summary>
        /// <param name="accountId">Required parameter: Example: </param>
        /// <param name="phonenumber">Required parameter: Example: </param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        PersonPersonInformation PersonalInfoPersonInfoPhoneNumber(Guid accountId, string phonenumber);

        /// <summary>
        /// Phonenumber
        /// </summary>
        /// <param name="accountId">Required parameter: Example: </param>
        /// <param name="phonenumber">Required parameter: Example: </param>
        /// <return>Returns the PersonPersonInformation response from the API call</return>
        Task<PersonPersonInformation> PersonalInfoPersonInfoPhoneNumberAsync(Guid accountId, string phonenumber);

    }
} 