using HRleavemanagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRleavemanagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int Id { get; set; } 
        public int NumberOfdays { get; set; }  
        public DateTime DateCreated { get; set; }
        public Leavetype LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int period { get; set; }
    }
}
