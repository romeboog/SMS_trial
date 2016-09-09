using SMS.Domain.ViewModels;
using SMS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL.Interfaces;
using SMS.Domain;

namespace SMS.BLL.Services
{
    public class LoginService
    {
        private IRepository<bd03_user> db;
        public LoginService()
        {
            db = new GenericRepository<bd03_user>();
        }
        private List<bd03_user> Getbd03()
        {
            List<bd03_user> result = db.Get().ToList();
            return result;
        }
        public bd03_user CheckUser(LoginViewModel model)
        {
            List<bd03_user> dbdatas = Getbd03();
            foreach(bd03_user dbdata in dbdatas)
            {
                if(dbdata.user_id.Trim() == model.user_id.Trim() && dbdata.user_pwd.Trim() == model.user_password.Trim() )
                {
                    return dbdata;
                }
            }
            return new bd03_user();
        }
        
    }
}
