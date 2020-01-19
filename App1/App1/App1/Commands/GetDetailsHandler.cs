using System.Threading;
using System.Threading.Tasks;
using App1.Models;
using App1.Services;
using MediatR;

namespace App1.Commands
{
    public class GetDetailsHandler : IRequestHandler<GetDetailsRequest, GetDetailsResponse>
    {
        private readonly IDataStore<Item> items;

        public GetDetailsHandler(IDataStore<Item> items)
        {
            this.items = items;
        }

        public async Task<GetDetailsResponse> Handle(GetDetailsRequest request, CancellationToken cancellationToken)
        {
            var item = await items.GetItemAsync(request.Id);
            return new GetDetailsResponse(){Item = item};
        }
    }
}
