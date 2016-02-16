using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorTwo : Component
    {
        private string name;
        private Transform transform;
        private BoxPreassurePlate plate;
        public DoorTwo(GameObject gameObject, string name) : base(gameObject)
        {
            this.name = name;
            transform = gameObject.Transform;
        }
    }
}
