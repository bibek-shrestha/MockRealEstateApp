using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Controller;

[Route("api/houses")]
[ApiController]
public class HouseController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHouses()
    {
        var houseList = new[] {
                new {
                    id = 1,
                    address = "40 Albert Street, Rhodes",
                    country = "Australia",
                    price = 1000000,
                    photo = "164558.jpeg",
                    description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new {
                    id = 2,
                    address = "10 Alva Stree, Strathfield",
                    country = "Australia",
                    price = 900000,
                    photo = "259600.jpeg",
                    description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            };
        return Ok(houseList);
    }
}

