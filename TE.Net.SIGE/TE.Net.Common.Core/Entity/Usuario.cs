using System;

namespace TE.Net.Common.Core
{
	public class Usuario
	{
		#region Membros Privados
		
		private bool isChanged;
		
		//Chave Primária
		private int id;
		
		//Propriedades
		private string nome;
		private string loginUsuario;
		private string senha;
		private TipoUsuario tipoUsuario;
		private DateTime dtNascimento;
		private string email;
		
		#endregion

		#region Construtor Padrão
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Usuario"/> class.
		/// </summary>
		public Usuario ()
		{
			this.id = 0;
			this.nome = string.Empty;
			this.loginUsuario = string.Empty;
			this.senha = string.Empty;
			this.tipoUsuario = null;
			this.dtNascimento =null;
			this.email = string.Empty;
		}
		
		#endregion

		#region Construtor Completo
		
		/// <summary>
		/// Initializes a new instance of the <see cref="TE.Net.Common.Core.Usuario"/> class.
		/// </summary>
		/// <param name='nome'>
		/// Nome.
		/// </param>
		/// <param name='login'>
		/// Login.
		/// </param>
		/// <param name='senha'>
		/// Senha.
		/// </param>
		/// <param name='tipoUsuario'>
		/// Tipo usuario.
		/// </param>
		/// <param name='dtNascimento'>
		/// Dt nascimento.
		/// </param>
		/// <param name='email'>
		/// Email.
		/// </param>
		public Usuario(string nome, string login, string senha, TipoUsuario tipoUsuario,DateTime dtNascimento, string email)
		{
			this.nome = nome;
			this.loginUsuario = login;
			this.senha = senha;
			this.tipoUsuario = tipoUsuario;
			this.dtNascimento = dtNascimento;
			this.email = email;
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
		/// Gets or sets the login.
		/// </summary>
		/// <value>
		/// The login.
		/// </value>
		public virtual string Login
		{
			get { return this.loginUsuario;}
			set
			{
				this.isChanged = true;
				this.loginUsuario = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the senha.
		/// </summary>
		/// <value>
		/// The senha.
		/// </value>
		public virtual string Senha
		{
			get {return this.senha;}
			set 
			{
				this.isChanged = true;
				this.senha = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the tipo usuario.
		/// </summary>
		/// <value>
		/// The tipo usuario.
		/// </value>
		public virtual TipoUsuario TipoUsuario
		{
			get {return this.tipoUsuario;}
			set
			{
				this.isChanged = true;
				this.tipoUsuario = value;
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
		
		/// <summary>
		/// Gets or sets the data nascimento.
		/// </summary>
		/// <value>
		/// The data nascimento.
		/// </value>
		public DateTime DataNascimento
		{
			get{return this.dtNascimento;}
			set
			{
				this.isChanged = true;
				this.dtNascimento = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>
		/// The email.
		/// </value>
		public virtual string Email
		{
			get {return this.email;}
			set
			{
				this.isChanged = true;
				this.email = value;
			}
		}
		#endregion
		
		#region Equals
		
		/// <summary>
		/// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="TE.Net.Common.Core.Usuario"/>.
		/// </summary>
		/// <param name='obj'>
		/// The <see cref="System.Object"/> to compare with the current <see cref="TE.Net.Common.Core.Usuario"/>.
		/// </param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="System.Object"/> is equal to the current
		/// <see cref="TE.Net.Common.Core.Usuario"/>; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals (object obj)
		{
			if(obj is Usuario)
			{
				if( (obj as Usuario).Id == this.id)
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
  			hash = 31 * hash + this.id.GetHashCode();
			
			return hash;
		}
		#endregion
		
		
		
	}
}

