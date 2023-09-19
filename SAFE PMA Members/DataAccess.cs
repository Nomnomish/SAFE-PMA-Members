using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public List<Member> MemberList(string lastName)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            var output = connection.Query<Member>("dbo.").ToList();
            return output;
        }
    }
}
