using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class EnemyShip : Actor
{

    public override void Create(Scene scene)
    {
        speed = 90.0f;
        base.Create(scene);
        sprite.Position = new Vector2f(300,300);
        sprite.TextureRect = new IntRect(144, 156, 102, 84);
        sprite.Origin = new Vector2f(51, 42);
    }

    public override void Render(RenderTarget target)
    {
       base.Render(target);
    }

    public override void Update(Scene scene, float deltatime)
    {
        if (!isDead)
        {
            scene.Spawn(this);
            Console.WriteLine("din mamma");
        }
        var newpos = sprite.Position;
        sprite.Position = newpos;
    }
}