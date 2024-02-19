using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers;
using BakeryDesignPatterns.Areas.Admin.CQRS.Querys;
using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
   
        private readonly GetAllProductQueryHandler _productQueryHandler;
        private readonly CreateProductQueryHandler _createProductQueryHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        public ProductController(GetAllProductQueryHandler productQueryHandler, CreateProductQueryHandler createProductQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler)
        {
            _productQueryHandler = productQueryHandler;
            _createProductQueryHandler = createProductQueryHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
        }

       
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
            if (ModelState.IsValid)
            {
                _createProductQueryHandler.Handle(command);
                return RedirectToAction("Index");
            }
          return View();
        }
        public IActionResult DeleteProduct(string id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(string id)
        {
            var values =  _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}

