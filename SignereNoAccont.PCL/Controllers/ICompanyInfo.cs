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
    public partial interface ICompanyInfo
    {
        /// <summary>
        /// Difi
        /// </summary>
        /// <param name="orgnumber">Optional parameter: Example: </param>
        /// <param name="companyname">Optional parameter: Example: </param>
        /// <return>Returns the DifiResponse response from the API call</return>
        DifiResponse CompanyInfoGetOrgInfoDifi(string orgnumber = null, string companyname = null);

        /// <summary>
        /// Difi
        /// </summary>
        /// <param name="orgnumber">Optional parameter: Example: </param>
        /// <param name="companyname">Optional parameter: Example: </param>
        /// <return>Returns the DifiResponse response from the API call</return>
        Task<DifiResponse> CompanyInfoGetOrgInfoDifiAsync(string orgnumber = null, string companyname = null);

        /// <summary>
        /// Matchit
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="companyname">Optional parameter: query param</param>
        /// <param name="orgnumber">Optional parameter: query param</param>
        /// <return>Returns the CompanyInformationResponse response from the API call</return>
        CompanyInformationResponse CompanyInfoGetOrgInfoBisnode(Guid accountId, string companyname = null, string orgnumber = null);

        /// <summary>
        /// Matchit
        /// </summary>
        /// <param name="accountId">Required parameter: Signere account Id</param>
        /// <param name="companyname">Optional parameter: query param</param>
        /// <param name="orgnumber">Optional parameter: query param</param>
        /// <return>Returns the CompanyInformationResponse response from the API call</return>
        Task<CompanyInformationResponse> CompanyInfoGetOrgInfoBisnodeAsync(Guid accountId, string companyname = null, string orgnumber = null);

    }
} 