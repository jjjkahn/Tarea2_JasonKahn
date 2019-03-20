using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    

    public partial class App : Form
    {
        Archivo AR = new Archivo();
        carro[] car = new carro[20];
        bool T = false;
        string saldo = "5000000";
        int contador = 0;
        char Transa;
        char Transmi;
        string mar;
        decimal valor;
        public App()
        {
                InitializeComponent();
                AR.crearArchivo();
                input_saldo.Text = AR.Copie_saldo_actual();          
        }
        


        private void input_marca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(input_marca.Text != null)
                mar = input_marca.Text;
                else
                {
                    MessageBox.Show("Debe completar la marca");
                }
            }catch(Exception R)
            {
                MessageBox.Show("Error "+R);
            }
            
        } 

        private void input_precio_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                decimal temp = decimal.Parse(input_precio.Text);
                T = true;
                if (T)
                {
                    valor = temp; 
                }
            }
            catch(Exception h)
            {               
                input_precio.Clear();                
            }                                            
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {

            if ((input_marca.Text != null) && (input_precio.Text != null) && (radio_Automatico.Checked == true || radio_Manual.Checked == true) && (radio_Venta.Checked == true || radio_Compra.Checked == true))
            {
               
                car[contador] = new carro(mar, Transmi, Transa, valor);
                
                AR.escribirArchivo(car[contador].Printcarro());
                contador++;

                decimal temp = decimal.Parse(saldo);
                if (radio_Compra.Checked)
                {
                    temp = temp - valor;
                }
                if (radio_Venta.Checked)
                {
                    temp = temp + valor;
                }
                saldo = temp.ToString();
                input_saldo.Text = saldo;
                AR.Chaging_saldo(saldo);
                
            }
            else
            {
                MessageBox.Show("Debes completar todos los espacios");
            }
            if (radio_Automatico.Checked)
            {
                radio_Automatico.Checked = false;
            }
            if (radio_Manual.Checked)
            {
                radio_Manual.Checked = false;
            }
            if (radio_Compra.Checked)
            {
                radio_Compra.Checked = false;
            }
            if (radio_Venta.Checked)
            {
                radio_Venta.Checked = false;
            }
            input_marca.Clear();
            input_precio.Clear();
           

            
        }

        private void input_saldo_TextChanged(object sender, EventArgs e)
        {
                     
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Text = AR.PrintArchivo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_Venta_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Venta.Checked)
            {
                Transa = 'V';
            }
        }

        private void radio_Compra_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Compra.Checked)
            {
                Transa = 'C';
            }
        }

        private void radio_Automatico_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Automatico.Checked)
            {
                Transmi = 'A';
            }
        }

        private void radio_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Manual.Checked)
            {
                Transmi = 'M';
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (radio_Automatico.Checked)
            {
                radio_Automatico.Checked = false;
            }
            if (radio_Manual.Checked)
            {
                radio_Manual.Checked = false;
            }
            if (radio_Compra.Checked)
            {
                radio_Compra.Checked = false;
            }
            if (radio_Venta.Checked)
            {
                radio_Venta.Checked = false;
            }
            input_marca.Clear();
            input_precio.Clear();
            richTextBox1.Clear();
        }

        private void btn_insertar_MouseHover(object sender, EventArgs e)
        {
            
            btn_insertar.Width = 150;
            btn_insertar.Height = 50;
        }

        private void btn_insertar_MouseLeave(object sender, EventArgs e)
        {
            btn_insertar.BackColor = Color.Azure;
            btn_insertar.Width = 99;
            btn_insertar.Height = 36;
        }



        //Funny details for the app
        public void arreglo()
        {
            string todo = AR.toda_info_archivo();
            string line,transaccion,valor;
            int Acontador = 0,Mcontador =0;
            
           
                    using (System.IO.StringReader reader = new System.IO.StringReader(todo))
            {
                
                while((line = reader.ReadLine())!= null)
                {
                    char[] cline = line.ToCharArray();
                    if('A' == cline[0] )
                    {
                        Acontador++;
                    }
                    if ('M' == cline[0])
                    {
                        Mcontador++;
                    }
                }

                string[] manuales = new string[Mcontador];
                string[] automaticos = new string[Acontador];
                Acontador = 0;
                Mcontador = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] cline = line.ToCharArray();
                    if ('A' == cline[0])
                    {
                        automaticos[Acontador] = line;
                        Acontador++;
                    }
                    if ('M' == cline[0])
                    {
                        manuales[Mcontador] = line;
                        Mcontador++;
                    }
                }



            }
        }

    }
}
