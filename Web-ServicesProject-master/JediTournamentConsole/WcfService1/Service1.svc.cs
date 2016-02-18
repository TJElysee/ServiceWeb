using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

using WcfService1.EntitiesWS;
using EntitiesLayer;
using StubDataAccessLayer;

namespace WcfService1
{
    public class Service1 : IService1
    {
        private DalManager dalM = new DalManager();

        public List<JediWS> GetJediList(){
            List<Jedi> list =  dalM.GetJedi(); 
            List<JediWS> rlist = new List<JediWS>();
            foreach (Jedi jeds in list)
                rlist.Add(new JediWS(jeds));

            return rlist;
        }

        public List<StadeWS> GetStadeList(){
            List<Stade> list = dalM.GetStade();
            List<StadeWS> rlist = new List<StadeWS>();
            foreach (Stade stad in list)
                rlist.Add(new StadeWS(stad));

            return rlist;
        }

        public List<MatchWS> GetMatchList(){
            List<Match> list = dalM.GetMatch();
            List<MatchWS> rlist = new List<MatchWS>();
            foreach (Match mat in list)
                rlist.Add(new MatchWS(mat));
            return rlist;
        
        }

        public List<TournoiWS> GetTournamentList(){
            List<Tournoi> list = dalM.GetTournoi();
            List<TournoiWS> rlist = new List<TournoiWS>();
            foreach (Tournoi mat in list)
                rlist.Add(new TournoiWS(mat));
            return rlist;
        }


    }
        
}
