//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualPlay.Business.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sys_File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_File()
        {
            this.Ent_Document = new HashSet<Ent_Document>();
            this.Per_Document = new HashSet<Per_Document>();
        }
    
        public int idFile { get; set; }
        public string nmFile { get; set; }
        public string dsPath { get; set; }
        public int idUserCreate { get; set; }
        public System.DateTime dtCreate { get; set; }
        public int idUserLastUpdate { get; set; }
        public System.DateTime dtLastUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ent_Document> Ent_Document { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Per_Document> Per_Document { get; set; }
        public virtual Sys_User Sys_User { get; set; }
        public virtual Sys_User Sys_User1 { get; set; }
    }
}