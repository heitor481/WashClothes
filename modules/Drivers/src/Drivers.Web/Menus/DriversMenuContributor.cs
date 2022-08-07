using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Drivers.Web.Menus;

public class DriversMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(DriversMenus.Prefix, displayName: "Drivers", "~/Drivers", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
