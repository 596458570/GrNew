//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gr.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpAtten
    {
        public int id { get; set; }
        public int EmpId { get; set; }
        public int AttendanceId { get; set; }
        public string Status { get; set; }
    
        public virtual Attendance Attendance { get; set; }
        public virtual Emp Emp { get; set; }
    }
}