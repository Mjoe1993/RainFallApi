using MediatR;
using RainFallLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallLibrary.Queries
{
    public record GetRainFallByIdQuery(int id):IRequest<Root>;

}
