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
    public class PersonNavnAdresse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string statusField;
        private DateTime? statusDatoField;
        private DateTime? fodselsdatoField;
        private string navnField;
        private string adresseField;
        private string postnrField;
        private string poststedField;
        private string kommuneField;
        private string fylkeField;
        private int? alderField;
        private string kjonnField;
        private List<string> telefonField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusField")]
        public string StatusField 
        { 
            get 
            {
                return this.statusField; 
            } 
            set 
            {
                this.statusField = value;
                onPropertyChanged("StatusField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("statusDatoField")]
        public DateTime? StatusDatoField 
        { 
            get 
            {
                return this.statusDatoField; 
            } 
            set 
            {
                this.statusDatoField = value;
                onPropertyChanged("StatusDatoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("fodselsdatoField")]
        public DateTime? FodselsdatoField 
        { 
            get 
            {
                return this.fodselsdatoField; 
            } 
            set 
            {
                this.fodselsdatoField = value;
                onPropertyChanged("FodselsdatoField");
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
        public string PostnrField 
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
        [JsonProperty("kommuneField")]
        public string KommuneField 
        { 
            get 
            {
                return this.kommuneField; 
            } 
            set 
            {
                this.kommuneField = value;
                onPropertyChanged("KommuneField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fylkeField")]
        public string FylkeField 
        { 
            get 
            {
                return this.fylkeField; 
            } 
            set 
            {
                this.fylkeField = value;
                onPropertyChanged("FylkeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("alderField")]
        public int? AlderField 
        { 
            get 
            {
                return this.alderField; 
            } 
            set 
            {
                this.alderField = value;
                onPropertyChanged("AlderField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kjonnField")]
        public string KjonnField 
        { 
            get 
            {
                return this.kjonnField; 
            } 
            set 
            {
                this.kjonnField = value;
                onPropertyChanged("KjonnField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("telefonField")]
        public List<string> TelefonField 
        { 
            get 
            {
                return this.telefonField; 
            } 
            set 
            {
                this.telefonField = value;
                onPropertyChanged("TelefonField");
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