using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Areas.Identity.Data
{
    public class WebApp1User : IdentityUser
    {
       

    public string Name { get; set; }
    public DateTime DOB { get; set; }

    }

    public class WebApp1IdentityDbContext : IdentityDbContext<WebApp1User>
    {
        public WebApp1IdentityDbContext(DbContextOptions<WebApp1IdentityDbContext> options)
            : base(options)
        {
        }
    }
}