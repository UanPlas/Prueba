using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        int modo = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mia_storesDataSet1.productosN' Puede moverla o quitarla según sea necesario.
            this.productosNTableAdapter.Fill(this.mia_storesDataSet1.productosN);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            modo = 0;
            textBoxName.ReadOnly = false;
            textBoxID.ReadOnly = true;
            buttonConfirm.Enabled = true ;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case 0: 
                    
                    this.productosNTableAdapter.InsertProductN(textBoxName.Text);
                    textBoxName.ReadOnly = true;
                    textBoxID.ReadOnly = true;
                    limpiar();
                    buttonConfirm.Enabled = false;
                    MessageBox.Show("Nuevo producto agregado con éxito");

                    break; 
                case 1: 
                    
                    this.productosNTableAdapter.UpdateProductN(textBoxName.Text, int.Parse(textBoxID.Text));
                    textBoxName.ReadOnly = true;
                    textBoxID.ReadOnly = true;
                    limpiar();
                    buttonConfirm.Enabled = false;
                    MessageBox.Show("Producto actualizado con éxito");
                    break;

                case 2: 
                    
                    this.productosNTableAdapter.DeleteProductN(int.Parse(textBoxID.Text)); limpiar();
                    textBoxName.ReadOnly = true;
                    textBoxID.ReadOnly = true;
                    limpiar();
                    buttonConfirm.Enabled = false;
                    MessageBox.Show("Producto eliminado con éxito");
                    break;
                default: MessageBox.Show("No disponible"); break;

            }
            this.productosNTableAdapter.Fill(this.mia_storesDataSet1.productosN);

            dataGridView1.Update();
            dataGridView1.Refresh(); 
        }
        private void limpiar()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
        }




        private void buttonDelete_Click_(object sender, EventArgs e)
        {
            modo = 2;
            limpiar();
            textBoxID.ReadOnly = false;
            textBoxName.ReadOnly = true;
            buttonConfirm.Enabled = true;
        }

        private void buttonUpdate_Click_(object sender, EventArgs e)
        {
            modo = 1;
            limpiar();
            textBoxName.ReadOnly = false;
            textBoxID.ReadOnly = false;
            buttonConfirm.Enabled = true;
        }
    }
}
