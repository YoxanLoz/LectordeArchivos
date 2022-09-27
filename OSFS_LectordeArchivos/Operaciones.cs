using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSFS_LectordeArchivos
{
    class Operaciones
    {
        public String Op { get; set; }
        public String LOC { get; set; }

        public override string ToString()
        {
            return Op + "," + LOC;
        }

    }
}
