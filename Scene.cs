namespace SpaceInvaders;

public class Scene
{
    private List<Entity> entities;
    public readonly AssetLoader assets;

    public Scene()
    {
        entities = new List<Entity>();
        assets = new AssetLoader();
    }
    
    public void Spawn(Entity entity)
    {
        entities.Add(entity);
    }

    public void Update(float deltatime)
    {
        for (int i = entities.Count - 1; i >= 0; i--)
        {
            Entity entity = entities[i];
            
        }
    }
}