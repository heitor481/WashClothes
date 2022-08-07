using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using WashClothes.Clothes;

namespace WashClothes.Seed
{
    public class ClotheSeed : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Clothe, int> _clothesRepository;
        private readonly IRepository<IdentityUser, Guid> _usersRepository;
        public ClotheSeed(IRepository<Clothe, int> clothesRepository, 
            IRepository<IdentityUser, Guid> usersRepository)
        {
            _clothesRepository = clothesRepository;
            _usersRepository = usersRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _clothesRepository.GetCountAsync() <= 0) 
            {
                var user = await _usersRepository.FirstOrDefaultAsync();

                await _clothesRepository.InsertAsync(new Clothe
                {
                    Color = "red",
                    Type = ClotheType.Shirt,
                    UserId = user.Id
                }, autoSave: true);

                await _clothesRepository.InsertAsync(new Clothe
                {
                    Color = "blue",
                    Type = ClotheType.JeansPants,
                    UserId = user.Id
                }, autoSave: true);

                await _clothesRepository.InsertAsync(new Clothe
                {
                    Color = "green",
                    Type = ClotheType.Jacket,
                    UserId = user.Id
                }, autoSave: true);
            }
        }
    }
}
