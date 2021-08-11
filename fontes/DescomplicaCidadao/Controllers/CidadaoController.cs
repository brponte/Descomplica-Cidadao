using DescomplicaCidadao.Filters;
using DescomplicaCidadao.Models.Data;
using DescomplicaCidadao.Models.DB;
using System.Web.Mvc;

namespace DescomplicaCidadao.Controllers
{
	[EhCidadaoFilter]
	public class CidadaoController : BaseController
	{
		//----------------------------------------------------------------------
		public ActionResult Index()
		{
			return View( "Index" );
		}

		//----------------------------------------------------------------------
	}
}
 