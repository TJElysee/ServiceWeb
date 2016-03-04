using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace WcfService1.EntitiesWS
{
   [DataContract]
   public class CaracteristiquesWS : EntityObjectWS
      {
         private EDefCaracteristiqueWS definition;
         private string nom;
         private ETypeCaracteristiqueWS type;
         private int valeur;
      [DataMember]
      public int Valeur
         {
            get
            {
               return valeur;
            }
            set
            {
               valeur = value;

            }
         }
      [DataMember]
      public string Nom
         {
            get
            {
               return nom;
            }
         }
         public CaracteristiquesWS(EDefCaracteristiqueWS definition, string nom, ETypeCaracteristiqueWS type, int valeur, int id) : base(id)
         {
            this.definition = definition;
            this.nom = nom;
            this.type = type;
            this.valeur = valeur;
         }

      public CaracteristiquesWS(Caracteristiques carac):base(carac.Id)
      {
         string temp;

         this.nom = carac.Nom;
         this.valeur = carac.Valeur;

         temp = carac.DefString();

         var caracs =  Enum.GetValues(typeof(EDefCaracteristiqueWS));
         foreach(EDefCaracteristiqueWS str in caracs)
         {
            if(str.ToString() == temp)
            {
               this.definition = str;
               break;
            }
               
         }

         temp = carac.TypeString();

         var types = Enum.GetValues(typeof(ETypeCaracteristiqueWS));
         foreach (ETypeCaracteristiqueWS str in types)
         {
            if (str.ToString() == temp)
            {
               this.type = str;
               break;
            }

         }

      }
   }
   
}