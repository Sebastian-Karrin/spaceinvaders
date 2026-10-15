using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Collections.Generic;

namespace SpaceInvaders;

public class HeroShip : Actor
{
    public override void Create(Scene scene)
    {
        speed = 100.0f;
        base.Create(scene);
        sprite.TextureRect = new IntRect(0, 912, 112, 84);
        sprite.Origin = new Vector2f(66,42);
        sprite.Position = new Vector2f(500, 500);
    }

    protected override int PickDirection(Scene scene)
    {
        int dir = direction;
       
        if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
        {
            dir = 1;
            isMoving = true;
        }

        if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
        {
            dir = 3;
            isMoving = true;
        }

        if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
        {
            dir = 0;
            isMoving = true;
        }

        if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
        {
            dir = 2;
            isMoving = true;
        }

        if (!isDead) return dir;
        return direction;
    }


    public override void Update(Scene scene, float deltatime)
    {
       
      
    }

    public override void Render(RenderTarget target)
    {
        
    }
}