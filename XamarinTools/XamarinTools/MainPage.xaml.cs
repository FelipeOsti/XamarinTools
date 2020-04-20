using FormsCurvedBottomNavigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTools.View;

namespace XamarinTools
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CurvedBottomTabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new PageTesteView("Acontecendo Ao Vivo")
            {
                Title = "Ao Vivo",
                IconImageSource = "aovivo"
            });
            this.Children.Add(new PageTesteView("Eventos de Hoje")
            {
                Title = "Evento",
                IconImageSource = "evento"
            });
            this.Children.Add(new PageTesteView("Informações")
            {
                Title = "Info",
                IconImageSource = "info"
            });
            this.Children.Add(new PageTesteView("Temas de Hoje")
            {
                Title = "Temas",
                IconImageSource = "temas"
            });
        }

        private void CurvedBottomTabbedPage_FabIconClicked(object sender, EventArgs e)
        {
            //
        }
    }
}
