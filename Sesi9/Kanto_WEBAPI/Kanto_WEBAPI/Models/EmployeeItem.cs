﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanto_WEBAPI.Models
{

    public class EmployeeItem
    {
        private Models.EmployeeContext context;

        public int id { get; set; }
        public string nama { get; set; }
        public string jeniskelamin { get; set; }
        public string alamat { get; set; }
    }
}
