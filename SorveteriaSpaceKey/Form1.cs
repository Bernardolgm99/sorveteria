using System;
using System.Windows.Forms;

namespace SorveteriaSpaceKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tipo = "";
            rdbCasquinha.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VerificarTipo();
            VerificarSabor();
            VerificarCalda();
            MessageBox.Show("SORVETE\nTIPO: " + Tipo + "\nSABOR(es): " + Sabor + "\nCalda(s):" + Calda);
        }

        private string Tipo, Sabor, Calda;

        private void VerificarTipo()
        {
            //rdbCasquinha rdbPote
            if (rdbCasquinha.Checked)
            {
                Tipo = "Casquinha";
            }
            else
            {
                Tipo = "Pote";
            }
        }

        private void VerificarSabor()
        {
            Sabor = "";
            if (chkChocolate.Checked)
            {
                Sabor = "Chocolate; ";
            }
            if (chkMorango.Checked)
            {
                Sabor += "Morango; ";
            }
            if (chkBaunilha.Checked)
            {
                Sabor += "Baunilha; ";
            }
            if (String.IsNullOrEmpty(Sabor))
            {
                Sabor = "Não selecionado";
            }
        }

        private void VerificarCalda()
        {
            Calda = "";
            if (chkChocolateQuente.Checked)
            {
                Calda = "Chocolate Quente; ";
            }
            if (chkCaramelo.Checked)
            {
                Calda += "Caramelo; ";
            }
            if (String.IsNullOrEmpty(Calda))
            {
                Calda = "Não selecionado";
            }
        }
    }
}
