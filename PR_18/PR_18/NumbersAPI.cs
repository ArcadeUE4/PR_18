using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;
using Xamarin.Forms;

namespace PR_18
{
    public class NumbersAPI
    {
        private string text;
        private bool found;
        private int number;
        private string type;
        private DateTime date;

        #region PropertyChanged

        public string Text
        {
            get { return text; }
            private set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

       public bool Found
        {
            get { return found; }
            private set
            {
                found = value;
                OnPropertyChanged("Found");
            }
        }

       public int Number
        {
            get { return number; }
            private set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }

       public string Type
        {
            get { return type; }
            private set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        public DateTime Date
        { 
            get  { return date; }
            set 
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

#endregion

        public NumbersAPI()
        {
            LoadDataCommand = new Command(LoadData);
        }

        public ICommand LoadDataCommand { protected get; set; }

        private async void LoadData()
        {

            string url = "http://numbersapi.com/random/year?json";

            try
            {
                using (var webClient = new WebClient())
                {

                    var response = webClient.DownloadString(url);

                    var rateInfo = JsonConvert.DeserializeObject<NumbersFactsPage>(response);

                    this.Text = rateInfo.Text;
                    this.Found = rateInfo.Found;
                    this.Number = rateInfo.Number;
                    this.Type = rateInfo.Type;
                    this.Date = rateInfo.Date;

                }
            }

            catch (Exception ex)
            { }


        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }



    }
}
