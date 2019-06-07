using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage.Pickers;

namespace MusicPlayer_team1
{
    public class AddMusic
    {
        MediaSource mediaSource;


        MediaPlayer mediaPlayer;


        private async System.Threading.Tasks.Task AddMedia()
        {

            var filePicker = new Windows.Storage.Pickers.FileOpenPicker();
            string[] fileTypes = new string[] { ".wmv", ".mp3", ".mp4" };
            foreach (string fileType in fileTypes)
            {
                filePicker.FileTypeFilter.Add(fileType);


            }
            filePicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            Windows.Storage.StorageFile file = await filePicker.PickMultipleFilesAsync;
            if (!(file is null))
            {

                mediaSource = MediaSource.CreateFromStorageFile(file);
                mediaPlayer.Source = mediaSource;
                




            }
        }

    }

}
