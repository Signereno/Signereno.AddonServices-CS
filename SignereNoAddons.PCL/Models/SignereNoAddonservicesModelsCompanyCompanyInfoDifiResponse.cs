/*
 * SignereNoAddons.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/10/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Signere.no;
using Signere.no.Utilities;

namespace Signere.no.Models
{
    public class SignereNoAddonservicesModelsCompanyCompanyInfoDifiResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string orgNr;
        private string orgName;
        private string address;
        private string postalCode;
        private string city;
        private string website;
        private string country;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OrgNr")]
        public string OrgNr 
        { 
            get 
            {
                return this.orgNr; 
            } 
            set 
            {
                this.orgNr = value;
                onPropertyChanged("OrgNr");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName 
        { 
            get 
            {
                return this.orgName; 
            } 
            set 
            {
                this.orgName = value;
                onPropertyChanged("OrgName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Address")]
        public string Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("City")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Website")]
        public string Website 
        { 
            get 
            {
                return this.website; 
            } 
            set 
            {
                this.website = value;
                onPropertyChanged("Website");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 