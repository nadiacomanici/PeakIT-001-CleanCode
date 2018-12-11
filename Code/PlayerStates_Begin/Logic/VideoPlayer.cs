using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStates_Begin.Logic
{
    public class VideoPlayer
    {
        private int CurrentState = 0;

        public void TogglePlayPause()
        {
            if (CurrentState == 1)
            {
                Play();
            }
            else
            {
                if (CurrentState == 2)
                {
                    Pause();
                }
                else
                {
                    throw new InvalidOperationException("Wrong player state");
                }
            }
        }

        private void Play()
        {
            Console.WriteLine("Play");
            CurrentState = 2;
        }

        private void Pause()
        {
            Console.WriteLine("Pause");
            CurrentState = 3;
        }

        public void PlayVideo(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);

            if ((fileExtension == ".mp4" || fileExtension == ".avi")
                && (CurrentState != 2 || CurrentState == 3))
            {
                LoadVideo(fileName);
                Play();
            }
        }

        private void LoadVideo(string fileName)
        {
            Console.WriteLine("Loading Video");
            CurrentState = 1;
        }
    }
}
