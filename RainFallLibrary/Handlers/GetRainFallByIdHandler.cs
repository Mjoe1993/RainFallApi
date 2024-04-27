using MediatR;
using RainFallLibrary.Data;
using RainFallLibrary.Models;
using RainFallLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallLibrary.Handlers
{
    public class GetRainFallByIdHandler : IRequestHandler<GetRainFallByIdQuery, Root>
    {
        private readonly IDataRepository _repository;
        public GetRainFallByIdHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<Root> Handle(GetRainFallByIdQuery request, CancellationToken cancellationToken )
        {
            return await Task.FromResult( await _repository.GetRoot(request.id));
        }
    }
}
