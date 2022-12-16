using WebApp2022.Core.Models.Account;
using WebApp2022.Core.Models.Comments;
using WebApp2022.Core.Models.Towns;

namespace WebApp2022.Tests.ServiceTests
{
    internal class AccountServiceTests
    {
        [Test]
        public async Task Test_AddComment()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var townServiceMock = new Mock<ITownService>();
            var accountService = new AccountService(repoMock.Object, townServiceMock.Object);
            var comment = new CommentAddViewModel
            {
                Title = "Testss",
                Content = "Test if AddCommentWorks",
                ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012"
            };

            await accountService.AddComment(comment, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            repoMock.Verify(r => r.AddAsync(It.IsAny<Comment>()));
        }

        [Test]
        public async Task Test_Details()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var townServiceMock = new Mock<ITownService>();
            repoMock.Setup(r => r.All<ApplicationUser>()).Returns(values.Users.BuildMock());
            repoMock.Setup(r => r.All<Comment>()).Returns(values.Comments.BuildMock());
            var accountService = new AccountService(repoMock.Object, townServiceMock.Object);

            var details = await accountService.Details("6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Comments);
            Assert.AreEqual(values.Comments.Count(c => c.ReceiverId == "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"), details.Comments.Count);
            Assert.AreEqual("Veliko Tarnovo", details.Town);
            Assert.AreEqual("Ivan Georgiev", details.FullName);
            Assert.AreEqual("guest1", details.UserName);
            Assert.AreEqual("guest1@mail.com", details.Email);
            Assert.AreEqual("0884305667", details.PhoneNumber);
            Assert.AreEqual("6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", details.Id);
        }

        [Test]
        public async Task Test_Exists()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var townServiceMock = new Mock<ITownService>();
            repoMock.Setup(r => r.All<ApplicationUser>()).Returns(values.Users.BuildMock());
            var accountService = new AccountService(repoMock.Object, townServiceMock.Object);

            var existTrue = await accountService.Exists("6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");
            var existFalse = await accountService.Exists(Guid.Empty.ToString());

            Assert.IsTrue(existTrue);
            Assert.IsFalse(existFalse);
        }

        [Test]
        public async Task Test_GetUserToEdit()
        {
            var towns = new List<TownViewModel>
            {
                new TownViewModel
                {
                    Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Name = "Veliko Tarnovo"
                },
                new TownViewModel
                {
                    Id = Guid.Parse("d3e30c24-857f-4cd0-ba75-b9accb4d7c9f"),
                    Name = "Lovech"
                },
                new TownViewModel
                {
                    Id = Guid.Parse("db7127bc-1d68-4b3b-a523-a68a78b7e4a8"),
                    Name = "Pleven"
                },
                new TownViewModel
                {
                    Id = Guid.Parse("6fb2fef5-b16e-49dd-bfc4-8aef199df54c"),
                    Name = "Pavlikeni"
                }
            };
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var townServiceMock = new Mock<ITownService>();
            repoMock.Setup(r => r.All<ApplicationUser>()).Returns(values.Users.BuildMock());
            townServiceMock.Setup(t => t.GetTowns()).ReturnsAsync(towns);
            var accountService = new AccountService(repoMock.Object, townServiceMock.Object);

            var user = await accountService.GetUserToEdit("6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            Assert.IsNotNull(user);
            Assert.AreEqual("Ivan", user.FirstName);
            Assert.AreEqual("Georgiev", user.LastName);
            Assert.AreEqual("guest1", user.UserName);
            Assert.AreEqual("0884305667", user.PhoneNumber);
            Assert.AreEqual("guest1@mail.com", user.Email);
            Assert.AreEqual("658cfb89-2396-438d-baea-c10ef9ba492f", user.Town);
            Assert.IsNotNull(user.Towns);
            Assert.AreEqual(4, user.Towns.Count);
        }

        [Test]
        public async Task Test_Edit()
        {
            DatabaseValues values = new DatabaseValues();
            var repoMock = new Mock<IRepository>();
            var townServiceMock = new Mock<ITownService>();
            repoMock.Setup(r => r.All<ApplicationUser>()).Returns(values.Users.BuildMock());
            var accountService = new AccountService(repoMock.Object, townServiceMock.Object);
            var account = new EditAccountViewModel
            {
                Email = "test@mail.com",
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                PhoneNumber = "0882854899",
                UserName = "TestUserName",
                Town = "658cfb89-2396-438d-baea-c10ef9ba492f"
            };

            await accountService.Edit(account, "dea12856-c198-4129-b3f3-b893d8395082");

            repoMock.Verify(t => t.SaveChangesAsync(), Times.Once);
        }
    }
}
