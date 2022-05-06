using Bogus;
using Bogus.Hollywood;
using BuzzMobile.Shared.Models;

namespace BuzzMobile.Pages;

public class IndexBase : PageBase
{
   /*protected override async Task OnAfterRenderAsync(bool firstRender)
   {
      if (firstRender)
      {
         await GenerateIndexMovieFaker();
      }
   }
   public async Task GenerateIndexMovieFaker()
   {
      var indexFaker = new Faker<MovieModel>()
            .RuleFor(x => x.Movie, x => x.Movies().MovieTagline())
         ;

      Model = indexFaker.Generate(1);
   }*/
}