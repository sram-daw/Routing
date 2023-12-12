using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class BlogController : Controller
    {
        [Route("Tienda/index/{id:int}")]
        public IActionResult Index(int id)
        {
			return Content("El ID es "+ id);
        }

		[Route("Producto/Detalles/{id:int:length(4)}-{slug:alpha}")]
		public IActionResult Detalles(int id, string slug)
		{
			return Content("El ID es " + id+ " y el slug es"+slug);
		}
		[Route("Listado/{categoria?}/{marca?}")]
		public IActionResult Listado(string categoria, string marca)
		{
			//return Content("Listamos los productos de "+ categoria+" y "+marca);
			return Content($"Listamos los productos de {categoria} y {marca}");
		}
		[Route("Blog/Enumerar")] //otra forma de asignar rutas sin necesidad de usar Program.cs
        public IActionResult Listar()
        {
            return Content("Listamos los posts del blog");
        }
        [Route("Blog/Detalle/{id:int}")] //solo entrará en esta acción si el id es un numero
        public IActionResult Detalle(int idPublicacion)
        {
            return Content("Muestra detalles de un post");
        }
        public IActionResult Crear(string nombre)
        {
            return Content("Creamos nueva publicacion.");
        }
        public IActionResult Editar(string nombre)
        {
            return Content("Modificamos nueva publicacion.");
        }
        public IActionResult Eliminar(string nombre)
        {
            return Content("Eliminamos una publicacion.");
        }
     
    }
}
