/*
 * SignerenoAddonServices.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 12/10/2016
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
using SignerenoAddonServices.PCL;
using SignerenoAddonServices.PCL.Utilities;

namespace SignerenoAddonServices.PCL.Models
{
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoBetaDetaljer : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private DateTime? registrertDatoField;
        private string betaGruppeKodeField;
        private string betaGruppeTekstField;
        private string betaTypeField;
        private string betaTekstField;
        private long? betaBelopField;
        private string kildeKodeField;
        private string kildeTekstField;
        private long? kildeReferansenrField;
        private string statusAnmerkningField;
        private DateTime? statusDatoField;
        private string kreditorField;

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
        [JsonProperty("betaGruppeKodeField")]
        public string BetaGruppeKodeField 
        { 
            get 
            {
                return this.betaGruppeKodeField; 
            } 
            set 
            {
                this.betaGruppeKodeField = value;
                onPropertyChanged("BetaGruppeKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaGruppeTekstField")]
        public string BetaGruppeTekstField 
        { 
            get 
            {
                return this.betaGruppeTekstField; 
            } 
            set 
            {
                this.betaGruppeTekstField = value;
                onPropertyChanged("BetaGruppeTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaTypeField")]
        public string BetaTypeField 
        { 
            get 
            {
                return this.betaTypeField; 
            } 
            set 
            {
                this.betaTypeField = value;
                onPropertyChanged("BetaTypeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaTekstField")]
        public string BetaTekstField 
        { 
            get 
            {
                return this.betaTekstField; 
            } 
            set 
            {
                this.betaTekstField = value;
                onPropertyChanged("BetaTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaBelopField")]
        public long? BetaBelopField 
        { 
            get 
            {
                return this.betaBelopField; 
            } 
            set 
            {
                this.betaBelopField = value;
                onPropertyChanged("BetaBelopField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kildeKodeField")]
        public string KildeKodeField 
        { 
            get 
            {
                return this.kildeKodeField; 
            } 
            set 
            {
                this.kildeKodeField = value;
                onPropertyChanged("KildeKodeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kildeTekstField")]
        public string KildeTekstField 
        { 
            get 
            {
                return this.kildeTekstField; 
            } 
            set 
            {
                this.kildeTekstField = value;
                onPropertyChanged("KildeTekstField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kildeReferansenrField")]
        public long? KildeReferansenrField 
        { 
            get 
            {
                return this.kildeReferansenrField; 
            } 
            set 
            {
                this.kildeReferansenrField = value;
                onPropertyChanged("KildeReferansenrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusAnmerkningField")]
        public string StatusAnmerkningField 
        { 
            get 
            {
                return this.statusAnmerkningField; 
            } 
            set 
            {
                this.statusAnmerkningField = value;
                onPropertyChanged("StatusAnmerkningField");
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
        [JsonProperty("kreditorField")]
        public string KreditorField 
        { 
            get 
            {
                return this.kreditorField; 
            } 
            set 
            {
                this.kreditorField = value;
                onPropertyChanged("KreditorField");
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