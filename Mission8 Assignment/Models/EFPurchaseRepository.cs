using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookProject.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookContext context;

        public EFPurchaseRepository(BookContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchase> Purchase => context.Purchase.Include(x => x.Lines).ThenInclude(x => x.Book); //Lines references line 17ish in Purchase.cs

        public void SavePurchase(Purchase purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.Purchase.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}

