using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using realestate.Models;

namespace realestate.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoriesController : ControllerBase
{
    private static List<Category> categories = new List<Category>()
    {
        new Category(){Id = 0, Name = "Apartment", ImageUrl = "Apartment.png" },
        new Category(){Id = 1, Name = "Commerical", ImageUrl = "Commerical.png" }
    };
    [HttpGet]
    public IEnumerable<Category> Get()
    {
        return categories;
    }
    [HttpPost]
    public void Post([FromBody] Category category)
    {
        categories.Add(category);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Category category)
    {
        categories[id] = category;
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        categories.RemoveAt(id);
    }
}
