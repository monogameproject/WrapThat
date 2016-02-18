using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace WrapThat
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        Director director;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Vector2 playerPosition;
        private string level = "level 1";
        private bool completed = false;
        private Direction direction;
        private LevelOne one = new LevelOne();
        private static GameWorld instance;
        private static float deltaTime;
        private static List<GameObject> gameObjects = new List<GameObject>();
        private List<GameObject> removeGameObjects = new List<GameObject>();

        public List<Collider> Colliders
        {
            get
            {
                List<Collider> tmp = new List<Collider>();

                foreach (GameObject go in GameObjects)
                {
                    tmp.Add(go.GetComponent<Collider>());
                }
                return tmp;

            }
        }
        public static GameWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameWorld();
                }
                return instance;
            }
        }

        public static List<GameObject> GameObjects
        {
            get
            {
                return gameObjects;
            }

            set
            {
                gameObjects = value;
            }
        }

        public static float DeltaTime
        {
            get
            {
                return deltaTime;
            }
        }



        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public List<GameObject> RemoveGameObjects
        {
            get
            {
                return removeGameObjects;
            }

            set
            {
                removeGameObjects = value;
            }
        }

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            //graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            //graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            //graphics.IsFullScreen = true;
            //graphics.ApplyChanges();
            if (level == "level 1")
            {
            director = new Director(new PlayerBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero));
            director = new Director(new DoorBuilder());
            gameObjects.Add(director.Construct(new Vector2(150,47), "Frederik"));
            
            director = new Director(new PreassurePlateBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero, "Frederik"));
            director = new Director(new MoveableBoxBuilder());
            gameObjects.Add(director.Construct(new Vector2(250,55)));
            director = new Director(new BoxPreassurePlateBuilder());
            gameObjects.Add(director.Construct(new Vector2(450,55), "Niels"));
            director = new Director(new Gift());
            gameObjects.Add(director.Construct(new Vector2(350,250)));
           
          
            one.LevelOneBuild();
                //GameObject background = new GameObject();
                //background.AddComponent(new SpriteRenderer(background, "Background", 0));
                //gameObjects.Add(background);
                director = new Director(new PlayerBuilder());
                gameObjects.Add(director.Construct(Vector2.Zero));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(150, 47), "Frederik"));
                director = new Director(new PreassurePlateBuilder());
                gameObjects.Add(director.Construct(Vector2.Zero, "Frederik"));
                director = new Director(new MoveableBoxBuilder());
                gameObjects.Add(director.Construct(new Vector2(250, 55)));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(450, 55), "Niels"));
                director = new Director(new Gift());
                gameObjects.Add(director.Construct(new Vector2(350, 250)));


                one.LevelOneBuild();
                foreach (GameObject go in one.LevelOneObjects)
                {
                    GameObjects.Add(go);
                }
            }
            if (level == "level 2" && Completed == true)
            {



                one.LevelTwoBuild();
                foreach (GameObject go in one.LevelOneObjects)
                {

                    GameObjects.Add(go);

                }
                Completed = false;
                level = "game done";
            }





            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            foreach (GameObject go in gameObjects)
            {
                go.LoadContent(Content);
            }
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            int j = RemoveGameObjects.Count;
            for (int i = 0; i < j; i++)
            {
                GameObjects.Remove(RemoveGameObjects[i]);
            }
            RemoveGameObjects.Clear();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            foreach (GameObject go in gameObjects)
            {
                if ((Player)go.GetComponent("Player") != null)
                {
                    Player other = (Player)go.GetComponent("Player");
                    direction = other.Direction;
                    go.Update();
                }
                if ((MoveableBox)go.GetComponent("MoveableBox") != null)
                {
                    go.Update(direction);
                }
                go.Update();
            }
            if (level == "level 2" && Completed == true)
            {
                int J = GameObjects.Count;
                for (int i = 0; i < J; i++)
                {
                    GameObject go = GameObjects[0];

                    if (go.GetComponent("Collider") != null)
                    {
                        Colliders.Remove((Collider)go.GetComponent("Collider"));
                    }
                    GameObjects.Remove(GameObjects[0]);
                    one.LevelOneObjects.Clear();
                }

                Initialize();
            }
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);
            spriteBatch.Begin(SpriteSortMode.BackToFront);

            foreach (GameObject go in gameObjects)
            {

                go.Draw(spriteBatch);
            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
