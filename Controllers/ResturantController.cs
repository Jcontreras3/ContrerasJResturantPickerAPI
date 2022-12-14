//Jovann Contreras
//Date 10/27/2022
//Peer reviewed by: Madeline Gowan - The code runs as intended. I like the use of Models, especially since we just learned them! And I like the categories--having vague terms like dessert and fast food allows more options, wheras I went a bit more specific with coffee, pizza, etc. Good work!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResturantPick.Models;

namespace ContrerasJResturantPickerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResturantController : ControllerBase
    {

        [HttpGet]
        [Route("ResturantPick")]

        public string ResturantPickerChallenge(ResturantPickModel item)
        {
            string[] randomRes = { "Burger King", "MCdonald", "Chicfila", "Wendys", "Shirisoni", "Carls Jr.", "Jack in the box", "Payters", "BJ's", "Chilli's" };
            string[] fastFood = { "Mcdonalds", "Burger King", "Subway", "Carls.Jr", "Wendy's", "Philly CheeseStake", "Jack in box", "Canes", "Chic Fil a", "PopEyes" };
            string[] dessert = { "Basken Robins", "DF DONUTS & Coffee", "Dream Ice Cream Parlor", "Milk and Dream", "Bambu Desserts & Drinks", "Cold Stone Creamery", "Yogurtland", "85C Bakery Cafe", "Tigers Yogurt", "Start Donuts" };

            
            Random randomplace = new Random();
            int res = randomplace.Next(0, 10);
            string test = "";
            if(item.rndFood.ToLower() == "random")
            {
               test = randomRes[res];
            }
           else if(item.rndFood.ToLower() == "dessert")
            {
               test = dessert[res];
            }
          else if(item.rndFood.ToLower() == "fastfood")
            {
               test = fastFood[res];
            }

            return test;
        }

    }
}