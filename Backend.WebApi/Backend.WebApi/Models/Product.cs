﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.WebApi.Models
{
    public class Product
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Category
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }
    }

    public class Review
    {
        public int Id
        {
            get; set;
        }

        public int ProductId
        {
            get; set;
        }

        public int Rating
        {
            get; set;
        }

        public string Text
        {
            get; set;
        }
    }

}