using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaTest;

public partial class MyControl : UserControl
{
    public MyControl()
    {
        InitializeComponent();

        Content = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Cras aliquet pellentesque tincidunt. 
Quisque ut consectetur erat. 
Suspendisse vitae ultricies turpis, sed tempus orci. 
Curabitur dictum, orci nec facilisis laoreet, metus odio posuere augue, et dapibus est mi a enim. 
Pellentesque mattis nisi eget massa rhoncus facilisis. 
Aenean nec nulla sit amet libero scelerisque tristique. 
Fusce facilisis quam vel quam pellentesque dapibus. 
Praesent sagittis ultrices ex at feugiat. 
Ut orci risus, tempus ut tortor ac, hendrerit convallis mi.";
    }
}