using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Lab_ptszona.Clases
{
    internal class Empleado
    {
       
        
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public int Edad { get; set; }
            public string Cargo { get; set; }

            public double Sueldo {get; set;}


            public Empleado(int id, string nombre, string apellido, int edad, string cargo, double sueldo)
            {
                Id = id;
                Nombre = nombre;
                this.Apellido = apellido;
                Edad = edad;
                Cargo = cargo;
                Sueldo = sueldo;
            }
            public override string ToString()
            {
                return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo} Sueldo: {Sueldo}";
            }
        


    }
}
