using Microsoft.EntityFrameworkCore;
using StoredProcedureLanguage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProcedureLanguage.Data
{
    public class StoredProcedureDBContext : DbContext
    {
        public StoredProcedureDBContext(DbContextOptions<StoredProcedureDBContext> options) : base(options) { }

        public DbSet<Language> Language { get; set; }
    }
}
