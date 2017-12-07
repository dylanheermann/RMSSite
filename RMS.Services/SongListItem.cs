using System;
using System.ComponentModel.DataAnnotations;

namespace RMS.Services
{
    public class SongListItem
    {
        public int SongId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => $"[{SongId}] {Title}";
    }
}