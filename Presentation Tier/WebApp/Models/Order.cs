﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApp.Models;

namespace WebApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        
        public DateTime OrderDate { get; set; }
        public IList<BasketItem> Items { get; set; }
        [Required]
        public string InvoiceAddress { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public double DeliveryPrice { get; set; }
        [Required]
        public string Currency { get; set; }
        [JsonPropertyName("delivered")]
        public bool IsDelivered { get; set; }
        [JsonPropertyName("orderStatus")]
        public string Status { get; set; }
    }
}