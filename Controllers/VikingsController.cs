using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VikingApp.Controllers
{
    [Route("api/[controller]")]
    public class VikingsController : Controller
    {
        private static string[] Names = new[]
        {
            "Ragner", "Floki", "Bjorn", "Ivar", "Harald", "Karl", "Brut", "Mikkael", "Skars", "Fors"
        };

        [HttpGet("[action]")]
        public IEnumerable<Viking> NewVikings()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Viking
            {
                Title = "",
                Name = Names[rng.Next(Names.Length)] + " " + Names[new Random().Next(Names.Length) + "son",
                Nation = "Denmark",
                Raids = 0
            });
        }

        public class Viking
        {
            public string Title { get; set; }
            public string Name { get; set; }
            public string Nation { get; set; }
            public int Raids { get; set; }
        }
    }
}
