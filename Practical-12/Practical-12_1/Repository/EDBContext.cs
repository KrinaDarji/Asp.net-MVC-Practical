using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeModel;
namespace Repository
{
    public class EDBContext : DbContext
    {
        public EDBContext() : base("EmployeeDBContext")
        {

        }
        public DbSet<EmployeeTable> EmployeeTables { get; set; }
    }
}
