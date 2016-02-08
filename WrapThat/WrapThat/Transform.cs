﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    public class Transform : Component
    {

        private Vector2 position;
        private Transform GetTransform;
        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        

        public Transform(GameObject gameObject, Vector2 position) : base (gameObject)
        {
            this.position = position;
        }
        public void Translate(Vector2 translation)
        {
            position += translation;
        }
    }
}
