using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.API.Filters
{
    public class ItemExistsAttribute : TypeFilterAttribute
    {
        public ItemExistsAttribute() : base(typeof(ItemExistsFilter))
        {
            //Bu attribute çağrıldığında, ItemExistsFilter nesnesine yönlendirilecek...
        }
    }
}
