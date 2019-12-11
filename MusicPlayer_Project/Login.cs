using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MusicPlayer_Project
{
    /*
     * Name:Mark Xie
     * Student Id:p447119
     * Date:11/11/2019
     * Programming III
     */
    public partial class Login : Form
    {
        //set mysql database to global
        private string connectionString = "server=127.0.0.1;uid=root;pwd=;database=musicplayer";
        private MySqlConnection connection = new MySqlConnection();
        private Hash Hasher = new Hash();

        public Login()
        {
            InitializeComponent();
        }
        //set visitor login
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MoeMusicPlayer();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //if both field are filled
            if (!string.IsNullOrEmpty(TextLoginUsername.Text) && !string.IsNullOrEmpty(textLoginPassword.Text))
            {
                try
                {
                    LbOutputLog.Items.Clear();
                    LbOutputLog.Items.Add("Validation Check");
                    string username = TextLoginUsername.Text;
                    //start database connection 
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    //select user 
                    string query = "SELECT `username`, `password`, `salt` FROM `users` WHERE `username`= @username";
                    MySqlCommand statement = new MySqlCommand(query, connection);
                    string password = textLoginPassword.Text;
                    statement.Parameters.AddWithValue("@username", username);
                    //Execute data
                    MySqlDataReader logInCheck = statement.ExecuteReader();
                    if (logInCheck.Read())
                    {
                        //read password and salt
                        string passwordValue = logInCheck.GetString("password");
                        string saltValue = logInCheck.GetString("salt");
                        //boolean statement for password match 
                        bool result = Hasher.IsPasswordMatch(password, saltValue, passwordValue);
                        if (result)
                        {   //if password match message box pop and close current form show next form
                            MessageBox.Show("Password Matched");
                            LoginInfo.UserName = username;
                            this.Hide();
                            var form2 = new MoeMusicPlayer();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                        }
                        else
                        {   //if password did not match
                            LbOutputLog.Items.Add("Password FAIL");
                        }
                    }
                    else//if username not found
                    {
                        MessageBox.Show("Username does not match");
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            //if username is not filled
            else if (string.IsNullOrEmpty(TextLoginUsername.Text) && !string.IsNullOrEmpty(textLoginPassword.Text))
            {
                MessageBox.Show("pelase enter your username,Try agian!");

            }
            //if password is not filled
            else if (!string.IsNullOrEmpty(TextLoginUsername.Text) && string.IsNullOrEmpty(textLoginPassword.Text))
            {
                MessageBox.Show("pelase enter your password,Try agian!");
            }
            else
            {
                MessageBox.Show("pelase enter your username and password,Try agian!");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //if username and password is filled
            if (!string.IsNullOrEmpty(textUsername.Text) && !string.IsNullOrEmpty(textpassword.Text))
            {
                //if user passowrd and confirm password field is correctly filled
                if (textpassword.Text == textConfirmPassword.Text)
                {
                    //check if database Ip is launched 
                    try
                    {
                        LbOutputLog.Items.Clear();
                        LbOutputLog.Items.Add("New User Created");
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        string username = textUsername.Text;
                        string password = textpassword.Text;
                        LbOutputLog.Items.Add("userid " + username);
                        string[] passwordHash = Hasher.GeneratePasswordHash(password).Split('|');
                        string query = "INSERT INTO `users`(`username`, `password`, `salt`) VALUES (@username,@password,@salt)";
                        MySqlCommand statement = new MySqlCommand(query, connection);
                        statement.Parameters.AddWithValue("@username", username);
                        statement.Parameters.AddWithValue("@password", passwordHash[0]);
                        statement.Parameters.AddWithValue("@salt", passwordHash[1]);
                        statement.ExecuteReader();
                        connection.Close();
                        LbOutputLog.Items.Add("password " + passwordHash[0]);
                        LbOutputLog.Items.Add("Salt " + passwordHash[1]);
                        MessageBox.Show(textUsername.Text + " Created Successfully.");
                        textUsername.Clear();
                        textpassword.Clear();
                        textConfirmPassword.Clear();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else//if passowrd and confirm password does not match
                {
                    MessageBox.Show("Password does not match");
                }
            }
            else//if user did not filling information in a correct format
            {
                MessageBox.Show("Please filling you information in a correct format.");
            }
        }
    }
}
