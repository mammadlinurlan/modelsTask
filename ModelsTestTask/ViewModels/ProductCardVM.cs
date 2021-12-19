using System;
using System.Collections.Generic;
using ModelsTestTask.Models;

namespace ModelsTestTask.ViewModels
{
    public class ProductCardVM
    {
        public Product product { get; set; }
        public List<Card> cards { get; set; }
    }
}
