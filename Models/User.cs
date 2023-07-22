using OOPExamPreparation01.Interfaces;
using OOPExamPreparation01.Interfaces.ExceptionMesseges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPExamPreparation01.Models
{
    public class User : IUser
    {
        private string firstname;
        private string lastname;
        private string drivinglicensenumber;
        private double rating;
        private bool isblocked;

        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DrivingLicenseNumber = drivingLicenseNumber;
            isblocked = false;
        }

        public string FirstName
        { 
            get => this.firstname;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(UserExceptionMessege.NullOrEmptyUsername);
                }
                this.firstname = value;
            }
        }

        public string LastName
        {
            get => this.lastname;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(UserExceptionMessege.NullOrEmptyLastname);
                }
                this.lastname = value;
            }
        }

        public string DrivingLicenseNumber
        {
            get => this.drivinglicensenumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(UserExceptionMessege.NullOrEmptyDrivingLicenseNumber);
                }
                this.drivinglicensenumber = value;
            }
        }

        public double Rating {get;private set;}
        public bool IsBlocked { get; private set; }

        public void DecreaseRating()   //TO Do
        {
            throw new NotImplementedException();
        }

        public void IncreaseRating()    //TO Do
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} Driving license: {DrivingLicenseNumber} Rating: {rating}";
        }
    }
}
