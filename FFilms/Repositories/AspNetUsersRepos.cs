using Dapper;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FFilms.Repositories
{
    public class AspNetUsersRepos
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<IdentityUser> GetUsers()
        {
            List<IdentityUser> users = new List<IdentityUser>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                users = db.Query<IdentityUser>("SELECT * FROM AspNetUsers").ToList();
            }
            return users;
        }
    }
}