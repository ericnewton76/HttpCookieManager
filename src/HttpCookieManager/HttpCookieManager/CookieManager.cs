using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpCookieManager
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Web;

	namespace HttpCookieManager
	{

		public class CookieManager
		{
			private static CookieManager S_CookieManager = new CookieManager();
			public static CookieManager Current { get { return S_CookieManager; } }

			public virtual bool Exists<T>(HttpContextBase httpContextBase)
			{
				throw new NotImplementedException();
			}
			public virtual void SetCookie<T>(HttpResponseBase httpReponse, T value)
			{
				throw new NotImplementedException();
			}
			public virtual T GetCookie<T>(HttpRequestBase httpRequest)
			{
				throw new NotImplementedException();
			}
		}
	}

}
