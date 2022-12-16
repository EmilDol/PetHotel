namespace WebApp2022.Tests.Common
{
    internal class DatabaseValues
    {
        public List<ApplicationUser> Users = new List<ApplicationUser> //Done
        {
            new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = " ADMIN@MAIL.COM",
                FirstName = "Petar",
                LastName = "Petrov",
                PhoneNumber = "0882854999",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                Pets = new List<Pet>()
                {
                    new Pet
                    {
                        Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                        DateAdded = DateTime.UtcNow,
                        Name = "Mishi",
                        Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting   industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                        IsApproved = true,
                        ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?   s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                        OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                        Age = 3,
                        Heigth = 0.3,
                        Weigth = 4,
                        Type = AnimalType.Cat,
                        Requirements = "Needs to be played with and weekly beautition session"
                    }
                },
                Town = new Town
                {
                    Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Name = "Veliko Tarnovo",
                    IsApproved = true
                },
                CommentsReceived = new List<Comment>
                {
                    new Comment
                    {
                        Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                        Title = "Great babysitter",
                        Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                        AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                        ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                    }
                },
                CommentsWritten = new List<Comment>
                {
                    new Comment
                    {
                        Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                        Title = "Don't recommend",
                        Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                        ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                    },
                    new Comment
                    {
                        Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                        Title = "Worst babysitter",
                        Content = "He returned my cat ill and starving! He had beaten up my cat!",
                        ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                    }
                },
                Requests = new List<Request>
                {
                    new Request
                    {
                        Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                        AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                        IsConfirmed = true,
                        BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                    },
                    new Request
                    {
                        Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                        AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                        IsConfirmed = false,
                        BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                    }
                }
            },
            new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest1",
                NormalizedUserName = "GUEST1",
                Email = "guest1@mail.com",
                NormalizedEmail = "GUEST1@MAIL.COM",
                FirstName = "Ivan",
                LastName = "Georgiev",
                PhoneNumber = "0884305667",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                Town = new Town
                {
                    Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Name = "Veliko Tarnovo",
                    IsApproved = true
                },
                Pets = new List<Pet>()
                {
                    new Pet
                    {
                        Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                        DateAdded = DateTime.UtcNow,
                        IsApproved = true,
                        Name = "Juan",
                        Description = "Horsey. He big and likes balconies.",
                        ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                        OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        Age = 69,
                        Heigth = 3,
                        Weigth = 420,
                        Type = AnimalType.Exotic,
                        Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                    }
                },
                CommentsWritten = new List<Comment>
                { 
                    new Comment
                    {
                        Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                        Title = "Can't complain",
                        Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                        ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                        AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                    }
                },
                CommentsReceived = new List<Comment>
                {
                    new Comment
                    {
                        Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                        Title = "Don't recommend",
                        Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                        ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                    },
                    new Comment
                    {
                        Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                        Title = "Worst babysitter",
                        Content = "He returned my cat ill and starving! He had beaten up my cat!",
                        ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                    }
                },
                Requests = new List<Request>
                {
                    new Request
                    {
                        Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                        AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                        IsConfirmed = false,
                        BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                    }
                }
            },
            new ApplicationUser()
            {
                Id = "72153552-7b85-4e34-b236-290e9bbad012",
                UserName = "guest2",
                NormalizedUserName = "GUEST2",
                Email = "guest2@mail.com",
                NormalizedEmail = "GUEST2@MAIL.COM",
                FirstName = "Boyan",
                LastName = "Hristov",
                PhoneNumber = "0854993215",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                Town = new Town
                {
                    Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Name = "Veliko Tarnovo",
                    IsApproved = true
                },
                Pets = new List<Pet>
                {
                    new Pet
                    {
                        Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                        DateAdded= DateTime.UtcNow,
                        Name = "Pablo",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                        IsApproved = false,
                        ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-    Cassanelli_inline.jpg.large.jpg",
                        OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                        Type = AnimalType.Bugs,
                        Age = 36,
                        Heigth = 1.5,
                        Weigth = 5,
                        Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
                    },
                    new Pet
                    {
                        Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                        DateAdded = DateTime.UtcNow,
                        IsApproved = false,
                        Name = "Juanita",
                        Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                        ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                        OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                        Age = 42,
                        Heigth = 2.85,
                        Weigth = 300,
                        Type = AnimalType.Bird,
                        Requirements = "Every evening she needs to hear her husband Juan"
                    }
                },
                CommentsWritten = new List<Comment>
                {
                    new Comment
                    {
                        Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                        Title = "Great babysitter",
                        Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                        AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                        ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                    }
                },
                CommentsReceived = new List<Comment>
                {
                    new Comment
                    {
                        Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                        Title = "Can't complain",
                        Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                        ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                        AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                    }
                },
                Requests = new List<Request>
                {
                    new Request
                    {
                        Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                        IsConfirmed = false,
                        AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                        BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012"
                    }
                }
            }
        };

        public List<Comment> Comments = new List<Comment>()
        {
            new Comment
            {
                Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                Title = "Great babysitter",
                Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                Author = new ApplicationUser()
                {
                    Id = "72153552-7b85-4e34-b236-290e9bbad012",
                    UserName = "guest2",
                    NormalizedUserName = "GUEST2",
                    Email = "guest2@mail.com",
                    NormalizedEmail = "GUEST2@MAIL.COM",
                    FirstName = "Boyan",
                    LastName = "Hristov",
                    PhoneNumber = "0854993215",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>
                    {
                        new Pet
                        {
                            Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                            DateAdded= DateTime.UtcNow,
                            Name = "Pablo",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                            IsApproved = false,
                            ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-        Cassanelli_inline.jpg.large.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Type = AnimalType.Bugs,
                            Age = 36,
                            Heigth = 1.5,
                            Weigth = 5,
                            Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
                        },
                        new Pet
                        {
                            Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = false,
                            Name = "Juanita",
                            Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                            ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Age = 42,
                            Heigth = 2.85,
                            Weigth = 300,
                            Type = AnimalType.Bird,
                            Requirements = "Every evening she needs to hear her husband Juan"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                            IsConfirmed = false,
                            AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                            BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012"
                        }
                    }
                },
                ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082",
                Receiver = new ApplicationUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = " ADMIN@MAIL.COM",
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PhoneNumber = "0882854999",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                            DateAdded = DateTime.UtcNow,
                            Name = "Mishi",
                            Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting     industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                            IsApproved = true,
                            ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?     s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                            OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                            Age = 3,
                            Heigth = 0.3,
                            Weigth = 4,
                            Type = AnimalType.Cat,
                            Requirements = "Needs to be played with and weekly beautition session"
                        }
                    },
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                            AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            IsConfirmed = true,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Request
                        {
                            Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    }
                }
            },
            new Comment
            {
                Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                Title = "Don't recommend",
                Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                AuthorId = "dea12856-c198-4129-b3f3-b893d8395082",
                Author = new ApplicationUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = " ADMIN@MAIL.COM",
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PhoneNumber = "0882854999",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                            DateAdded = DateTime.UtcNow,
                            Name = "Mishi",
                            Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting     industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                            IsApproved = true,
                            ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?     s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                            OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                            Age = 3,
                            Heigth = 0.3,
                            Weigth = 4,
                            Type = AnimalType.Cat,
                            Requirements = "Needs to be played with and weekly beautition session"
                        }
                    },
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                            AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            IsConfirmed = true,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Request
                        {
                            Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    }
                },
                Receiver = new ApplicationUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest1",
                    NormalizedUserName = "GUEST1",
                    Email = "guest1@mail.com",
                    NormalizedEmail = "GUEST1@MAIL.COM",
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    PhoneNumber = "0884305667",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = true,
                            Name = "Juan",
                            Description = "Horsey. He big and likes balconies.",
                            ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                            OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            Age = 69,
                            Heigth = 3,
                            Weigth = 420,
                            Type = AnimalType.Exotic,
                            Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    }
                }
            },
            new Comment
            {
                Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                Title = "Worst babysitter",
                Content = "He returned my cat ill and starving! He had beaten up my cat!",
                ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                AuthorId = "dea12856-c198-4129-b3f3-b893d8395082",
                Author = new ApplicationUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = " ADMIN@MAIL.COM",
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PhoneNumber = "0882854999",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                            DateAdded = DateTime.UtcNow,
                            Name = "Mishi",
                            Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting     industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                            IsApproved = true,
                            ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?     s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                            OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                            Age = 3,
                            Heigth = 0.3,
                            Weigth = 4,
                            Type = AnimalType.Cat,
                            Requirements = "Needs to be played with and weekly beautition session"
                        }
                    },
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                            AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            IsConfirmed = true,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Request
                        {
                            Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    }
                },
                Receiver = new ApplicationUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest1",
                    NormalizedUserName = "GUEST1",
                    Email = "guest1@mail.com",
                    NormalizedEmail = "GUEST1@MAIL.COM",
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    PhoneNumber = "0884305667",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = true,
                            Name = "Juan",
                            Description = "Horsey. He big and likes balconies.",
                            ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                            OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            Age = 69,
                            Heigth = 3,
                            Weigth = 420,
                            Type = AnimalType.Exotic,
                            Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    }
                }
            },
            new Comment
            {
                Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                Title = "Can't complain",
                Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                Receiver = new ApplicationUser()
                {
                    Id = "72153552-7b85-4e34-b236-290e9bbad012",
                    UserName = "guest2",
                    NormalizedUserName = "GUEST2",
                    Email = "guest2@mail.com",
                    NormalizedEmail = "GUEST2@MAIL.COM",
                    FirstName = "Boyan",
                    LastName = "Hristov",
                    PhoneNumber = "0854993215",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>
                    {
                        new Pet
                        {
                            Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                            DateAdded= DateTime.UtcNow,
                            Name = "Pablo",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                            IsApproved = false,
                            ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-        Cassanelli_inline.jpg.large.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Type = AnimalType.Bugs,
                            Age = 36,
                            Heigth = 1.5,
                            Weigth = 5,
                            Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
                        },
                        new Pet
                        {
                            Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = false,
                            Name = "Juanita",
                            Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                            ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Age = 42,
                            Heigth = 2.85,
                            Weigth = 300,
                            Type = AnimalType.Bird,
                            Requirements = "Every evening she needs to hear her husband Juan"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                            IsConfirmed = false,
                            AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                            BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012"
                        }
                    }
                },
                AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                Author = new ApplicationUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest1",
                    NormalizedUserName = "GUEST1",
                    Email = "guest1@mail.com",
                    NormalizedEmail = "GUEST1@MAIL.COM",
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    PhoneNumber = "0884305667",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = true,
                            Name = "Juan",
                            Description = "Horsey. He big and likes balconies.",
                            ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                            OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            Age = 69,
                            Heigth = 3,
                            Weigth = 420,
                            Type = AnimalType.Exotic,
                            Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    }
                }
            }
        }; //Done

        public List<Announcement> Announcements = new List<Announcement>
        {
            new Announcement
            {
                IsAvailable = true,
                Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                OfferedPaying = 3000,
                DayStarting = DateTime.Parse("28/12/2022"),
                DayEnding = DateTime.Parse("06/01/2022"),
                Requests = new List<Request>
                {
                    new Request
                    {
                        Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                        AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                        Announcement = new Announcement
                        {
                            IsAvailable = true,
                            Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            OfferedPaying = 3000,
                            DayStarting = DateTime.Parse("28/12/2022"),
                            DayEnding = DateTime.Parse("06/01/2022")
                        },
                        IsConfirmed = false,
                        BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082",
                        Babysitter = new ApplicationUser()
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            UserName = "admin",
                            NormalizedUserName = "ADMIN",
                            Email = "admin@mail.com",
                            NormalizedEmail = " ADMIN@MAIL.COM",
                            FirstName = "Petar",
                            LastName = "Petrov",
                            PhoneNumber = "0882854999",
                            TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                            Pets = new List<Pet>()
                            {
                                new Pet
                                {
                                    Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                                    DateAdded = DateTime.UtcNow,
                                    Name = "Mishi",
                                    Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and     typesetting       industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                                    IsApproved = true,
                                    ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?             s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                                    OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                                    Age = 3,
                                    Heigth = 0.3,
                                    Weigth = 4,
                                    Type = AnimalType.Cat,
                                    Requirements = "Needs to be played with and weekly beautition session"
                                }
                            },
                            Town = new Town
                            {
                                Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                                Name = "Veliko Tarnovo",
                                IsApproved = true
                            },
                            CommentsReceived = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                                    Title = "Great babysitter",
                                    Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                                    AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                                    ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            },
                            CommentsWritten = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                                    Title = "Don't recommend",
                                    Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                },
                                new Comment
                                {
                                    Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                                    Title = "Worst babysitter",
                                    Content = "He returned my cat ill and starving! He had beaten up my cat!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            },
                            Requests = new List<Request>
                            {
                                new Request
                                {
                                    Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                                    AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                                    IsConfirmed = true,
                                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                                },
                                new Request
                                {
                                    Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                                    AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                                    IsConfirmed = false,
                                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            }
                        }
                    },
                    new Request
                    {
                        Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                        AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                        IsConfirmed = false,
                        BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                        Announcement = new Announcement
                        {
                            IsAvailable = true,
                            Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            OfferedPaying = 3000,
                            DayStarting = DateTime.Parse("28/12/2022"),
                            DayEnding = DateTime.Parse("06/01/2022")
                        },
                        Babysitter = new ApplicationUser()
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            UserName = "guest1",
                            NormalizedUserName = "GUEST1",
                            Email = "guest1@mail.com",
                            NormalizedEmail = "GUEST1@MAIL.COM",
                            FirstName = "Ivan",
                            LastName = "Georgiev",
                            PhoneNumber = "0884305667",
                            TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                            Town = new Town
                            {
                                Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                                Name = "Veliko Tarnovo",
                                IsApproved = true
                            },
                            Pets = new List<Pet>()
                            {
                                new Pet
                                {
                                    Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                                    DateAdded = DateTime.UtcNow,
                                    IsApproved = true,
                                    Name = "Juan",
                                    Description = "Horsey. He big and likes balconies.",
                                    ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                                    OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    Age = 69,
                                    Heigth = 3,
                                    Weigth = 420,
                                    Type = AnimalType.Exotic,
                                    Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                                }
                            },
                            CommentsWritten = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                                    Title = "Can't complain",
                                    Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                                    ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                                    AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                                }
                            },
                            CommentsReceived = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                                    Title = "Don't recommend",
                                    Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                },
                                new Comment
                                {
                                    Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                                    Title = "Worst babysitter",
                                    Content = "He returned my cat ill and starving! He had beaten up my cat!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            },
                            Requests = new List<Request>
                            {
                                new Request
                                {
                                    Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                                    AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                                    IsConfirmed = false,
                                    BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                                }
                            }
                        }
                    }
                },
                Pet = new Pet()
            },
            new Announcement
            {
                IsAvailable = false,
                Id = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                OfferedPaying = 150,
                PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                DayStarting = DateTime.Parse("13/03/2023"),
                DayEnding = DateTime.Parse("17/03/2023"),
                Requests = new List<Request>
                {
                    new Request
                    {
                        Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                        AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                        Announcement = new Announcement
                        {
                            IsAvailable = false,
                            Id = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            OfferedPaying = 150,
                            PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            DayStarting = DateTime.Parse("13/03/2023"),
                            DayEnding = DateTime.Parse("17/03/2023")
                        },
                        IsConfirmed = true,
                        BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082",
                        Babysitter = new ApplicationUser()
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            UserName = "admin",
                            NormalizedUserName = "ADMIN",
                            Email = "admin@mail.com",
                            NormalizedEmail = " ADMIN@MAIL.COM",
                            FirstName = "Petar",
                            LastName = "Petrov",
                            PhoneNumber = "0882854999",
                            TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                            Pets = new List<Pet>()
                            {
                                new Pet
                                {
                                    Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                                    DateAdded = DateTime.UtcNow,
                                    Name = "Mishi",
                                    Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and     typesetting       industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                                    IsApproved = true,
                                    ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?             s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                                    OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                                    Age = 3,
                                    Heigth = 0.3,
                                    Weigth = 4,
                                    Type = AnimalType.Cat,
                                    Requirements = "Needs to be played with and weekly beautition session"
                                }
                            },
                            Town = new Town
                            {
                                Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                                Name = "Veliko Tarnovo",
                                IsApproved = true
                            },
                            CommentsReceived = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                                    Title = "Great babysitter",
                                    Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                                    AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                                    ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            },
                            CommentsWritten = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                                    Title = "Don't recommend",
                                    Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                },
                                new Comment
                                {
                                    Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                                    Title = "Worst babysitter",
                                    Content = "He returned my cat ill and starving! He had beaten up my cat!",
                                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            },
                            Requests = new List<Request>
                            {
                                new Request
                                {
                                    Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                                    AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                                    IsConfirmed = true,
                                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                                },
                                new Request
                                {
                                    Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                                    AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                                    IsConfirmed = false,
                                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                                }
                            }
                        }
                    }
                },
                Pet = new Pet
                {
                    Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    DateAdded = DateTime.UtcNow,
                    IsApproved = true,
                    Name = "Juan",
                    Description = "Horsey. He big and likes balconies.",
                    ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                    OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    Age = 69,
                    Heigth = 3,
                    Weigth = 420,
                    Type = AnimalType.Exotic,
                    Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                }
            },
            new Announcement
            {
                IsAvailable = true,
                PetId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                Id = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                OfferedPaying = 400,
                Pet = new Pet(),
                DayStarting = DateTime.Parse("23/01/2023"),
                DayEnding = DateTime.Parse("28/03/2023")
            }
        };

        public List<Request> Requests = new List<Request>
        {
            new Request
            {
                Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                Announcement = new Announcement
                {
                    IsAvailable = false,
                    Id = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                    OfferedPaying = 150,
                    PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    DayStarting = DateTime.Parse("13/03/2023"),
                    DayEnding = DateTime.Parse("17/03/2023")
                },
                IsConfirmed = true,
                BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082",
                Babysitter = new ApplicationUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = " ADMIN@MAIL.COM",
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PhoneNumber = "0882854999",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                            DateAdded = DateTime.UtcNow,
                            Name = "Mishi",
                            Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting     industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                            IsApproved = true,
                            ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?     s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                            OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                            Age = 3,
                            Heigth = 0.3,
                            Weigth = 4,
                            Type = AnimalType.Cat,
                            Requirements = "Needs to be played with and weekly beautition session"
                        }
                    },
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                            AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            IsConfirmed = true,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Request
                        {
                            Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    }
                }
            },
            new Request
            {
                Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                Announcement = new Announcement
                {
                    IsAvailable = true,
                    Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                    PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    OfferedPaying = 3000,
                    DayStarting = DateTime.Parse("28/12/2022"),
                    DayEnding = DateTime.Parse("06/01/2022")
                },
                IsConfirmed = false,
                BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082",
                Babysitter = new ApplicationUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = " ADMIN@MAIL.COM",
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PhoneNumber = "0882854999",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                            DateAdded = DateTime.UtcNow,
                            Name = "Mishi",
                            Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting     industry.   Lorem Ipsum has been the industry's standard dummy text ever since the",
                            IsApproved = true,
                            ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?     s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                            OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                            Age = 3,
                            Heigth = 0.3,
                            Weigth = 4,
                            Type = AnimalType.Cat,
                            Requirements = "Needs to be played with and weekly beautition session"
                        }
                    },
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                            AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                            IsConfirmed = true,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Request
                        {
                            Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    }
                }
            },
            new Request
            {
                Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                IsConfirmed = false,
                BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                Announcement = new Announcement
                {
                    IsAvailable = true,
                    Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                    PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    OfferedPaying = 3000,
                    DayStarting = DateTime.Parse("28/12/2022"),
                    DayEnding = DateTime.Parse("06/01/2022")
                },
                Babysitter = new ApplicationUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest1",
                    NormalizedUserName = "GUEST1",
                    Email = "guest1@mail.com",
                    NormalizedEmail = "GUEST1@MAIL.COM",
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    PhoneNumber = "0884305667",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>()
                    {
                        new Pet
                        {
                            Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = true,
                            Name = "Juan",
                            Description = "Horsey. He big and likes balconies.",
                            ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                            OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            Age = 69,
                            Heigth = 3,
                            Weigth = 420,
                            Type = AnimalType.Exotic,
                            Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                            Title = "Don't recommend",
                            Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new Comment
                        {
                            Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                            Title = "Worst babysitter",
                            Content = "He returned my cat ill and starving! He had beaten up my cat!",
                            ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                            AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                            IsConfirmed = false,
                            BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    }
                }
            },
            new Request
            {
                Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                IsConfirmed = false,
                AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012",
                Babysitter = new ApplicationUser()
                {
                    Id = "72153552-7b85-4e34-b236-290e9bbad012",
                    UserName = "guest2",
                    NormalizedUserName = "GUEST2",
                    Email = "guest2@mail.com",
                    NormalizedEmail = "GUEST2@MAIL.COM",
                    FirstName = "Boyan",
                    LastName = "Hristov",
                    PhoneNumber = "0854993215",
                    TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Town = new Town
                    {
                        Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                        Name = "Veliko Tarnovo",
                        IsApproved = true
                    },
                    Pets = new List<Pet>
                    {
                        new Pet
                        {
                            Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                            DateAdded= DateTime.UtcNow,
                            Name = "Pablo",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                            IsApproved = false,
                            ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-        Cassanelli_inline.jpg.large.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Type = AnimalType.Bugs,
                            Age = 36,
                            Heigth = 1.5,
                            Weigth = 5,
                            Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
                        },
                        new Pet
                        {
                            Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                            DateAdded = DateTime.UtcNow,
                            IsApproved = false,
                            Name = "Juanita",
                            Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                            ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                            OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                            Age = 42,
                            Heigth = 2.85,
                            Weigth = 300,
                            Type = AnimalType.Bird,
                            Requirements = "Every evening she needs to hear her husband Juan"
                        }
                    },
                    CommentsWritten = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                            Title = "Great babysitter",
                            Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                            AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                            ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                        }
                    },
                    CommentsReceived = new List<Comment>
                    {
                        new Comment
                        {
                            Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                            Title = "Can't complain",
                            Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                            ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                            AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        }
                    },
                    Requests = new List<Request>
                    {
                        new Request
                        {
                            Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                            IsConfirmed = false,
                            AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                            BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012"
                        }
                    }
                },
                Announcement = new Announcement
                {
                    IsAvailable = true,
                    PetId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    Id = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                    OfferedPaying = 400,
                    DayStarting = DateTime.Parse("23/01/2023"),
                    DayEnding = DateTime.Parse("28/03/2023")
                }
            }
        };

        public List<Pet> Pets = new List<Pet>()
        {
            new Pet
            {
                Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                DateAdded = DateTime.UtcNow,
                Name = "Mishi",
                Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the",
                IsApproved = true,
                ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpgs=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                Age = 3,
                Heigth = 0.3,
                Weigth = 4,
                Type = AnimalType.Cat,
                Requirements = "Needs to be played with and weekly beautition session"
            },
            new Pet
            {
                Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                DateAdded= DateTime.UtcNow,
                Name = "Pablo",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                IsApproved = false,
                ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-GuidoCassanelli_inline.jpg.large.jpg",
                OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                Type = AnimalType.Bugs,
                Age = 36,
                Heigth = 1.5,
                Weigth = 5,
                Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
            },
            new Pet
            {
                Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                DateAdded = DateTime.UtcNow,
                IsApproved = true,
                Name = "Juan",
                Description = "Horsey. He big and likes balconies.",
                ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                Age = 69,
                Heigth = 3,
                Weigth = 420,
                Type = AnimalType.Exotic,
                Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
            },
            new Pet
            {
                Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                DateAdded = DateTime.UtcNow,
                IsApproved = false,
                Name = "Juanita",
                Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                Age = 42,
                Heigth = 2.85,
                Weigth = 300,
                Type = AnimalType.Bird,
                Requirements = "Every evening she needs to hear her husband Juan"
            }
        };

        public List<Town> Towns = new List<Town>
        {
            new Town
            {
                Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                Name = "Veliko Tarnovo",
                IsApproved = true
            },
            new Town
            {
                Id = Guid.Parse("651dc286-24dd-473e-8099-a56ad3e7a6e2"),
                Name = "Sofia",
                IsApproved = false
            },
            new Town
            {
                Id = Guid.Parse("d3e30c24-857f-4cd0-ba75-b9accb4d7c9f"),
                Name = "Lovech",
                IsApproved = true
            },
            new Town
            {
                Id = Guid.Parse("db7127bc-1d68-4b3b-a523-a68a78b7e4a8"),
                Name = "Pleven",
                IsApproved = true
            },
            new Town
            {
                Id = Guid.Parse("d6ce7d29-6f17-478d-af2f-b45fb212dd02"),
                Name = "Plovdiv",
                IsApproved = false
            },
            new Town
            {
                Id = Guid.Parse("6fb2fef5-b16e-49dd-bfc4-8aef199df54c"),
                Name = "Pavlikeni",
                IsApproved = true
            }
        }; //Done
    }
}
