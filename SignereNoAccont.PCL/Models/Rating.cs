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
    public class Rating : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string rating1Field;
        private string ratingBeskrivelseField;
        private int? limitField;
        private string aktuellHendelseField;
        private string delbGrunnfaktaField;
        private string delbEierJurdiskField;
        private string delbOkonomiField;
        private string delbBetalingserfaringField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("rating1Field")]
        public string Rating1Field 
        { 
            get 
            {
                return this.rating1Field; 
            } 
            set 
            {
                this.rating1Field = value;
                onPropertyChanged("Rating1Field");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ratingBeskrivelseField")]
        public string RatingBeskrivelseField 
        { 
            get 
            {
                return this.ratingBeskrivelseField; 
            } 
            set 
            {
                this.ratingBeskrivelseField = value;
                onPropertyChanged("RatingBeskrivelseField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("limitField")]
        public int? LimitField 
        { 
            get 
            {
                return this.limitField; 
            } 
            set 
            {
                this.limitField = value;
                onPropertyChanged("LimitField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("aktuellHendelseField")]
        public string AktuellHendelseField 
        { 
            get 
            {
                return this.aktuellHendelseField; 
            } 
            set 
            {
                this.aktuellHendelseField = value;
                onPropertyChanged("AktuellHendelseField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delbGrunnfaktaField")]
        public string DelbGrunnfaktaField 
        { 
            get 
            {
                return this.delbGrunnfaktaField; 
            } 
            set 
            {
                this.delbGrunnfaktaField = value;
                onPropertyChanged("DelbGrunnfaktaField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delbEierJurdiskField")]
        public string DelbEierJurdiskField 
        { 
            get 
            {
                return this.delbEierJurdiskField; 
            } 
            set 
            {
                this.delbEierJurdiskField = value;
                onPropertyChanged("DelbEierJurdiskField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delbOkonomiField")]
        public string DelbOkonomiField 
        { 
            get 
            {
                return this.delbOkonomiField; 
            } 
            set 
            {
                this.delbOkonomiField = value;
                onPropertyChanged("DelbOkonomiField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delbBetalingserfaringField")]
        public string DelbBetalingserfaringField 
        { 
            get 
            {
                return this.delbBetalingserfaringField; 
            } 
            set 
            {
                this.delbBetalingserfaringField = value;
                onPropertyChanged("DelbBetalingserfaringField");
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