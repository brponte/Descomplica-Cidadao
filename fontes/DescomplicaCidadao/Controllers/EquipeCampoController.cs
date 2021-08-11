using DescomplicaCidadao.Filters;
using DescomplicaCidadao.Models.Data;
using DescomplicaCidadao.Models.DB;
using System.Web.Mvc;

namespace DescomplicaCidadao.Controllers
{
	[EhEquipeCampoFilter]
	public class EquipeCampoController : BaseController
	{
		//----------------------------------------------------------------------
		public ActionResult Index()
		{
			return View( "Index" );
		}

		//----------------------------------------------------------------------
	}
}
 