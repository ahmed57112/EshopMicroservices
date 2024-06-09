using MediatR;

namespace catalogApi.products.craeteProduct
{
    public record CreateProductCommand(string Name,string Description,List<string> Category,decimal Price,string ImageFile)
        :IRequest<CreateProductResult>;

    public record CreateProductResult(Guid Id);
    internal class craeteProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>

    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //logic to create product
            throw new NotImplementedException();
        }
    }
}
