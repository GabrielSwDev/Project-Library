//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Editorial
    {
        public Editorial()
        {
            this.Book = new HashSet<Book>();
        }
    
        public long Id_Editorial { get; set; }
        public string Editorial_Name { get; set; }
        public string Country { get; set; }
    
        public virtual ICollection<Book> Book { get; set; }
    }
}