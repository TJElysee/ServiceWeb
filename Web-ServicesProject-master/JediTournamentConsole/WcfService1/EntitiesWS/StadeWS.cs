using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace WcfService1.EntitiesWS
{
    [DataContract]
    public class StadeWS : EntityObjectWS
        {
            private Caracteristiques[] caracteristiques;

            public Caracteristiques[] Caracteristiques
            {
                get { return caracteristiques; }
                set { caracteristiques = value; }
            }
            private int nbPlace;
            private string planete;

            public string Planete
            {
                get
                {
                    return planete;
                }
                set
                {
                    planete = value;
                }
            }
            public int NbPlaces
            {
                get
                {
                    return nbPlace;
                }
                set
                {
                    nbPlace = value;
                }
            }
            public StadeWS(Caracteristiques[] caracteristiques, int nb, string plan, int identifiant)
                : base(identifiant)
            {
                this.caracteristiques = caracteristiques;
                nbPlace = nb;
                planete = plan;
            }

            public StadeWS(Stade stade)
                : base(stade.Id)
            {
                this.Caracteristiques = stade.Caracteristiques;
                this.NbPlaces = stade.NbPlaces;
                this.planete = stade.Planete;
            }

        }
    
}