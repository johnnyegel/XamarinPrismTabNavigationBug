using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace XamarinTestTabNav
{
    public class ViewBViewModel : BindableObject
    {
        private readonly INavigationService _navService;
        public string LabelTextBinding { get; } = "Testing View B Binding here";
        
        public DelegateCommand NavigationCommandBinding { get; }

        public ViewBViewModel(INavigationService navService)
        {
            _navService = navService;
            NavigationCommandBinding = new DelegateCommand(async () => await NavigateToView());
        }

        private async Task NavigateToView()
        {
            var result = await _navService.NavigateAsync(nameof(ViewD));
            Console.WriteLine($"[NAVIGATE]: {nameof(ViewBViewModel)}");
        }
    }
}