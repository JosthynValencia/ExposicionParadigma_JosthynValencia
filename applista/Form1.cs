using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applista
{
    public partial class Form1 : Form
    {
        private List<clases.Empleados > Lista = new List<clases.Empleados >();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLISTA_Click(object sender, EventArgs e)
        {
            clases.Empleados empleado = new clases.Empleados();
            empleado.NombreCompleto = this.txtNOMBRE.Text;
            empleado.Genero = this.comboGENERO.Text;
            empleado.Estadocivil = this.comboESTADOCIVIL.Text;
            empleado.edad = this.txtEDAD.Text;

            Lista.Add(empleado);
            //mostrar los empleados en la listview
            ListViewItem item = new ListViewItem(empleado.NombreCompleto );
            listViewEMPLEADOS.Items.Add(item);
            item.SubItems.Add(empleado.Genero);
            item.SubItems.Add(empleado.Estadocivil);
            item.SubItems.Add(empleado.edad);


        }
    }
}
