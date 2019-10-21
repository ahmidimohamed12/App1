using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PRoductPages : ContentPage
    {
        int bt = 0;
        
        public PRoductPages()
        {
            InitializeComponent();
            if(MainPage.n1 == 1)
            {
                if(menustar.tpizza == 1)
                {
                    im1.Source = ImageSource.FromFile("pz1.png");
                    im2.Source = ImageSource.FromFile("pz2.png");
                    im3.Source = ImageSource.FromFile("pz3.png");
                    im4.Source = ImageSource.FromFile("pz4.png");
                    im5.Source = ImageSource.FromFile("pz5.png");
                    im6.Source = ImageSource.FromFile("pz6.png");
                    im7.Source = ImageSource.FromFile("pz7.png");
                    im8.Source = ImageSource.FromFile("pz8.png");

                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;

                    im9.Source = ImageSource.FromFile("pz9.png");
                    im10.Source = ImageSource.FromFile("pz10.png");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    pr1.Text = "28";
                    pr2.Text = "35";
                    pr3.Text = "40";
                    pr4.Text = "40";
                    pr5.Text = "40";
                    pr6.Text = "45";
                    pr7.Text = "40";
                    pr8.Text = "50";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Margarita";
                    m2.Text = "Thon";
                    m3.Text = "Viand Hacher";
                    m4.Text = "Pizza Blanche";
                    m5.Text = "4 Fromage";
                    m6.Text = "Fruit de Mer";
                    m7.Text = "Peperani";
                    m8.Text = "Sky Plza";

                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;

                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tburger == 1)
                {
                    im1.Source = ImageSource.FromFile("brg1.png");
                    im2.Source = ImageSource.FromFile("brg2.png");
                    im3.Source = ImageSource.FromFile("brg3.png");
                    im4.Source = ImageSource.FromFile("brg4.png");
                    im5.Source = ImageSource.FromFile("brg5.png");
                    im6.Source = ImageSource.FromFile("brg6.png");
                    im7.Source = ImageSource.FromFile("brg7.png");

                    im8.IsVisible = false;
                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    pr8.IsVisible = false;
                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    m8.IsVisible = false;
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;

                    im8.Source = ImageSource.FromFile("brg8.png");
                    im9.Source = ImageSource.FromFile("brg9.png");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "23";
                    pr2.Text = "25";
                    pr3.Text = "25";
                    pr4.Text = "35";
                    pr5.Text = "35";
                    pr6.Text = "35";
                    pr7.Text = "40";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Hamburger";
                    m2.Text = "Chess Burger";
                    m3.Text = "Chicken Burger";
                    m4.Text = "King Burger";
                    m5.Text = "Queen Burger";
                    m6.Text = "Mixter Burger";
                    m7.Text = "Plaza Burger";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tsalad == 1)
                {
                    im1.Source = ImageSource.FromFile("sld1.png");
                    im2.Source = ImageSource.FromFile("sld2.png");
                    im3.Source = ImageSource.FromFile("sld3.png");
                    im4.Source = ImageSource.FromFile("sld4.png");
                    im5.Source = ImageSource.FromFile("sld5.png");
                    im6.Source = ImageSource.FromFile("sld6.png");
                   
                    
                    
                    
                    
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "22";
                    pr2.Text = "24";
                    pr3.Text = "25";
                    pr4.Text = "30";
                    pr5.Text = "30";



                    pr6.Text = "";

                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";
                    im6.IsVisible = false;
                    pr6.IsVisible = false;
                    m6.IsVisible = false;
                    im7.IsVisible = false;
                    im8.IsVisible = false;
                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    pr8.IsVisible = false;
                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;
                    pr7.IsVisible = false;
                    m7.IsVisible = false;
                    m8.IsVisible = false;
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    m1.Text = "Nicoise";
                    m2.Text = "Tomate Mozarella";
                    m3.Text = "Poulet";
                    m4.Text = "Fruit de Mer";
                    m5.Text = "Plaza";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tpanini==1)
                {
                    im1.Source = ImageSource.FromFile("pann1.png");
                    im2.Source = ImageSource.FromFile("pann2.png");
                    im3.Source = ImageSource.FromFile("pann3.png");
                    im4.Source = ImageSource.FromFile("pann4.png");
                    im5.Source = ImageSource.FromFile("pann5.png");
                    im6.Source = ImageSource.FromFile("pann6.png");
                    im7.Source = ImageSource.FromFile("pann7.png");
                    im8.Source = ImageSource.FromFile("pann8.png");

                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;
                    pr7.IsVisible = false;
                    m7.IsVisible = false;
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;

                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tpate==1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";

                }
                if(menustar.ttacos  == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tchicken == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tglace == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if(menustar.tjus == 1)
                {
                    im1.Source = ImageSource.FromFile("");
                    im2.Source = ImageSource.FromFile("");
                    im3.Source = ImageSource.FromFile("");
                    im4.Source = ImageSource.FromFile("");
                    im5.Source = ImageSource.FromFile("");
                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");

                    pr1.Text = "";
                    pr2.Text = "";
                    pr3.Text = "";
                    pr4.Text = "";
                    pr5.Text = "";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "";
                    m2.Text = "";
                    m3.Text = "";
                    m4.Text = "";
                    m5.Text = "";
                    m6.Text = "";
                    m7.Text = "";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
        
            }
            if (MainPage.n2 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
                im9.Source = ImageSource.FromFile("");
                im10.Source = ImageSource.FromFile("");
                im11.Source = ImageSource.FromFile("");
                im12.Source = ImageSource.FromFile("");
                im13.Source = ImageSource.FromFile("");
                im14.Source = ImageSource.FromFile("");

                pr1.Text = "";
                pr2.Text = "";
                pr3.Text = "";
                pr4.Text = "";
                pr5.Text = "";
                pr6.Text = "";
                pr7.Text = "";
                pr8.Text = "";
                pr9.Text = "";
                pr10.Text = "";
                pr11.Text = "";
                pr12.Text = "";
                pr13.Text = "";
                pr14.Text = "";

                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
                m5.Text = "";
                m6.Text = "";
                m7.Text = "";
                m8.Text = "";
                m9.Text = "";
                m10.Text = "";
                m11.Text = "";
                m12.Text = "";
                m13.Text = "";
                m14.Text = "";
            }
            if (MainPage.n3 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
                im9.Source = ImageSource.FromFile("");
                im10.Source = ImageSource.FromFile("");
                im11.Source = ImageSource.FromFile("");
                im12.Source = ImageSource.FromFile("");
                im13.Source = ImageSource.FromFile("");
                im14.Source = ImageSource.FromFile("");

                pr1.Text = "";
                pr2.Text = "";
                pr3.Text = "";
                pr4.Text = "";
                pr5.Text = "";
                pr6.Text = "";
                pr7.Text = "";
                pr8.Text = "";
                pr9.Text = "";
                pr10.Text = "";
                pr11.Text = "";
                pr12.Text = "";
                pr13.Text = "";
                pr14.Text = "";

                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
                m5.Text = "";
                m6.Text = "";
                m7.Text = "";
                m8.Text = "";
                m9.Text = "";
                m10.Text = "";
                m11.Text = "";
                m12.Text = "";
                m13.Text = "";
                m14.Text = "";
            }
            if (MainPage.n4 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
                im9.Source = ImageSource.FromFile("");
                im10.Source = ImageSource.FromFile("");
                im11.Source = ImageSource.FromFile("");
                im12.Source = ImageSource.FromFile("");
                im13.Source = ImageSource.FromFile("");
                im14.Source = ImageSource.FromFile("");

                pr1.Text = "";
                pr2.Text = "";
                pr3.Text = "";
                pr4.Text = "";
                pr5.Text = "";
                pr6.Text = "";
                pr7.Text = "";
                pr8.Text = "";
                pr9.Text = "";
                pr10.Text = "";
                pr11.Text = "";
                pr12.Text = "";
                pr13.Text = "";
                pr14.Text = "";

                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
                m5.Text = "";
                m6.Text = "";
                m7.Text = "";
                m8.Text = "";
                m9.Text = "";
                m10.Text = "";
                m11.Text = "";
                m12.Text = "";
                m13.Text = "";
                m14.Text = "";
            }
            if (MainPage.n5 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
                im9.Source = ImageSource.FromFile("");
                im10.Source = ImageSource.FromFile("");
                im11.Source = ImageSource.FromFile("");
                im12.Source = ImageSource.FromFile("");
                im13.Source = ImageSource.FromFile("");
                im14.Source = ImageSource.FromFile("");

                pr1.Text = "";
                pr2.Text = "";
                pr3.Text = "";
                pr4.Text = "";
                pr5.Text = "";
                pr6.Text = "";
                pr7.Text = "";
                pr8.Text = "";
                pr9.Text = "";
                pr10.Text = "";
                pr11.Text = "";
                pr12.Text = "";
                pr13.Text = "";
                pr14.Text = "";

                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
                m5.Text = "";
                m6.Text = "";
                m7.Text = "";
                m8.Text = "";
                m9.Text = "";
                m10.Text = "";
                m11.Text = "";
                m12.Text = "";
                m13.Text = "";
                m14.Text = "";
            }
            if (MainPage.n6 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
                im9.Source = ImageSource.FromFile("");
                im10.Source = ImageSource.FromFile("");
                im11.Source = ImageSource.FromFile("");
                im12.Source = ImageSource.FromFile("");
                im13.Source = ImageSource.FromFile("");
                im14.Source = ImageSource.FromFile("");

                pr1.Text = "";
                pr2.Text = "";
                pr3.Text = "";
                pr4.Text = "";
                pr5.Text = "";
                pr6.Text = "";
                pr7.Text = "";
                pr8.Text = "";
                pr9.Text = "";
                pr10.Text = "";
                pr11.Text = "";
                pr12.Text = "";
                pr13.Text = "";
                pr14.Text = "";

                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
                m5.Text = "";
                m6.Text = "";
                m7.Text = "";
                m8.Text = "";
                m9.Text = "";
                m10.Text = "";
                m11.Text = "";
                m12.Text = "";
                m13.Text = "";
                m14.Text = "";
            }
            btnpl.Clicked += btn_val;
            
        }
        private async void btn_val(object sender,EventArgs e)
        {
           await Navigation.PushModalAsync(new Formclie());
        }
        private void Guest(Image im,EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            im.GestureRecognizers.Add(n);
        }

        private void im1_click(object sender,EventArgs e)
        {
            bt++;
            btnpl.Text += bt;

        }
    
    }
}