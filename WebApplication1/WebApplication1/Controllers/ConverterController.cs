using CoreHtmlToImage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConverterController : Controller
    {
        [HttpGet]
        public IActionResult Get(string htmlLink)
        {
            var converter = new HtmlConverter();
            // var html = "<div><strong>Hello</strong> World!</div>";
            // var bytes = converter.FromHtmlString(html);
            var bytes = converter.FromUrl(htmlLink);

            return File(bytes, "image/jpeg");
        }

        [HttpGet("html")]
        public IActionResult GetHTML()
        {
            var converter = new HtmlConverter();
            var html = "<div><strong>Hello</strong> World!</div>";
            var bytes = converter.FromHtmlString(html);
            //var bytes = converter.FromUrl(htmlLink);

            return File(bytes, "image/jpeg");
        }
    }
}
