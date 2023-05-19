using Demo072023C.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo072023C
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSpeak_Clicked(object sender, EventArgs e)
        {

            DependencyService.Get<ITextToSpeech>().Speak(txtMessage.Text);
            
        }
    }
}
