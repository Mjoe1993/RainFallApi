using RainFallLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallLibrary.Data
{
    public interface IDataRepository
    {
       Task<Root?>  GetRoot(int id);
    }
}
