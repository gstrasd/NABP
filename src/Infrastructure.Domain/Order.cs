using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class Order
    {
        public int UserLoginId { get; set; }
        public string UserName { get; set; }
        public Address Shipping { get; set; }
        public Payment Payment { get; set; }
    }

    public class Payment
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Cvv { get; set; }
        public Address BillingAddress { get; set; }
        public List<LineItem> OrderLineItems { get; set; }
        public decimal BalanceDue { get; set; }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string ZipOrPostalCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }

    public class LineItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }

    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Uom { get; set; }
        public bool IsPaymentCodeApplied { get; set; }
        public decimal? PaymentCodeDiscount { get; set; }
        public decimal ItemTotal { get; set; }
        public string PaymentCodeDiscountList { get; set; }
    }
}
