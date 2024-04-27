﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);

        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);

        void CompleteTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<TournamentModel> GetTournament_All();
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
    }
}
