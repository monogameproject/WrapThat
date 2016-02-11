using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WrapThat
{
    enum Direction { Front, Back, Left, Right}
    class Player : Component, IUpdateable, ILoadable, IAnimateable, ICollisionEnter, ICollisionExit
    {
        private IStrategy strategy;
        private Direction direction = Direction.Front;
        private Transform transform;
        private Animator animator;
        private Vector2 currentDirection = new Vector2(0, 0);

        public Direction Direction
        {
            get
            {
                return direction;
            }
        }

        public Player(GameObject gameObject) : base (gameObject)
        {
            animator = (Animator)GameObject.GetComponent("Animator");
            transform = gameObject.Transform;
        }
        public void Update()
        {
            KeyboardState keyState = Keyboard.GetState();
            strategy = new Move(animator, transform);
            if ((keyState.IsKeyDown(Keys.D)) || (keyState.IsKeyDown(Keys.A)) || (keyState.IsKeyDown(Keys.S)) || (keyState.IsKeyDown(Keys.W)))
            {
                strategy = new Move(animator, transform);
                if (keyState.IsKeyDown(Keys.D))
                {
                    direction = Direction.Right;
                    strategy.Update(ref direction);
                }
                else if (keyState.IsKeyDown(Keys.A))
                {
                    direction = Direction.Left;
                    strategy.Update(ref direction);
                }
                else if (keyState.IsKeyDown(Keys.S))
                {
                    direction = Direction.Front;
                    strategy.Update(ref direction);
                }
                else if (keyState.IsKeyDown(Keys.W))
                {
                    direction = Direction.Back;
                    strategy.Update(ref direction);
                }
            }
        }

        public void OnAnimationDone(string animationName)
        {

        }

        public void LoadContent(ContentManager content)
        {
            CreateAnimations();
        }

        public void CreateAnimations()
        {
            animator.CreateAnimation("IdleFront", new Animation(1, 0, 0, 100, 100, 6, Vector2.Zero));
            //animator.CreateAnimation("IdleBack", new Animation(4, 0, 4, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("IdleLeft", new Animation(4, 0, 8, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("IdleRight", new Animation(4, 0, 12, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("WalkFront", new Animation(4, 150, 0, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("WalkBack", new Animation(4, 150, 4, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("WalkLeft", new Animation(4, 150, 8, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("WalkRight", new Animation(4, 150, 12, 90, 150, 6, Vector2.Zero));
            //animator.CreateAnimation("AttackFront", new Animation(4, 300, 0, 145, 160, 8, new Vector2(50, 0)));
            //animator.CreateAnimation("AttackBack", new Animation(4, 465, 0, 170, 155, 8, new Vector2(20, 0)));
            //animator.CreateAnimation("AttackRight", new Animation(4, 620, 0, 150, 150, 8, Vector2.Zero));
            //animator.CreateAnimation("AttackLeft", new Animation(4, 770, 0, 150, 150, 8, new Vector2(60, 0)));
            //animator.CreateAnimation("DieFront", new Animation(3, 920, 0, 150, 150, 5, Vector2.Zero));
            //animator.CreateAnimation("DieBack", new Animation(3, 920, 3, 150, 150, 5, Vector2.Zero));
            //animator.CreateAnimation("DieLeft", new Animation(3, 1070, 0, 150, 150, 5, Vector2.Zero));
            //animator.CreateAnimation("DieRight", new Animation(3, 1070, 3, 150, 150, 5, Vector2.Zero));
            animator.PlayAnimation("IdleFront");
        }
        public void OnCollisionEnter(Collider other)
        {
            if (other.GameObject.GetComponent("PreassurePlate") == null)
            {
                if (Direction == Direction.Front)
                {
                    direction = Direction.Back;
                }
                else if (Direction == Direction.Back)
                {
                    direction = Direction.Front;
                }
                else if (Direction == Direction.Right)
                {
                    direction = Direction.Left;
                }
                else if (Direction == Direction.Left)
                {
                    direction = Direction.Right;
                }
                strategy.Update(ref direction);
            }
            
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
