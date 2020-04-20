using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTools.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTesteView : ContentPage
    {
        public PageTesteView(string teste)
        {
            InitializeComponent();

            lblPagina.Text = $"Label de teste {teste}";
        }
    }
}