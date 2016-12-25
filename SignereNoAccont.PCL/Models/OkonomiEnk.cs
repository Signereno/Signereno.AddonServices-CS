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
    public class OkonomiEnk : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private DateTime? fodselsdatoEierField;
        private int? skatteArField;
        private long? formueField;
        private double? endringFormueField;
        private long? inntektField;
        private double? endringInntektField;
        private long? skattField;
        private string skatteKlasseField;
        private string skatteKlasseUtlField;
        private int? kommunenrField;
        private string kommuneNavnField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("fodselsdatoEierField")]
        public DateTime? FodselsdatoEierField 
        { 
            get 
            {
                return this.fodselsdatoEierField; 
            } 
            set 
            {
                this.fodselsdatoEierField = value;
                onPropertyChanged("FodselsdatoEierField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skatteArField")]
        public int? SkatteArField 
        { 
            get 
            {
                return this.skatteArField; 
            } 
            set 
            {
                this.skatteArField = value;
                onPropertyChanged("SkatteArField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("formueField")]
        public long? FormueField 
        { 
            get 
            {
                return this.formueField; 
            } 
            set 
            {
                this.formueField = value;
                onPropertyChanged("FormueField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endringFormueField")]
        public double? EndringFormueField 
        { 
            get 
            {
                return this.endringFormueField; 
            } 
            set 
            {
                this.endringFormueField = value;
                onPropertyChanged("EndringFormueField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("inntektField")]
        public long? InntektField 
        { 
            get 
            {
                return this.inntektField; 
            } 
            set 
            {
                this.inntektField = value;
                onPropertyChanged("InntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endringInntektField")]
        public double? EndringInntektField 
        { 
            get 
            {
                return this.endringInntektField; 
            } 
            set 
            {
                this.endringInntektField = value;
                onPropertyChanged("EndringInntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skattField")]
        public long? SkattField 
        { 
            get 
            {
                return this.skattField; 
            } 
            set 
            {
                this.skattField = value;
                onPropertyChanged("SkattField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skatteKlasseField")]
        public string SkatteKlasseField 
        { 
            get 
            {
                return this.skatteKlasseField; 
            } 
            set 
            {
                this.skatteKlasseField = value;
                onPropertyChanged("SkatteKlasseField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skatteKlasseUtlField")]
        public string SkatteKlasseUtlField 
        { 
            get 
            {
                return this.skatteKlasseUtlField; 
            } 
            set 
            {
                this.skatteKlasseUtlField = value;
                onPropertyChanged("SkatteKlasseUtlField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kommunenrField")]
        public int? KommunenrField 
        { 
            get 
            {
                return this.kommunenrField; 
            } 
            set 
            {
                this.kommunenrField = value;
                onPropertyChanged("KommunenrField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kommuneNavnField")]
        public string KommuneNavnField 
        { 
            get 
            {
                return this.kommuneNavnField; 
            } 
            set 
            {
                this.kommuneNavnField = value;
                onPropertyChanged("KommuneNavnField");
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