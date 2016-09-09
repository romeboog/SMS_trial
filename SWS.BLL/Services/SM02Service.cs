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
    public class SM02Service
    {
        private IRepository<sm02_soft_keep_detail> db;
        public SM02Service()
        {
            db = new GenericRepository<sm02_soft_keep_detail>();
        }        
        //public IQueryable<SM02ViewModel> Get()
        //{
        //    List<SM02ViewModel> model = new List<SM02ViewModel>();
        //    var dbresult = db.Get().AsQueryable();
        //    //TotalRow = db.Get().ToList().Count;
        //    //var dbresult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();
        //    foreach (var items in dbresult)
        //    {
        //        SM02ViewModel _model = new SM02ViewModel();
        //        _model.year = items.year.Trim();
        //        _model.org= items.org.Trim();
        //        _model.dept= items.dept.Trim();
        //        _model.soft_id= items.soft_id.Trim();
        //        _model.detail_id= items.detail_id.Trim();
        //        _model.keep_org= items.keep_org.Trim();
        //        _model.keep_man= items.keep_man.Trim();
        //        _model.use_org= items.use_org.Trim();
        //        _model.use_man= items.use_man.Trim();
        //        _model.soft_ver= items.use_man.Trim();
        //        _model.soft_cost= items.soft_cost;
        //        _model.auth_number= items.auth_number;
        //        _model.update_date= items.update_date;
        //        _model.decrease_reason= items.decrease_reason.Trim();
        //        _model.decrease_handle= items.decrease_handle.Trim();
        //        _model.detail_memo = items.detail_memo.Trim();
        //        model.Add(_model);
        //    }
        //    return model.AsQueryable();

        //}
        public SM02ViewModel Get(string year, string org, string dept, string soft_id,string detail_id )
        {
            List<SM02ViewModel> model = new List<SM02ViewModel>();
            //var dbresult = db.Get().AsQueryable();
            var dbresult = db.Get().ToList();
            //var result = dbresult.Find(year, org, dept, soft_id);
            int i = 0;
            bool isfound = false;
            sm02_soft_keep_detail result = new sm02_soft_keep_detail();

            while (i < dbresult.Count)
            {
                if (dbresult[i].year.Trim() == year && dbresult[i].org.Trim() == org && dbresult[i].dept.Trim() == dept && dbresult[i].soft_id.Trim() == soft_id && dbresult[i].detail_id == detail_id)
                {
                    result = dbresult[i];
                    isfound = true;
                }
                i++;
            }
            if (isfound)
            {
                SM02ViewModel _model = new SM02ViewModel();
                _model.org = result.org.Trim();
                _model.dept = result.dept.Trim();
                _model.soft_id = result.soft_id.Trim();
                _model.detail_id = result.detail_id.Trim();
                _model.keep_org = result.keep_org.Trim();
                _model.keep_man = result.keep_man.Trim();
                _model.use_org = result.use_org.Trim();
                _model.use_man = result.use_man.Trim();
                _model.soft_ver = result.use_man.Trim();
                _model.soft_cost = result.soft_cost;
                _model.auth_number = result.auth_number;
                _model.update_date = result.update_date;
                _model.decrease_reason = result.decrease_reason.Trim();
                _model.decrease_handle = result.decrease_handle.Trim();
                _model.detail_memo = result.detail_memo.Trim();
                model.Add(_model);
                return _model;
            }
            else
                return new SM02ViewModel();
        }
        public IQueryable<SM02ViewModel> Get(string year,string org, string dept, string soft_id)
        {
            List<SM02ViewModel> model = new List<SM02ViewModel>();
            var dbresult = db.Get().AsQueryable();
            //TotalRow = db.Get().ToList().Count;
            //var dbresult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();
            dbresult = dbresult.Where(r => r.org == org && r.dept == dept && r.soft_id == soft_id && r.year == year);
            foreach (var items in dbresult)
            {
                SM02ViewModel _model = new SM02ViewModel();
                _model.year = items.year.Trim();
                _model.org = items.org.Trim();
                _model.dept = items.dept.Trim();
                _model.soft_id = items.soft_id.Trim();
                _model.detail_id = items.detail_id.Trim();
                _model.keep_org = items.keep_org.Trim();
                _model.keep_man = items.keep_man.Trim();
                _model.use_org = items.use_org.Trim();
                _model.use_man = items.use_man.Trim();
                _model.soft_ver = items.use_man.Trim();
                _model.soft_cost = items.soft_cost;
                _model.auth_number = items.auth_number;
                _model.update_date = items.update_date;
                _model.decrease_reason = items.decrease_reason.Trim();
                _model.decrease_handle = items.decrease_handle.Trim();
                _model.detail_memo = items.detail_memo.Trim();
                model.Add(_model);
            }
            return model.AsQueryable();

        }
        private sm02_soft_keep_detail SM02VMtoM(SM02ViewModel viewmodel)
        {
            sm02_soft_keep_detail _model = new sm02_soft_keep_detail();
            _model.year = viewmodel.year.Trim();
            _model.org = viewmodel.org.Trim();
            _model.dept = viewmodel.dept.Trim();
            _model.soft_id = viewmodel.soft_id.Trim();
            _model.detail_id = viewmodel.detail_id.Trim();
            _model.keep_org = viewmodel.keep_org.Trim();
            _model.keep_man = viewmodel.keep_man.Trim();
            _model.use_org = viewmodel.use_org.Trim();
            _model.use_man = viewmodel.use_man.Trim();
            _model.soft_ver = viewmodel.use_man.Trim();
            _model.soft_cost = viewmodel.soft_cost;
            _model.auth_number = viewmodel.auth_number;
            _model.update_date = viewmodel.update_date;
            _model.decrease_reason = viewmodel.decrease_reason.Trim();
            _model.decrease_handle = viewmodel.decrease_handle.Trim();
            _model.detail_memo = viewmodel.detail_memo.Trim();
            return _model;
        }

        public void addSM02(SM02ViewModel viewmodel)
        {
            sm02_soft_keep_detail _model = SM02VMtoM(viewmodel);
            db.Insert(_model);
        }
        public void saveSM02(SM02ViewModel viewmodel)
        {
            sm02_soft_keep_detail _model = SM02VMtoM(viewmodel);
            db.Update(_model);
        }
        public void deleteSM02(string year, string org, string dept, string soft_id)
        {
            var sm02 = db.GetByID(year, org, dept, soft_id);
            db.Delete(sm02);
        }
        //public List<SM01_GetUsableOrg_Result> {}
    }
}
