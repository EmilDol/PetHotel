namespace WebApp2022.Tests.ServiceTests
{
    internal class RequestServiceTests
    {
        [Test]
        public async Task Test_Request_Reject()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Request>()).Returns(values.Requests.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            requestService.Reject(Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"));
            repoMock.Verify(t => t.DeleteAsync<Request>(It.IsAny<Guid>()));

            requestService.Reject(Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"));
            repoMock.Verify(t => t.DeleteAsync<Request>(It.IsAny<Guid>()));
        }

        [Test]
        public async Task Test_Request_GetAnnouncementId()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Request>()).Returns(values.Requests.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            var resultEmpty = await requestService.GetAnnouncementId(Guid.Empty);
            var resultOk = await requestService.GetAnnouncementId(Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"));

            Assert.AreEqual(Guid.Empty, resultEmpty);
            Assert.AreEqual(Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"), resultOk);
        }

        [Test]
        public async Task Test_Add()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var requestService = new RequestsService(repoMock.Object);

            await requestService.Add(Guid.Empty, Guid.Empty.ToString());

            repoMock.Verify(t => t.AddAsync(It.IsAny<Request>()));
        }

        [Test]
        public async Task Test_Exists()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            var exists = await requestService.Exists(Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"), "dea12856-c198-4129-b3f3-b893d8395082");
            var existsNot = await requestService.Exists(Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"), "a56-c198-4129-b3f3-b893d8395082");

            Assert.IsTrue(exists);
            Assert.IsFalse(existsNot);
        }

        [Test]
        public async Task Test_All()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Request>()).Returns(values.Requests.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            var model = await requestService.All(Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"));

            var modelBad = await requestService.All(Guid.NewGuid());

            Assert.IsNotNull(model);
            Assert.IsNotNull(modelBad);
            Assert.AreEqual(0, modelBad.Count);
            Assert.AreEqual(2, model.Count);
        }

        [Test]
        public async Task Test_Accept_Ok()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Request>()).Returns(values.Requests.BuildMock());
            repoMock.Setup(t => t.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            await requestService.Accept(Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"));

            repoMock.Verify(t => t.DeleteAsync<Request>(It.IsAny<Guid>()), Times.Once);
            repoMock.Verify(t => t.SaveChangesAsync(), Times.Once);
        }
        
        [Test]
        public async Task Test_Accept_Bad()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(t => t.All<Request>()).Returns(values.Requests.BuildMock());
            repoMock.Setup(t => t.All<Announcement>()).Returns(values.Announcements.BuildMock());
            var requestService = new RequestsService(repoMock.Object);

            await requestService.Accept(Guid.Empty);
            
            repoMock.Verify(t => t.DeleteAsync<Request>(It.IsAny<Guid>()), Times.Never);
            repoMock.Verify(t => t.SaveChangesAsync(), Times.Never);
        }
    }
}
