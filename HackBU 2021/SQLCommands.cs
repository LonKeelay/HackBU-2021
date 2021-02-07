using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace HackBU_2021
{
    class SQLCommands
    {
        SQLiteConnection conn;
        public SQLCommands()
        {
            conn = new SQLiteConnection("Data Source=daba.db");
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS users(
                username TEXT NOT NULL,
                password TEXT NOT NULL,
                spaces TEXT NOT NULL
            );";
            command.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Adds a user to the database of users
        /// </summary>
        /// <param name="username">User's username</param>
        /// <param name="password">User's password</param>
        /// <param name="spaces">Time taken to input the characters in the password</param>
        /// <returns>
        /// 0 when successful<br/>
        /// 1 when user already exists<br/>
        /// </returns>
        public int createUser(string username, string password, string spaces)
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT count(*) FROM users WHERE username='{username}';";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                conn.Close();
                return 1;
            }
            cmd.CommandText = $"INSERT INTO users(username, password, spaces) VALUES('{username}', '{password}','{spaces}');";
            cmd.ExecuteNonQuery();
            conn.Close();
            return 0;
        }

        /// <summary>
        /// Check if user can login
        /// </summary>
        /// <param name="username">User's username</param>
        /// <param name="password">User's password</param>
        /// <param name="spaces">Time taken to input the characters in the password</param>
        /// <returns>
        /// 0 when successful<br/>
        /// 1 when user does not exist<br/>
        /// 2 when password is wrong<br/>
        /// 3 when speed is wrong
        /// </returns>
        public int login(string username, string password, string spaces)
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT password FROM users WHERE username='{username.ToLower()}';";
            var fir = cmd.ExecuteScalar();
            if (fir == null)
            {
                conn.Close();
                return 1;
            }
            string pass = fir.ToString();
            cmd.CommandText = $"SELECT spaces FROM users WHERE username='{username.ToLower()}';";
            string spac = cmd.ExecuteScalar().ToString();
            if (pass == password && similarEnough(spac, spaces))
            {
                conn.Close();
                return 0;
            }
            else if (similarEnough(spac, spaces))
            {
                conn.Close();
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public void dropTables()
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DROP TABLE users;";
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS users(
                username TEXT NOT NULL,
                password TEXT NOT NULL,
                spaces TEXT NOT NULL
            );";
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        bool similarEnough(string saved, string attempt)
        {
            int[] a = Array.ConvertAll(saved.Split(','), int.Parse);
            int[] b = Array.ConvertAll(attempt.Split(','), int.Parse);
            bool close = true;
            for(int i = 0; i < a.Length; i++)
            {
                if ((Math.Abs((b[i]-a[i])/(double)a[i])) > 0.8)
                {
                    close = false;
                }
            }
            return close;
        }
    }
}
