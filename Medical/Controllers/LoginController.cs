﻿using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Medical.Controllers
{
    public class LoginController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult AdminLoginMemberList()   //管理員帳號登入=>會員清單管理
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USE))  //TODO 還需要寫一個getSession(登出)/未驗證身分
            {
                MedicalContext medicalContext = new MedicalContext();
                //CMemberAdminViewModel vModel = new CMemberAdminViewModel();
                IEnumerable<Member> datas = null;

                datas = from t in medicalContext.Members
                        select t;

                return View(datas);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult LoginSuccess()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USE))
            {
                return RedirectToAction("LoginSuccess");   //已登入的證明
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            string jasonUser = "";
            //先設定email登入
            //Member mb = (new MedicalContext()).Members.FirstOrDefault(n => n.Email == vModel.txtAccount);
            Member mb = (new MedicalContext()).Members.FirstOrDefault(n => n.Email.Equals(vModel.txtAccount));  //linQ不分大小寫

            if (mb != null)
            {
                if (mb.Email.Equals(vModel.txtAccount) && mb.Password.Equals(vModel.txtPassword) && mb.Role == 1)
                {
                    //LogbySession(mb);
                    jasonUser = JsonSerializer.Serialize(mb);
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USE, jasonUser);
                    return RedirectToAction("Index", "Home");
                }
                else if (mb.Email.Equals(vModel.txtAccount) && mb.Password.Equals(vModel.txtPassword) && mb.Role == 2)
                {
                    jasonUser = JsonSerializer.Serialize(mb);
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USE, jasonUser);
                    return RedirectToAction("Index", "Home");
                }
                else if (mb.Email.Equals(vModel.txtAccount) && mb.Password.Equals(vModel.txtPassword) && mb.Role == 3)
                {
                    jasonUser = JsonSerializer.Serialize(mb);
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USE, jasonUser);
                    return RedirectToAction("Index", "Home",new {area="Admin" });
                }
            }
            //TODO 身分別登入不同頁面
            return View();
        }



        public IActionResult Register()
        {

            return View();
        }

        //[HttpPost]
        //public IActionResult Register(CRegisterViewModel vModel)  //Ver.1.0可用
        //{
        //    MedicalContext medicalDb = new MedicalContext();
        //    medicalDb.Members.Add(vModel.member);
        //    //Member m = medicalDb.Members.Where(n => n.Gender.GenderId == vModel.GenderId).FirstOrDefault();

        //    medicalDb.SaveChanges();
        //    return RedirectToAction("Index", "Home");
        //}
        [HttpPost]
        public IActionResult Register(CRegisterViewModel vModel)
        {
            MedicalContext medicalDb = new MedicalContext();
            medicalDb.Members.Add(vModel.member);
            //================================

            //MedicalContext medicalDb = new MedicalContext();
            ////IEnumerable<CRegisterViewModel> vModel = null;
            //var q = from c in medicalDb.Members
            //        join m in medicalDb.Cities on c.CityId equals m.CityId
            //        join n in medicalDb.Genders on c.GenderId equals n.GenderId
            //        select new CRegisterViewModel
            //        {
            //            IdentityId = c.IdentityId,
            //            Password = c.Password,
            //            MemberName = c.MemberName,
            //            BirthDay = c.BirthDay,
            //            GenderId = n.Gender1,
            //            Email = c.Email,
            //            Phone = c.Phone,
            //            Role = c.Role,
            //            CityId = c.CityId,
            //            Address = c.Address
            //        };
            //================================
            medicalDb.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int? id)
        {
            MedicalContext db = new MedicalContext();
            Member mem = db.Members.FirstOrDefault(c => c.MemberId == id);
            if (mem != null)
            {
                db.Members.Remove(mem);
                db.SaveChanges();
            }
            return RedirectToAction("AdminLoginMemberList", "Login");
        }


        public IActionResult Edit(int? id)
        {
            MedicalContext db = new MedicalContext();
            Member mem = db.Members.FirstOrDefault(c => c.MemberId == id);
            if (mem == null)
                return RedirectToAction("Index", "Home");
            return View(mem);
        }
        [HttpPost]
        public IActionResult Edit(Member p)
        {
            MedicalContext db = new MedicalContext();
            Member mem = db.Members.FirstOrDefault(c => c.MemberId == p.MemberId);
            if (mem != null)
            { 
                mem.IdentityId = p.IdentityId;   
                mem.Password = p.Password;
                mem.MemberName = p.MemberName;
                mem.BirthDay = p.BirthDay;
                mem.GenderId = p.GenderId;
                mem.BloodType = p.BloodType;
                mem.Weight = p.Weight;
                mem.IcCardNo = p.IcCardNo;
                mem.Phone = p.Phone;
                mem.Email = p.Email; 
                mem.Role = p.Role;
                mem.CityId = p.CityId;
                mem.Address = p.Address;


                db.SaveChanges();
            }
            return RedirectToAction("AdminLoginMemberList", "Login");
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USE))
            {

                HttpContext.Session.Remove(CDictionary.SK_LOGINED_USE);
                    return RedirectToAction("Index", "Home");
        
            }
            return RedirectToAction("Index", "Home");
        }


            }
}
