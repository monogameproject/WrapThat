﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    public abstract class Component
    {
        private GameObject gameObject;
        public Component(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
        public Component()
        {

        }

        public GameObject GameObject
        {
            get
            {
                return gameObject;
            }
            private set
            {
                gameObject = value;
            }
        }
    }
}
