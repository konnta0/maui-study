using System;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiStudy.Models
{
    public class EntrySampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ReturnCommand { private set; get; }

        public ICommand ReturnCommandParameter { private set; get; }

        private string recievedReturnCommand;

        public string RecievedReturnCommandStr
        {
            set
            {
                if (recievedReturnCommand != value)
                {
                    recievedReturnCommand = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecievedReturnCommandStr"));
                }
            }
            get => recievedReturnCommand;
        }

        private string recievedReturnCommandParameter;
        public string RecievedReturnCommandParameterStr
        {
            set
            {
                if (recievedReturnCommandParameter != value)
                {
                    recievedReturnCommandParameter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecievedReturnCommandParameterStr"));
                }
            }
            get => recievedReturnCommandParameter;
        }


        public EntrySampleViewModel()
        {
            recievedReturnCommand = string.Empty;
            RecievedReturnCommandStr = $"now at {DateTime.Now.ToString()}";
            ReturnCommand = new Command(() =>
           {
               RecievedReturnCommandStr = $"recieved at {DateTime.Now.ToString()}";
           });

            RecievedReturnCommandParameterStr = $"now at {DateTime.Now.ToString()}";
            ReturnCommandParameter = new Command<DateTime>(t =>
            {
                RecievedReturnCommandParameterStr = $"recieved at {t.ToString()}";
            });
        }
    }
}