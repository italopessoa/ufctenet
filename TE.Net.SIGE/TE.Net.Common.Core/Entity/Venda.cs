using System;

namespace TE.Net.Common.Core
{
	public class Venda
	{
		
		#region Membros Privados
		
		private bool isChanged;
		
		//Chave Primária
		private int codigo;
		
		
		//Propriedades
		private Produto produto;
		private DateTime dtVenda;
		private string loginUsuario;
		
		#endregion

		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Venda"/> class.
		/// </summary>
		public Venda ()
		{
			this.codigo = 0;
			this.produto = null;
			this.dtVenda = null;
			this.loginUsuario = string.Empty;
		}
		
		#endregion
		
		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Venda"/> class.
		/// </summary>
		/// <param name='produto'>
		/// Produto.
		/// </param>
		/// <param name='dtVenda'>
		/// Dt venda.
		/// </param>
		/// <param name='loginUsuario'>
		/// Login usuario.
		/// </param>
		public Venda(Produto produto, DateTime dtVenda, string loginUsuario)
		{
			this.produto = produto;
			this.dtVenda = dtVenda;
			this.loginUsuario = loginUsuario;
		}
		
		#endregion
		
		#region Métodos Público
		
		/// <summary>
		/// Gets or sets the codigo.
		/// </summary>
		/// <value>
		/// The codigo.
		/// </value>
		public virtual int Codigo
		{
			get{return this.codigo;}
			set
			{
				this.isChanged = true;
				this.codigo = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the produto.
		/// </summary>
		/// <value>
		/// The produto.
		/// </value>
		public virtual Produto Produto
		{
			get{return this.produto;}
			set
			{
				this.isChanged = true;
				this.produto = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the data venda.
		/// </summary>
		/// <value>
		/// The data venda.
		/// </value>
		public virtual DateTime DataVenda
		{
			get{return this.dtVenda;}
			set
			{
				this.isChanged = true;
				this.dtVenda = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the usuario.
		/// </summary>
		/// <value>
		/// The usuario.
		/// </value>
		public virtual string Usuario
		{
			get{return this.loginUsuario;}
			set
			{
				this.isChanged = true;
				this.loginUsuario = value;
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
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.Venda"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.Venda"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.Venda"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Usuario)
			{
				if( (obj as Venda).Codigo == this.codigo)
					return true;
			}
			return false;
		}
		
		#endregion
		
		#region HashCode
		
		/// <summary>
		/// Serves as a hash function for a <see cref="TE.Net.Common.Core.Usuario"/> object.
		/// </summary>
		/// <returns>
		/// A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.
		/// </returns>
		public override int GetHashCode ()
		{
			int hash = 7;
  			hash = 31 * hash + this.codigo.GetHashCode();
			
			return hash;
		}
		#endregion
	}
}

