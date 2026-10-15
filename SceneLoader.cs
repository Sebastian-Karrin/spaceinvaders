using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class SceneLoader
{
    private string currentScene = "", nextScene = "";
    
    public SceneLoader()
    {
        
    }

    public void HandleSceneChange(Scene scene)
    {
        scene.Clear();
        Create(scene, out Entity createdEntity);
        Vector2f position = new Vector2f(0,0);
        if (createdEntity != null)
        {
            createdEntity.Position = position;
            scene.Spawn(createdEntity);
        }
        currentScene = nextScene; //uppdaterar currentScene som samma värde som nextScene
      
    }

    public void Load(string scene) => nextScene = scene;

    public void Reload()
    {
        
    }

    private bool Create(Scene scene, out Entity createdEntity)
    {
        if (!scene.FindByType<HeroShip>(out _))
        {
            createdEntity = new HeroShip();
            return true;
        } 
        if (!scene.FindByType<EnemyShip>(out _))
        {
            createdEntity = new EnemyShip();
            return true;
        }
        if (!scene.FindByType<Background>(out _))
        {
            createdEntity = new Background();
            return true;
        }
        createdEntity = null;
        return false;
    }
}