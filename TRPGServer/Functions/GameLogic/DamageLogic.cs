using TRPGServer.Data;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Functions.GameLogic
{
    public class DamageLogic
    {
        private readonly AppDbContext _context;

        public DamageLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        //public bool CauseDamage(Guid ActorId, Guid TargetId, DiceModel Dice) 
        //{
        //   var Actor = _context.RoomCharacter.Where(c => c.Id == ActorId);
        //    Actor.
        //}
    }
}
