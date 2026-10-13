using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
           

            using (var window = new RenderWindow(
                       new VideoMode(1920, 1080), "SpaceInvaders"))
            {
                window.Closed += (o, e) => window.Close();
                Clock clock = new Clock();
                Scene scene = new Scene();
                
                while (window.IsOpen)
                {
                    
                    float deltatime = clock.Restart().AsSeconds();
                    deltatime = MathF.Min(deltatime, 0.1f);
                    if (deltatime > 0.1f) deltatime = 0.1f;
                    window.DispatchEvents();
                    scene.Update(deltatime);
                    window.Clear(new Color(10, 10, 50));
                    scene.Render(window);
                    
                    window.Display();
                }
            }
        }
    }
}