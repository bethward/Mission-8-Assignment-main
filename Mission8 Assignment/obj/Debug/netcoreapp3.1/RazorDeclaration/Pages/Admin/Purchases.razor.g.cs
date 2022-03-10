// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/_Imports.razor"
using BookProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/bethanyward/Projects/Mission-8-Assignment-main/Mission8 Assignment/Pages/Admin/Purchases.razor"
       

    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllPurchases { get; set; }
    public IEnumerable<Purchase> UncollectedPurchases { get; set; }
    public IEnumerable<Purchase> CollectedPurchases { get; set;}

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllPurchases = await repo.Purchase.ToListAsync();
        UncollectedPurchases = AllPurchases.Where(x => !x.PurchaseReceived);
        CollectedPurchases = AllPurchases.Where(x => x.PurchaseReceived);
    }

    public void CollectPurchase(int id) => UpdatePurchase(id, true);
    public void ResetPurchase(int id) => UpdatePurchase(id, false);

    private void UpdatePurchase(int id, bool purchased)
    {
        Purchase p = repo.Purchase.FirstOrDefault(x => x.PurchaseId == id);
        p.PurchaseReceived = purchased;
        repo.SavePurchase(p);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
