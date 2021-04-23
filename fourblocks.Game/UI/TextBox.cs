using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;

namespace fourblocks.Game.UI
{
    public class TextBox : osu.Framework.Graphics.UserInterface.TextBox
    {
        protected override void NotifyInputError()
        {
            throw new System.NotImplementedException();
        }

        protected override SpriteText CreatePlaceholder()
        {
            throw new System.NotImplementedException();
        }

        protected override Caret CreateCaret()
        {
            throw new System.NotImplementedException();
        }
    }
}
