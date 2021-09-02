using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Converter
{
    public class PetConverter : IPetConverter
    {
        public Pet Convert(PetEntity petEntity)
        {
            return new Pet
            {
                Id = petEntity.Id,
                Birthdate = petEntity.Birthdate,
                Color = petEntity.Color,
                Name = petEntity.Name,
                PetType = new PetTypeConverter().Convert(petEntity.PetTypeEntity),
                Price = petEntity.Price,
                SoldDate = petEntity.SoldDate
            };
        }

        public PetEntity Convert(Pet pet)
        {
            return new PetEntity
            {
                Id = pet.Id,
                Birthdate = pet.Birthdate,
                Color = pet.Color,
                Name = pet.Name,
                PetTypeEntity = new PetTypeConverter().Convert(pet.PetType),
                Price = pet.Price,
                SoldDate = pet.SoldDate
            };
        }
    }
}