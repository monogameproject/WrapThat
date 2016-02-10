using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class LevelOne
    {
       private List<GameObject> _levelOneObjects= new List<GameObject>();

        public List<GameObject> LevelOneObjects
        {
            get { return _levelOneObjects; }
            set { _levelOneObjects = value; }
        }


        public  void LevelOneBuild()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "tile", 1f));
            gameObject.Transform.Position = new Vector2(-6,-6);
            _levelOneObjects.Add(gameObject);
        }
    }
}
