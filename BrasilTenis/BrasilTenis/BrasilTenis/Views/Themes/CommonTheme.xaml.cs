﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrasilTenis.Views.Themes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommonTheme : ResourceDictionary
    {
        public CommonTheme()
        {
            InitializeComponent();
        }
    }
}