using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RainFallApi.Models;
using RainFallApi.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RainFallApi.Controllers
{
    [Route("api/RainFall")]
    [ApiController]
    public class RainFallController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// test test
        /// </remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}", Name = "GetRainfallById")]
        public async Task<ActionResult> GetRainfallById(int id)
        {
            ApiHelper.InitializeCient();
            string url = "https://environment.data.gov.uk/flood-monitoring/id/stations/3680";
  
    
            using (HttpResponseMessage response = await ApiHelper.HttpClient.GetAsync(url))
            {
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Root root = new Root();
                        root = await response.Content.ReadAsAsync<Root>();
                        return Ok(root);

                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
    

            }
        }
    }
}
