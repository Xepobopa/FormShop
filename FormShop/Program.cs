//<<<<<<< sign-in-form
using FormShop.Controller;
using FormShop.Model;
using FormShop.View;
//=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormShop.Controller;
using FormShop.Model;
//>>>>>>> main_functionality

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormController.Add(new SignIn());
            FormController.Add(new ManagerForm());
            FormController.Add(new UserForm());
            FormController.Add(new FailedForm());
            FormController.Add(new RegisterForm());
            FormController.SetErrorForm(new FailedForm());

            Application.Run(FormController.GetFirst());
        }
    }
}
            Application.Run(new StartForm());
        }
    }
}
