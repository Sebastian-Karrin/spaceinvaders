using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Actor : Entity
{
    protected float speed;
    protected int direction;
    public string textureName2;
    
    public Actor(string textureName2) : base($"{textureName2}")
    {
        this.textureName2 = textureName2;
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