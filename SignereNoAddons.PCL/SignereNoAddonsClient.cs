/*
 * SignereNoAddons.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/10/2016
 */
using System;
using Signere.no.Controllers;
using Signere.no.Http.Client;

namespace Signere.no
{
    public partial class SignereNoAddonsClient
    {

        /// <summary>
        /// Singleton access to SignatureRolesCheck controller
        /// </summary>
        public SignatureRolesCheck SignatureRolesCheck
        {
            get
            {
                return Signere.no.Controllers.SignatureRolesCheck.Instance;
            }
        }

        /// <summary>
        /// Singleton access to OfficialPersonRegistry controller
        /// </summary>
        public OfficialPersonRegistry OfficialPersonRegistry
        {
            get
            {
                return Signere.no.Controllers.OfficialPersonRegistry.Instance;
            }
        }

        /// <summary>
        /// Singleton access to PersonalInfo controller
        /// </summary>
        public PersonalInfo PersonalInfo
        {
            get
            {
                return Signere.no.Controllers.PersonalInfo.Instance;
            }
        }

        /// <summary>
        /// Singleton access to CompanyInfo controller
        /// </summary>
        public CompanyInfo CompanyInfo
        {
            get
            {
                return Signere.no.Controllers.CompanyInfo.Instance;
            }
        }

        /// <summary>
        /// Singleton access to CreditCheck controller
        /// </summary>
        public CreditCheck CreditCheck
        {
            get
            {
                return Signere.no.Controllers.CreditCheck.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public SignereNoAddonsClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public SignereNoAddonsClient(string oAuthAccessToken)
        {
            Configuration.OAuthAccessToken = oAuthAccessToken;
        }
    }
}