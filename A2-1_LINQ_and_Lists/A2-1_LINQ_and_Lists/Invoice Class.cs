using System;
using System.Collections.Generic;

namespace A2_1_LINQ_and_Lists
{
    // Exercise 9.3 Solution: Invoice.cs
    // Invoice class.
    public class Invoice
    {
        // declare variables for Invoice object
        private int quantityValue;
        private decimal priceValue;

        // auto-implemented property PartNumber
        public int PartNumber { get; set; }

        // auto-implemented property PartDescription
        public string PartDescription { get; set; }

        // four-argument constructor
        public Invoice(int part, string description,
           int count, decimal pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            Price = pricePerItem;
        }

        // property for quantityValue; ensures value is positive
        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if (value > 0) // determine whether quantity is positive
                {
                    quantityValue = value; // valid quantity assigned
                }
            }
        }

        // property for pricePerItemValue; ensures value is positive
        public decimal Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0M) // determine whether price is non-negative
                {
                    priceValue = value; // valid price assigned
                }
            }
        }

        // return string containing the fields in the Invoice in a nice format
        public override string ToString()
        {
            // left justify each field, and give large enough spaces so
            // all the columns line up
            return $"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}";
        }
        
    }

    public class List
    {
        public static List<Invoice> invoice = new List<Invoice>()
        {
        invoice.Add(new Invoice {PartNumber = 83, PartDescription = "Electric Sander", Quantity = 7, Price = 57.98M})

        }
    }
}
