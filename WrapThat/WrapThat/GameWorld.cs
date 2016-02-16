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
        private List<Collider> colliders = new List<Collider>();
        private Vector2 playerPosition;
        private string level = "level 1";
        private bool completed = false;
        private Direction direction;
        private LevelOne one = new LevelOne();
       
        private static GameWorld instance;
        private static float deltaTime;
        private static List<GameObject> gameObjects = new List<GameObject>();
        private List<GameObject> removeGameObjects = new List<GameObject>(); 

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

        internal List<Collider> Colliders
        {
            get
            {
                return colliders;
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
            director = new Director(new PlayerBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero));
            director = new Director(new DoorOneBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero, "Frederik"));
            director = new Director(new PreassurePlateBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero, "Frederik"));
            director = new Director(new MoveableBoxBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero));
            director = new Director(new BoxPreassurePlateBuilder());
            gameObjects.Add(director.Construct(Vector2.Zero));
            director = new Director(new Gift());
            gameObjects.Add(director.Construct(Vector2.Zero));
            //for (int i = 1; i < 4; i++)
            //{

            //director = new Director(new LevelBuilder(i));

            //gameObjects.Add(director.Construct(Vector2.Zero));
            //}
            if (level == "level 1")
            {
            //LevelOne one= new LevelOne();
            one.LevelOneBuild();
                foreach (GameObject go in one.LevelOneObjects)
            {
                GameObjects.Add(go);
            }
            }
            if (level == "level 2" && Completed == true)
            {

                //LevelOne one = new LevelOne();
                
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
                    GameObject go =GameObjects[0] ;
                    //GameObject go = new GameObject();
                    int I = go.Components.Count;
                    for (int j = 0; j < I; j++)
                    {
                        go.Components.Remove(go.Components[0]);
                    }
                   removeGameObjects.Add(GameObjects[0]);
                    GameObjects.Remove(GameObjects[0]);
                    removeGameObjects.Clear();
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
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

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
