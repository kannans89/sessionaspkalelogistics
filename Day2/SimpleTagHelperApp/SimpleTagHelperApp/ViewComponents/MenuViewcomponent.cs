using Microsoft.AspNetCore.Mvc;

namespace SimpleTagHelperApp.ViewComponents
{
    public class Menu { 
    
        public string Text { get; set; }
        public bool IsSelected { get; set; }
        public string Url { get; set; }
    
    }

    public class MenuViewcomponent:ViewComponent
    {
        private List<Menu> _items;
        public MenuViewcomponent() { 
           // Repository layer inject
         
        }

        public async Task<IViewComponentResult> InvokeAsync(int selectIndexNo) {
            _items = new List<Menu>() { 
              new Menu(){Text="Home",Url="/",IsSelected=(0==selectIndexNo) },
              new Menu(){ Text="About",Url="/About",IsSelected=(1==selectIndexNo) },
              new Menu(){Text="Contact",Url="/Contact",IsSelected=(2==selectIndexNo) }
            
            };

            return View(_items);
        }

    }
}
