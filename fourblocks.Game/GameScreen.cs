using System.Collections.Generic;
using fourblocks.Game.UI;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Screens;
using osuTK;
using osuTK.Graphics;

namespace fourblocks.Game
{
    public class GameScreen : Screen
    {
        private readonly MenuList mainMenu;

        public GameScreen()
        {
            mainMenu = new MenuList(Direction.Vertical, true, Color4.LightPink, Color4.Firebrick)
            {
                Name = "MainMenu",
                Anchor = Anchor.CentreLeft,
                Origin = Anchor.CentreLeft,
                Items = new List<MenuItem>() { new MenuItem("Play", playClicked), new MenuItem("Settings", settingsClicked), new MenuItem("Exit", exitClicked) },
                Colour = Colour4.White,
                BackgroundColour = Color4.LightPink,
                Scale = new Vector2(5),
            };
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new Box()
                {
                    Colour = Color4.Black,
                    RelativeSizeAxes = Axes.Both
                },
                mainMenu,
                new BasicTextBox()
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(1000, 64),
                    Colour = Colour4.White,
                }
            };
        }

        private void playClicked()
        {
        }

        private void settingsClicked()
        {
        }

        private void exitClicked()
        {
            Game.Exit();
        }
    }
}
