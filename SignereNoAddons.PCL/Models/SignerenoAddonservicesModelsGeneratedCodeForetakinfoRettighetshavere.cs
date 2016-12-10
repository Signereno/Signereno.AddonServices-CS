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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoRettighetshavere : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private long? internreferanseField;
        private DateTime? fodtDatoField;
        private bool? fodtDatoFieldSpecified;
        private string navnField;
        private string adresseField;
        private int? postnrField;
        private string poststedField;
        private double? andelField;
        private bool? indirekteEierField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("internreferanseField")]
        public long? InternreferanseField 
        { 
            get 
            {
                return this.internreferanseField; 
            } 
            set 
            {
                this.internreferanseField = value;
                onPropertyChanged("InternreferanseField");
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
        [JsonProperty("fodtDatoFieldSpecified")]
        public bool? FodtDatoFieldSpecified 
        { 
            get 
            {
                return this.fodtDatoFieldSpecified; 
            } 
            set 
            {
                this.fodtDatoFieldSpecified = value;
                onPropertyChanged("FodtDatoFieldSpecified");
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
        [JsonProperty("adresseField")]
        public string AdresseField 
        { 
            get 
            {
                return this.adresseField; 
            } 
            set 
            {
                this.adresseField = value;
                onPropertyChanged("AdresseField");
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
        [JsonProperty("andelField")]
        public double? AndelField 
        { 
            get 
            {
                return this.andelField; 
            } 
            set 
            {
                this.andelField = value;
                onPropertyChanged("AndelField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("indirekteEierField")]
        public bool? IndirekteEierField 
        { 
            get 
            {
                return this.indirekteEierField; 
            } 
            set 
            {
                this.indirekteEierField = value;
                onPropertyChanged("IndirekteEierField");
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