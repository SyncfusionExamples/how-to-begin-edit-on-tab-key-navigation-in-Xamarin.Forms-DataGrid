# how-to-begin-edit-on-tab-key-navigation-in-Xamarin.Forms-DataGrid

##About the sample
This example illustrates how to begin edit on tab key navigation in Xamarin.Forms SfDataGrid.

By default, the SfDataGrid does not allow to enter edit mode while navigating the cell by using Tab key. But you can allow to enter edit mode by customizing the “Tab” key functionality by overriding ProcessKeyDown() method in custom selection controller and begin the editing action by calling SfDataGrid.BeginEdit() method in ProcessKeyDown() method when Tab key processed.

```XAML
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DataGridDemo"
             xmlns:sfPager="clr-namespace:Syncfusion.SfDataGrid.XForms.DataPager;assembly=Syncfusion.SfDataGrid.XForms"
             xmlns:sfGrid="clr-namespace:Syncfusion.SfDataGrid.XForms;assembly=Syncfusion.SfDataGrid.XForms"
             x:Class="DataGridDemo.MainPage" >
    <ContentPage.Resources>
        <local:CustomSelectionController x:Key="CustomSelectionController" />
    </ContentPage.Resources>
    <ContentPage.Content>
        <StackLayout Orientation="Vertical">
            <sfGrid:SfDataGrid x:Name="textGrid" 
                               ItemsSource="{Binding OrdersInfo}" 
                               SelectionController="{x:StaticResource CustomSelectionController}"
                               ColumnSizer="Star" NavigationMode="Cell" 
                               SelectionMode="Single" AllowEditing="True">
            </sfGrid:SfDataGrid>
        </StackLayout>
      
    </ContentPage.Content>
</ContentPage>
```

```C#
public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        ViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }

    public class CustomSelectionController : GridSelectionController
    {
        public CustomSelectionController()
        {
            this.SelectedRows = new GridSelectedRowsCollection();
        }

        protected override void ProcessKeyDown(string keyCode, bool isCtrlKeyPressed, bool isShiftKeyPressed)
        {
            if (keyCode == "Tab")
            {
                this.DataGrid.BeginEdit(1,0);
            }
            else
            {
                // default key action
                base.ProcessKeyDown(keyCode, isCtrlKeyPressed, isShiftKeyPressed);
            }
        }
    }
```

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.