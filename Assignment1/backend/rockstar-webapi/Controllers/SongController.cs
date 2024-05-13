using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace rockstar_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {

        private readonly ILogger<SongController> _logger;

        public SongController(ILogger<SongController> logger)
        {
            _logger = logger;
        }

        [HttpGet("song1")]
        public IActionResult GetSong1Lyrics()
        {
            var song1Lyrics = new SongLyrics
            {
                title = "Country Roads - John Denver",
                lyrics = "<div style=' font-family: monospace; white-space: pre;'>" +
                        "[Verse 1]<br>" + 
                        "Almost heaven, West Virginia<br>" +
                        "Blue Ridge Mountains, Shenandoah River<br>" +
                        "Life is old there, older than the trees<br>" +
                        "Younger than the mountains, blowing like a breeze<br>" +
                        "<br>" +
                        "[Chorus]<br>" +
                        "Country roads, take me home<br>" +
                        "To the place I belong<br>" +
                        "West Virginia, mountain mama<br>" +
                        "Take me home, country roads<br>" +
                        "<br>" +
                        "</div>"

            };
            return Ok(song1Lyrics);
        }

        [HttpGet("song2")]
        public IActionResult GetSong2Lyrics()
        {
            var song2Lyrics = new SongLyrics
            {
                title = "Tu - Vasu Raina",
                lyrics = "Tu<br>Bas ek tu..<br>Tune sikhaya" + 
                " mujhe<br>Hasna yu..<br><br>Hmm..<br>Tu<br>Han ek tu..<br>Tune sawara mujhe jab<br>Tha main tanha" +
                " yu..<br><br>Adhoora tha main har ghadi<br>Apne me hi<br>Karta tha main guftagu<br>Karte karte guftagu<br>Mila" +
                " tujhse hu<br>Kese kab kyu ye kya main kahu...<br><br>Ohh hoo wo<br>Tu hi hai<br>Jo mere sath chalta hai<br>Ohh" +
                " hoo wo<br>Tu hi hai, woo<br>Ohh hoo wo<br>Tu hi hai<br>Jo mere sath chalta hai<br>Ohh hooo<br>Tu hi hai, woo<br>"
       
            };
            return Ok(song2Lyrics);
        }

        [HttpGet("song3")]
        public IActionResult GetSong3Lyrics()
        {
            var song3Lyrics = new SongLyrics
            {
                title = "Illuminati - Sushin Shyam",
                lyrics = "<span>Naadin Nanmakane<br></span><span>Ponmakane Muthaayavane" +
                "<br></span><span>Minnum Sooriyanum <br></span><span>Chanthiranum Onnaayavane<br></span>" +
                "<span>Thaaraavum Neeravum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span><span>Thaazhvarayum" +
                " Thaazhvarayum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span>"

            };
            return Ok(song3Lyrics);
        }
    }
}
