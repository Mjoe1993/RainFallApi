using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RainFallLibrary.Models;
using RainFallLibrary.Queries;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RainFallApi.Controllers
{
    [Route("api/RainFall")]
    [ApiController]
    public class RainFallController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RainFallController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// You can get Rain Fall By Id
        /// </summary>
        /// <remarks>
        /// Information on from a particular station
        /// valid id = 3680
        /// </remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}", Name = "GetRainfallById")]
        public async Task<ActionResult> GetRainfallById(int id)
        {
            try
            {
                var result = await _mediator.Send(new GetRainFallByIdQuery(id));
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
