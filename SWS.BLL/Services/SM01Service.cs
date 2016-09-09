using SMS.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Domain.ViewModels;
using SMS.Domain;
using SMS.DAL;
using SMS.DAL.Repository;

namespace SMS.BLL.Services
{
    public class SM01Service
    {
        private IRepository<sm01_soft_keep_main> db;
        public SM01Service()
        {
            db = new GenericRepository<sm01_soft_keep_main>();
        }        
        //public IQueryable<SM01ViewModel> Get(int CurrPage, int PageSize, out int TotalRow)
        //{
        //    List<SM01ViewModel> model = new List<SM01ViewModel>();
        //    //var dbresult = db.Get().AsQueryable();
        //    var dbresult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();
        //    TotalRow = db.Get().Count();
        //    foreach(var items in dbresult)
        //    {
        //        SM01ViewModel _model = new SM01ViewModel();
        //        _model.year = items.year;
        //        _model.org = items.org;
        //        _model.dept = items.dept;
        //        _model.soft_id = items.soft_id;
        //        _model.soft_name = items.soft_name;
        //        _model.user_id = items.user_id;
        //        _model.soft_type = items.soft_type;
        //        _model.soft_sn = items.soft_sn;
        //        _model.soft_for = items.soft_for;
        //        _model.soft_work_on = items.soft_work_on;
        //        _model.soft_max_user = items.soft_max_user;
        //        _model.soft_number = items.soft_number;
        //        _model.soft_platform = items.soft_platform;
        //        _model.soft_from = items.soft_from;
        //        _model.soft_from_unit = items.soft_from_unit;
        //        _model.soft_keeper = items.soft_keeper;
        //        _model.soft_doc = items.soft_doc;
        //        _model.install_date = items.install_date;
        //        _model.install_place = items.install_place;
        //        _model.memo = items.memo;
        //        model.Add(_model);
        //    }
        //    return model.AsQueryable();
            
