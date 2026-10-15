using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders;

public class AssetLoader
{
    public static readonly string AssetPath = "assets";
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
        string textureName = ($"assets/{name}.png");
        Texture texture = textures[textureName];
        textures.Add(name, texture);
        
        return texture;
    }

    public Font LoadFont(string name)
    {
        if (fonts.TryGetValue(name, out Font found))
        {
            return found;
        }

        string fontName = ($"{AssetPath}/{name}.ttf");
        Font font = fonts[fontName];
        fonts.Add(name, font);
        return font;
    }

    
}