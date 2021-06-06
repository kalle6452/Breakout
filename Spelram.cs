using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Breakout
{
    class Spelram
    {
        public float Width { get; set; } 
        public float Height { get; set; } 

        private Texture2D imgPixel { get; set; }  
        private SpriteBatch spriteBatch; 

        public Spelram(float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent spelRam)
        {
            Width = screenWidth;
            Height = screenHeight;
            imgPixel = spelRam.imgPixel;
            this.spriteBatch = spriteBatch;
        }

        public void Draw()
        {
            spriteBatch.Draw(imgPixel, new Rectangle(1, 1, (int)Width - 1, 1), Color.White); 
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0, 1, (int)Height - 1), Color.White);
            spriteBatch.Draw(imgPixel, new Rectangle((int)Width - 1, 0, 1, (int)Height - 1), Color.White);
        }
    }
    }
    


