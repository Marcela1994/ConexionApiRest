using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassConexionDB;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select * from usuarios where account = '{0}' and password = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(cmd);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                
                if(cuenta == textBox1.Text.Trim() && password == textBox2.Text.Trim()) {
                    //MessageBox.Show("Conectado a la DB");
                    this.Hide();
                    Form2 f = new Form2();
                    f.ShowDialog();
                    
                }            
            }
            catch(Exception ex) {
                MessageBox.Show("No se realizo la conexion " + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
