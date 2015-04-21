﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamLand.GameObject
{
    interface IGameObject
    {
        void Awake();
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
