using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//usamos los namespaces necesarios
using System.Reflection;
using TiposPlugIn01;


namespace AplicacionConPlugins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarPlugInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos el cuadro de dialogo.
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (verificarCargaPlugin(openFileDialog1.FileName) == false)
                    MessageBox.Show("No es un plugin válido para la aplicación");
            }
        }

        private bool verificarCargaPlugin(string plugin)
        {
            bool encontrado = false;

            Assembly pluginAsm = null;

            //Obtener valores de la forma
            double a = Convert.ToDouble(txtParamA.Text);
            double b = Convert.ToDouble(txtParamB.Text);
            double r = 0.0;

            try {
                //Cargamos el assembly que contiene el plug-in
                pluginAsm = Assembly.LoadFrom(plugin);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return encontrado;
            }

            //Si todoo ha ido bien, tenemos que obtener las clases que implementarn la interfaz
            //IpliginMates que tienen los comportamientos.

            var clases = from t in pluginAsm.GetTypes()
                         where t.IsClass && (t.GetInterface("IPlugInMates") != null)
                         select t;

            //creamos el objeto de la instancias encontradas y hacemos la invocación al metodo Calcular
            foreach (Type t in clases)
            {
                encontrado = true;

                //Creamos instancia
                IPlugInMates objeto = (IPlugInMates)pluginAsm.CreateInstance(t.FullName, true);

                //Invocamos el método del plugin. Aquí es donde efectivamente se 
                //hace uso del plugin.
                r = objeto.Calcular(a, b);

                //actualizamos resultado
                lblResultado.Text = r.ToString();

                var pluginInfo = from ci in t.GetCustomAttributes(false)
                                 where (ci.GetType() == typeof(CInfoPlugIn))
                                 select ci;

                //Colocamos la información en el formulario
                foreach (CInfoPlugIn c in pluginInfo)
                {
                    lblInfo.Text = c.Creador + "," + c.Informacion;
                }
            }
            return encontrado;

        } 
    }
}
