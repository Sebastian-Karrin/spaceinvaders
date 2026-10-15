using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Collections.Generic;

namespace SpaceInvaders;

public class HeroShip : Actor
{
    public Vector2f direction = new Vector2f(1, 1) / MathF.Sqrt(2.0f);
    
    public HeroShip() : base("playerShip1_blue")
    {
        sprite.Origin = new Vector2f(0,0);
        sprite.Position = new Vector2f(500, 500);
    }

    public override void Update(Scene scene, float deltatime)
    {
       var newpos = sprite.Position;
       newpos += direction * deltatime * 100.0f;
       sprite.Position = newpos;
    }

    public override void Render(RenderTarget target)
    {
        
    }
}