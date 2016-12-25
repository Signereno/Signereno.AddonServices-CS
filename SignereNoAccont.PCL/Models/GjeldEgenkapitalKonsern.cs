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
    public class GjeldEgenkapitalKonsern : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? regnskapsAvArField;
        private int? regnskapsAvMndField;
        private long? sumEgenkapitalField;
        private long? innskuttEgenkapitalField;
        private long? selskapskapitalField;
        private long? egneAksjerField;
        private long? overkursfondField;
        private long? opptjentEgenkapitalField;
        private long? fondForVurdField;
        private long? annenEgenkapitalField;
        private long? minoritetsinteresserField;
        private long? sumGjeldField;
        private long? avsetningForpliktelserField;
        private long? pensjonForpliktelserField;
        private long? utsattSkattField;
        private long? andreAvsetningerField;
        private long? sumLangsiktigGjeldField;
        private long? annenLangsiktigGjeldField;
        private long? konvertibleLanLangField;
        private long? obligasjonsLanField;
        private long? gjeldKredittLangField;
        private long? gjeldKonsernLangField;
        private long? ansvarligLanekapitalField;
        private long? ovrigLangsiktigGjeldField;
        private long? sumKortsiktigGjeldField;
        private long? konvertibleLanKortField;
        private long? sertifikatLanField;
        private long? gjeldKredittKortField;
        private long? kassakredittField;
        private long? leverandorGjeldField;
        private long? betalbarSkattField;
        private long? skyldOffentligAvgiftField;
        private long? gjeldKonsernKortField;
        private long? utbytteField;
        private long? annenKortsiktigGjeldField;
        private long? sumGjeldEgenkapitalField;
        private long? kassekredittlimitField;
        private long? skyldKonsernbidragField;
        private long? avdragLangsiktigGjeldField;

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
        [JsonProperty("sumEgenkapitalField")]
        public long? SumEgenkapitalField 
        { 
            get 
            {
                return this.sumEgenkapitalField; 
            } 
            set 
            {
                this.sumEgenkapitalField = value;
                onPropertyChanged("SumEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("innskuttEgenkapitalField")]
        public long? InnskuttEgenkapitalField 
        { 
            get 
            {
                return this.innskuttEgenkapitalField; 
            } 
            set 
            {
                this.innskuttEgenkapitalField = value;
                onPropertyChanged("InnskuttEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("selskapskapitalField")]
        public long? SelskapskapitalField 
        { 
            get 
            {
                return this.selskapskapitalField; 
            } 
            set 
            {
                this.selskapskapitalField = value;
                onPropertyChanged("SelskapskapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("egneAksjerField")]
        public long? EgneAksjerField 
        { 
            get 
            {
                return this.egneAksjerField; 
            } 
            set 
            {
                this.egneAksjerField = value;
                onPropertyChanged("EgneAksjerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("overkursfondField")]
        public long? OverkursfondField 
        { 
            get 
            {
                return this.overkursfondField; 
            } 
            set 
            {
                this.overkursfondField = value;
                onPropertyChanged("OverkursfondField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("opptjentEgenkapitalField")]
        public long? OpptjentEgenkapitalField 
        { 
            get 
            {
                return this.opptjentEgenkapitalField; 
            } 
            set 
            {
                this.opptjentEgenkapitalField = value;
                onPropertyChanged("OpptjentEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fondForVurdField")]
        public long? FondForVurdField 
        { 
            get 
            {
                return this.fondForVurdField; 
            } 
            set 
            {
                this.fondForVurdField = value;
                onPropertyChanged("FondForVurdField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenEgenkapitalField")]
        public long? AnnenEgenkapitalField 
        { 
            get 
            {
                return this.annenEgenkapitalField; 
            } 
            set 
            {
                this.annenEgenkapitalField = value;
                onPropertyChanged("AnnenEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minoritetsinteresserField")]
        public long? MinoritetsinteresserField 
        { 
            get 
            {
                return this.minoritetsinteresserField; 
            } 
            set 
            {
                this.minoritetsinteresserField = value;
                onPropertyChanged("MinoritetsinteresserField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sumGjeldField")]
        public long? SumGjeldField 
        { 
            get 
            {
                return this.sumGjeldField; 
            } 
            set 
            {
                this.sumGjeldField = value;
                onPropertyChanged("SumGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("avsetningForpliktelserField")]
        public long? AvsetningForpliktelserField 
        { 
            get 
            {
                return this.avsetningForpliktelserField; 
            } 
            set 
            {
                this.avsetningForpliktelserField = value;
                onPropertyChanged("AvsetningForpliktelserField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pensjonForpliktelserField")]
        public long? PensjonForpliktelserField 
        { 
            get 
            {
                return this.pensjonForpliktelserField; 
            } 
            set 
            {
                this.pensjonForpliktelserField = value;
                onPropertyChanged("PensjonForpliktelserField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("utsattSkattField")]
        public long? UtsattSkattField 
        { 
            get 
            {
                return this.utsattSkattField; 
            } 
            set 
            {
                this.utsattSkattField = value;
                onPropertyChanged("UtsattSkattField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("andreAvsetningerField")]
        public long? AndreAvsetningerField 
        { 
            get 
            {
                return this.andreAvsetningerField; 
            } 
            set 
            {
                this.andreAvsetningerField = value;
                onPropertyChanged("AndreAvsetningerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sumLangsiktigGjeldField")]
        public long? SumLangsiktigGjeldField 
        { 
            get 
            {
                return this.sumLangsiktigGjeldField; 
            } 
            set 
            {
                this.sumLangsiktigGjeldField = value;
                onPropertyChanged("SumLangsiktigGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenLangsiktigGjeldField")]
        public long? AnnenLangsiktigGjeldField 
        { 
            get 
            {
                return this.annenLangsiktigGjeldField; 
            } 
            set 
            {
                this.annenLangsiktigGjeldField = value;
                onPropertyChanged("AnnenLangsiktigGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("konvertibleLanLangField")]
        public long? KonvertibleLanLangField 
        { 
            get 
            {
                return this.konvertibleLanLangField; 
            } 
            set 
            {
                this.konvertibleLanLangField = value;
                onPropertyChanged("KonvertibleLanLangField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("obligasjonsLanField")]
        public long? ObligasjonsLanField 
        { 
            get 
            {
                return this.obligasjonsLanField; 
            } 
            set 
            {
                this.obligasjonsLanField = value;
                onPropertyChanged("ObligasjonsLanField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldKredittLangField")]
        public long? GjeldKredittLangField 
        { 
            get 
            {
                return this.gjeldKredittLangField; 
            } 
            set 
            {
                this.gjeldKredittLangField = value;
                onPropertyChanged("GjeldKredittLangField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldKonsernLangField")]
        public long? GjeldKonsernLangField 
        { 
            get 
            {
                return this.gjeldKonsernLangField; 
            } 
            set 
            {
                this.gjeldKonsernLangField = value;
                onPropertyChanged("GjeldKonsernLangField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ansvarligLanekapitalField")]
        public long? AnsvarligLanekapitalField 
        { 
            get 
            {
                return this.ansvarligLanekapitalField; 
            } 
            set 
            {
                this.ansvarligLanekapitalField = value;
                onPropertyChanged("AnsvarligLanekapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ovrigLangsiktigGjeldField")]
        public long? OvrigLangsiktigGjeldField 
        { 
            get 
            {
                return this.ovrigLangsiktigGjeldField; 
            } 
            set 
            {
                this.ovrigLangsiktigGjeldField = value;
                onPropertyChanged("OvrigLangsiktigGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sumKortsiktigGjeldField")]
        public long? SumKortsiktigGjeldField 
        { 
            get 
            {
                return this.sumKortsiktigGjeldField; 
            } 
            set 
            {
                this.sumKortsiktigGjeldField = value;
                onPropertyChanged("SumKortsiktigGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("konvertibleLanKortField")]
        public long? KonvertibleLanKortField 
        { 
            get 
            {
                return this.konvertibleLanKortField; 
            } 
            set 
            {
                this.konvertibleLanKortField = value;
                onPropertyChanged("KonvertibleLanKortField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sertifikatLanField")]
        public long? SertifikatLanField 
        { 
            get 
            {
                return this.sertifikatLanField; 
            } 
            set 
            {
                this.sertifikatLanField = value;
                onPropertyChanged("SertifikatLanField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldKredittKortField")]
        public long? GjeldKredittKortField 
        { 
            get 
            {
                return this.gjeldKredittKortField; 
            } 
            set 
            {
                this.gjeldKredittKortField = value;
                onPropertyChanged("GjeldKredittKortField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kassakredittField")]
        public long? KassakredittField 
        { 
            get 
            {
                return this.kassakredittField; 
            } 
            set 
            {
                this.kassakredittField = value;
                onPropertyChanged("KassakredittField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("leverandorGjeldField")]
        public long? LeverandorGjeldField 
        { 
            get 
            {
                return this.leverandorGjeldField; 
            } 
            set 
            {
                this.leverandorGjeldField = value;
                onPropertyChanged("LeverandorGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betalbarSkattField")]
        public long? BetalbarSkattField 
        { 
            get 
            {
                return this.betalbarSkattField; 
            } 
            set 
            {
                this.betalbarSkattField = value;
                onPropertyChanged("BetalbarSkattField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skyldOffentligAvgiftField")]
        public long? SkyldOffentligAvgiftField 
        { 
            get 
            {
                return this.skyldOffentligAvgiftField; 
            } 
            set 
            {
                this.skyldOffentligAvgiftField = value;
                onPropertyChanged("SkyldOffentligAvgiftField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldKonsernKortField")]
        public long? GjeldKonsernKortField 
        { 
            get 
            {
                return this.gjeldKonsernKortField; 
            } 
            set 
            {
                this.gjeldKonsernKortField = value;
                onPropertyChanged("GjeldKonsernKortField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("utbytteField")]
        public long? UtbytteField 
        { 
            get 
            {
                return this.utbytteField; 
            } 
            set 
            {
                this.utbytteField = value;
                onPropertyChanged("UtbytteField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenKortsiktigGjeldField")]
        public long? AnnenKortsiktigGjeldField 
        { 
            get 
            {
                return this.annenKortsiktigGjeldField; 
            } 
            set 
            {
                this.annenKortsiktigGjeldField = value;
                onPropertyChanged("AnnenKortsiktigGjeldField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sumGjeldEgenkapitalField")]
        public long? SumGjeldEgenkapitalField 
        { 
            get 
            {
                return this.sumGjeldEgenkapitalField; 
            } 
            set 
            {
                this.sumGjeldEgenkapitalField = value;
                onPropertyChanged("SumGjeldEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kassekredittlimitField")]
        public long? KassekredittlimitField 
        { 
            get 
            {
                return this.kassekredittlimitField; 
            } 
            set 
            {
                this.kassekredittlimitField = value;
                onPropertyChanged("KassekredittlimitField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skyldKonsernbidragField")]
        public long? SkyldKonsernbidragField 
        { 
            get 
            {
                return this.skyldKonsernbidragField; 
            } 
            set 
            {
                this.skyldKonsernbidragField = value;
                onPropertyChanged("SkyldKonsernbidragField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("avdragLangsiktigGjeldField")]
        public long? AvdragLangsiktigGjeldField 
        { 
            get 
            {
                return this.avdragLangsiktigGjeldField; 
            } 
            set 
            {
                this.avdragLangsiktigGjeldField = value;
                onPropertyChanged("AvdragLangsiktigGjeldField");
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