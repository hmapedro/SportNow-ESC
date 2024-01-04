﻿using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SportNow.CustomViews
{
    public class FormValueEdit : Frame
    {

        public Entry entry;
        //public string Text {get; set; }

        public FormValueEdit(string Text)
        {
            createFormValueEdit(Text, Keyboard.Text);
        }

        public FormValueEdit(string Text, Keyboard keyboard)
        {
            createFormValueEdit(Text, keyboard);
        }

        public void createFormValueEdit(string Text, Keyboard keyboard)
        {

            this.CornerRadius = 5 * (float)App.screenHeightAdapter;
            this.IsClippedToBounds = true;
            BorderColor = App.topColor;
            BackgroundColor = Color.Transparent;
            this.Padding = new Thickness(1, 2, 2, 2);
            //this.MinimumHeightRequest = 50;
            this.HeightRequest = 45 * App.screenHeightAdapter;
            this.VerticalOptions = LayoutOptions.Center;
            this.HasShadow = false;

            entry = new Entry
            {
                //Padding = new Thickness(5,0,5,0),
                Text = Text,
                HorizontalTextAlignment = TextAlignment.Start,
                //VerticalTextAlignment = TextAlignment.Center,
                TextColor = App.normalTextColor,
                BackgroundColor = Color.White,
                FontSize = App.formValueFontSize,
                Keyboard = keyboard
                //HeightRequest = 30
            };

            this.Content = entry; // relativeLayout_Button;

        }
    }
}
