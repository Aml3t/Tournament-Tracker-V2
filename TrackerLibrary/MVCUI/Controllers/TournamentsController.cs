using MVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult Create()
        {
            TournamentMVCModel input = new TournamentMVCModel();
            
            List<TeamModel> allTeams = GlobalConfig.Connection.GetTeam_All();

            List<PrizeModel> allPrizes = GlobalConfig.Connection.GetPrizes_All();

            input.EnteredTeams = allTeams.Select(x => new SelectListItem { Text = x.TeamName, Value = x.Id.ToString() }).ToList();
            input.Prizes = allPrizes.Select(x => new SelectListItem { Text = x.PlaceName, Value = x.Id.ToString() }).ToList();


            return View(input);
        }

        // POST: Tournaments/Create
        [ValidateAntiForgeryToken()]
        [HttpPost]
        public ActionResult Create(TournamentModel p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO - Create the tournament
                    //GlobalConfig.Connection.CreateTournament(p);
                    
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}