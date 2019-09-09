using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public class ReportEODVM
    {
        public Game topGame { get; set; }
        // public string topGame { get; set; }

        public List<Member> newMembers { get; set; }
        
       /* public ReportEODVM()
        {
               NewMembers =  new List<Member>();
        }
        */
    }
}