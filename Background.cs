using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Background : Entity
{
    public Vector2f direction = new Vector2f(0, 1);
    
    public Background() : base("darkPurple", "pixel-font")
    {
       
        sprite.Position = new Vector2f(0,0);
    }

    public override void Update(Scene scene, float deltaTime)
    {
        var newpos = sprite.Position;
        newpos += direction * deltaTime * 100.0f;
        sprite.Position = newpos;
        Console.WriteLine($"{newpos}");
    }

    public override void Render(RenderTarget target)
    {
                target.Draw(sprite);
    }
}