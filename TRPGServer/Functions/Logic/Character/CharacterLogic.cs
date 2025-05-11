using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity.Character;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Logic.Character
{
    public class CharacterLogic : ICharacterLogic
    {
        private readonly AppDbContext _context;

        public CharacterLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }
        public CharacterBaseModel GetCharacterById(Guid Id)
        {
            CharacterBase? character = _context.CharacterBase
                //.Include(c => c.Items)
                //.Include(c => c.Status)
                .Where(c => c.Id == Id).FirstOrDefault();
            if (character == null)
            {
                return new CharacterBaseModel();
            }

            var temp = character.Items.FirstOrDefault();

            return new CharacterBaseModel();
            //return CharacterMapper.MapToModel(character);
        }
    }
}
