using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Breakout;
namespace Breakout
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameContent gameContent;

        private Paddle paddle;
        private Ball ball;
        private Spelram spelRam;
        private int screenWidth = 0;
        private int screenHeight = 0;
        public Game1()
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
            spriteBatch = new SpriteBatch(GraphicsDevice);
            gameContent = new GameContent(Content);
            screenHeight = 500;
            screenWidth = 1000;
            graphics.ApplyChanges();
            int paddleX = screenWidth / 3;
            
            int paddleY = screenHeight - 100; 
            paddle = new Paddle(paddleX, paddleY, screenWidth, spriteBatch, gameContent);
            spelRam = new Spelram(screenWidth, screenHeight, spriteBatch, gameContent);
            ball = new Ball(screenWidth, screenHeight, spriteBatch, gameContent);
            // TODO: Add your initialization logic here
            gameContent = new GameContent(Content);
    }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            gameContent = new GameContent(Content);
            screenHeight = 500;
            screenWidth = 1000;
            graphics.ApplyChanges();
            //create game objects
            int paddleX = screenWidth / 2;
            spelRam = new Spelram(screenWidth, screenHeight, spriteBatch, gameContent);
            int paddleY = screenHeight - 100;  
            paddle = new Paddle(paddleX, paddleY, screenWidth, spriteBatch, gameContent); 
                                                                                          
           
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

            // TODO: Add your update logic here
            KeyboardState newKeyboardState = Keyboard.GetState();
            if (newKeyboardState.IsKeyDown(Keys.Left))
            {
                paddle.Vänster();
            }
            if (newKeyboardState.IsKeyDown(Keys.Right))
            {
                paddle.Höger();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            paddle.Draw();
            spelRam.Draw();
            ball.Draw();
            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
