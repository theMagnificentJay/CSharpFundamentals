﻿using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok(); //200 (ok) status
            }

            return BadRequest(ModelState); // 400 Bad request
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products); // 200 (ok) Here's your list
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById([FromUri]int id)
        {
            Product product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
