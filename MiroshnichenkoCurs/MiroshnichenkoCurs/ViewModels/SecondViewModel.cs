﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroshnichenkoCurs.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {

        public SecondViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }
        public MainWindowViewModel? MainContext { get; set; }


    }
}
