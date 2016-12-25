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
    public class CreditCheckCompanyResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? orgNumber;
        private string orgName;
        private string address;
        private string postalCode;
        private string city;
        private DateTime? incorporationDate;
        private string chairMan;
        private string cEO;
        private Economy economy;
        private string bisnodeRatingCode;
        private string bisnodeRatingDescription;
        private double? creditLimit;
        private string paymentDefaults;
        private string requestId;
        private string report;
        private HentForetakResponse detailedInformation;
        private int? numberOfPaymentDefaults;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OrgNumber")]
        public int? OrgNumber 
        { 
            get 
            {
                return this.orgNumber; 
            } 
            set 
            {
                this.orgNumber = value;
                onPropertyChanged("OrgNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName 
        { 
            get 
            {
                return this.orgName; 
            } 
            set 
            {
                this.orgName = value;
                onPropertyChanged("OrgName");
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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("IncorporationDate")]
        public DateTime? IncorporationDate 
        { 
            get 
            {
                return this.incorporationDate; 
            } 
            set 
            {
                this.incorporationDate = value;
                onPropertyChanged("IncorporationDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ChairMan")]
        public string ChairMan 
        { 
            get 
            {
                return this.chairMan; 
            } 
            set 
            {
                this.chairMan = value;
                onPropertyChanged("ChairMan");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CEO")]
        public string CEO 
        { 
            get 
            {
                return this.cEO; 
            } 
            set 
            {
                this.cEO = value;
                onPropertyChanged("CEO");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Economy")]
        public Economy Economy 
        { 
            get 
            {
                return this.economy; 
            } 
            set 
            {
                this.economy = value;
                onPropertyChanged("Economy");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BisnodeRatingCode")]
        public string BisnodeRatingCode 
        { 
            get 
            {
                return this.bisnodeRatingCode; 
            } 
            set 
            {
                this.bisnodeRatingCode = value;
                onPropertyChanged("BisnodeRatingCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BisnodeRatingDescription")]
        public string BisnodeRatingDescription 
        { 
            get 
            {
                return this.bisnodeRatingDescription; 
            } 
            set 
            {
                this.bisnodeRatingDescription = value;
                onPropertyChanged("BisnodeRatingDescription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CreditLimit")]
        public double? CreditLimit 
        { 
            get 
            {
                return this.creditLimit; 
            } 
            set 
            {
                this.creditLimit = value;
                onPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PaymentDefaults")]
        public string PaymentDefaults 
        { 
            get 
            {
                return this.paymentDefaults; 
            } 
            set 
            {
                this.paymentDefaults = value;
                onPropertyChanged("PaymentDefaults");
            }
        }

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
        [JsonProperty("DetailedInformation")]
        public HentForetakResponse DetailedInformation 
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