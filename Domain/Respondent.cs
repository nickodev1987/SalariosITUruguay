//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Respondent
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int WorksFor { get; set; }
        public int Role { get; set; }
        public decimal Salary { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Position Position { get; set; }
    }
}
