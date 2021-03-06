//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreData.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CardPayments = new HashSet<CardPayment>();
            this.PizzaOrders = new HashSet<PizzaOrder>();
        }
    
        public int CustomerID { get; set; }
        public int NameID { get; set; }
        public int AddressID { get; set; }
        public int EmailID { get; set; }
        public int PhoneID { get; set; }
        public bool Active { get; set; }
    
        public virtual AddressDetail AddressDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardPayment> CardPayments { get; set; }
        public virtual Email Email { get; set; }
        public virtual Name Name { get; set; }
        public virtual Phone Phone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
    }
}
