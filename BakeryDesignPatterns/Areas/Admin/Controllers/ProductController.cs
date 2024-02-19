using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
   
        private readonly GetAllProductQueryHandler _productQueryHandler;
        private readonly CreateProductQueryHandler _createProductQueryHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        public ProductController(GetAllProductQueryHandler productQueryHandler, CreateProductQueryHandler createProductQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _productQueryHandler = productQueryHandler;
            _createProductQueryHandler = createProductQueryHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            var values = _productQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
           return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _createProductQueryHandler.Handle(command);
            return View();
        }
        public IActionResult DeleteProduct(string id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct()
        {

        }
    }
}

