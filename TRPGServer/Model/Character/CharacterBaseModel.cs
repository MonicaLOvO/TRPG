using TRPGServer.Model.Class;

namespace TRPGServer.Model.Character
{
    public class CharacterBaseModel
    {
        public Guid Id { get; set; }
        public AccountModel Account { get; set; }

        public CharacterItemsModel[] CharacterItems;
        public CharacterStatusModel[] CharacterStatus;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public string Era { get; set; }
        public ImageModel Image { get; set; }

 
        public int STR { get; set; } 
 
        public int CON { get; set; } 
 
        public int SIZ { get; set; } 
 
        public int DEX { get; set; } 
 
        public int APP { get; set; } 
 
        public int INT { get; set; } 
 
        public int POW { get; set; } 
 
        public int EDU { get; set; } 
        public int LUCK { get; set; }

 
        public int Hp { get; set; } 

 
        public int MP { get; set; } 
 
        public int SAN { get; set; } 
 
        public int Mov { get; set; } 
    }
}
