using System;
using System.Windows.Forms;
using log4net;
using System.Configuration;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly ILog logger =
            LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            logger.Info("Boton pulsado");

        }

        private void Setting_Click(object sender, EventArgs e)
        {
            var sAttr = ConfigurationManager.AppSettings["FileName"].ToString();
            MessageBox.Show(sAttr);
        }
    }
}
