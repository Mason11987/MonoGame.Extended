using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Entities.Systems
{
    public abstract class EntityDrawSystem : EntitySystem, IDrawSystem
    {
        protected EntityDrawSystem(AspectBuilder aspect)
            : base(aspect)
        {
        }

        public virtual void Draw(GameTime gameTime)
        {
            Begin();

            foreach (var entityId in ActiveEntities)
                Draw(gameTime, entityId);

            End();
        }

        public virtual void Begin() { }
        public abstract void Draw(GameTime gameTime, int entityId);
        public virtual void End() { }
    }
}