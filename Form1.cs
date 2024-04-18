using Microsoft.VisualBasic;

namespace Vectores
{
    public partial class Form1 : Form
    {
        vector v1, v2, v3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new vector();
            v2 = new vector();
            v3 = new vector();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) <= int.Parse(textBox3.Text))
            {
                v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            }
            else
                textBox4.Text = "Error en rango";

        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargarFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarFib(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i, n1;
            v1 = new vector();
            n1 = int.Parse(Interaction.InputBox("N° de elementos"));
            for (i = 1; i <= n1; i++)
            {
                v1.Cargar(int.Parse(Interaction.InputBox("Elementos" + i + ":")));
            }
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.Media());
        }

        private void desvMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.DesvMed());
        }

        private void frecDeUnEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.FrecEle(int.Parse(textBox1.Text)));
        }

        private void frecDePrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.FrecPrim());
        }

        private void frecDeNoPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.FrecNPrim());
        }

        private void maximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.Maximo());
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox7.Text = v3.Descargar();
        }

        private void seleccionDeAprobYReprobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.SelecApRep(ref v2, ref v3);
        }

        private void busquedaSecuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.BuscSec(int.Parse(textBox1.Text)));
        }

        private void busquedaSecuencialAlMenosDe1PrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.BuscSecPrim());
        }

        private void busquedaSecuencialConPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.BuscSecP(int.Parse(textBox1.Text)));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v1.CargarSRep(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void ordenarDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerifOrdDesc());
        }

        private void ordenarDecendenteConRigorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerifOrdDescConRigor(int.Parse(textBox1.Text)));
        }

        private void verifIgaulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerifIgual());
        }

        private void ordenamientoXInterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdInter();
            textBox6.Text = v1.Descargar();
        }

        private void ordenamientoXInterDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdInterDesc();
            textBox6.Text = v1.Descargar();
        }

        private void ordXSeleccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdSelecc();
            textBox6.Text = v1.Descargar();
        }

        private void ordXConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdCont(ref v2);
            textBox6.Text = v2.Descargar();
        }
        private void ordBurbujaToolStripMenuItem Click(object sender, EventArgs e)
        {
           v1.OrdBurb();
           textBox6.Text = v1.Descargar();
        }
        private void ordBurbInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
           v1.OrdBurbInv():
           textBox6.Text = v1.Descargar();
        }
        private void ordInserToolStripMenuItem Click(object sender, EventArgs e)
        {
           v1.OrdxInsercion(ref V2);
           textBox6.Text = v2.Descargar();
        }
    }
}
