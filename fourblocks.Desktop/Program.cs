using osu.Framework.Platform;
using osu.Framework;
using fourblocks.Game;

namespace fourblocks.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"fourblocks"))
            using (osu.Framework.Game game = new fourblocksGame())
                host.Run(game);
        }
    }
}