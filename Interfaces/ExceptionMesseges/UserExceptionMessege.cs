using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Interfaces.ExceptionMesseges
{
    public class UserExceptionMessege : Exception
    {
        public const string NullOrEmptyUsername = "FirstName cannot be null or whitespace!";
        public const string NullOrEmptyLastname = "LastName cannot be null or whitespace!";
        public const string NullOrEmptyDrivingLicenseNumber = "Driving license number is required!";
    }
}
