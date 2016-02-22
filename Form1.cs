using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VentanaPrincipal : Form
    {
        sumatra comandox = new sumatra();
        private string aimprimir;
        public VentanaPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BOTON ABRIR CARPETA
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string[] files = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.pdf");
            comandox.archivosAImprimir = files;
            System.Windows.Forms.MessageBox.Show("Hay " + files.Length.ToString() + " archivos PDF", "Message");            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Asignar(object sender, EventArgs e)
        {
            comandox.setTotal(hojas.Text);
            aimprimir = comandox.generarComando();
            if (hojas.Text != null)
            {
                MessageBox.Show("Se va a imprimir la/las página/s " + hojas.Text);
                start.Enabled = true;
            }
            else
            {
                MessageBox.Show("Elija una págna para poder imprimir");
            }
        }

        private void button3_Click(object sender, EventArgs o)
        {
            try
            {
                foreach (string archivo in comandox.archivosAImprimir)
                {
                    Process ejecucion = new Process();
                    ejecucion.StartInfo.UseShellExecute = false;
                    ejecucion.StartInfo.FileName = @"""" + comandox.getEjecutable() + @"""";
                    ejecucion.StartInfo.CreateNoWindow = true;
                    ejecucion.StartInfo.Arguments = aimprimir + archivo;
                    ejecucion.Start();
                    MessageBox.Show(@"""" + comandox.getEjecutable() + @"""" + aimprimir + archivo);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
        }

        //VENTANA DE INFO
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Info InfoAbrir = new Info();
            InfoAbrir.ShowDialog();
        }

        //VENTANA SETUP EN DESUSO
        private void setup(object sender, EventArgs e)
        {
            config ConfigAbrir = new config();
            ConfigAbrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comandox.setEjecutable();
        }
    }
}
