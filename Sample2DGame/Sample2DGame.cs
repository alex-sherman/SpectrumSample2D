using Microsoft.Xna.Framework.Input;
using Spectrum;
using Spectrum.Framework;
using Spectrum.Framework.Entities;
using Spectrum.Framework.Graphics;
using Spectrum.Framework.Input;
using Spectrum.Framework.Screens;
using Spectrum.Framework.Screens.InputElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2DGame
{
    public static class SampleEntry
    {
        public static void Main(string[] args) { Entry<Sample2DGame>.Main(args); }
    }
    [Serializable]
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
            scene.AddElement(new DebugPrinter());
            camera.Position = new Vector2(0, 0);
            var manager = scene.Manager;
            manager.CreateEntity(new InitData<GameObject2D>()
                .Set("Texture", "thadius").Call("AddComponent", "Thadius"));
            InputLayout.AddBind("Forward", Keys.W);
            InputLayout.AddBind("RotateLeft", Keys.Q);
            InputLayout.AddBind("RotateRight", Keys.E);
            InputLayout.AddBind("LeftShift", Keys.LeftShift);
            layout.RegisterHandler(Keys.F1, (_) => { Game.Debug ^= true; });
        }
    }
}
