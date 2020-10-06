using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Windows.Forms;
using Newtonsoft.Json;
using Transcender.utils;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;

namespace Transcender
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Show_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Toggle.Checked)
            {
                Password_Field.UseSystemPasswordChar = false;
            }
            else
            {
                Password_Field.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void PasswordFieldHandler(object sender, EventArgs e)
        {
            Password_Field.UseSystemPasswordChar = true;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            DebugBox.Text = "";
            bool isValid = true;
            String user_input = User_Field.Text;
            String pass_input = Password_Field.Text;

            if(!FieldValidator.validateUser(user_input))
            {
                DebugBox.AppendText("\n*Username can only contain alphabet letters, 0-9, dot and underscore. No spaces allowed.\n");
                isValid = false;
            }

            if(!FieldValidator.validatePassword(pass_input))
            {
                DebugBox.AppendText("\n *Password can only contain alphabet letters, 0-9, and symbols ._/?!#$%^&*. No spaces allowed\n");
                isValid = false;
            }

            

            if (isValid)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("username", user_input);
                BsonDocument userDocument;
                try
                {
                    userDocument = Connector.collection.Find(filter).First();
                    dynamic userData = JObject.Parse(userDocument.ToString());

                    string password = userData["password"].ToString();
                    if (Tools.Decrypt(password) == pass_input)
                    {
                        MessageBox.Show("Succesfully Logged in");
                    }
                    else
                    {
                        MessageBox.Show("Invalid password");
                    }

                }
                catch
                {
                    MessageBox.Show("Username not found");
                }
            }
        }

        private void UsernameFieldHandler(object sender, EventArgs e)
        {
            
        }

        //On click disappear
        bool passwordClicked = false;
        private void Password_Field_Click(object sender, EventArgs e)
        {
            if (passwordClicked == false)
            {
                Password_Field.Text = String.Empty;
                passwordClicked = true;
            }
        }

        //On click disappear
        bool usernameClicked = false;
        private void User_Field_Click(object sender, EventArgs e)
        {
            if (usernameClicked == false)
            {
                User_Field.Text = String.Empty;
                usernameClicked = true;
            }
        }

        private void DebugBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
