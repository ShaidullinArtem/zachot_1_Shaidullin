using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zachet_1_Shaidullin.types;

namespace zachet_1_Shaidullin
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent( );
        }

        static void checkInitialFiles (string fileOnePath, string fileTwoPath)
        {
            if (!File.Exists(fileOnePath) || File.ReadLines(fileOnePath).ToArray().Length == 0)
            {
                File.Create(fileOnePath);
                string [ ] initialData = new string [ 2 ] { "1 Турция", "2 Египит" };
                File.AppendAllLines(fileOnePath, initialData);
            }

            if (!File.Exists(fileTwoPath) || File.ReadLines(fileTwoPath).ToArray( ).Length == 0 )
            {
                File.Create(fileTwoPath);
                string [ ] initialData = new string [ 2 ] { "1 Rivas 2 2000", "2 Sonesta 1 1600" };
                File.AppendAllLines(fileTwoPath, initialData);
            }
        }

        static Dictionary<string, string> collectCountryData(string filePath)
        {
            Dictionary<string, string> countryCollection = new Dictionary<string, string> ();

            foreach ( string line in File.ReadLines(filePath) )
            {
                string [ ] data = line.Split(new char [ ] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray<string>( );
                countryCollection.Add(data [ 0 ], data [ 1 ]);
            }

            return countryCollection;
        }

        static Dictionary<string, HotelType> collectHotelData(string filePath)
        {
            Dictionary<string, HotelType> hotelCollection = new Dictionary<string, HotelType>( );

            foreach (string line in File.ReadLines(filePath))
            {
                string [ ] data = line.Split(new char [ ] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray<string>( );
                HotelType hotel = new HotelType(data [1], int.Parse(data [2]), double.Parse(data [3]));
                hotelCollection.Add(data [ 0 ], hotel);
            }

            return hotelCollection;
        }

        static List<TourType> concatData(Dictionary<string, string> countryData, Dictionary<string, HotelType> hotelData)
        {
            List<TourType> concatData = new List<TourType> { };

            foreach (var country in countryData)
            { 
                foreach (var hotel in hotelData)
                {
                    if ( country.Key == hotel.Key ) concatData.Add(new TourType(country.Key, country.Value, hotel.Value.title, hotel.Value.count, hotel.Value.price));
                }
            }

            return concatData;
        }


        private void items_box_SelectedIndexChanged (object sender, EventArgs e)
        {
            remove_item_button.Enabled = true;
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            // checkInitialFiles("country.txt", "hotel.txt");
            Dictionary<string, string> countries = collectCountryData("./country.txt");
            Dictionary<string, HotelType> hotels = collectHotelData("./hotel.txt");
            List<TourType> data = concatData(countries, hotels);

            foreach (TourType item in data)
            {
                items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
            }
        }

        private void remove_item_button_Click (object sender, EventArgs e)
        {
            int curItem = items_box.SelectedIndex;
            items_box.Items.RemoveAt(curItem);
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            items_box.Items.Clear( );
            string parametr = comboBox1.GetItemText(comboBox1.SelectedIndex).ToString();

            Dictionary<string, string> countries = collectCountryData("./country.txt");
            Dictionary<string, HotelType> hotels = collectHotelData("./hotel.txt");
            var data = concatData(countries, hotels);
            switch ( parametr )
            {
                case "0":
                    foreach ( TourType item in data.OrderBy(item => item.id) )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
                case "1":
                    foreach ( TourType item in data.OrderBy(item => item.country) )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
                case "2":
                    foreach ( TourType item in data.OrderBy(item => item.hotelTitle) )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
                case "3":
                    foreach ( TourType item in data.OrderBy(item => item.country) )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
                case "4":
                    foreach ( TourType item in data.OrderBy(item => item.price) )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
                default:
                    foreach ( TourType item in data )
                    {
                        items_box.Items.Add($"{item.id} {item.hotelTitle} {item.country} {item.count}*{item.price}");
                    }
                    break;
            }
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }
    }
}
