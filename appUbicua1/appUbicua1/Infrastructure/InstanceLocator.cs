using appUbicua1.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace appUbicua1.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
