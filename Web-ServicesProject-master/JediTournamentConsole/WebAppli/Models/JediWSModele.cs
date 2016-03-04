using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.EntitiesWS;

namespace WebAppli.Models
{
   public class JediWSModele
   {
      private JediWS jedi;

      public string Nom
      {
         get { return jedi.Nom; }
         set { jedi.Nom = value; }

      }

      public bool isSith
      {
         get { return jedi.IsSith; }
         set { jedi.IsSith = value; }
      }

      public CaracteristiquesWS[] Carac
      {
         get { return jedi.Carac; }
         set { jedi.Carac = value; }
      }
      
      public JediWSModele(JediWS jed)
      {
         jedi = jed;
      }
   }
}