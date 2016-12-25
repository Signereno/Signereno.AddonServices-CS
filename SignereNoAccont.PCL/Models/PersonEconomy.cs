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
    public class PersonEconomy : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? year;
        private double? netIncome;
        private double? incomeChange;
        private double? fortune;
        private double? assessedTax;
        private string taxClass;
        private string municipal;
        private string municipalNumber;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Year")]
        public int? Year 
        { 
            get 
            {
                return this.year; 
            } 
            set 
            {
                this.year = value;
                onPropertyChanged("Year");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NetIncome")]
        public double? NetIncome 
        { 
            get 
            {
                return this.netIncome; 
            } 
            set 
            {
                this.netIncome = value;
                onPropertyChanged("NetIncome");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IncomeChange")]
        public double? IncomeChange 
        { 
            get 
            {
                return this.incomeChange; 
            } 
            set 
            {
                this.incomeChange = value;
                onPropertyChanged("IncomeChange");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Fortune")]
        public double? Fortune 
        { 
            get 
            {
                return this.fortune; 
            } 
            set 
            {
                this.fortune = value;
                onPropertyChanged("Fortune");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AssessedTax")]
        public double? AssessedTax 
        { 
            get 
            {
                return this.assessedTax; 
            } 
            set 
            {
                this.assessedTax = value;
                onPropertyChanged("AssessedTax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TaxClass")]
        public string TaxClass 
        { 
            get 
            {
                return this.taxClass; 
            } 
            set 
            {
                this.taxClass = value;
                onPropertyChanged("TaxClass");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Municipal")]
        public string Municipal 
        { 
            get 
            {
                return this.municipal; 
            } 
            set 
            {
                this.municipal = value;
                onPropertyChanged("Municipal");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MunicipalNumber")]
        public string MunicipalNumber 
        { 
            get 
            {
                return this.municipalNumber; 
            } 
            set 
            {
                this.municipalNumber = value;
                onPropertyChanged("MunicipalNumber");
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