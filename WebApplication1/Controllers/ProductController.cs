using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitStore.Domain.Entities;
using FitStore.Domain.Abstract;
using WebApplication1.Models;
//using FitStore.WebUI.Models;


namespace FitStore.Controllers
{
    public class ProductController : Controller
    {
        // Kontroler pośredniczy miedzy rzeczami z model a widokiem.
        // Ten kontroler pobiera dane z klasy Product dzięki metdodom lub dzieki interfejsowi
        // IProductRepository. Tutaj mamy też wstrzykiwanie zależności poprzez konstruktor.

        private IProductRepository repository;

        public int PageSize = 4;

        public ProductController(IProductRepository rep)
        {
            this.repository = rep;
        }
        // Ta metoda List wygeneruje, wyrzuci z siebie widok zawierajacy pelna liste produktow.
        // Dzieje sie tak bo korzystamy z wlasciwosci interfejsu ktory ma zaimplementowany odpowieni getter.
        // Wywoływanie metody View bez podawania nazwy widoku informuje platforme ze powinna wygenerowac domyslny 
        // szablon widoku dla metody akcji. Przez przekazanie listy obiektow Product do metody View informujemy
        // platforme, ze wypelnilismy obiekt Model w widoku o scisle okreslonym typie.
        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? 
                    repository.Products.Count() :
                    repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}

