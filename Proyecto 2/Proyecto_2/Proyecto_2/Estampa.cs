using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    internal class Estampa
    {
        public string categoria;
        public string codigo;
        public int estado;

        public Estampa(string categoria, int numero)
        {
            this.categoria = categoria;
            this.codigo = categoria + numero;
            this.estado = 0;
        }
        
        public void marcar()
        {
            this.estado = 1;
        }

        public void repetir()
        {
            this.estado = 2;
        }

        public void faltar()
        {
            this.estado = 0;
        }

        public bool esMarcada()
        {
            return this.estado == 1;
        }

        public bool esRepetida()
        {
            return this.estado == 2;
        }

        public bool esFaltante()
        {
            return this.estado == 0;
        }
    }
}
