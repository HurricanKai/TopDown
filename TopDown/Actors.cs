﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown
{
    class Actors
    {
        public static Player Character;
        public static List<Actor> Drawable = new List<Actor>();
        public static List<Bullet> Bullets = new List<Bullet>();
        public static List<BasicEnemy> Enemies = new List<BasicEnemy>();
        public static List<Particle> BloodParticles = new List<Particle>();
        public static List<DeadBody> DeadBodies = new List<DeadBody>();
        public static List<Ability> Abilities = new List<Ability>();

        public static void Init()
        {
            Character = new Player(GameProperties.DefaultTexture, Vector2.Zero, new Vector2(15,15), Color.Red, 400);

            Drawable.Add(Character);
        }
    }
}
