using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
  public partial class FrmMedia : Form
  {
    public FrmMedia()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
       // Aqui é um comentario
       // criando as variaveis
       // boa pratica criar as variaveis no começo do codigo
      decimal nota1;
      decimal nota2;
      decimal nota3;
      decimal nota4;
      decimal media1, media2, mediaFinal;
      // o C# é case sensitive, faz diferenciação entre maiuscula e miniscula
      nota1 = decimal.Parse(txtN1.Text);
      nota2 = decimal.Parse(txtN2.Text);
      nota3 = decimal.Parse(txtN3.Text);
      nota4 = decimal.Parse(txtN4.Text);
      /* fazer validacao dos numeros
      para tomar uma decisao usamos o comando if(se)
      if é sempre uma comparação
      tipos de comparações:
      == igualdade
      >=
      <=
      >
      <
      != diferente
      || (o nome deste simbolo é pipe ) significa ou
      && significa E
      */ 
      if (nota1 > 10 || nota1 <0) {
            // só pra colocar o cirsor na caixina que esta com erro
      txtN1.Focus();
                //mostrar mensagem para o usuario
      MessageBox.Show("A nota 1 está errada, notas entre 0 e 10");
            // finalizar o codigo, quando aparece o return o codigo é finalizado
      return;
            }
       if (nota1 > 10 || nota1 <0) {
            // só pra colocar o cirsor na caixina que esta com erro
      txtN1.Focus();
                //mostrar mensagem para o usuario
      MessageBox.Show("A nota 1 está errada, notas entre 0 e 10");
            // finalizar o codigo, quando aparece o return o codigo é finalizado
      return;
            }
            if (nota2 > 10 || nota2 < 0)
            {
                // só pra colocar o cirsor na caixina que esta com erro
                txtN1.Focus();
                //mostrar mensagem para o usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10");
                // finalizar o codigo, quando aparece o return o codigo é finalizado
                return;
            }
            if (nota3 > 10 || nota3 < 0)
            {
                // só pra colocar o cirsor na caixina que esta com erro
                txtN1.Focus();
                //mostrar mensagem para o usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10");
                // finalizar o codigo, quando aparece o return o codigo é finalizado
                return;
            }
            if (nota4 > 10 || nota4 < 0)
            {
                // só pra colocar o cirsor na caixina que esta com erro
                txtN1.Focus();
                //mostrar mensagem para o usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10");
                // finalizar o codigo, quando aparece o return o codigo é finalizado
                return;
            }

            //calculo das medias
            media1 = ((nota1 * 4) + (nota2 * 6)) /10;
      media2 = ((nota3 * 4) + (nota4 * 6)) /10;
      mediaFinal = (media1 + media2) /2;
      // mostrar as medias
      // .ToString() = transformar em texto isto é um metodo/funçao
      // como saber se é um método? icone cubo roxo
      txtBim1.Text = media1.ToString();
      txtBim2.Text = media2.ToString();
      txtMedia.Text = mediaFinal.ToString();
        }

    private void txtID_TextChanged(object sender, EventArgs e)
    {

    }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
