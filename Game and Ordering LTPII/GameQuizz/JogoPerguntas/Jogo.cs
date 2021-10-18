using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPerguntas
{
    public partial class Jogo : Form
    {
        public Jogo(string nome)
        {
            InitializeComponent();
            this.nomejogo = nome;
        }

        string nomejogo;
        private int flag;
        int i = 1;
        private int pontos = 0;

        public int Pontos { get => pontos; set => pontos = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Enabled = false;
            cmdVeri.Enabled = true;
            flag = 6;
            timer1.Enabled = true;
            if (i==1)
            {
                labelPerguntaVerd.Text = "Qual o componente utilizado para exibir imagens e textos que não podem ser alterados pelo usuário?";
                radioButton1.Text = "Ponteiro";
                radioButton2.Text = "Label";
                radioButton3.Text = "Picture Box";
                radioButton4.Text = "Painel";
                button1.Text = "Proximo";
            }
            else if (i==2)
            {
                labelPerguntaVerd.Text = "Qual desses componentes é utilizado para criar um menu no windows forms?";
                radioButton1.Text = "MenuStrip";
                radioButton2.Text = "MenuForm";
                radioButton3.Text = "TextBox";
                radioButton4.Text = "MenuList";
            }
            else if (i == 3)
            {
                labelPerguntaVerd.Text = "Qual é o componente utilizado para exibir um calendario no windows forms?";
                radioButton1.Text = "Calender";
                radioButton2.Text = "DateCalender";
                radioButton3.Text = "Date";
                radioButton4.Text = "MouthnCalender";
            }
            else if (i == 4)
            {
                labelPerguntaVerd.Text = "Qual é o componente utilizado para para exibir arrays no windows forms ?";
                radioButton1.Text = "TextBox";
                radioButton2.Text = "ArraysList";
                radioButton3.Text = "DataGridView";
                radioButton4.Text = "VetArrays";
            }
            else if (i == 5)
            {
                labelPerguntaVerd.Text = "Qual é o componente utilizado para fazer ações periodicamente no windows forms?";
                radioButton1.Text = "Date";
                radioButton2.Text = "Ponteiro";
                radioButton3.Text = "Timer";
                radioButton4.Text = "ActionTrue";
            }
            else if (i == 6)
            {
                labelPerguntaVerd.Text = "Qual é o componente que é utilizado para exibir anotações quando se passa o mouse por cima";
                radioButton1.Text = "TrackBar";
                radioButton2.Text = "Ponteiro";
                radioButton3.Text = "ToolTip";
                radioButton4.Text = "AnnotationStrip";
            }
            else if (i == 7)
            {
                labelPerguntaVerd.Text = "Qual é o componente que é utilizado para representar uma barra de progresso no windows forms";
                radioButton1.Text = "ProgressBar";
                radioButton2.Text = "BarraList";
                radioButton3.Text = "StripBar";
                radioButton4.Text = "TreeViwe";
            }
            if (button1.Text=="Proximo")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            if (button1.Text=="Fim")
            {
                Close();
            }
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag ==6)
            {
                pBFotos.Image = Properties.Resources._6b;
                flag--;
            }
            else if (flag == 5)
            {
                pBFotos.Image = Properties.Resources._5b;
                flag--;
            }
            else if (flag == 4)
            {
                pBFotos.Image = Properties.Resources._4b;
                flag--;
            }
            else if (flag == 3)
            {
                pBFotos.Image = Properties.Resources._31;
                flag--;
            }
            else if (flag == 2)
            {
                pBFotos.Image = Properties.Resources._2b;
                flag--;
            }
            else if (flag == 1)
            {
                pBFotos.Image = Properties.Resources._1b;
                flag--;
            }
            else if (flag == 0)
            {
                pBFotos.Image = Properties.Resources.tempoPassou;
                radioButton1.Text = " ";
                radioButton2.Text = " ";
                radioButton3.Text = " ";
                radioButton4.Text = " ";
                labelPerguntaVerd.Text = "O tempo acabou...\n Clique em proximo para ir adiante";
                button1.Enabled = true;
                cmdVeri.Enabled = false;
                i++;
                
                if (i == 8)
                {
                    labelPerguntaVerd.Text = "Nome:" + nomejogo + "\nPontos :" + Pontos + "\nO jogo acabou";
                    button1.Text = "Fim";
                }
            }
        }

        private void cmdVeri_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            cmdVeri.Enabled = false;
            switch (i)
            {
                case 1:
                    if (radioButton2.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 2:
                    if (radioButton1.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 3:
                    if (radioButton4.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 4:
                    if (radioButton3.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 5:
                    if (radioButton3.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 6:
                    if (radioButton3.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    break;
                case 7:
                    if (radioButton1.Checked ==true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        Pontos += flag;
                    }
                    else
                        pBFotos.Image = Properties.Resources.errou;
                    labelPerguntaVerd.Text = "Nome:" + nomejogo + "\nPontos :" + Pontos + "\nO jogo acabou";
                    button1.Text = "Fim";
                    break;
                default:
                    {
                    }
                    break;
            }
            flag = -1;
            i++;
        }

    }
    
}
