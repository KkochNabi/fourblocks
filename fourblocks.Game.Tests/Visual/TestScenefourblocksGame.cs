using osu.Framework.Allocation;
using osu.Framework.Platform;
using osu.Framework.Testing;

namespace fourblocks.Game.Tests.Visual
{
    public class TestScenefourblocksGame : TestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private fourblocksGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new fourblocksGame();
            game.SetHost(host);

            Add(game);
        }
    }
}