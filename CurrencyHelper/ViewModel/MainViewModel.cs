using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using CurrencyHelper.Pages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace CurrencyHelper.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Page Main;
        private Page Converter;
        private Page Favourites;
        private Page Feedback;
        private Page Settings;
        private Page Notes;

        private Page _currentPage;
        public Page CurrentPage     
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
                RaisePropertyChanged(nameof(CurrentPage));
            }
        }


        private double _frameOpacity;
        public double FrameOpacity       
        {
            get
            {
                return _frameOpacity;
            }
            set
            {
                _frameOpacity = value;
                RaisePropertyChanged(nameof(FrameOpacity));
            }
        }


        public MainViewModel()
        {
            Main = new Main();
            Favourites = new Favourites();
            Converter = new Converter();
            Settings = new Settings();
            Feedback = new Feedback();
            Notes = new Notes();

            CurrentPage = Main;
            FrameOpacity = 1;   
        }

        public ICommand MainpageBtn_Click
        {
            
            get
            {
                return new RelayCommand(() => CurrentPage = Main);
            }
        }

        public ICommand ConvertBtn_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Converter);
            }
        }

        public ICommand FavouritesBtn_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Favourites);
            }
        }

        public ICommand SettingsBtn_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Settings);
            }
        }

        public ICommand FeedbackBtn_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Feedback);
            }
        }


        public ICommand NotesBtn_Click
        {
            get
            {
                return  new RelayCommand(() => CurrentPage = Notes);
            }
        }       
    }

      


}





       