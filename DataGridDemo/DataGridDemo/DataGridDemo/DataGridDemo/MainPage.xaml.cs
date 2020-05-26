using Syncfusion.SfDataGrid.XForms.DataPager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfDataGrid.XForms;
using Syncfusion.Data;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using Syncfusion.SfDataGrid.XForms.Renderers;
using Syncfusion.XForms.ComboBox;

namespace DataGridDemo
{
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
}
