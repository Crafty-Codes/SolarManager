using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SolarManager.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private string _ipEntry;

        public string IpEntry
        {
            get {
                IpEntryPlaceholderColor = new Color(0,0,0);
                IpEntryColor = new Color(0,0,0);    
                return _ipEntry; 
            }
            set { SetProperty(ref _ipEntry, value); }
        }

        private Color _ipEntryColor;

        public Color IpEntryColor
        {
            get { return _ipEntryColor; }
            set { SetProperty(ref _ipEntryColor, value); }
        }  
        
        private Color _ipEntryPlaceholderColor;

        public Color IpEntryPlaceholderColor
        {
            get { return _ipEntryPlaceholderColor; }
            set { SetProperty(ref _ipEntryPlaceholderColor, value); }
        }

        public MainPageViewModel() 
        {
            SetIp = new Command(SetIpHandler);
        }

        private void SetIpHandler(object obj)

        {
            Regex rx = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            Match mc = rx.Match(IpEntry);

            if (mc.Success)
            {
                IpEntryColor = new Color(0, 255, 0);
                return;
            }

            IpEntry = "";
            IpEntryPlaceholderColor = new Color(255, 0, 0);
        }

        public ICommand SetIp { private set; get; }     



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
