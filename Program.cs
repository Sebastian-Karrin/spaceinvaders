using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            scene.assets.LoadTexture("this");

            using (var window = new RenderWindow(
                       new VideoMode(800, 900), "SpaceInvaders"))
            {
                window.Closed += (o, e) => window.Close();
                
                Clock clock = new Clock();
                while (window.IsOpen)
                {
                    window.DispatchEvents();
                    float deltatime = clock.Restart().AsSeconds();
                    deltatime = MathF.Min(deltatime, 0.1f);
                    window.Clear(new Color(255, 255, 255));
                    window.Display();
                }
            }
        }
    }
}