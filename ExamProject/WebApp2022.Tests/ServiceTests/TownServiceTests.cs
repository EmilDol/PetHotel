namespace WebApp2022.Tests.ServiceTests
{
    public class Tests
    {
        [Test]
        public async Task Test_Add_Ok_Value()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.AddAsync(It.IsAny<Town>));
            repoMock.Setup(t => t.All<Town>()).Returns(values.Towns.BuildMock());
            var townService = new TownService(repoMock.Object);

            await townService.Add("Svishtov");
            var town = new Town();

            repoMock.Verify(t => t.AddAsync(It.IsAny<Town>()));
        }

        [Test]
        public async Task Test_GetTowns()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Town>()).Returns(values.Towns.BuildMock());

            var townService = new TownService(repoMock.Object);
            var town = await townService.GetTowns();

            Assert.NotNull(town);
            Assert.AreEqual(4, town.Count);
            Assert.That(town.Select(t => t.Name).Contains("Veliko Tarnovo"));
        }
    }
}