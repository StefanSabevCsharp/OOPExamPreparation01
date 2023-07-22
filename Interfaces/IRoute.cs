using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Interfaces
{
    public interface IRoute
    {
        string StartPoint { get; }
        string EndPoint { get; }
        double Length { get; }
        int RouteId { get; }
        bool IsLocked { get; }
        void LockRoute();
    }
}
