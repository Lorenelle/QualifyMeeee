﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualifyMe.DomainModels
{
    public class StudentUser : QualifyMeDatabaseDbContext
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public int StudentID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Mobile { get; set; }
      


    }
}
