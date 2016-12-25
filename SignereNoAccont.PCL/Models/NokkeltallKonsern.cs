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
    public class NokkeltallKonsern : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? regnskapsAvArField;
        private int? regnskapsAvMndField;
        private double? overskuddsprosentField;
        private double? rentedekningsgradField;
        private double? totalrentabilitetField;
        private double? eKRentabilitetField;
        private double? langLagerfinansField;
        private double? gjennomsnittLagerField;
        private double? egenkapitalAndelField;
        private double? tapsbufferField;
        private double? fremmedkapitalKostnadField;
        private double? likviditetsgrad1Field;
        private double? likviditetsgrad2Field;
        private double? likviderProsentSalgField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("regnskapsAvArField")]
        public int? RegnskapsAvArField 
        { 
            get 
            {
                return this.regnskapsAvArField; 
            } 
            set 
            {
                this.regnskapsAvArField = value;
                onPropertyChanged("RegnskapsAvArField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("regnskapsAvMndField")]
        public int? RegnskapsAvMndField 
        { 
            get 
            {
                return this.regnskapsAvMndField; 
            } 
            set 
            {
                this.regnskapsAvMndField = value;
                onPropertyChanged("RegnskapsAvMndField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("overskuddsprosentField")]
        public double? OverskuddsprosentField 
        { 
            get 
            {
                return this.overskuddsprosentField; 
            } 
            set 
            {
                this.overskuddsprosentField = value;
                onPropertyChanged("OverskuddsprosentField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("rentedekningsgradField")]
        public double? RentedekningsgradField 
        { 
            get 
            {
                return this.rentedekningsgradField; 
            } 
            set 
            {
                this.rentedekningsgradField = value;
                onPropertyChanged("RentedekningsgradField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("totalrentabilitetField")]
        public double? TotalrentabilitetField 
        { 
            get 
            {
                return this.totalrentabilitetField; 
            } 
            set 
            {
                this.totalrentabilitetField = value;
                onPropertyChanged("TotalrentabilitetField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eKRentabilitetField")]
        public double? EKRentabilitetField 
        { 
            get 
            {
                return this.eKRentabilitetField; 
            } 
            set 
            {
                this.eKRentabilitetField = value;
                onPropertyChanged("EKRentabilitetField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("langLagerfinansField")]
        public double? LangLagerfinansField 
        { 
            get 
            {
                return this.langLagerfinansField; 
            } 
            set 
            {
                this.langLagerfinansField = value;
                onPropertyChanged("LangLagerfinansField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjennomsnittLagerField")]
        public double? GjennomsnittLagerField 
        { 
            get 
            {
                return this.gjennomsnittLagerField; 
            } 
            set 
            {
                this.gjennomsnittLagerField = value;
                onPropertyChanged("GjennomsnittLagerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("egenkapitalAndelField")]
        public double? EgenkapitalAndelField 
        { 
            get 
            {
                return this.egenkapitalAndelField; 
            } 
            set 
            {
                this.egenkapitalAndelField = value;
                onPropertyChanged("EgenkapitalAndelField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tapsbufferField")]
        public double? TapsbufferField 
        { 
            get 
            {
                return this.tapsbufferField; 
            } 
            set 
            {
                this.tapsbufferField = value;
                onPropertyChanged("TapsbufferField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fremmedkapitalKostnadField")]
        public double? FremmedkapitalKostnadField 
        { 
            get 
            {
                return this.fremmedkapitalKostnadField; 
            } 
            set 
            {
                this.fremmedkapitalKostnadField = value;
                onPropertyChanged("FremmedkapitalKostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("likviditetsgrad1Field")]
        public double? Likviditetsgrad1Field 
        { 
            get 
            {
                return this.likviditetsgrad1Field; 
            } 
            set 
            {
                this.likviditetsgrad1Field = value;
                onPropertyChanged("Likviditetsgrad1Field");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("likviditetsgrad2Field")]
        public double? Likviditetsgrad2Field 
        { 
            get 
            {
                return this.likviditetsgrad2Field; 
            } 
            set 
            {
                this.likviditetsgrad2Field = value;
                onPropertyChanged("Likviditetsgrad2Field");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("likviderProsentSalgField")]
        public double? LikviderProsentSalgField 
        { 
            get 
            {
                return this.likviderProsentSalgField; 
            } 
            set 
            {
                this.likviderProsentSalgField = value;
                onPropertyChanged("LikviderProsentSalgField");
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