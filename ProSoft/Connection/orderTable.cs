//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProSoft.Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderTable
    {
        public int id_order { get; set; }
        public int id_user { get; set; }
        public int id_product { get; set; }
    
        public virtual productTable productTable { get; set; }
        public virtual userTable userTable { get; set; }
    }
}
