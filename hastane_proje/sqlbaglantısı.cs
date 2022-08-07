using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje
{
    internal class sqlbaglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-5R80TPD\\;Initial Catalog=Hastaneproje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
