using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class EnemyShip : Actor
{
    public EnemyShip() : base()
    {
        sprite.TextureRect = new IntRect(0, 0,18, 18);
        sprite.Origin = new Vector2f(9,9);
        sprite.Position = new Vector2f(300,300);
    }

    public override void Render(RenderTarget target)
    {
       base.Render(target);
    }
}