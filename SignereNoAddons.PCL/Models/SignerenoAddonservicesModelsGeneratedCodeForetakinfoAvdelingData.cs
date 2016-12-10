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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoAvdelingData : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? antallAnsatteField;
        private bool? antallAnsatteFieldSpecified;
        private int? telefonField;
        private bool? telefonFieldSpecified;
        private int? telefaxField;
        private bool? telefaxFieldSpecified;
        private DateTime? stiftetDatoField;
        private string bransjeKodeField;
        private string bransjeTekstField;
        private string dagligLederField;
        private int? hovedforetakOrgnrField;
        private bool? hovedforetakOrgnrFieldSpecified;
        private int? hovedforetakDunsnrField;
        private bool? hovedforetakDunsnrFieldSpecified;
        private string hovedforetakNavnField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallAnsatteField")]
        public int? AntallAnsatteField 
        { 
            get 
            {
                return this.antallAnsatteField; 
            } 
            set 
            {
                this.antallAnsatteField = value;
                onPropertyChanged("AntallAnsatteField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallAnsatteFieldSpecified")]
        public bool? AntallAnsatteFieldSpecified 
        { 
            get 
            {
                return this.antallAnsatteFieldSpecified; 
            } 
            set 
            {
                this.antallAnsatteFieldSpecified = value;
                onPropertyChanged("AntallAnsatteFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("telefonField")]
        public int? TelefonField 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("telefonFieldSpecified")]
        public bool? TelefonFieldSpecified 
        { 
            get 
            {
                return this.telefonFieldSpecified; 
            } 
            set 
            {
                this.telefonFieldSpecified = value;
                onPropertyChanged("TelefonFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("telefaxField")]
        public int? TelefaxField 
        { 
            get 
            {
                return this.telefaxField; 
            } 
            set 
            {
                this.telefaxField = value;
                onPropertyChanged("TelefaxField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("telefaxFieldSpecified")]
        public bool? TelefaxFieldSpecified 
        { 
            get 
            {
                return this.telefaxFieldSpecified; 
            } 
            set 
            {
                this.telefaxFieldSpecified = value;
                onPropertyChanged("TelefaxFieldSpecified");
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
        [JsonProperty("bransjeKodeField")]
        public string BransjeKodeField 
        { 
            get 
            {
                return this.bransjeKodeField; 
            } 
            set 
            {
                this.bransjeKodeField = value;
                onPropertyChanged("BransjeKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bransjeTekstField")]
        public string BransjeTekstField 
        { 
            get 
            {
                return this.bransjeTekstField; 
            } 
            set 
            {
                this.bransjeTekstField = value;
                onPropertyChanged("BransjeTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("dagligLederField")]
        public string DagligLederField 
        { 
            get 
            {
                return this.dagligLederField; 
            } 
            set 
            {
                this.dagligLederField = value;
                onPropertyChanged("DagligLederField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hovedforetakOrgnrField")]
        public int? HovedforetakOrgnrField 
        { 
            get 
            {
                return this.hovedforetakOrgnrField; 
            } 
            set 
            {
                this.hovedforetakOrgnrField = value;
                onPropertyChanged("HovedforetakOrgnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hovedforetakOrgnrFieldSpecified")]
        public bool? HovedforetakOrgnrFieldSpecified 
        { 
            get 
            {
                return this.hovedforetakOrgnrFieldSpecified; 
            } 
            set 
            {
                this.hovedforetakOrgnrFieldSpecified = value;
                onPropertyChanged("HovedforetakOrgnrFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hovedforetakDunsnrField")]
        public int? HovedforetakDunsnrField 
        { 
            get 
            {
                return this.hovedforetakDunsnrField; 
            } 
            set 
            {
                this.hovedforetakDunsnrField = value;
                onPropertyChanged("HovedforetakDunsnrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hovedforetakDunsnrFieldSpecified")]
        public bool? HovedforetakDunsnrFieldSpecified 
        { 
            get 
            {
                return this.hovedforetakDunsnrFieldSpecified; 
            } 
            set 
            {
                this.hovedforetakDunsnrFieldSpecified = value;
                onPropertyChanged("HovedforetakDunsnrFieldSpecified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hovedforetakNavnField")]
        public string HovedforetakNavnField 
        { 
            get 
            {
                return this.hovedforetakNavnField; 
            } 
            set 
            {
                this.hovedforetakNavnField = value;
                onPropertyChanged("HovedforetakNavnField");
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