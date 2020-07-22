using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Floristeria2.Models
{
    class Tree
    {
        public string Nombre { get; set; }
        public string Altura { get; set; }
        public string Precio { get; set; }

        //Constructor

        public Tree(TextBox nombre, TextBox altura, TextBox precio)
        {
            this.Nombre = nombre.ToString();
            this.Altura = altura.ToString();
            this.Precio = precio.ToString();
        }
    }
}
