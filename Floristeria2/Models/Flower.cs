using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Floristeria2.Models
{
    class Flower
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Precio { get; set; }

        //Constructor
        public Flower (TextBox nombre, TextBox color, TextBox precio)
        {
            this.Nombre = nombre.ToString();
            this.Color = color.ToString();
            this.Precio = precio.ToString();
        }
    }
}
