using System;
using TE.Net.Common.Core;

namespace TE.Net.Common.Core
{
	public class TipoUsuarioService : ITipoUsuarioService
	{
		private ITipoUsuarioDAO tipoUsuarioDAO;
		
		public TipoUsuarioService ()
		{
			this.tipoUsuarioDAO = new TipoUsuarioNHibernateDAO();
		}
		
		public string findusuario(string nome)
		{
			return this.tipoUsuarioDAO.findusuario(nome);
		}
	}
}

