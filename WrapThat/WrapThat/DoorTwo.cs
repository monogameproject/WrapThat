using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorTwo : Component, IUpdateable
    {
        private Transform transform;
        private BoxPreassurePlate boxPreassurePlate;
        public DoorTwo(GameObject gameObject) : base(gameObject)
        {
            boxPreassurePlate = (BoxPreassurePlate)gameObject.GetComponent("PreassurePlate");
            transform = gameObject.Transform;
        }
        public void Update()
        {
            if (boxPreassurePlate.BoxPressed == true)
            {
                foreach (GameObject go in GameWorld.GameObjects)
                {
                    if (go == this)
                    {
                        GameWorld.GameObjects.Remove((GameObject)go);
                    }
                }
            }
        }
    }
}
