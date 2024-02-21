using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Veterinary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var species = new List<string>
            {
                "Pies",
                "Kot",
                "Świnka morska",
            };
            Species.ItemsSource = species;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            AgeLabel.Text = ((int)e.NewValue).ToString();
        }

        private void Species_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Console.WriteLine(e.Item.ToString());
            switch (e.Item.ToString())
            {
                case "Pies":
                    AgeSlider.Maximum = 18;
                    break; 
                case "Kot":
                    AgeSlider.Maximum = 20;
                    break;
                case "Świnka morska":
                    AgeSlider.Maximum = 9;
                    break;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message = OwnerInp.Text + ", " + Species.SelectedItem + ", " + PurposeInp.Text + ", " + TimePicker.Time;
            DisplayAlert("Zapisana Wizytę", message, "OK");
        }
    }
}
