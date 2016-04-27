using AppSqlLiteXamarin;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSqlLiteXamarin
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection con;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            con = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "Empleado.db3"));
            con.CreateTable<Empleados>();
        }

        public void InsertEmpleado(Empleados empleado)
        {
            con.Insert(empleado);
        }

        public void UpdateEmpleado(Empleados empleado)
        {
            con.Update(empleado);
        }

        public void DeleteEmpleado(Empleados empleado)
        {
            con.Delete(empleado);
        }

        public Empleados GetEmpelado(int IDEmpleado)
        {
            return con.Table<Empleados>().FirstOrDefault(c => c.IDEmpleado == IDEmpleado);
        }

        public List<Empleados> GetEmpleados()
        {
            return con.Table<Empleados>().OrderBy(c => c.Apellidos).ToList();
        }
        public void Dispose()
        {
            con.Dispose();
        }
    }
}
