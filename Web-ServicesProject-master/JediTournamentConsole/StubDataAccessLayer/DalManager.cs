﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{

    
    public class DalManager
    {
        private List<Jedi> listJedi = new List<Jedi>();
        private List<Match> listMatch = new List<Match>();
        private List<Stade> listStade = new List<Stade>();
        private List<Caracteristiques> listCaracteristiques = new List<Caracteristiques>();
        private List<Utilisateur> listUtilisateur = new List<Utilisateur>();
        private List<Tournoi> listTournoi = new List<Tournoi>();
       
        public DalManager()
        {
           
            Caracteristiques Force1 = new Caracteristiques(EDefCaracteristique.Force,"Force",ETypeCaracteristique.Jedi,66,10);
            Caracteristiques Force2= new Caracteristiques(EDefCaracteristique.Force,"Force",ETypeCaracteristique.Jedi,42,11);

            Caracteristiques Defense1= new Caracteristiques(EDefCaracteristique.Defense,"Defense",ETypeCaracteristique.Jedi,66,12);
            Caracteristiques Defense2= new Caracteristiques(EDefCaracteristique.Defense,"Defense",ETypeCaracteristique.Jedi,42,13);

            Caracteristiques Vie1= new Caracteristiques(EDefCaracteristique.Sante,"Sante",ETypeCaracteristique.Jedi,66,14);
            Caracteristiques Vie2= new Caracteristiques(EDefCaracteristique.Sante,"Sante",ETypeCaracteristique.Jedi,42,15);

            Caracteristiques Chance1= new Caracteristiques(EDefCaracteristique.Chance,"Chance",ETypeCaracteristique.Jedi,66,16);
            Caracteristiques Chance2= new Caracteristiques(EDefCaracteristique.Chance,"Chance",ETypeCaracteristique.Jedi,42,17);

            Caracteristiques ForceStade= new Caracteristiques(EDefCaracteristique.Force,"Force",ETypeCaracteristique.Stade,66,18);
            Caracteristiques DefenseStade= new Caracteristiques(EDefCaracteristique.Defense,"Defense",ETypeCaracteristique.Stade,66,19);
            Caracteristiques VieStade= new Caracteristiques(EDefCaracteristique.Sante,"Sante",ETypeCaracteristique.Stade,66,20);
            Caracteristiques ChanceStade= new Caracteristiques(EDefCaracteristique.Chance,"Chance",ETypeCaracteristique.Stade,66,21);


            Caracteristiques[] Un = {Force1,Defense1,Vie1,Chance1};
            Caracteristiques[] Deux = {Force2,Defense2,Vie2,Chance2};
         Caracteristiques[] Trois = { Force1, Defense2, Vie1, Chance2 };
         Caracteristiques[] Quartre = { Force2, Defense1, Vie2, Chance1 };
         Caracteristiques[] Cinq = { Force1, Defense1, Vie2, Chance2 };
         Caracteristiques[] Six = { Force2, Defense2, Vie1, Chance1 };


         Caracteristiques[] Stade = {ForceStade,DefenseStade,VieStade,ChanceStade};

            Utilisateur Romain = new Utilisateur("Saulas", "Romain", "rosaulas", "saluasor",12314);
            Utilisateur Simon = new Utilisateur("Dujardin", "Simon", "admin", "admin", 12314);

            Jedi Yoda = new Jedi(Un,false,"Yoda",1);
            Jedi Palpatine = new Jedi(Deux,true,"Palpatine",2);
            Jedi JeanPierre = new Jedi(Un, true, "Jean-Pierre", 3);
            Jedi Luke = new Jedi(Quartre, false, "Luke", 4);
            Jedi Vader = new Jedi(Six, true, "Vader", 5);
            Jedi Rey = new Jedi(Un, false, "Rey", 6);
            Jedi Finn = new Jedi(Cinq, false, "Finn", 7);
            Jedi ObiWan = new Jedi(Deux, false, "ObiWan", 8);
            Jedi QuiGon = new Jedi(Quartre, false, "Qui Gon", 9);
            Jedi Kylo = new Jedi(Deux, true, "Kylo Ren", 10);
            Jedi Maul = new Jedi(Deux, true, "Maul", 11);
            Jedi Asajj = new Jedi(Trois, false, "Asajj", 12);
            Jedi Dooku = new Jedi(Deux, true, "Dooku", 13);
            Jedi JarJar = new Jedi(Trois, true, "Jar Jar", 14);
            Jedi Windu = new Jedi(Cinq, false, "Windu", 15);
            Jedi Grievous = new Jedi(Six, true, "Grievous", 16);

         Stade Tatouine = new Stade(Stade,50000,"Tatouine",3);

            Match Versus1 = new Match(1,Yoda,Palpatine,EPhaseTournoi.HuitiemeFinale,Tatouine,1);
            Match Versus2 = new Match(5, JeanPierre, JarJar, EPhaseTournoi.HuitiemeFinale, Tatouine, 2);
            Match Versus3 = new Match(1, Luke, Rey, EPhaseTournoi.HuitiemeFinale, Tatouine, 3);
            Match Versus4 = new Match(5, ObiWan, Vader, EPhaseTournoi.HuitiemeFinale, Tatouine, 4);
            Match Versus5 = new Match(1, Finn, Grievous, EPhaseTournoi.HuitiemeFinale, Tatouine, 5);
            Match Versus6 = new Match(5, Maul, QuiGon, EPhaseTournoi.HuitiemeFinale, Tatouine, 6);
            Match Versus7 = new Match(1, Windu, Kylo, EPhaseTournoi.HuitiemeFinale, Tatouine, 7);
            Match Versus8 = new Match(5, Dooku, Asajj, EPhaseTournoi.HuitiemeFinale, Tatouine, 8);

            Match Versus9 = new Match(1, JeanPierre, Palpatine, EPhaseTournoi.QuartFinale, Tatouine, 9);
            Match Versus10 = new Match(5, Rey, Vader, EPhaseTournoi.QuartFinale, Tatouine, 10);
            Match Versus11 = new Match(1, Finn, Maul, EPhaseTournoi.QuartFinale, Tatouine, 11);
            Match Versus12 = new Match(5, Kylo, Dooku, EPhaseTournoi.QuartFinale, Tatouine, 12);

            Match Versus13 = new Match(1, JeanPierre, Rey, EPhaseTournoi.DemiFinale, Tatouine, 13);
            Match Versus14 = new Match(5, Finn, Kylo, EPhaseTournoi.DemiFinale, Tatouine, 14);

            Match Versus15 = new Match(1, JeanPierre, Kylo, EPhaseTournoi.Finale, Tatouine, 15);

         listUtilisateur.Add(Romain);
            listUtilisateur.Add(Simon);
            
            listJedi.Add(Yoda);
            listJedi.Add(JeanPierre);
            listJedi.Add(Palpatine);
            listJedi.Add(Luke);
            listJedi.Add(Vader);
            listJedi.Add(Rey);
            listJedi.Add(Finn);
            listJedi.Add(ObiWan);
            listJedi.Add(QuiGon);
            listJedi.Add(Kylo);
            listJedi.Add(Maul);
            listJedi.Add(Asajj);
            listJedi.Add(Dooku);
            listJedi.Add(JarJar);
            listJedi.Add(Windu);
            listJedi.Add(Grievous);

            listMatch.Add(Versus1);
            listMatch.Add(Versus2);
            listMatch.Add(Versus3);
            listMatch.Add(Versus4);
            listMatch.Add(Versus5);
            listMatch.Add(Versus6);
            listMatch.Add(Versus7);
            listMatch.Add(Versus8);
         listMatch.Add(Versus9);
         listMatch.Add(Versus10);
         listMatch.Add(Versus11);
         listMatch.Add(Versus12);
         listMatch.Add(Versus13);
         listMatch.Add(Versus14);
         listMatch.Add(Versus15);

         listStade.Add(Tatouine);
            
            listCaracteristiques.Add(Force1);
            listCaracteristiques.Add(Force2);
            listCaracteristiques.Add(ForceStade);
            listCaracteristiques.Add(Defense1);
            listCaracteristiques.Add(Defense2);
            listCaracteristiques.Add(DefenseStade);
            listCaracteristiques.Add(Vie1);
            listCaracteristiques.Add(Vie2);
            listCaracteristiques.Add(VieStade);
            listCaracteristiques.Add(Chance1 );
            listCaracteristiques.Add(Chance2);
            listCaracteristiques.Add(ChanceStade);

        }


        public List<Tournoi> GetTournoi()
        {
            return listTournoi;
        }
        public List<Jedi> GetJedi()
        {
            return listJedi;
        }
        public List<Match> GetMatch()
        {
            return listMatch;
        }
        public List<Stade> GetStade() 
        {
            return listStade;
        }
        public List<Caracteristiques>   GetCaracteristiques()
        {
            return listCaracteristiques;
        }

        public Utilisateur GetUtilisateurByLogin(string log)
        {
            return listUtilisateur.Find(x => x.Login == log);
        }
    }
}
