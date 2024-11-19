using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andmebass2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Andmebaas_Tarpv23;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        OpenFileDialog open;
        SaveFileDialog save;
        string extension;
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
        }
        public void NaitaAndmed()
        {
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Toode", conn);
            adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'andmebaas_Tarpv23DataSet.Toode' table. You can move, or remove it, as needed.
            this.toodeTableAdapter.Fill(this.andmebaas_Tarpv23DataSet.Toode);

        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Insert into Toode(Nimetus, Kogus, Hind, Pilt) Values (@toode,@kogus,@hind,@pilt)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text + extension);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }

        private void Kustuta_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if (ID != 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM Toode WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Emaldamine();
                    NaitaAndmed();

                    MessageBox.Show("Kirje kustutatud");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Viga kustutamisel");
            }
        }

        private void Uuenda_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Update Toode SET Nimetus=@toode, Kogus=@kogus, Hind=@hind WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text + extension);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                    Emaldamine();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }

        
        private void Emaldamine()
        {
            MessageBox.Show("Andmed elukalt uuendatud", "Uuendamine");
            Nimetus_txt.Text = "";
            Kogus_txt.Text = "";
            Hind_txt.Text = "";
            pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "Красный_крест.png"));
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        private void Pildi_otsing_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Pictures\";
            open.Multiselect = false;
            open.Filter = "Images Files(*.jpeg;*.png;*.bmp;*.jpg)|*.jpeg;*.png;*.bmp;*.jpg";
            FileInfo openfile = new FileInfo(@"C:\Users\opilane\Pictures\" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Nimetus_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Pildid");
                extension = Path.GetExtension(open.FileName);
                save.FileName = Nimetus_txt.Text + extension;
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && Nimetus_txt != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox1.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või ole Cancel vajutatud");
            }
        }
    }
}