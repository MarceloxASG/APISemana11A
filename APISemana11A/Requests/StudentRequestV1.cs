﻿using APISemana11A.Models;

namespace APISemana11A.Requests
{
    public class StudentRequestV1
    {
        public int GradeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}