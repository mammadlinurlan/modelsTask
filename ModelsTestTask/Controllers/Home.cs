using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ModelsTestTask.Models;
using ModelsTestTask.ViewModels;

namespace ModelsTestTask.Controllers
{
    public class Home:Controller
    {

        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {

                new Product()
                {
                    id= 1,
                    name= "iPhone xs",
                    size = "5.6 inch",
                    color= "gold"

                   
                },


                new Product()
                {
                    id= 2,
                    name= "iPhone 11",
                    size = "6.1 inch",
                    color= "white"


                }
                ,

                new Product()
                {
                    id= 3,
                    name= "iPhone 12 pro",
                    size = "5.6 inch",
                    color= "pasific blue"


                },

                new Product()
                {
                    id= 4,
                    name= "iPhone 13 pro max",
                    size = "6.5 inch",
                    color= "black"


                }





            };



            return View(products);

        }


        public ActionResult Detail()
        {

            List<Card> cards = new List<Card>
            {
                new Card()
                {
                 id=1,
                 name="kapital bank",
                 cvc=612,
                  expDate="12/2024"
                },
                new Card()
                {
                 id=1,
                 name="pasha bank",
                 cvc=222,
                  expDate="12/2024"
                },
                new Card()
                {
                 id=1,
                 name="leo bank",
                 cvc=142,
                  expDate="12/2024"
                }
            };

           Product prod =  new Product()
            {
                id = 1,
                name = "iPhone xs",
                size = "5.6 inch",
                color = "gold"


            };


            ProductCardVM details = new ProductCardVM
            {
                 cards = cards,
                  product= prod
            };


            return View(details);
        }


    }
}
