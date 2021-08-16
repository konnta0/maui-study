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

        public ICommand OnDragStartedCommand { private set; get; }
        public string DragStartedAt
        {
            set
            {
                if (_dragStartedAt != value)
                {
                    _dragStartedAt = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DragStartedAt"));
                }
            }
            get => _dragStartedAt;
        }
        private string _dragStartedAt;

        public SliderSampleViewModel()
        {
            DragCompletedAt = string.Empty;
            OnDragCompletedCommand = new Command(() =>
            {
                DragCompletedAt = $"recieved at {DateTime.Now.ToString()}";
            });

            DragStartedAt = string.Empty;
            OnDragStartedCommand = new Command(() =>
            {
                DragStartedAt = $"recieved at {DateTime.Now.ToString()}";
            });
        }
    }
}