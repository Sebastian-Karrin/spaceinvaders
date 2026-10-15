using Platformer;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class Scene
{
    private List<Entity> entities;
    public readonly AssetLoader assets;
    public readonly SceneLoader loader;
    public bool gameOver;

    public Scene() //Constructorn
    {
        entities = new List<Entity>();
        loader = new SceneLoader();
        assets = new AssetLoader();
        gameOver = false;
    }
    
    public void Spawn(Entity entity) //Lägger till alla entities i entities listan sen creatar
    {
        entities.Add(entity);
        entity.Create(this);
    }

    public void UpdateAll(float deltatime) //Uppdaterar allting i entities listan
    {
       loader.HandleSceneChange(this);
        for (int i = entities.Count - 1; i >= 0; i--)
        {
            Entity entity = entities[i];
            entity.Update(this, deltatime);
        }
        for(int i = 0; i < entities.Count;)
        {
            Entity entity = entities[i];
            if (entity.isDead) entities.RemoveAt(i);
            else i++;
        }
    }

    public void RenderAll(RenderTarget target) //Renderar allting från entities listan
    {
        for (int i = 0;  i < entities.Count; i++)
        {
            entities[i].Render(target);
        }
    }

    public void Clear() //Tar bort allting från entities listan på skärmen
    {
        for (int i = entities.Count - 1; i >= 0; i--)
        {
            Entity entity = entities[i];
            entities.RemoveAt(i);
            entity.Destroy(this);
        }
    }

    public IEnumerable<Entity> FindIntersects(FloatRect bounds) // letar efter collisions
    {
        int lastEntity = entities.Count - 1;
        for (int i = lastEntity; i >= 0; i--)
        {
            Entity entity = entities[i];
            if (entity.isDead) continue;
            if (entity.Bounds.Intersects(bounds))
            {
                yield return entity;
            }
        }
        
    }

    public bool FindByType<T>(out T found) where T : Entity
    {
        foreach (Entity entity in entities)
        {
            if (!entity.isDead && entity is T typed)
            {
                found = typed;
                return true;
            }
        }
        found = default(T);
        return false;
    }
}