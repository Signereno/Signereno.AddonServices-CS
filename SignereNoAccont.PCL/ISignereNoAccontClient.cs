/*
 * SignereNoAccont.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/25/2016
 */
using System;
using Signere.no.Controllers;

namespace Signere.no
{
    public partial interface ISignereNoAccontClient
    {

        /// <summary>
        /// Singleton access to CompanyInfo controller
        /// </summary>
        ICompanyInfo CompanyInfo { get;}

        /// <summary>
        /// Singleton access to CreditCheck controller
        /// </summary>
        ICreditCheck CreditCheck { get;}

        /// <summary>
        /// Singleton access to OfficialPersonRegistry controller
        /// </summary>
        IOfficialPersonRegistry OfficialPersonRegistry { get;}

        /// <summary>
        /// Singleton access to PersonalInfo controller
        /// </summary>
        IPersonalInfo PersonalInfo { get;}

        /// <summary>
        /// Singleton access to SignatureRolesCheck controller
        /// </summary>
        ISignatureRolesCheck SignatureRolesCheck { get;}

    }
}