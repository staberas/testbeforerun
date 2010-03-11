using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace Project_Slug
{
    class Bullet
    {
        public bool alive;
        //the image of our bullet 
        public Texture2D texture;

        //the bullet's position bulletImage
        public Vector2 Position;

        public Bullet(Texture2D loadedTexture)
        {
            texture = loadedTexture;
            Position = Vector2.Zero;
        }

        //this will be called every frame 
        public void Update()
        {
            //you may want to replace this with velocity or something else entirely 
            Position.Y -= 2;
            //collision detection should go here if you need it 
        }

        //this will be called when you draw your game 
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, Color.White);
        } 
    }
}
