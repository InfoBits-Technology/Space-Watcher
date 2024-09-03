using System.Runtime.InteropServices;
using System.Text;





namespace Space_Sound
{
    public class SoundSystem
    {
        [DllImport("winmm.dll")]
        private static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize,
                                  IntPtr hwndCallback);
        public void Play(string sound, string alias, string type)
        {
            Close(alias);
            mciSendString($"open {sound} type {type}  alias {alias}", null, 0, IntPtr.Zero);
            mciSendString($"play {alias}", null, 0, IntPtr.Zero);
        }

        public void Close(string alias)
        {
            string command = $"close {alias}";
            mciSendString(command, null, 0, 0);
        }

    }
}