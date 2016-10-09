using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Management.Objects
{
    public class Connection
    {
        public string connectionString { set; get; }
        public SqlCeConnection connect()
        {
            SqlCeConnection cn = new SqlCeConnection(connectionString);
            return cn;
        }

        public byte[] HashPassword(string password)
        {
            System.Security.Cryptography.SHA1 hash = System.Security.Cryptography.SHA1.Create();
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] combined = encoder.GetBytes(password);
            hash.ComputeHash(combined);
            return hash.Hash;
        }
    }
}
