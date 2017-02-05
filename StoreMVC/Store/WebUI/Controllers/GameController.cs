using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain.Abstract;
using Store.Domain.Entities;
using Store.WebUI.Models;
using WebUI.Models;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;
        public int pageSize = 4;

        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            MyViewModel model = new MyViewModel();
            return View(model);
        }
        public ViewResult GoToB(int Id)
        {
            MyViewModel model = new MyViewModel();
            model.GetB = model.GetBB(Id);
                       
            return View("MyPartial", model);
        }//()

        public ViewResult List(string category, int page = 1)
        {
            GamesListViewModel model = new GamesListViewModel
            {
                Games = repository.Games
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(game => game.GameId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                repository.Games.Count() :
                repository.Games.Where(game => game.Category == category).Count()
                },
                CurrentCategory = category
            };
            ViewBag.ForPartial = "For partial";
            return View(model);
        }
    }
}