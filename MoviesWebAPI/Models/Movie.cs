using System.ComponentModel.DataAnnotations;

namespace MoviesWebAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double RunningTime { get; set; }
        public string Genre { get; set; }
    }
}
