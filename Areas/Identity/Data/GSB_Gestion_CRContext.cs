using GSB_Gestion_CR.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GSB_Gestion_CR.Data;

public class GSB_Gestion_CRContext : IdentityDbContext<GSB_Gestion_CRUser>
{
    public GSB_Gestion_CRContext(DbContextOptions<GSB_Gestion_CRContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
