using NuGet.Frameworks;

using WebApp2022.Core.Services.Administration;

namespace WebApp2022.Tests.ServiceTests
{
    internal class ApproveServiceTests
    {
        [Test]
        public async Task Test_ExistPet()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Pet>()).Returns(values.Pets.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            var True = await apporoveService.ExistPet(Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"));
            var False = await apporoveService.ExistPet(Guid.Empty);

            Assert.IsTrue(True);
            Assert.IsFalse(False);
        }
        
        [Test]
        public async Task Test_ExistTown()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Town>()).Returns(values.Towns.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            var True = await apporoveService.ExistTown(Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"));
            var False = await apporoveService.ExistTown(Guid.Empty);

            Assert.IsTrue(True);
            Assert.IsFalse(False);
        }

        [Test]
        public async Task Test_RejectTown()
        {
            var repoMock = new Mock<IRepository>();
            var apporoveService = new ApproveService(repoMock.Object);

            await apporoveService.RejectTown(Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"));

            repoMock.Verify(t => t.DeleteAsync<Town>(It.IsAny<Guid>()));
            repoMock.Verify(t => t.SaveChangesAsync());
        }
        
        [Test]
        public async Task Test_RejectPet()
        {
            var repoMock = new Mock<IRepository>();
            var apporoveService = new ApproveService(repoMock.Object);

            await apporoveService.RejectPet(Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"));

            repoMock.Verify(t => t.DeleteAsync<Pet>(It.IsAny<Guid>()));
            repoMock.Verify(t => t.SaveChangesAsync());
        }
        
        [Test]
        public async Task Test_ApprovePet_Ok()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Pet>()).Returns(values.Pets.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            await apporoveService.ApprovePet(Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"));

            repoMock.Verify(t => t.SaveChangesAsync());
        }
        
        [Test]
        public async Task Test_ApproveTown_Ok()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Town>()).Returns(values.Towns.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            await apporoveService.ApproveTown(Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"));

            repoMock.Verify(t => t.SaveChangesAsync());
        }

        [Test]
        public async Task Test_GetPets()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            var pets = await apporoveService.GetPets();

            Assert.IsNotNull(pets);
            Assert.AreEqual(2, pets.Count);
            Assert.IsTrue(pets.Select(p => p.Name).Contains("Juanita"));
            Assert.IsTrue(pets.Select(p => p.Name).Contains("Pablo"));
        }
        
        [Test]
        public async Task Test_GetTowns()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Town>()).Returns(values.Towns.BuildMock());
            var apporoveService = new ApproveService(repoMock.Object);

            var towns = await apporoveService.GetTowns();

            Assert.IsNotNull(towns);
            Assert.AreEqual(2, towns.Count);
            Assert.IsTrue(towns.Select(t => t.Name).Contains("Sofia"));
            Assert.IsTrue(towns.Select(t => t.Name).Contains("Plovdiv"));
        }
    }
}
