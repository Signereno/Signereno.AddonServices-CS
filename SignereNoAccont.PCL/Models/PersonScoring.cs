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
    public class PersonScoring : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string beslutningField;
        private List<PersonArsaksData> arsaksDataField;
        private int? scoreField;
        private int? grenseAvslagField;
        private int? grenseGodkjentField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("beslutningField")]
        public string BeslutningField 
        { 
            get 
            {
                return this.beslutningField; 
            } 
            set 
            {
                this.beslutningField = value;
                onPropertyChanged("BeslutningField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("arsaksDataField")]
        public List<PersonArsaksData> ArsaksDataField 
        { 
            get 
            {
                return this.arsaksDataField; 
            } 
            set 
            {
                this.arsaksDataField = value;
                onPropertyChanged("ArsaksDataField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("scoreField")]
        public int? ScoreField 
        { 
            get 
            {
                return this.scoreField; 
            } 
            set 
            {
                this.scoreField = value;
                onPropertyChanged("ScoreField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("grenseAvslagField")]
        public int? GrenseAvslagField 
        { 
            get 
            {
                return this.grenseAvslagField; 
            } 
            set 
            {
                this.grenseAvslagField = value;
                onPropertyChanged("GrenseAvslagField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("grenseGodkjentField")]
        public int? GrenseGodkjentField 
        { 
            get 
            {
                return this.grenseGodkjentField; 
            } 
            set 
            {
                this.grenseGodkjentField = value;
                onPropertyChanged("GrenseGodkjentField");
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