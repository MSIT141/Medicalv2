﻿using Medical.Controllers;
using Medical.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.ViewModel
{
    public class CClinicDetailViewModel
    {

        private ClinicDetail _clinicDetail;

        public CClinicDetailViewModel()
        {
            _clinicDetail = new ClinicDetail();
        }
        public ClinicDetail clinicDetail
        {
            get { return _clinicDetail; }
            set { _clinicDetail = value; }
        }

        public int ClinicDetailId
        {
            get { return _clinicDetail.ClinicDetailId; }
            set { _clinicDetail.ClinicDetailId = value; }
        }
        public int? DoctorId
        {
            get { return _clinicDetail.DoctorId; }
            set { _clinicDetail.DoctorId = value; }
        }
        public int? DepartmentId
        {
            get { return _clinicDetail.DepartmentId; }
            set { _clinicDetail.DepartmentId = value; }
        }
        public int PeriodId
        {
            get { return _clinicDetail.PeriodId; }
            set { _clinicDetail.PeriodId = value; }
        }
        public int? Online
        {
            get { return _clinicDetail.Online; }
            set { _clinicDetail.Online = value; }
        }
        public int? RoomId
        {
            get { return _clinicDetail.RoomId; }
            set { _clinicDetail.RoomId = value; }
        }
        public string ClinicDate
        {
            get { return _clinicDetail.ClinicDate; }
            set { _clinicDetail.ClinicDate = value; }
        }
        [DisplayName("預約上限")]
        public int? LimitNum
        {
            get { return _clinicDetail.LimitNum; }
            set { _clinicDetail.LimitNum = value; }
        }

        public string doctor
        {
            set; get;
        }

        public int period
        {
            set; get;
        }

        public int room
        {
            set; get;
        }

        public string date
        {
            set; get;
        }

        public int id
        {
            set; get;
        }

        public virtual Department Department { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Period Period { get; set; }
        public virtual ClinicRoom Room { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }
    }
}
