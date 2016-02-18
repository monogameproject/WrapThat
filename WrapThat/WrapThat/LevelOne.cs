using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

        public void LevelBorderBuild()
        {
            for (int i = 0; i < 16; i++)
            {
                GameObject gameObject = new GameObject();
                int newx = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6 + newx, -6);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 9; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(-6, -6 + newy);
                gameObject.AddComponent(new Collider(gameObject));

                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 9; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(750, -6 + newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 16; i++)
            {
                GameObject gameObject = new GameObject();
                int newx = 50 * i;

                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(newx, 444);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
        }
        public  void LevelOneBuild()
        {
            LevelBorderBuild();
            // bygger første  række henad
            for (int i = 0; i < 7; i++)
            {
                
            GameObject gameObject = new GameObject();

                int newx = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
            gameObject.Transform.Position = new Vector2(150+newx, 100);
            gameObject.AddComponent(new Collider(gameObject));


            _levelOneObjects.Add(gameObject);
            }
            // bygger  alt efter hullet henad x
            for (int i = 0; i < 4; i++)
            {

                GameObject gameObject = new GameObject();

                int newx = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(550 + newx, 100);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 6; i++)
            {

                GameObject gameObject = new GameObject();

                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(150 , 150+newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

        }

        public  void LevelTwoBuild()
        {
           LevelBorderBuild();
        }

        public void LevelChecker( string level)
        {
            if (level == "level 1")
            {

                LevelOneBuild();
                foreach (GameObject go in LevelOneObjects)
                {
                    GameWorld.GameObjects.Add(go);
                }
            }
            if (level == "level 2" && GameWorld.Instance.Completed == true)
            {



                LevelTwoBuild();
                foreach (GameObject go in LevelOneObjects)
                {

                    GameWorld.GameObjects.Add(go);

                }
                GameWorld.Instance.Completed = false;
               
            }
        }

        public void RemoveOldLevel( string level,bool Completed)
        {
            if (level == "level 2" && Completed == true)
            {
                int J = GameWorld.GameObjects.Count;
                for (int i = 0; i < J; i++)
                {
                    GameObject go = GameWorld.GameObjects[0];

                    if (go.GetComponent("Collider") != null)
                    {
                        GameWorld.Instance.Colliders.Remove((Collider)go.GetComponent("Collider"));
                    }
                    GameWorld.GameObjects.Remove(GameWorld.GameObjects[0]);

                }

               // Initialize();
            }
        }
    }
}
