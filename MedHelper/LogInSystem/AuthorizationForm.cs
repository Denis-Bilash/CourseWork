using MedHelperAdmin;
using MedHelperLibrary.Models;
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
        Hospital hospital;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hospital = new Hospital();
            hospital.Load();                     // Загружаем данные в начеле роботы

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool cheked = false;
            string AuthorizationAccess = "";

            foreach (User us in hospital.Users) 
            {
                if (us.Login == login)
                    if (us.Password == password)
                    {
                        cheked = true;
                        AuthorizationAccess = us.Access;
                    }
            }

            textBox1.Text = hospital.Users[0].Login;
            textBox2.Text = hospital.Users[0].Password;

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
                AdminAppForm H = new AdminAppForm(hospital);
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
