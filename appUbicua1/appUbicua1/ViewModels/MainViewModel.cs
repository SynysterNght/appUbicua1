using appUbicua1.Helpers;
using appUbicua1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace appUbicua1.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        private PagosViewModel Pagos;
        #endregion
     
        #region Contructor
        public MainViewModel()
        {
            instance = this;
            this.Pagos = new PagosViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null) 
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion
    }
}
