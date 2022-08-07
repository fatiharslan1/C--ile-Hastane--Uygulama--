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
    public partial class frm_doktorgiris : Form
    {
        public frm_doktorgiris()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select  * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_doktordetay frd = new frm_doktordetay();
                frd.dtc = msktc.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Şifre ya da TC", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