        //}
        public IQueryable<SM01ViewModel> Get(int CurrPage, int PageSize, out int TotalRow)
        {
            List<SM01ViewModel> model = new List<SM01ViewModel>();
            //var dbresult = db.Get().AsQueryable();
            TotalRow = db.Get().ToList().Count;
            var dbresult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();
            foreach (var items in dbresult)
            {
                SM01ViewModel _model = new SM01ViewModel();
                _model.year = items.year.Trim();
                _model.org = items.org.Trim();
                _model.dept = items.dept.Trim();
                _model.soft_id = items.soft_id.Trim();
                _model.soft_name = items.soft_name.Trim();
                _model.user_id = items.user_id.Trim();
                _model.soft_type = items.soft_type.Trim();
                _model.soft_sn = items.soft_sn.Trim();
                _model.soft_for = items.soft_for.Trim();
                _model.soft_work_on = items.soft_work_on.Trim();
                _model.soft_max_user = items.soft_max_user;
                _model.soft_number = items.soft_number;
                _model.soft_platform = items.soft_platform.Trim();
                _model.soft_from = items.soft_from.Trim();
                _model.soft_from_unit = items.soft_from_unit.Trim();
                _model.soft_keeper = items.soft_keeper.Trim();
                _model.soft_doc = items.soft_doc.Trim();
                _model.install_date = items.install_date;
                _model.install_place = items.install_place.Trim();
                _model.memo = items.memo.Trim();
                model.Add(_model);
            }
            return model.AsQueryable();

        }
        public IQueryable<SM01ViewModel> Get()
        {
            List<SM01ViewModel> model = new List<SM01ViewModel>();
            var dbresult = db.Get().AsQueryable();
            //TotalRow = db.Get().ToList().Count;
            //var dbresult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();
            foreach (var items in dbresult)
            {
                SM01ViewModel _model = new SM01ViewModel();
                _model.year = items.year.Trim();
                _model.org = items.org.Trim();
                _model.dept = items.dept.Trim();
                _model.soft_id = items.soft_id.Trim();
                _model.soft_name = items.soft_name.Trim();
                _model.user_id = items.user_id.Trim();
                _model.soft_type = items.soft_type.Trim();
                _model.soft_sn = items.soft_sn.Trim();
                _model.soft_for = items.soft_for.Trim();
                _model.soft_work_on = items.soft_work_on.Trim();
                _model.soft_max_user = items.soft_max_user;
                _model.soft_number = items.soft_number;
                _model.soft_platform = items.soft_platform.Trim();
                _model.soft_from = items.soft_from.Trim();
                _model.soft_from_unit = items.soft_from_unit.Trim();
                _model.soft_keeper = items.soft_keeper.Trim();
                _model.soft_doc = items.soft_doc.Trim();
                _model.install_date = items.install_date;
                _model.install_place = items.install_place.Trim();
                _model.memo = items.memo.Trim();
                model.Add(_model);
            }
            return model.AsQueryable();

        }
        public SM01ViewModel Get(string year,string org, string dept, string soft_id)
        {
            List<SM01ViewModel> model = new List<SM01ViewModel>();
            //var dbresult = db.Get().AsQueryable();
            var dbresult = db.Get().ToList();
            //var result = dbresult.Find(year, org, dept, soft_id);
            int i = 0;
            bool isfound = false;
            sm01_soft_keep_main result = new sm01_soft_keep_main();
            
            while ( i < dbresult.Count)
            {
                if (dbresult[i].year.Trim() == year && dbresult[i].org.Trim() == org && dbresult[i].dept.Trim() == dept && dbresult[i].soft_id.Trim() == soft_id)
                {
                    result = dbresult[i];
                    isfound = true;
                }
                i++;
            }
            if (isfound)
            {
                SM01ViewModel _model = new SM01ViewModel();
                _model.year = result.year.Trim();
                _model.org = result.org.Trim();
                _model.dept = result.dept.Trim();
                _model.soft_id = result.soft_id.Trim();
                _model.soft_name = result.soft_name.Trim();
                _model.user_id = result.user_id.Trim();
                _model.soft_type = result.soft_type.Trim();
                _model.soft_sn = result.soft_sn.Trim();
                _model.soft_for = result.soft_for.Trim();
                _model.soft_work_on = result.soft_work_on.Trim();
                _model.soft_max_user = result.soft_max_user;
                _model.soft_number = result.soft_number;
                _model.soft_platform = result.soft_platform.Trim();
                _model.soft_from = result.soft_from.Trim();
                _model.soft_from_unit = result.soft_from_unit.Trim();
                _model.soft_keeper = result.soft_keeper.Trim();
                _model.soft_doc = result.soft_doc.Trim();
                _model.install_date = result.install_date;
                _model.install_place = result.install_place.Trim();
                _model.memo = result.memo.Trim();
                model.Add(_model);
                return _model;
            }
            else
                return new SM01ViewModel();
        }
        private sm01_soft_keep_main SM01VMtoM(SM01ViewModel viewmodel)
        {
            sm01_soft_keep_main _model = new sm01_soft_keep_main();
            _model.year = viewmodel.year;
            _model.org = viewmodel.org;
            _model.dept = viewmodel.dept;
            _model.soft_id = viewmodel.soft_id;
            _model.soft_name = viewmodel.soft_name;
            _model.user_id = viewmodel.user_id;
            _model.soft_type = viewmodel.soft_type;
            _model.soft_sn = viewmodel.soft_sn;
            _model.soft_for = viewmodel.soft_for;
            _model.soft_work_on = viewmodel.soft_work_on;
            _model.soft_max_user = viewmodel.soft_max_user;
            _model.soft_number = viewmodel.soft_number;
            _model.soft_platform = viewmodel.soft_platform;
            _model.soft_from = viewmodel.soft_from;
            _model.soft_from_unit = viewmodel.soft_from_unit;
            _model.soft_keeper = viewmodel.soft_keeper;
            _model.soft_doc = viewmodel.soft_doc;
            _model.install_date = viewmodel.install_date;
            _model.install_place = viewmodel.install_place;
            _model.memo = viewmodel.memo;
            return _model;
        }
        private sm02_soft_keep_detail SM02VMtoM(SM02ViewModel items)
        {
            sm02_soft_keep_detail _model = new sm02_soft_keep_detail();
            _model.year = items.year.Trim();
            _model.org = items.org.Trim();
            _model.dept = items.dept.Trim();
            _model.soft_id = items.soft_id.Trim();
            _model.detail_id = items.detail_id;
            _model.keep_org = items.keep_org;
            _model.keep_man = items.keep_man;
            _model.use_org = items.use_org;
            _model.use_man = items.use_man;
            _model.soft_ver = items.soft_ver;
            _model.soft_cost = items.soft_cost;
            _model.auth_number = items.auth_number;
            _model.update_date = items.update_date;
            _model.decrease_reason = items.decrease_reason;
            _model.decrease_handle = items.decrease_handle;
            _model.detail_memo = items.detail_memo;
            return _model;
        }
        private SM01ViewModel SMVMtoSM01VM(SMViewModel items)
        {
            SM01ViewModel _model = new SM01ViewModel();
            _model.year = items.year.Trim();
            _model.org = items.org.Trim();
            _model.dept = items.dept.Trim();
            _model.soft_id = items.soft_id.Trim();
            _model.soft_name = items.soft_name.Trim();
            _model.user_id = items.user_id.Trim();
            _model.soft_type = items.soft_type.Trim();
            _model.soft_sn = items.soft_sn.Trim();
            _model.soft_for = items.soft_for.Trim();
            _model.soft_work_on = items.soft_work_on.Trim();
            _model.soft_max_user = items.soft_max_user;
            _model.soft_number = items.soft_number;
            _model.soft_platform = items.soft_platform.Trim();
            _model.soft_from = items.soft_from.Trim();
            _model.soft_from_unit = items.soft_from_unit.Trim();
            _model.soft_keeper = items.soft_keeper.Trim();
            _model.soft_doc = items.soft_doc.Trim();
            _model.install_date = items.install_date;
            _model.install_place = items.install_place.Trim();
            _model.memo = items.memo.Trim();
            return _model;
        }
        private SM02ViewModel SMVMtoSM02VM(SMViewModel items)
        {
            SM02ViewModel _model = new SM02ViewModel();
            _model.year = items.year.Trim();
            _model.org = items.org.Trim();
            _model.dept = items.dept.Trim();
            _model.soft_id = items.soft_id.Trim();
            _model.detail_id = items.detail_id;
            _model.keep_org = items.keep_org;
            _model.keep_man = items.keep_man;
            _model.use_org = items.use_org;
            _model.use_man = items.use_man;
            _model.soft_ver = items.soft_ver;
            _model.soft_cost = items.soft_cost;
            _model.auth_number = items.auth_number;
            _model.update_date = items.update_date;
            _model.decrease_reason = items.decrease_reason;
            _model.decrease_handle = items.decrease_handle;
            _model.detail_memo = items.detail_memo;
            return _model;
        }

