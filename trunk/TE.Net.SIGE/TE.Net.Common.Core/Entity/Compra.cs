using System;

namespace TE.Net.Common.Core
{
	public class Compra
	{
		
		#region Membros Privados
		
		private bool isChanged;
		
		//Chave Primária
		private int codigo;
		
		//Propriedades
		private Produto produto;
		private DateTime dtCompra;
		private int quantidade;
		
		#endregion
		
		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Compra"/> class.
		/// </summary>
		public Compra ()
		{
			this.codigo = 0;
			this.produto = null;
			this.dtCompra = null;
			this,quantidade = 0;
		}
		
		#endregion
		
		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Compra"/> class.
		/// </summary>
		/// <param name='produto'>
		/// Produto.
		/// </param>
		/// <param name='dtCompra'>
		/// Dt compra.
		/// </param>
		/// <param name='quantidade'>
		/// Quantidade.
		/// </param>
		public Compra(Produto produto, DateTime dtCompra, int quantidade)
		{
			this.produto = produto;
			this.dtCompra = dtCompra;
			this.quantidade = quantidade;
		}
		
		#endregion
		
		#region Métodos Públicos
		/// <summary>
		/// Gets or sets the codigo.
		/// </summary>
		/// <value>
		/// The codigo.
		/// </value>
		public virtual int Codigo
		{
			get {return this.codigo;}
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
			get {return this.produto;}
			set
			{
				this.isChanged = true;
				this.produto = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the data compra.
		/// </summary>
		/// <value>
		/// The data compra.
		/// </value>
		public virtual DateTime DataCompra
		{
			get {return this.dtCompra;}
			set
			{
				this.isChanged = true;
				this.dtCompra = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the quantidade.
		/// </summary>
		/// <value>
		/// The quantidade.
		/// </value>
		public virtual int Quantidade
		{
			get {return this.quantidade;}
			set
			{
				this.isChanged = true;
				this.quantidade = value;
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
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.Compra"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.Compra"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.Compra"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Produto)
			{
				if( (obj as Compra).codigo == this.codigo)
					return true;
			}
			return false;
		}
		#endregion
		
		#region HashCode
		
		/// <summary>
		/// Serves as a hash function for a <see cref="TE.Net.Common.Core.Compra"/> object.
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

