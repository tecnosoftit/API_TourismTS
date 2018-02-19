using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel.General;

namespace Services
{
    public class Security
    {
        private readonly General _ser = new General();
        private readonly TecnoTourismEntities _db = new TecnoTourismEntities();

        public User GetUser(string username, string password, string companyId)
        {
            try
            {
                var query = "EXEC SP_LOGIN '" + username + "', '" + password + "', '" + companyId + "'";
                return _db.Database.SqlQuery<User>(query).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Roles> GetRoles(string uId, string companyId)
        {
            try
            {
                var query = "EXEC SP_GETROLESPERUSER '" + uId + "', '" + companyId + "'";
                return _db.Database.SqlQuery<Roles>(query).ToList();
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
