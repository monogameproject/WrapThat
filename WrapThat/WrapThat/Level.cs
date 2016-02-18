using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WrapThat
{
    class Level
    {
        private List<GameObject> _levelOneObjects = new List<GameObject>();

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
        public void LevelOneBuild()
        {
            LevelBorderBuild();
            // bygger første  række henad
            for (int i = 0; i < 7; i++)
            {

                GameObject gameObject = new GameObject();

                int newx = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(200 + newx, 150);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
            // bygger  alt efter hullet henad x
            for (int i = 0; i < 3; i++)
            {

                GameObject gameObject = new GameObject();

                int newx = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(650 + newx, 150);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 6; i++)
            {

                GameObject gameObject = new GameObject();

                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(150, 148 + newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

            for (int i = 0; i < 4; i++)
            {

                GameObject gameObject = new GameObject();

                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(400, 198 + newy);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }

        }

        public void LevelTwoBuild()
        {
            LevelBorderBuild();
            int j = 6;
            GameObject single = new GameObject();
            single.AddComponent(new SpriteRenderer(single, "Tile", 2f));
            single.Transform.Position = new Vector2(200 - j, 50 - j);
            single.AddComponent(new Collider(single));
            _levelOneObjects.Add(single);
            for (int i = 0; i < 6; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(50 - j + newy, 100 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 1)
                {
                    i = 2;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 2; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(350 - j + newy, 150 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 4)
                {
                    i = 3;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(100 - j + newy, 200 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 3;
                }
                if (i == 4)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(100 - j + newy, 250 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 3;
                }
                if (i == 4)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(100 - j + newy, 300 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 3;
                }
                if (i == 4)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(100 - j + newy, 350 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 4; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(250 - j + newy, 400 - j);
                gameObject.AddComponent(new Collider(gameObject));

                _levelOneObjects.Add(gameObject);
            }


        }
        public void LevelThreeBuild()
        {
            LevelBorderBuild();
            int j = 6;
            GameObject single = new GameObject();
            single.AddComponent(new SpriteRenderer(single, "Tile", 2f));
            single.Transform.Position = new Vector2(500 - j, 50 - j);
            single.AddComponent(new Collider(single));
            _levelOneObjects.Add(single);
            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(50 - j + newy, 100 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 1)
                {
                    i = 2;
                }
                if (i == 5)
                {
                    i = 7;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 5; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(300 - j + newy, 150 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 3;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 5; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(300 - j + newy, 200 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 3;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(200 - j + newy, 250 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(50 - j + newy, 300 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 2;
                }
                if (i == 3)
                {
                    i = 4;
                }
                if (i == 7)
                {
                    i = 8;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(200 - j + newy, 350 - j);
                gameObject.AddComponent(new Collider(gameObject));
                if (i == 0)
                {
                    i = 1;
                }
                if (i == 2)
                {
                    i = 5;
                }


                _levelOneObjects.Add(gameObject);
            }
            for (int i = 0; i < 10; i++)
            {
                GameObject gameObject = new GameObject();
                int newy = 50 * i;
                gameObject.AddComponent(new SpriteRenderer(gameObject, "Tile", 2f));
                gameObject.Transform.Position = new Vector2(50 - j + newy, 400 - j);
                gameObject.AddComponent(new Collider(gameObject));


                _levelOneObjects.Add(gameObject);
            }
        }

        public void LevelChecker(string level)
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

        public void RemoveOldLevel(string level, bool Completed)
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
