using DataAccess.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        public User Login(string user, string pass)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass)
            };

            string query = "SELECT * FROM Users WHERE LoginName = @user AND Password = @pass";
            DataTable result = ExecuteReader(query);

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    LoginName = Convert.ToString(row["LoginName"]),
                    Password = Convert.ToString(row["Password"]),
                    FullName = Convert.ToString(row["FullName"]),
                    Role = Convert.ToString(row["Role"])
                };
            }
            return null;
        }
    }
}
