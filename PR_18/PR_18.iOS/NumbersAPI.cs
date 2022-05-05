using Newtonsoft.Json;

using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace PR_18
{
    public class NumbersAPI : INotifyPropertyChanged
    {
        private string text;
        private bool found;
        private int number;
        private string type;
        private string date;
    }
}