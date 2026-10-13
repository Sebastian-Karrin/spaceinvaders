using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class HeroShip : Actor
{
    public HeroShip() : base()
    {
        sprite.TextureRect = new IntRect(0, 0, 16, 16);
        sprite.Origin = new Vector2f(0,0);
    }
    
}