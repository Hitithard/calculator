using Calculator.WpfApp.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calculator.WpfApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        private List<string> _availableOperations = new List<string> { "+","-","/","*" };


        public MainViewModel() 
        {
            ScreenVal = "0";
            AddNumberCommand = new RelayCommand(AddNumber);
            AddOperationCommand = new RelayCommand(AddOperation);
            ClearScreenCommand = new RelayCommand(ClearScreen);
            ClearlastNumCommand = new RelayCommand(ClearlastNum);
            GetResultCommand = new RelayCommand(GetResult);
        }

        private void GetResult(object obj)
        {
        }

        private void ClearlastNum(object obj)
        {
        }

        private void ClearScreen(object obj)
        {
        }

        private void AddOperation(object obj)
        {
        }

        private void AddNumber(object obj)
        {
            var number = obj as string;

            if (ScreenVal == "0" && number != ",")
                ScreenVal = string.Empty;
            else if (number == "," && _availableOperations.Contains(ScreenVal.Substring(ScreenVal.Length - 1)))
                number = "0,";
            ScreenVal += number;
        }

        private string _screenVal;


        public ICommand AddNumberCommand { get; set; }
        public ICommand AddOperationCommand { get; set; }
        public ICommand ClearScreenCommand { get; set; }
        public ICommand ClearlastNumCommand { get; set; }
        public ICommand GetResultCommand { get; set; }

        public string ScreenVal
        {
            get { return _screenVal; }
            set 
            {
                _screenVal = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
  