using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TP3 : Form
    {
        public TP3()
        {
            InitializeComponent();
            

        }

        private void TP3Inicio_Load(object sender, EventArgs e)
        {
   

        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            int[] numerosGenerados = generar_numeros_aleatorios();
            Uniforme u = new Uniforme();
            u.Show();
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            int[] numerosGenerados = generar_numeros_aleatorios();
            Exponencial exp = new Exponencial();
            exp.Show();
        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            int[] numerosGenerados = generar_numeros_aleatorios();
            Poisson p = new Poisson();
            p.Show();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            int[] numerosGenerados = generar_numeros_aleatorios();
            Normal n = new Normal();
            n.Show();
        }

 

    public void btn_generar_Click(object sender, EventArgs e)
    {
        generar_numeros_aleatorios();
           
    }

    public int[] generar_numeros_aleatorios()
    {

        //Creo el objeto de la clase Random 
        Random RND = new Random();
        DataTable dt = new DataTable();
        int n;
        n = Convert.ToInt32(txt_numeros.Text);
        n = int.Parse(txt_numeros.Text);
        dt.Columns.Add("Numeros aleatorios generados");    

        //Creamos un array que va a contener cantidad aleatoria de numeros que ingresamos por el texbox
        int[] numeros = new int[n];

        //Recorremos el array y vamos asignando a cada posición un número aleatorio
        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = RND.Next(0, 100000);

        //Mostramos el arreglo con los numeros en pantalla
        for (int i = 0; i < numeros.Length; i++)
        {
            DataRow dr = dt.NewRow();
            dr["Numeros aleatorios generados"] = numeros[i];
            dt.Rows.Add(dr);
            
        }

        dgv_numeros.DataSource = dt;


        return numeros;
    
    }

    private void dgv_numeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
       
    }

    private void txt_numeros_TextChanged(object sender, EventArgs e)
    {

    }

    private void txt_media_TextChanged(object sender, EventArgs e)
    {
        double media = calcularMedia();
        string mensaje = Convert.ToString(media);
        //enseguida se muestra en el textbox esta variable
        txt_media.Text = mensaje;

       
    }

    public double calcularMedia()
    {
        int[] numerosGenerados = generar_numeros_aleatorios();
        int n;
        n = Convert.ToInt32(txt_numeros.Text);
        n = int.Parse(txt_numeros.Text);
        double media = 0;
        for (int i = 0; i < numerosGenerados.Length; i++)
        {
            double contar = i++;
            media = contar / n;

        }
        return media;

    }

    public double calcularLambda()
    {
        double media = calcularMedia();
        double lambda = 1 / media;
        return lambda;


    }

    private void txt_lambda_TextChanged(object sender, EventArgs e)
    {
        double lambda = calcularLambda();
        string mensaje = Convert.ToString(lambda);
        //enseguida se muestra en el textbox esta variable
        txt_media.Text = mensaje;


    }

     




    }
}
