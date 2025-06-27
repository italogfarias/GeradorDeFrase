using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GeradorDeFrase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarFrase_Click(object sender, EventArgs e)
        {

            string url = $"https://estevaorada.com/aulas/api/frases/";

            Frase frase = new Frase();

            //Limita a utilização do webClient dentro do escopo:
            using (WebClient navegador = new WebClient())
            {
                string conteudo = navegador.DownloadString(url);
                // Converter para UTF-8 (corrigir acentuação)
                conteudo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(conteudo));
                //Instanciar um obj do tipo endereco
               

                frase = JsonConvert.DeserializeObject<Frase>(conteudo);

                // Verificar se endereco.Cep não é nulo:
                if (!string.IsNullOrEmpty(frase.Frase_))
                {

                  lblResultado.Text = frase.Frase_;
                }

                else
                {
                    MessageBox.Show("Não foi possível obter a frase! ");
                }
            }

        }
    }
}
