using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStates_End.Logic
{
    public class VideoPlayer
    {
        private PlayerStates CurrentState = PlayerStates.Uninitialized;

        public void TogglePlayPause()
        {
            switch (CurrentState)
            {
                case PlayerStates.VideoLoaded:
                    Play();
                    break;
                case PlayerStates.Playing:
                    Pause();
                    break;
                default:
                    throw new InvalidOperationException("Wrong player state");
            }
        }

        private void Play()
        {
            Console.WriteLine("Play");
            CurrentState = PlayerStates.Playing;
        }

        private void Pause()
        {
            Console.WriteLine("Pause");
            CurrentState = PlayerStates.Paused;
        }

        private bool IsExtensionValid(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            return (fileExtension == ".mp4" || fileExtension == ".avi");
        }

        private bool CanPlayNewVideo()
        {
            return (CurrentState != PlayerStates.Playing || CurrentState == PlayerStates.Paused);
        }

        public void PlayVideo(string fileName)
        {
            if (IsExtensionValid(fileName) && CanPlayNewVideo())
            {
                LoadVideo(fileName);
                Play();
            }
        }

        private void LoadVideo(string fileName)
        {
            Console.WriteLine("Loading Video");
            CurrentState = PlayerStates.VideoLoaded;
        }
    }
}
