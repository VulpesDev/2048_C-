using API_2048.Contexts;
using API_2048.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API_2048.Models;

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
        public IActionResult AddHighscore(HighscoreInputModel model)
        {
            Console.WriteLine($"Received request: PlayerName={model.PlayerName}, ScoreStr={model.ScoreStr}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (uint.TryParse(model.ScoreStr, out uint score) == false)
            {
                score = 0;
            }
               Highscore newHighscore = new()
               {
                   PlayerName = model.PlayerName,
                   Score = score
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
            if (lastTenScores == null)
                return NotFound();
            return Ok(topScores);
        }

        [HttpGet("lastten")]
        public ActionResult<List<Highscore>> lastTenScores()
        {
            List<Highscore> lastScores = _context.Highscores
                .OrderByDescending(h => h.Timestamp)
                .Take(10)
                .ToList();
            if (lastTenScores == null)
                return NotFound();
            return Ok(lastScores);
        }

        [HttpGet("toptoday")]
        public ActionResult<Highscore> TopScoreToday()
        {
            TimeSpan localOffset = TimeSpan.FromHours(-3);

            DateTime localToday = DateTime.Today.Add(localOffset);
            DateTime localTomorrow = localToday.AddDays(1);

            DateTime utcToday = localToday.ToUniversalTime();
            DateTime utcTomorrow = localTomorrow.ToUniversalTime();

            var topScoreToday = _context.Highscores
                .Where(h => h.Timestamp >= utcToday && h.Timestamp < utcTomorrow)
                .OrderByDescending(h => h.Score)
                .FirstOrDefault();

            if (topScoreToday == null)
            {
                return NotFound();
            }

            return Ok(topScoreToday);
        }
    }
}