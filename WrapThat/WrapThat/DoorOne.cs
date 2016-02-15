using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorOne : Component
    {
        private Transform transform;
        private Animator animator;
        private PreassurePlate preassurePlate;
        public DoorOne(GameObject gameObject) : base(gameObject)
        {
            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");
        }
    }
}
