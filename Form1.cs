using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Andmebass2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Andmebaas_Tarpv23;Integrated Security=True");

        //SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["AndmebaasConnectionString"]);

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable laotable, dt;
        string openFilePath;
        int ID;
        public Form1()
        {
            InitializeComponent();
            NaitaLaod();
            NaitaAndmed();
        }

        private void NaitaLaod()
        {
            try
            {
                conn.Open();
                laotable = new DataTable();
                cmd = new SqlCommand("SELECT * FROM Ladu", conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(laotable);
                foreach (DataRow row in laotable.Rows)
                {
                    Ladu_cb.Items.Add(row["LaoNimetus"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga laode andmete laadimisel: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    

        private void ClearPictureBoxImage()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }


        public void NaitaAndmed()
        {
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Toode", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Pilt"].HeaderText = "Pilt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga andmete laadimisel: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nimetus_txt.Text) &&
                !string.IsNullOrWhiteSpace(Kogus_txt.Text) &&
                !string.IsNullOrWhiteSpace(Hind_txt.Text))
            {
                try
                {
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("Palun valige pilt!");
                        return;
                    }

                    conn.Open();

                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    cmd = new SqlCommand("SELECT Id FROM Ladu WHERE LaoNimetus=@ladu", conn);
                    cmd.Parameters.AddWithValue("@ladu", Ladu_cb.Text);
                    int laduId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("INSERT INTO Toode (Nimetus, Kogus, Hind, ProductPicture, LaoId) VALUES (@toode, @kogus, @hind, @pilt, @laoid)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", int.Parse(Kogus_txt.Text));
                    cmd.Parameters.AddWithValue("@hind", decimal.Parse(Hind_txt.Text));
                    cmd.Parameters.AddWithValue("@pilt", imageBytes);
                    cmd.Parameters.AddWithValue("@laoid", laduId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Toode lisati edukalt!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga toote lisamisel: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Emaldamine();
                    NaitaAndmed();
                }
            }
            else
            {
                MessageBox.Show("Palun täitke kõik väljad!");
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
                    cmd = new SqlCommand("DELETE FROM Toode WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga kustutamisel: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Emaldamine();
                NaitaAndmed();
            }
        }

        private void Uuenda_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nimetus_txt.Text) && !string.IsNullOrWhiteSpace(Kogus_txt.Text) && !string.IsNullOrWhiteSpace(Hind_txt.Text))
            {
                try
                {
                    conn.Open();

                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    cmd = new SqlCommand("UPDATE Toode SET Nimetus = @toode, Kogus = @kogus, Hind = @hind, ProductPicture = @pilt WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", int.Parse(Kogus_txt.Text));
                    cmd.Parameters.AddWithValue("@hind", decimal.Parse(Hind_txt.Text));
                    cmd.Parameters.AddWithValue("@pilt", imageBytes);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Andmed on edukalt uuendatud!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga andmete uuendamisel: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    NaitaAndmed();
                    Emaldamine();
                }
            }
            else
            {
                MessageBox.Show("Palun täitke kõik väljad!");
            }
        }


        private void Emaldamine()
        {
            Nimetus_txt.Clear();
            Kogus_txt.Clear();
            Hind_txt.Clear();
            ClearPictureBoxImage();
        }

        private void Pildi_otsing_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp;*.jpg;*.png",
                Title = "Valige pilt"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                ClearPictureBoxImage();
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                openFilePath = open.FileName;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value.ToString();
                Kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
                Hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value.ToString();

                byte[] imageBytes = dataGridView1.Rows[e.RowIndex].Cells["ProductPicture"].Value as byte[];

                ClearPictureBoxImage();
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga pildi kuvamisel: " + ex.Message);
            }
        }
    }

}
