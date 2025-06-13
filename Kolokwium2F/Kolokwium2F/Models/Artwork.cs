﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2F.Models;

public class Artwork
{
    [Key]
    public int ArtworkId { get; set; }
    [ForeignKey("ArtistId")]
    public int ArtistId { get; set; }
    [MaxLength(100)]
    public string Title { get; set; }
    public int YearCreated { get; set; }
    
    public ICollection<ExhibitionArtwork> ExhibitionArtworks { get; set; } =null!;

}