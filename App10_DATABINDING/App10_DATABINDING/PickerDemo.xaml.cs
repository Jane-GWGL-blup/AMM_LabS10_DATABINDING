﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10_DATABINDING
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerDemo : ContentPage
    {
        public PickerDemo()
        {
            InitializeComponent();
            BindingContext = new MonkeysPageViewModel();
        }
    }
}