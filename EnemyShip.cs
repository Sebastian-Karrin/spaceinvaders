using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class EnemyShip : Actor
{
    public Vector2f direction = new Vector2f(1, 1) / MathF.Sqrt(2.0f);
    
    public EnemyShip() : base("playerShip1_red")
    {
        sprite.Position = new Vector2f(300,300);
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
        newpos += direction * deltatime * 100.0f;
        sprite.Position = newpos;
    }
}