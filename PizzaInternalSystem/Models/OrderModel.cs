﻿using System;

namespace PizzaDataLibrary.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int Sum { get; set; }
        public DateTime OrderTime { get; set; }
        public int StatusId { get; set; }
        public string OrderContents { get; set; }
        public int EmployeeId { get; set; }
    }
}