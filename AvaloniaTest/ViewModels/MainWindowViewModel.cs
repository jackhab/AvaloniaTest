using System.Collections.ObjectModel;

namespace AvaloniaTest.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            TestItems = [];
            for (int i = 0; i < 100; i++)
                TestItems.Add($"ITEM                             {i}");

        }

        public ObservableCollection<string> TestItems { get; set; }
    }
}
