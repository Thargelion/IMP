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
    public partial class Form1 : Form
    {
        private sumatra comandox;
        private string aimprimir;
        private string[] archivete;
        public Form1()
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
            archivete = files;
            System.Windows.Forms.MessageBox.Show("Hay " + files.Length.ToString() + " archivos PDF", "Message");
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Asignar(object sender, EventArgs e)
        {
            comandox = new sumatra(textBox1.Text);
            aimprimir = comandox.generarComando();
            if (textBox1.Text != null)
            {
                MessageBox.Show("Se va a imprimir la/las página/s " + textBox1.Text);
                button3.Enabled = true;
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
                foreach (string archivo in archivete)
                {
                    Process ejecucion = new Process();
                    ejecucion.StartInfo.UseShellExecute = false;
                    ejecucion.StartInfo.FileName = comandox.getUbicacion();
                    ejecucion.StartInfo.CreateNoWindow = true;
                    ejecucion.StartInfo.Arguments = aimprimir + " " + archivo;
                    ejecucion.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Info InfoAbrir = new Info();
            InfoAbrir.ShowDialog();
        }
    }
}
