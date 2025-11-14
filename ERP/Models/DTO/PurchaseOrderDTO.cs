using System;
using System.Collections.Generic;

namespace ERP.Models.DTOs
{
    public class PurchaseOrderDTO
    {
        public HeaderDTO Header { get; set; }
        public List<DetailDTO> Details { get; set; }
    }

    public class HeaderDTO
    {
        public string Vendor { get; set; }
        public string Doctype { get; set; }
        public DateOnly Docdt { get; set; }
    }

    public class DetailDTO
    {
        public int Part { get; set; }
        public string Make { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public decimal Value => (Qty * Price) * (Discount / 100);
    }
}
