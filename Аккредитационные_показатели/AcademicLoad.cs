//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Аккредитационные_показатели
{
    using System;
    using System.Collections.Generic;
    
    public partial class AcademicLoad
    {
        public int Code_academic { get; set; }
        public int Code_teacher { get; set; }
        public int Code_discipline { get; set; }
        public string NumberHours_academic { get; set; }
        public string BidShare_academic { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        public virtual Disciplines Disciplines { get; set; }
    }
}
