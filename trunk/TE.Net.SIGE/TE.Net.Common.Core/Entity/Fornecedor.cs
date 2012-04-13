using System;

namespace TE.Net.Common.Core
{
	public class Fornecedor
	{
		
		#region Membros Privados
		
		private bool isChanged();
		
		//Chave Primária
		private string cnpj;
		
		//Propriedades
		private string nome;
		private string nomeComercial;
		
		#endregion
		
		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Fornecedor"/> class.
		/// </summary>
		public Fornecedor ()
		{
			this.id = 0;
			this.nome = string.Empty;
			this.nomeComercial = string.Empty;
			this.cnpj = string.Empty;
		}
		
		#endregion
		
		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Fornecedor"/> class.
		/// </summary>
		/// <param name='nome'>
		/// Nome.
		/// </param>
		/// <param name='nomeComercial'>
		/// Nome comercial.
		/// </param>
		/// <param name='cnpj'>
		/// Cnpj.
		/// </param>
		public Fornecedor(string nome, string nomeComercial, string cnpj)
		{
			this.nome = nome;
			this.nomeComercial = nomeComercial;
			this.cnpj = cnpj;
		}
		
		#endregion
		
		#region Métodos Públicos
		
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public virtual int Id
		{
			get {return this.id;}
			set {
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
			get { return this.nome;}
			set
			{
				this.isChanged = true;
				this.nome = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the nome comercial.
		/// </summary>
		/// <value>
		/// The nome comercial.
		/// </value>
		public virtual string NomeComercial
		{
			get {return this.nomeComercial;}
			set
			{
				this.isChanged = true;
				this.nomeComercial = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the CNP.
		/// </summary>
		/// <value>
		/// The CNP.
		/// </value>
		public virtual string CNPJ
		{
			get {return this.cnpj;}
			set
			{
				this.isChanged = true;
				this.cnpj = value;
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
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.Fornecedor"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.Fornecedor"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.Fornecedor"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Fornecedor)
			{
				if( (obj as Fornecedor).Id == this.id)
					return true;
			}
			return false;
		}
		#endregion
		
		#region HashCode
		
		/// <summary>
		/// Serves as a hash function for a <see cref="TE.Net.Common.Core.Fornecedor"/> object.
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
		
		
	}
}

