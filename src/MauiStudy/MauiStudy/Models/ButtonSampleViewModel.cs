using System;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiStudy.Models
{
    public class ButtonSampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int RecievedOnCommandSampleCount
        {
            set
            {
                if (recievedOnCommandSampleCount != value)
                {
                    recievedOnCommandSampleCount = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecievedOnCommandSampleCount"));
                }
            }
            get
            {
                return recievedOnCommandSampleCount;
            }
        }

        private int recievedOnCommandSampleCount;

        public ICommand OnCommandSample { private set; get; }

        public ButtonSampleViewModel()
        {
            recievedOnCommandSampleCount = 0;
            OnCommandSample = new Command(() => RecievedOnCommandSampleCount++);
        }
    }
}