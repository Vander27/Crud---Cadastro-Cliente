using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Generics;
using Projeto.Repository.Context;

namespace Projeto.Repository.Persistence
{
    //criando as classes para  herdar o GenericRepository(crud)
   public class ClienteRepository : GenericRepository<Cliente>
   {
        

   }
}
