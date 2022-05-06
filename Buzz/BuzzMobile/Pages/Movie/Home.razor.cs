using Bogus;
using Bogus.Hollywood;
using BuzzMobile.Shared.Models;

namespace BuzzMobile.Pages.Movie;

public class HomeBase : PageBase
{
   protected override async Task OnAfterRenderAsync(bool firstRender)
   {
      if (firstRender)
      {
         await GenerateMovieFaker();
      }
   }

   public async Task GenerateMovieFaker()
   {
      var movieFaker = new Faker<MovieModel>()
            .RuleFor(x => x.Movie, x => x.Movies().MovieCollection())
            .RuleFor(x => x.Movie, x => x.Movies().MovieTitle())
            .RuleFor(x => x.Movie, x => x.Movies().MovieOverview())
         ;
      Model = movieFaker.GenerateBetween(1, 10);
      StateHasChanged();
   }
}