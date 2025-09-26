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
using System.Configuration;

namespace ListaClases
{
    public partial class Form1 : Form
    {
        public List<Persona> personas = new List<Persona>();  //creamos la lista Persona
        public int id;    //agregamos el id
       
     
        public Form1()
        {
            InitializeComponent();
            id = 0;                             //inicializamos el id en 0, la grilla cargada y la listBox vacía
            ActualizarGrilla(); 
            listBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "")    //No se pueden ingresar datos vacíos
            {
                Persona persona = new Persona();            //Creamos un nuevo objeto de tipo Persona
                persona.id = id;                                //Añadimos los atributos
                persona.nombre = txtNombre.Text;
                persona.apellido = txtApellido.Text;
                persona.edad = (int)numericUpDown1.Value;
                personas.Add(persona);                      //Agregamos la persona a la Lista que creamos globalmente
                id++;           //SUPER IMPORTANTE SUMAR EL ID PARA NO CARGAR IDENTIFICADORES REPETIDOS
                txtNombre.Text = string.Empty;          //dejamos en blanco las casillas
                txtApellido.Text = string.Empty;    
                numericUpDown1.Text = string.Empty;

                    //CREAMOS EL OBJETO CONNECTION PARA CONECTAR     nombre del servidor  , nombre de la base de datos     
                using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=personas;Integrated Security=True"))
                {           
                    //Guardamos en una variable String el comando a ejecutar en lenguaje SQL
                    string sql = $"insert into Persona (nombre,apellido,edad) Values ('{persona.nombre}','{persona.apellido}','{persona.edad}')";
                    SqlCommand cmd = new SqlCommand(sql, connection); //Crea el comando SQL y pasa como parametros la variable sql y el conector CONNECTION
                    connection.Open(); //abre el canal de comunicacion
                    cmd.ExecuteNonQuery();  //ejecuta la consulta SQL
                }

            }
            else
            {
                MessageBox.Show("Debe completar los campos!"); 
            }
                ActualizarGrilla();
        }
        public void ActualizarGrilla()
        {
            personas.Clear(); //Borramos todos los datos para volver a cargarlos
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=personas;Integrated Security=True")) 
            {
                string sql = "select * from Persona";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open() ;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona() {
                            id = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            apellido = reader.GetString(2),
                            edad = reader.GetInt32(3),
                        };
                        personas.Add(persona);
                    }
                }
            }
            dataGridView1.DataSource = null;                //CARGAMOS EL DATAGRID
            dataGridView1.DataSource = personas;            
            
        }

        public void cargarListBox()
        {
            listBox1.Text = string.Empty;
            foreach (Persona persona in personas)
            {
                listBox1.Items.Add(persona);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //CARGAMOS EL LISTBOX POR APELLIDO
            listBox1.Items.Clear();
            string ape = textBox1.Text.ToString();
            foreach (Persona persona in personas)
            {
                if (ape == persona.apellido)
                {
                    listBox1.Items.Add (persona);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

                                    //METODO PARA MODIFICAR LOS DATOS DE UNA PERSONA POR ID
            int IDSelec = int.Parse(txtId.Text);
            Persona personaSelec = new Persona();
            personaSelec.id = IDSelec;
            personaSelec.nombre = txtNombre.Text;
            personaSelec.apellido = txtApellido.Text;
            personaSelec.edad = (int)numericUpDown1.Value;

            using (SqlConnection connection = new SqlConnection("Data source=localhost; Initial Catalog=personas; Integrated Security =True"))
            {
                string sql = $@"update Persona SET
                    nombre = '{personaSelec.nombre}',
                    apellido = '{personaSelec.apellido}',
                    edad = '{personaSelec.edad}'
                    where id = '{personaSelec.id}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            ActualizarGrilla();                         //ACTAULIZAMOS LA GRILLA Y SETEAMOS EN EMPTY TODOS LAS CASILLAS
            MessageBox.Show("Modificación realizada");
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            numericUpDown1.Text = string.Empty;

        }

        private void button4_Click(object sender, EventArgs e)
        {   
                                //METODO PARA ELIMINAR A UNA PERSONA POR ID
            int idSelec = int.Parse(txtId.Text.ToString());
            using (SqlConnection connection = new SqlConnection("Data source=localhost; Initial Catalog=personas; Integrated Security =True"))
            {
                string sql = $"Delete from Persona where id = {idSelec}";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery ();
            }
            ActualizarGrilla ();                     //ACTAULIZAMOS LA GRILLA Y SETEAMOS EN EMPTY TODOS LAS CASILLAS
            txtId.Text = string.Empty;
            MessageBox.Show("Persona eliminada");
        }
    }


}
