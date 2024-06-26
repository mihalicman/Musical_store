﻿namespace ShopWebsite.Shared.Models.DataTransferObjects
{
    public class OrderDetailsResponse
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetailsProductResponse> Products { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}
