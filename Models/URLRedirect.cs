using System;
using System.ComponentModel.DataAnnotations;
namespace UrlRedirector.Models
{
    public class URLRedirect
    {
        [Key]
        public string Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string DestinationUrl { get; set; }
        public long NumVisits { get; set; }
    }
}
