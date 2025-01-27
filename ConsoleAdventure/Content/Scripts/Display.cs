﻿using ConsoleAdventure.Settings;
using ConsoleAdventure.WorldEngine;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace ConsoleAdventure
{
    internal class Display
    {
        private World world;
        public Display(World world)
        {
            this.world = world;
        }

        public string DisplayInfo()
        {
            return
                $"{Docs.GetInfo()}\n" +
                $"{world.time.GetTime()}\n" +
                $"X:{world.players[0].position.x} Y:{world.players[0].position.y}\n" +
                $"Structure: {world.GetField(world.players[0].position.x, world.players[0].position.y, World.BlocksLayerId)}\n\n"
                ;
        }

        public void DrawWorld()
        {
            world.Render();
        }

        public string DisplayInventory()
        {
            return
                $"Inventory:\n" +
                $"{world.players[0].inventory.GetInfo()}\n" +
                $"{Loger.GetLogs()}"
                ;
        }
    }
}
