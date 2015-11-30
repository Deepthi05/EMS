using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpEntity
{
  public  class EmpLeave
    {
        public int EmpId { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public string Descr { get; set; }
    }
}
