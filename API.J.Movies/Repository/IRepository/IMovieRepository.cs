using API.J.Movies.DAL.Models;

namespace API.J.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); //Me retorna una lista de peliculas
        Task<Movie> GetMovieAsync(int id); //Me retorna una película en especifico
        Task<bool> MovieExistsByIdAsync(int id); //Verifica si una película existe por id
        Task<bool> MovieExistsByNameAsync(string name); //Verifica si una película existe por nombre
        Task<bool> CreateMovieAsync(Movie movie); //Crea una nueva película
        Task<bool> UpdateMovieAsync(Movie movie); //Actualiza una película
        Task<bool> DeleteMovieAsync(int id); //Elimina una película buscando por id
    }
}
