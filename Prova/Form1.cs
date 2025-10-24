using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String destino = cbDestino.Text;
            double totalfinal = 0;
            double totaldiaria = 0;
            double total = 0;
            int adulto = (int)ncdAdulto.Value;
            int crianca = (int)ncdCriancas.Value;
            int diaria = (int)ncdDiaria.Value;

            //  string mensagem;


            switch (destino) {
                case "Londres":
                    //      mensagem += "Destino: Londres";
                    if (rdbSimples.Checked)
                    {
                        total += 500;
                        destino += "\n Quarto: Simples";

                    }

                    if (rdnMedio.Checked)
                    {
                        total += 700;
                        destino += "\n Quarto: Médio";

                    }

                    if (rdnLuxo.Checked)
                    {
                        total += 900;
                        destino += "\n Quarto: Luxo";

                    }

                    if (rndSluxo.Checked)
                    {
                        total += 1100;
                        destino += "\n Quarto: Super Luxo";

                    }

                    // Opcionais 


                    if (chbSeguro.Checked)
                    {
                        total += 50;
                        destino += "\n Seguro: Sim";

                    }

                    else if (!chbSeguro.Checked)
                    {
                        destino += "\n Seguro: Não";

                    }

                    if (chbTranslado.Checked)
                    {
                        total += 25;
                        destino += "\n Translado: Sim";

                    }

                    else if (!chbTranslado.Checked)
                    {
                        destino += "\n Translado: Não";

                    }


                    if (chbAlmoco.Checked)
                    {
                        total += 100;
                        destino += "\n Almoço: Sim";

                    }

                    else if (!chbAlmoco.Checked)
                    {
                        destino += "\n Almoço: Não";

                    }

                    if (chbPasseio.Checked)
                    {
                        total += 40;
                        destino += "\n Passeio: Sim";

                    }

                    else if (!chbPasseio.Checked)
                    {
                        destino += "\n Passeio: Não";

                    }

                    if (chbLavandeia.Checked)
                    {
                        total += 10;
                        destino += "\n Lavanderia: Sim";

                    }

                    else if (!chbLavandeia.Checked)
                    {
                        destino += "\n Lavanderia: Não";

                    }

                    break;

                        case "Paris":
                            //      mensagem += "Destino: Londres";
                            if (rdbSimples.Checked)
                            {
                                total += 600;
                                destino += "\n Quarto: Simples";

                            }

                            if (rdnMedio.Checked)
                            {
                                total += 800;
                                destino += "\n Quarto: Médio";

                            }

                            if (rdnLuxo.Checked)
                            {
                                total += 1000;
                                destino += "\n Quarto: Luxo";

                            }

                            if (rndSluxo.Checked)
                            {
                                total += 1200;
                                destino += "\n Quarto: Super Luxo";

                            }

                            // Opcionais 


                            if (chbSeguro.Checked)
                            {
                                total += 60;
                                destino += "\n Seguro: Sim";

                            }

                            else if (!chbSeguro.Checked)
                            {
                                destino += "\n Seguro: Não";

                            }

                            if (chbTranslado.Checked)
                            {
                                total += 30;
                                destino += "\n Translado: Sim";

                            }

                            else if (!chbTranslado.Checked)
                            {
                                destino += "\n Translado: Não";

                            }


                            if (chbAlmoco.Checked)
                            {
                                total += 120;
                                destino += "\n Almoço: Sim";

                            }

                            else if (!chbAlmoco.Checked)
                            {
                                destino += "\n Almoço: Não";

                            }

                            if (chbPasseio.Checked)
                            {
                                total += 50;
                                destino += "\n Passeio: Sim";

                            }

                            else if (!chbPasseio.Checked)
                            {
                                destino += "\n Passeio: Não";

                            }

                            if (chbLavandeia.Checked)
                            {
                                total += 12;
                                destino += "\n Lavanderia: Sim";

                            }

                            else if (!chbLavandeia.Checked)
                            {
                                destino += "\n Lavanderia: Não";

                            }
                            break;


                case "Nova York":
                    //      mensagem += "Destino: Londres";
                    if (rdbSimples.Checked)
                    {
                        total += 550;
                        destino += "\n Quarto: Simples";

                    }

                    if (rdnMedio.Checked)
                    {
                        total += 750;
                        destino += "\n Quarto: Médio";

                    }

                    if (rdnLuxo.Checked)
                    {
                        total += 950;
                        destino += "\n Quarto: Luxo";

                    }

                    if (rndSluxo.Checked)
                    {
                        total += 1150;
                        destino += "\n Quarto: Super Luxo";

                    }

                    // Opcionais 


                    if (chbSeguro.Checked)
                    {
                        total += 55;
                        destino += "\n Seguro: Sim";

                    }

                    else if (!chbSeguro.Checked)
                    {
                        destino += "\n Seguro: Não";

                    }

                    if (chbTranslado.Checked)
                    {
                        total += 22;
                        destino += "\n Translado: Sim";

                    }

                    else if (!chbTranslado.Checked)
                    {
                        destino += "\n Translado: Não";

                    }


                    if (chbAlmoco.Checked)
                    {
                        total += 125;
                        destino += "\n Almoço: Sim";

                    }

                    else if (!chbAlmoco.Checked)
                    {
                        destino += "\n Almoço: Não";

                    }

                    if (chbPasseio.Checked)
                    {
                        total += 45;
                        destino += "\n Passeio: Sim";

                    }

                    else if (!chbPasseio.Checked)
                    {
                        destino += "\n Passeio: Não";

                    }

                    if (chbLavandeia.Checked)
                    {
                        total += 14;
                        destino += "\n Lavanderia: Sim";

                    }

                    else if (!chbLavandeia.Checked)
                    {
                        destino += "\n Lavanderia: Não";

                    }
                    break;


                case "Barcelona":
                    //      mensagem += "Destino: Londres";
                    if (rdbSimples.Checked)
                    {
                        total += 580;
                        destino += "\n Quarto: Simples";

                    }

                    if (rdnMedio.Checked)
                    {
                        total += 780;
                        destino += "\n Quarto: Médio";

                    }

                    if (rdnLuxo.Checked)
                    {
                        total += 980;
                        destino += "\n Quarto: Luxo";

                    }

                    if (rndSluxo.Checked)
                    {
                        total += 1180;
                        destino += "\n Quarto: Super Luxo";

                    }

                    // Opcionais 


                    if (chbSeguro.Checked)
                    {
                        total += 58;
                        destino += "\n Seguro: Sim";

                    }

                    else if (!chbSeguro.Checked)
                    {
                        destino += "\n Seguro: Não";

                    }

                    if (chbTranslado.Checked)
                    {
                        total += 24;
                        destino += "\n Translado: Sim";

                    }

                    else if (!chbTranslado.Checked)
                    {
                        destino += "\n Translado: Não";

                    }


                    if (chbAlmoco.Checked)
                    {
                        total += 130;
                        destino += "\n Almoço: Sim";

                    }

                    else if (!chbAlmoco.Checked)
                    {
                        destino += "\n Almoço: Não";

                    }

                    if (chbPasseio.Checked)
                    {
                        total += 55;
                        destino += "\n Passeio: Sim";

                    }

                    else if (!chbPasseio.Checked)
                    {
                        destino += "\n Passeio: Não";

                    }

                    if (chbLavandeia.Checked)
                    {
                        total += 15;
                        destino += "\n Lavanderia: Sim";

                    }

                    else if (!chbLavandeia.Checked)
                    {
                        destino += "\n Lavanderia: Não";

                    }
                    break;
            }
            totalfinal += (total * adulto) + (total * crianca * (0.50) );
            totaldiaria += totalfinal * diaria;

            MessageBox.Show("Destino: " + destino + "\n" + "\n" + "Adultos: " + adulto + "\n" + "Crianças: " + crianca + "\n" + "Diárias: " + diaria + "\n" + "Total Da Reserva:  R$" + totaldiaria);
        }
    }
}
