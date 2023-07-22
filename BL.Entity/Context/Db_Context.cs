using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entity
{
  public  class Db_Context:DbContext
    {
        public Db_Context():base("AmlakDb")
        {

        }
        public DbSet<Melk_Kh_Ap> MelkKhAp { get; set; }
    }
}
