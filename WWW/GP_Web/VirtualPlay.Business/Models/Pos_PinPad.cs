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
    
    public partial class Pos_PinPad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pos_PinPad()
        {
            this.Sys_MerchantPinPad = new HashSet<Sys_MerchantPinPad>();
        }
    
        public int idPinPad { get; set; }
        public string dsSoftDescriptor { get; set; }
        public string dsSitefNumber { get; set; }
        public string dsPinpadInfo { get; set; }
        public string dsServerAddress { get; set; }
        public string dsServerPort { get; set; }
        public string cdSerial { get; set; }
        public string flProxyMode { get; set; }
        public string flStatus { get; set; }
        public Nullable<int> idUserCreate { get; set; }
        public System.DateTime dtCreate { get; set; }
        public Nullable<int> idUserLastUpdate { get; set; }
        public System.DateTime dtLastUpdate { get; set; }
    
        public virtual Sys_User Sys_User { get; set; }
        public virtual Sys_User Sys_User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_MerchantPinPad> Sys_MerchantPinPad { get; set; }
    }
}