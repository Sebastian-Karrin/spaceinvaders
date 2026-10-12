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
                //TODO: initialize
            }
        }
    }
}