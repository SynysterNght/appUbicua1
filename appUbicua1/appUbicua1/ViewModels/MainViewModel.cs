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
        #region Attributes
        private ApiService apiService;
        #endregion

        #region Properties
        public ObservableCollection<Pagos> pagos { get; set; }
        #endregion

        #region Contructor
        public MainViewModel()
        {
            apiService = new ApiService();
            pagos = new ObservableCollection<Pagos>();
            LoadPagos();
        }
        #endregion

        #region Metodos
        private async void LoadPagos()
        {
            var rsp = await apiService.Get<Pagos>("https://",
                                    "api/",
                                    "Pagos");
            throw new NotImplementedException();
        }
        #endregion
    }
}
