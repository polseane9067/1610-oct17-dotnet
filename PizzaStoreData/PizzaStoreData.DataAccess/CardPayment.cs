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
    
    public partial class CardPayment
    {
        public int CardPaymentID { get; set; }
        public int CustomerID { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public int ExpirationDate { get; set; }
        public int CVC { get; set; }
        public bool Active { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}