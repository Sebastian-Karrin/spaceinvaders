using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Actor : Entity
{
    protected float speed;
    protected int direction;
    public string textureName2;

    protected Vector2f originalPosition;
    
    public Actor(string textureName2) : base($"{textureName2}")
    {
        this.textureName2 = textureName2;
        Position = new Vector2f();
    }

    protected static Vector2f ToVector(int dir)
    {
        if (dir==0) return new Vector2f(1, 0); //Höger
        if (dir==1) return new Vector2f(0, -1); //Upp
        if (dir==2) return new Vector2f(-1, 0); //Vänster
        if (dir == 3) return new Vector2f(0,1); //Ner
        return new Vector2f(0, 0); //Stilla, om nåt går fel.
    }

    public override void Create(Scene scene)
    {
        base.Create(scene);
        originalPosition = Position;
        
    }

    public override void Update(Scene scene, float deltaTime)
    {
        base.Update(scene, deltaTime);
        Position += ToVector(direction) * (speed * deltaTime);
    }

    public override void Render(RenderTarget target)
    {
        base.Render(target);
    }
}