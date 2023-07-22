using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Interfaces.ExceptionMesseges
{
    public class RouteExceptions : Exception
    {
        public const string NullOrEmptyStartPoint = "StartPoint cannot be null or whitespace!";
        public const string NullOrEmptyEndPoint = "EndPoint cannot be null or whitespace!";
        public const string InvalidRouteLength = "Length cannot be less than 1 kilometer.";
    }
}
