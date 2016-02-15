using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorOne : Component, IUpdateable
    {
        private Transform transform;
        private Animator animator;
        private PreassurePlate preassurePlate;
        public DoorOne(GameObject gameObject) : base(gameObject)
        {
            preassurePlate = (PreassurePlate)gameObject.GetComponent("PreassurePlate");
            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");
        }
        public void Update()
        {
            if (preassurePlate.PlayerPressed == true)
            {

            }
        }
    }
}
