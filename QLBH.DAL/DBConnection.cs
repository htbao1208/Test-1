using Microsoft.Data.SqlClient;

namespace QLBH.DAL
{
    public class DBConnection
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");
    }
}
