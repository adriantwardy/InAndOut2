﻿using InAndOut2.Data;
using InAndOut2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut2.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
