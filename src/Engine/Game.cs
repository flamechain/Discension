using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Discension {
    public class DiscensionGame : Game {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _background;
        private Color _bgcolor;

        public DiscensionGame() {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize() {
            Window.IsBorderless = true;
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent() {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _background = new Texture2D(GraphicsDevice, 1920, 1080);

            Color[] bgdata = new Color[1920*1080];
            for (int i=0; i < bgdata.Length; i++)
                bgdata[i] = Color.Black;

            _background.SetData(bgdata);
            _bgcolor = Color.White;
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
            _spriteBatch.Dispose();
            _background.Dispose();
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            base.Draw(gameTime);
            GraphicsDevice.Clear(_bgcolor);
            _spriteBatch.Begin();

            _spriteBatch.Draw(_background, new Rectangle(0, 0, 1920, 1080), Color.White);

            _spriteBatch.End();
        }
    }
}
