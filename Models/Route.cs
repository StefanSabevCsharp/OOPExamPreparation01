using OOPExamPreparation01.Interfaces;
using OOPExamPreparation01.Interfaces.ExceptionMesseges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    public class Route : IRoute
    {
        string startPoint;
        string endPoint;
        double length;
        int routeId;
        bool isLocked;

        public Route(string startPoint, string endPoint, double length,int routeId)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Length = length;
            RouteId = routeId;
            IsLocked = false;
        }

        public string StartPoint
        {
            get
            {
                return this.startPoint;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(RouteExceptions.NullOrEmptyStartPoint);
                }
                this.startPoint = value;
            }
        }

        public string EndPoint
        {
            get => this.endPoint;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(RouteExceptions.NullOrEmptyEndPoint);
                }
                this.endPoint = value;
            }
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(RouteExceptions.InvalidRouteLength);
                }
                this.length = value;
            }
        }


        public int RouteId {get; private set;}

        public bool IsLocked {get; private set;}

        public void LockRoute()
        {
            IsLocked = true;
        }
    }
}
