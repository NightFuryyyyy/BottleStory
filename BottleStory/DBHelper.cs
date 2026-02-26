using System.Data.SqlClient;

namespace StudentInfoSystem {
    public static class DBHelper {
        private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BottleStory;Integrated Security=True;";
        public static SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }

        public static string login(string username, string password) {
            string sqlQuery = "SELECT username, passwordHash, accountType FROM users where username = @username";
            using (SqlConnection conn = GetConnection()) {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn)) {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader()) {

                        if (!rdr.Read()) {
                            return "Username not found!";
                        }
                        if (BCrypt.Net.BCrypt.EnhancedVerify(password, rdr.GetString(rdr.GetOrdinal("passwordHash")))) {
                            return rdr.GetString(rdr.GetOrdinal("accountType"));
                        } else {
                            return "Incorrect password!";
                        }
                    }
                }
            }
        }

        public static string signup(string username, string password) {
            string sqlQuery = "SELECT username, passwordHash, accountType FROM users where username = @username";
            using (SqlConnection conn = GetConnection()) {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn)) {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        if (rdr.Read()) {
                            return "Username already exists!";
                        }
                        if (BCrypt.Net.BCrypt.EnhancedVerify(password, rdr.GetString(rdr.GetOrdinal("passwordHash")))) {
                            return rdr.GetString(rdr.GetOrdinal("accountType"));
                        } else {
                            return "Incorrect password!";
                        }
                    }
                }
            }
        }
    }
}