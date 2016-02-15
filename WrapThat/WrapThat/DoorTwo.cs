using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorTwo : Component
    {
        private Transform transform;
        private BoxPreassurePlate plate;
        public DoorTwo(GameObject gameObject) : base(gameObject)
        {
            transform = gameObject.Transform;
        }
    }
}
