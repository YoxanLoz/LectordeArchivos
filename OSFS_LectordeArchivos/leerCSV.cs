using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OSFS_LectordeArchivos
{
    class leerCSV
    {
        public List<Operaciones> obtenerRegistros()
        {
            List<Operaciones> lista = new List<Operaciones>();
            StreamReader A = new StreamReader("tamanos1(1).csv");
            string linea;
            while ((linea = A.ReadLine()) != null)
            {
                string[] valores = linea.Split(',');
                Operaciones Operaciones = new Operaciones();
                Operaciones.Op = valores[0];
                Operaciones.LOC = valores[1];
                lista.Add(Operaciones);
            }
            A.Close();
            A.Dispose();
            return lista;
        }
    }
}
