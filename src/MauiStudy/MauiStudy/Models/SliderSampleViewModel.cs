using System;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiStudy.Models
{
    public class SliderSampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OnDragCompletedCommand { private set; get; }
        public string DragCompletedAt
        {
            set
            {
                if (_dragCompletedAt != value)
                {
                    _dragCompletedAt = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DragCompletedAt"));
                }
            }
            get => _dragCompletedAt;
        }
        private string _dragCompletedAt;


        public SliderSampleViewModel()
        {
            DragCompletedAt = string.Empty;
            OnDragCompletedCommand = new Command(() =>
            {
                DragCompletedAt = $"recieved at {DateTime.Now.ToString()}";
            });
        }
    }
}