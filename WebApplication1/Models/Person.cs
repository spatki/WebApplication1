using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        public int ID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string Logo { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
    }
}