        //private sm02_soft_keep_detail SM01VMtoSM02VM(SM01ViewModel viewmodel)
        //{
        //    sm02_soft_keep_detail _model = new sm02_soft_keep_detail();
        //    _model.year = viewmodel.year;
        //    _model.org = viewmodel.org;
        //    _model.dept = viewmodel.dept;
        //    _model.soft_id = viewmodel.soft_id;
        //    _model.keep_org = "";
        //    return _model;
        //}

        public void addSM01(SMViewModel viewmodel)
        {
            IRepository<sm02_soft_keep_detail> db2 = new GenericRepository<sm02_soft_keep_detail>();
            SM01ViewModel SM01VM = SMVMtoSM01VM(viewmodel);
            SM02ViewModel SM02VM = SMVMtoSM02VM(viewmodel);
            sm01_soft_keep_main _SM01model = SM01VMtoM(SM01VM);
            sm02_soft_keep_detail _SM02model = SM02VMtoM(SM02VM);
            db.Insert(_SM01model);
            db2.Insert(_SM02model);
        }
        public void saveSM01(SM01ViewModel viewmodel)
        {
            sm01_soft_keep_main _model = SM01VMtoM(viewmodel);
            db.Update(_model);
        }
        public void deleteSM01(string year, string org, string dept, string soft_id)
        {
            var sm01 = db.GetByID(year, org, dept, soft_id);
            db.Delete(sm01);
        }
        //public List<SM01_GetUsableOrg_Result> {}
    }
}
