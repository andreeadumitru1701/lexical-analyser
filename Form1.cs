using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace analizor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text = " ";
        string[] cuv_cheie = {"domains", "predicates", "clauses", "integer", "write"};
        string[] operatori = {">", "<", ">=", "=<", "=:=", "=\\=", "+", "-", "*", "/", "**", "//", "mod"};
        string[] semne_punctuatie = {",", ".", ";"};

        public void analiza_cuvinte_cheie()
        {
            foreach (string aux in cuv_cheie)
            {
                if (text.Contains(aux))
                {
                    cuvcheie.Text += aux + ", ";
                }
            }
        }

        public void analiza_semne_punctuatie()
        {
            foreach (string aux in semne_punctuatie)
            {
                if (text.Contains(aux))
                {
                    punctuatie.Text += aux + "  ";
                }
            }
        }

        public void analiza_operatori()
        {
            foreach (string aux in operatori)
            {
                if (text.Contains(aux))
                {
                    op.Text += aux + ", ";
                }
            }
        }

        public void analiza_constante()
        {
            string rgx_const = @"\b([0-9]).*?\b"; // \b - selector de cuvant
            Regex rgx = new Regex(rgx_const);
            MatchCollection constante = rgx.Matches(text); //MatchCollection - sabloane
            string[] lista_constante = new string[constante.Count];
            string[] lista_constante_diff = new string[constante.Count];

            for (int count = 0; count < constante.Count; count++)
                lista_constante[count] = constante[count].Value.ToString();

            lista_constante_diff = lista_constante.Distinct().ToArray();

            foreach (string aux in lista_constante)
            {
                constante_text.Text += aux + ", ";
            }
        }

        public void analiza_variabile()
        {
            string rgx2_var = @"\b([A-Z]).*?\b"; // \b - selector de cuvant
            Regex rgx2 = new Regex(rgx2_var);
            MatchCollection variabile = rgx2.Matches(text);
            string[] lista_variabile = new string[variabile.Count];
            string[] lista_variabile_diff = new string[variabile.Count];

            for (int count = 0; count < variabile.Count; count++)
                lista_variabile[count] = variabile[count].Value;

            lista_variabile_diff = lista_variabile.Distinct().ToArray();

            foreach (string aux in lista_variabile_diff)
            {
                variabile_text.Text += aux + ", ";
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            analiza_cuvinte_cheie();
            analiza_semne_punctuatie();
            analiza_operatori();
            analiza_constante();
            analiza_variabile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = System.IO.File.ReadAllText(@"C:\Users\X\Desktop\prolog_analizor.txt");
            textBox1.Text = text;
        }
    }
}
