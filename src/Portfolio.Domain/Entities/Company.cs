﻿using System;

namespace Portfolio.Domain.Entities
{
    public class Company
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }
        public string CompanyUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Order { get; set; }
    }
}
