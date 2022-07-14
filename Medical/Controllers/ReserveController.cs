﻿using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Controllers
{

    public class ReserveController : Controller
    {
        private readonly MedicalContext _context;

        public ReserveController(MedicalContext context)
        {
            _context = context;
        }
        // GET:各表的內容
        public IActionResult ReserveList()
        {
           
            CReserveforShowViewModel datas = null;      
                datas = new CReserveforShowViewModel()
                {
                    doctorsList = _context.Doctors.ToList(),
                    departmentList = _context.Departments.ToList(),
                    treatmentDetailList = _context.TreatmentDetails.ToList(),
                    clinicDetailList = _context.ClinicDetails.ToList(),
                    periodlist = _context.Periods.ToList(),
                    clinicRoomlist = _context.ClinicRooms.ToList()
                    
                    
                    
                };

            return View(datas);

        }

        public IActionResult ReserveResult(test result)
        {
           
            //int departmentId = _context.Departments.Where(a => a.DeptName == result.departmenttext).Select(a => a.DepartmentId).FirstOrDefault();
            int doctorId = _context.Doctors.Where(a => a.DoctorName == result.doctorname).Select(a => a.DoctorId).FirstOrDefault();
            //int treatmentDetailId = _context.TreatmentDetails.Where(a => a.TreatmentDetail1 == result.treatmentDetailtext).Select(a => a.TreatmentDetailId).FirstOrDefault(); ;

            //CReserveforShowViewModel datas = null;
            IEnumerable<ClinicDetail> list = _context.ClinicDetails.Where(a => a.DoctorId == doctorId);
            
            return Json(list);         
        }



        public IActionResult ReserveSearch(int?member =4)
        {
            ViewBag.name = _context.Reserves.Where(a => a.MemberId == member).Select(a => a.Member.MemberName).FirstOrDefault();
            var list = _context.Reserves.Where(a => a.MemberId == member)
                .Include(a => a.Member)
                .Include(a => a.State)
                .Include(a => a.Source)
                .Include(a=>a.ClinicDetail)
                .ThenInclude(a=>a.Doctor)               
                .ToList();
            return View(list); 

        }

        public IActionResult Delete(int reserveId)
        {
            Reserve result = new Reserve();
               result = _context.Reserves.FirstOrDefault(a => a.ReserveId == reserveId);
            if (result != null)
            {
                _context.Reserves.Remove(result);
                _context.SaveChanges();
            }

            return RedirectToAction("ReserveSearch");
        }


    }
}
