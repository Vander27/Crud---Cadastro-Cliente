using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using Projeto.Repository.Mappings;
using Projeto.Entities;

namespace Projeto.Repository.Context
{
    //Regra 1) Esta classe deverá Herdar 'DbContext'..
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }
        //sobrescrita do método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
 
        }

        public DbSet<Cliente> Cliente { get; set; }
        
    }
}
