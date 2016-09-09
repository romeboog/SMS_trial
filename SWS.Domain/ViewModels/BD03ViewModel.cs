using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.ViewModels
{
    //使用者主表
    public class BD03ViewModel_SM01DDL
    {
        public string user_org { get; set; }
        public string user_dept { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
        public bool usable { get; set; }
        public string user_mail { get; set; }
        public string user_tel { get; set; }

    }

    //使用者明細
    public class BD03AddModel
    {
        public string user_org { get; set; }
        public string user_dept { get; set; }
        public string user_id { get; set; }
        public string user_pwd { get; set; }
        public string user_name { get; set; }
        public string user_sex { get; set; }
        public string user_mail { get; set; }
        public string user_tel { get; set; }
        public int auth_type { get; set; }
        public bool usable { get; set; }
        public System.DateTime make_date { get; set; }
        public System.DateTime modify_date { get; set; }
        public string maker_id { get; set; }
    }
}
