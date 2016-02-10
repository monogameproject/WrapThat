using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    interface IStrategy
    {
        void Update(ref Direction direction, Vector2 translation);
    }
}
