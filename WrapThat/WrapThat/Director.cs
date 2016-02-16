using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class Director
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public GameObject Construct(Vector2 position)
        {
            builder.BuildGameObject(position);
            return builder.GetResult();
        }
        public GameObject Construct(Vector2 position, string name)
        {
            builder.BuildGameObject(position, name);
            return builder.GetResult();
        }
    }
}
