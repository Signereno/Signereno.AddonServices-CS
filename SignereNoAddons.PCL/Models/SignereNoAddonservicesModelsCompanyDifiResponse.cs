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
    public class SignereNoAddonservicesModelsCompanyDifiResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private List<SignereNoAddonservicesModelsCompanyCompanyInfoDifiResponse> organizations;
        private string rawData;
        private string requestId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Organizations")]
        public List<SignereNoAddonservicesModelsCompanyCompanyInfoDifiResponse> Organizations 
        { 
            get 
            {
                return this.organizations; 
            } 
            set 
            {
                this.organizations = value;
                onPropertyChanged("Organizations");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RawData")]
        public string RawData 
        { 
            get 
            {
                return this.rawData; 
            } 
            set 
            {
                this.rawData = value;
                onPropertyChanged("RawData");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId 
        { 
            get 
            {
                return this.requestId; 
            } 
            set 
            {
                this.requestId = value;
                onPropertyChanged("RequestId");
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