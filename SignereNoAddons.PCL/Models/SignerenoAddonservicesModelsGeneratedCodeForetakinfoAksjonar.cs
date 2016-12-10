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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoAksjonar : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? orgnrField;
        private long? internRefField;
        private DateTime? fodtDatoField;
        private string navnField;
        private int? postnrField;
        private string poststedField;
        private double? eierandelField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("orgnrField")]
        public int? OrgnrField 
        { 
            get 
            {
                return this.orgnrField; 
            } 
            set 
            {
                this.orgnrField = value;
                onPropertyChanged("OrgnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("internRefField")]
        public long? InternRefField 
        { 
            get 
            {
                return this.internRefField; 
            } 
            set 
            {
                this.internRefField = value;
                onPropertyChanged("InternRefField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("fodtDatoField")]
        public DateTime? FodtDatoField 
        { 
            get 
            {
                return this.fodtDatoField; 
            } 
            set 
            {
                this.fodtDatoField = value;
                onPropertyChanged("FodtDatoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("navnField")]
        public string NavnField 
        { 
            get 
            {
                return this.navnField; 
            } 
            set 
            {
                this.navnField = value;
                onPropertyChanged("NavnField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postnrField")]
        public int? PostnrField 
        { 
            get 
            {
                return this.postnrField; 
            } 
            set 
            {
                this.postnrField = value;
                onPropertyChanged("PostnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("poststedField")]
        public string PoststedField 
        { 
            get 
            {
                return this.poststedField; 
            } 
            set 
            {
                this.poststedField = value;
                onPropertyChanged("PoststedField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eierandelField")]
        public double? EierandelField 
        { 
            get 
            {
                return this.eierandelField; 
            } 
            set 
            {
                this.eierandelField = value;
                onPropertyChanged("EierandelField");
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