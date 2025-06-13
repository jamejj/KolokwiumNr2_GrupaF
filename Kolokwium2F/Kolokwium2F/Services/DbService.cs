using Kolokwium2F.Data;
using Kolokwium2F.DTOs;
using Kolokwium2F.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2F.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }



    public async Task<GalleryExhibitionDto> GetGalleryExhibitions(int galleryId)
    {


        var gallery = await _context.Galleries
            .Select(e => new GalleryExhibitionDto
            {
                GalleryId = gallery.GalleryId,
                Name = gallery.Name,
                EstablishedDate = gallery.EstablishedDate,
                Exhibitions = gallery.Exhibitions.Select(e => new ExhibitionDto
                {
                    Title = e.Title,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    NumberOfArtworks = e.NumberOfArtworks,
                    Artworks = e.ExhibitionArtworks.Select(ea => new ArtworkDto
                    {
                        Title = ea.Artwork.Title,
                        YearCreated = ea.Artwork.YearCreated,
                        InsuranceValue = ea.InsuranceValue,
                        Artist = new ArtistDto
                        {
                            FirstName = ea.Artwork.Artist.FirstName,
                            LastName = ea.Artwork.Artist.LastName,
                            BirthDate = ea.Artwork.Artist.BirthDate
                    }).ToList()
                }).FirstOrDefaultAsync(e => e.Id == galleryId);

                if (gallery is null)
                throw new NotFoundException("Not found");
                return gallery;
            }

    }




