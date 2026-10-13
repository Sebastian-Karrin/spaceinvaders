using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class HeroShip : Actor
{
    public Vector2f direction = new Vector2f(1, 1) / MathF.Sqrt(2.0f);
    
    public HeroShip() : base()
    {
        sprite.Origin = new Vector2f(0,0);
        sprite.Position = new Vector2f(500, 500);
    }

    public override void Update(Scene scene, float deltatime)
    {
        base.Update(scene, deltatime);
       var newpos = sprite.Position;
       newpos += direction * deltatime * 100.0f;
       sprite.Position = newpos;
    }

    public override void Render(RenderTarget target)
    {
        
    }
}