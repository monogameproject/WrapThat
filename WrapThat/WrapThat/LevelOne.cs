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
            for (int i = 0; i < 17; i++)
            {
            GameObject gameObject = new GameObject();
                int newx = 50*i;

            gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
            gameObject.Transform.Position = new Vector2(-6+newx,-6);
                gameObject.AddComponent(new Collider(gameObject));
                    
                
            _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6 , -6+newy);
                gameObject.AddComponent(new Collider(gameObject));

                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(750, -6 + newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 17; i++)
            {
                GameObject gameObject = new GameObject();
                int newx = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6+newx, -6+450);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
        }

        public  void LevelTwoBuild()
        {
            for (int i = 0; i < 17; i++)
            {
                GameObject gameObject = new GameObject();
                int newx = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6 + newx, -6);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6, -6 + newy);
                gameObject.AddComponent(new Collider(gameObject));

                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(750, -6 + newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 17; i++)
            {
                GameObject gameObject = new GameObject();
                int newx = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6 + newx, -6 + 450);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            GameObject gObject = new GameObject();
            

            gObject.AddComponent(new SpriteRenderer(gObject, "Tile", 2f));
            gObject.Transform.Position = new Vector2(350 ,350);
            gObject.AddComponent(new Collider(gObject));


            _levelOneObjects.Add(gObject);
        }
    }
}
