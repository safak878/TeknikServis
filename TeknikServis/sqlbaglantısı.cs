using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TeknikServis
{
    class sqlbaglantısı
    {
        public SqlConnection baglantı()
        {


            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F0TNBP8;Initial Catalog=DbTeknıkServıs;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
