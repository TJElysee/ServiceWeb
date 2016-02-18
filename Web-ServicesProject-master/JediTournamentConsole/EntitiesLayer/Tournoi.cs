using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Tournoi : EntityObject
    {
        private Match matchs;

        public Match Matchs
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

        
        public Tournoi(Match matchs,string nom,int id):base(id)
        {
            this.matchs = matchs;
            this.nom = nom;
        }
    
    }
}
