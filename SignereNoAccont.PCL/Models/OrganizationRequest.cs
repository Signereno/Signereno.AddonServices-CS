/*
 * SignereNoAccont.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/25/2016
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
    public class OrganizationRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string orgNumber;
        private bool? prokura;
        private bool? signature;
        private List<CheckSignature> signatures;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OrgNumber")]
        public string OrgNumber 
        { 
            get 
            {
                return this.orgNumber; 
            } 
            set 
            {
                this.orgNumber = value;
                onPropertyChanged("OrgNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Prokura")]
        public bool? Prokura 
        { 
            get 
            {
                return this.prokura; 
            } 
            set 
            {
                this.prokura = value;
                onPropertyChanged("Prokura");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Signature")]
        public bool? Signature 
        { 
            get 
            {
                return this.signature; 
            } 
            set 
            {
                this.signature = value;
                onPropertyChanged("Signature");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Signatures")]
        public List<CheckSignature> Signatures 
        { 
            get 
            {
                return this.signatures; 
            } 
            set 
            {
                this.signatures = value;
                onPropertyChanged("Signatures");
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