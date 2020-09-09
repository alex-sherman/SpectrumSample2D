using Microsoft.Xna.Framework.Input;
using Spectrum.Framework;
using Spectrum.Framework.Entities;
using Spectrum.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2DGame
{
    public class Thadius : Component<GameObject2D>, IUpdate
    {
        public override void Initialize(Entity e)
        {
            base.Initialize(e);
            P.Texture = "thadius";
            P.Bounds = P.Texture.Texture.Bounds;
            // Center the sprite on Thadius's position
            P.Bounds.X = -P.Bounds.Width / 2;
            P.Bounds.Y = -P.Bounds.Height / 2;
        }

        public void Update(float dt)
        {
            var multiplier = InputState.Current.IsKeyDown(Keys.LeftShift) ? 2 : 1;
            if (InputState.Current.IsKeyDown(Keys.Q))
                P.Rotation += dt * multiplier;
            if (InputState.Current.IsKeyDown(Keys.E))
                P.Rotation -= dt * multiplier;
            if (InputState.Current.IsKeyDown(Keys.W))
                P.Position += Vector2.UnitY.Rotate(P.Rotation) * dt * 500 * multiplier;
        }
    }
}
