using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futebol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idades = Convert.ToInt32(txt_idade.Text);
            if(idades <=  4 || idades >= 26)
            {
                MessageBox.Show("FAVOR PREENCHER O CAMPO CORRETAMENTE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                int idade = Convert.ToInt32(txt_idade.Text);

                if(idade == 5 || idade <= 10)
                {

                    lb_result.Text = "INFANTIL";
                    lb_result.ForeColor = Color.Green;


                }
                else if ( idade == 1 || idade <= 15)
                {

                    lb_result.Text = "JUVENIL";
                    lb_result.ForeColor = Color.Gold;


                }
                else if (idade == 16 || idade <= 20 )
                {

                    lb_result.Text = "JUNIOR";
                    lb_result.ForeColor = Color.Blue;

                }
                else if ( idade == 21 || idade <= 25)
                {

                    lb_result.Text = "PROFISSIONAL";
                    lb_result.ForeColor = Color.Red;

                }









            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idades = Convert.ToInt32(txt_idade.Text);
            
            if (idades <= 4 || idades >= 26)
            {

                MessageBox.Show("FAVOR PREENCHER O CAMPO CORRETAMENTE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else

            {




                int idade_case = Convert.ToInt32(txt_idade.Text);


                switch (idade_case)
                {

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        lb_result.Text = "INFANTIL";
                        lb_result.ForeColor = Color.Green;
                        break;

                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        lb_result.Text = "JUVENIL";
                        lb_result.ForeColor = Color.Gold;       
                        break;

                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        lb_result.Text = "JUNIOR";
                        lb_result.ForeColor = Color.Blue;
                        break;

                    default:
                        lb_result.Text = "PROFISSIONAL";
                        lb_result.ForeColor = Color.Red;
                        break;









                }









            }



















        }
    }
}
