using EjSmith.Cards.Classes;
using EjSmith.Cards.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EjSmith.Cards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardDeckController(ICardDeckService cardDeckService) : ControllerBase
    {
        // GET: api/<CardDeckController>
        [HttpGet]
        public IEnumerable<CardDeck> Get()
        {
            return cardDeckService.GetDecks();
        }
    }
}
