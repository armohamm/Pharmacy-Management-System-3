//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Access
    {
        public User_Access()
        {
            this.User_Information = new HashSet<User_Information>();
        }
    
        public string Username { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }
    
        public virtual ICollection<User_Information> User_Information { get; set; }
    }
}
