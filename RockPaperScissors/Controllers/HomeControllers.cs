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
      Game.ClearAll();
      return View();
    }

    [HttpGet("/playerone")]
    public ActionResult NewRound()
    {
      return View("PlayerOneTurn", Game.GetPlayerOne());
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
      List<Game> _games = Game.GetGames();
      Console.WriteLine("player2Play = "+ _games[1].GetPlayerPlay());
      string PlayerOneName = _games[0].GetPlayerName();
      string PlayerOnePlay = _games[0].GetPlayerPlay();
      string PlayerTwoName = _games[1].GetPlayerName();
      string PlayerTwoPlay = _games[1].GetPlayerPlay();
      List<Game> gamesList = Game.GetGames();
      Dictionary<string, string> myDictionary = new Dictionary<string, string>(){{"p1Name",PlayerOneName},{"p2Name",PlayerTwoName},{"p1Play",PlayerOnePlay},{"p2Play",PlayerTwoPlay},{"result",Game.ComparePlay()}};
      // string _result = Game.ComparePlay()+" ["+PlayerOneName+" chose "+PlayerOnePlay+"] ["+PlayerTwoName+" chose "+PlayerTwoPlay+"]";

      return View("GameResult", myDictionary);
    }
  }
}
