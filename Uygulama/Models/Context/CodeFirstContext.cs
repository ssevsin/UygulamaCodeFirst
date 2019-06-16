using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Uygulama.Models.Entity;

namespace Uygulama.Models.Context
{
    public class CodeFirstContext :DbContext
    {

        static CodeFirstContext()
        {
            Database.SetInitializer<CodeFirstContext>(null);
        }

        public CodeFirstContext()
            : base("name=CodeFirstContext")
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}