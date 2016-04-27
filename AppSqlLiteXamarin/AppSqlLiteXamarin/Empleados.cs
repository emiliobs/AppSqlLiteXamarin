using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSqlLiteXamarin
{
  public  class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int IDEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaContrato { get; set; }
        public decimal Salario { get; set; }
        public bool Activo { get; set; }

        public string NombreCompleto
        {
            get{
                return ($"{this.Nombres} {this.Apellidos}");
            }
        }

        public string FechaContatoEdited
        {
            get
            {
                return ($"{FechaContrato}");
            }
        }

        public string SalarioEdited
        {
            get
            {
                return ($"0:C2{Salario}");      
            }     
        }

        public override string ToString()
        {
            return ($"{IDEmpleado} {NombreCompleto} {FechaContatoEdited} {SalarioEdited} {Activo}");
        }
    }
}
