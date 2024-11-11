using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevo_Proyecto
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e){
            Usuarios u1=new Usuarios();
            u1.usuario = textBox1.Text;
            u1.contraseña = textBox3.Text;
            u1.C_Contraseña = textBox4.Text;
            MessageBox.Show(u1.Registrado());
        }
    }
}
