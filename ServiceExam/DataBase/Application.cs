//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceExam.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int IDApplication { get; set; }
        public string ClientName { get; set; }
        public string PhoneClient { get; set; }
        public Nullable<int> SerType { get; set; }
        public Nullable<int> MasterService { get; set; }
        public Nullable<System.DateTime> DateRecord { get; set; }
    
        public virtual UserService UserService { get; set; }
        public virtual TypeService TypeService { get; set; }
    }
}
