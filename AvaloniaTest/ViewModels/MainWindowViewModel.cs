using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AvaloniaTest.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            TestItems = [];
            for (int i = 0; i < 5; i++)
                TestItems.Add($"ITEM  {i}");
        }

        [RelayCommand]
        public void OnTestButtonClick()
        {
            TestItems[0] = "CHECK";
        }

        public ObservableCollection<string> TestItems { get; set; }
    }
}
