using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class EnemyShip : Actor
{
    public EnemyShip() : base()
    {
        sprite.TextureRect = new IntRect(0, 0,16, 16);
        sprite.Origin = new Vector2f(8,8);
    }    
}