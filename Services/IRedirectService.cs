using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using UrlRedirector.Models;

namespace UrlRedirector.Services
{
    public interface IRedirectService
    {
            Task<URLRedirect[]> GetRedirectsForUserAsync(IdentityUser theUser);
            Task<bool> RedirectExists(string id);
            Task<bool> AddRedirectAsync(URLRedirect newItem);
            Task<URLRedirect> VisitRedirectAsync(string id);
    }
}
