using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationRole_NETCORE.Data
{
    public class MyContext : IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }
    }
}
