namespace Kolokwium2F.DTOs;

public class GalleryExhibitionDto
{
    public int GalleryId { get; set; }
    public string Name { get; set; } 
    public DateTime EstablishedDate { get; set; }
    public List<ExhibitionDto> Exhibitions { get; set; } = new List<ExhibitionDto>();
}

/*
public class ExhibitionDto
{
    public string Title { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfArtworks { get; set; }
    public List<ArtworkDto> Artworks { get; set; } = new List<ArtworkDto>();
}
*/

/*
public class ArtworkDto
{
    public string Title { get; set; }
    public int YearCreated { get; set; }
    public decimal InsuranceValue { get; set; }
    public ArtistDto Artist { get; set; }
}
*/
/*
public class ArtistDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}
*/