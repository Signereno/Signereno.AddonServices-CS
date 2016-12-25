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
    public class PersonBetaSammendrag : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? antallInkassoField;
        private DateTime? ajourDatoInkassoField;
        private int? antallPanterLosoreField;
        private DateTime? ajourDatoLosoreField;
        private int? antallPanterEiendomField;
        private DateTime? ajourDatoEiendomField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallInkassoField")]
        public int? AntallInkassoField 
        { 
            get 
            {
                return this.antallInkassoField; 
            } 
            set 
            {
                this.antallInkassoField = value;
                onPropertyChanged("AntallInkassoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ajourDatoInkassoField")]
        public DateTime? AjourDatoInkassoField 
        { 
            get 
            {
                return this.ajourDatoInkassoField; 
            } 
            set 
            {
                this.ajourDatoInkassoField = value;
                onPropertyChanged("AjourDatoInkassoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallPanterLosoreField")]
        public int? AntallPanterLosoreField 
        { 
            get 
            {
                return this.antallPanterLosoreField; 
            } 
            set 
            {
                this.antallPanterLosoreField = value;
                onPropertyChanged("AntallPanterLosoreField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ajourDatoLosoreField")]
        public DateTime? AjourDatoLosoreField 
        { 
            get 
            {
                return this.ajourDatoLosoreField; 
            } 
            set 
            {
                this.ajourDatoLosoreField = value;
                onPropertyChanged("AjourDatoLosoreField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antallPanterEiendomField")]
        public int? AntallPanterEiendomField 
        { 
            get 
            {
                return this.antallPanterEiendomField; 
            } 
            set 
            {
                this.antallPanterEiendomField = value;
                onPropertyChanged("AntallPanterEiendomField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ajourDatoEiendomField")]
        public DateTime? AjourDatoEiendomField 
        { 
            get 
            {
                return this.ajourDatoEiendomField; 
            } 
            set 
            {
                this.ajourDatoEiendomField = value;
                onPropertyChanged("AjourDatoEiendomField");
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