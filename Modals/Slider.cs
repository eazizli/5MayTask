using Microsoft.Build.Framework;

namespace EvaraMVC.Modals;

public class Slider
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageName { get; set; }
}
