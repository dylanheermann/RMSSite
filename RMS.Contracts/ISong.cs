using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models;

namespace RMS.Contracts
{
    public interface ISong
    {
        bool CreateSong(SongCreateModel model);
        IEnumerable<SongListModel> GetSongs();
        SongDetailsModel GetSongById(int songId);
        bool UpdateSong(SongEditModel model);
        bool DeleteSong(int songId);
    }
}
