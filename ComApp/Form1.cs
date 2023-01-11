using System.Runtime.CompilerServices;
using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ComApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*****************************
         * Zodiac Calculations Method!
         ****************************/
        static string zodCalc(string personOne, string personTwo)
        {
            //String creations for Zodiacs
            string zodiacOne = "Aries";
            string zodiacTwo = "Taurus";
            string zodiacThree = "Gemini";
            string zodiacFour = "Cancer";
            string zodiacFive = "Leo";
            string zodiacSix = "Virgo";
            string zodiacSeven = "Libra";
            string zodiacEight = "Scorpio";
            string zodiacNine = "Sagittarius";
            string zodiacTen = "Capricorn";
            string zodiacEleven = "Aquarius";
            string zodiacTwelve = "Pisces";
            string results; //to return

            //Aries Calcs
            if (personOne == zodiacOne && personTwo == zodiacOne)
            {
                return results = "50";
            }
            if (personOne == zodiacOne && personTwo == zodiacTwo)
            {
                return results = "57";
            }
            if (personOne == zodiacOne && personTwo == zodiacThree)
            {
                return results = "83";
            }
            if (personOne == zodiacOne && personTwo == zodiacFour)
            {
                return results = "42";
            }
            if (personOne == zodiacOne && personTwo == zodiacFive)
            {
                return results = "97";
            }
            if (personOne == zodiacOne && personTwo == zodiacSix)
            {
                return results = "63";
            }
            if (personOne == zodiacOne && personTwo == zodiacSeven)
            {
                return results = "85";
            }
            if (personOne == zodiacOne && personTwo == zodiacEight)
            {
                return results = "50";
            }
            if (personOne == zodiacOne && personTwo == zodiacNine)
            {
                return results = "100";
            }
            if (personOne == zodiacOne && personTwo == zodiacTen)
            {
                return results = "47";
            }
            if (personOne == zodiacOne && personTwo == zodiacEleven)
            {
                return results = "90";
            }
            if (personOne == zodiacOne && personTwo == zodiacTwelve)
            {
                return results = "67";
            }

            //Taurus Calcs
            if (personOne == zodiacTwo && personTwo == zodiacOne)
            {
                return results = "57";
            }
            if (personOne == zodiacTwo && personTwo == zodiacTwo)
            {
                return results = "100";
            }
            if (personOne == zodiacTwo && personTwo == zodiacThree)
            {
                return results = "33";
            }
            if (personOne == zodiacTwo && personTwo == zodiacFour)
            {
                return results = "97";
            }
            if (personOne == zodiacTwo && personTwo == zodiacFive)
            {
                return results = "73";
            }
            if (personOne == zodiacTwo && personTwo == zodiacSix)
            {
                return results = "90";
            }
            if (personOne == zodiacTwo && personTwo == zodiacSeven)
            {
                return results = "65";
            }
            if (personOne == zodiacTwo && personTwo == zodiacEight)
            {
                return results = "88";
            }
            if (personOne == zodiacTwo && personTwo == zodiacNine)
            {
                return results = "30";
            }
            if (personOne == zodiacTwo && personTwo == zodiacTen)
            {
                return results = "100";
            }
            if (personOne == zodiacTwo && personTwo == zodiacEleven)
            {
                return results = "58";
            }
            if (personOne == zodiacTwo && personTwo == zodiacTwelve)
            {
                return results = "85";
            }

            //Gemini Calcs
            if (personOne == zodiacThree && personTwo == zodiacOne)
            {
                return results = "83";
            }
            if (personOne == zodiacThree && personTwo == zodiacTwo)
            {
                return results = "33";
            }
            if (personOne == zodiacThree && personTwo == zodiacThree)
            {
                return results = "60";
            }
            if (personOne == zodiacThree && personTwo == zodiacFour)
            {
                return results = "65";
            }
            if (personOne == zodiacThree && personTwo == zodiacFive)
            {
                return results = "90";
            }
            if (personOne == zodiacThree && personTwo == zodiacSix)
            {
                return results = "68";
            }
            if (personOne == zodiacThree && personTwo == zodiacSeven)
            {
                return results = "95";
            }
            if (personOne == zodiacThree && personTwo == zodiacEight)
            {
                return results = "28";
            }
            if (personOne == zodiacThree && personTwo == zodiacNine)
            {
                return results = "60";
            }
            if (personOne == zodiacThree && personTwo == zodiacTen)
            {
                return results = "68";
            }
            if (personOne == zodiacThree && personTwo == zodiacEleven)
            {
                return results = "100";
            }
            if (personOne == zodiacThree && personTwo == zodiacTwelve)
            {
                return results = "53";
            }

            //Cancer Calcs
            if (personOne == zodiacFour && personTwo == zodiacOne)
            {
                return results = "42";
            }
            if (personOne == zodiacFour && personTwo == zodiacTwo)
            {
                return results = "97";
            }
            if (personOne == zodiacFour && personTwo == zodiacThree)
            {
                return results = "65";
            }
            if (personOne == zodiacFour && personTwo == zodiacFour)
            {
                return results = "75";
            }
            if (personOne == zodiacFour && personTwo == zodiacFive)
            {
                return results = "65";
            }
            if (personOne == zodiacFour && personTwo == zodiacSix)
            {
                return results = "90";
            }
            if (personOne == zodiacFour && personTwo == zodiacSeven)
            {
                return results = "65";
            }
            if (personOne == zodiacFour && personTwo == zodiacEight)
            {
                return results = "94";
            }
            if (personOne == zodiacFour && personTwo == zodiacNine)
            {
                return results = "53";
            }
            if (personOne == zodiacFour && personTwo == zodiacTen)
            {
                return results = "83";
            }
            if (personOne == zodiacFour && personTwo == zodiacEleven)
            {
                return results = "27";
            }
            if (personOne == zodiacFour && personTwo == zodiacTwelve)
            {
                return results = "98";
            }

            //Leo Calcs
            if (personOne == zodiacFive && personTwo == zodiacOne)
            {
                return results = "97";
            }
            if (personOne == zodiacFive && personTwo == zodiacTwo)
            {
                return results = "73";
            }
            if (personOne == zodiacFive && personTwo == zodiacThree)
            {
                return results = "90";
            }
            if (personOne == zodiacFive && personTwo == zodiacFour)
            {
                return results = "65";
            }
            if (personOne == zodiacFive && personTwo == zodiacFive)
            {
                return results = "45";
            }
            if (personOne == zodiacFive && personTwo == zodiacSix)
            {
                return results = "35";
            }
            if (personOne == zodiacFive && personTwo == zodiacSeven)
            {
                return results = "100";
            }
            if (personOne == zodiacFive && personTwo == zodiacEight)
            {
                return results = "58";
            }
            if (personOne == zodiacFive && personTwo == zodiacNine)
            {
                return results = "93";
            }
            if (personOne == zodiacFive && personTwo == zodiacTen)
            {
                return results = "35";
            }
            if (personOne == zodiacFive && personTwo == zodiacEleven)
            {
                return results = "68";
            }
            if (personOne == zodiacFive && personTwo == zodiacTwelve)
            {
                return results = "88";
            }

            //Virgo Calcs
            if (personOne == zodiacSix && personTwo == zodiacOne)
            {
                return results = "63";
            }
            if (personOne == zodiacSix && personTwo == zodiacTwo)
            {
                return results = "90";
            }
            if (personOne == zodiacSix && personTwo == zodiacThree)
            {
                return results = "68";
            }
            if (personOne == zodiacSix && personTwo == zodiacFour)
            {
                return results = "90";
            }
            if (personOne == zodiacSix && personTwo == zodiacFive)
            {
                return results = "35";
            }
            if (personOne == zodiacSix && personTwo == zodiacSix)
            {
                return results = "95";
            }
            if (personOne == zodiacSix && personTwo == zodiacSeven)
            {
                return results = "68";
            }
            if (personOne == zodiacSix && personTwo == zodiacEight)
            {
                return results = "88";
            }
            if (personOne == zodiacSix && personTwo == zodiacNine)
            {
                return results = "48";
            }
            if (personOne == zodiacSix && personTwo == zodiacTen)
            {
                return results = "100";
            }
            if (personOne == zodiacSix && personTwo == zodiacEleven)
            {
                return results = "30";
            }
            if (personOne == zodiacSix && personTwo == zodiacTwelve)
            {
                return results = "88";
            }

            //Libra Calcs
            if (personOne == zodiacSeven && personTwo == zodiacOne)
            {
                return results = "85";
            }
            if (personOne == zodiacSeven && personTwo == zodiacTwo)
            {
                return results = "65";
            }
            if (personOne == zodiacSeven && personTwo == zodiacThree)
            {
                return results = "95";
            }
            if (personOne == zodiacSeven && personTwo == zodiacFour)
            {
                return results = "65";
            }
            if (personOne == zodiacSeven && personTwo == zodiacFive)
            {
                return results = "100";
            }
            if (personOne == zodiacSeven && personTwo == zodiacSix)
            {
                return results = "68";
            }
            if (personOne == zodiacSeven && personTwo == zodiacSeven)
            {
                return results = "75";
            }
            if (personOne == zodiacSeven && personTwo == zodiacEight)
            {
                return results = "35";
            }
            if (personOne == zodiacSeven && personTwo == zodiacNine)
            {
                return results = "95";
            }
            if (personOne == zodiacSeven && personTwo == zodiacTen)
            {
                return results = "55";
            }
            if (personOne == zodiacSeven && personTwo == zodiacEleven)
            {
                return results = "90";
            }
            if (personOne == zodiacSeven && personTwo == zodiacTwelve)
            {
                return results = "75";
            }

            //Scorpio Calcs
            if (personOne == zodiacEight && personTwo == zodiacOne)
            {
                return results = "50";
            }
            if (personOne == zodiacEight && personTwo == zodiacTwo)
            {
                return results = "88";
            }
            if (personOne == zodiacEight && personTwo == zodiacThree)
            {
                return results = "28";
            }
            if (personOne == zodiacEight && personTwo == zodiacFour)
            {
                return results = "94";
            }
            if (personOne == zodiacEight && personTwo == zodiacFive)
            {
                return results = "58";
            }
            if (personOne == zodiacEight && personTwo == zodiacSix)
            {
                return results = "88";
            }
            if (personOne == zodiacEight && personTwo == zodiacSeven)
            {
                return results = "35";
            }
            if (personOne == zodiacEight && personTwo == zodiacEight)
            {
                return results = "80";
            }
            if (personOne == zodiacEight && personTwo == zodiacNine)
            {
                return results = "28";
            }
            if (personOne == zodiacEight && personTwo == zodiacTen)
            {
                return results = "95";
            }
            if (personOne == zodiacEight && personTwo == zodiacEleven)
            {
                return results = "73";
            }
            if (personOne == zodiacEight && personTwo == zodiacTwelve)
            {
                return results = "100";
            }

            //Sagittarius Calcs
            if (personOne == zodiacNine && personTwo == zodiacOne)
            {
                return results = "100";
            }
            if (personOne == zodiacNine && personTwo == zodiacTwo)
            {
                return results = "30";
            }
            if (personOne == zodiacNine && personTwo == zodiacThree)
            {
                return results = "60";
            }
            if (personOne == zodiacNine && personTwo == zodiacFour)
            {
                return results = "53";
            }
            if (personOne == zodiacNine && personTwo == zodiacFive)
            {
                return results = "93";
            }
            if (personOne == zodiacNine && personTwo == zodiacSix)
            {
                return results = "48";
            }
            if (personOne == zodiacNine && personTwo == zodiacSeven)
            {
                return results = "95";
            }
            if (personOne == zodiacNine && personTwo == zodiacEight)
            {
                return results = "28";
            }
            if (personOne == zodiacNine && personTwo == zodiacNine)
            {
                return results = "45";
            }
            if (personOne == zodiacNine && personTwo == zodiacTen)
            {
                return results = "60";
            }
            if (personOne == zodiacNine && personTwo == zodiacEleven)
            {
                return results = "95";
            }
            if (personOne == zodiacNine && personTwo == zodiacTwelve)
            {
                return results = "63";
            }

            //Capricorn Calcs
            if (personOne == zodiacTen && personTwo == zodiacOne)
            {
                return results = "47";
            }
            if (personOne == zodiacTen && personTwo == zodiacTwo)
            {
                return results = "100";
            }
            if (personOne == zodiacTen && personTwo == zodiacThree)
            {
                return results = "68";
            }
            if (personOne == zodiacTen && personTwo == zodiacFour)
            {
                return results = "83";
            }
            if (personOne == zodiacTen && personTwo == zodiacFive)
            {
                return results = "35";
            }
            if (personOne == zodiacTen && personTwo == zodiacSix)
            {
                return results = "100";
            }
            if (personOne == zodiacTen && personTwo == zodiacSeven)
            {
                return results = "55";
            }
            if (personOne == zodiacTen && personTwo == zodiacEight)
            {
                return results = "95";
            }
            if (personOne == zodiacTen && personTwo == zodiacNine)
            {
                return results = "60";
            }
            if (personOne == zodiacTen && personTwo == zodiacTen)
            {
                return results = "75";
            }
            if (personOne == zodiacTen && personTwo == zodiacEleven)
            {
                return results = "68";
            }
            if (personOne == zodiacTen && personTwo == zodiacTwelve)
            {
                return results = "100";
            }

            //Aquarius Calcs
            if (personOne == zodiacEleven && personTwo == zodiacOne)
            {
                return results = "78";
            }
            if (personOne == zodiacEleven && personTwo == zodiacTwo)
            {
                return results = "58";
            }
            if (personOne == zodiacEleven && personTwo == zodiacThree)
            {
                return results = "100";
            }
            if (personOne == zodiacEleven && personTwo == zodiacFour)
            {
                return results = "27";
            }
            if (personOne == zodiacEleven && personTwo == zodiacFive)
            {
                return results = "68";
            }
            if (personOne == zodiacEleven && personTwo == zodiacSix)
            {
                return results = "55";
            }
            if (personOne == zodiacEleven && personTwo == zodiacSeven)
            {
                return results = "90";
            }
            if (personOne == zodiacEleven && personTwo == zodiacEight)
            {
                return results = "73";
            }
            if (personOne == zodiacEleven && personTwo == zodiacNine)
            {
                return results = "95";
            }
            if (personOne == zodiacEleven && personTwo == zodiacTen)
            {
                return results = "68";
            }
            if (personOne == zodiacEleven && personTwo == zodiacEleven)
            {
                return results = "45";
            }
            if (personOne == zodiacFive && personTwo == zodiacTwelve)
            {
                return results = "45";
            }

            //Pisces Calcs
            if (personOne == zodiacTwelve && personTwo == zodiacOne)
            {
                return results = "67";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacTwo)
            {
                return results = "85";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacThree)
            {
                return results = "53";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacFour)
            {
                return results = "100";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacFive)
            {
                return results = "38";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacSix)
            {
                return results = "88";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacSeven)
            {
                return results = "75";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacEight)
            {
                return results = "100";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacNine)
            {
                return results = "63";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacTen)
            {
                return results = "100";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacEleven)
            {
                return results = "45";
            }
            if (personOne == zodiacTwelve && personTwo == zodiacTwelve)
            {
                return results = "60";
            }


            else
            {
                return results = "Error";
            }
        }

        /*********************************
         * End Zodiac Calculations Method!
         ********************************/

        /***********************************
         * Myers-Briggs Calculations Method!
         **********************************/

        static string myersCalc(string personOne, string personTwo)
        {
            string myersOne = "INFJ";
            string myersTwo = "INTJ";
            string myersThree = "ENTJ";
            string myersFour = "ENFJ";
            string myersFive = "ENFP";
            string myersSix = "ENTP";
            string myersSeven = "INTP";
            string myersEight = "INFP";
            string myersNine = "ISFJ";
            string myersTen = "ISTJ";
            string myersEleven = "ESTJ";
            string myersTwelve = "ESFJ";
            string myersThirteen = "ESFP";
            string myersFourteen = "ESTP";
            string myersFifteen = "ISTP";
            string myersSixteen = "ISFP";
            string result;

            //INFP Calcs
            if (personOne == myersOne && personTwo == myersOne)
            {
                return result = "97.50";
            }
            if (personOne == myersOne && personTwo == myersTwo)
            {
                return result = "90";
            }
            if (personOne == myersOne && personTwo == myersThree)
            {
                return result = "55";
            }
            if (personOne == myersOne && personTwo == myersFour)
            {
                return result = "70";
            }
            if (personOne == myersOne && personTwo == myersFive)
            {
                return result = "100";
            }
            if (personOne == myersOne && personTwo == myersSix)
            {
                return result = "95";
            }
            if (personOne == myersOne && personTwo == myersSeven)
            {
                return result = "65";
            }
            if (personOne == myersOne && personTwo == myersEight)
            {
                return result = "75";
            }
            if (personOne == myersOne && personTwo == myersNine)
            {
                return result = "50";
            }
            if (personOne == myersOne && personTwo == myersTen)
            {
                return result = "45";
            }
            if (personOne == myersOne && personTwo == myersEleven)
            {
                return result = "40";
            }
            if (personOne == myersOne && personTwo == myersTwelve)
            {
                return result = "60";
            }
            if (personOne == myersOne && personTwo == myersThirteen)
            {
                return result = "85";
            }
            if (personOne == myersOne && personTwo == myersFourteen)
            {
                return result = "80";
            }
            if (personOne == myersOne && personTwo == myersFifteen)
            {
                return result = "30";
            }
            if (personOne == myersOne && personTwo == myersSixteen)
            {
                return result = "35";
            }

            //INTJ Calcs
            if (personOne == myersTwo && personTwo == myersOne)
            {
                return result = "90";
            }
            if (personOne == myersTwo && personTwo == myersTwo)
            {
                return result = "97.50";
            }
            if (personOne == myersTwo && personTwo == myersThree)
            {
                return result = "70";
            }
            if (personOne == myersTwo && personTwo == myersFour)
            {
                return result = "55";
            }
            if (personOne == myersTwo && personTwo == myersFive)
            {
                return result = "95";
            }
            if (personOne == myersTwo && personTwo == myersSix)
            {
                return result = "100";
            }
            if (personOne == myersTwo && personTwo == myersSeven)
            {
                return result = "75";
            }
            if (personOne == myersTwo && personTwo == myersEight)
            {
                return result = "85";
            }
            if (personOne == myersTwo && personTwo == myersNine)
            {
                return result = "45";
            }
            if (personOne == myersTwo && personTwo == myersTen)
            {
                return result = "50";
            }
            if (personOne == myersTwo && personTwo == myersEleven)
            {
                return result = "60";
            }
            if (personOne == myersTwo && personTwo == myersTwelve)
            {
                return result = "40";
            }
            if (personOne == myersTwo && personTwo == myersThirteen)
            {
                return result = "80";
            }
            if (personOne == myersTwo && personTwo == myersFourteen)
            {
                return result = "85";
            }
            if (personOne == myersTwo && personTwo == myersFifteen)
            {
                return result = "35";
            }
            if (personOne == myersTwo && personTwo == myersSixteen)
            {
                return result = "30";
            }

            //ENTJ Calcs
            if (personOne == myersThree && personTwo == myersOne)
            {
                return result = "55";
            }
            if (personOne == myersThree && personTwo == myersTwo)
            {
                return result = "70";
            }
            if (personOne == myersThree && personTwo == myersThree)
            {
                return result = "97.50";
            }
            if (personOne == myersThree && personTwo == myersFour)
            {
                return result = "90";
            }
            if (personOne == myersThree && personTwo == myersFive)
            {
                return result = "65";
            }
            if (personOne == myersThree && personTwo == myersSix)
            {
                return result = "75";
            }
            if (personOne == myersThree && personTwo == myersSeven)
            {
                return result = "100";
            }
            if (personOne == myersThree && personTwo == myersEight)
            {
                return result = "95";
            }
            if (personOne == myersThree && personTwo == myersNine)
            {
                return result = "40";
            }
            if (personOne == myersThree && personTwo == myersTen)
            {
                return result = "60";
            }
            if (personOne == myersThree && personTwo == myersEleven)
            {
                return result = "50";
            }
            if (personOne == myersThree && personTwo == myersTwelve)
            {
                return result = "45";
            }
            if (personOne == myersThree && personTwo == myersThirteen)
            {
                return result = "30";
            }
            if (personOne == myersThree && personTwo == myersFourteen)
            {
                return result = "35";
            }
            if (personOne == myersThree && personTwo == myersFifteen)
            {
                return result = "85";
            }
            if (personOne == myersThree && personTwo == myersSixteen)
            {
                return result = "80";
            }

            //ENFJ Calcs
            if (personOne == myersFour && personTwo == myersOne)
            {
                return result = "65";
            }
            if (personOne == myersFour && personTwo == myersTwo)
            {
                return result = "55";
            }
            if (personOne == myersFour && personTwo == myersThree)
            {
                return result = "90";
            }
            if (personOne == myersFour && personTwo == myersFour)
            {
                return result = "97.50";
            }
            if (personOne == myersFour && personTwo == myersFive)
            {
                return result = "75";
            }
            if (personOne == myersFour && personTwo == myersSix)
            {
                return result = "65";
            }
            if (personOne == myersFour && personTwo == myersSeven)
            {
                return result = "95";
            }
            if (personOne == myersFour && personTwo == myersEight)
            {
                return result = "100";
            }
            if (personOne == myersFour && personTwo == myersNine)
            {
                return result = "70";
            }
            if (personOne == myersFour && personTwo == myersTen)
            {
                return result = "40";
            }
            if (personOne == myersFour && personTwo == myersEleven)
            {
                return result = "45";
            }
            if (personOne == myersFour && personTwo == myersTwelve)
            {
                return result = "50";
            }
            if (personOne == myersFour && personTwo == myersThirteen)
            {
                return result = "35";
            }
            if (personOne == myersFour && personTwo == myersFourteen)
            {
                return result = "30";
            }
            if (personOne == myersFour && personTwo == myersFifteen)
            {
                return result = "80";
            }
            if (personOne == myersFour && personTwo == myersSixteen)
            {
                return result = "85";
            }

            //ENFP Calcs
            if (personOne == myersFive && personTwo == myersOne)
            {
                return result = "100";
            }
            if (personOne == myersFive && personTwo == myersTwo)
            {
                return result = "95";
            }
            if (personOne == myersFive && personTwo == myersThree)
            {
                return result = "60";
            }
            if (personOne == myersFive && personTwo == myersFour)
            {
                return result = "75";
            }
            if (personOne == myersFive && personTwo == myersFive)
            {
                return result = "97.50";
            }
            if (personOne == myersFive && personTwo == myersSix)
            {
                return result = "90";
            }
            if (personOne == myersFive && personTwo == myersSeven)
            {
                return result = "55";
            }
            if (personOne == myersFive && personTwo == myersEight)
            {
                return result = "70";
            }
            if (personOne == myersFive && personTwo == myersNine)
            {
                return result = "85";
            }
            if (personOne == myersFive && personTwo == myersTen)
            {
                return result = "80";
            }
            if (personOne == myersFive && personTwo == myersEleven)
            {
                return result = "40";
            }
            if (personOne == myersFive && personTwo == myersTwelve)
            {
                return result = "35";
            }
            if (personOne == myersFive && personTwo == myersThirteen)
            {
                return result = "50";
            }
            if (personOne == myersFive && personTwo == myersFourteen)
            {
                return result = "45";
            }
            if (personOne == myersFive && personTwo == myersFifteen)
            {
                return result = "40";
            }
            if (personOne == myersFive && personTwo == myersSixteen)
            {
                return result = "60";
            }

            //ENTP Calcs
            if (personOne == myersSix && personTwo == myersOne)
            {
                return result = "95";
            }
            if (personOne == myersSix && personTwo == myersTwo)
            {
                return result = "100";
            }
            if (personOne == myersSix && personTwo == myersThree)
            {
                return result = "75";
            }
            if (personOne == myersSix && personTwo == myersFour)
            {
                return result = "65";
            }
            if (personOne == myersSix && personTwo == myersFive)
            {
                return result = "90";
            }
            if (personOne == myersSix && personTwo == myersSix)
            {
                return result = "97.50";
            }
            if (personOne == myersSix && personTwo == myersSeven)
            {
                return result = "70";
            }
            if (personOne == myersSix && personTwo == myersEight)
            {
                return result = "55";
            }
            if (personOne == myersSix && personTwo == myersNine)
            {
                return result = "80";
            }
            if (personOne == myersSix && personTwo == myersTen)
            {
                return result = "85";
            }
            if (personOne == myersSix && personTwo == myersEleven)
            {
                return result = "35";
            }
            if (personOne == myersSix && personTwo == myersTwelve)
            {
                return result = "30";
            }
            if (personOne == myersSix && personTwo == myersThirteen)
            {
                return result = "45";
            }
            if (personOne == myersSix && personTwo == myersFourteen)
            {
                return result = "50";
            }
            if (personOne == myersSix && personTwo == myersFifteen)
            {
                return result = "60";
            }
            if (personOne == myersSix && personTwo == myersSixteen)
            {
                return result = "40";
            }

            //INTP Calcs
            if (personOne == myersSeven && personTwo == myersOne)
            {
                return result = "60";
            }
            if (personOne == myersSeven && personTwo == myersTwo)
            {
                return result = "75";
            }
            if (personOne == myersSeven && personTwo == myersThree)
            {
                return result = "100";
            }
            if (personOne == myersSeven && personTwo == myersFour)
            {
                return result = "95";
            }
            if (personOne == myersSeven && personTwo == myersFive)
            {
                return result = "55";
            }
            if (personOne == myersSeven && personTwo == myersSix)
            {
                return result = "70";
            }
            if (personOne == myersSeven && personTwo == myersSeven)
            {
                return result = "97.50";
            }
            if (personOne == myersSeven && personTwo == myersEight)
            {
                return result = "90";
            }
            if (personOne == myersSeven && personTwo == myersNine)
            {
                return result = "30";
            }
            if (personOne == myersSeven && personTwo == myersTen)
            {
                return result = "35";
            }
            if (personOne == myersSeven && personTwo == myersEleven)
            {
                return result = "85";
            }
            if (personOne == myersSeven && personTwo == myersTwelve)
            {
                return result = "80";
            }
            if (personOne == myersSeven && personTwo == myersThirteen)
            {
                return result = "40";
            }
            if (personOne == myersSeven && personTwo == myersFourteen)
            {
                return result = "60";
            }
            if (personOne == myersSeven && personTwo == myersFifteen)
            {
                return result = "50";
            }
            if (personOne == myersSeven && personTwo == myersSixteen)
            {
                return result = "45";
            }

            //INFP Calcs
            if (personOne == myersEight && personTwo == myersOne)
            {
                return result = "75";
            }
            if (personOne == myersEight && personTwo == myersTwo)
            {
                return result = "65";
            }
            if (personOne == myersEight && personTwo == myersThree)
            {
                return result = "95";
            }
            if (personOne == myersEight && personTwo == myersFour)
            {
                return result = "100";
            }
            if (personOne == myersEight && personTwo == myersFive)
            {
                return result = "70";
            }
            if (personOne == myersEight && personTwo == myersSix)
            {
                return result = "55";
            }
            if (personOne == myersEight && personTwo == myersSeven)
            {
                return result = "90";
            }
            if (personOne == myersEight && personTwo == myersEight)
            {
                return result = "97.50";
            }
            if (personOne == myersEight && personTwo == myersNine)
            {
                return result = "35";
            }
            if (personOne == myersEight && personTwo == myersTen)
            {
                return result = "30";
            }
            if (personOne == myersEight && personTwo == myersEleven)
            {
                return result = "80";
            }
            if (personOne == myersEight && personTwo == myersTwelve)
            {
                return result = "85";
            }
            if (personOne == myersEight && personTwo == myersThirteen)
            {
                return result = "60";
            }
            if (personOne == myersEight && personTwo == myersFourteen)
            {
                return result = "40";
            }
            if (personOne == myersEight && personTwo == myersFifteen)
            {
                return result = "45";
            }
            if (personOne == myersEight && personTwo == myersSixteen)
            {
                return result = "50";
            }

            //ISFJ Calcs
            if (personOne == myersNine && personTwo == myersOne)
            {
                return result = "50";
            }
            if (personOne == myersNine && personTwo == myersTwo)
            {
                return result = "45";
            }
            if (personOne == myersNine && personTwo == myersThree)
            {
                return result = "40";
            }
            if (personOne == myersNine && personTwo == myersFour)
            {
                return result = "60";
            }
            if (personOne == myersNine && personTwo == myersFive)
            {
                return result = "85";
            }
            if (personOne == myersNine && personTwo == myersSix)
            {
                return result = "80";
            }
            if (personOne == myersNine && personTwo == myersSeven)
            {
                return result = "30";
            }
            if (personOne == myersNine && personTwo == myersEight)
            {
                return result = "35";
            }
            if (personOne == myersNine && personTwo == myersNine)
            {
                return result = "97.50";
            }
            if (personOne == myersNine && personTwo == myersTen)
            {
                return result = "90";
            }
            if (personOne == myersNine && personTwo == myersEleven)
            {
                return result = "55";
            }
            if (personOne == myersNine && personTwo == myersTwelve)
            {
                return result = "70";
            }
            if (personOne == myersNine && personTwo == myersThirteen)
            {
                return result = "100";
            }
            if (personOne == myersNine && personTwo == myersFourteen)
            {
                return result = "95";
            }
            if (personOne == myersNine && personTwo == myersFifteen)
            {
                return result = "65";
            }
            if (personOne == myersNine && personTwo == myersSixteen)
            {
                return result = "75";
            }

            //ISTJ Calcs
            if (personOne == myersTen && personTwo == myersOne)
            {
                return result = "45";
            }
            if (personOne == myersTen && personTwo == myersTwo)
            {
                return result = "50";
            }
            if (personOne == myersTen && personTwo == myersThree)
            {
                return result = "60";
            }
            if (personOne == myersTen && personTwo == myersFour)
            {
                return result = "40";
            }
            if (personOne == myersTen && personTwo == myersFive)
            {
                return result = "80";
            }
            if (personOne == myersTen && personTwo == myersSix)
            {
                return result = "85";
            }
            if (personOne == myersTen && personTwo == myersSeven)
            {
                return result = "35";
            }
            if (personOne == myersTen && personTwo == myersEight)
            {
                return result = "30";
            }
            if (personOne == myersTen && personTwo == myersNine)
            {
                return result = "90";
            }
            if (personOne == myersTen && personTwo == myersTen)
            {
                return result = "97.50";
            }
            if (personOne == myersTen && personTwo == myersEleven)
            {
                return result = "70";
            }
            if (personOne == myersTen && personTwo == myersTwelve)
            {
                return result = "55";
            }
            if (personOne == myersTen && personTwo == myersThirteen)
            {
                return result = "95";
            }
            if (personOne == myersTen && personTwo == myersFourteen)
            {
                return result = "100";
            }
            if (personOne == myersTen && personTwo == myersFifteen)
            {
                return result = "75";
            }
            if (personOne == myersTen && personTwo == myersSixteen)
            {
                return result = "65";
            }

            //ESTJ Calcs
            if (personOne == myersEleven && personTwo == myersOne)
            {
                return result = "40";
            }
            if (personOne == myersEleven && personTwo == myersTwo)
            {
                return result = "60";
            }
            if (personOne == myersEleven && personTwo == myersThree)
            {
                return result = "50";
            }
            if (personOne == myersEleven && personTwo == myersFour)
            {
                return result = "45";
            }
            if (personOne == myersEleven && personTwo == myersFive)
            {
                return result = "30";
            }
            if (personOne == myersEleven && personTwo == myersSix)
            {
                return result = "35";
            }
            if (personOne == myersEleven && personTwo == myersSeven)
            {
                return result = "85";
            }
            if (personOne == myersEleven && personTwo == myersEight)
            {
                return result = "80";
            }
            if (personOne == myersEleven && personTwo == myersNine)
            {
                return result = "55";
            }
            if (personOne == myersEleven && personTwo == myersTen)
            {
                return result = "70";
            }
            if (personOne == myersEleven && personTwo == myersEleven)
            {
                return result = "98";
            }
            if (personOne == myersEleven && personTwo == myersTwelve)
            {
                return result = "90";
            }
            if (personOne == myersEleven && personTwo == myersThirteen)
            {
                return result = "65";
            }
            if (personOne == myersEleven && personTwo == myersFourteen)
            {
                return result = "75";
            }
            if (personOne == myersEleven && personTwo == myersFifteen)
            {
                return result = "100";
            }
            if (personOne == myersEleven && personTwo == myersSixteen)
            {
                return result = "95";
            }

            //ESFJ Calcs
            if (personOne == myersTwelve && personTwo == myersOne)
            {
                return result = "70";
            }
            if (personOne == myersTwelve && personTwo == myersTwo)
            {
                return result = "40";
            }
            if (personOne == myersTwelve && personTwo == myersThree)
            {
                return result = "45";
            }
            if (personOne == myersTwelve && personTwo == myersFour)
            {
                return result = "50";
            }
            if (personOne == myersTwelve && personTwo == myersFive)
            {
                return result = "35";
            }
            if (personOne == myersTwelve && personTwo == myersSix)
            {
                return result = "30";
            }
            if (personOne == myersTwelve && personTwo == myersSeven)
            {
                return result = "80";
            }
            if (personOne == myersTwelve && personTwo == myersEight)
            {
                return result = "85";
            }
            if (personOne == myersTwelve && personTwo == myersNine)
            {
                return result = "65";
            }
            if (personOne == myersTwelve && personTwo == myersTen)
            {
                return result = "55";
            }
            if (personOne == myersTwelve && personTwo == myersEleven)
            {
                return result = "90";
            }
            if (personOne == myersTwelve && personTwo == myersTwelve)
            {
                return result = "98";
            }
            if (personOne == myersTwelve && personTwo == myersThirteen)
            {
                return result = "75";
            }
            if (personOne == myersTwelve && personTwo == myersFourteen)
            {
                return result = "65";
            }
            if (personOne == myersTwelve && personTwo == myersFifteen)
            {
                return result = "95";
            }
            if (personOne == myersTwelve && personTwo == myersSixteen)
            {
                return result = "100";
            }

            //ESFP Calcs
            if (personOne == myersThirteen && personTwo == myersOne)
            {
                return result = "85";
            }
            if (personOne == myersThirteen && personTwo == myersTwo)
            {
                return result = "80";
            }
            if (personOne == myersThirteen && personTwo == myersThree)
            {
                return result = "30";
            }
            if (personOne == myersThirteen && personTwo == myersFour)
            {
                return result = "35";
            }
            if (personOne == myersThirteen && personTwo == myersFive)
            {
                return result = "50";
            }
            if (personOne == myersThirteen && personTwo == myersSix)
            {
                return result = "45";
            }
            if (personOne == myersThirteen && personTwo == myersSeven)
            {
                return result = "40";
            }
            if (personOne == myersThirteen && personTwo == myersEight)
            {
                return result = "60";
            }
            if (personOne == myersThirteen && personTwo == myersNine)
            {
                return result = "100";
            }
            if (personOne == myersThirteen && personTwo == myersTen)
            {
                return result = "95";
            }
            if (personOne == myersThirteen && personTwo == myersEleven)
            {
                return result = "60";
            }
            if (personOne == myersThirteen && personTwo == myersTwelve)
            {
                return result = "75";
            }
            if (personOne == myersThirteen && personTwo == myersThirteen)
            {
                return result = "97.50";
            }
            if (personOne == myersThirteen && personTwo == myersFourteen)
            {
                return result = "90";
            }
            if (personOne == myersThirteen && personTwo == myersFifteen)
            {
                return result = "55";
            }
            if (personOne == myersThirteen && personTwo == myersSixteen)
            {
                return result = "70";
            }

            //ESTP Calcs
            if (personOne == myersFourteen && personTwo == myersOne)
            {
                return result = "80";
            }
            if (personOne == myersFourteen && personTwo == myersTwo)
            {
                return result = "85";
            }
            if (personOne == myersFourteen && personTwo == myersThree)
            {
                return result = "35";
            }
            if (personOne == myersFourteen && personTwo == myersFour)
            {
                return result = "30";
            }
            if (personOne == myersFourteen && personTwo == myersFive)
            {
                return result = "45";
            }
            if (personOne == myersFourteen && personTwo == myersSix)
            {
                return result = "50";
            }
            if (personOne == myersFourteen && personTwo == myersSeven)
            {
                return result = "60";
            }
            if (personOne == myersFourteen && personTwo == myersEight)
            {
                return result = "40";
            }
            if (personOne == myersFourteen && personTwo == myersNine)
            {
                return result = "95";
            }
            if (personOne == myersFourteen && personTwo == myersTen)
            {
                return result = "100";
            }
            if (personOne == myersFourteen && personTwo == myersEleven)
            {
                return result = "75";
            }
            if (personOne == myersFourteen && personTwo == myersTwelve)
            {
                return result = "65";
            }
            if (personOne == myersFourteen && personTwo == myersThirteen)
            {
                return result = "90";
            }
            if (personOne == myersFourteen && personTwo == myersFourteen)
            {
                return result = "98";
            }
            if (personOne == myersFourteen && personTwo == myersFifteen)
            {
                return result = "70";
            }
            if (personOne == myersFourteen && personTwo == myersSixteen)
            {
                return result = "55";
            }

            //ISTP Calcs
            if (personOne == myersFifteen && personTwo == myersOne)
            {
                return result = "30";
            }
            if (personOne == myersFifteen && personTwo == myersTwo)
            {
                return result = "35";
            }
            if (personOne == myersFifteen && personTwo == myersThree)
            {
                return result = "85";
            }
            if (personOne == myersFifteen && personTwo == myersFour)
            {
                return result = "80";
            }
            if (personOne == myersFifteen && personTwo == myersFive)
            {
                return result = "40";
            }
            if (personOne == myersFifteen && personTwo == myersSix)
            {
                return result = "60";
            }
            if (personOne == myersFifteen && personTwo == myersSeven)
            {
                return result = "50";
            }
            if (personOne == myersFifteen && personTwo == myersEight)
            {
                return result = "45";
            }
            if (personOne == myersFifteen && personTwo == myersNine)
            {
                return result = "60";
            }
            if (personOne == myersFifteen && personTwo == myersTen)
            {
                return result = "75";
            }
            if (personOne == myersFifteen && personTwo == myersEleven)
            {
                return result = "100";
            }
            if (personOne == myersFifteen && personTwo == myersTwelve)
            {
                return result = "95";
            }
            if (personOne == myersFifteen && personTwo == myersThirteen)
            {
                return result = "55";
            }
            if (personOne == myersFifteen && personTwo == myersFourteen)
            {
                return result = "70";
            }
            if (personOne == myersFifteen && personTwo == myersFifteen)
            {
                return result = "98";
            }
            if (personOne == myersFifteen && personTwo == myersSixteen)
            {
                return result = "90";
            }

            //ISFP Calcs
            if (personOne == myersSixteen && personTwo == myersOne)
            {
                return result = "35";
            }
            if (personOne == myersSixteen && personTwo == myersTwo)
            {
                return result = "30";
            }
            if (personOne == myersSixteen && personTwo == myersThree)
            {
                return result = "80";
            }
            if (personOne == myersSixteen && personTwo == myersFour)
            {
                return result = "85";
            }
            if (personOne == myersSixteen && personTwo == myersFive)
            {
                return result = "60";
            }
            if (personOne == myersSixteen && personTwo == myersSix)
            {
                return result = "40";
            }
            if (personOne == myersSixteen && personTwo == myersSeven)
            {
                return result = "45";
            }
            if (personOne == myersSixteen && personTwo == myersEight)
            {
                return result = "50";
            }
            if (personOne == myersSixteen && personTwo == myersNine)
            {
                return result = "75";
            }
            if (personOne == myersSixteen && personTwo == myersTen)
            {
                return result = "65";
            }
            if (personOne == myersSixteen && personTwo == myersEleven)
            {
                return result = "95";
            }
            if (personOne == myersSixteen && personTwo == myersTwelve)
            {
                return result = "100";
            }
            if (personOne == myersSixteen && personTwo == myersThirteen)
            {
                return result = "70";
            }
            if (personOne == myersSixteen && personTwo == myersFourteen)
            {
                return result = "55";
            }
            if (personOne == myersSixteen && personTwo == myersFifteen)
            {
                return result = "90";
            }
            if (personOne == myersSixteen && personTwo == myersSixteen)
            {
                return result = "98";
            }

            else
            {
                return result = "Error";
            }

        }

        /***************************************
         * End Myers-Briggs Calculations Method!
         **************************************/

        /*********************************
         * Enneagram Calculations Method!
         ********************************/

        static string ennCalc(string personOne, string personTwo)
        {
            string typeOne = "Type One";
            string typeTwo = "Type Two";
            string typeThree = "Type Three";
            string typeFour = "Type Four";
            string typeFive = "Type Five";
            string typeSix = "Type Six";
            string typeSeven = "Type Seven";
            string typeEight = "Type Eight";
            string typeNine = "Type Nine";
            string results;

            //Type One Calc
            if (personOne == typeOne && personTwo == typeOne)
            {
                return results = "77.80";
            }
            if (personOne == typeOne && personTwo == typeTwo)
            {
                return results = "88.90";
            }
            if (personOne == typeOne && personTwo == typeThree)
            {
                return results = "95";
            }
            if (personOne == typeOne && personTwo == typeFour)
            {
                return results = "55";
            }
            if (personOne == typeOne && personTwo == typeFive)
            {
                return results = "100";
            }
            if (personOne == typeOne && personTwo == typeSix)
            {
                return results = "66.70";
            }
            if (personOne == typeOne && personTwo == typeSeven)
            {
                return results = "100";
            }
            if (personOne == typeOne && personTwo == typeEight)
            {
                return results = "30";
            }
            if (personOne == typeOne && personTwo == typeNine)
            {
                return results = "95";
            }

            //Type Two Calc
            if (personOne == typeTwo && personTwo == typeOne)
            {
                return results = "88.90";
            }
            if (personOne == typeTwo && personTwo == typeTwo)
            {
                return results = "55";
            }
            if (personOne == typeTwo && personTwo == typeThree)
            {
                return results = "77.80";
            }
            if (personOne == typeTwo && personTwo == typeFour)
            {
                return results = "88.90";
            }
            if (personOne == typeTwo && personTwo == typeFive)
            {
                return results = "77.80";
            }
            if (personOne == typeTwo && personTwo == typeSix)
            {
                return results = "88.90";
            }
            if (personOne == typeTwo && personTwo == typeSeven)
            {
                return results = "68";
            }
            if (personOne == typeTwo && personTwo == typeEight)
            {
                return results = "95";
            }
            if (personOne == typeTwo && personTwo == typeNine)
            {
                return results = "77.80";
            }

            //Type Three Calc
            if (personOne == typeThree && personTwo == typeOne)
            {
                return results = "100";
            }
            if (personOne == typeThree && personTwo == typeTwo)
            {
                return results = "77.80";
            }
            if (personOne == typeThree && personTwo == typeThree)
            {
                return results = "65";
            }
            if (personOne == typeThree && personTwo == typeFour)
            {
                return results = "65";
            }
            if (personOne == typeThree && personTwo == typeFive)
            {
                return results = "95";
            }
            if (personOne == typeThree && personTwo == typeSix)
            {
                return results = "50";
            }
            if (personOne == typeThree && personTwo == typeSeven)
            {
                return results = "77.80";
            }
            if (personOne == typeThree && personTwo == typeEight)
            {
                return results = "30";
            }
            if (personOne == typeThree && personTwo == typeNine)
            {
                return results = "88.90";
            }

            //Type Four Calc
            if (personOne == typeFour && personTwo == typeOne)
            {
                return results = "55";
            }
            if (personOne == typeFour && personTwo == typeTwo)
            {
                return results = "88.90";
            }
            if (personOne == typeFour && personTwo == typeThree)
            {
                return results = "65";
            }
            if (personOne == typeFour && personTwo == typeFour)
            {
                return results = "50";
            }
            if (personOne == typeFour && personTwo == typeFive)
            {
                return results = "77.80";
            }
            if (personOne == typeFour && personTwo == typeSix)
            {
                return results = "40";
            }
            if (personOne == typeFour && personTwo == typeSeven)
            {
                return results = "55.50";
            }
            if (personOne == typeFour && personTwo == typeEight)
            {
                return results = "70";
            }
            if (personOne == typeFour && personTwo == typeNine)
            {
                return results = "95";
            }

            //Type Five Calc
            if (personOne == typeFive && personTwo == typeOne)
            {
                return results = "100";
            }
            if (personOne == typeFive && personTwo == typeTwo)
            {
                return results = "77.80";
            }
            if (personOne == typeFive && personTwo == typeThree)
            {
                return results = "95";
            }
            if (personOne == typeFive && personTwo == typeFour)
            {
                return results = "77.80";
            }
            if (personOne == typeFive && personTwo == typeFive)
            {
                return results = "90";
            }
            if (personOne == typeFive && personTwo == typeSix)
            {
                return results = "70";
            }
            if (personOne == typeFive && personTwo == typeSeven)
            {
                return results = "90";
            }
            if (personOne == typeFive && personTwo == typeEight)
            {
                return results = "30";
            }
            if (personOne == typeFive && personTwo == typeNine)
            {
                return results = "65";
            }

            //Type Six Calc
            if (personOne == typeSix && personTwo == typeOne)
            {
                return results = "66.70";
            }
            if (personOne == typeSix && personTwo == typeTwo)
            {
                return results = "88.90";
            }
            if (personOne == typeSix && personTwo == typeThree)
            {
                return results = "50";
            }
            if (personOne == typeSix && personTwo == typeFour)
            {
                return results = "40";
            }
            if (personOne == typeSix && personTwo == typeFive)
            {
                return results = "70";
            }
            if (personOne == typeSix && personTwo == typeSix)
            {
                return results = "65";
            }
            if (personOne == typeSix && personTwo == typeSeven)
            {
                return results = "30";
            }
            if (personOne == typeSix && personTwo == typeEight)
            {
                return results = "90";
            }
            if (personOne == typeSix && personTwo == typeNine)
            {
                return results = "90";
            }

            //Type Seven Calc
            if (personOne == typeSeven && personTwo == typeOne)
            {
                return results = "100";
            }
            if (personOne == typeSeven && personTwo == typeTwo)
            {
                return results = "68";
            }
            if (personOne == typeSeven && personTwo == typeThree)
            {
                return results = "77.80";
            }
            if (personOne == typeSeven && personTwo == typeFour)
            {
                return results = "55.50";
            }
            if (personOne == typeSeven && personTwo == typeFive)
            {
                return results = "90";
            }
            if (personOne == typeSeven && personTwo == typeSix)
            {
                return results = "30";
            }
            if (personOne == typeSeven && personTwo == typeSeven)
            {
                return results = "50";
            }
            if (personOne == typeSeven && personTwo == typeEight)
            {
                return results = "70";
            }
            if (personOne == typeSeven && personTwo == typeNine)
            {
                return results = "88.90";
            }

            //Type Eight Calc
            if (personOne == typeEight && personTwo == typeOne)
            {
                return results = "30";
            }
            if (personOne == typeEight && personTwo == typeTwo)
            {
                return results = "95";
            }
            if (personOne == typeEight && personTwo == typeThree)
            {
                return results = "30";
            }
            if (personOne == typeEight && personTwo == typeFour)
            {
                return results = "70";
            }
            if (personOne == typeEight && personTwo == typeFive)
            {
                return results = "30";
            }
            if (personOne == typeEight && personTwo == typeSix)
            {
                return results = "90";
            }
            if (personOne == typeEight && personTwo == typeSeven)
            {
                return results = "70";
            }
            if (personOne == typeEight && personTwo == typeEight)
            {
                return results = "45";
            }
            if (personOne == typeEight && personTwo == typeNine)
            {
                return results = "95";
            }

            //Type Nine Calc
            if (personOne == typeNine && personTwo == typeOne)
            {
                return results = "95";
            }
            if (personOne == typeNine && personTwo == typeTwo)
            {
                return results = "77.80";
            }
            if (personOne == typeNine && personTwo == typeThree)
            {
                return results = "88.90";
            }
            if (personOne == typeNine && personTwo == typeFour)
            {
                return results = "95";
            }
            if (personOne == typeNine && personTwo == typeFive)
            {
                return results = "65";
            }
            if (personOne == typeNine && personTwo == typeSix)
            {
                return results = "90";
            }
            if (personOne == typeNine && personTwo == typeSeven)
            {
                return results = "88.90";
            }
            if (personOne == typeNine && personTwo == typeEight)
            {
                return results = "95";
            }
            if (personOne == typeNine && personTwo == typeNine)
            {
                return results = "30";
            }

            else
            {
                return results = "Error";
            }
        }

        /*********************************
         * End Enneagram Calculations Method!
         ********************************/


        private void button1_Click(object sender, EventArgs e)
        {
            /********************************************
             * Upon press, calculations begin!
             *******************************************/
            try
            {
                string personOneZodiac = zodiacOptionsOne.SelectedItem.ToString();
                string personTwoZodiac = zodiacOptionsTwo.SelectedItem.ToString();
                zodiacTotal.Text = zodCalc(personOneZodiac, personTwoZodiac) + "%";
                decimal finalOne = decimal.Parse(zodCalc(personOneZodiac, personTwoZodiac));

                string personOneMBTI = myersOptionOne.SelectedItem.ToString();
                string personTwoMBTI = myersOptionTwo.SelectedItem.ToString();
                myersTotal.Text = myersCalc(personOneMBTI, personTwoMBTI) + "%";
                decimal finalTwo = decimal.Parse(myersCalc(personOneMBTI, personTwoMBTI));

                string personOneEnn = ennOptionOne.SelectedItem.ToString();
                string personTwoEnn = ennOptionTwo.SelectedItem.ToString();
                string skipMe = "Skip";
                if(personOneEnn != skipMe)
                {
                    ennTotal.Text = ennCalc(personOneEnn, personTwoEnn) + "%";
                    decimal finalThree = decimal.Parse(ennCalc(personOneEnn, personTwoEnn));
                    decimal grandTotalPtOne = finalOne + finalTwo + finalThree;
                    decimal grandTotalPtTwo = grandTotalPtOne / 3;
                    decimal grandTotal = Decimal.Round(grandTotalPtTwo, 2);
                    string grandTot = grandTotal.ToString();
                    bigTotal.Text = grandTotal + "%";
                }
                else
                {
                    ennTotal.Text = "Skipped!";
                    decimal grandTotalPtOne = finalOne + finalTwo;
                    decimal grandTotalPtTwo = (grandTotalPtOne / 2);
                    decimal grandTotal = Decimal.Round(grandTotalPtTwo, 2);
                    string grandTot = grandTotal.ToString();
                    bigTotal.Text = grandTotal + "%";
                }

            }//end try
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong with your input! Did you forget to select a category or forget to select 'Skip' for Enneagram?\n" + x.Message);
            }//end catch
        }
    }
}
