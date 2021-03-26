using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace XamarinTestTabNav
{
    public class ViewAViewModel : BindableObject
    {
        private readonly INavigationService _navService;
        public string LabelTextBinding { get; } = "Testing View A binding here";
        
        public DelegateCommand NavigationCommandBinding { get; }

        public ViewAViewModel(INavigationService navService)
        {
            _navService = navService;
            NavigationCommandBinding = new DelegateCommand(async () => await NavigateToView());
        }

        private async Task NavigateToView()
        {
            var result = await _navService.NavigateAsync(nameof(ViewC));
            Console.WriteLine($"[NAVIGATE]: {nameof(ViewAViewModel)}");
            
        }
    }
}