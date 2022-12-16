namespace WebApp2022.Tests.ServiceTests
{
    internal class AnnouncementServiceTests
    {
        [Test]
        public async Task Test_GetPetId()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var announcementService = new AnnouncementService(repoMock.Object);

            var ok = await announcementService.GetPetId(Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"));
            var bad = await announcementService.GetPetId(Guid.Empty);

            Assert.IsNotNull(ok);
            Assert.AreEqual("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3", ok.ToString());
            Assert.AreEqual(Guid.Empty, bad);
        }

        [Test]
        public async Task Test_Mine()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var announcementService = new AnnouncementService(repoMock.Object);

            var mineOk = await announcementService.Mine("6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");
            var mineBad = await announcementService.Mine("3d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            Assert.IsNotNull(mineOk);
            Assert.IsNotNull(mineBad);
            Assert.AreEqual(0, mineBad.Count);
            Assert.AreEqual(1, mineOk.Count);
        }

        [Test]
        public async Task Test_Exists()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(r => r.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var announcementService = new AnnouncementService(repoMock.Object);

            var existsTrue = await announcementService.Exists(Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"));
            var existsFalse = await announcementService.Exists(Guid.Empty);

            Assert.IsTrue(existsTrue);
            Assert.IsFalse(existsFalse);
        }
    }
}
