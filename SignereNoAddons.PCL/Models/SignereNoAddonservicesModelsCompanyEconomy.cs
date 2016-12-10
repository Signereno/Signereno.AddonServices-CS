/*
 * SignereNoAddons.PCL
 *
 * This file was automatically generated for Signere.no by APIMATIC v2.0 ( https://apimatic.io ) on 12/10/2016
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
    public class SignereNoAddonservicesModelsCompanyEconomy : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? year;
        private long? turnover;
        private long? operatingProfit;
        private double? equity;
        private int? employees;

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
        [JsonProperty("Turnover")]
        public long? Turnover 
        { 
            get 
            {
                return this.turnover; 
            } 
            set 
            {
                this.turnover = value;
                onPropertyChanged("Turnover");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OperatingProfit")]
        public long? OperatingProfit 
        { 
            get 
            {
                return this.operatingProfit; 
            } 
            set 
            {
                this.operatingProfit = value;
                onPropertyChanged("OperatingProfit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Equity")]
        public double? Equity 
        { 
            get 
            {
                return this.equity; 
            } 
            set 
            {
                this.equity = value;
                onPropertyChanged("Equity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Employees")]
        public int? Employees 
        { 
            get 
            {
                return this.employees; 
            } 
            set 
            {
                this.employees = value;
                onPropertyChanged("Employees");
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