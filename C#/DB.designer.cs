﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ExamenFinalProgra")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcliente(cliente instance);
    partial void Updatecliente(cliente instance);
    partial void Deletecliente(cliente instance);
    partial void Insertdevolucione(devolucione instance);
    partial void Updatedevolucione(devolucione instance);
    partial void Deletedevolucione(devolucione instance);
    partial void Insertlibro(libro instance);
    partial void Updatelibro(libro instance);
    partial void Deletelibro(libro instance);
    partial void Insertprestamo(prestamo instance);
    partial void Updateprestamo(prestamo instance);
    partial void Deleteprestamo(prestamo instance);
    #endregion
		
		public DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExamenFinalPrograConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cliente> clientes
		{
			get
			{
				return this.GetTable<cliente>();
			}
		}
		
		public System.Data.Linq.Table<devolucione> devoluciones
		{
			get
			{
				return this.GetTable<devolucione>();
			}
		}
		
		public System.Data.Linq.Table<libro> libros
		{
			get
			{
				return this.GetTable<libro>();
			}
		}
		
		public System.Data.Linq.Table<prestamo> prestamos
		{
			get
			{
				return this.GetTable<prestamo>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListaCliente")]
		public ISingleResult<ListaClienteResult> ListaCliente()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListaClienteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListaDevoluciones")]
		public ISingleResult<ListaDevolucionesResult> ListaDevoluciones()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListaDevolucionesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListaPrestamos")]
		public ISingleResult<ListaPrestamosResult> ListaPrestamos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListaPrestamosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListaLibro")]
		public ISingleResult<ListaLibroResult> ListaLibro()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListaLibroResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cliente")]
	public partial class cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCliente;
		
		private string _nombre;
		
		private string _apellido;
		
		private EntitySet<devolucione> _devoluciones;
		
		private EntitySet<prestamo> _prestamos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidClienteChanging(int value);
    partial void OnidClienteChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    #endregion
		
		public cliente()
		{
			this._devoluciones = new EntitySet<devolucione>(new Action<devolucione>(this.attach_devoluciones), new Action<devolucione>(this.detach_devoluciones));
			this._prestamos = new EntitySet<prestamo>(new Action<prestamo>(this.attach_prestamos), new Action<prestamo>(this.detach_prestamos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					this.OnidClienteChanging(value);
					this.SendPropertyChanging();
					this._idCliente = value;
					this.SendPropertyChanged("idCliente");
					this.OnidClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="VarChar(30)")]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_devolucione", Storage="_devoluciones", ThisKey="idCliente", OtherKey="idCliente")]
		public EntitySet<devolucione> devoluciones
		{
			get
			{
				return this._devoluciones;
			}
			set
			{
				this._devoluciones.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_prestamo", Storage="_prestamos", ThisKey="idCliente", OtherKey="idCliente")]
		public EntitySet<prestamo> prestamos
		{
			get
			{
				return this._prestamos;
			}
			set
			{
				this._prestamos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_devoluciones(devolucione entity)
		{
			this.SendPropertyChanging();
			entity.cliente = this;
		}
		
		private void detach_devoluciones(devolucione entity)
		{
			this.SendPropertyChanging();
			entity.cliente = null;
		}
		
		private void attach_prestamos(prestamo entity)
		{
			this.SendPropertyChanging();
			entity.cliente = this;
		}
		
		private void detach_prestamos(prestamo entity)
		{
			this.SendPropertyChanging();
			entity.cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.devoluciones")]
	public partial class devolucione : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDevolucion;
		
		private string _fecha;
		
		private System.Nullable<int> _idCliente;
		
		private System.Nullable<int> _idlibro;
		
		private EntityRef<cliente> _cliente;
		
		private EntityRef<libro> _libro;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDevolucionChanging(int value);
    partial void OnidDevolucionChanged();
    partial void OnfechaChanging(string value);
    partial void OnfechaChanged();
    partial void OnidClienteChanging(System.Nullable<int> value);
    partial void OnidClienteChanged();
    partial void OnidlibroChanging(System.Nullable<int> value);
    partial void OnidlibroChanged();
    #endregion
		
		public devolucione()
		{
			this._cliente = default(EntityRef<cliente>);
			this._libro = default(EntityRef<libro>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDevolucion", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idDevolucion
		{
			get
			{
				return this._idDevolucion;
			}
			set
			{
				if ((this._idDevolucion != value))
				{
					this.OnidDevolucionChanging(value);
					this.SendPropertyChanging();
					this._idDevolucion = value;
					this.SendPropertyChanged("idDevolucion");
					this.OnidDevolucionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="VarChar(50)")]
		public string fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this.OnfechaChanging(value);
					this.SendPropertyChanging();
					this._fecha = value;
					this.SendPropertyChanged("fecha");
					this.OnfechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int")]
		public System.Nullable<int> idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					if (this._cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClienteChanging(value);
					this.SendPropertyChanging();
					this._idCliente = value;
					this.SendPropertyChanged("idCliente");
					this.OnidClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idlibro", DbType="Int")]
		public System.Nullable<int> idlibro
		{
			get
			{
				return this._idlibro;
			}
			set
			{
				if ((this._idlibro != value))
				{
					if (this._libro.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidlibroChanging(value);
					this.SendPropertyChanging();
					this._idlibro = value;
					this.SendPropertyChanged("idlibro");
					this.OnidlibroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_devolucione", Storage="_cliente", ThisKey="idCliente", OtherKey="idCliente", IsForeignKey=true)]
		public cliente cliente
		{
			get
			{
				return this._cliente.Entity;
			}
			set
			{
				cliente previousValue = this._cliente.Entity;
				if (((previousValue != value) 
							|| (this._cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cliente.Entity = null;
						previousValue.devoluciones.Remove(this);
					}
					this._cliente.Entity = value;
					if ((value != null))
					{
						value.devoluciones.Add(this);
						this._idCliente = value.idCliente;
					}
					else
					{
						this._idCliente = default(Nullable<int>);
					}
					this.SendPropertyChanged("cliente");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="libro_devolucione", Storage="_libro", ThisKey="idlibro", OtherKey="idLibro", IsForeignKey=true)]
		public libro libro
		{
			get
			{
				return this._libro.Entity;
			}
			set
			{
				libro previousValue = this._libro.Entity;
				if (((previousValue != value) 
							|| (this._libro.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._libro.Entity = null;
						previousValue.devoluciones.Remove(this);
					}
					this._libro.Entity = value;
					if ((value != null))
					{
						value.devoluciones.Add(this);
						this._idlibro = value.idLibro;
					}
					else
					{
						this._idlibro = default(Nullable<int>);
					}
					this.SendPropertyChanged("libro");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.libros")]
	public partial class libro : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idLibro;
		
		private string _nombre;
		
		private string _autor;
		
		private string _anno;
		
		private System.Nullable<int> _estado;
		
		private EntitySet<devolucione> _devoluciones;
		
		private EntitySet<prestamo> _prestamos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLibroChanging(int value);
    partial void OnidLibroChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnautorChanging(string value);
    partial void OnautorChanged();
    partial void OnannoChanging(string value);
    partial void OnannoChanged();
    partial void OnestadoChanging(System.Nullable<int> value);
    partial void OnestadoChanged();
    #endregion
		
		public libro()
		{
			this._devoluciones = new EntitySet<devolucione>(new Action<devolucione>(this.attach_devoluciones), new Action<devolucione>(this.detach_devoluciones));
			this._prestamos = new EntitySet<prestamo>(new Action<prestamo>(this.attach_prestamos), new Action<prestamo>(this.detach_prestamos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLibro", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idLibro
		{
			get
			{
				return this._idLibro;
			}
			set
			{
				if ((this._idLibro != value))
				{
					this.OnidLibroChanging(value);
					this.SendPropertyChanging();
					this._idLibro = value;
					this.SendPropertyChanged("idLibro");
					this.OnidLibroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor", DbType="VarChar(30)")]
		public string autor
		{
			get
			{
				return this._autor;
			}
			set
			{
				if ((this._autor != value))
				{
					this.OnautorChanging(value);
					this.SendPropertyChanging();
					this._autor = value;
					this.SendPropertyChanged("autor");
					this.OnautorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anno", DbType="VarChar(30)")]
		public string anno
		{
			get
			{
				return this._anno;
			}
			set
			{
				if ((this._anno != value))
				{
					this.OnannoChanging(value);
					this.SendPropertyChanging();
					this._anno = value;
					this.SendPropertyChanged("anno");
					this.OnannoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int")]
		public System.Nullable<int> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="libro_devolucione", Storage="_devoluciones", ThisKey="idLibro", OtherKey="idlibro")]
		public EntitySet<devolucione> devoluciones
		{
			get
			{
				return this._devoluciones;
			}
			set
			{
				this._devoluciones.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="libro_prestamo", Storage="_prestamos", ThisKey="idLibro", OtherKey="idlibro")]
		public EntitySet<prestamo> prestamos
		{
			get
			{
				return this._prestamos;
			}
			set
			{
				this._prestamos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_devoluciones(devolucione entity)
		{
			this.SendPropertyChanging();
			entity.libro = this;
		}
		
		private void detach_devoluciones(devolucione entity)
		{
			this.SendPropertyChanging();
			entity.libro = null;
		}
		
		private void attach_prestamos(prestamo entity)
		{
			this.SendPropertyChanging();
			entity.libro = this;
		}
		
		private void detach_prestamos(prestamo entity)
		{
			this.SendPropertyChanging();
			entity.libro = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.prestamos")]
	public partial class prestamo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idPrestamo;
		
		private string _fecha;
		
		private System.Nullable<int> _idCliente;
		
		private System.Nullable<int> _idlibro;
		
		private EntityRef<cliente> _cliente;
		
		private EntityRef<libro> _libro;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPrestamoChanging(int value);
    partial void OnidPrestamoChanged();
    partial void OnfechaChanging(string value);
    partial void OnfechaChanged();
    partial void OnidClienteChanging(System.Nullable<int> value);
    partial void OnidClienteChanged();
    partial void OnidlibroChanging(System.Nullable<int> value);
    partial void OnidlibroChanged();
    #endregion
		
		public prestamo()
		{
			this._cliente = default(EntityRef<cliente>);
			this._libro = default(EntityRef<libro>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPrestamo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idPrestamo
		{
			get
			{
				return this._idPrestamo;
			}
			set
			{
				if ((this._idPrestamo != value))
				{
					this.OnidPrestamoChanging(value);
					this.SendPropertyChanging();
					this._idPrestamo = value;
					this.SendPropertyChanged("idPrestamo");
					this.OnidPrestamoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="VarChar(50)")]
		public string fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this.OnfechaChanging(value);
					this.SendPropertyChanging();
					this._fecha = value;
					this.SendPropertyChanged("fecha");
					this.OnfechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int")]
		public System.Nullable<int> idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					if (this._cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClienteChanging(value);
					this.SendPropertyChanging();
					this._idCliente = value;
					this.SendPropertyChanged("idCliente");
					this.OnidClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idlibro", DbType="Int")]
		public System.Nullable<int> idlibro
		{
			get
			{
				return this._idlibro;
			}
			set
			{
				if ((this._idlibro != value))
				{
					if (this._libro.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidlibroChanging(value);
					this.SendPropertyChanging();
					this._idlibro = value;
					this.SendPropertyChanged("idlibro");
					this.OnidlibroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_prestamo", Storage="_cliente", ThisKey="idCliente", OtherKey="idCliente", IsForeignKey=true)]
		public cliente cliente
		{
			get
			{
				return this._cliente.Entity;
			}
			set
			{
				cliente previousValue = this._cliente.Entity;
				if (((previousValue != value) 
							|| (this._cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cliente.Entity = null;
						previousValue.prestamos.Remove(this);
					}
					this._cliente.Entity = value;
					if ((value != null))
					{
						value.prestamos.Add(this);
						this._idCliente = value.idCliente;
					}
					else
					{
						this._idCliente = default(Nullable<int>);
					}
					this.SendPropertyChanged("cliente");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="libro_prestamo", Storage="_libro", ThisKey="idlibro", OtherKey="idLibro", IsForeignKey=true)]
		public libro libro
		{
			get
			{
				return this._libro.Entity;
			}
			set
			{
				libro previousValue = this._libro.Entity;
				if (((previousValue != value) 
							|| (this._libro.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._libro.Entity = null;
						previousValue.prestamos.Remove(this);
					}
					this._libro.Entity = value;
					if ((value != null))
					{
						value.prestamos.Add(this);
						this._idlibro = value.idLibro;
					}
					else
					{
						this._idlibro = default(Nullable<int>);
					}
					this.SendPropertyChanged("libro");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class ListaClienteResult
	{
		
		private int _idCliente;
		
		private string _nombre;
		
		private string _apellido;
		
		public ListaClienteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int NOT NULL")]
		public int idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					this._idCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="VarChar(30)")]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this._apellido = value;
				}
			}
		}
	}
	
	public partial class ListaDevolucionesResult
	{
		
		private int _idDevolucion;
		
		private string _fecha;
		
		private System.Nullable<int> _idCliente;
		
		private System.Nullable<int> _idlibro;
		
		public ListaDevolucionesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDevolucion", DbType="Int NOT NULL")]
		public int idDevolucion
		{
			get
			{
				return this._idDevolucion;
			}
			set
			{
				if ((this._idDevolucion != value))
				{
					this._idDevolucion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="VarChar(50)")]
		public string fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this._fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int")]
		public System.Nullable<int> idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					this._idCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idlibro", DbType="Int")]
		public System.Nullable<int> idlibro
		{
			get
			{
				return this._idlibro;
			}
			set
			{
				if ((this._idlibro != value))
				{
					this._idlibro = value;
				}
			}
		}
	}
	
	public partial class ListaPrestamosResult
	{
		
		private int _idPrestamo;
		
		private string _fecha;
		
		private System.Nullable<int> _idCliente;
		
		private System.Nullable<int> _idlibro;
		
		public ListaPrestamosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPrestamo", DbType="Int NOT NULL")]
		public int idPrestamo
		{
			get
			{
				return this._idPrestamo;
			}
			set
			{
				if ((this._idPrestamo != value))
				{
					this._idPrestamo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="VarChar(50)")]
		public string fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this._fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int")]
		public System.Nullable<int> idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					this._idCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idlibro", DbType="Int")]
		public System.Nullable<int> idlibro
		{
			get
			{
				return this._idlibro;
			}
			set
			{
				if ((this._idlibro != value))
				{
					this._idlibro = value;
				}
			}
		}
	}
	
	public partial class ListaLibroResult
	{
		
		private int _idLibro;
		
		private string _nombre;
		
		private string _autor;
		
		private string _anno;
		
		private System.Nullable<int> _estado;
		
		public ListaLibroResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLibro", DbType="Int NOT NULL")]
		public int idLibro
		{
			get
			{
				return this._idLibro;
			}
			set
			{
				if ((this._idLibro != value))
				{
					this._idLibro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor", DbType="VarChar(30)")]
		public string autor
		{
			get
			{
				return this._autor;
			}
			set
			{
				if ((this._autor != value))
				{
					this._autor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anno", DbType="VarChar(30)")]
		public string anno
		{
			get
			{
				return this._anno;
			}
			set
			{
				if ((this._anno != value))
				{
					this._anno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int")]
		public System.Nullable<int> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this._estado = value;
				}
			}
		}
	}
}
#pragma warning restore 1591