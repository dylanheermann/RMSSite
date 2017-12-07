using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    public class SongEntity
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Song { get; set; }
        public string Description { get; set; }
        public string SongName { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}