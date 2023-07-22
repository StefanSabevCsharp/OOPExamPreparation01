using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPExamPreparation01.Interfaces
{
    public interface IUser
    {
         string FirstName { get;}
         string LastName { get;}
         string DrivingLicenseNumber { get;}

        double Rating { get; }
        bool IsBlocked { get; }
        void IncreaseRating();
        void DecreaseRating();

    }
}
