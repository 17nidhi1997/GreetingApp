using System;
using System.ComponentModel.DataAnnotations;


namespace GreetingAppCommannLayer
{
    public class GreetingModel 
    {
        private string firstName;
        private string lastName;
        private string emailId;
        private string password;
        private string mobileNumber;
        private string salary;
        [Key]
        public int EmployeeId
        {
            set; get;
        }
        [Required]
        [MaxLength(20)]
        public string FirstName
        {
            set
            {
                this.firstName = value;
            }
            get
            {
                return this.firstName;
            }
        }
        [Required]
        [MaxLength(20)]
        public string LastName
        {
            set
            {
                this.lastName = value;
            }
            get
            {
                return this.lastName;
            }
        }
        [Required]
        public string EmailId
        {
            set
            {
                this.emailId = value;
            }
            get
            {
                return this.emailId;
            }
        }
        [Required]
        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }
        [Required]
        [RegularExpression(@"^\d+$")]
        [MaxLength(11)]
        public string MobileNumber
        {
            set
            {
                this.mobileNumber = value;
            }
            get
            {
                return this.mobileNumber;
            }
        }
        [Required]
        public string Salary
        {
            set
            {
                this.salary = value;
            }
            get
            {
                return this.salary;
            }
        }
    }
}
