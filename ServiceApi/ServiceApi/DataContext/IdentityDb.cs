using Microsoft.AspNet.Identity.EntityFramework;
using ServiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApi.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb() : base("LeiLocal", throwIfV1Schema: false)
        {
        }
        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}
