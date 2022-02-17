using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string NameOfGame { get; set; }
        public string Producer { get; set; }
        public string Ganre { get; set; }
        public DateTime Realese { get; set; }
        public string GameMode { get; set; }
        public int SoldItemsCount { get; set; }
    }
}
