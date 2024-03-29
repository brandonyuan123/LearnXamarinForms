﻿using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.DatePickerMenu;
using MyFirstProject.ViewViewModels.Controls.DoubleSwitch;
using MyFirstProject.ViewViewModels.Controls.DualPicker;
using MyFirstProject.ViewViewModels.Controls.Entry;
using MyFirstProject.ViewViewModels.Controls.Picker;
using MyFirstProject.ViewViewModels.Controls.Slider;
using MyFirstProject.ViewViewModels.Controls.Stepper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls
{
    public class ControlsViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }
        public ICommand OnStepperClicked { get; set; }
        public ICommand OnSwitchClicked { get; set; }
        public ICommand OnDoubleSwitchClicked { get; set; }
        public ICommand OnEntryClicked { get; set; }
        public ICommand OnPickerClicked { get; set; }
        public ICommand OnDualPickerClicked { get; set; }
        public ICommand OnDatePickerClicked { get; set; }

        public ControlsViewModel()
        {
            Title = Titles.ControlsTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnDoubleSwitchClicked = new Command(OnDoubleSwitchClickedAsync);
            OnEntryClicked = new Command(OnEntryClickedAsync);
            OnPickerClicked = new Command(OnPickerClickedAsync);
            OnDualPickerClicked = new Command(OnDualPickerClickedAsync);
            OnDatePickerClicked = new Command(OnDatePickerClickedAsync);
        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
        private async void OnStepperClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }
        private async void OnSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }
        private async void OnDoubleSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DoubleSwitchView());
        }
        private async void OnEntryClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryView());
        }
        private async void OnPickerClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerView());
        }
        private async void OnDualPickerClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DualPickerView());
        }
        private async void OnDatePickerClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerMenuView());
        }
    }
}
