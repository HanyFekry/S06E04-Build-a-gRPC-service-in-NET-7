using Grpc.Core;
using static ToDoGrpc.Image;

namespace ToDoGrpc.Services
{
    public class ImageService : ImageBase
    {
        public override async Task<GetUrlResponse> GetUrl(GetUrlRequest request, ServerCallContext context)
        {
            if (!string.IsNullOrEmpty(request?.Name))
                return await Task.FromResult(new GetUrlResponse { Url = "sample url" });
            throw new RpcException(new Status(StatusCode.NotFound, $"No image with name {request?.Name}"));
        }
    }
}
