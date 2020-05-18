using MedHelperAdmin;
using MedHelperLibrary.Models;
using MedHelperLibrary.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSystem
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void ErrorHandler(string message) 
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool cheked = false;
            string AuthorizationAccess = "";

            // Считываем данные с файла accaunt.txt, 
            // проверяем на соответствие
            using (UsersLoader UserData = new UsersLoader()) 
            {
                UserData.LoadError += ErrorHandler;
                UserData.Load();

                if (UserData.users != null)
                {
                    foreach (User us in UserData.users)
                    {
                        if (us.Login == login)
                            if (us.Password == password)
                            {
                                cheked = true;
                                AuthorizationAccess = us.Access;
                                break;
                            }
                    }
                }
            }

         

            ////Первый вариант
            //string AdminAppPath = @"\MedHelperAdmin\bin\Debug\MedHelperAdmin.exe";
            //string DoctorAppPath = @"";
            //bool check = true;

            //if (check)
            //{
            //    string path = new DirectoryInfo(@"..\..\..").FullName + AdminAppPath;
            //    Process.Start(path);
            //    Close();
            //}

            if (cheked && AuthorizationAccess == "Admin")   //Запускаем программу для администратора 
            {
                // Второй вариант
                AdminAppForm H = new AdminAppForm();
                this.Visible = false;
                H.ShowDialog();
                Close();
            }
            else if (cheked && AuthorizationAccess == "Doctor") { }
            else 
            {
                label3.Text = "Неверный логин или пароль. Пожайлуста, повторите попытку";
                label3.Visible = true;
            }
        }

        
    }
}
