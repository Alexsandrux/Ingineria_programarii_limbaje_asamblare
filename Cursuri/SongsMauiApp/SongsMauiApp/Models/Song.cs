using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SongsMauiApp.Models
{
    [SQLite.Table("songs")]
    class Song
    {
        [PrimaryKey, AutoIncrement]
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("nume")]
        public string Nume { get; set; }

        [JsonPropertyName("gen")]
        public string Gen { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonIgnore]
        public bool IsFavorite { get; set; }

    }
}
