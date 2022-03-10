// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mission07.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 3 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Mission07.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Orders.razor"
       

    // bring in IPurchaseRespository
    public IPurchaseRepository repo => Service;

    // initialize variables
    public IEnumerable<Purchase> AllOrders { get; set; }
    public IEnumerable<Purchase> NotShippedOrders { get; set; }
    public IEnumerable<Purchase> ShippedOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Purchases.ToListAsync();
        NotShippedOrders = AllOrders.Where(x => !x.Shipped);
        ShippedOrders = AllOrders.Where(x => x.Shipped);
    }

    public void OrderShipped(int id) => UpdatePurchase(id, true);
    public void ResetShippedInfo(int id) => UpdatePurchase(id, false);

    private void UpdatePurchase(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.Shipped = shipped;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
