using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollerDice.Models;
using Xamarin.Forms;

namespace RollerDice
{
    public partial class MainPage : ContentPage
    {
        public string ResultValue { get; set; }
        public string ResultValueTwo { get; set; }

        public int totalSides = 4;

        Die die = new Die();


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            int result = die.Roll();
            ResultValue = result.ToString();
            OnPropertyChanged(nameof(ResultValue));
        }

        void RadioButton_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            string value = radio.Value.ToString();
            totalSides = int.Parse(value);
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            
            int result = die.Roll();
            int result2 = die.Roll();
            ResultValue = result.ToString();
            ResultValueTwo = result2.ToString();
            OnPropertyChanged(nameof(ResultValue));
            OnPropertyChanged(nameof(ResultValueTwo));
        }



    }
}

