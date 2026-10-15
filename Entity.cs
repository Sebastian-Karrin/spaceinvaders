using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Entity
{
    private readonly string fontName;
    private readonly string textureName;
    protected readonly Sprite sprite;
    public bool isDead;

    protected Entity(string textureName, string fontName)
    {
        this.fontName = fontName;
        this.textureName = textureName;
        sprite = new Sprite();
        isDead = false;
    }
    
    public Vector2f Position
    {
      get  => sprite.Position;
      set => sprite.Position = value;
    }

    public FloatRect Bounds => sprite.GetGlobalBounds();
    
    public virtual bool Solid => false;

    public virtual void Update(Scene scene, float deltatime)
    {
        
    }

    public virtual void Create(Scene scene)
    {
        sprite.Texture = scene.assets.LoadTexture(textureName);
        
    }

    public virtual void Destroy(Scene scene)
    {
        
    }

    public virtual void Render(RenderTarget target)
    {
        target.Draw(sprite);
    }

}