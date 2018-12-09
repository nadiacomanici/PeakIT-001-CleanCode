using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStates_End.Logic
{
    public enum PlayerStates
    {
        Uninitialized = 0,
        VideoLoaded = 1,
        Playing = 2,
        Paused = 3,
        Stopped = 4
    }
}
