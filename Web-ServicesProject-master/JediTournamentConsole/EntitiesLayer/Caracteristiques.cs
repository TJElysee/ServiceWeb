using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Caracteristiques : EntityObject
    {
        private EDefCaracteristique definition;
        private string nom;
        private ETypeCaracteristique type;
        private int valeur;



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
        public string Nom
        {
            get
            {
                return nom;
            }
        }

      public EDefCaracteristique Definition
      {
         get
         {
            return definition;
         }

         set
         {
            definition = value;
         }
      }

      public ETypeCaracteristique Type
      {
         get
         {
            return type;
         }

         set
         {
            type = value;
         }
      }

      public string TypeString()
      {
         return type.ToString();
      }

      public string DefString()
      {
         return definition.ToString();
      }

      public Caracteristiques(EDefCaracteristique definition,string nom,ETypeCaracteristique type,int valeur ,int id):base(id)
        {
            this.Definition = definition;
            this.nom = nom;
            this.Type = type;
            this.valeur = valeur;
        }
    }
}
