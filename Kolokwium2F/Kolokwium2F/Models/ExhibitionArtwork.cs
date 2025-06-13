using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2F.Models;

[Table("Exhibition_Artwork")]
public class ExhibitionArtwork
{
    [Key]
    public int Exhibition { get; set; }
    [ForeignKey("ArtworkId")]
    public int ArtworkId { get; set; }
    public decimal InsuranceValue { get; set; }
}