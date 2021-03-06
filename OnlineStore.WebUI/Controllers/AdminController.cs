﻿using OnlineStore.Domain.Abstract;
using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.WebUI.Controllers
{
    [Authorize]   
    public class AdminController : Controller
    {
        IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View(repository.Products);
        }
        public ActionResult Edit(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
        public ActionResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deleteProduct = repository.DeleteProduct(productId);
            if (deleteProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted",deleteProduct.Name);
            }
            return RedirectToAction("Index");
        }        
    }
}