﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvvmLight1.Model;

namespace AspNetCore_netFW.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _dataService;

        public HomeController(IDataService dataservice)
        {
            _dataService = dataservice;
        }


        public IActionResult Index()
        {
            return View();
        }


        //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-2.1
        public IActionResult About()/////////////[FromServices] IDataService _dataservice)
        {
            ViewData["Message"] = "Your application description page.";

            //_dataService.GetData(
            //(item, error) =>
            //{
            //    if (error != null)
            //    {
            //                    // Report error here
            //                    return;
            //    }

            //    ViewData["Message"] = item.Title;
            //});


            ViewData["Message2"] = "----------------------------------........";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
