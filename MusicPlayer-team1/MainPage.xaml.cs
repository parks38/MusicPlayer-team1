using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using System.Windows.Input;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicPlayer_team1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       

        public MainPage()
        {
            
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
            mediaPlayerElement.AutoPlay = true;
        }

        


        

            private void ShuffleButton_Click(object sender, RoutedEventArgs e)
            {

            }

            private void DeleteButton_Click(object sender, RoutedEventArgs e)
            {

            }

        private void MediaTransportControls_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Space)
                e.Handled = true;

            if (mediaPlayerElement.MediaPlayer.PlaybackSession.PlaybackState == Windows.Media.Playback.MediaPlaybackState.Playing)
            {
                mediaPlayerElement.MediaPlayer.Pause();
            }
            else if (mediaPlayerElement.MediaPlayer.PlaybackSession.PlaybackState == Windows.Media.Playback.MediaPlaybackState.Paused)
            {
                mediaPlayerElement.MediaPlayer.Play();
            }
        }
    }
   
}
