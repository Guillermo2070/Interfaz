using Excursionistas.BaseDatos;
using Excursionistas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursionistas
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        // Prueba
        Entidad _Entidad = new Entidad();

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            IEnumerable<Elementos> ListaElementos = _Entidad.Elementos.ToList().OrderBy(x => x.Peso);

            List<ModeloElementos> Elementos = new List<ModeloElementos>();
            Elementos.Add(new ModeloElementos { Id = 1, Elemento = "E1", Peso = 5, Calorias = 3 });
            Elementos.Add(new ModeloElementos { Id = 2, Elemento = "E2", Peso = 3, Calorias = 5 });
            Elementos.Add(new ModeloElementos { Id = 3, Elemento = "E3", Peso = 5, Calorias = 2 });
            Elementos.Add(new ModeloElementos { Id = 4, Elemento = "E4", Peso = 1, Calorias = 8 });
            Elementos.Add(new ModeloElementos { Id = 5, Elemento = "E5", Peso = 2, Calorias = 3 });

            IEnumerable<ModeloElementos> ModeloElementos = Elementos.OrderBy(x => x.Peso);

            TbRespuesta.Text = ElementosIdeales(ModeloElementos);
        }

        private string ElementosIdeales(IEnumerable<ModeloElementos> Elementos)
        {
            int Peso = 0;
            int Calorias = 0;
            var Respuesta = "Elementos ideales: ";

            foreach (var item in Elementos)
            {
                int PesoActual = Convert.ToInt32(item.Peso);
                int CaloriaActual = Convert.ToInt32(item.Calorias);

                Peso += Convert.ToInt32(item.Peso);
                Calorias += Convert.ToInt32(item.Calorias);

                if (Convert.ToInt32(TbPeso.Text) >= Peso)
                {
                     Respuesta += item.Elemento + " ";
                }
                else
                {
                    if (Convert.ToInt32(TbCalorias.Text) >= Calorias)
                    {
                        Peso = Peso - PesoActual;
                        Calorias = Calorias - CaloriaActual;
                    }
                }
            }
            return Respuesta;
        }
    }
}
