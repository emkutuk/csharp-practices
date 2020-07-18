﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class AlbumAdapter : IVinylSingle
    {
        private IVinylAlbum album;

        public AlbumAdapter(IVinylAlbum album)
        {
            this.album = album;
        }

        public void Pause()
        {
            album.Pause();
        }

        public void Play()
        {
            album.Play();
        }

        public void Stop()
        {
            album.Stop();
        }
    }
}
