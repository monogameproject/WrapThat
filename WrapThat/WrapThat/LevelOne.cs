using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class LevelOne
    {




        public  void LevelOneBuild()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "tile", 1f));
            gameObject.Transform.Position = new Vector2(0,0);
        }
    }
}
