using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniCh2MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EndPointsController : ControllerBase
    {
        [HttpGet("/sumEnd")]
        public string sumEnd(double a, double b){
            double sum = a + b;
              
             string result = "The sum of " + a + " and" + b + " is " + sum;
            return result; 
        }

        [HttpGet("/Time")]
        public string Time(string name, string time){
            string result = "Hello what is your name " + name + " and what time did you wake up " + " I woke up at " + time;

            return result;
        }

        [HttpGet("/greatOrLess")]
        public string greaterOrLess(int num1, int num2){
            string result;
    if(num1 > num2){
    result = num1 + " is greater than " + num2 + " and " + num2 + " is less than " + num1;
    }else if(num1 < num2) {
    result = num1 + " is less than " + num2 + " and " + num2 + " is greater than " + num1;
    }else {
    result = num1 + " is equal to " + num2 + " both numbers are equal";

    }
    return result;
        }

    }
}