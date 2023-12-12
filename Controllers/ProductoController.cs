using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
	public class ProductoController : Controller
	{
		public IActionResult Index()
		{
			return Content("Esto es el index");
		}
		public IActionResult Listar()
		{
			return Content("Listamos los productos");
		}
		public IActionResult Detalle(int idProducto)
		{
			return Content("Detallamos un producto específico");
		}
		//actividad 3
		[Route("Producto/Buscar/{terminoBusqueda?}")]
		public IActionResult Buscar(string terminoBusqueda)
		{
			if (terminoBusqueda == null || terminoBusqueda == "")
			{
				return RedirectToAction("Index");
			}
			return Content($"Buscamos el término {terminoBusqueda}");
		}

		[Route("Producto/Agregar/{producto?}")]
		public IActionResult Agregar(Producto producto)
		{

			if (producto == null) {
				return Content("Formulario agregar");
			}
			//llamamos al modelo para agregarlo a la bd
			return RedirectToAction("Index");
		}

		[Route("Producto/Editar/{id?}/{producto?}")]
		public IActionResult Editar(int id, Producto producto)
		{

			if (id == 0) //aparentemente si no se rellena un parametro de tipo int es igual a 0
			{
				return Content("Index1");
			}
			if (producto == null)
			{
				return Content("Formulario Agregar");
			}
			else {
				//actualizar producto
				return Content("Indexxx");
			}
			
			
		}
	}
	public class Producto //creamos aquí mismo la clase Producto para el ejemplo de Agregar
	{

	}

}


