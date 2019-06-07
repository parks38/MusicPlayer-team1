using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace MusicPlayer_team1
{
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void AddButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            AddMusic _addMusic = new AddMusic();
            await _addMusic.AddMedia(playList, mediaPlayer);
        }

        
            private void ShuffleButton_Click(object sender, RoutedEventArgs e)
            {

            }

            private void DeleteButton_Click(object sender, RoutedEventArgs e)
            {

            }
        }
   
}
