using HRleavemanagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRleavemanagement.Domain
{
    public class Leavetype : BaseDomainEntity
    {
        public int Id {  get; set; }
        public string Name { get; set; }    
        public int DefaultDays { get; set; }
        public DateTime Datecreated { get; set ; }
    }
}
