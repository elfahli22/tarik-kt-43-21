﻿namespace tarik_kt_43_21.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int HeaderTeacherId {get; set;}
        public Teacher Teacher { get; set; }
    }
}
