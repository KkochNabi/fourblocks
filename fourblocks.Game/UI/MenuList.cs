using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osuTK.Graphics;

namespace fourblocks.Game.UI
{
    public class MenuList : Menu
    {
        private Color4 ItemBackgroundColor;
        private Color4 ItemBackgroundHoverColor;

        public MenuList(Direction direction = Direction.Vertical, bool topLevelMenu = true, Color4 itemBackgroundColor = default, Color4 itemBackgroundHoverColor = default)
            : base(direction, topLevelMenu)
        {
            // osu!framework defaults
            BackgroundColour = Colour4.Blue;
            ItemBackgroundColor = itemBackgroundColor == default ? FrameworkColour.BlueGreen : itemBackgroundColor;
            ItemBackgroundHoverColor = itemBackgroundHoverColor == default ? FrameworkColour.Green : itemBackgroundHoverColor;
        }

        protected override Menu CreateSubMenu() => new MenuList()
        {
            Anchor = Direction == Direction.Horizontal ? Anchor.BottomLeft : Anchor.TopRight
        };

        protected override DrawableMenuItem CreateDrawableMenuItem(MenuItem item) => new ModularDrawableMenuItem(item, ItemBackgroundColor, ItemBackgroundHoverColor);

        protected override ScrollContainer<Drawable> CreateScrollContainer(Direction direction) => new BasicScrollContainer(direction); // TODO: Add custom method?

        public class ModularDrawableMenuItem : Menu.DrawableMenuItem
        {
            public Color4 BackgroundColor;
            public Color4 BackgroundHoverColor;

            public ModularDrawableMenuItem(MenuItem item, Color4 color, Color4 hoverColor)
                : base(item)
            {
                BackgroundColor = BackgroundColour = color;
                BackgroundHoverColor = BackgroundColourHover = hoverColor;
            }

            protected override Drawable CreateContent() => new SpriteText()
            {
                Anchor = Anchor.CentreLeft,
                Origin = Anchor.CentreLeft,
                Padding = new MarginPadding(2),
                Font = FrameworkFont.Condensed,
            };
        }
    }


}
