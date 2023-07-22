using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Interfaces.ExceptionMesseges
{
    public class VehicleExceptionMesseges : Exception

    {
        public const string NullOrEmptyBrand = "Brand cannot be null or whitespace!";
        public const string NullOrEmptyModel = "Model cannot be null or whitespace!";
        public const string NullOrEmptyLicensePlateNumber = "License plate number is required!";

    }
}
