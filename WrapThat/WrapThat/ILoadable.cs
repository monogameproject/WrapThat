﻿using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    interface ILoadable
    {
        void LoadContent(ContentManager content);
    }
}
