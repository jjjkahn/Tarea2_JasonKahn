using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    class Archivo
    {
        
        public Archivo()
        {

        }

        public void crearArchivo()
        {
            if (!File.Exists("sucarro.txt"))
            {
                TextWriter archivo;
                archivo = new StreamWriter("sucarro.txt");
                archivo.WriteLine("saldo;5000000");
                archivo.Close();          
            }
        }  
        public void escribirArchivo(string txt)
        {
            if (File.Exists("sucarro.txt"))
            {

                TextWriter archivo;
                archivo = new StreamWriter("sucarro.txt",true);
                archivo.WriteLine(txt);
                archivo.Close();

            }
        }

        public string PrintArchivo()
        {
            if (File.Exists("sucarro.txt"))
            {
                string x;
                TextReader archivo;
                archivo = new StreamReader("sucarro.txt", true);
                x = archivo.ReadToEnd();
                archivo.Close();
                return x;
            }
            else
            {
                return "El archivo no existe";
            }
        }
        public void Chaging_saldo(string saldo_actual)
        {
            if (File.Exists("sucarro.txt"))
            {
                string[] lines = File.ReadAllLines("sucarro.txt");
                string x;
                TextWriter archivo;
                archivo = new StreamWriter("sucarro.txt");
               
                x = "saldo;" + saldo_actual;
                lines[0] = x;
                for(int i = 0; i < lines.Length; i++)
                {
                    archivo.WriteLine(lines[i]);
                }
                archivo.Close();
                
            }
        }
        public string Copie_saldo_actual()
        {
            string saldo;
            if (File.Exists("sucarro.txt"))
            {
                TextReader archvio_lectura;
                archvio_lectura = new StreamReader("sucarro.txt");
                saldo = archvio_lectura.ReadLine();
                saldo = saldo.Substring(6);
                archvio_lectura.Close();
                return saldo;
            }
            else
            {
                return "No hay saldo";
            }

                
        }
        public string toda_info_archivo()
        {
            string Info = "";
            if (File.Exists("sucarro.txt"))
            {
                TextReader archvio_lectura;
                archvio_lectura = new StreamReader("sucarro.txt");
                
                Info = archvio_lectura.ReadToEnd();               
                archvio_lectura.Close();            
            }
            return Info;

        }


        
        
    }
}
