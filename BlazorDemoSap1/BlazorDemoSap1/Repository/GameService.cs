using BlazorDemoSap1.Models;

namespace BlazorDemoSap1.Repository
{
    public class GameService : IGameService
    {
        public List<Game> Games { get; set; } = new()
        {
            new Game
            {
                Id = 1,
                Creator = "CD Projekt Red",
                Name = "Cyberpunk 2077",
                Description = "Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg",
                Price = 59.99
            },
            new Game
            {
                Id = 2,
                Creator = "FromSoftware",
                Name = "Elden Ring",
                Description = "Elden Ring is an action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5e/Elden_Ring_cover_art.jpg",
                Price = 59.99
            },
                new Game
                {
                    Id = 3,
                    Creator = "CD Projekt Red",
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                    Price = 39.99
                },
                new Game
                {
                    Id = 4,
                    Creator = "Rockstar Games",
                    Name = "Red Dead Redemption 2",
                    Description = "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg",
                            Price = 59.99
                        }
                    };

        public int LastId { get; set; } = 4;

        public List<Game> GetGames()
        {
            return Games.ToList();
        }

        public Game? GetById(int id)
        {
            Game? game = Games.FirstOrDefault(g => g.Id == id);

            if(game == null)
            {
                return null;
            }

            return game;
        }

        public bool UpdateGame(UpdateGame updatedGame , int id)
        {
            int index = Games.FindIndex(g => g.Id == id);

            if (index == -1)
            {
                return false;
            }

            Games[index].Description = updatedGame.Description;
            Games[index].ImageUrl = updatedGame.ImageUrl;
            Games[index].Price = updatedGame.Price;
            
            return true;
        }

        public bool AddGame(AddGame newGame)
        {
            int index = Games.FindIndex(g => g.Name == newGame.Name);


            if(index == -1)
            {

                Game game = new()
                {
                    Id = ++LastId,
                    Creator = newGame.Creator,
                    Name = newGame.Name,
                    Description = newGame.Description,
                    ImageUrl = newGame.ImageUrl,
                    Price = newGame.Price
                };

                Games.Add(game);
                return true;
            }
            return false;
        }

        public bool RemoveGame(int id)
        {
            int index = Games.FindIndex(g => g.Id == id);

            if (index == -1)
            {
                return false;
            }

            Games.RemoveAt(index);
            return true;
        }
    }
}
