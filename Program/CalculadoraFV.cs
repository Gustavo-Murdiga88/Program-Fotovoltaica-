using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgramFotovoltaica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txt_mediaConsumo.Enabled = false;
            txt_mediaConsumoDia.Enabled = false; 
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_mediaAnual_Click(object sender, EventArgs e)
        {
            //declaração de váriaveis
            double mes1, mes2, mes3, mes4, mes5, mes6, mes7, mes8, mes9, mes10, mes11, mes12, mediaTotalkwh;

            //entrada de consumo mensal

            mes1 = Convert.ToDouble(txt_mes1.Text);
            mes2 = Convert.ToDouble(txt_mes2.Text);
            mes3 = Convert.ToDouble(txt_mes3.Text);
            mes4 = Convert.ToDouble(txt_mes4.Text);
            mes5 = Convert.ToDouble(txt_mes5.Text);
            mes6 = Convert.ToDouble(txt_mes6.Text);
            mes7 = Convert.ToDouble(txt_mes7.Text);
            mes8 = Convert.ToDouble(txt_mes8.Text);
            mes9 = Convert.ToDouble(txt_mes9.Text);
            mes10 = Convert.ToDouble(txt_mes10.Text);
            mes11 = Convert.ToDouble(txt_mes11.Text);
            mes12 = Convert.ToDouble(txt_mes12.Text);

            //calculo de consumo médio por ano 
            mediaTotalkwh = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6 + mes7 + mes8 + mes9 + mes10 + mes11 + mes12) / 12;

            //estruda de decisão do CheckBox Padrão de entrada


            if (rdoMono.Checked)
            {
                mediaTotalkwh -= 30;
            }else if(rdoBifa.Checked)
            {
                mediaTotalkwh -= 60;
            }
            else if (rdoTri.Checked)
            {
                mediaTotalkwh -= 90;
            }
            else if ( rdoMono.Checked == false && rdoBifa.Checked == false && rdoTri.Checked == false)
            {
                MessageBox.Show("Selecione um padrão de entrada", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



            //Atribuição do valor para a textbox (Média consumo mês)
            txt_mediaConsumo.Text = mediaTotalkwh.ToString("F2") + "KW/h";

            //Atribuição do valor para textbox (Média Dia)

            txt_mediaConsumoDia.Text = (mediaTotalkwh / 30).ToString("F2");

            //Atribuíção do valor "mediaTotalkwh" para a textbox "Média dia" 
            txt_copiaMediaConsumo.Text = txt_mediaConsumoDia.Text;
            

        }

        private void  ckb_PEM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calularSistemaSolar_Click(object sender, EventArgs e)
        {
            //declaração de variáveis 
            double resultadoKwp, irradiacaoSolar,totalPlacasSolares, potenciaTotalInversor, potenciaTotalDasPlacas;

            //Atribuição de valores para váriaveis
            resultadoKwp = Convert.ToDouble(txt_copiaMediaConsumo.Text);
            irradiacaoSolar = Convert.ToDouble(txt_irradiacaoSolar.Text);

            //Resultado em Kwp
           txt_resultadoKwp.Text = (resultadoKwp /= irradiacaoSolar).ToString("F2");

            //potência das placas
            potenciaTotalDasPlacas = Convert.ToDouble(txt_potenciaPlacasSolares.Text); 
            //Calculando total de placas
            totalPlacasSolares = Convert.ToDouble(txt_resultadoKwp.Text);
            totalPlacasSolares = (totalPlacasSolares * 1000) / potenciaTotalDasPlacas;

            //Atribuindo Valor para textbox Total placas
            txt_totalPlacasSolares.Text = totalPlacasSolares.ToString("F0");

            //Calculando o Valor total do inversor 
            potenciaTotalInversor = totalPlacasSolares * potenciaTotalDasPlacas;

            //Atribuindo o valor para a textbox (Potência total Inversor)
            txt_potenciaInversor.Text = potenciaTotalInversor.ToString("N1") + "Kwp";




        }

        private void txt_mes1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mediaConsumo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_mediaConsumoDia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
