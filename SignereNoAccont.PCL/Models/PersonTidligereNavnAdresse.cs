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
    public class PersonTidligereNavnAdresse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string tidligereNavnAdresse1Field;
        private DateTime? endringsDatoField;
        private string endringsTypeField;
        private string tidligerePostAdresseField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tidligereNavnAdresse1Field")]
        public string TidligereNavnAdresse1Field 
        { 
            get 
            {
                return this.tidligereNavnAdresse1Field; 
            } 
            set 
            {
                this.tidligereNavnAdresse1Field = value;
                onPropertyChanged("TidligereNavnAdresse1Field");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endringsDatoField")]
        public DateTime? EndringsDatoField 
        { 
            get 
            {
                return this.endringsDatoField; 
            } 
            set 
            {
                this.endringsDatoField = value;
                onPropertyChanged("EndringsDatoField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endringsTypeField")]
        public string EndringsTypeField 
        { 
            get 
            {
                return this.endringsTypeField; 
            } 
            set 
            {
                this.endringsTypeField = value;
                onPropertyChanged("EndringsTypeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tidligerePostAdresseField")]
        public string TidligerePostAdresseField 
        { 
            get 
            {
                return this.tidligerePostAdresseField; 
            } 
            set 
            {
                this.tidligerePostAdresseField = value;
                onPropertyChanged("TidligerePostAdresseField");
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