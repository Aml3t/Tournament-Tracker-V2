﻿using MVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace MVCUI.Controllers
{
    public class TournamentsController : Controller
    {
        // GET: Tournaments
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {
            List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

            try
            {
                return View(tournaments.Where(x => x.Id == id).First());
            }
            catch 
            {

                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult Create()
        {
            TournamentMVCCreateModel input = new TournamentMVCCreateModel();
            
            List<TeamModel> allTeams = GlobalConfig.Connection.GetTeam_All();

            List<PrizeModel> allPrizes = GlobalConfig.Connection.GetPrizes_All();

            input.EnteredTeams = allTeams.Select(x => new SelectListItem { Text = x.TeamName, Value = x.Id.ToString() }).ToList();
            input.Prizes = allPrizes.Select(x => new SelectListItem { Text = x.PlaceName, Value = x.Id.ToString() }).ToList();


            return View(input);
        }

        // POST: Tournaments/Create
        [ValidateAntiForgeryToken()]
        [HttpPost]
        public ActionResult Create(TournamentMVCCreateModel model)
        {
            try
            {
                if (ModelState.IsValid && model.SelectedEnteredTeams.Count > 0)
                {
                    TournamentModel t = new TournamentModel();
                    t.TournamentName = model.TournamentName;
                    t.EntryFee = model.EntryFee;
                    t.EnteredTeams = model.SelectedEnteredTeams.Select(x => new TeamModel { Id = int.Parse(x) }).ToList();
                    t.Prizes = model.SelectedPrizes.Select(x => new PrizeModel { Id = int.Parse(x) }).ToList();

                    TournamentLogic.CreateRounds(t);

                    GlobalConfig.Connection.CreateTournament(t);

                    t.AlertUsersToNewRound();

                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}