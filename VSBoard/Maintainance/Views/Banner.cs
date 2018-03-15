using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VSBoard.Maintainance.Views
{
    public partial class Banner : Form
    {
          LinkedList<String> annlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        int imageID = 0;
        int rowg = 0;
        public Banner()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            GetImagesFromDatabase();
        }
        void GetImagesFromDatabase()
        {
            try
            {
                //Initialize SQL Server connection.
                SqlConnection CN = new SqlConnection(connection.constring);

                //Initialize SQL adapter.
                SqlDataAdapter ADAP = new SqlDataAdapter("Select * from tbl_banners", CN);

                //Initialize Dataset.
                DataSet DS = new DataSet();

                //Fill dataset with ImagesStore table.
                ADAP.Fill(DS, "ImagesStore");

                //Fill Grid with dataset.
                dataGridView1.DataSource = DS.Tables["ImagesStore"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImageData"].Value;
                imageID = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                rowg = e.RowIndex;
                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPreview.Image = newImage;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
                   //Ask user to select file.
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Set image in picture box
               pictureBoxPreview.ImageLocation = dlg.FileName;

                //Provide file path in txtImagePath text box.
                txtImagePath.Text = dlg.FileName;
            }
        }

        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(txtImagePath.Text);

                //Initialize SQL Server Connection
                SqlConnection CN = new SqlConnection(connection.constring);

                //Set insert query
                string qry = "insert into tbl_banners (OriginalPath,ImageData) values(@OriginalPath, @ImageData)";

                //Initialize SqlCommand object for insert.
                SqlCommand SqlCom = new SqlCommand(qry, CN);

                //We are passing Original Image Path and Image byte data as sql parameters.
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)txtImagePath.Text));
                SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                //Open connection and execute insert query.
                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();

                //Close form and return to list or images.
                Banner_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a valid banner !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_banners where id = @ImageID";
            cm = new SqlCommand(sql, cn);
            cm.Parameters.Add(new SqlParameter("@ImageID", (int)imageID));
            cm.ExecuteNonQuery();
            MessageBox.Show("Banner successfully deleted", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cm.Dispose();
            //listViewAnnouncements.Items.Clear();
            //getAnnouncement();
            Banner_Load(sender,e);
            button2.Enabled = false;
        }

        
    }
}
