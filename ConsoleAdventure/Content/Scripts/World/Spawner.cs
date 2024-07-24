using System;
using ConsoleAdventure.Content.Scripts.Entities;

namespace ConsoleAdventure.WorldEngine;

public static class Spawner
{
    public static Entity Spawn(Entity entity, Position position = default)
    {
        Entity spawnedEntity = new Entity(World.instance, Position.Zero());
        spawnedEntity = (Entity)entity.Copy();
        spawnedEntity.ChooseColor();
        World.instance.SetSubjectPosition(spawnedEntity, entity.worldLayer, position.x, position.y);

        return spawnedEntity;
    }
}