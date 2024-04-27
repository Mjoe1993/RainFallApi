using RainFallLibrary.Models;
using RainFallLibrary.Services;
using RainFallLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallLibrary.Data
{
    public class DataRepository : IDataRepository
    {


        async Task<Root?> IDataRepository.GetRoot(int id)
        {
            try
            {
                ApiHelper.InitializeCient();
                string rainFallById = $"id/stations/{id}";
                string url = SD.Root_RainFall_API + rainFallById;
                using (HttpResponseMessage response = await ApiHelper.HttpClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Root root = new Root();
                        root = await response.Content.ReadAsAsync<Root>();
                        return root;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }

        }

    }
}
