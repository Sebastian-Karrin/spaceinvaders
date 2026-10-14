using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Background :Entity
{
    public Background() : base("darkPurple")
    {
        sprite.Scale = new Vector2f(0.5f, 0.5f);
    }

    public override void Render(RenderTarget target)
    {
        View view = target.GetView();
        Vector2f topLeft = view.Center - 0.5f * view.Size;
        int tilesX = (int)MathF.Ceiling(view.Size.X / 24);
        int tilesY = (int)MathF.Ceiling(view.Size.Y / 24);

        for (int row = 0; row <= tilesY; row++)
        {
            for (int col = 0; col <= tilesX; col++)
            {
                sprite.Origin = new Vector2f();
                sprite.Position = topLeft + 24 * new Vector2f(col, row);
                target.Draw(sprite);
            }
        }
    }
}