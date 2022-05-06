using Bogus;
using BuzzMobile.Shared.Models;

namespace BuzzMobile.Pages.Movie;

public class SearchBase : PageBase
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await GenerateImageFaker();
        }
    }
    
    public async Task GenerateImageFaker()
    {
        var actorFaker = new Faker<MovieModel>()
                .RuleFor(x => x.Actor, x => x.Person.FullName)
                .RuleFor(x => x.Image, x => x.Person.Avatar)
            ;
        Model = actorFaker.GenerateBetween(1, 4);
        StateHasChanged();
    }
}