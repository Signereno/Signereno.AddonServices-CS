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
    public class SignerenoAddonservicesModelsGeneratedCodePersonInfoFullmaktForetak : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? dunsnrField;
        private int? orgnrField;
        private string navnField;
        private string adresseField;
        private int? postnrField;
        private string poststedField;
        private string statusKodeField;
        private string statusTekstField;
        private string selskapsformField;
        private string prokuraKodeField;
        private string prokuraTekstField;
        private string signaturKodeField;
        private string signaturTekstField;
        private List<SignerenoAddonservicesModelsGeneratedCodePersonInfoFullmaktPerson> fullmaktPersonField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("dunsnrField")]
        public int? DunsnrField 
        { 
            get 
            {
                return this.dunsnrField; 
            } 
            set 
            {
                this.dunsnrField = value;
                onPropertyChanged("DunsnrField");
            }
        }

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
        [JsonProperty("statusKodeField")]
        public string StatusKodeField 
        { 
            get 
            {
                return this.statusKodeField; 
            } 
            set 
            {
                this.statusKodeField = value;
                onPropertyChanged("StatusKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusTekstField")]
        public string StatusTekstField 
        { 
            get 
            {
                return this.statusTekstField; 
            } 
            set 
            {
                this.statusTekstField = value;
                onPropertyChanged("StatusTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("selskapsformField")]
        public string SelskapsformField 
        { 
            get 
            {
                return this.selskapsformField; 
            } 
            set 
            {
                this.selskapsformField = value;
                onPropertyChanged("SelskapsformField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prokuraKodeField")]
        public string ProkuraKodeField 
        { 
            get 
            {
                return this.prokuraKodeField; 
            } 
            set 
            {
                this.prokuraKodeField = value;
                onPropertyChanged("ProkuraKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prokuraTekstField")]
        public string ProkuraTekstField 
        { 
            get 
            {
                return this.prokuraTekstField; 
            } 
            set 
            {
                this.prokuraTekstField = value;
                onPropertyChanged("ProkuraTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("signaturKodeField")]
        public string SignaturKodeField 
        { 
            get 
            {
                return this.signaturKodeField; 
            } 
            set 
            {
                this.signaturKodeField = value;
                onPropertyChanged("SignaturKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("signaturTekstField")]
        public string SignaturTekstField 
        { 
            get 
            {
                return this.signaturTekstField; 
            } 
            set 
            {
                this.signaturTekstField = value;
                onPropertyChanged("SignaturTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktPersonField")]
        public List<SignerenoAddonservicesModelsGeneratedCodePersonInfoFullmaktPerson> FullmaktPersonField 
        { 
            get 
            {
                return this.fullmaktPersonField; 
            } 
            set 
            {
                this.fullmaktPersonField = value;
                onPropertyChanged("FullmaktPersonField");
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