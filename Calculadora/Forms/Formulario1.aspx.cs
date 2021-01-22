using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora.Forms
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        private Ecuacion ecuacion;
        CalculadoraEntities db = new CalculadoraEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnCalcular.Click += BtnCalcular_Click;
            BtnClear.Click += BtnClear_Click;
            BtnLastOperation.Click += BtnLastOperation_Click;
            BtnRegisters.Click += BtnRegisters_Click;
            BtnClearHistory.Click += BtnClearHistory_Click;
            
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }

        private void BtnRegisters_Click(object sender, EventArgs e)
        {
            GetOperations();
        }

        private void BtnLastOperation_Click(object sender, EventArgs e)
        {
            GetLastOperation();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = "";
            TxtNum2.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
        
            SaveLastOperation();
           
            
        }

        private void SaveOperation()
        {    
            db.Ecuacion.Add(ecuacion);
            db.SaveChanges();
        }

    
        private void GetOperations()
        {
            List<Ecuacion> list = db.Ecuacion.ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        private void GetLastOperation()
        {
            if (Session["ecuacion"] != null)
            {
                Ecuacion ecuacion = Session["ecuacion"] as Ecuacion;
                TxtNum1.Text = ecuacion.Num1.ToString().Replace(',','.'); ;
                TxtNum2.Text = ecuacion.Num2.ToString().Replace(',', '.');
                c1.SelectedValue = ecuacion.Operador;
                
            }
        }

        private void SaveLastOperation()
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtNum1.Text) && !string.IsNullOrEmpty(TxtNum2.Text))
                {
                    ecuacion = new Ecuacion()
                    {
                        Num1 = double.Parse(TxtNum1.Text.Replace('.',',')),
                        Num2 = double.Parse(TxtNum2.Text.Replace('.', ',')),
                        Operador = c1.SelectedValue.ToString(),

                    };
                    ecuacion.Result = GetResult(ecuacion.Operador, ecuacion.Num1, ecuacion.Num2);
                    Session["ecuacion"] = ecuacion;
                    ListBox1.Items.Add(ecuacion.ToString());
                    SaveOperation();
                }
            }
            catch (FormatException)
            {

            }
          




        }

        private double GetResult(string Operador,double Num1,double Num2)
        {
            double Result=0;
            switch (Operador)
            {
                case "+":
                    Result = Num1 + Num2;
                    break;
                case "-":
                    Result = Num1 - Num2;
                    break;
                case "x":
                    Result = Num1 * Num2;
                    break;
                case "%":
                    Result = Num1 % Num2;
                    break;
                case "/":
                    Result = Num1 / Num2;
                    break;
            }

            return Result;
        }

    
    
        

      

    
    }
}