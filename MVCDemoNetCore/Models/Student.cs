﻿namespace MVCDemoNetCore.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public int GradeID { get; set; }
        public Grade Grade { get; set; }
    }
}
