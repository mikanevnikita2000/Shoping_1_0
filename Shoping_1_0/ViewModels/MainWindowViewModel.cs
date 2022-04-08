using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoping_1_0.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        private string _data = "Дата";
        public string Data
        {
            get => _data;
            set => this.RaiseAndSetIfChanged(ref _data, value);
        }
    }
   /* public string VisibleExpression
    {
        get => _visibleExpression;
        set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
    }*/
}
