using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BottomUpAnalysis
{
    public static class Helper
    {
        private static int _sleep;

        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void Sleep(int milliseconds)
        {
            DateTime start = DateTime.Now;
            for (;;)
            {
                if ((DateTime.Now - start).TotalMilliseconds > milliseconds)
                    break;

                for (int i = 0; i < 10; i++)
                    _sleep += i;
            }
        }
    }
}
