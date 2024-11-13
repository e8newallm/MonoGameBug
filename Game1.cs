using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.IO;

namespace GameMono;

public static class Constants
{
    public const int CELLSIZE = 50;
}

public class Game1 : Game
{
    private readonly GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private readonly Object[,] generated = Generate.Gen(1000, 600);

    public Game1()
    {
        //generated = Generate.Gen(1000, 600);
    }

    public void RunOneFrame()
    {

    }

    protected void Initialize()
    {

    }

    protected void LoadContent()
    {

    }

    protected void Update(GameTime gameTime)
    {
    }

    protected void Draw(GameTime gameTime)
    {
    }
}
