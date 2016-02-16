﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorOne : Component
    {
        private string name;
        private Transform transform;
        private Animator animator;
        private PreassurePlate preassurePlate;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DoorOne(GameObject gameObject, string name) : base(gameObject)
        {
            this.Name = name;
            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");
        }
    }
}
