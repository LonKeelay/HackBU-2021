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
                spaces TEXT NOT NULL,
                chances TEXT NOT NULL
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
            cmd.CommandText = $"INSERT INTO users(username, password, spaces, chances) VALUES('{username}', '{password}','{spaces}','6');";
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
                return -2;
            }
            string pass = fir.ToString();
            if (pass != password) {
                conn.Close();
                return -3;
            }
            cmd.CommandText = $"SELECT spaces FROM users WHERE username='{username.ToLower()}';";
            string spac = cmd.ExecuteScalar().ToString();
            if(similarEnough(spac, spaces))
            {
                cmd.CommandText = $"SELECT chances FROM users WHERE username='{username.ToLower()}';";
                int chance = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (chance >= 0) {
                    chance -= 1;
                    string chanceString = chance.ToString();
                    cmd.CommandText = $"UPDATE users SET chances = '{chanceString}' WHERE username='{username.ToLower()}';";
                    cmd.ExecuteScalar();
                }
                conn.Close();
                return chance;
            }
            else
            {
                conn.Close();
                return -4;
            }
        }

        private void dropTables()
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
                    return false;
                }
            }
            return true;
        }
    }
}
