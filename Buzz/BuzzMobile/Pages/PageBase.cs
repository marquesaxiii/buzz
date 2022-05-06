using BuzzMobile.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BuzzMobile.Pages;

public class PageBase : ComponentBase
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    public List<MovieModel> Model { get; set; } = new();
   
}