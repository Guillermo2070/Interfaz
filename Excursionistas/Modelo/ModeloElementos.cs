using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursionistas.Modelo
{
    public class ModeloElementos
    {
        public int Id { get; set; }
        public string Elemento { get; set; }
        public Nullable<int> Peso { get; set; }
        public Nullable<int> Calorias { get; set; }
    }
}
