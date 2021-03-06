﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WrapThat
{
    public class Player : Component, IUpdateable, ILoadable, IAnimateable, ICollisionEnter, ICollisionExit
    {
        private IStrategy strategy;
        private Direction direction = Direction.Front;
        private Direction oppositeDirection;
        private Transform transform;
        private Animator animator;
        private Vector2 currentDirection = new Vector2(0, 0);

        internal Direction Direction
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
            if ((keyState.IsKeyDown(Keys.R)))
            {
                GameWorld.Instance.Completed = true;
            }
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
            animator.CreateAnimation("IdleFront", new Animation(3, 90, 0, 45, 45, 3, Vector2.Zero));
            animator.CreateAnimation("IdleBack", new Animation(3, 135, 0, 45, 45, 3, Vector2.Zero));
            animator.CreateAnimation("IdleLeft", new Animation(3, 45, 0, 45, 45, 3, Vector2.Zero));
            animator.CreateAnimation("IdleRight", new Animation(3, 0, 0, 45, 45, 3, Vector2.Zero));
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
            if (other.GameObject.GetComponent("PreassurePlate") != null)
            {

            } else if (other.GameObject.GetComponent("MoveableBox") != null)
            {

            }
            else if(other.GameObject.GetComponent("BoxPreassurePlate") != null)
            {

            }
            else if (other.GameObject.GetComponent("Gift") != null)
            {

            }
            if(other.GameObject.GetComponent("Gift") == null && other.GameObject.GetComponent("BoxPreassurePlate") == null && other.GameObject.GetComponent("PreassurePlate") == null && other.GameObject.GetComponent("MoveableBox") == null)
            {
                if (direction == Direction.Front)
                {
                    oppositeDirection = Direction.Back;
                }
                else if (direction == Direction.Back)
                {
                    oppositeDirection = Direction.Front;
                }
                else if (direction == Direction.Right)
                {
                    oppositeDirection = Direction.Left;
                }
                else if (direction == Direction.Left)
                {
                    oppositeDirection = Direction.Right;
                }
                strategy.Update(ref oppositeDirection);
            }
            
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
