using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVApp.Views
{
    public partial class AutorView : ContentPage
    {
        public AutorView(Model.Autor autor)
        {
            InitializeComponent();

            this.Autor.Text = autor.Nome;
        }
    }
}
