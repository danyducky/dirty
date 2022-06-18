using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Openskill.Helpers.Enums;

namespace Openskill.Helpers.Filters
{
    public class AuthMenu : Attribute, IActionFilter
    {
        public static readonly string Key = "AuthItem";

        private readonly AuthItem authItem;

        public AuthMenu(AuthItem authItem)
        {
            this.authItem = authItem;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do nothing.
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;

            controller!.ViewData[Key] = authItem;
        }
    }
}
