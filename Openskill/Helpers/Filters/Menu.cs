using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Openskill.Helpers.Enums;

namespace Openskill.Helpers.Filters
{
    /// <summary>
    /// Menu item attribute.
    /// </summary>
    public class Menu : Attribute, IActionFilter
    {
        public static readonly string Key = "MenuItem";

        private readonly MenuItem? menuItem;

        public Menu(MenuItem menuItem)
        {
            this.menuItem = menuItem;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do nothing.
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;

            controller!.ViewData[Key] = menuItem ?? MenuItem.None;
        }
    }
}
