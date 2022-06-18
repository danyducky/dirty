using Microsoft.AspNetCore.Mvc.Rendering;
using Openskill.Helpers.Enums;

namespace Openskill.Helpers.Html
{
    public static class HtmlExtensions
    {
        public static string IsActive(this IHtmlHelper helper, MenuItem? activeItem, MenuItem menuItem)
        {
            return activeItem == menuItem ? "active" : string.Empty;
        }

        public static string IsActive(this IHtmlHelper helper, AuthItem? activeItem, AuthItem authItem)
        {
            return activeItem == authItem ? "active" : string.Empty;
        }
    }
}
