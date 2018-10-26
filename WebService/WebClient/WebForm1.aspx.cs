using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.CalculatorService;//пространтсво имён веб-сервиса

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static WebServiceCalculatorSoapClient _serviceCalculatorSoapClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Добавлено веб-ссылка на сервис
            // Это инициализация клиента для веб-сервиса
            _serviceCalculatorSoapClient = new CalculatorService.WebServiceCalculatorSoapClient();
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (_serviceCalculatorSoapClient.State != CommunicationState.Opened)
            {
                var result = "";
                if (button == Button1)
                {
                    result =
                        _serviceCalculatorSoapClient.Sub(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text))
                            .ToString(CultureInfo.CurrentCulture);
                }
                else if (button == Button2)
                {
                    result =
                        _serviceCalculatorSoapClient.Sum(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text))
                            .ToString(CultureInfo.CurrentCulture);
                }
                else if (button == Button3)
                {
                    result =
                        _serviceCalculatorSoapClient.Div(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text))
                            .ToString(CultureInfo.CurrentCulture);
                }
                else
                {
                    result =
                        _serviceCalculatorSoapClient.Mult(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text))
                            .ToString(CultureInfo.CurrentCulture);
                }

                Label1.Text = result;
                _serviceCalculatorSoapClient.Close();
            }
        }
    }
}