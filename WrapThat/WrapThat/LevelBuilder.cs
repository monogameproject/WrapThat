using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class LevelBuilder : IBuilder
    {
        private int i;
        public LevelBuilder(int i)
        {
            this.i = i;
        }
        private GameObject gameObject;
        public GameObject GetResult()
        {

           

                return gameObject;
            
          
        }

        public void BuildGameObject(Vector2 position)
        {
           
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "tile", 1f));
            gameObject.Transform.Position = new Vector2(i*122, i*122);
                
            this.gameObject = gameObject;
            


            //gameObject.AddComponent(new Collider());

            //  this.gameObject = gameObject;
        }
    }
}
