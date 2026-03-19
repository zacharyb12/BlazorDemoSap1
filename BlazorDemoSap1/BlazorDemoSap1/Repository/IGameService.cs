using BlazorDemoSap1.Models;

namespace BlazorDemoSap1.Repository
{
    public interface IGameService
    {
        List<Game> GetGames();


        Game? GetById(int id);


        public bool UpdateGame(UpdateGame updatedGame, int id);

        public bool AddGame(AddGame newGame);

        public bool RemoveGame(int id);

    }
}
