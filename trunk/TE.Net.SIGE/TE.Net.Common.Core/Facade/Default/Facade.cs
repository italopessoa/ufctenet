using System;

namespace TE.Net.Common.Core
{
	public class Facade : ICoreFacade
	{
		ITipoUsuarioService tipoUsuarioservice;
		
		public Facade ()
		{
			this.tipoUsuarioservice = new TipoUsuarioService();
		}
		
		public string findusuario(string nome)
		{
			return this.tipoUsuarioservice.findusuario(nome);
		}
	}
}

