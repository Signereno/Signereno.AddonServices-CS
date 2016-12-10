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
    public class SignereNoAddonservicesModelsSignatureCheckSignatureRights : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? mvaNumber;
        private string name;
        private SignereNoAddonservicesModelsSignatureCheckSignatureObject signatur;
        private SignereNoAddonservicesModelsSignatureCheckSignatureObject prokura;
        private string report;
        private string requestId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MvaNumber")]
        public int? MvaNumber 
        { 
            get 
            {
                return this.mvaNumber; 
            } 
            set 
            {
                this.mvaNumber = value;
                onPropertyChanged("MvaNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Signatur")]
        public SignereNoAddonservicesModelsSignatureCheckSignatureObject Signatur 
        { 
            get 
            {
                return this.signatur; 
            } 
            set 
            {
                this.signatur = value;
                onPropertyChanged("Signatur");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Prokura")]
        public SignereNoAddonservicesModelsSignatureCheckSignatureObject Prokura 
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
        [JsonProperty("Report")]
        public string Report 
        { 
            get 
            {
                return this.report; 
            } 
            set 
            {
                this.report = value;
                onPropertyChanged("Report");
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