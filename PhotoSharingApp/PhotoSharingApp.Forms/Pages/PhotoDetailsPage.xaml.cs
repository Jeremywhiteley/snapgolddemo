﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using PhotoSharingApp.Frontend.Portable;
using GalaSoft.MvvmLight.Ioc;
using PhotoSharingApp.Frontend.Portable.Models;

namespace PhotoSharingApp.Forms
{
    public partial class PhotoDetailsPage : ContentPage
    {
        private PhotoDetailsViewModel viewModel;

        public PhotoDetailsPage(Photo photo)
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            viewModel = SimpleIoc.Default.GetInstance<PhotoDetailsViewModel>();
            viewModel.Photo = photo;
            BindingContext = viewModel;
        }
    }
}
