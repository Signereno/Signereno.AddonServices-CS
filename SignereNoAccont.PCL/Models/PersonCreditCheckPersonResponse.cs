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
    public class PersonCreditCheckPersonResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string requestId;
        private string report;
        private string name;
        private string address;
        private string city;
        private string postalCode;
        private int? score;
        private string scoreDecision;
        private string dateOfBirth;
        private int? age;
        private string gender;
        private int? numberOfPaymentDefaults;
        private double? paymentDefaultsAmount;
        private List<PersonEconomy> incomeAndFortune;
        private PersonHentPersonResponse detailedInformation;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId 
        { 
            get 
            {
                return this.requestId; 
            } 
            set 
            {
                this.requestId = value;
                onPropertyChanged("RequestId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Report")]
        public string Report 
        { 
            get 
            {
                return this.report; 
            } 
            set 
            {
                this.report = value;
                onPropertyChanged("Report");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Address")]
        public string Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("City")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Score")]
        public int? Score 
        { 
            get 
            {
                return this.score; 
            } 
            set 
            {
                this.score = value;
                onPropertyChanged("Score");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ScoreDecision")]
        public string ScoreDecision 
        { 
            get 
            {
                return this.scoreDecision; 
            } 
            set 
            {
                this.scoreDecision = value;
                onPropertyChanged("ScoreDecision");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth 
        { 
            get 
            {
                return this.dateOfBirth; 
            } 
            set 
            {
                this.dateOfBirth = value;
                onPropertyChanged("DateOfBirth");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Age")]
        public int? Age 
        { 
            get 
            {
                return this.age; 
            } 
            set 
            {
                this.age = value;
                onPropertyChanged("Age");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender 
        { 
            get 
            {
                return this.gender; 
            } 
            set 
            {
                this.gender = value;
                onPropertyChanged("Gender");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NumberOfPaymentDefaults")]
        public int? NumberOfPaymentDefaults 
        { 
            get 
            {
                return this.numberOfPaymentDefaults; 
            } 
            set 
            {
                this.numberOfPaymentDefaults = value;
                onPropertyChanged("NumberOfPaymentDefaults");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PaymentDefaultsAmount")]
        public double? PaymentDefaultsAmount 
        { 
            get 
            {
                return this.paymentDefaultsAmount; 
            } 
            set 
            {
                this.paymentDefaultsAmount = value;
                onPropertyChanged("PaymentDefaultsAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IncomeAndFortune")]
        public List<PersonEconomy> IncomeAndFortune 
        { 
            get 
            {
                return this.incomeAndFortune; 
            } 
            set 
            {
                this.incomeAndFortune = value;
                onPropertyChanged("IncomeAndFortune");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DetailedInformation")]
        public PersonHentPersonResponse DetailedInformation 
        { 
            get 
            {
                return this.detailedInformation; 
            } 
            set 
            {
                this.detailedInformation = value;
                onPropertyChanged("DetailedInformation");
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