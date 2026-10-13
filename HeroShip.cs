using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class HeroShip : Actor
{
    public HeroShip() : base()
    {
        sprite.Origin = new Vector2f(0,0);
        sprite.Position = new Vector2f(500, 500);
    }

    public override void Update(Scene scene, float deltatime)
    {
        base.Update(scene, deltatime);
        if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) ;
    }

    public override void Render(RenderTarget target)
    {
        
    }
}