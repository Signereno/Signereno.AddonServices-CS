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
    public class HentForetakResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private Identifikasjon identifikasjonField;
        private NavnAdresse navnAdresseField;
        private Rating ratingField;
        private List<HistoriskRating> histRatingField;
        private Grunnfakta grunnfaktaField;
        private List<Juridisk> juridiskField;
        private List<Verv> vervField;
        private List<Aksjonar> aksjonarField;
        private List<Datterselskap> datterselskapField;
        private List<OkonomiEnk> okonomiEnkField;
        private List<NokkeltallForetak> nokkeltallForetakField;
        private List<NokkeltallBransje> nokkeltallBransjeField;
        private List<NokkeltallKonsern> nokkeltallKonsernField;
        private BetaSammendrag betaSammendragField;
        private List<BetaDetaljer> betaDetaljerField;
        private List<Losore> losoreField;
        private EiendomNorge eiendomNorgeField;
        private List<KonsernLink> konsernLinkField;
        private Scoring scoringField;
        private List<OkonomiSammendragForetak> okonomiSammendragForetakField;
        private List<OkonomiSammendragKonsern> okonomiSammendragKonsernField;
        private List<OkonomiDetaljerForetak> okonomiDetaljerForetakField;
        private List<OkonomiDetaljerKonsern> okonomiDetaljerKonsernField;
        private List<EiendelerForetak> eiendelerForetakField;
        private List<EiendelerKonsern> eiendelerKonsernField;
        private List<GjeldEgenkapitalForetak> gjeldEgenkapitalForetakField;
        private List<GjeldEgenkapitalKonsern> gjeldEgenkapitalKonsernField;
        private AvdelingData avdelingDataField;
        private List<Rettighetshavere> rettighetshavereField;
        private List<EiendomNorgeListe> eiendomNorgeListeField;
        private List<FullmaktForetak> fullmaktForetakField;
        private List<Meldinger> meldingerField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("identifikasjonField")]
        public Identifikasjon IdentifikasjonField 
        { 
            get 
            {
                return this.identifikasjonField; 
            } 
            set 
            {
                this.identifikasjonField = value;
                onPropertyChanged("IdentifikasjonField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("navnAdresseField")]
        public NavnAdresse NavnAdresseField 
        { 
            get 
            {
                return this.navnAdresseField; 
            } 
            set 
            {
                this.navnAdresseField = value;
                onPropertyChanged("NavnAdresseField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ratingField")]
        public Rating RatingField 
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
        [JsonProperty("histRatingField")]
        public List<HistoriskRating> HistRatingField 
        { 
            get 
            {
                return this.histRatingField; 
            } 
            set 
            {
                this.histRatingField = value;
                onPropertyChanged("HistRatingField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("grunnfaktaField")]
        public Grunnfakta GrunnfaktaField 
        { 
            get 
            {
                return this.grunnfaktaField; 
            } 
            set 
            {
                this.grunnfaktaField = value;
                onPropertyChanged("GrunnfaktaField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("juridiskField")]
        public List<Juridisk> JuridiskField 
        { 
            get 
            {
                return this.juridiskField; 
            } 
            set 
            {
                this.juridiskField = value;
                onPropertyChanged("JuridiskField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vervField")]
        public List<Verv> VervField 
        { 
            get 
            {
                return this.vervField; 
            } 
            set 
            {
                this.vervField = value;
                onPropertyChanged("VervField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("aksjonarField")]
        public List<Aksjonar> AksjonarField 
        { 
            get 
            {
                return this.aksjonarField; 
            } 
            set 
            {
                this.aksjonarField = value;
                onPropertyChanged("AksjonarField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("datterselskapField")]
        public List<Datterselskap> DatterselskapField 
        { 
            get 
            {
                return this.datterselskapField; 
            } 
            set 
            {
                this.datterselskapField = value;
                onPropertyChanged("DatterselskapField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("okonomiEnkField")]
        public List<OkonomiEnk> OkonomiEnkField 
        { 
            get 
            {
                return this.okonomiEnkField; 
            } 
            set 
            {
                this.okonomiEnkField = value;
                onPropertyChanged("OkonomiEnkField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nokkeltallForetakField")]
        public List<NokkeltallForetak> NokkeltallForetakField 
        { 
            get 
            {
                return this.nokkeltallForetakField; 
            } 
            set 
            {
                this.nokkeltallForetakField = value;
                onPropertyChanged("NokkeltallForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nokkeltallBransjeField")]
        public List<NokkeltallBransje> NokkeltallBransjeField 
        { 
            get 
            {
                return this.nokkeltallBransjeField; 
            } 
            set 
            {
                this.nokkeltallBransjeField = value;
                onPropertyChanged("NokkeltallBransjeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nokkeltallKonsernField")]
        public List<NokkeltallKonsern> NokkeltallKonsernField 
        { 
            get 
            {
                return this.nokkeltallKonsernField; 
            } 
            set 
            {
                this.nokkeltallKonsernField = value;
                onPropertyChanged("NokkeltallKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaSammendragField")]
        public BetaSammendrag BetaSammendragField 
        { 
            get 
            {
                return this.betaSammendragField; 
            } 
            set 
            {
                this.betaSammendragField = value;
                onPropertyChanged("BetaSammendragField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaDetaljerField")]
        public List<BetaDetaljer> BetaDetaljerField 
        { 
            get 
            {
                return this.betaDetaljerField; 
            } 
            set 
            {
                this.betaDetaljerField = value;
                onPropertyChanged("BetaDetaljerField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("losoreField")]
        public List<Losore> LosoreField 
        { 
            get 
            {
                return this.losoreField; 
            } 
            set 
            {
                this.losoreField = value;
                onPropertyChanged("LosoreField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eiendomNorgeField")]
        public EiendomNorge EiendomNorgeField 
        { 
            get 
            {
                return this.eiendomNorgeField; 
            } 
            set 
            {
                this.eiendomNorgeField = value;
                onPropertyChanged("EiendomNorgeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("konsernLinkField")]
        public List<KonsernLink> KonsernLinkField 
        { 
            get 
            {
                return this.konsernLinkField; 
            } 
            set 
            {
                this.konsernLinkField = value;
                onPropertyChanged("KonsernLinkField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("scoringField")]
        public Scoring ScoringField 
        { 
            get 
            {
                return this.scoringField; 
            } 
            set 
            {
                this.scoringField = value;
                onPropertyChanged("ScoringField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("okonomiSammendragForetakField")]
        public List<OkonomiSammendragForetak> OkonomiSammendragForetakField 
        { 
            get 
            {
                return this.okonomiSammendragForetakField; 
            } 
            set 
            {
                this.okonomiSammendragForetakField = value;
                onPropertyChanged("OkonomiSammendragForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("okonomiSammendragKonsernField")]
        public List<OkonomiSammendragKonsern> OkonomiSammendragKonsernField 
        { 
            get 
            {
                return this.okonomiSammendragKonsernField; 
            } 
            set 
            {
                this.okonomiSammendragKonsernField = value;
                onPropertyChanged("OkonomiSammendragKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("okonomiDetaljerForetakField")]
        public List<OkonomiDetaljerForetak> OkonomiDetaljerForetakField 
        { 
            get 
            {
                return this.okonomiDetaljerForetakField; 
            } 
            set 
            {
                this.okonomiDetaljerForetakField = value;
                onPropertyChanged("OkonomiDetaljerForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("okonomiDetaljerKonsernField")]
        public List<OkonomiDetaljerKonsern> OkonomiDetaljerKonsernField 
        { 
            get 
            {
                return this.okonomiDetaljerKonsernField; 
            } 
            set 
            {
                this.okonomiDetaljerKonsernField = value;
                onPropertyChanged("OkonomiDetaljerKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eiendelerForetakField")]
        public List<EiendelerForetak> EiendelerForetakField 
        { 
            get 
            {
                return this.eiendelerForetakField; 
            } 
            set 
            {
                this.eiendelerForetakField = value;
                onPropertyChanged("EiendelerForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eiendelerKonsernField")]
        public List<EiendelerKonsern> EiendelerKonsernField 
        { 
            get 
            {
                return this.eiendelerKonsernField; 
            } 
            set 
            {
                this.eiendelerKonsernField = value;
                onPropertyChanged("EiendelerKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldEgenkapitalForetakField")]
        public List<GjeldEgenkapitalForetak> GjeldEgenkapitalForetakField 
        { 
            get 
            {
                return this.gjeldEgenkapitalForetakField; 
            } 
            set 
            {
                this.gjeldEgenkapitalForetakField = value;
                onPropertyChanged("GjeldEgenkapitalForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gjeldEgenkapitalKonsernField")]
        public List<GjeldEgenkapitalKonsern> GjeldEgenkapitalKonsernField 
        { 
            get 
            {
                return this.gjeldEgenkapitalKonsernField; 
            } 
            set 
            {
                this.gjeldEgenkapitalKonsernField = value;
                onPropertyChanged("GjeldEgenkapitalKonsernField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("avdelingDataField")]
        public AvdelingData AvdelingDataField 
        { 
            get 
            {
                return this.avdelingDataField; 
            } 
            set 
            {
                this.avdelingDataField = value;
                onPropertyChanged("AvdelingDataField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("rettighetshavereField")]
        public List<Rettighetshavere> RettighetshavereField 
        { 
            get 
            {
                return this.rettighetshavereField; 
            } 
            set 
            {
                this.rettighetshavereField = value;
                onPropertyChanged("RettighetshavereField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eiendomNorgeListeField")]
        public List<EiendomNorgeListe> EiendomNorgeListeField 
        { 
            get 
            {
                return this.eiendomNorgeListeField; 
            } 
            set 
            {
                this.eiendomNorgeListeField = value;
                onPropertyChanged("EiendomNorgeListeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktForetakField")]
        public List<FullmaktForetak> FullmaktForetakField 
        { 
            get 
            {
                return this.fullmaktForetakField; 
            } 
            set 
            {
                this.fullmaktForetakField = value;
                onPropertyChanged("FullmaktForetakField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("meldingerField")]
        public List<Meldinger> MeldingerField 
        { 
            get 
            {
                return this.meldingerField; 
            } 
            set 
            {
                this.meldingerField = value;
                onPropertyChanged("MeldingerField");
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