using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace WcfService1.EntitiesWS
{
        [DataContract]
    public class TournoiWS : EntityObjectWS
        {
            private MatchWS matchs;

            public MatchWS Matchs
            {
                get { return matchs; }
                set { matchs = value; }
            }
            private string nom;

            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }


            public TournoiWS(MatchWS matchs, string nom, int id)
                : base(id)
            {
                this.matchs = matchs;
                this.nom = nom;
            }

            public TournoiWS(Tournoi tournoi)
                : base(tournoi.Id)
            {
                this.Matchs = new MatchWS(tournoi.Matchs);
                this.Nom = tournoi.Nom;
            }

        }
    
}