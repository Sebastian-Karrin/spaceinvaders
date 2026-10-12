namespace SpaceInvaders;

public class SceneLoader
{
    private Dictionary<char, Func<Entity>> loaders;
    private string currentscene = "", nextscene = "";
    
    public SceneLoader()
    {
        loaders = new Dictionary<char, Func<Entity>>();
    }
}