using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Actor : Entity
{
    protected float speed;
    protected int direction;
    
    public Actor() : base("SpaceInvaders")
    {
        Position = new Vector2f();
    }

    public override void Create(Scene scene)
    {
        base.Create(scene);
    }

    public override void Update(Scene scene, float deltaTime)
    {
        base.Update(scene, deltaTime);
    }

    public override void Render(RenderTarget target)
    {
        base.Render(target);
    }
}