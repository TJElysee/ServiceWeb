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
        private CaracteristiquesWS[] caracteristiques;
        private bool isSith;
        private string nom;

      [DataMember]
      public CaracteristiquesWS[] Carac
        {
            get
            {
                return caracteristiques;
            }
            set
            {
                this.caracteristiques = value;
            }
        }

      [DataMember]
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

      [DataMember]
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
         List<CaracteristiquesWS> car = new List<CaracteristiquesWS>();
         foreach (Caracteristiques carac in caracteristiques)
         {
            car.Add(new CaracteristiquesWS(carac));
         }
            
            this.caracteristiques = car.ToArray();
            this.isSith = isSith;
            this.nom = nom;
        }

      public JediWS(Jedi jedi):base(jedi.Id)
        {
            this.Nom = jedi.Nom;
            this.isSith = jedi.IsSith;

         List<CaracteristiquesWS> car = new List<CaracteristiquesWS>();
         foreach (Caracteristiques carac in jedi.Carac)
         {
            car.Add(new CaracteristiquesWS(carac));   
         }
         this.Carac = car.ToArray();
      }
      public override string ToString()
        {
            return nom;
        }
    }
}