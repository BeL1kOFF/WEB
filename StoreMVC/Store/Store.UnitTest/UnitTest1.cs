using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Abstract;
using Store.Domain.Entities;
//using Store.WebUI.Controllers;
using Store.WebUI.Models;

namespace Store.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {/*

            // Организация (arrange)
            Mock<IGameRepository> mock = new Mock<IGameRepository>();
            mock.Setup(m => m.Games).Returns(new List<Game>
    {
        new Game { GameId = 1, Name = "Игра1"},
        new Game { GameId = 2, Name = "Игра2"},
        new Game { GameId = 3, Name = "Игра3"},
        new Game { GameId = 4, Name = "Игра4"},
        new Game { GameId = 5, Name = "Игра5"}
    });
            GameController controller = new GameController(mock.Object);
            controller.pageSize = 3;

            // Действие (act)
            GamesListViewModel result = (GamesListViewModel)controller.List(2).Model;

            // Утверждение
            List<Game> games = result.Games.ToList();
            Assert.IsTrue(games.Count == 2);
            Assert.AreEqual(games[0].Name, "Игра4");
            Assert.AreEqual(games[1].Name, "Игра5");*/
        }

        [TestMethod]
        public void Can_Send_Pagination_View_Model()
        {
            /*
        // Организация (arrange)
        Mock<IGameRepository> mock = new Mock<IGameRepository>();
        mock.Setup(m => m.Games).Returns(new List<Game>
    {
        new Game { GameId = 1, Name = "Игра1"},
        new Game { GameId = 2, Name = "Игра2"},
        new Game { GameId = 3, Name = "Игра3"},
        new Game { GameId = 4, Name = "Игра4"},
        new Game { GameId = 5, Name = "Игра5"}
    });
        GameController controller = new GameController(mock.Object);
        controller.pageSize = 3;

        // Act
        GamesListViewModel result = (GamesListViewModel)controller.List(2).Model;

        // Assert
        PagingInfo pageInfo = result.PagingInfo;
        Assert.AreEqual(pageInfo.CurrentPage, 2);
        Assert.AreEqual(pageInfo.ItemsPerPage, 3);
        Assert.AreEqual(pageInfo.TotalItems, 5);
        Assert.AreEqual(pageInfo.TotalPages, 2);*/
        }
    }
}
