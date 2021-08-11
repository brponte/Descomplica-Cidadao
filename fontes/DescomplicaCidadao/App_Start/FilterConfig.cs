using System.Web;
using System.Web.Mvc;
using DescomplicaCidadao.Filters;

namespace DescomplicaCidadao
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters( GlobalFilterCollection filters )
		{
			filters.Add( new CustomHandleErrorAttribute() );
		}
	}
}