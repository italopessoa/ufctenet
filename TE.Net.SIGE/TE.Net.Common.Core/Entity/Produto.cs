using System;

namespace TE.Net.Common.Core
{
	public class Produto
	{
		
		#region Membros Privados
		
		private bool isChanged;
		
		//Chave Primária
		private int id;
		
		//Propriedades
		private string nome;
		private double valorUnitario;
		private DateTime dataValidade;
		private int quantidade;
		private Fornecedor fornecedor;
		
		#endregion
		
		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Produto"/> class.
		/// </summary>
		public Produto ()
		{
			this.id =0;
			this.nome = string.Empty;
			this.valorUnitario = 0.0;
			this.dataValidade= null;
			this.quantidade = 0;
			this.fornecedor = null;
		}
		
		#endregion
		
		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Produto"/> class.
		/// </summary>
		/// <param name='nome'>
		/// Nome.
		/// </param>
		/// <param name='valor'>
		/// Valor.
		/// </param>
		/// <param name='dataValidade'>
		/// Data validade.
		/// </param>
		/// <param name='quantidade'>
		/// Quantidade.
		/// </param>
		/// <param name='fornecedor'>
		/// Fornecedor.
		/// </param>
		public Produto(string nome, double valor, DateTime dataValidade, int quantidade, Fornecedor fornecedor)
		{
			this.nome = nome;
			this.valorUnitario = valor;
			this.dataValidade= dataValidade;
			this.quantidade = quantidade;
			this.fornecedor = fornecedor;
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
		/// Gets or sets the valor unitario.
		/// </summary>
		/// <value>
		/// The valor unitario.
		/// </value>
		public virtual double ValorUnitario
		{
			get {return this.valorUnitario;}
			set 
			{
				this.isChanged = value;
				this.valorUnitario = valorUnitario;
			}
		}
		
		/// <summary>
		/// Gets or sets the data validade.
		/// </summary>
		/// <value>
		/// The data validade.
		/// </value>
		public DateTime DataValidade
		{
			get {return this.dataValidade;}
			set
			{
				this.isChanged = true;
				this.dataValidade = value;
			}
				
		}
		
		/// <summary>
		/// Gets or sets the quantidade.
		/// </summary>
		/// <value>
		/// The quantidade.
		/// </value>
		private int Quantidade
		{
			get {return this.quantidade;}
			set
			{
				this.isChanged = true;
				this.quantidade = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the fornecedor.
		/// </summary>
		/// <value>
		/// The fornecedor.
		/// </value>
		public Fornecedor Fornecedor
		{
			get {return this.fornecedor;}
			set 
			{
				this.isChanged = true;
				this.fornecedor = value;
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
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.Produto"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.Produto"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.Produto"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Produto)
			{
				if( (obj as Produto).Id == this.id)
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
		
	}
}

