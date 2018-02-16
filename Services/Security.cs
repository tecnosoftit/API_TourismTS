﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.General;

namespace Services
{
    public class Security
    {
        private readonly General _ser = new General();

        public User GetUser(string username, string password)
        {
            var pswd = _ser.GetMd5Password(password);
            return username.ToUpper().Equals("ADMIN") && password.ToUpper().Equals("ADMIN")
                ? new User
                {
                    Name = "pepito",
                    User_name = "Pepito",
                    UserLastname = "Prueba"
                }
                : null;
        }

        public List<Roles> GetRoles(string uId)
        {
            try
            {
                return new List<Roles>
                {
                    new Roles
                    {
                        Role = "ADMIN",
                        RoleId = 1,
                        RoleLevel = 100
                    }
                };
            }
            catch (Exception)
            {
                return new List<Roles>();
            }
        }

        public string ResetAccount(UserTransport user)
        {
            try
            {
                var password = _ser.CreateRandomPassword();
                var nPassword = _ser.GetMd5Password(password);
                return nPassword;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
