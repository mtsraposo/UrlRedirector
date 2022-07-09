using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRedirector.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using UrlRedirector.Services;

namespace UrlRedirector.Controllers
{
    [Route("r")]
    public class RedirectController : Controller
    {
        private readonly IRedirectService _redirectService;
        public RedirectController(IRedirectService redirectService)
        {
            _redirectService = redirectService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> DoRedirect(string id){
            var redirect = await _redirectService.VisitRedirectAsync(id);
            return new RedirectResult(redirect.DestinationUrl,false);
        }

    }
}
