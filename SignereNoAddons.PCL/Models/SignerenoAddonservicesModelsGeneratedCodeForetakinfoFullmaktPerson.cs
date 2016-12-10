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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoFullmaktPerson : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private long? internreferanseField;
        private DateTime? fodtDatoField;
        private bool? fodtDatoFieldSpecified;
        private string navnField;
        private string adresseField;
        private int? postnrField;
        private string poststedField;
        private string fullmaktTypeKodeField;
        private string fullmaktTypeTekstField;
        private string fullmaktKodeField;
        private string fullmaktTekstField;
        private int? prioritetField;
        private bool? prioritetFieldSpecified;
        private int? antallField;
        private bool? antallFieldSpecified;
        private bool? obligatoriskField;
        private bool? obligatoriskFieldSpecified;
        private List<SignerenoAddonservicesModelsGeneratedCodeForetakinfoVervData> vervField;

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
        [JsonProperty("fullmaktTypeKodeField")]
        public string FullmaktTypeKodeField 
        { 
            get 
            {
                return this.fullmaktTypeKodeField; 
            } 
            set 
            {
                this.fullmaktTypeKodeField = value;
                onPropertyChanged("FullmaktTypeKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktTypeTekstField")]
        public string FullmaktTypeTekstField 
        { 
            get 
            {
                return this.fullmaktTypeTekstField; 
            } 
            set 
            {
                this.fullmaktTypeTekstField = value;
                onPropertyChanged("FullmaktTypeTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktKodeField")]
        public string FullmaktKodeField 
        { 
            get 
            {
                return this.fullmaktKodeField; 
            } 
            set 
            {
                this.fullmaktKodeField = value;
                onPropertyChanged("FullmaktKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktTekstField")]
        public string FullmaktTekstField 
        { 
            get 
            {
                return this.fullmaktTekstField; 
            } 
            set 
            {
                this.fullmaktTekstField = value;
                onPropertyChanged("FullmaktTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prioritetField")]
        public int? PrioritetField 
        { 
            get 
            {
                return this.prioritetField; 
            } 
            set 
            {
                this.prioritetField = value;
                onPropertyChanged("PrioritetField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prioritetFieldSpecified")]
        public bool? PrioritetFieldSpecified 
        { 
            get 
            {
                return this.prioritetFieldSpecified; 
            } 
            set 
            {
                this.prioritetFieldSpecified = value;
                onPropertyChanged("PrioritetFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallField")]
        public int? AntallField 
        { 
            get 
            {
                return this.antallField; 
            } 
            set 
            {
                this.antallField = value;
                onPropertyChanged("AntallField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallFieldSpecified")]
        public bool? AntallFieldSpecified 
        { 
            get 
            {
                return this.antallFieldSpecified; 
            } 
            set 
            {
                this.antallFieldSpecified = value;
                onPropertyChanged("AntallFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("obligatoriskField")]
        public bool? ObligatoriskField 
        { 
            get 
            {
                return this.obligatoriskField; 
            } 
            set 
            {
                this.obligatoriskField = value;
                onPropertyChanged("ObligatoriskField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("obligatoriskFieldSpecified")]
        public bool? ObligatoriskFieldSpecified 
        { 
            get 
            {
                return this.obligatoriskFieldSpecified; 
            } 
            set 
            {
                this.obligatoriskFieldSpecified = value;
                onPropertyChanged("ObligatoriskFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vervField")]
        public List<SignerenoAddonservicesModelsGeneratedCodeForetakinfoVervData> VervField 
        { 
            get 
            {
                return this.vervField; 
            } 
            set 
            {
                this.vervField = value;
                onPropertyChanged("VervField");
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