using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Breakout;
namespace Breakout
{
    class GameContent
    {
    //Använder get och set metoder för att man kan ändra variablers värde utan att påverka hur man kommer åt datan, gör även att man kan komma åt datan externt.
        public Texture2D imgPaddle { get; set; }
        public Texture2D imgBall { get; set; }
        public Texture2D imgBrick { get; set; }
        public Texture2D imgPixel { get; set; }
        public GameContent(ContentManager Content)
        {

            imgBall = Content.Load<Texture2D>("Ball");
            imgPaddle = Content.Load<Texture2D>("Paddle");
            imgBrick = Content.Load<Texture2D>("Brick");
            imgPixel = Content.Load<Texture2D>("pixel");
        }
    }
}
