using System;
using System.Security;

namespace TE.Net.Common.Core
{
	public class TipoUsuario
	{
	
		#region Membros Privados
			
		private bool isChanged;
		
		//Chave Primária
		private int id;
		
		//Propriedades
		private string nome;
		private string descricao;
		
		#endregion
		
		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.TipoUsuario"/> class.
		/// </summary>
		public TipoUsuario ()
		{
			this.id = 0;
			this.nome = String.Empty;
			this.descricao = String.Empty;
		}
		
		#endregion
	
		#region Contrutor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.TipoUsuario"/> class.
		/// </summary>
		/// <param name='id'>
		/// Identifier.
		/// </param>
		/// <param name='nome'>
		/// Nome.
		/// </param>
		/// <param name='descricao'>
		/// Descricao.
		/// </param>
		public TipoUsuario(int id, string nome, string descricao)
		{
			this.id = id;
			this.nome = nome;
			this.descricao = descricao;
		}
		
		#endregion
	
		#region Propriedades Públicas
		
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public virtual int Id
		{
			get {return this.id;}
			set
			{
				this.isChanged = true;
				this.id = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the nome.
		/// </summary>
		/// <value>
		/// The nome.
		/// </value>
		public virtual string Nome
		{
			get{return this.nome;}
			set 
			{
				this.isChanged = true;
				this.nome = value;	
			}
		}
			
		/// <summary>
		/// Gets or sets the descricao.
		/// </summary>
		/// <value>
		/// The descricao.
		/// </value>
		public virtual string Descricao
		{
			get { return this.descricao;}
			set 
			{
				this.isChanged = true;
				this.descricao = value;
			}
		}
		
		/// <summary>
		/// Gets a value indicating whether this instance is changed.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is changed; otherwise, <c>false</c>.
		/// </value>
		public virtual bool IsChanged
		{
			get { return this.isChanged; }
		}
		
		#endregion

		#region Equals
		
		/// <summary>
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.TipoUsuario"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.TipoUsuario"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.TipoUsuario"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is TipoUsuario)
			{
				if( (obj as TipoUsuario).Id == this.id)
					return true;
			}
			return false;
		}
		
		#endregion
		
		#region GetHashCode
		
		/// <summary>
		/// Serves as a hash function for a <see cref="TE.Net.Common.Core.TipoUsuario"/> object.
		/// </summary>
		/// <returns>
		/// A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.
		/// </returns>
		/*public override int GetHashCode ()
		{
			//return this.id * this.GetHashCode;
			base.GetHashCode();
		}*/
		
		#endregion
	}
}