using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MGURIDEAPAD;Initial Catalog=HastaneProje;User ID=sa;Password=Gr1724Gr");
            baglan.Open();
            return baglan;
        }
    }
}
