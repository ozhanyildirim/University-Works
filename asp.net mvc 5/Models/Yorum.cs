//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorum
    {
        public int YorumId { get; set; }
        public string Icerik { get; set; }
        public Nullable<int> Uyeıd { get; set; }
        public Nullable<int> ForumId { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Uye Uye { get; set; }
    }
}
