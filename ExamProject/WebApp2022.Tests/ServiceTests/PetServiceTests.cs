using WebApp2022.Core.Models.Pets;

namespace WebApp2022.Tests.ServiceTests
{
    internal class PetServiceTests
    {
        [Test]
        public async Task Test_Pet_Exists()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);

            bool existsTrue = await petService.Exists(Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"));
            bool existsFalse = await petService.Exists(Guid.Parse("4b8ec921-8cd7-4290-bbc3-e31e6d40aea3"));

            Assert.IsTrue(existsTrue);
            Assert.IsFalse(existsFalse);
        }

        [Test]
        public async Task Test_Pet_IsApproved()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);

            bool approvedFalse = await petService.IsApproved(Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"));
            bool approvedFalseNonExist = await petService.IsApproved(Guid.NewGuid());
            bool approvedTrue = await petService.IsApproved(Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"));

            Assert.IsTrue(approvedTrue);
            Assert.IsFalse(approvedFalse);
            Assert.IsFalse(approvedFalseNonExist);
        }

        [Test]
        public async Task Test_Pet_Owns()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);

            bool ownsTrue = await petService.Owns(Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"), "72153552-7b85-4e34-b236-290e9bbad012");
            bool ownsFalse = await petService.Owns(Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"), "dea12856-c198-4129-b3f3-b893d8395082");

            Assert.IsTrue(ownsTrue);
            Assert.IsFalse(ownsFalse);
        }

        [Test]
        public async Task Test_Pet_Mine()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);

            var myPets = await petService.Mine("72153552-7b85-4e34-b236-290e9bbad012");
            var pet = myPets.First(p => p.Id == Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"));

            Assert.IsNotNull(myPets);
            Assert.AreEqual(2, myPets.Count);
            Assert.AreEqual("Pablo", pet.Name);
            Assert.AreEqual("Every second full noon he goes to Tsvetelina Yaneva's concert", pet.Requirements);
            Assert.AreEqual("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has", pet.Description);
            Assert.AreEqual("Bugs", pet.Type);
        }

        [Test]
        public async Task Test_Pet_GetPetToEditById()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);

            var pet = await petService.GetPetToEditById(Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"));

            var actualPet = values.Pets.First(i => i.Id == Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"));

            Assert.IsNotNull(pet);
            Assert.AreEqual(actualPet.Name, pet.Name);
            Assert.AreEqual(actualPet.Description, pet.Description);
            Assert.AreEqual(actualPet.ImageUrl, pet.ImageUrl);
            Assert.AreEqual(actualPet.Heigth, pet.Heigth);
            Assert.AreEqual(actualPet.Id, pet.Id);
            Assert.AreEqual(actualPet.Age, pet.Age);
            Assert.AreEqual(actualPet.Weigth, pet.Weigth);
            Assert.AreEqual(actualPet.Requirements, pet.Requirements);
        }

        [Test]
        public async Task Test_Pet_Add_Ok()
        {
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.AddAsync(It.IsAny<PetAddViewModel>()));
            var petService = new PetService(repoMock.Object);
            var pet = new PetAddViewModel
            {
                Id = Guid.NewGuid(),
                Age = 12,
                Description = "Lorem iPsum is a great dummy text provider for stuffed text",
                Heigth = 1,
                ImageUrl = "https://media.istockphoto.com/id/1296353202/photo/group-of-pets-posing-around-a-border-collie-dog-cat-ferret-rabbit-bird-fish-rodent.jpg?s=612x612&w=0&k=20&c=l4UJze9hXcNABS_3QJcaOU07R1pcuV3L7w_IJTu9o2c=",
                Name = "TestAdd",
                Requirements = "Require adada",
                Type = "Bugs",
                Weigth = 12
            };

            await petService.Add(pet, "72153552-7b85-4e34-b236-290e9bbad012");

            repoMock.Verify(t => t.AddAsync(It.IsAny<Pet>()));
        }

        [Test]
        public async Task Test_Pet_Add_Not_Ok()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);
            var pet = new PetAddViewModel
            {
                Id = Guid.NewGuid(),
                Age = 12,
                Description = "Lorem iPsum is a great dummy text provider for stuffed text",
                Heigth = 1,
                ImageUrl = "https://media.istockphoto.com/id/1296353202/photo/group-of-pets-posing-around-a-border-collie-dog-cat-ferret-rabbit-bird-fish-rodent.jpg?s=612x612&w=0&k=20&c=l4UJze9hXcNABS_3QJcaOU07R1pcuV3L7w_IJTu9o2c=",
                Name = "TestAdd",
                Requirements = "Require adada",
                Type = "Not existing",
                Weigth = 12
            };

            await petService.Add(pet, "72153552-7b85-4e34-b236-290e9bbad012");

            repoMock.Verify(t => t.AddAsync(It.IsAny<Pet>()), Times.Never);
        }

        [Test]
        public async Task Test_Pet_Edit_Ok()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);
            var pet = new PetEditViewModel
            {
                Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                Age = 12,
                Description = "Lorem iPsum is a great dummy text provider for stuffed text",
                Heigth = 1,
                ImageUrl = "https://media.istockphoto.com/id/1296353202/photo/group-of-pets-posing-around-a-border-collie-dog-cat-ferret-rabbit-bird-fish-rodent.jpg?s=612x612&w=0&k=20&c=l4UJze9hXcNABS_3QJcaOU07R1pcuV3L7w_IJTu9o2c=",
                Name = "TestAdd",
                Requirements = "Require adada",
                Type = "Bugs",
                Weigth = 12
            };

            await petService.Edit(pet);

            repoMock.Verify(t => t.SaveChangesAsync());
        }

        [Test]
        public async Task Test_Pet_Edit_Bad_Data()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Pet>()).Returns(values.Pets.BuildMock());
            var petService = new PetService(repoMock.Object);
            var petBadId = new PetEditViewModel
            {
                Id = Guid.Parse("e92af452-0689-46a0-8739-04a880b25286"),
                Age = 12,
                Description = "Lorem iPsum is a great dummy text provider for stuffed text",
                Heigth = 1,
                ImageUrl = "https://media.istockphoto.com/id/1296353202/photo/group-of-pets-posing-around-a-border-collie-dog-cat-ferret-rabbit-bird-fish-rodent.jpg?s=612x612&w=0&k=20&c=l4UJze9hXcNABS_3QJcaOU07R1pcuV3L7w_IJTu9o2c=",
                Name = "TestAdd",
                Requirements = "Require adada",
                Type = "Bugs",
                Weigth = 12
            };
            var petBadCategory = new PetEditViewModel
            {
                Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                Age = 12,
                Description = "Lorem iPsum is a great dummy text provider for stuffed text",
                Heigth = 1,
                ImageUrl = "https://media.istockphoto.com/id/1296353202/photo/group-of-pets-posing-around-a-border-collie-dog-cat-ferret-rabbit-bird-fish-rodent.jpg?s=612x612&w=0&k=20&c=l4UJze9hXcNABS_3QJcaOU07R1pcuV3L7w_IJTu9o2c=",
                Name = "TestAdd",
                Requirements = "Require adada",
                Type = "Not Existing",
                Weigth = 12
            };

            await petService.Edit(petBadId);

            repoMock.Verify(t => t.SaveChangesAsync(), Times.Never);


            await petService.Edit(petBadCategory);

            repoMock.Verify(t => t.SaveChangesAsync(), Times.Never);
        }
    }
}
