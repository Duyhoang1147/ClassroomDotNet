using Classroom.Model.Model.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Classroom.Model.Model.DbContext
{
    public class IdentityAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public IdentityAppDbContext(DbContextOptions<IdentityAppDbContext> option) : base(option) { }
    }
}