using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class sumatra
    {
        private string ejecutable;
        public string[] archivosAImprimir;
        public const string comando = " -print-to-default -print-settings ";
        public string total;
        public void setTotal(string cantidad)
        {
            total = cantidad;
        }

        public void setUbicacion(string[] archivo)
        {

        }

        public string generarComando()
        {
            return comando + total + " ";
        }

        public void setEjecutable()
        {
            ejecutable = abrir();
        }

        public string getEjecutable()
        {
            return ejecutable;
        }

        public string abrir()
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                string[] files = System.IO.Directory.GetFiles(fbd.SelectedPath, "sumatrapdf.exe");
                return files[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
