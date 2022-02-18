using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical10_Partial.Models
{

    public class Repository
    {
        /// <summary>
        /// list of user details
        /// </summary>
        private static List<User> alluser = new List<User>() { new User()
        {
            ID = 1,
            Name="Krina",
            dob="25/05/2001",
            Address="Khambhat",
        }

        };
        /// <summary>
        /// return user
        /// </summary>
        public static IEnumerable<User> AllUser
        {
            get { return alluser; }
        }
        /// <summary>
        /// add to list 
        /// </summary>
        /// <param name="user"></param>
        public void add(User user)
        {
            alluser.Add(user);
        }
        /// <summary>
        /// details of user
        /// </summary>
        /// <param name="id"></param>
        /// <returns> all user</returns>
        public User Details(int id)
        {
            return alluser.FirstOrDefault(r => r.ID == id);
        }
        /// <summary>
        /// remove user
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var u = Get(id);
            alluser.Remove(u);
        }
        /// <summary>
        /// edit user
        /// </summary>
        /// <param name="user"></param>
        public void Edit(User user)
        {

            var existing = Get(user.ID);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.dob = user.dob;
                existing.Address = user.Address;
            }

        }
        /// <summary>
        /// get id for user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>user id</returns>
        public User Get(int id)
        {
            return alluser.FirstOrDefault(r => r.ID == id);
        }
    }
}