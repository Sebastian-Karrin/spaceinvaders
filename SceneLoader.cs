using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class SceneLoader
{
    private string currentscene = "", nextscene = "";
    
    public SceneLoader()
    {
        
    }

    public void LoadScene(Scene scene)
    {
        scene.Clear();
        Create(scene, out Entity createdEntity);
        Vector2f position = new Vector2f(new Random().Next(0, 1000), new Random().Next(0, 1000));
        createdEntity.Position = position;
        scene.Spawn(createdEntity);
    }

    public void Load(string scene)
    {
        
    }

    public void Reload()
    {
        
    }

    private bool Create(Scene scene, out Entity createdEntity)
    {
        if (scene.FindByType<HeroShip>(out _))
        {
            createdEntity = new HeroShip();
            return true;
        }
        else if (scene.FindByType<EnemyShip>(out _))
        {
            createdEntity = new EnemyShip();
            return true;
        }
        createdEntity = null;
        return false;
    }
}