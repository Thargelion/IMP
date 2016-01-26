using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class sumatra
    {
        public const string ubicacion = @"""C:\Program Files\SumatraPDF\SumatraPDF.exe""";
        public const string comando = " -print-to-default -print-settings ";
        public string total { get; set; }
        public sumatra(string cantidad)
        {
            this.total = cantidad;
        }
        public string getUbicacion()
        {
            return ubicacion;
        }

        public string generarComando()
        {
            return comando + this.total;
        }
    }
}
