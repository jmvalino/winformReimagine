using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.ProviderBase;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace VSBoard
{
    public partial class dbConnector : Form
    {

        public dbConnector()
        {
            InitializeComponent();
        }

        public string constring = @"Data Source=" + ConfigurationManager.AppSettings["ds"] + ";" +
                                      "Initial Catalog=DB_SmartScheduler;" +
                                      "User ID=" + ConfigurationManager.AppSettings["du"] + ";" +
                                      "Password=" + ConfigurationManager.AppSettings["dp"] + ";";

        private void dbConfig_FormClosing(object sender, FormClosingEventArgs e)
        {

           

        }

        private void dbConnector_Load(object sender, EventArgs e)
        {
            ds.Text = ConfigurationManager.AppSettings["ds"];
            du.Text = ConfigurationManager.AppSettings["du"];
            dp.Text = ConfigurationManager.AppSettings["dp"];
        }

        private void dbConnector_FormClosing(object sender, FormClosingEventArgs e)
        {

            //config.ConnectionStrings["ds"] = ds.Text;
            //config.ConnectionStrings["du"] = ds.Text;
            //config.ConnectionStrings["dp"] = ds.Text;

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ds"].Value = ds.Text;
            config.AppSettings.Settings["du"].Value = du.Text;
            config.AppSettings.Settings["dp"].Value = dp.Text;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

       
       
    }
}
