using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace WashClothes.Web.Pages;

public class IndexModel : WashClothesPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
