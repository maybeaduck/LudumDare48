﻿using Leopotam.Ecs;

namespace Zlodey
{
    public class ExampleSystem : Injects, IEcsRunSystem
    {
        private EcsFilter<WinEvent> _filter;
        public void Run()
        {
            foreach (var i in _filter)
            { 
            }
        }
    }
}