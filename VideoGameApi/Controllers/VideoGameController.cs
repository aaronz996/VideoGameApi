using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "Spider-man 2",
                Platform = "Ps5",
                Developer = "Insomaniac Games",
                Publisher = "Sony Interactive Entertainment"
            },

            new VideoGame {
                Id = 2,
                Title = "Crysis",
                Platform = "xBox",
                Developer = "Critech",
                Publisher = "Nano Technology"

            },

            new VideoGame {
                Id = 3,
                Title = "WatchDogs",
                Platform = "PC",
                Developer = "Naughty Dog",
                Publisher = "Rockstar"

            }

        };

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet ("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            
            if(game is null)
            {
                return NotFound();
            }
            return Ok(game);
        }


        [HttpPost]
        public ActionResult<VideoGame> AddVideoGame(VideoGame newGame)
        {
            if (newGame is null)
            {
                return BadRequest();
            }

            else
            {
                newGame.Id = videoGames.Max(x => x.Id) + 1;
                videoGames.Add(newGame);
                return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
            }
        }

        [HttpPut("{id}")]

        public IActionResult UpdateVideoGame (int id, VideoGame updatedGame)
        {
            var game = videoGames.FirstOrDefault (x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }
            
            else
            {
               game.Title = updatedGame.Title;
               game.Platform = updatedGame.Platform;
               game.Developer = updatedGame.Developer;
               game.Publisher = updatedGame.Publisher;

            }

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteVideoGame(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }

            else
            {
                videoGames.Remove(game);
            }

            return NoContent();
        }



    }
}
