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
    public class SignerenoAddonservicesModelsGeneratedCodeForetakinfoOkonomiDetaljerKonsern : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? regnskapsAvArField;
        private int? regnskapsAvMndField;
        private long? totalinntektField;
        private long? salgsinntekterField;
        private long? annenDriftsinntektField;
        private long? varekostnadField;
        private long? beholdningsendringField;
        private long? lonnskostnadField;
        private long? avskrivningerField;
        private long? nedskrivningerField;
        private long? annenDriftskostnadField;
        private long? driftsResultatField;
        private long? inntektInvDatterField;
        private long? inntektInvKonsernField;
        private long? inntektInvAnnenField;
        private long? renteinntektKonsernField;
        private long? renteinntektAnnenField;
        private long? finansinntektAnnenField;
        private long? finansinntektField;
        private long? verdiendringMarFinOmlopsmidlerField;
        private long? nedskrivningMarFinOmlopsmidlerField;
        private long? nedskrivningFinAnleggsmidlerField;
        private long? rentekostnadKonsernField;
        private long? annenRentekostnadField;
        private long? annenFinanskostnadField;
        private long? finanskostnadField;
        private long? ordResultatForSkattField;
        private long? skattOrdResultatField;
        private long? ordResultatField;
        private long? ekstraordInntektField;
        private long? ekstraordKostnadField;
        private long? skattEkstraordResultatField;
        private long? sumSkattField;
        private long? minoritetsInteresserField;
        private long? arsResultatField;
        private long? konsernbidragField;
        private long? utbytteField;
        private long? tilFondVurdForField;
        private long? tilAnnenEgenkapitalField;
        private long? tapKravField;

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
        [JsonProperty("totalinntektField")]
        public long? TotalinntektField 
        { 
            get 
            {
                return this.totalinntektField; 
            } 
            set 
            {
                this.totalinntektField = value;
                onPropertyChanged("TotalinntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("salgsinntekterField")]
        public long? SalgsinntekterField 
        { 
            get 
            {
                return this.salgsinntekterField; 
            } 
            set 
            {
                this.salgsinntekterField = value;
                onPropertyChanged("SalgsinntekterField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenDriftsinntektField")]
        public long? AnnenDriftsinntektField 
        { 
            get 
            {
                return this.annenDriftsinntektField; 
            } 
            set 
            {
                this.annenDriftsinntektField = value;
                onPropertyChanged("AnnenDriftsinntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("varekostnadField")]
        public long? VarekostnadField 
        { 
            get 
            {
                return this.varekostnadField; 
            } 
            set 
            {
                this.varekostnadField = value;
                onPropertyChanged("VarekostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("beholdningsendringField")]
        public long? BeholdningsendringField 
        { 
            get 
            {
                return this.beholdningsendringField; 
            } 
            set 
            {
                this.beholdningsendringField = value;
                onPropertyChanged("BeholdningsendringField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lonnskostnadField")]
        public long? LonnskostnadField 
        { 
            get 
            {
                return this.lonnskostnadField; 
            } 
            set 
            {
                this.lonnskostnadField = value;
                onPropertyChanged("LonnskostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("avskrivningerField")]
        public long? AvskrivningerField 
        { 
            get 
            {
                return this.avskrivningerField; 
            } 
            set 
            {
                this.avskrivningerField = value;
                onPropertyChanged("AvskrivningerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nedskrivningerField")]
        public long? NedskrivningerField 
        { 
            get 
            {
                return this.nedskrivningerField; 
            } 
            set 
            {
                this.nedskrivningerField = value;
                onPropertyChanged("NedskrivningerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenDriftskostnadField")]
        public long? AnnenDriftskostnadField 
        { 
            get 
            {
                return this.annenDriftskostnadField; 
            } 
            set 
            {
                this.annenDriftskostnadField = value;
                onPropertyChanged("AnnenDriftskostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("driftsResultatField")]
        public long? DriftsResultatField 
        { 
            get 
            {
                return this.driftsResultatField; 
            } 
            set 
            {
                this.driftsResultatField = value;
                onPropertyChanged("DriftsResultatField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("inntektInvDatterField")]
        public long? InntektInvDatterField 
        { 
            get 
            {
                return this.inntektInvDatterField; 
            } 
            set 
            {
                this.inntektInvDatterField = value;
                onPropertyChanged("InntektInvDatterField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("inntektInvKonsernField")]
        public long? InntektInvKonsernField 
        { 
            get 
            {
                return this.inntektInvKonsernField; 
            } 
            set 
            {
                this.inntektInvKonsernField = value;
                onPropertyChanged("InntektInvKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("inntektInvAnnenField")]
        public long? InntektInvAnnenField 
        { 
            get 
            {
                return this.inntektInvAnnenField; 
            } 
            set 
            {
                this.inntektInvAnnenField = value;
                onPropertyChanged("InntektInvAnnenField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("renteinntektKonsernField")]
        public long? RenteinntektKonsernField 
        { 
            get 
            {
                return this.renteinntektKonsernField; 
            } 
            set 
            {
                this.renteinntektKonsernField = value;
                onPropertyChanged("RenteinntektKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("renteinntektAnnenField")]
        public long? RenteinntektAnnenField 
        { 
            get 
            {
                return this.renteinntektAnnenField; 
            } 
            set 
            {
                this.renteinntektAnnenField = value;
                onPropertyChanged("RenteinntektAnnenField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("finansinntektAnnenField")]
        public long? FinansinntektAnnenField 
        { 
            get 
            {
                return this.finansinntektAnnenField; 
            } 
            set 
            {
                this.finansinntektAnnenField = value;
                onPropertyChanged("FinansinntektAnnenField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("finansinntektField")]
        public long? FinansinntektField 
        { 
            get 
            {
                return this.finansinntektField; 
            } 
            set 
            {
                this.finansinntektField = value;
                onPropertyChanged("FinansinntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("verdiendringMarFinOmlopsmidlerField")]
        public long? VerdiendringMarFinOmlopsmidlerField 
        { 
            get 
            {
                return this.verdiendringMarFinOmlopsmidlerField; 
            } 
            set 
            {
                this.verdiendringMarFinOmlopsmidlerField = value;
                onPropertyChanged("VerdiendringMarFinOmlopsmidlerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nedskrivningMarFinOmlopsmidlerField")]
        public long? NedskrivningMarFinOmlopsmidlerField 
        { 
            get 
            {
                return this.nedskrivningMarFinOmlopsmidlerField; 
            } 
            set 
            {
                this.nedskrivningMarFinOmlopsmidlerField = value;
                onPropertyChanged("NedskrivningMarFinOmlopsmidlerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nedskrivningFinAnleggsmidlerField")]
        public long? NedskrivningFinAnleggsmidlerField 
        { 
            get 
            {
                return this.nedskrivningFinAnleggsmidlerField; 
            } 
            set 
            {
                this.nedskrivningFinAnleggsmidlerField = value;
                onPropertyChanged("NedskrivningFinAnleggsmidlerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("rentekostnadKonsernField")]
        public long? RentekostnadKonsernField 
        { 
            get 
            {
                return this.rentekostnadKonsernField; 
            } 
            set 
            {
                this.rentekostnadKonsernField = value;
                onPropertyChanged("RentekostnadKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenRentekostnadField")]
        public long? AnnenRentekostnadField 
        { 
            get 
            {
                return this.annenRentekostnadField; 
            } 
            set 
            {
                this.annenRentekostnadField = value;
                onPropertyChanged("AnnenRentekostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("annenFinanskostnadField")]
        public long? AnnenFinanskostnadField 
        { 
            get 
            {
                return this.annenFinanskostnadField; 
            } 
            set 
            {
                this.annenFinanskostnadField = value;
                onPropertyChanged("AnnenFinanskostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("finanskostnadField")]
        public long? FinanskostnadField 
        { 
            get 
            {
                return this.finanskostnadField; 
            } 
            set 
            {
                this.finanskostnadField = value;
                onPropertyChanged("FinanskostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ordResultatForSkattField")]
        public long? OrdResultatForSkattField 
        { 
            get 
            {
                return this.ordResultatForSkattField; 
            } 
            set 
            {
                this.ordResultatForSkattField = value;
                onPropertyChanged("OrdResultatForSkattField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skattOrdResultatField")]
        public long? SkattOrdResultatField 
        { 
            get 
            {
                return this.skattOrdResultatField; 
            } 
            set 
            {
                this.skattOrdResultatField = value;
                onPropertyChanged("SkattOrdResultatField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ordResultatField")]
        public long? OrdResultatField 
        { 
            get 
            {
                return this.ordResultatField; 
            } 
            set 
            {
                this.ordResultatField = value;
                onPropertyChanged("OrdResultatField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ekstraordInntektField")]
        public long? EkstraordInntektField 
        { 
            get 
            {
                return this.ekstraordInntektField; 
            } 
            set 
            {
                this.ekstraordInntektField = value;
                onPropertyChanged("EkstraordInntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ekstraordKostnadField")]
        public long? EkstraordKostnadField 
        { 
            get 
            {
                return this.ekstraordKostnadField; 
            } 
            set 
            {
                this.ekstraordKostnadField = value;
                onPropertyChanged("EkstraordKostnadField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skattEkstraordResultatField")]
        public long? SkattEkstraordResultatField 
        { 
            get 
            {
                return this.skattEkstraordResultatField; 
            } 
            set 
            {
                this.skattEkstraordResultatField = value;
                onPropertyChanged("SkattEkstraordResultatField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sumSkattField")]
        public long? SumSkattField 
        { 
            get 
            {
                return this.sumSkattField; 
            } 
            set 
            {
                this.sumSkattField = value;
                onPropertyChanged("SumSkattField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minoritetsInteresserField")]
        public long? MinoritetsInteresserField 
        { 
            get 
            {
                return this.minoritetsInteresserField; 
            } 
            set 
            {
                this.minoritetsInteresserField = value;
                onPropertyChanged("MinoritetsInteresserField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("arsResultatField")]
        public long? ArsResultatField 
        { 
            get 
            {
                return this.arsResultatField; 
            } 
            set 
            {
                this.arsResultatField = value;
                onPropertyChanged("ArsResultatField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("konsernbidragField")]
        public long? KonsernbidragField 
        { 
            get 
            {
                return this.konsernbidragField; 
            } 
            set 
            {
                this.konsernbidragField = value;
                onPropertyChanged("KonsernbidragField");
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
        [JsonProperty("tilFondVurdForField")]
        public long? TilFondVurdForField 
        { 
            get 
            {
                return this.tilFondVurdForField; 
            } 
            set 
            {
                this.tilFondVurdForField = value;
                onPropertyChanged("TilFondVurdForField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tilAnnenEgenkapitalField")]
        public long? TilAnnenEgenkapitalField 
        { 
            get 
            {
                return this.tilAnnenEgenkapitalField; 
            } 
            set 
            {
                this.tilAnnenEgenkapitalField = value;
                onPropertyChanged("TilAnnenEgenkapitalField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tapKravField")]
        public long? TapKravField 
        { 
            get 
            {
                return this.tapKravField; 
            } 
            set 
            {
                this.tapKravField = value;
                onPropertyChanged("TapKravField");
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