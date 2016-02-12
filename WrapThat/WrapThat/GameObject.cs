using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace WrapThat
{
    public enum Direction { Front, Back, Left, Right}
    public class GameObject : Component, IAnimateable
    {
        private Transform transform;
        private List<Component> components = new List<Component>();

        internal Transform Transform
        {
            get
            {
                return transform;
            }
        }

        public GameObject()
        {
            this.transform = new Transform(this, Vector2.Zero);
            AddComponent(transform);
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }
        public Component GetComponent(string component)
        {
            foreach (Component compt in components)
            {
                if (compt.GetType().Name == component)
                {
                    return compt;
                }
            }
            return null;
        }
        public void LoadContent(ContentManager content)
        {
            foreach (Component component in components)
            {
                if (component is ILoadable)
                {
                    (component as ILoadable).LoadContent(content);
                }
            }
        }
        public void Update()
        {
            foreach (Component comp in components)
            {
                if (comp is IUpdateable)
                {
                    (comp as IUpdateable).Update();
                }
            }
        }
        public void Update(Direction direction)
        {
            foreach (Component component in components)
            {
                if (component is MoveableBox)
                {
                    (component as MoveableBox).Update(direction);
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Component component in components)
            {
                if (component is IDrawable)
                {
                    (component as IDrawable).Draw(spriteBatch);
                }
            }
        }

        public void OnAnimationDone(string animationName)
        {
            foreach (Component component in components)
            {
                if (component is IAnimateable) //Checks if any components are IAnimateable
                {
                    //If a component is IAnimateable we call the local implementation of the method
                    (component as IAnimateable).OnAnimationDone(animationName);
                }
            }
        }
        public void OnCollisionEnter(Collider other)
        {
            foreach (Component component in components)
            {
                if (component is ICollisionEnter)
                {
                    (component as ICollisionEnter).OnCollisionEnter(other);
                }
            }

        }
        public void OnCollisionExit(Collider other)
        {
            foreach (Component component in components)
            {
                if (component is ICollisionExit)
                {
                    (component as ICollisionExit).OnCollisionExit(other);
                }
            }

        }
    }
}
