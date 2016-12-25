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
    public class HistoriskRating : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? endrArField;
        private int? endrMndField;
        private string ratingField;
        private int? limitField;
        private string aktuellHendelseField;
        private int? regnArField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endrArField")]
        public int? EndrArField 
        { 
            get 
            {
                return this.endrArField; 
            } 
            set 
            {
                this.endrArField = value;
                onPropertyChanged("EndrArField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endrMndField")]
        public int? EndrMndField 
        { 
            get 
            {
                return this.endrMndField; 
            } 
            set 
            {
                this.endrMndField = value;
                onPropertyChanged("EndrMndField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ratingField")]
        public string RatingField 
        { 
            get 
            {
                return this.ratingField; 
            } 
            set 
            {
                this.ratingField = value;
                onPropertyChanged("RatingField");
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
        [JsonProperty("regnArField")]
        public int? RegnArField 
        { 
            get 
            {
                return this.regnArField; 
            } 
            set 
            {
                this.regnArField = value;
                onPropertyChanged("RegnArField");
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