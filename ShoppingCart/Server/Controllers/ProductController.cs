using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
            new Product
            {
                Id = 1,
                Title = "Chromatica",
                Description = "Chromatica is the sixth studio album by American singer Lady Gaga, released on May 29, 2020, by Interscope Records and subsidiary Streamline.",
                ImageURL = "https://duckduckgo.com/i/4039f234.png",
                Price = 9.99m

            },

             new Product
            {
                Id = 2,
                Title = "Zeit",
                Description = "Zeit is the eighth studio album by German Neue Deutsche Härte band Rammstein, released on 29 April 2022 through Universal Music.",
                ImageURL = "https://duckduckgo.com/i/fb3c23cc.png",
                Price = 9.99m

            },

             new Product
            {
                Id = 3,
                Title = "Alive 2007",
                Description = "Alive 2007 is the second live album by the French electronic music duo Daft Punk, released on 19 November 2007 by Virgin Records.",
                ImageURL = "https://duckduckgo.com/i/af5f1f5b.jpg",
                Price = 7.99m

            },

             new Product
            {
                Id = 4,
                Title = "Black Market Music",
                Description = "Black Market Music is the third studio album by English alternative rock band Placebo. The album took nine months to record, from late-1999 to mid-2000;",
                ImageURL = "https://duckduckgo.com/i/663edfbf.jpg",
                Price = 9.99m

            }
        };

        [HttpGet]  
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
