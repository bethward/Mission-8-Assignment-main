using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookProject.Infrastructure;
using BookProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookProject.Pages
{
    public class CartModel : PageModel
    {
        private IBookRepository repo { get; set;}

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public CartModel (IBookRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? " /";
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int BookId, string returnUrl)
        {
            Book p = repo.Books.FirstOrDefault(x => x.BookId == BookId);
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(p, 1);

            //HttpContext.Session.SetJson("basket", basket);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookid, string returnurl)
        {
            //removeItem method is coming from basket.cs & inheritance
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookid).Book);

            return RedirectToPage(new {ReturnUrl = returnurl});
        }
    }
}
