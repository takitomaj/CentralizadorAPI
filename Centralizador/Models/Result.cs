﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centralizador.Models
{
    public class Result
    {
        public string wrapperType { get; set; }
        public string kind { get; set; }
        public int artistId { get; set; }
        public int collectionId { get; set; }
        public int trackId { get; set; }
        public string artistName { get; set; }
        public string collectionName { get; set; }
        public string trackName { get; set; }
        public string collectionCensoredName { get; set; }
        public string trackCensoredName { get; set; }
        public string artistViewUrl { get; set; }
        public string collectionViewUrl { get; set; }
        public string trackViewUrl { get; set; }
        public string previewUrl { get; set; }
        public string artworkUrl30 { get; set; }
        public string artworkUrl60 { get; set; }
        public string artworkUrl100 { get; set; }
        public double collectionPrice { get; set; }
        public double trackPrice { get; set; }
        public DateTime releaseDate { get; set; }
        public string collectionExplicitness { get; set; }
        public string trackExplicitness { get; set; }
        public int discCount { get; set; }
        public int discNumber { get; set; }
        public int trackCount { get; set; }
        public int trackNumber { get; set; }
        public int trackTimeMillis { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
        public string primaryGenreName { get; set; }
        public bool isStreamable { get; set; }
        public int? collectionArtistId { get; set; }
        public string collectionArtistViewUrl { get; set; }
        public double? trackRentalPrice { get; set; }
        public double? collectionHdPrice { get; set; }
        public double? trackHdPrice { get; set; }
        public double? trackHdRentalPrice { get; set; }
        public string contentAdvisoryRating { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public bool? hasITunesExtras { get; set; }
        public string collectionArtistName { get; set; }
    }
}