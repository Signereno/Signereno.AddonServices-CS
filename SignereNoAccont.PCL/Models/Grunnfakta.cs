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
    public class Grunnfakta : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string selskFormKodeField;
        private string selskFormTekstField;
        private int? etablertArField;
        private bool? etablertArFieldSpecified;
        private DateTime? stiftetDatoField;
        private long? aksjekapitalField;
        private string aksjekapitalStatusField;
        private string registrertStedField;
        private DateTime? registrertDatoField;
        private int? revisorOrgnrField;
        private string revisorNavnField;
        private int? bankRegnrField;
        private string bankNavnField;
        private List<BransjeData> bransjeDataField;
        private List<AnsatteData> ansatteDataField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("selskFormKodeField")]
        public string SelskFormKodeField 
        { 
            get 
            {
                return this.selskFormKodeField; 
            } 
            set 
            {
                this.selskFormKodeField = value;
                onPropertyChanged("SelskFormKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("selskFormTekstField")]
        public string SelskFormTekstField 
        { 
            get 
            {
                return this.selskFormTekstField; 
            } 
            set 
            {
                this.selskFormTekstField = value;
                onPropertyChanged("SelskFormTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("etablertArField")]
        public int? EtablertArField 
        { 
            get 
            {
                return this.etablertArField; 
            } 
            set 
            {
                this.etablertArField = value;
                onPropertyChanged("EtablertArField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("etablertArFieldSpecified")]
        public bool? EtablertArFieldSpecified 
        { 
            get 
            {
                return this.etablertArFieldSpecified; 
            } 
            set 
            {
                this.etablertArFieldSpecified = value;
                onPropertyChanged("EtablertArFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("stiftetDatoField")]
        public DateTime? StiftetDatoField 
        { 
            get 
            {
                return this.stiftetDatoField; 
            } 
            set 
            {
                this.stiftetDatoField = value;
                onPropertyChanged("StiftetDatoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("aksjekapitalField")]
        public long? AksjekapitalField 
        { 
            get 
            {
                return this.aksjekapitalField; 
            } 
            set 
            {
                this.aksjekapitalField = value;
                onPropertyChanged("AksjekapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("aksjekapitalStatusField")]
        public string AksjekapitalStatusField 
        { 
            get 
            {
                return this.aksjekapitalStatusField; 
            } 
            set 
            {
                this.aksjekapitalStatusField = value;
                onPropertyChanged("AksjekapitalStatusField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("registrertStedField")]
        public string RegistrertStedField 
        { 
            get 
            {
                return this.registrertStedField; 
            } 
            set 
            {
                this.registrertStedField = value;
                onPropertyChanged("RegistrertStedField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("registrertDatoField")]
        public DateTime? RegistrertDatoField 
        { 
            get 
            {
                return this.registrertDatoField; 
            } 
            set 
            {
                this.registrertDatoField = value;
                onPropertyChanged("RegistrertDatoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("revisorOrgnrField")]
        public int? RevisorOrgnrField 
        { 
            get 
            {
                return this.revisorOrgnrField; 
            } 
            set 
            {
                this.revisorOrgnrField = value;
                onPropertyChanged("RevisorOrgnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("revisorNavnField")]
        public string RevisorNavnField 
        { 
            get 
            {
                return this.revisorNavnField; 
            } 
            set 
            {
                this.revisorNavnField = value;
                onPropertyChanged("RevisorNavnField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankRegnrField")]
        public int? BankRegnrField 
        { 
            get 
            {
                return this.bankRegnrField; 
            } 
            set 
            {
                this.bankRegnrField = value;
                onPropertyChanged("BankRegnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankNavnField")]
        public string BankNavnField 
        { 
            get 
            {
                return this.bankNavnField; 
            } 
            set 
            {
                this.bankNavnField = value;
                onPropertyChanged("BankNavnField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bransjeDataField")]
        public List<BransjeData> BransjeDataField 
        { 
            get 
            {
                return this.bransjeDataField; 
            } 
            set 
            {
                this.bransjeDataField = value;
                onPropertyChanged("BransjeDataField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ansatteDataField")]
        public List<AnsatteData> AnsatteDataField 
        { 
            get 
            {
                return this.ansatteDataField; 
            } 
            set 
            {
                this.ansatteDataField = value;
                onPropertyChanged("AnsatteDataField");
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