﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.ViewModels
{
    public class SM01ViewModel
    {
        public string year { get; set; }
        public string org { get; set; }
        public string dept { get; set; }
        public string soft_id { get; set; }
        public string soft_name { get; set; }
        public string user_id { get; set; }
        public string soft_type { get; set; }
        public string soft_sn { get; set; }
        public string soft_for { get; set; }
        public string soft_work_on { get; set; }
        public Nullable<int> soft_max_user { get; set; }
        public Nullable<int> soft_number { get; set; }
        public string soft_platform { get; set; }
        public string soft_from { get; set; }
        public string soft_from_unit { get; set; }
        public string soft_keeper { get; set; }
        public string soft_doc { get; set; }
        public Nullable<System.DateTime> install_date { get; set; }
        public string install_place { get; set; }
        public string memo { get; set; }
    }
    public class SMViewModel
    {
        public string year { get; set; }
        public string org { get; set; }
        public string dept { get; set; }
        public string soft_id { get; set; }
        public string soft_name { get; set; }
        public string user_id { get; set; }
        public string soft_type { get; set; }
        public string soft_sn { get; set; }
        public string soft_for { get; set; }
        public string soft_work_on { get; set; }
        public Nullable<int> soft_max_user { get; set; }
        public Nullable<int> soft_number { get; set; }
        public string soft_platform { get; set; }
        public string soft_from { get; set; }
        public string soft_from_unit { get; set; }
        public string soft_keeper { get; set; }
        public string soft_doc { get; set; }
        public Nullable<System.DateTime> install_date { get; set; }
        public string install_place { get; set; }
        public string memo { get; set; }
        public string detail_id { get; set; }
        public string keep_org { get; set; }
        public string keep_man { get; set; }
        public string use_org { get; set; }
        public string use_man { get; set; }
        public string soft_ver { get; set; }
        public Nullable<int> soft_cost { get; set; }
        public Nullable<int> auth_number { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string decrease_reason { get; set; }
        public string decrease_handle { get; set; }
        public string detail_memo { get; set; }
    }
}
