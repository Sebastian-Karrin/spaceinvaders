using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class AssetLoader
{
    public static readonly string AssetPath = "assets/AllAssets/Spritesheet/sheet";
    private readonly Dictionary<string, Texture> textures;
    private readonly Dictionary<string, Font> fonts;

    public AssetLoader()
    {
        textures = new Dictionary<string, Texture>();
        fonts = new Dictionary<string, Font>();
    }

    public Texture LoadTexture(string name)
    {
        if (textures.TryGetValue(name, out Texture found))
        {
            return found;
        }
        string textureName = ($"{AssetPath}/{name}.png");
        Texture texture = textures[textureName];
        textures.Add(textureName, texture);
        return texture;
    }

    
}