//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvtoDelo_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_to_complect
    {
        public int id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> complect_id { get; set; }
    
        public virtual complects complects { get; set; }
        public virtual products products { get; set; }
    }
}
