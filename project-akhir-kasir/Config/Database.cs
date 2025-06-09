using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_kasir.Config
{
    public static class Database
    {
        private static String dbServer = "localhost";
        private static String dbUser = "root";
        private static String dbPassword = "";
        private static String dbName = "project_pemvis";

        public static String ConnStr => $"server={dbServer};user={dbUser}; database={dbName}; password={dbPassword}";
    }
}
