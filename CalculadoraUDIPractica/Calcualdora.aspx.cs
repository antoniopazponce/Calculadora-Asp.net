using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraUDIPractica
{
    public partial class Calcualdora : System.Web.UI.Page
    {
        Calculate _calculadora;
        protected void Page_Load(object sender, EventArgs e)
        {
            _calculadora = new Calculate();
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "0";
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "3";
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "4";

        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "5";

        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "6";

        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "7";

        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "8";

        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += "9";
           
        }

        protected void btnCE_Click(object sender, EventArgs e)
        {
            txtTotal.Text = string.Empty;
            Session["Valor1"] = null;
            Session["Valor2"] = null;
        }
       
        protected void btnSuma_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == string.Empty)
            {
                Response.Write("Sintax Error");
            }
            else
            {
                if (Session["Verificador"] == null)
                {
                    Session["Valor1"] = txtTotal.Text;
                    Session["Operador"] = "Suma";
                    Session["Verificador"] = 1;
                    txtTotal.Text = string.Empty;
                }
                else
                {
                    if (Session["Verificador"] != null)
                    {
                        Session["Valor2"] = txtTotal.Text;
                        txtTotal.Text = string.Empty;
                        Session["Valor1"] = _calculadora.Suma(Convert.ToInt32(Session["valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                    }
                }
            }
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == string.Empty)
            {
                Response.Write("Sintax Error");
            }
            else
            {
                if(Session["Verificador"] == null)
                {
                    Session["Operador"] = "Resta";
                    Session["Valor1"] = txtTotal.Text;
                    txtTotal.Text = string.Empty;
                    Session["Verificador"] = 1;
                }
                else
                {
                    if(Session["Verificador"]!= null)
                    {
                        Session["Valor2"] = txtTotal.Text;
                        Session["Valor1"] = _calculadora.Resta(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                        txtTotal.Text = string.Empty;
                        Session["Verificador"] = null;

                    }
                }
            }
        }

        protected void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == string.Empty)
            {
                Response.Write("Sintax Error");
            }
            else
            {
                if (Session["Verificador"] == null)
                {
                    Session["Operador"] = "Multiplicacion";
                    Session["Valor1"] = txtTotal.Text;
                    txtTotal.Text = string.Empty;
                    Session["Verificador"] = 1;
                }
                else
                {
                    if (Session["Verificador"] != null)
                    {
                        Session["Valor2"] = txtTotal.Text;
                        Session["Valor1"] = _calculadora.Multiplicacion(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                        txtTotal.Text = string.Empty;

                    }
                }
            }
        }

        protected void btnDivicion_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == string.Empty)
            {
                Response.Write("Sintax Error");
            }
            else
            {
                if (Session["Verificador"] == null)
                {
                    Session["Operador"] = "Division";
                    Session["Valor1"] = txtTotal.Text;
                    txtTotal.Text = string.Empty;
                    Session["Verificador"] = 1;
                }
                else
                {
                    if (Session["Verificador"] != null)
                    {
                        Session["Valor2"] = txtTotal.Text;
                        Session["Valor1"] = _calculadora.Division(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                        txtTotal.Text = string.Empty;

                    }
                }
            }
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == string.Empty)
            {
                Response.Write("Sintax Error");
            }
            else
            {
                if((string)Session["Operador"]=="Suma")
                {
                    Session["Valor2"] = txtTotal.Text;
                    txtTotal.Text =_calculadora.Suma( Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                    Session["Verificador"] = null;
                    
                }
                else
                {
                    if((string)Session["Operador"]=="Resta")
                    {
                        Session["Valor2"] = txtTotal.Text;
                        txtTotal.Text = _calculadora.Resta(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                        Session["Verificador"] = null;
                    }
                    else
                    {
                        if((string) Session["Operador"]=="Multiplicacion")
                        {
                            Session["Valor2"] = txtTotal.Text;
                            txtTotal.Text = _calculadora.Multiplicacion(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                            Session["Verificador"] = null;
                        }
                        else
                        {
                            if ((string)Session["Operador"] == "Division")
                            {
                                Session["Valor2"] = txtTotal.Text;
                                txtTotal.Text = _calculadora.Division(Convert.ToInt32(Session["Valor1"]), Convert.ToInt32(Session["Valor2"])).ToString();
                                Session["Verificador"] = null;
                            }
                        }
                    }
                }
               
            }
        }

        protected void btnComa_Click(object sender, EventArgs e)
        {
            txtTotal.Text += ","; 
        }
    }
}