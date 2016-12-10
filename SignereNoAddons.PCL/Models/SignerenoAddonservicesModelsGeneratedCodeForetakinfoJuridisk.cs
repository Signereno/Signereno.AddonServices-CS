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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoJuridisk : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string prokuraField;
        private string signaturField;
        private string eierStrukturField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prokuraField")]
        public string ProkuraField 
        { 
            get 
            {
                return this.prokuraField; 
            } 
            set 
            {
                this.prokuraField = value;
                onPropertyChanged("ProkuraField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("signaturField")]
        public string SignaturField 
        { 
            get 
            {
                return this.signaturField; 
            } 
            set 
            {
                this.signaturField = value;
                onPropertyChanged("SignaturField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eierStrukturField")]
        public string EierStrukturField 
        { 
            get 
            {
                return this.eierStrukturField; 
            } 
            set 
            {
                this.eierStrukturField = value;
                onPropertyChanged("EierStrukturField");
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