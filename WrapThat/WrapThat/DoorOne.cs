using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorOne : Component, IUpdateable, ICollisionEnter, ICollisionExit
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
        public void OnCollisionEnter(Collider other)
        {
            throw new NotImplementedException();
        }
        public void OnCollisionExit(Collider other)
        {
            throw new NotImplementedException();
        }
    }
}
