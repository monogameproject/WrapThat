using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorTwo : Component, IUpdateable, ICollisionEnter, ICollisionExit
    {
        private Transform transform;
        private Animator animator;
        private BoxPreassurePlate boxPreassurePlate;
        public DoorTwo(GameObject gameObject) : base(gameObject)
        {
            boxPreassurePlate = (BoxPreassurePlate)gameObject.GetComponent("PreassurePlate");
            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");
        }
        public void Update()
        {
            if (boxPreassurePlate.BoxPressed == true)
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
