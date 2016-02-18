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
        //text
        private SpriteFont font;
        private int score = 0;
        //text
        private Vector2 playerPosition;
        private string level = "level 1";
        private bool completed = false;
        private Direction direction;
        private Level one = new Level();
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
                GameObject background = new GameObject();
                background.AddComponent(new SpriteRenderer(background, "Background", 0f));
                gameObjects.Add(background);
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(150, 46), "Frederik"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(150, 97), "Frederik"));
                director = new Director(new PreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(50, 380), "Frederik"));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(450, 55), "Niels"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(550, 150), "Niels", "DoorTwo"));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(450, 350), "Claus"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(400, 398), "Claus"));
                director = new Director(new Gift());
                gameObjects.Add(director.Construct(new Vector2(350, 250)));
                director = new Director(new MoveableBoxBuilder());
                gameObjects.Add(director.Construct(new Vector2(250, 55)));
                director = new Director(new MoveableBoxBuilder());
                gameObjects.Add(director.Construct(new Vector2(550, 300)));
                director = new Director(new PlayerBuilder());
                gameObjects.Add(director.Construct(Vector2.Zero));


                one.LevelOneBuild();
                foreach (GameObject go in one.LevelOneObjects)
                {
                    GameObjects.Add(go);
                }
            }
            if (level == "level 2" && Completed == true)
            {
                GameObject background = new GameObject();
                background.AddComponent(new SpriteRenderer(background, "Background", 0f));
                gameObjects.Add(background);
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(194, 144), "Frederik"));
                director = new Director(new PreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(194, 394), "Frederik"));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(144, 344), "Claus"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(44, 244), "Claus", "DoorTwo"));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(294, 144), "Niels"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(294, 344), "Niels"));
                director = new Director(new Gift());
                gameObjects.Add(director.Construct(new Vector2(350, 200)));
                director = new Director(new MoveableBoxBuilder());
                gameObjects.Add(director.Construct(new Vector2(150, 150)));
                director = new Director(new PlayerBuilder());
                gameObjects.Add(director.Construct(Vector2.Zero));


                one.LevelTwoBuild();
                foreach (GameObject go in one.LevelOneObjects)
                {

                    GameObjects.Add(go);

                }
                Completed = false;
            }

            if (level == "level 3" && Completed == true)
            {
                one.LevelThreeBuild();

                GameObject background = new GameObject();
                background.AddComponent(new SpriteRenderer(background, "Background", 0f));
                gameObjects.Add(background);
                director = new Director(new PreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(344, 344), "Frederik"));
                director = new Director(new BoxPreassurePlateBuilder());
                gameObjects.Add(director.Construct(new Vector2(444, 44), "Claus"));
                gameObjects.Add(director.Construct(new Vector2(444, 44), "Claus"));
                gameObjects.Add(director.Construct(new Vector2(144, 144), "Niels"));
                gameObjects.Add(director.Construct(new Vector2(444, 44), "Claus"));
                gameObjects.Add(director.Construct(new Vector2(44, 344), "Extra"));
                gameObjects.Add(director.Construct(new Vector2(94, 194), "Lucas"));
                director = new Director(new DoorBuilder());
                gameObjects.Add(director.Construct(new Vector2(244, 244), "Claus", "DoorTwo"));
                gameObjects.Add(director.Construct(new Vector2(294, 44), "Niels"));
                gameObjects.Add(director.Construct(new Vector2(94, 294), "Frederik", "DoorTwo"));
                gameObjects.Add(director.Construct(new Vector2(144, 294), "Frederik", "DoorTwo"));
                gameObjects.Add(director.Construct(new Vector2(244, 274), "Lucas", "DoorTwo"));
                gameObjects.Add(director.Construct(new Vector2(244, 304), "Extra", "DoorTwo"));
                director = new Director(new MoveableBoxBuilder());
                gameObjects.Add(director.Construct(new Vector2(148, 98)));
                gameObjects.Add(director.Construct(new Vector2(398, 148)));
                director = new Director(new Gift());
                gameObjects.Add(director.Construct(new Vector2(250, 350)));
                director = new Director(new PlayerBuilder());
                gameObjects.Add(director.Construct(Vector2.Zero));

                foreach (GameObject go in one.LevelOneObjects)
                {

                    GameObjects.Add(go);

                }
                Completed = false;
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
            font = Content.Load<SpriteFont>("Text");
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
            if (level == "level 3" && Completed == true)
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
            spriteBatch.Begin();

            foreach (GameObject go in gameObjects)
            {

                go.Draw(spriteBatch);
            }
            if (level == "level 1")
            {
                spriteBatch.DrawString(font, "use w,a,s,d", new Vector2(47, 200), Color.Red);
                spriteBatch.DrawString(font, "to move", new Vector2(70, 230), Color.Red);

                spriteBatch.DrawString(font, "hit this", new Vector2(55, 320), Color.Red);

                spriteBatch.DrawString(font, "push the box onto the plate", new Vector2(180, 100), Color.Red);

                spriteBatch.DrawString(font, "hit the gift to", new Vector2(210, 320), Color.Red);
                spriteBatch.DrawString(font, "go to  the next level", new Vector2(210, 340), Color.Red);

            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
