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

namespace hastane_proje
{
    public partial class frm_doktordetay : Form
    {
        public frm_doktordetay()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        public string dtc;

        private void frm_doktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = dtc;

            //doktor ad soyad
            SqlCommand komut = new SqlCommand("select doktorad, doktorsoyad from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevudoktor= '" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            frm_doktorbilgiduzenle frdb = new frm_doktorbilgiduzenle();
            frdb.TCNO = lbltc.Text;
            frdb.Show();

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frm_duyurular fr = new frm_duyurular();
            fr.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
