using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Represents a Product in ECommerce application
    /// </summary>
    public class Product
    {
        //Properties
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateOfManufactute { get; set; }


    }
}

namespace College
{ 
public class Student
    { 
        public int RollNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Branch branch { get; set; }
        public List<Examination> examinations { get; set; }
    }

    public class Branch
    {
        public string BranchName { get; set; }
        public int NumberOfSemesters { get; set; }
    }

    public class Examination
    {
        public string ExaminationName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Mark { get; set; }
        public int SecuredMark { get; set; }
    }

}
