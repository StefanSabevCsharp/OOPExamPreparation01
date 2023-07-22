using OOPExamPreparation01.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    public class UserRepository : IRepository<IUser>
    {
        private List<IUser> users;
       
        public UserRepository()
        {
            this.users = new List<IUser>();
        }
        public void AddModel(IUser user)
        {
           users.Add(user);
        }

        public IUser FindById(string identifier)
        {
            IUser user = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            return user;
        }


        public bool RemoveById(string identifier)
        {
            IUser user = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            if (user == null)
            {
                return false;
            }
            users.Remove(user);
            return true;
           
        }
        public IReadOnlyCollection<IUser> GetAll()
        {
            return users.AsReadOnly();
        }

    
    }
}
