using Microsoft.Xna.Framework;
using Spectrum;
using Spectrum.Framework.Entities;
using Spectrum.Framework.Graphics;
using Spectrum.Framework.Screens;
using Spectrum.Framework.Screens.InputElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2DGame
{
    public class Sample2DGame : SpectrumGame
    {
        protected override void Initialize()
        {
            base.Initialize();
            var camera = new Camera2D();
            var layout = Root.AddElement(new LinearLayout());
            layout.BackgroundColor = "0xffffff";
            layout.AddElement(new TextElement("Hello Thadius"));
            layout.Height = 1.0;
            layout.Width = 1.0;
            var scene = layout.AddElement(new SceneScreen(camera));
            camera.Position = new Vector2(0, 0);
            var manager = scene.Manager;
            manager.CreateEntity(new InitData<GameObject2D>().Call("AddComponent", "Thadius"));
        }
    }
}
