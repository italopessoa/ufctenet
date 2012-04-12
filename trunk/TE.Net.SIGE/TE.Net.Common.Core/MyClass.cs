using System;

namespace TE.Net.Common.Core
{
	public class MyClass
	{
		private ICoreFacade coreFacade;
		
		public MyClass ()
		{
			this.coreFacade = new Facade();
			this.coreFacade.findusuario("italo");
		}
	}
}

