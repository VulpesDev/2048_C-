using API_2048.Contexts;
using API_2048.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_2048.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighscoreDataController : ControllerBase
    {
        private HighscoreDataContext _context;

        public HighscoreDataController(HighscoreDataContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public IActionResult AddHighscore(string name, uint scoreVal)
        {
               Highscore newHighscore = new()
               {
                   PlayerName = name,
                   Score = scoreVal
               };
            _context.Highscores.Add(newHighscore);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("topten")]
        public ActionResult<List<Highscore>> topTenScores()
        {
            List<Highscore> topScores = _context.Highscores
                .OrderByDescending(h => h.Score)
                .Take(10)
                .ToList();
            return Ok(topScores);
        }

        [HttpGet("lastten")]
        public ActionResult<List<Highscore>> lastTenScores()
        {
            List<Highscore> lastScores = _context.Highscores
                .OrderByDescending(h => h.Timestamp)
                .Take(10)
                .ToList();
            return Ok(lastScores);
        }
    }
}