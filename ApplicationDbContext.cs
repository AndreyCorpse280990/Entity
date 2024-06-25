using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class ApplicationDbContext : DbContext
    {
        // укажем маппинг таблицы студентов для работы с бд 
        public DbSet<ChemicalElements> ChemicalElements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"
                    Data Source=HOME-PC\SQLEXPRESS;
                    Initial Catalog=ChemicalElementsPV324_db;
                    Timeout=5;
                    Integrated Security=SSPI;
                    TrustServerCertificate=Yes";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
