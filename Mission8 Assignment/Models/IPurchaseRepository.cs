using System;
using System.Linq;

namespace BookProject.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchase { get; }

        void SavePurchase(Purchase purchase);
    }
}
