using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }


    [HttpPost("/playerone")]
    public ActionResult PlayerOneTurn()
    {
      Game Player1 = new Game(Request.Form["Player1Name"]);
      Game Player2 = new Game(Request.Form["Player2Name"]);

      return View(Game.GetPlayerOne());
    }

    [HttpPost("/playertwo")]
    public ActionResult PlayerTwoTurn()
    {
      Game.SetPlayerOnePlay(Request.Form["player1Play"]);
      List<Game> _games = Game.GetGames();
      Console.WriteLine("player1Play = "+_games[0].GetPlayerPlay());
      return View(Game.GetPlayerTwo());
    }
    [HttpPost("/result")]
    public ActionResult GameResult()
    {
      Game.SetPlayerTwoPlay(Request.Form["player2Play"]);
      Console.WriteLine("player2Play = "+_games[1].GetPlayerPlay());
      List<Game> gamesList = Game.GetGames();
      return View(gamesList);
    }
  }
}
