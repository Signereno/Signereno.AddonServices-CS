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
    public class PersonHentPersonResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private PersonIdentifikasjon identifikasjonField;
        private PersonNavnAdresse navnAdresseField;
        private PersonScoring scoringField;
        private List<PersonDelomrader> delomraderField;
        private PersonBetaSammendrag betaSammendragField;
        private List<PersonBetaDetaljer> betaDetaljerField;
        private List<PersonLigning> ligningField;
        private List<PersonDisponibelInntekt> disponibelInntektField;
        private List<PersonNaringsInteresser> naringsInteresserField;
        private PersonEiendomNorge eiendomNorgeField;
        private List<PersonEiendomListe> eiendomListeField;
        private List<PersonLosore> losoreField;
        private List<PersonTidligereNavnAdresse> tidligereNavnAdresseField;
        private List<PersonFullmaktForetak> fullmaktForetakField;
        private List<PersonMeldinger> meldingerField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("identifikasjonField")]
        public PersonIdentifikasjon IdentifikasjonField 
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
        public PersonNavnAdresse NavnAdresseField 
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
        [JsonProperty("scoringField")]
        public PersonScoring ScoringField 
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
        [JsonProperty("delomraderField")]
        public List<PersonDelomrader> DelomraderField 
        { 
            get 
            {
                return this.delomraderField; 
            } 
            set 
            {
                this.delomraderField = value;
                onPropertyChanged("DelomraderField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("betaSammendragField")]
        public PersonBetaSammendrag BetaSammendragField 
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
        public List<PersonBetaDetaljer> BetaDetaljerField 
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
        [JsonProperty("ligningField")]
        public List<PersonLigning> LigningField 
        { 
            get 
            {
                return this.ligningField; 
            } 
            set 
            {
                this.ligningField = value;
                onPropertyChanged("LigningField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("disponibelInntektField")]
        public List<PersonDisponibelInntekt> DisponibelInntektField 
        { 
            get 
            {
                return this.disponibelInntektField; 
            } 
            set 
            {
                this.disponibelInntektField = value;
                onPropertyChanged("DisponibelInntektField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("naringsInteresserField")]
        public List<PersonNaringsInteresser> NaringsInteresserField 
        { 
            get 
            {
                return this.naringsInteresserField; 
            } 
            set 
            {
                this.naringsInteresserField = value;
                onPropertyChanged("NaringsInteresserField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("eiendomNorgeField")]
        public PersonEiendomNorge EiendomNorgeField 
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
        [JsonProperty("eiendomListeField")]
        public List<PersonEiendomListe> EiendomListeField 
        { 
            get 
            {
                return this.eiendomListeField; 
            } 
            set 
            {
                this.eiendomListeField = value;
                onPropertyChanged("EiendomListeField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("losoreField")]
        public List<PersonLosore> LosoreField 
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
        [JsonProperty("tidligereNavnAdresseField")]
        public List<PersonTidligereNavnAdresse> TidligereNavnAdresseField 
        { 
            get 
            {
                return this.tidligereNavnAdresseField; 
            } 
            set 
            {
                this.tidligereNavnAdresseField = value;
                onPropertyChanged("TidligereNavnAdresseField");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fullmaktForetakField")]
        public List<PersonFullmaktForetak> FullmaktForetakField 
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
        public List<PersonMeldinger> MeldingerField 
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