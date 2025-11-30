using System.Diagnostics;

namespace EasyOptimization.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        public RelayCommand<string> LinkToCommand { get; private set; }

        public DashboardViewModel() { 
            LinkToCommand = new RelayCommand<string>(LinkTo!);
        }
        private void LinkTo(string url)
        {
            Process.Start("explorer.exe", url);
        }
    }
}
