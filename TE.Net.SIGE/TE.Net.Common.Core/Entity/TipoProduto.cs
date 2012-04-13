using System;

namespace TE.Net.Common.Core
{
	public class TipoProduto
	{
		#region Membros Privados
		
		private bool isChanged;
		
		//Chave Primária
		private int id;
		
		private string nome;
		private string descricao;
		
		
		#endregion
		
		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.TipoProduto"/> class.
		/// </summary>
		public TipoProduto ()
		{
			this.id = 0;
			this.nome = string.Empty;
			this.descricao = string.Empty;
		}
		
		#endregion
		
		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.TipoProduto"/> class.
		/// </summary>
		/// <param name='nome'>
		/// Nome.
		/// </param>
		/// <param name='descricao'>
		/// Descricao.
		/// </param>
		public TipoProduto(string nome, string descricao)
		{
			this.nome = nome;
			this.descricao = descricao;
		}
		#endregion
		
		#region Métodos Públicos
		
		/// <summary>
		/// Gets or sets the nome.
		/// </summary>
		/// <value>
		/// The nome.
		/// </value>
		public virtual string Nome
		{
			get {return this.nome;}
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
			get {return this.Descricao;}
			set
			{
				this.isChanged = true;
				this.Descricao = value;
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
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.TipoProduto"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.TipoProduto"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.TipoProduto"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Produto)
			{
				if( (obj as TipoProduto).Id == this.id)
					return true;
			}
			return false;
		}
		#endregion
		
		#region HashCode
		
		/// <summary>
		/// Serves as a hash function for a <see cref="TE.Net.Common.Core.Produto"/> object.
		/// </summary>
		/// <returns>
		/// A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.
		/// </returns>
		public override int GetHashCode ()
		{
			int hash = 7;
  			hash = 31 * hash + this.id.GetHashCode();
			
			return hash;
		}
		
		#endregion