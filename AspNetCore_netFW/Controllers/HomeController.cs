﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_netFW.Model;
using Microsoft.Extensions.Options;

namespace AspNetCore_netFW.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataItem _dataItem;
        //private readonly DataService _dataServ;
        private readonly IDataService _dataServ;

        //public HomeController(IOptions<DataItem> dataItem)
        //public HomeController(IOptions<DataService> dataServ)
        public HomeController(IDataService dataServ)
        {
            //_dataItem = dataItem.Value;
            //_dataServ = dataServ.Value;
            _dataServ = dataServ;
        }


        public IActionResult Index()
        {
            //ViewData["Title"] = _dataItem.Title;
            _dataServ.GetData(
            (item, error) =>
            {
                if (error != null)
                {
                    // Report error here
                    return;
                }
                ViewData["Title"] = item.Title;
            });

            return View();
        }

        public bool returnTrue()
        {
            return true;
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


            ViewData["Message2"] = "Message2-------------------........";

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
