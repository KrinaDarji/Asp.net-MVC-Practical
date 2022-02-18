using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_10.Models
{
    /// <summary>
    /// User Class
    /// </summary>
    public class User
    {
        #region  properties
        /// <summary>
        /// get and set user ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// get and ser user name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// get and set user dob
        /// </summary>
        public string dob { get; set; }
        /// <summary>
        /// get and set address
        /// </summary>
        public string Address { get; set; }
        #endregion
    }
}