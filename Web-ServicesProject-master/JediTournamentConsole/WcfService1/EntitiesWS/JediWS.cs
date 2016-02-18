using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace WcfService1.EntitiesWS
{
    [DataContract]
    public class JediWS : EntityObjectWS
    {
        private Caracteristiques[] caracteristiques;
        private bool isSith;
        private string nom;

        public Caracteristiques[] Carac
        {
            get
            {
                return caracteristiques;
            }
            set
            {
                this.Carac = value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public bool IsSith
        {
            get
            {
                return isSith;
            }
            set
            {
                this.isSith = value;
            }
        }
        public JediWS(Caracteristiques[] caracteristiques,bool isSith,string nom,int id):base(id)
        {
            this.caracteristiques = caracteristiques;
            this.isSith = isSith;
            this.nom = nom;
        }

        public JediWS(Jedi jedi):base(jedi.Id)
        {
            this.Nom = jedi.Nom;
            this.isSith = jedi.IsSith;
            this.Carac = jedi.Carac;
        }



        public override string ToString()
        {
            return nom;
        }
    }
}