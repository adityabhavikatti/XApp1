using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xapp
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }

        partial void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var pg = new Page1();
            PlaceHolder.Content = pg.Content;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var pg2 = new Page2();
            PlaceHolder.Content = pg2.Content;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            var pg3 = new Page3();
            PlaceHolder.Content = pg3.Content;
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            var pg4 = new Page4();
            PlaceHolder.Content = pg4.Content;
        }

        
    }
}
