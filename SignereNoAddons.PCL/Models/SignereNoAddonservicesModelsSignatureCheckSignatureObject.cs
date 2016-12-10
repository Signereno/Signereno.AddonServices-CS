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
    public class SignereNoAddonservicesModelsSignatureCheckSignatureObject : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string requirementsDescription;
        private SignereNoAddonservicesModelsSignatureCheckRequiredSignatures required;
        private SignereNoAddonservicesModelsSignatureCheckOtherSignatures others;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RequirementsDescription")]
        public string RequirementsDescription 
        { 
            get 
            {
                return this.requirementsDescription; 
            } 
            set 
            {
                this.requirementsDescription = value;
                onPropertyChanged("RequirementsDescription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Required")]
        public SignereNoAddonservicesModelsSignatureCheckRequiredSignatures Required 
        { 
            get 
            {
                return this.required; 
            } 
            set 
            {
                this.required = value;
                onPropertyChanged("Required");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Others")]
        public SignereNoAddonservicesModelsSignatureCheckOtherSignatures Others 
        { 
            get 
            {
                return this.others; 
            } 
            set 
            {
                this.others = value;
                onPropertyChanged("Others");
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