using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using App1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PRoductPages : ContentPage
    {
       
        int bt = 0;
        public static List<Commands> cm = new List<Commands>();
    
        public PRoductPages()
        {

            InitializeComponent();
            if(MainPage.n1 == 1)
            {
                if(menustar.tchawar == 1)
                {

                    im1.Source = ImageSource.FromFile("wr1.png");
                    im2.Source = ImageSource.FromFile("wr2.png");
                    im3.Source = ImageSource.FromFile("wr3.png");
                    im4.Source = ImageSource.FromFile("wr4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "25";
                    pr2.Text = "40";
                    pr3.Text = "30";
                    pr4.Text = "30";
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

                    m1.Text = "Sandwich";
                    m2.Text = "PLAT";
                    m3.Text = "Panini";
                    m4.Text = "tacos";
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
                if (menustar.tpizza == 1)
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

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "25";
                    pr2.Text = "30";
                    pr3.Text = "30";
                    pr4.Text = "35";
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

                    m1.Text = "Thon";
                    m2.Text = "Polet";
                    m3.Text = "Viand Hacher";
                    m4.Text = "Fruit de Mer";
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
                    im1.Source = ImageSource.FromFile("ptt1.png");
                    im2.Source = ImageSource.FromFile("ptt2.png");
                    im3.Source = ImageSource.FromFile("ptt3.png");
                    im4.Source = ImageSource.FromFile("ptt4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "30";
                    pr2.Text = "40";
                    pr3.Text = "45";
                    pr4.Text = "50";
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

                    m1.Text = "Napolitaine";
                    m2.Text = "Bolognaise";
                    m3.Text = "Carbonara";
                    m4.Text = "Fruits de Mer";
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
                    im1.Source = ImageSource.FromFile("tcs1.png");
                    im2.Source = ImageSource.FromFile("tcs2.png");
                    im3.Source = ImageSource.FromFile("tcs3.png");
                    im4.Source = ImageSource.FromFile("tcs4.png");



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    im5.Source = ImageSource.FromFile("tcs5.png");
                    im6.Source = ImageSource.FromFile("tcs6.png");
                    im7.Source = ImageSource.FromFile("tcs7.png");
                    im8.Source = ImageSource.FromFile("tcs8.png");
                    im9.Source = ImageSource.FromFile("tcs9.png");
                    
                    
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");


                    pr1.Text = "30";
                    pr2.Text = "30";
                    pr3.Text = "30";
                    pr4.Text = "35";
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

                    m1.Text = "Bogata";
                    m2.Text = "Mexicans";
                    m3.Text = "King";
                    m4.Text = "Mixte";
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



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");
                  
                    
                    
                    
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

                    pr1.Text = "18";
                    pr2.Text = "25";
                    pr3.Text = "50";
                    pr4.Text = "100";
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

                    m1.Text = "Sandwicj";
                    m2.Text = "1/4 Polet";
                    m3.Text = "1/2 Polet";
                    m4.Text = "Polet Complet";
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

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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


                    im1.Source = ImageSource.FromFile("gl1.png");
                    im2.Source = ImageSource.FromFile("gl2.png");
                    im3.Source = ImageSource.FromFile("gl3.png");
                    im4.Source = ImageSource.FromFile("gl4.png");

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

                    pr1.Text = "40";
                    pr2.Text = "40";
                    pr3.Text = "50";
                    pr4.Text = "50";
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

                    m1.Text = "Blanche";
                    m2.Text = "Forestier";
                    m3.Text = "Toi et MOi";
                    m4.Text = "Plaza";
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
                    im1.Source = ImageSource.FromFile("ds1.png");
                    im2.Source = ImageSource.FromFile("ds2.png");
                    im3.Source = ImageSource.FromFile("ds3.png");
                    im4.Source = ImageSource.FromFile("ds4.png");
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

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "18";
                    pr2.Text = "18";
                    pr3.Text = "18";
                    pr4.Text = "18";
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

                    m1.Text = "Gateux";
                    m2.Text = "Tirmaisu";
                    m3.Text = "Salde de Fruit ";
                    m4.Text = "Fondant Chocolat";
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
                //if()
                //{

                //    im8.IsVisible = false;
                //    im6.IsVisible = false;
                //    im5.IsVisible = false;
                //    im7.IsVisible = false;
                //    pr8.IsVisible = false;
                //    pr7.IsVisible = false;
                //    pr5.IsVisible = false;
                //    pr6.IsVisible = false;

                //    m5.IsVisible = false;

                //    m6.IsVisible = false;

                //    m7.IsVisible = false;

                //    m8.IsVisible = false;
                //    im9.IsVisible = false;
                //    im10.IsVisible = false;
                //    im11.IsVisible = false;
                //    im12.IsVisible = false;
                //    im13.IsVisible = false;
                //    im14.IsVisible = false;
                //    pr9.IsVisible = false;
                //    pr10.IsVisible = false;
                //    pr11.IsVisible = false;
                //    pr12.IsVisible = false;
                //    pr13.IsVisible = false;
                //    pr14.IsVisible = false;
                //    pr7.IsVisible = false;
                //    m7.IsVisible = false;
                //    m9.IsVisible = false;
                //    m10.IsVisible = false;
                //    m11.IsVisible = false;
                //    m12.IsVisible = false;
                //    m13.IsVisible = false;
                //    m14.IsVisible = false;

                //    im1.Source = ImageSource.FromFile("ds1.png");
                //    im2.Source = ImageSource.FromFile("ds2.png");
                //    im3.Source = ImageSource.FromFile("ds3.png");
                //    im4.Source = ImageSource.FromFile("ds4.png");
                //    im5.Source = ImageSource.FromFile("");
                //    im6.Source = ImageSource.FromFile("");
                //    im7.Source = ImageSource.FromFile("");
                //    im8.Source = ImageSource.FromFile("");
                //    im9.Source = ImageSource.FromFile("");
                //    im10.Source = ImageSource.FromFile("");
                //    im11.Source = ImageSource.FromFile("");
                //    im12.Source = ImageSource.FromFile("");
                //    im13.Source = ImageSource.FromFile("");
                //    im14.Source = ImageSource.FromFile("");

                //    pr1.Text = "";
                //    pr2.Text = "";
                //    pr3.Text = "";
                //    pr4.Text = "";
                //    pr5.Text = "";
                //    pr6.Text = "";
                //    pr7.Text = "";
                //    pr8.Text = "";
                //    pr9.Text = "";
                //    pr10.Text = "";
                //    pr11.Text = "";
                //    pr12.Text = "";
                //    pr13.Text = "";
                //    pr14.Text = "";

                //    m1.Text = "";
                //    m2.Text = "";
                //    m3.Text = "";
                //    m4.Text = "";
                //    m5.Text = "";
                //    m6.Text = "";
                //    m7.Text = "";
                //    m8.Text = "";
                //    m9.Text = "";
                //    m10.Text = "";
                //    m11.Text = "";
                //    m12.Text = "";
                //    m13.Text = "";
                //    m14.Text = "";
                //}
                if(menustar.tjus == 1)
                {
                    im1.Source = ImageSource.FromFile("jor.png");
                    im2.Source = ImageSource.FromFile("jfraise.png");
                    im3.Source = ImageSource.FromFile("javo.png");
                    im4.Source = ImageSource.FromFile("panacher.png");
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

                if (menustar.tchawar == 1)
                {

                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "25";
                    pr2.Text = "40";
                    pr3.Text = "30";
                    pr4.Text = "30";
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

                    m1.Text = "Sandwich";
                    m2.Text = "PLAT";
                    m3.Text = "Panini";
                    m4.Text = "tacos";
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
                if (menustar.tpizza == 1)
                    {
                        im1.Source = ImageSource.FromFile("pz1.png");
                        im2.Source = ImageSource.FromFile("pz2.png");
                        im3.Source = ImageSource.FromFile("pz3.png");
                        im4.Source = ImageSource.FromFile("pz4.png");
                        im5.Source = ImageSource.FromFile("pz5.png");
                        im6.Source = ImageSource.FromFile("pz6.png");
                        im7.Source = ImageSource.FromFile("pz7.png");
                        im8.Source = ImageSource.FromFile("pz8.png");
                        im9.Source = ImageSource.FromFile("pz9.png");
                        im10.Source = ImageSource.FromFile("pz10.png");
                  
                

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

                       
                        pr11.IsVisible = false;
                        pr12.IsVisible = false;
                        pr13.IsVisible = false;
                        pr14.IsVisible = false;

                        pr1.Text = "20";
                        pr2.Text = "25";
                        pr3.Text = "25";
                        pr4.Text = "30";
                        pr5.Text = "25";
                        pr6.Text = "30";
                        pr7.Text = "35";
                        pr8.Text = "35";
                        pr9.Text = "30";
                        pr10.Text = "30";

                        m1.Text = "Margarita";
                        m2.Text = "Vegetarian";
                        m3.Text = "Thon";
                        m4.Text = "Charcuterie";
                        m5.Text = "Bolognaise";
                        m6.Text = "Chicken";
                        m7.Text = "Fruit de Mer";
                        m8.Text = "Quatre Saison";
                    m9.Text = "Quatre Fromage";
                    m10.Text = "Supreme";
                    m11.IsVisible = false;
                        m12.IsVisible = false;
                        m13.IsVisible = false;
                        m14.IsVisible = false;

                    }
                    if (menustar.tburger == 1)
                    {
                        im1.Source = ImageSource.FromFile("brg1.png");
                        im2.Source = ImageSource.FromFile("brg2.png");
                        im3.Source = ImageSource.FromFile("brg3.png");
                        im4.Source = ImageSource.FromFile("brg4.png");
                        im5.Source = ImageSource.FromFile("brg5.png");
                        im6.Source = ImageSource.FromFile("brg6.png");
                        im7.Source = ImageSource.FromFile("brg7.png");
                        im8.Source = ImageSource.FromFile("brg8.png");
                  

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

                        pr1.Text = "22";
                        pr2.Text = "40";
                        pr3.Text = "18";
                        pr4.Text = "30";
                        pr5.Text = "40";
                        pr6.Text = "40";
                        pr7.Text = "30";
                        pr8.Text = "30";
                      

                        m1.Text = "Chicken ";
                        m2.Text = "Double Chicken ";
                        m3.Text = "Chees";
                        m4.Text = "Double Chees";
                        m5.Text = "Chicken Beef";
                        m6.Text = "Chees & Double";
                        m7.Text = "Torino";
                        m8.Text = "Fish";
                      
                    }
                    if (menustar.tsalad == 1)
                    {
                        im1.Source = ImageSource.FromFile("sld1.png");
                        im2.Source = ImageSource.FromFile("sld2.png");
                        im3.Source = ImageSource.FromFile("sld3.png");
                        im4.Source = ImageSource.FromFile("sld4.png");
                        im5.Source = ImageSource.FromFile("sld5.png");
                        im6.Source = ImageSource.FromFile("sld6.png");





                        im7.Source = ImageSource.FromFile("sld1.png");
                        im8.Source = ImageSource.FromFile("sld3.png");
                       

                        pr1.Text = "13";
                        pr2.Text = "15";
                        pr3.Text = "17";
                        pr4.Text = "20";
                        pr5.Text = "40";

                        pr6.Text = "25";

                        pr7.Text = "25";
                        pr8.Text = "27";




                       
                       
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
                        m9.IsVisible = false;
                        m10.IsVisible = false;
                        m11.IsVisible = false;
                        m12.IsVisible = false;
                        m13.IsVisible = false;
                        m14.IsVisible = false;
                        m1.Text = "eco";
                        m2.Text = "Nicoise";
                        m3.Text = "Surimi";
                        m4.Text = "Mixte";
                        m5.Text = "Torino Food";
                    m6.Text = "Fish";
                    m7.Text = "Italy";
                    m8.Text = "Chicken";
                    }
                    if (menustar.tpanini == 1)
                    {
                        im1.Source = ImageSource.FromFile("pann1.png");
                        im2.Source = ImageSource.FromFile("pann2.png");
                        im3.Source = ImageSource.FromFile("pann3.png");
                        im4.Source = ImageSource.FromFile("pann4.png");
                        im5.Source = ImageSource.FromFile("pann5.png");
                        im6.Source = ImageSource.FromFile("pann6.png");
                        im7.Source = ImageSource.FromFile("pann7.png");
                       
                        im8.IsVisible = false;
                        im6.IsVisible = false;
                        im5.IsVisible = false;
                        im7.IsVisible = false;
                        pr8.IsVisible = false;
                        pr7.IsVisible = false;
                        pr5.IsVisible = false;
                        pr6.IsVisible = false;

                        m5.IsVisible = false;

                        m6.IsVisible = false;

                        m7.IsVisible = false;

                        m8.IsVisible = false;
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

                     

                        pr1.Text = "15";
                        pr2.Text = "17";
                        pr3.Text = "19";
                        pr4.Text = "21";
                        pr5.Text = "22";
                        pr6.Text = "23";
                        pr7.Text = "35";
                    

                        m1.Text = "Fromage";
                        m2.Text = "Thon";
                        m3.Text = "Poulet";
                        m4.Text = "Viande Hacher";
                        m5.Text = "Fruit de Mer";
                        m6.Text = "Mixte";
                        m7.Text = "Torino Food";
                    }
                    if (menustar.tpate == 1)
                    {
                        im1.Source = ImageSource.FromFile("ptt1.png");
                        im2.Source = ImageSource.FromFile("ptt2.png");
                        im3.Source = ImageSource.FromFile("ptt3.png");
                        im4.Source = ImageSource.FromFile("ptt4.png");
                        im5.Source = ImageSource.FromFile("ptt5.png");

                        im6.Source = ImageSource.FromFile("");
                        im7.Source = ImageSource.FromFile("");
                        im8.Source = ImageSource.FromFile("");
                        im9.Source = ImageSource.FromFile("");
                        im10.Source = ImageSource.FromFile("");
                        im11.Source = ImageSource.FromFile("");
                        im12.Source = ImageSource.FromFile("");
                        im13.Source = ImageSource.FromFile("");
                        im14.Source = ImageSource.FromFile("");
                        im8.IsVisible = false;
                        im6.IsVisible = false;
                        im7.IsVisible = false;
                        pr8.IsVisible = false;
                        pr7.IsVisible = false;
                        pr6.IsVisible = false;


                        m6.IsVisible = false;

                        m7.IsVisible = false;

                        m8.IsVisible = false;
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

                        pr1.Text = "30";
                        pr2.Text = "33";
                        pr3.Text = "33";
                        pr4.Text = "35";
                        pr5.Text = "35";

                        m1.Text = "Bolognaise";
                        m2.Text = "Carbonara";
                        m3.Text = "Polet Champignon";
                        m4.Text = "4 fromage";
                        m5.Text = "Fruit de Mer";

                    }
                    if (menustar.ttacos == 1)
                    {
                        im1.Source = ImageSource.FromFile("tcs1.png");
                        im2.Source = ImageSource.FromFile("tcs2.png");
                        im3.Source = ImageSource.FromFile("tcs3.png");
                        im4.Source = ImageSource.FromFile("tcs4.png");
                        im5.Source = ImageSource.FromFile("tcs5.png");
                        im6.Source = ImageSource.FromFile("tcs6.png");
                        im7.Source = ImageSource.FromFile("tcs7.png");
                        im8.Source = ImageSource.FromFile("tcs8.png");
                    im9.Source = ImageSource.FromFile("tcs9.png");

                    im10.IsVisible = false;
                        im11.IsVisible = false;
                        im12.IsVisible = false;
                        im13.IsVisible = false;
                        im14.IsVisible = false;
                       
                        pr10.IsVisible = false;
                        pr11.IsVisible = false;
                        pr12.IsVisible = false;
                        pr13.IsVisible = false;
                        pr14.IsVisible = false;
                      
                        m10.IsVisible = false;
                        m11.IsVisible = false;
                        m12.IsVisible = false;
                        m13.IsVisible = false;
                        m14.IsVisible = false;
                        pr1.Text = "18";
                        pr2.Text = "25";
                        pr3.Text = "27";
                        pr4.Text = "27";
                        pr5.Text = "35";
                        pr6.Text = "30";
                        pr7.Text = "35";
                        pr8.Text = "20";
                        pr9.Text = "20";
                       

                        m1.Text = "Thon";
                        m2.Text = "Polet";
                        m3.Text = "Viand Hacher";
                        m4.Text = "Escalop";
                        m5.Text = "Torino Food";
                        m6.Text = "Nuggets";
                        m7.Text = "Cordon Bleu";
                        m8.Text = "Vegetarian";
                        m9.Text = "Mini";
                    }
                    if (menustar.tchicken == 1)
                    {



                        im8.IsVisible = false;
                        im6.IsVisible = false;
                        im5.IsVisible = false;
                        im7.IsVisible = false;
                        pr8.IsVisible = false;
                        pr7.IsVisible = false;
                        pr5.IsVisible = false;
                        pr6.IsVisible = false;

                        m5.IsVisible = false;

                        m6.IsVisible = false;

                        m7.IsVisible = false;

                        m8.IsVisible = false;
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

                        im1.Source = ImageSource.FromFile("ch1.png");
                        im2.Source = ImageSource.FromFile("ch2.png");
                        im3.Source = ImageSource.FromFile("ch3.png");


                    im4.IsVisible = false;
                    m4.IsVisible = false;
                    pr4.IsVisible = false;



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

                        pr1.Text = "25";
                        pr2.Text = "45";
                        pr3.Text = "90";

                        m1.Text = "1/4 chicken";
                        m2.Text = "1/2 chicken";
                        m3.Text = "Complet";
                    }
                    if (menustar.tglace == 1)
                    {

                        im8.IsVisible = false;
                        im6.IsVisible = false;
                        im5.IsVisible = false;
                        im7.IsVisible = false;
                        pr8.IsVisible = false;
                        pr7.IsVisible = false;
                        pr5.IsVisible = false;
                        pr6.IsVisible = false;

                        m5.IsVisible = false;

                        m6.IsVisible = false;

                        m7.IsVisible = false;

                        m8.IsVisible = false;
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
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                        m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;

                  
                    }
                    if (menustar.tdessert == 1)
                    {
                        im1.Source = ImageSource.FromFile("ds2.png");
                        im2.Source = ImageSource.FromFile("ds1.png");
                        im3.Source = ImageSource.FromFile("ds3.png");
                        im4.Source = ImageSource.FromFile("gl1.png");
                      
                        im8.IsVisible = false;
                        im6.IsVisible = false;
                        im5.IsVisible = false;
                        im7.IsVisible = false;
                        pr8.IsVisible = false;
                        pr7.IsVisible = false;
                        pr5.IsVisible = false;
                        pr6.IsVisible = false;

                        m5.IsVisible = false;

                        m6.IsVisible = false;

                        m7.IsVisible = false;

                        m8.IsVisible = false;
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



                        pr1.Text = "15";
                        pr2.Text = "15";
                        pr3.Text = "15";
                        pr4.Text = "17";

                        m1.Text = "Salade Fruits";
                        m2.Text = "Tirmisu";
                        m3.Text = "Panna Cota";
                        m4.Text = "Glace 3Boles";
                    }
                  
                    if (menustar.tjus == 1)
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
            if (MainPage.n3 == 1)
            {
                if (menustar.tchawar == 1)
                {


                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "20";
                    pr2.Text = "30";


                    m1.Text = "Shawarma";
                    m2.Text = "PLAT";


                }
                if (menustar.tpizza == 1)
                {
                    im1.Source = ImageSource.FromFile("pz1.png");
                    im2.Source = ImageSource.FromFile("pz2.png");
                    im3.Source = ImageSource.FromFile("pz3.png");
                    im4.Source = ImageSource.FromFile("pz4.png");
                    im5.Source = ImageSource.FromFile("pz5.png");
                    im6.Source = ImageSource.FromFile("pz6.png");
                    im7.Source = ImageSource.FromFile("pz7.png");
                    im8.Source = ImageSource.FromFile("pz8.png");
                    im9.Source = ImageSource.FromFile("pz9.png");

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


                    m10.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    pr1.Text = "40";
                    pr2.Text = "30";
                    pr3.Text = "35";
                    pr4.Text = "30";
                    pr5.Text = "30";
                    pr6.Text = "30";
                    pr7.Text = "30";
                    pr8.Text = "35";
                    pr9.Text = "25";

                    m1.Text = "Pizza Idriss";
                    m2.Text = "Portofino";
                    m3.Text = "Fruit de Mer";
                    m4.Text = "Mixte";
                    m5.Text = "4 Saison";
                    m6.Text = "Fromage";
                    m7.Text = "Vegetarianne";
                    m8.Text = "Thonara";
                    m9.Text = "Margarita";
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;

                }
                if (menustar.tburger == 1)
                {
                    im1.Source = ImageSource.FromFile("brg1.png");
                    im2.Source = ImageSource.FromFile("brg2.png");
                    im3.Source = ImageSource.FromFile("brg3.png");
                    im4.Source = ImageSource.FromFile("brg4.png");
                    im5.Source = ImageSource.FromFile("brg5.png");
                    im6.Source = ImageSource.FromFile("brg6.png");
                    im7.Source = ImageSource.FromFile("brg7.png");
                    im8.Source = ImageSource.FromFile("brg8.png");
                  
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

                    pr1.Text = "15";
                    pr2.Text = "16";
                    pr3.Text = "17";
                    pr4.Text = "18";
                    pr5.Text = "25";
                    pr6.Text = "30";
                    pr7.Text = "20";
                    pr8.Text = "22";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Hamburger ";
                    m2.Text = "Chees Burger ";
                    m3.Text = "Egg Burger";
                    m4.Text = "Chicken Burger";
                    m5.Text = "King Burger";
                    m6.Text = "Double  Chicken ";
                    m7.Text = "Long Burger";
                    m8.Text = "Long Chicken";
                }
                if (menustar.tsalad == 1)
                {
                    im1.Source = ImageSource.FromFile("sld1.png");
                    im2.Source = ImageSource.FromFile("sld2.png");
                    im3.Source = ImageSource.FromFile("sld3.png");
                    im4.Source = ImageSource.FromFile("sld4.png");


                    pr1.Text = "10";
                    pr2.Text = "12";
                    pr3.Text = "12";
                    pr4.Text = "18";

                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    m6.IsVisible = false;
                    m5.IsVisible = false;
                    pr6.IsVisible = false;
                    pr5.IsVisible = false;
                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    m1.Text = "Thon";
                    m2.Text = "Nicoise";
                    m3.Text = "marocain";
                    m4.Text = "maison";

                }
                if (menustar.tpanini == 1)
                {
                    im1.Source = ImageSource.FromFile("pann1.png");
                    im2.Source = ImageSource.FromFile("pann2.png");
                    im3.Source = ImageSource.FromFile("pann3.png");
                    im4.Source = ImageSource.FromFile("pann4.png");
                    im5.Source = ImageSource.FromFile("pann5.png");
                    im6.Source = ImageSource.FromFile("pann6.png");
                    im7.Source = ImageSource.FromFile("pann7.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "15";
                    pr3.Text = "15";
                    pr4.Text = "15";
                    pr5.Text = "15";
                    pr6.Text = "17";
                    pr7.Text = "20";


                    m1.Text = "Fromage";
                    m2.Text = "Thon";
                    m3.Text = "Poulet";
                    m4.Text = "Viande Hacher";
                    m5.Text = "Fruit de Mer";
                    m6.Text = "Mixte";
                    m7.Text = "Torino Food";

                }
                if (menustar.tpate == 1)
                { 
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;

                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;

                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;

                    im1.Source = ImageSource.FromFile("ptt1.png");
                    im2.Source = ImageSource.FromFile("ptt2.png");
                    im3.Source = ImageSource.FromFile("ptt3.png");
                    im4.Source = ImageSource.FromFile("ptt4.png");
                    im5.Source = ImageSource.FromFile("ptt5.png");

                   
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr6.IsVisible = false;
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;



                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "30";
                    pr2.Text = "33";
                    pr3.Text = "33";
                    pr4.Text = "35";
                    pr5.Text = "35";


                    m1.Text = "Bolognaise";
                    m2.Text = "Carbonara";
                    m3.Text = "Polet Champignon";
                    m4.Text = "4 fromage";
                    m5.Text = "Fruit de Mer";

                }
                if (menustar.ttacos == 1)
                {

                    im1.Source = ImageSource.FromFile("tcs1.png");
                    im2.Source = ImageSource.FromFile("tcs2.png");
                    im3.Source = ImageSource.FromFile("tcs3.png");
                    im4.Source = ImageSource.FromFile("tcs4.png");
                    im5.Source = ImageSource.FromFile("tcs5.png");
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    im8.IsVisible = false;
                    im9.IsVisible = false;
                    im7.IsVisible = false;
                    im6.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;
                    m6.IsVisible = false;
                    pr6.IsVisible = false;
                    pr7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr9.IsVisible = false;
                    
                    m7.IsVisible = false;

                    m8.IsVisible = false;

                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    pr1.Text = "25";
                    pr2.Text = "25";
                    pr3.Text = "35";
                    pr4.Text = "35";
                    pr5.Text = "30";
                   


                    m1.Text = "Dinde";
                    m2.Text = "Kefta";
                    m3.Text = "Shawarma";
                    m4.Text = "Escalop";
                    m5.Text = "Mixte";
                  
                }
                if (menustar.tchicken == 1)
                {



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");


                    im4.IsVisible = false;
                    m4.IsVisible = false;
                    pr4.IsVisible = false;



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

                    pr1.Text = "25";
                    pr2.Text = "45";
                    pr3.Text = "90";
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

                    m1.Text = "1/4 chicken";
                    m2.Text = "1/2 chicken";
                    m3.Text = "Complet";
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
                if (menustar.tglace == 1)
                {

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;


                }
                if (menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("ds2.png");
                    im2.Source = ImageSource.FromFile("ds1.png");
                    im3.Source = ImageSource.FromFile("ds3.png");
                    im4.Source = ImageSource.FromFile("gl1.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "15";
                    pr3.Text = "15";
                    pr4.Text = "17";
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

                    m1.Text = "Salade Fruits";
                    m2.Text = "Tirmisu";
                    m3.Text = "Panna Cota";
                    m4.Text = "Glace 3Boles";
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

                if (menustar.tjus == 1)
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
            if (MainPage.n4 == 1)
            {
                if (menustar.tchawar == 1)
                {

                    
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "20";
                    pr2.Text = "30";
                   

                    m1.Text = "Shawarma";
                    m2.Text = "PLAT";
                  

                }
                if (menustar.tpizza == 1)
                {
                    im1.Source = ImageSource.FromFile("pz1.png");
                    im2.Source = ImageSource.FromFile("pz2.png");
                    im3.Source = ImageSource.FromFile("pz3.png");
                    im4.Source = ImageSource.FromFile("pz4.png");
                    im5.Source = ImageSource.FromFile("pz5.png");
                    im6.Source = ImageSource.FromFile("pz6.png");
                    im7.Source = ImageSource.FromFile("pz7.png");
                    im8.Source = ImageSource.FromFile("pz8.png");
                    im9.Source = ImageSource.FromFile("pz9.png");

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


                    m10.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    pr1.Text = "40";
                    pr2.Text = "30";
                    pr3.Text = "35";
                    pr4.Text = "30";
                    pr5.Text = "30";
                    pr6.Text = "30";
                    pr7.Text = "30";
                    pr8.Text = "35";
                    pr9.Text = "25";

                    m1.Text = "Pizza Idriss";
                    m2.Text = "Portofino";
                    m3.Text = "Fruit de Mer";
                    m4.Text = "Mixte";
                    m5.Text = "4 Saison";
                    m6.Text = "Fromage";
                    m7.Text = "Vegetarianne";
                    m8.Text = "Thonara";
                    m9.Text = "Margarita";
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;

                }
                if (menustar.tburger == 1)
                {
                    im1.Source = ImageSource.FromFile("brg1.png");
                    im2.Source = ImageSource.FromFile("brg2.png");
                    im3.Source = ImageSource.FromFile("brg3.png");
                    im4.Source = ImageSource.FromFile("brg4.png");
                    im5.Source = ImageSource.FromFile("brg5.png");
                    im6.Source = ImageSource.FromFile("brg6.png");
                    im7.Source = ImageSource.FromFile("brg7.png");
                    im8.Source = ImageSource.FromFile("brg8.png");
                    pr8.Text = "";
                    m8.Text = "";

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

                    pr1.Text = "15";
                    pr2.Text = "16";
                    pr3.Text = "17";
                    pr4.Text = "18";
                    pr5.Text = "25";
                    pr6.Text = "30";
                    pr7.Text = "20";
                    pr8.Text = "22";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Hamburger ";
                    m2.Text = "Chees Burger ";
                    m3.Text = "Egg Burger";
                    m4.Text = "Chicken Burger";
                    m5.Text = "King Burger";
                    m6.Text = "Double  Chicken ";
                    m7.Text = "Long Burger";
                    m8.Text = "Long Chicken";
                }
                if (menustar.tsalad == 1)
                {
                    im1.Source = ImageSource.FromFile("sld1.png");
                    im2.Source = ImageSource.FromFile("sld2.png");
                    im3.Source = ImageSource.FromFile("sld3.png");
                    im4.Source = ImageSource.FromFile("sld4.png");
                   

                    pr1.Text = "10";
                    pr2.Text = "12";
                    pr3.Text = "12";
                    pr4.Text = "18";

                    im9.IsVisible = false;
                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    m6.IsVisible = false;
                    m5.IsVisible = false;
                    pr6.IsVisible = false;
                    pr5.IsVisible = false;
                    pr9.IsVisible = false;
                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    m1.Text = "Thon";
                    m2.Text = "Nicoise";
                    m3.Text = "marocain";
                    m4.Text = "maison";
                   
                }
                if (menustar.tpanini == 1)
                {
                    im1.Source = ImageSource.FromFile("pann1.png");
                    im2.Source = ImageSource.FromFile("pann2.png");
                    im3.Source = ImageSource.FromFile("pann3.png");
                    im4.Source = ImageSource.FromFile("pann4.png");
                    im5.Source = ImageSource.FromFile("pann5.png");
                    im6.Source = ImageSource.FromFile("pann6.png");
                    im7.Source = ImageSource.FromFile("pann7.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "15";
                    pr3.Text = "15";
                    pr4.Text = "15";
                    pr5.Text = "15";
                    pr6.Text = "17";
                    pr7.Text = "20";
                   

                    m1.Text = "Fromage";
                    m2.Text = "Thon";
                    m3.Text = "Poulet";
                    m4.Text = "Viande Hacher";
                    m5.Text = "Fruit de Mer";
                    m6.Text = "Mixte";
                    m7.Text = "Torino Food";
                 
                }
                if (menustar.tpate == 1)
                {
                    im1.Source = ImageSource.FromFile("ptt1.png");
                    im2.Source = ImageSource.FromFile("ptt2.png");
                    im3.Source = ImageSource.FromFile("ptt3.png");
                    im4.Source = ImageSource.FromFile("ptt4.png");
                    im5.Source = ImageSource.FromFile("ptt5.png");

                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr6.IsVisible = false;
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;



                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "30";
                    pr2.Text = "33";
                    pr3.Text = "33";
                    pr4.Text = "35";
                    pr5.Text = "35";
                  

                    m1.Text = "Bolognaise";
                    m2.Text = "Carbonara";
                    m3.Text = "Polet Champignon";
                    m4.Text = "4 fromage";
                    m5.Text = "Fruit de Mer";
                   
                }
                if (menustar.ttacos == 1)
                {
                    im1.Source = ImageSource.FromFile("tcs1.png");
                    im2.Source = ImageSource.FromFile("tcs2.png");
                    im3.Source = ImageSource.FromFile("tcs3.png");
                    im4.Source = ImageSource.FromFile("tcs4.png");
                    im5.Source = ImageSource.FromFile("tcs5.png");
                  

                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;

                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    pr1.Text = "18";
                    pr2.Text = "25";
                    pr3.Text = "27";
                    pr4.Text = "27";
                    pr5.Text = "35";
                    pr6.Text = "30";
                    pr7.Text = "35";
                    pr8.Text = "20";
                    pr9.Text = "20";


                    m1.Text = "Dinde";
                    m2.Text = "Polet";
                    m3.Text = "Viand Hacher";
                    m4.Text = "Escalop";
                    m5.Text = "Torino Food";
                    m6.Text = "Nuggets";
                    m7.Text = "Cordon Bleu";
                    m8.Text = "Vegetarian";
                    m9.Text = "Mini";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tchicken == 1)
                {



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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
                    im4.IsVisible = false;
                    m4.IsVisible = false;
                    pr4.IsVisible = false;
                }
                if (menustar.tglace == 1)
                {

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;


                }
                if (menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("ds2.png");
                    im2.Source = ImageSource.FromFile("ds1.png");
                    im3.Source = ImageSource.FromFile("ds3.png");
                    im4.Source = ImageSource.FromFile("gl1.png");
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;


                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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


                }

                if (menustar.tjus == 1)
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
            if (MainPage.n5 == 1)
            {
                if (menustar.tchawar == 1)
                {

                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "25";
                    pr2.Text = "40";
                    pr3.Text = "30";
                    pr4.Text = "30";
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

                    m1.Text = "Sandwich";
                    m2.Text = "PLAT";
                    m3.Text = "Panini";
                    m4.Text = "tacos";
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
                if (menustar.tpizza == 1)
                {
                    im1.Source = ImageSource.FromFile("pz1.png");
                    im2.Source = ImageSource.FromFile("pz2.png");
                    im3.Source = ImageSource.FromFile("pz3.png");
                    im4.Source = ImageSource.FromFile("pz4.png");
                    im5.Source = ImageSource.FromFile("pz5.png");
                    im6.Source = ImageSource.FromFile("pz6.png");
                    im7.Source = ImageSource.FromFile("pz7.png");
                    im8.Source = ImageSource.FromFile("pz8.png");
                    im9.Source = ImageSource.FromFile("pz9.png");
                    im10.Source = ImageSource.FromFile("pz10.png");



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


                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    pr1.Text = "20";
                    pr2.Text = "25";
                    pr3.Text = "25";
                    pr4.Text = "30";
                    pr5.Text = "25";
                    pr6.Text = "30";
                    pr7.Text = "35";
                    pr8.Text = "35";
                    pr9.Text = "30";
                    pr10.Text = "30";

                    m1.Text = "Margarita";
                    m2.Text = "Vegetarian";
                    m3.Text = "Thon";
                    m4.Text = "Charcuterie";
                    m5.Text = "Bolognaise";
                    m6.Text = "Chicken";
                    m7.Text = "Fruit de Mer";
                    m8.Text = "Quatre Saison";
                    m9.Text = "Quatre Fromage";
                    m10.Text = "Supreme";
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
                if (menustar.tburger == 1)
                {
                    im1.Source = ImageSource.FromFile("brg1.png");
                    im2.Source = ImageSource.FromFile("brg2.png");
                    im3.Source = ImageSource.FromFile("brg3.png");
                    im4.Source = ImageSource.FromFile("brg4.png");
                    im5.Source = ImageSource.FromFile("brg5.png");
                    im6.Source = ImageSource.FromFile("brg6.png");
                    im7.Source = ImageSource.FromFile("brg7.png");
                    im8.Source = ImageSource.FromFile("brg8.png");
                    pr8.Text = "";
                    m8.Text = "";

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

                    pr1.Text = "22";
                    pr2.Text = "40";
                    pr3.Text = "18";
                    pr4.Text = "30";
                    pr5.Text = "40";
                    pr6.Text = "40";
                    pr7.Text = "30";
                    pr8.Text = "30";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Chicken ";
                    m2.Text = "Double Chicken ";
                    m3.Text = "Chees";
                    m4.Text = "Double Chees";
                    m5.Text = "Chicken Beef";
                    m6.Text = "Chees & Double";
                    m7.Text = "Torino";
                    m8.Text = "Fish";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tsalad == 1)
                {
                    im1.Source = ImageSource.FromFile("sld1.png");
                    im2.Source = ImageSource.FromFile("sld2.png");
                    im3.Source = ImageSource.FromFile("sld3.png");
                    im4.Source = ImageSource.FromFile("sld4.png");
                    im5.Source = ImageSource.FromFile("sld5.png");
                    im6.Source = ImageSource.FromFile("sld6.png");





                    im7.Source = ImageSource.FromFile("sld1.png");
                    im8.Source = ImageSource.FromFile("sld3.png");


                    pr1.Text = "13";
                    pr2.Text = "15";
                    pr3.Text = "17";
                    pr4.Text = "20";
                    pr5.Text = "40";

                    pr6.Text = "25";

                    pr7.Text = "25";
                    pr8.Text = "27";




                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

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
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    m1.Text = "eco";
                    m2.Text = "Nicoise";
                    m3.Text = "Surimi";
                    m4.Text = "Mixte";
                    m5.Text = "Torino Food";
                    m6.Text = "Fish";
                    m7.Text = "Italy";
                    m8.Text = "Chicken";
                }
                if (menustar.tpanini == 1)
                {
                    im1.Source = ImageSource.FromFile("pann1.png");
                    im2.Source = ImageSource.FromFile("pann2.png");
                    im3.Source = ImageSource.FromFile("pann3.png");
                    im4.Source = ImageSource.FromFile("pann4.png");
                    im5.Source = ImageSource.FromFile("pann5.png");
                    im6.Source = ImageSource.FromFile("pann6.png");
                    im7.Source = ImageSource.FromFile("pann7.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "17";
                    pr3.Text = "19";
                    pr4.Text = "21";
                    pr5.Text = "22";
                    pr6.Text = "23";
                    pr7.Text = "35";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Fromage";
                    m2.Text = "Thon";
                    m3.Text = "Poulet";
                    m4.Text = "Viande Hacher";
                    m5.Text = "Fruit de Mer";
                    m6.Text = "Mixte";
                    m7.Text = "Torino Food";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tpate == 1)
                {
                    im1.Source = ImageSource.FromFile("ptt1.png");
                    im2.Source = ImageSource.FromFile("ptt2.png");
                    im3.Source = ImageSource.FromFile("ptt3.png");
                    im4.Source = ImageSource.FromFile("ptt4.png");
                    im5.Source = ImageSource.FromFile("ptt5.png");

                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr6.IsVisible = false;


                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "30";
                    pr2.Text = "33";
                    pr3.Text = "33";
                    pr4.Text = "35";
                    pr5.Text = "35";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Bolognaise";
                    m2.Text = "Carbonara";
                    m3.Text = "Polet Champignon";
                    m4.Text = "4 fromage";
                    m5.Text = "Fruit de Mer";
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
                if (menustar.ttacos == 1)
                {
                    im1.Source = ImageSource.FromFile("tcs1.png");
                    im2.Source = ImageSource.FromFile("tcs2.png");
                    im3.Source = ImageSource.FromFile("tcs3.png");
                    im4.Source = ImageSource.FromFile("tcs4.png");
                    im5.Source = ImageSource.FromFile("tcs5.png");
                    im6.Source = ImageSource.FromFile("tcs6.png");
                    im7.Source = ImageSource.FromFile("tcs7.png");
                    im8.Source = ImageSource.FromFile("tcs8.png");
                    im9.Source = ImageSource.FromFile("tcs9.png");

                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;

                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    pr1.Text = "18";
                    pr2.Text = "25";
                    pr3.Text = "27";
                    pr4.Text = "27";
                    pr5.Text = "35";
                    pr6.Text = "30";
                    pr7.Text = "35";
                    pr8.Text = "20";
                    pr9.Text = "20";


                    m1.Text = "Thon";
                    m2.Text = "Polet";
                    m3.Text = "Viand Hacher";
                    m4.Text = "Escalop";
                    m5.Text = "Torino Food";
                    m6.Text = "Nuggets";
                    m7.Text = "Cordon Bleu";
                    m8.Text = "Vegetarian";
                    m9.Text = "Mini";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tchicken == 1)
                {



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");


                    im4.IsVisible = false;
                    m4.IsVisible = false;
                    pr4.IsVisible = false;



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

                    pr1.Text = "25";
                    pr2.Text = "45";
                    pr3.Text = "90";
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

                    m1.Text = "1/4 chicken";
                    m2.Text = "1/2 chicken";
                    m3.Text = "Complet";
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
                if (menustar.tglace == 1)
                {

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;


                }
                if (menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("ds2.png");
                    im2.Source = ImageSource.FromFile("ds1.png");
                    im3.Source = ImageSource.FromFile("ds3.png");
                    im4.Source = ImageSource.FromFile("gl1.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "15";
                    pr3.Text = "15";
                    pr4.Text = "17";
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

                    m1.Text = "Salade Fruits";
                    m2.Text = "Tirmisu";
                    m3.Text = "Panna Cota";
                    m4.Text = "Glace 3Boles";
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

                if (menustar.tjus == 1)
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
            if(MainPage.n6 == 1)
            {
                if (menustar.tchawar == 1)
                {

                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");
                    im4.Source = ImageSource.FromFile("ch4.png");



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
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "25";
                    pr2.Text = "40";
                    pr3.Text = "30";
                    pr4.Text = "30";
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

                    m1.Text = "Sandwich";
                    m2.Text = "PLAT";
                    m3.Text = "Panini";
                    m4.Text = "tacos";
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
                if (menustar.tpizza == 1)
                {
                    im1.Source = ImageSource.FromFile("pz1.png");
                    im2.Source = ImageSource.FromFile("pz2.png");
                    im3.Source = ImageSource.FromFile("pz3.png");
                    im4.Source = ImageSource.FromFile("pz4.png");
                    im5.Source = ImageSource.FromFile("pz5.png");
                    im6.Source = ImageSource.FromFile("pz6.png");
                    im7.Source = ImageSource.FromFile("pz7.png");
                    im8.Source = ImageSource.FromFile("pz8.png");
                    im9.Source = ImageSource.FromFile("pz9.png");
                    im10.Source = ImageSource.FromFile("pz10.png");



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


                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    pr1.Text = "20";
                    pr2.Text = "25";
                    pr3.Text = "25";
                    pr4.Text = "30";
                    pr5.Text = "25";
                    pr6.Text = "30";
                    pr7.Text = "35";
                    pr8.Text = "35";
                    pr9.Text = "30";
                    pr10.Text = "30";

                    m1.Text = "Margarita";
                    m2.Text = "Vegetarian";
                    m3.Text = "Thon";
                    m4.Text = "Charcuterie";
                    m5.Text = "Bolognaise";
                    m6.Text = "Chicken";
                    m7.Text = "Fruit de Mer";
                    m8.Text = "Quatre Saison";
                    m9.Text = "Quatre Fromage";
                    m10.Text = "Supreme";
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
                if (menustar.tburger == 1)
                {
                    im1.Source = ImageSource.FromFile("brg1.png");
                    im2.Source = ImageSource.FromFile("brg2.png");
                    im3.Source = ImageSource.FromFile("brg3.png");
                    im4.Source = ImageSource.FromFile("brg4.png");
                    im5.Source = ImageSource.FromFile("brg5.png");
                    im6.Source = ImageSource.FromFile("brg6.png");
                    im7.Source = ImageSource.FromFile("brg7.png");
                    im8.Source = ImageSource.FromFile("brg8.png");
                    pr8.Text = "";
                    m8.Text = "";

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

                    pr1.Text = "22";
                    pr2.Text = "40";
                    pr3.Text = "18";
                    pr4.Text = "30";
                    pr5.Text = "40";
                    pr6.Text = "40";
                    pr7.Text = "30";
                    pr8.Text = "30";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Chicken ";
                    m2.Text = "Double Chicken ";
                    m3.Text = "Chees";
                    m4.Text = "Double Chees";
                    m5.Text = "Chicken Beef";
                    m6.Text = "Chees & Double";
                    m7.Text = "Torino";
                    m8.Text = "Fish";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tsalad == 1)
                {
                    im1.Source = ImageSource.FromFile("sld1.png");
                    im2.Source = ImageSource.FromFile("sld2.png");
                    im3.Source = ImageSource.FromFile("sld3.png");
                    im4.Source = ImageSource.FromFile("sld4.png");
                    im5.Source = ImageSource.FromFile("sld5.png");
                    im6.Source = ImageSource.FromFile("sld6.png");





                    im7.Source = ImageSource.FromFile("sld1.png");
                    im8.Source = ImageSource.FromFile("sld3.png");


                    pr1.Text = "13";
                    pr2.Text = "15";
                    pr3.Text = "17";
                    pr4.Text = "20";
                    pr5.Text = "40";

                    pr6.Text = "25";

                    pr7.Text = "25";
                    pr8.Text = "27";




                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

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
                    m9.IsVisible = false;
                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    m1.Text = "eco";
                    m2.Text = "Nicoise";
                    m3.Text = "Surimi";
                    m4.Text = "Mixte";
                    m5.Text = "Torino Food";
                    m6.Text = "Fish";
                    m7.Text = "Italy";
                    m8.Text = "Chicken";
                }
                if (menustar.tpanini == 1)
                {
                    im1.Source = ImageSource.FromFile("pann1.png");
                    im2.Source = ImageSource.FromFile("pann2.png");
                    im3.Source = ImageSource.FromFile("pann3.png");
                    im4.Source = ImageSource.FromFile("pann4.png");
                    im5.Source = ImageSource.FromFile("pann5.png");
                    im6.Source = ImageSource.FromFile("pann6.png");
                    im7.Source = ImageSource.FromFile("pann7.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "17";
                    pr3.Text = "19";
                    pr4.Text = "21";
                    pr5.Text = "22";
                    pr6.Text = "23";
                    pr7.Text = "35";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Fromage";
                    m2.Text = "Thon";
                    m3.Text = "Poulet";
                    m4.Text = "Viande Hacher";
                    m5.Text = "Fruit de Mer";
                    m6.Text = "Mixte";
                    m7.Text = "Torino Food";
                    m8.Text = "";
                    m9.Text = "";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tpate == 1)
                {
                    im1.Source = ImageSource.FromFile("ptt1.png");
                    im2.Source = ImageSource.FromFile("ptt2.png");
                    im3.Source = ImageSource.FromFile("ptt3.png");
                    im4.Source = ImageSource.FromFile("ptt4.png");
                    im5.Source = ImageSource.FromFile("ptt5.png");

                    im6.Source = ImageSource.FromFile("");
                    im7.Source = ImageSource.FromFile("");
                    im8.Source = ImageSource.FromFile("");
                    im9.Source = ImageSource.FromFile("");
                    im10.Source = ImageSource.FromFile("");
                    im11.Source = ImageSource.FromFile("");
                    im12.Source = ImageSource.FromFile("");
                    im13.Source = ImageSource.FromFile("");
                    im14.Source = ImageSource.FromFile("");
                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr6.IsVisible = false;


                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    pr1.Text = "30";
                    pr2.Text = "33";
                    pr3.Text = "33";
                    pr4.Text = "35";
                    pr5.Text = "35";
                    pr6.Text = "";
                    pr7.Text = "";
                    pr8.Text = "";
                    pr9.Text = "";
                    pr10.Text = "";
                    pr11.Text = "";
                    pr12.Text = "";
                    pr13.Text = "";
                    pr14.Text = "";

                    m1.Text = "Bolognaise";
                    m2.Text = "Carbonara";
                    m3.Text = "Polet Champignon";
                    m4.Text = "4 fromage";
                    m5.Text = "Fruit de Mer";
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
                if (menustar.ttacos == 1)
                {
                    im1.Source = ImageSource.FromFile("tcs1.png");
                    im2.Source = ImageSource.FromFile("tcs2.png");
                    im3.Source = ImageSource.FromFile("tcs3.png");
                    im4.Source = ImageSource.FromFile("tcs4.png");
                    im5.Source = ImageSource.FromFile("tcs5.png");
                    im6.Source = ImageSource.FromFile("tcs6.png");
                    im7.Source = ImageSource.FromFile("tcs7.png");
                    im8.Source = ImageSource.FromFile("tcs8.png");
                    im9.Source = ImageSource.FromFile("tcs9.png");

                    im10.IsVisible = false;
                    im11.IsVisible = false;
                    im12.IsVisible = false;
                    im13.IsVisible = false;
                    im14.IsVisible = false;

                    pr10.IsVisible = false;
                    pr11.IsVisible = false;
                    pr12.IsVisible = false;
                    pr13.IsVisible = false;
                    pr14.IsVisible = false;

                    m10.IsVisible = false;
                    m11.IsVisible = false;
                    m12.IsVisible = false;
                    m13.IsVisible = false;
                    m14.IsVisible = false;
                    pr1.Text = "18";
                    pr2.Text = "25";
                    pr3.Text = "27";
                    pr4.Text = "27";
                    pr5.Text = "35";
                    pr6.Text = "30";
                    pr7.Text = "35";
                    pr8.Text = "20";
                    pr9.Text = "20";


                    m1.Text = "Thon";
                    m2.Text = "Polet";
                    m3.Text = "Viand Hacher";
                    m4.Text = "Escalop";
                    m5.Text = "Torino Food";
                    m6.Text = "Nuggets";
                    m7.Text = "Cordon Bleu";
                    m8.Text = "Vegetarian";
                    m9.Text = "Mini";
                    m10.Text = "";
                    m11.Text = "";
                    m12.Text = "";
                    m13.Text = "";
                    m14.Text = "";
                }
                if (menustar.tchicken == 1)
                {



                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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

                    im1.Source = ImageSource.FromFile("ch1.png");
                    im2.Source = ImageSource.FromFile("ch2.png");
                    im3.Source = ImageSource.FromFile("ch3.png");


                    im4.IsVisible = false;
                    m4.IsVisible = false;
                    pr4.IsVisible = false;



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

                    pr1.Text = "25";
                    pr2.Text = "45";
                    pr3.Text = "90";
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

                    m1.Text = "1/4 chicken";
                    m2.Text = "1/2 chicken";
                    m3.Text = "Complet";
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
                if (menustar.tglace == 1)
                {

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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
                    im1.IsVisible = false;
                    im2.IsVisible = false;
                    im3.IsVisible = false;
                    im4.IsVisible = false;
                    m1.IsVisible = false;
                    m2.IsVisible = false;
                    m3.IsVisible = false;
                    m4.IsVisible = false;
                    pr1.IsVisible = false;
                    pr2.IsVisible = false;
                    pr3.IsVisible = false;
                    pr4.IsVisible = false;


                }
                if (menustar.tdessert == 1)
                {
                    im1.Source = ImageSource.FromFile("ds2.png");
                    im2.Source = ImageSource.FromFile("ds1.png");
                    im3.Source = ImageSource.FromFile("ds3.png");
                    im4.Source = ImageSource.FromFile("gl1.png");

                    im8.IsVisible = false;
                    im6.IsVisible = false;
                    im5.IsVisible = false;
                    im7.IsVisible = false;
                    pr8.IsVisible = false;
                    pr7.IsVisible = false;
                    pr5.IsVisible = false;
                    pr6.IsVisible = false;

                    m5.IsVisible = false;

                    m6.IsVisible = false;

                    m7.IsVisible = false;

                    m8.IsVisible = false;
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



                    pr1.Text = "15";
                    pr2.Text = "15";
                    pr3.Text = "15";
                    pr4.Text = "17";
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

                    m1.Text = "Salade Fruits";
                    m2.Text = "Tirmisu";
                    m3.Text = "Panna Cota";
                    m4.Text = "Glace 3Boles";
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

                if (menustar.tjus == 1)
                {
                    im1.Source = ImageSource.FromFile("jor.png");
                    im2.Source = ImageSource.FromFile("panacher.png");
                    im3.Source = ImageSource.FromFile("javo.png");
                    im4.Source = ImageSource.FromFile("jfraise.png");
                  
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
            btnpl.Clicked += btn_val;
            Guest(im1, im1_click);
            Guest(im2, im2_click);
            Guest(im3, im3_click);
            Guest(im4, im4_click);
            Guest(im5, im5_click);
            Guest(im6, im6_click);
            Guest(im7, im7_click);
            Guest(im8, im8_click);
            Guest(im9, im9_click);
            Guest(im10, im10_click);
            Guest(im11, im11_click);
            Guest(im12, im12_click);
        
        }
        private async void btn_val(object sender,EventArgs e)
        {
           await Navigation.PushModalAsync(new Details());
        }
        private void Guest(Image im,EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            im.GestureRecognizers.Add(n);
        }

        private void im1_click(object sender,EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m1.Text;
            cmd.prix= int.Parse(pr1.Text);
            menustar.command +="/"+cmd.name+"/"+cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private  void im2_click(object sender,EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m2.Text;
            cmd.prix =int.Parse(pr2.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im3_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m3.Text;
            cmd.prix = int.Parse(pr3.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im4_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m4.Text;
            cmd.prix = int.Parse(pr4.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im5_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m5.Text;
            cmd.prix =int.Parse(pr5.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im6_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m6.Text;
            cmd.prix =int.Parse(pr6.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im7_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m7.Text;
            cmd.prix =int.Parse(pr7.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im8_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m8.Text;
            cmd.prix =int.Parse(pr8.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im9_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m9.Text;
            cmd.prix =int.Parse(pr9.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im10_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m10.Text;
            cmd.prix = int.Parse(pr10.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im11_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m11.Text;
            cmd.prix =int.Parse(pr11.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }
        private void im12_click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            cmd.name = m12.Text;
            cmd.prix =int.Parse(pr12.Text);
            menustar.command += "/" + cmd.name + "/" + cmd.prix.ToString();
            cm.Add(cmd);
            bt++;
            btnpl.Text = "طلبات" + bt;
        }

    }
}