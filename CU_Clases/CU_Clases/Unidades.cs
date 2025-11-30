using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Clases
{
    internal class Unidades
    {

        public int IdUnidad { get; set; }
        public string NombreUnidad { get; set; }
        public List<Conversion> Conversiones { get; set; }
    }
}
