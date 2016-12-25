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
    public class AnsatteData : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? ansatteArField;
        private int? ansatteAntallField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ansatteArField")]
        public int? AnsatteArField 
        { 
            get 
            {
                return this.ansatteArField; 
            } 
            set 
            {
                this.ansatteArField = value;
                onPropertyChanged("AnsatteArField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ansatteAntallField")]
        public int? AnsatteAntallField 
        { 
            get 
            {
                return this.ansatteAntallField; 
            } 
            set 
            {
                this.ansatteAntallField = value;
                onPropertyChanged("AnsatteAntallField");
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