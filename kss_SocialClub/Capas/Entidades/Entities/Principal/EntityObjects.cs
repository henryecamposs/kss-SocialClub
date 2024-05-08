using kss_SocialClub.Base;
using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;

namespace kss_SocialClub.Entities
{

    [EdmEntityTypeAttribute(Name = "sqlite_sp_functions")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_sp_functions : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String name
		{
			get { return _name; }
			set
			{
				ReportPropertyChanging("name");
				_name = value;
				ReportPropertyChanged("name");
			}
		}
		private String _name;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String text
		{
			get { return _text; }
			set
			{
				ReportPropertyChanging("text");
				_text = value;
				ReportPropertyChanged("text");
			}
		}
		private String _text;


	}

	[EdmEntityTypeAttribute(Name = "sqlite_vs_links_names")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_vs_links_names : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String name
		{
			get { return _name; }
			set
			{
				ReportPropertyChanging("name");
				_name = value;
				ReportPropertyChanged("name");
			}
		}
		private String _name;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String alias
		{
			get { return _alias; }
			set
			{
				ReportPropertyChanging("alias");
				_alias = value;
				ReportPropertyChanged("alias");
			}
		}
		private String _alias;


	}

	[EdmEntityTypeAttribute(Name = "sqlite_vs_properties")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_vs_properties : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parentType
		{
			get { return _parentType; }
			set
			{
				ReportPropertyChanging("parentType");
				_parentType = value;
				ReportPropertyChanged("parentType");
			}
		}
		private String _parentType;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parentName
		{
			get { return _parentName; }
			set
			{
				ReportPropertyChanging("parentName");
				_parentName = value;
				ReportPropertyChanged("parentName");
			}
		}
		private String _parentName;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String propertyName
		{
			get { return _propertyName; }
			set
			{
				ReportPropertyChanging("propertyName");
				_propertyName = value;
				ReportPropertyChanged("propertyName");
			}
		}
		private String _propertyName;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String propertyValue
		{
			get { return _propertyValue; }
			set
			{
				ReportPropertyChanging("propertyValue");
				_propertyValue = value;
				ReportPropertyChanged("propertyValue");
			}
		}
		private String _propertyValue;


	}

	[EdmEntityTypeAttribute(Name = "sqlite_stat1")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_stat1 : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String tbl
		{
			get { return _tbl; }
			set
			{
				ReportPropertyChanging("tbl");
				_tbl = value;
				ReportPropertyChanged("tbl");
			}
		}
		private String _tbl;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String idx
		{
			get { return _idx; }
			set
			{
				ReportPropertyChanging("idx");
				_idx = value;
				ReportPropertyChanged("idx");
			}
		}
		private String _idx;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String stat
		{
			get { return _stat; }
			set
			{
				ReportPropertyChanging("stat");
				_stat = value;
				ReportPropertyChanged("stat");
			}
		}
		private String _stat;


	}

	[EdmEntityTypeAttribute(Name = "sqlite_stat4")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_stat4 : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String tbl
		{
			get { return _tbl; }
			set
			{
				ReportPropertyChanging("tbl");
				_tbl = value;
				ReportPropertyChanged("tbl");
			}
		}
		private String _tbl;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String idx
		{
			get { return _idx; }
			set
			{
				ReportPropertyChanging("idx");
				_idx = value;
				ReportPropertyChanged("idx");
			}
		}
		private String _idx;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String neq
		{
			get { return _neq; }
			set
			{
				ReportPropertyChanging("neq");
				_neq = value;
				ReportPropertyChanged("neq");
			}
		}
		private String _neq;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nlt
		{
			get { return _nlt; }
			set
			{
				ReportPropertyChanging("nlt");
				_nlt = value;
				ReportPropertyChanged("nlt");
			}
		}
		private String _nlt;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ndlt
		{
			get { return _ndlt; }
			set
			{
				ReportPropertyChanging("ndlt");
				_ndlt = value;
				ReportPropertyChanged("ndlt");
			}
		}
		private String _ndlt;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Byte[] sample
		{
			get { return _sample; }
			set
			{
				ReportPropertyChanging("sample");
				_sample = value;
				ReportPropertyChanged("sample");
			}
		}
		private Byte[] _sample;


	}

	[EdmEntityTypeAttribute(Name = "sqlite_sequence")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class sqlite_sequence : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String name
		{
			get { return _name; }
			set
			{
				ReportPropertyChanging("name");
				_name = value;
				ReportPropertyChanged("name");
			}
		}
		private String _name;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? seq
		{
			get { return _seq; }
			set
			{
				ReportPropertyChanging("seq");
				_seq = value;
				ReportPropertyChanged("seq");
			}
		}
		private Int64? _seq;


	}

	[EdmEntityTypeAttribute(Name = "world_paises")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_paises : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id
		{
			get { return _id; }
			set
			{
				ReportPropertyChanging("id");
				_id = value;
				ReportPropertyChanged("id");
			}
		}
		private Int64? _id;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_idioma
		{
			get { return _id_idioma; }
			set
			{
				ReportPropertyChanging("id_idioma");
				_id_idioma = value;
				ReportPropertyChanged("id_idioma");
			}
		}
		private Int64? _id_idioma;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nombre
		{
			get { return _nombre; }
			set
			{
				ReportPropertyChanging("nombre");
				_nombre = value;
				ReportPropertyChanged("nombre");
			}
		}
		private String _nombre;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? x
		{
			get { return _x; }
			set
			{
				ReportPropertyChanging("x");
				_x = value;
				ReportPropertyChanged("x");
			}
		}
		private Double? _x;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? y
		{
			get { return _y; }
			set
			{
				ReportPropertyChanging("y");
				_y = value;
				ReportPropertyChanged("y");
			}
		}
		private Double? _y;


	}

	[EdmEntityTypeAttribute(Name = "world_regiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_regiones : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id
		{
			get { return _id; }
			set
			{
				ReportPropertyChanging("id");
				_id = value;
				ReportPropertyChanged("id");
			}
		}
		private Int64 _id;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_pais
		{
			get { return _id_pais; }
			set
			{
				ReportPropertyChanging("id_pais");
				_id_pais = value;
				ReportPropertyChanged("id_pais");
			}
		}
		private Int64 _id_pais;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_idioma
		{
			get { return _id_idioma; }
			set
			{
				ReportPropertyChanging("id_idioma");
				_id_idioma = value;
				ReportPropertyChanged("id_idioma");
			}
		}
		private Int64 _id_idioma;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String nombre
		{
			get { return _nombre; }
			set
			{
				ReportPropertyChanging("nombre");
				_nombre = value;
				ReportPropertyChanged("nombre");
			}
		}
		private String _nombre;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double x
		{
			get { return _x; }
			set
			{
				ReportPropertyChanging("x");
				_x = value;
				ReportPropertyChanged("x");
			}
		}
		private Double _x;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double y
		{
			get { return _y; }
			set
			{
				ReportPropertyChanging("y");
				_y = value;
				ReportPropertyChanged("y");
			}
		}
		private Double _y;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 exacto
		{
			get { return _exacto; }
			set
			{
				ReportPropertyChanging("exacto");
				_exacto = value;
				ReportPropertyChanged("exacto");
			}
		}
		private Int64 _exacto;


	}

	[EdmEntityTypeAttribute(Name = "Clientes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Apellidos
		{
			get { return _Apellidos; }
			set
			{
				ReportPropertyChanging("Apellidos");
				_Apellidos = value;
				ReportPropertyChanged("Apellidos");
			}
		}
		private String _Apellidos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CI
		{
			get { return _CI; }
			set
			{
				ReportPropertyChanging("CI");
				_CI = value;
				ReportPropertyChanged("CI");
			}
		}
		private String _CI;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? codigoPostal
		{
			get { return _codigoPostal; }
			set
			{
				ReportPropertyChanging("codigoPostal");
				_codigoPostal = value;
				ReportPropertyChanged("codigoPostal");
			}
		}
		private Int64? _codigoPostal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String direccion
		{
			get { return _direccion; }
			set
			{
				ReportPropertyChanging("direccion");
				_direccion = value;
				ReportPropertyChanged("direccion");
			}
		}
		private String _direccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String email
		{
			get { return _email; }
			set
			{
				ReportPropertyChanging("email");
				_email = value;
				ReportPropertyChanged("email");
			}
		}
		private String _email;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEmpresa
		{
			get { return _esEmpresa; }
			set
			{
				ReportPropertyChanging("esEmpresa");
				_esEmpresa = value;
				ReportPropertyChanged("esEmpresa");
			}
		}
		private Boolean? _esEmpresa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ciudad
		{
			get { return _id_ciudad; }
			set
			{
				ReportPropertyChanging("id_ciudad");
				_id_ciudad = value;
				ReportPropertyChanged("id_ciudad");
			}
		}
		private Int64? _id_ciudad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_estado
		{
			get { return _id_estado; }
			set
			{
				ReportPropertyChanging("id_estado");
				_id_estado = value;
				ReportPropertyChanged("id_estado");
			}
		}
		private Int64? _id_estado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_municipio
		{
			get { return _id_municipio; }
			set
			{
				ReportPropertyChanging("id_municipio");
				_id_municipio = value;
				ReportPropertyChanged("id_municipio");
			}
		}
		private Int64? _id_municipio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_nacionalidad
		{
			get { return _id_nacionalidad; }
			set
			{
				ReportPropertyChanging("id_nacionalidad");
				_id_nacionalidad = value;
				ReportPropertyChanged("id_nacionalidad");
			}
		}
		private Int64? _id_nacionalidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_parroquia
		{
			get { return _id_parroquia; }
			set
			{
				ReportPropertyChanging("id_parroquia");
				_id_parroquia = value;
				ReportPropertyChanged("id_parroquia");
			}
		}
		private Int64? _id_parroquia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_profesion
		{
			get { return _id_profesion; }
			set
			{
				ReportPropertyChanging("id_profesion");
				_id_profesion = value;
				ReportPropertyChanged("id_profesion");
			}
		}
		private Int64? _id_profesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_tipoPago
		{
			get { return _id_tipoPago; }
			set
			{
				ReportPropertyChanging("id_tipoPago");
				_id_tipoPago = value;
				ReportPropertyChanged("id_tipoPago");
			}
		}
		private Int64? _id_tipoPago;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Nombres
		{
			get { return _Nombres; }
			set
			{
				ReportPropertyChanging("Nombres");
				_Nombres = value;
				ReportPropertyChanged("Nombres");
			}
		}
		private String _Nombres;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Pasaporte
		{
			get { return _Pasaporte; }
			set
			{
				ReportPropertyChanging("Pasaporte");
				_Pasaporte = value;
				ReportPropertyChanged("Pasaporte");
			}
		}
		private String _Pasaporte;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefono
		{
			get { return _telefono; }
			set
			{
				ReportPropertyChanging("telefono");
				_telefono = value;
				ReportPropertyChanged("telefono");
			}
		}
		private String _telefono;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefono_movil
		{
			get { return _telefono_movil; }
			set
			{
				ReportPropertyChanging("telefono_movil");
				_telefono_movil = value;
				ReportPropertyChanged("telefono_movil");
			}
		}
		private String _telefono_movil;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Sexo
		{
			get { return _Sexo; }
			set
			{
				ReportPropertyChanging("Sexo");
				_Sexo = value;
				ReportPropertyChanged("Sexo");
			}
		}
		private String _Sexo;


	}

	[EdmEntityTypeAttribute(Name = "Empleados")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empleados : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Apellidos
		{
			get { return _Apellidos; }
			set
			{
				ReportPropertyChanging("Apellidos");
				_Apellidos = value;
				ReportPropertyChanged("Apellidos");
			}
		}
		private String _Apellidos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CI
		{
			get { return _CI; }
			set
			{
				ReportPropertyChanging("CI");
				_CI = value;
				ReportPropertyChanged("CI");
			}
		}
		private String _CI;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? codigoPostal
		{
			get { return _codigoPostal; }
			set
			{
				ReportPropertyChanging("codigoPostal");
				_codigoPostal = value;
				ReportPropertyChanged("codigoPostal");
			}
		}
		private Int64? _codigoPostal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String direccion
		{
			get { return _direccion; }
			set
			{
				ReportPropertyChanging("direccion");
				_direccion = value;
				ReportPropertyChanged("direccion");
			}
		}
		private String _direccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String email
		{
			get { return _email; }
			set
			{
				ReportPropertyChanging("email");
				_email = value;
				ReportPropertyChanged("email");
			}
		}
		private String _email;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ciudad
		{
			get { return _id_ciudad; }
			set
			{
				ReportPropertyChanging("id_ciudad");
				_id_ciudad = value;
				ReportPropertyChanged("id_ciudad");
			}
		}
		private Int64? _id_ciudad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_estado
		{
			get { return _id_estado; }
			set
			{
				ReportPropertyChanging("id_estado");
				_id_estado = value;
				ReportPropertyChanged("id_estado");
			}
		}
		private Int64? _id_estado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_municipio
		{
			get { return _id_municipio; }
			set
			{
				ReportPropertyChanging("id_municipio");
				_id_municipio = value;
				ReportPropertyChanged("id_municipio");
			}
		}
		private Int64? _id_municipio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_nacionalidad
		{
			get { return _id_nacionalidad; }
			set
			{
				ReportPropertyChanging("id_nacionalidad");
				_id_nacionalidad = value;
				ReportPropertyChanged("id_nacionalidad");
			}
		}
		private Int64 _id_nacionalidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_parroquia
		{
			get { return _id_parroquia; }
			set
			{
				ReportPropertyChanging("id_parroquia");
				_id_parroquia = value;
				ReportPropertyChanged("id_parroquia");
			}
		}
		private Int64? _id_parroquia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_profesion
		{
			get { return _id_profesion; }
			set
			{
				ReportPropertyChanging("id_profesion");
				_id_profesion = value;
				ReportPropertyChanged("id_profesion");
			}
		}
		private Int64? _id_profesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Nombres
		{
			get { return _Nombres; }
			set
			{
				ReportPropertyChanging("Nombres");
				_Nombres = value;
				ReportPropertyChanged("Nombres");
			}
		}
		private String _Nombres;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String rif
		{
			get { return _rif; }
			set
			{
				ReportPropertyChanging("rif");
				_rif = value;
				ReportPropertyChanged("rif");
			}
		}
		private String _rif;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String telefono
		{
			get { return _telefono; }
			set
			{
				ReportPropertyChanging("telefono");
				_telefono = value;
				ReportPropertyChanged("telefono");
			}
		}
		private String _telefono;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefono_movil
		{
			get { return _telefono_movil; }
			set
			{
				ReportPropertyChanging("telefono_movil");
				_telefono_movil = value;
				ReportPropertyChanged("telefono_movil");
			}
		}
		private String _telefono_movil;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String field
		{
			get { return _field; }
			set
			{
				ReportPropertyChanging("field");
				_field = value;
				ReportPropertyChanged("field");
			}
		}
		private String _field;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Ocupacion
		{
			get { return _Ocupacion; }
			set
			{
				ReportPropertyChanging("Ocupacion");
				_Ocupacion = value;
				ReportPropertyChanged("Ocupacion");
			}
		}
		private String _Ocupacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nota
		{
			get { return _Nota; }
			set
			{
				ReportPropertyChanging("Nota");
				_Nota = value;
				ReportPropertyChanged("Nota");
			}
		}
		private String _Nota;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Foto_Archivo
		{
			get { return _Foto_Archivo; }
			set
			{
				ReportPropertyChanging("Foto_Archivo");
				_Foto_Archivo = value;
				ReportPropertyChanged("Foto_Archivo");
			}
		}
		private String _Foto_Archivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_Ingreso
		{
			get { return _Fecha_Ingreso; }
			set
			{
				ReportPropertyChanging("Fecha_Ingreso");
				_Fecha_Ingreso = value;
				ReportPropertyChanged("Fecha_Ingreso");
			}
		}
		private DateTime? _Fecha_Ingreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_Egreso
		{
			get { return _Fecha_Egreso; }
			set
			{
				ReportPropertyChanging("Fecha_Egreso");
				_Fecha_Egreso = value;
				ReportPropertyChanged("Fecha_Egreso");
			}
		}
		private DateTime? _Fecha_Egreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? idDefCargo
		{
			get { return _idDefCargo; }
			set
			{
				ReportPropertyChanging("idDefCargo");
				_idDefCargo = value;
				ReportPropertyChanged("idDefCargo");
			}
		}
		private Int64? _idDefCargo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoSueldoIngreso
		{
			get { return _MontoSueldoIngreso; }
			set
			{
				ReportPropertyChanging("MontoSueldoIngreso");
				_MontoSueldoIngreso = value;
				ReportPropertyChanged("MontoSueldoIngreso");
			}
		}
		private Double? _MontoSueldoIngreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? idDefTipoContrato
		{
			get { return _idDefTipoContrato; }
			set
			{
				ReportPropertyChanging("idDefTipoContrato");
				_idDefTipoContrato = value;
				ReportPropertyChanged("idDefTipoContrato");
			}
		}
		private Int64? _idDefTipoContrato;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoSueldoActual
		{
			get { return _MontoSueldoActual; }
			set
			{
				ReportPropertyChanging("MontoSueldoActual");
				_MontoSueldoActual = value;
				ReportPropertyChanged("MontoSueldoActual");
			}
		}
		private Double? _MontoSueldoActual;


	}

	[EdmEntityTypeAttribute(Name = "Cajas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CantidadUnidadVentaPred
		{
			get { return _CantidadUnidadVentaPred; }
			set
			{
				ReportPropertyChanging("CantidadUnidadVentaPred");
				_CantidadUnidadVentaPred = value;
				ReportPropertyChanged("CantidadUnidadVentaPred");
			}
		}
		private Double _CantidadUnidadVentaPred;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAbierta
		{
			get { return _esAbierta; }
			set
			{
				ReportPropertyChanging("esAbierta");
				_esAbierta = value;
				ReportPropertyChanged("esAbierta");
			}
		}
		private Boolean? _esAbierta;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAgruparItemsIdenticos
		{
			get { return _esAgruparItemsIdenticos; }
			set
			{
				ReportPropertyChanging("esAgruparItemsIdenticos");
				_esAgruparItemsIdenticos = value;
				ReportPropertyChanged("esAgruparItemsIdenticos");
			}
		}
		private Boolean? _esAgruparItemsIdenticos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esNroFactura_Person
		{
			get { return _esNroFactura_Person; }
			set
			{
				ReportPropertyChanging("esNroFactura_Person");
				_esNroFactura_Person = value;
				ReportPropertyChanged("esNroFactura_Person");
			}
		}
		private Boolean _esNroFactura_Person;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esRemoto
		{
			get { return _esRemoto; }
			set
			{
				ReportPropertyChanging("esRemoto");
				_esRemoto = value;
				ReportPropertyChanged("esRemoto");
			}
		}
		private Boolean? _esRemoto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaAnterior
		{
			get { return _FechaAnterior; }
			set
			{
				ReportPropertyChanging("FechaAnterior");
				_FechaAnterior = value;
				ReportPropertyChanged("FechaAnterior");
			}
		}
		private DateTime? _FechaAnterior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaApertura
		{
			get { return _FechaApertura; }
			set
			{
				ReportPropertyChanging("FechaApertura");
				_FechaApertura = value;
				ReportPropertyChanged("FechaApertura");
			}
		}
		private DateTime? _FechaApertura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_ClientePredet
		{
			get { return _Id_ClientePredet; }
			set
			{
				ReportPropertyChanging("Id_ClientePredet");
				_Id_ClientePredet = value;
				ReportPropertyChanged("Id_ClientePredet");
			}
		}
		private Int64 _Id_ClientePredet;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estacion
		{
			get { return _id_Estacion; }
			set
			{
				ReportPropertyChanging("id_Estacion");
				_id_Estacion = value;
				ReportPropertyChanged("id_Estacion");
			}
		}
		private Int64? _id_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_FormaPagoPredet
		{
			get { return _Id_FormaPagoPredet; }
			set
			{
				ReportPropertyChanging("Id_FormaPagoPredet");
				_Id_FormaPagoPredet = value;
				ReportPropertyChanged("Id_FormaPagoPredet");
			}
		}
		private Int64 _Id_FormaPagoPredet;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoApertura
		{
			get { return _MontoApertura; }
			set
			{
				ReportPropertyChanging("MontoApertura");
				_MontoApertura = value;
				ReportPropertyChanged("MontoApertura");
			}
		}
		private Double? _MontoApertura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nombre
		{
			get { return _Nombre; }
			set
			{
				ReportPropertyChanging("Nombre");
				_Nombre = value;
				ReportPropertyChanged("Nombre");
			}
		}
		private String _Nombre;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? NroFacturaAnteior_IF
		{
			get { return _NroFacturaAnteior_IF; }
			set
			{
				ReportPropertyChanging("NroFacturaAnteior_IF");
				_NroFacturaAnteior_IF = value;
				ReportPropertyChanged("NroFacturaAnteior_IF");
			}
		}
		private Int64? _NroFacturaAnteior_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 NroFacturaAnterior
		{
			get { return _NroFacturaAnterior; }
			set
			{
				ReportPropertyChanging("NroFacturaAnterior");
				_NroFacturaAnterior = value;
				ReportPropertyChanged("NroFacturaAnterior");
			}
		}
		private Int64 _NroFacturaAnterior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Serial_IF
		{
			get { return _Serial_IF; }
			set
			{
				ReportPropertyChanging("Serial_IF");
				_Serial_IF = value;
				ReportPropertyChanged("Serial_IF");
			}
		}
		private String _Serial_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 TipoPrecioPredet
		{
			get { return _TipoPrecioPredet; }
			set
			{
				ReportPropertyChanging("TipoPrecioPredet");
				_TipoPrecioPredet = value;
				ReportPropertyChanged("TipoPrecioPredet");
			}
		}
		private Int64 _TipoPrecioPredet;


	}

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaApertura
		{
			get { return _FechaApertura; }
			set
			{
				ReportPropertyChanging("FechaApertura");
				_FechaApertura = value;
				ReportPropertyChanged("FechaApertura");
			}
		}
		private DateTime _FechaApertura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaCierre
		{
			get { return _FechaCierre; }
			set
			{
				ReportPropertyChanging("FechaCierre");
				_FechaCierre = value;
				ReportPropertyChanged("FechaCierre");
			}
		}
		private DateTime _FechaCierre;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_EstacionSesion
		{
			get { return _id_EstacionSesion; }
			set
			{
				ReportPropertyChanging("id_EstacionSesion");
				_id_EstacionSesion = value;
				ReportPropertyChanged("id_EstacionSesion");
			}
		}
		private Int64 _id_EstacionSesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_FacturaFinal
		{
			get { return _id_FacturaFinal; }
			set
			{
				ReportPropertyChanging("id_FacturaFinal");
				_id_FacturaFinal = value;
				ReportPropertyChanged("id_FacturaFinal");
			}
		}
		private Int64 _id_FacturaFinal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_FacturaInicial
		{
			get { return _id_FacturaInicial; }
			set
			{
				ReportPropertyChanging("id_FacturaInicial");
				_id_FacturaInicial = value;
				ReportPropertyChanged("id_FacturaInicial");
			}
		}
		private Int64 _id_FacturaInicial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoApetura
		{
			get { return _MontoApetura; }
			set
			{
				ReportPropertyChanging("MontoApetura");
				_MontoApetura = value;
				ReportPropertyChanged("MontoApetura");
			}
		}
		private Double _MontoApetura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoCuadreCaja
		{
			get { return _MontoCuadreCaja; }
			set
			{
				ReportPropertyChanging("MontoCuadreCaja");
				_MontoCuadreCaja = value;
				ReportPropertyChanged("MontoCuadreCaja");
			}
		}
		private Double _MontoCuadreCaja;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroCorte
		{
			get { return _nroCorte; }
			set
			{
				ReportPropertyChanging("nroCorte");
				_nroCorte = value;
				ReportPropertyChanged("nroCorte");
			}
		}
		private Int64 _nroCorte;


	}

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes_DetalleEgreso")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes_DetalleEgreso : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Cajas_Cortes
		{
			get { return _id_Cajas_Cortes; }
			set
			{
				ReportPropertyChanging("id_Cajas_Cortes");
				_id_Cajas_Cortes = value;
				ReportPropertyChanged("id_Cajas_Cortes");
			}
		}
		private Int64 _id_Cajas_Cortes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Tipoegreso
		{
			get { return _id_Tipoegreso; }
			set
			{
				ReportPropertyChanging("id_Tipoegreso");
				_id_Tipoegreso = value;
				ReportPropertyChanged("id_Tipoegreso");
			}
		}
		private Int64 _id_Tipoegreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoTotal
		{
			get { return _MontoTotal; }
			set
			{
				ReportPropertyChanging("MontoTotal");
				_MontoTotal = value;
				ReportPropertyChanged("MontoTotal");
			}
		}
		private Double _MontoTotal;


	}

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes_DetalleIngreso")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes_DetalleIngreso : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Cajas_Cortes
		{
			get { return _id_Cajas_Cortes; }
			set
			{
				ReportPropertyChanging("id_Cajas_Cortes");
				_id_Cajas_Cortes = value;
				ReportPropertyChanged("id_Cajas_Cortes");
			}
		}
		private Int64 _id_Cajas_Cortes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_TipoDocPago
		{
			get { return _id_TipoDocPago; }
			set
			{
				ReportPropertyChanging("id_TipoDocPago");
				_id_TipoDocPago = value;
				ReportPropertyChanged("id_TipoDocPago");
			}
		}
		private Int64 _id_TipoDocPago;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoTotal
		{
			get { return _MontoTotal; }
			set
			{
				ReportPropertyChanging("MontoTotal");
				_MontoTotal = value;
				ReportPropertyChanged("MontoTotal");
			}
		}
		private Double _MontoTotal;


	}

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes_IF")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes_IF : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaFinal_IF
		{
			get { return _FechaFinal_IF; }
			set
			{
				ReportPropertyChanging("FechaFinal_IF");
				_FechaFinal_IF = value;
				ReportPropertyChanged("FechaFinal_IF");
			}
		}
		private DateTime? _FechaFinal_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaInicial_IF
		{
			get { return _FechaInicial_IF; }
			set
			{
				ReportPropertyChanging("FechaInicial_IF");
				_FechaInicial_IF = value;
				ReportPropertyChanged("FechaInicial_IF");
			}
		}
		private DateTime? _FechaInicial_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Cajas_Cortes
		{
			get { return _id_Cajas_Cortes; }
			set
			{
				ReportPropertyChanging("id_Cajas_Cortes");
				_id_Cajas_Cortes = value;
				ReportPropertyChanged("id_Cajas_Cortes");
			}
		}
		private Int64 _id_Cajas_Cortes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoTotal1
		{
			get { return _MontoTotal1; }
			set
			{
				ReportPropertyChanging("MontoTotal1");
				_MontoTotal1 = value;
				ReportPropertyChanged("MontoTotal1");
			}
		}
		private Double _MontoTotal1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoTotal2
		{
			get { return _MontoTotal2; }
			set
			{
				ReportPropertyChanging("MontoTotal2");
				_MontoTotal2 = value;
				ReportPropertyChanged("MontoTotal2");
			}
		}
		private Double? _MontoTotal2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoTotal3
		{
			get { return _MontoTotal3; }
			set
			{
				ReportPropertyChanging("MontoTotal3");
				_MontoTotal3 = value;
				ReportPropertyChanged("MontoTotal3");
			}
		}
		private Double? _MontoTotal3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroCorteZ_IF
		{
			get { return _nroCorteZ_IF; }
			set
			{
				ReportPropertyChanging("nroCorteZ_IF");
				_nroCorteZ_IF = value;
				ReportPropertyChanged("nroCorteZ_IF");
			}
		}
		private Int64 _nroCorteZ_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nrofacturaFinal_IF
		{
			get { return _nrofacturaFinal_IF; }
			set
			{
				ReportPropertyChanging("nrofacturaFinal_IF");
				_nrofacturaFinal_IF = value;
				ReportPropertyChanged("nrofacturaFinal_IF");
			}
		}
		private Int64 _nrofacturaFinal_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroFacturaInicial_IF
		{
			get { return _nroFacturaInicial_IF; }
			set
			{
				ReportPropertyChanging("nroFacturaInicial_IF");
				_nroFacturaInicial_IF = value;
				ReportPropertyChanged("nroFacturaInicial_IF");
			}
		}
		private Int64 _nroFacturaInicial_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String nroSerial_IF
		{
			get { return _nroSerial_IF; }
			set
			{
				ReportPropertyChanging("nroSerial_IF");
				_nroSerial_IF = value;
				ReportPropertyChanged("nroSerial_IF");
			}
		}
		private String _nroSerial_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String RIF_IF
		{
			get { return _RIF_IF; }
			set
			{
				ReportPropertyChanging("RIF_IF");
				_RIF_IF = value;
				ReportPropertyChanged("RIF_IF");
			}
		}
		private String _RIF_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TasaIva1
		{
			get { return _TasaIva1; }
			set
			{
				ReportPropertyChanging("TasaIva1");
				_TasaIva1 = value;
				ReportPropertyChanged("TasaIva1");
			}
		}
		private Double _TasaIva1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? TasaIva2
		{
			get { return _TasaIva2; }
			set
			{
				ReportPropertyChanging("TasaIva2");
				_TasaIva2 = value;
				ReportPropertyChanged("TasaIva2");
			}
		}
		private Double? _TasaIva2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? TasaIva3
		{
			get { return _TasaIva3; }
			set
			{
				ReportPropertyChanging("TasaIva3");
				_TasaIva3 = value;
				ReportPropertyChanged("TasaIva3");
			}
		}
		private Double? _TasaIva3;


	}

	[EdmEntityTypeAttribute(Name = "Cajas_Egresos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Egresos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaActural
		{
			get { return _FechaActural; }
			set
			{
				ReportPropertyChanging("FechaActural");
				_FechaActural = value;
				ReportPropertyChanged("FechaActural");
			}
		}
		private DateTime? _FechaActural;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaRecibo
		{
			get { return _FechaRecibo; }
			set
			{
				ReportPropertyChanging("FechaRecibo");
				_FechaRecibo = value;
				ReportPropertyChanged("FechaRecibo");
			}
		}
		private DateTime? _FechaRecibo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_Asociado
		{
			get { return _ID_Asociado; }
			set
			{
				ReportPropertyChanging("ID_Asociado");
				_ID_Asociado = value;
				ReportPropertyChanged("ID_Asociado");
			}
		}
		private Int64? _ID_Asociado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_CorteZ
		{
			get { return _id_CorteZ; }
			set
			{
				ReportPropertyChanging("id_CorteZ");
				_id_CorteZ = value;
				ReportPropertyChanged("id_CorteZ");
			}
		}
		private Int64? _id_CorteZ;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Estaciones_Sesion
		{
			get { return _id_Estaciones_Sesion; }
			set
			{
				ReportPropertyChanging("id_Estaciones_Sesion");
				_id_Estaciones_Sesion = value;
				ReportPropertyChanged("id_Estaciones_Sesion");
			}
		}
		private Int64 _id_Estaciones_Sesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_TipoEgreso
		{
			get { return _id_TipoEgreso; }
			set
			{
				ReportPropertyChanging("id_TipoEgreso");
				_id_TipoEgreso = value;
				ReportPropertyChanged("id_TipoEgreso");
			}
		}
		private Int64 _id_TipoEgreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoTotal
		{
			get { return _MontoTotal; }
			set
			{
				ReportPropertyChanging("MontoTotal");
				_MontoTotal = value;
				ReportPropertyChanged("MontoTotal");
			}
		}
		private Double? _MontoTotal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreAsociado
		{
			get { return _NombreAsociado; }
			set
			{
				ReportPropertyChanging("NombreAsociado");
				_NombreAsociado = value;
				ReportPropertyChanged("NombreAsociado");
			}
		}
		private String _NombreAsociado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreEntrega
		{
			get { return _NombreEntrega; }
			set
			{
				ReportPropertyChanging("NombreEntrega");
				_NombreEntrega = value;
				ReportPropertyChanged("NombreEntrega");
			}
		}
		private String _NombreEntrega;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreRecibe
		{
			get { return _NombreRecibe; }
			set
			{
				ReportPropertyChanging("NombreRecibe");
				_NombreRecibe = value;
				ReportPropertyChanged("NombreRecibe");
			}
		}
		private String _NombreRecibe;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroDocAsociado
		{
			get { return _nroDocAsociado; }
			set
			{
				ReportPropertyChanging("nroDocAsociado");
				_nroDocAsociado = value;
				ReportPropertyChanged("nroDocAsociado");
			}
		}
		private String _nroDocAsociado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroReciboEgreso
		{
			get { return _nroReciboEgreso; }
			set
			{
				ReportPropertyChanging("nroReciboEgreso");
				_nroReciboEgreso = value;
				ReportPropertyChanged("nroReciboEgreso");
			}
		}
		private Int64 _nroReciboEgreso;


	}

	[EdmEntityTypeAttribute(Name = "Empresa")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empresa : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? codigoPostal
		{
			get { return _codigoPostal; }
			set
			{
				ReportPropertyChanging("codigoPostal");
				_codigoPostal = value;
				ReportPropertyChanged("codigoPostal");
			}
		}
		private Int64? _codigoPostal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Contacto
		{
			get { return _Contacto; }
			set
			{
				ReportPropertyChanging("Contacto");
				_Contacto = value;
				ReportPropertyChanged("Contacto");
			}
		}
		private String _Contacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String direccion
		{
			get { return _direccion; }
			set
			{
				ReportPropertyChanging("direccion");
				_direccion = value;
				ReportPropertyChanged("direccion");
			}
		}
		private String _direccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String empresa
		{
			get { return _empresa; }
			set
			{
				ReportPropertyChanging("empresa");
				_empresa = value;
				ReportPropertyChanged("empresa");
			}
		}
		private String _empresa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Ciudad
		{
			get { return _Id_Ciudad; }
			set
			{
				ReportPropertyChanging("Id_Ciudad");
				_Id_Ciudad = value;
				ReportPropertyChanged("Id_Ciudad");
			}
		}
		private Int64? _Id_Ciudad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Estado
		{
			get { return _id_Estado; }
			set
			{
				ReportPropertyChanging("id_Estado");
				_id_Estado = value;
				ReportPropertyChanged("id_Estado");
			}
		}
		private Int64 _id_Estado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_idioma
		{
			get { return _id_idioma; }
			set
			{
				ReportPropertyChanging("id_idioma");
				_id_idioma = value;
				ReportPropertyChanged("id_idioma");
			}
		}
		private Int64? _id_idioma;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Municipio
		{
			get { return _id_Municipio; }
			set
			{
				ReportPropertyChanging("id_Municipio");
				_id_Municipio = value;
				ReportPropertyChanged("id_Municipio");
			}
		}
		private Int64? _id_Municipio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Pais
		{
			get { return _id_Pais; }
			set
			{
				ReportPropertyChanging("id_Pais");
				_id_Pais = value;
				ReportPropertyChanged("id_Pais");
			}
		}
		private Int64? _id_Pais;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Parroquia
		{
			get { return _Id_Parroquia; }
			set
			{
				ReportPropertyChanging("Id_Parroquia");
				_Id_Parroquia = value;
				ReportPropertyChanged("Id_Parroquia");
			}
		}
		private Int64? _Id_Parroquia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_tipoComercio
		{
			get { return _ID_tipoComercio; }
			set
			{
				ReportPropertyChanging("ID_tipoComercio");
				_ID_tipoComercio = value;
				ReportPropertyChanged("ID_tipoComercio");
			}
		}
		private Int64 _ID_tipoComercio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImagenArchivo
		{
			get { return _ImagenArchivo; }
			set
			{
				ReportPropertyChanging("ImagenArchivo");
				_ImagenArchivo = value;
				ReportPropertyChanged("ImagenArchivo");
			}
		}
		private String _ImagenArchivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nit
		{
			get { return _nit; }
			set
			{
				ReportPropertyChanging("nit");
				_nit = value;
				ReportPropertyChanged("nit");
			}
		}
		private String _nit;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String rif
		{
			get { return _rif; }
			set
			{
				ReportPropertyChanging("rif");
				_rif = value;
				ReportPropertyChanged("rif");
			}
		}
		private String _rif;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefonos
		{
			get { return _telefonos; }
			set
			{
				ReportPropertyChanging("telefonos");
				_telefonos = value;
				ReportPropertyChanged("telefonos");
			}
		}
		private String _telefonos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefonosContacto
		{
			get { return _telefonosContacto; }
			set
			{
				ReportPropertyChanging("telefonosContacto");
				_telefonosContacto = value;
				ReportPropertyChanged("telefonosContacto");
			}
		}
		private String _telefonosContacto;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCliente_SolicitarEmail
		{
			get { return _esCliente_SolicitarEmail; }
			set
			{
				ReportPropertyChanging("esCliente_SolicitarEmail");
				_esCliente_SolicitarEmail = value;
				ReportPropertyChanged("esCliente_SolicitarEmail");
			}
		}
		private Boolean? _esCliente_SolicitarEmail;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCliente_SolicitarRIF
		{
			get { return _esCliente_SolicitarRIF; }
			set
			{
				ReportPropertyChanging("esCliente_SolicitarRIF");
				_esCliente_SolicitarRIF = value;
				ReportPropertyChanged("esCliente_SolicitarRIF");
			}
		}
		private Boolean? _esCliente_SolicitarRIF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCliente_SolicitarTelefono
		{
			get { return _esCliente_SolicitarTelefono; }
			set
			{
				ReportPropertyChanging("esCliente_SolicitarTelefono");
				_esCliente_SolicitarTelefono = value;
				ReportPropertyChanged("esCliente_SolicitarTelefono");
			}
		}
		private Boolean? _esCliente_SolicitarTelefono;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esimprimirEgreso
		{
			get { return _esimprimirEgreso; }
			set
			{
				ReportPropertyChanging("esimprimirEgreso");
				_esimprimirEgreso = value;
				ReportPropertyChanged("esimprimirEgreso");
			}
		}
		private Boolean _esimprimirEgreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esImprimirFiscal
		{
			get { return _esImprimirFiscal; }
			set
			{
				ReportPropertyChanging("esImprimirFiscal");
				_esImprimirFiscal = value;
				ReportPropertyChanged("esImprimirFiscal");
			}
		}
		private Boolean _esImprimirFiscal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esImprimirNConsumo
		{
			get { return _esImprimirNConsumo; }
			set
			{
				ReportPropertyChanging("esImprimirNConsumo");
				_esImprimirNConsumo = value;
				ReportPropertyChanged("esImprimirNConsumo");
			}
		}
		private Boolean _esImprimirNConsumo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esOffline
		{
			get { return _esOffline; }
			set
			{
				ReportPropertyChanging("esOffline");
				_esOffline = value;
				ReportPropertyChanged("esOffline");
			}
		}
		private Boolean _esOffline;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPedirCantidadPredet
		{
			get { return _esPedirCantidadPredet; }
			set
			{
				ReportPropertyChanging("esPedirCantidadPredet");
				_esPedirCantidadPredet = value;
				ReportPropertyChanged("esPedirCantidadPredet");
			}
		}
		private Boolean _esPedirCantidadPredet;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPoseeCaptaHuella
		{
			get { return _esPoseeCaptaHuella; }
			set
			{
				ReportPropertyChanging("esPoseeCaptaHuella");
				_esPoseeCaptaHuella = value;
				ReportPropertyChanged("esPoseeCaptaHuella");
			}
		}
		private Boolean? _esPoseeCaptaHuella;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPoseeGaveta
		{
			get { return _esPoseeGaveta; }
			set
			{
				ReportPropertyChanging("esPoseeGaveta");
				_esPoseeGaveta = value;
				ReportPropertyChanged("esPoseeGaveta");
			}
		}
		private Boolean? _esPoseeGaveta;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPoseeLectorPOSBanca
		{
			get { return _esPoseeLectorPOSBanca; }
			set
			{
				ReportPropertyChanging("esPoseeLectorPOSBanca");
				_esPoseeLectorPOSBanca = value;
				ReportPropertyChanged("esPoseeLectorPOSBanca");
			}
		}
		private Boolean? _esPoseeLectorPOSBanca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPoseeMouse
		{
			get { return _esPoseeMouse; }
			set
			{
				ReportPropertyChanging("esPoseeMouse");
				_esPoseeMouse = value;
				ReportPropertyChanged("esPoseeMouse");
			}
		}
		private Boolean? _esPoseeMouse;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPoseePantallaTactil
		{
			get { return _esPoseePantallaTactil; }
			set
			{
				ReportPropertyChanging("esPoseePantallaTactil");
				_esPoseePantallaTactil = value;
				ReportPropertyChanged("esPoseePantallaTactil");
			}
		}
		private Boolean? _esPoseePantallaTactil;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPoseeTeclado
		{
			get { return _esPoseeTeclado; }
			set
			{
				ReportPropertyChanging("esPoseeTeclado");
				_esPoseeTeclado = value;
				ReportPropertyChanged("esPoseeTeclado");
			}
		}
		private Boolean _esPoseeTeclado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPoseeVisorPrecio
		{
			get { return _esPoseeVisorPrecio; }
			set
			{
				ReportPropertyChanging("esPoseeVisorPrecio");
				_esPoseeVisorPrecio = value;
				ReportPropertyChanged("esPoseeVisorPrecio");
			}
		}
		private Boolean _esPoseeVisorPrecio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPoseeVisorPreciosMonitorExtra
		{
			get { return _esPoseeVisorPreciosMonitorExtra; }
			set
			{
				ReportPropertyChanging("esPoseeVisorPreciosMonitorExtra");
				_esPoseeVisorPreciosMonitorExtra = value;
				ReportPropertyChanged("esPoseeVisorPreciosMonitorExtra");
			}
		}
		private Boolean _esPoseeVisorPreciosMonitorExtra;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPreguntarCerrarApp
		{
			get { return _esPreguntarCerrarApp; }
			set
			{
				ReportPropertyChanging("esPreguntarCerrarApp");
				_esPreguntarCerrarApp = value;
				ReportPropertyChanged("esPreguntarCerrarApp");
			}
		}
		private Boolean _esPreguntarCerrarApp;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esRemoto
		{
			get { return _esRemoto; }
			set
			{
				ReportPropertyChanging("esRemoto");
				_esRemoto = value;
				ReportPropertyChanged("esRemoto");
			}
		}
		private Boolean _esRemoto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esRequierePassword
		{
			get { return _esRequierePassword; }
			set
			{
				ReportPropertyChanging("esRequierePassword");
				_esRequierePassword = value;
				ReportPropertyChanged("esRequierePassword");
			}
		}
		private Boolean _esRequierePassword;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esSolicitarEmpleado
		{
			get { return _esSolicitarEmpleado; }
			set
			{
				ReportPropertyChanging("esSolicitarEmpleado");
				_esSolicitarEmpleado = value;
				ReportPropertyChanged("esSolicitarEmpleado");
			}
		}
		private Boolean? _esSolicitarEmpleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaUltimaConfiguracion
		{
			get { return _FechaUltimaConfiguracion; }
			set
			{
				ReportPropertyChanging("FechaUltimaConfiguracion");
				_FechaUltimaConfiguracion = value;
				ReportPropertyChanged("FechaUltimaConfiguracion");
			}
		}
		private DateTime? _FechaUltimaConfiguracion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_Almacen
		{
			get { return _ID_Almacen; }
			set
			{
				ReportPropertyChanging("ID_Almacen");
				_ID_Almacen = value;
				ReportPropertyChanged("ID_Almacen");
			}
		}
		private Int64 _ID_Almacen;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_Licencia
		{
			get { return _ID_Licencia; }
			set
			{
				ReportPropertyChanging("ID_Licencia");
				_ID_Licencia = value;
				ReportPropertyChanged("ID_Licencia");
			}
		}
		private Int64 _ID_Licencia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_TipoDef_DescargaInventario
		{
			get { return _ID_TipoDef_DescargaInventario; }
			set
			{
				ReportPropertyChanging("ID_TipoDef_DescargaInventario");
				_ID_TipoDef_DescargaInventario = value;
				ReportPropertyChanged("ID_TipoDef_DescargaInventario");
			}
		}
		private Int64? _ID_TipoDef_DescargaInventario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_TipoDef_Estacion
		{
			get { return _ID_TipoDef_Estacion; }
			set
			{
				ReportPropertyChanging("ID_TipoDef_Estacion");
				_ID_TipoDef_Estacion = value;
				ReportPropertyChanged("ID_TipoDef_Estacion");
			}
		}
		private Int64 _ID_TipoDef_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_TipoDef_PedirDatosCliente
		{
			get { return _ID_TipoDef_PedirDatosCliente; }
			set
			{
				ReportPropertyChanging("ID_TipoDef_PedirDatosCliente");
				_ID_TipoDef_PedirDatosCliente = value;
				ReportPropertyChanged("ID_TipoDef_PedirDatosCliente");
			}
		}
		private Int64? _ID_TipoDef_PedirDatosCliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_TipoDef_PrecioPredet
		{
			get { return _ID_TipoDef_PrecioPredet; }
			set
			{
				ReportPropertyChanging("ID_TipoDef_PrecioPredet");
				_ID_TipoDef_PrecioPredet = value;
				ReportPropertyChanged("ID_TipoDef_PrecioPredet");
			}
		}
		private Int64 _ID_TipoDef_PrecioPredet;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String IPEstacion
		{
			get { return _IPEstacion; }
			set
			{
				ReportPropertyChanging("IPEstacion");
				_IPEstacion = value;
				ReportPropertyChanged("IPEstacion");
			}
		}
		private String _IPEstacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreEquipo
		{
			get { return _NombreEquipo; }
			set
			{
				ReportPropertyChanging("NombreEquipo");
				_NombreEquipo = value;
				ReportPropertyChanged("NombreEquipo");
			}
		}
		private String _NombreEquipo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String NombreEstacion
		{
			get { return _NombreEstacion; }
			set
			{
				ReportPropertyChanging("NombreEstacion");
				_NombreEstacion = value;
				ReportPropertyChanged("NombreEstacion");
			}
		}
		private String _NombreEstacion;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Dipositivo_VisorPrecios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dipositivo_VisorPrecios : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esVisorPreciosMonitor
		{
			get { return _esVisorPreciosMonitor; }
			set
			{
				ReportPropertyChanging("esVisorPreciosMonitor");
				_esVisorPreciosMonitor = value;
				ReportPropertyChanged("esVisorPreciosMonitor");
			}
		}
		private Boolean _esVisorPreciosMonitor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estacion
		{
			get { return _id_Estacion; }
			set
			{
				ReportPropertyChanging("id_Estacion");
				_id_Estacion = value;
				ReportPropertyChanged("id_Estacion");
			}
		}
		private Int64? _id_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_VisorPreciosModelo
		{
			get { return _Id_VisorPreciosModelo; }
			set
			{
				ReportPropertyChanging("Id_VisorPreciosModelo");
				_Id_VisorPreciosModelo = value;
				ReportPropertyChanged("Id_VisorPreciosModelo");
			}
		}
		private Int64? _Id_VisorPreciosModelo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_VisorPreciosVendor
		{
			get { return _ID_VisorPreciosVendor; }
			set
			{
				ReportPropertyChanging("ID_VisorPreciosVendor");
				_ID_VisorPreciosVendor = value;
				ReportPropertyChanged("ID_VisorPreciosVendor");
			}
		}
		private Int64? _ID_VisorPreciosVendor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Linea1
		{
			get { return _Linea1; }
			set
			{
				ReportPropertyChanging("Linea1");
				_Linea1 = value;
				ReportPropertyChanged("Linea1");
			}
		}
		private String _Linea1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Linea2
		{
			get { return _Linea2; }
			set
			{
				ReportPropertyChanging("Linea2");
				_Linea2 = value;
				ReportPropertyChanged("Linea2");
			}
		}
		private String _Linea2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Linea3
		{
			get { return _Linea3; }
			set
			{
				ReportPropertyChanging("Linea3");
				_Linea3 = value;
				ReportPropertyChanged("Linea3");
			}
		}
		private String _Linea3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Linea4
		{
			get { return _Linea4; }
			set
			{
				ReportPropertyChanging("Linea4");
				_Linea4 = value;
				ReportPropertyChanged("Linea4");
			}
		}
		private String _Linea4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PuertoComunicaciones
		{
			get { return _PuertoComunicaciones; }
			set
			{
				ReportPropertyChanging("PuertoComunicaciones");
				_PuertoComunicaciones = value;
				ReportPropertyChanged("PuertoComunicaciones");
			}
		}
		private String _PuertoComunicaciones;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivo_Balanza")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivo_Balanza : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? AnchoCodigoArticulo
		{
			get { return _AnchoCodigoArticulo; }
			set
			{
				ReportPropertyChanging("AnchoCodigoArticulo");
				_AnchoCodigoArticulo = value;
				ReportPropertyChanged("AnchoCodigoArticulo");
			}
		}
		private Int64? _AnchoCodigoArticulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? AnchoValorPeso
		{
			get { return _AnchoValorPeso; }
			set
			{
				ReportPropertyChanging("AnchoValorPeso");
				_AnchoValorPeso = value;
				ReportPropertyChanged("AnchoValorPeso");
			}
		}
		private Int64? _AnchoValorPeso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Codigo
		{
			get { return _Codigo; }
			set
			{
				ReportPropertyChanging("Codigo");
				_Codigo = value;
				ReportPropertyChanged("Codigo");
			}
		}
		private String _Codigo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esLeerCodigo
		{
			get { return _esLeerCodigo; }
			set
			{
				ReportPropertyChanging("esLeerCodigo");
				_esLeerCodigo = value;
				ReportPropertyChanged("esLeerCodigo");
			}
		}
		private Boolean? _esLeerCodigo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPuertoCOM
		{
			get { return _esPuertoCOM; }
			set
			{
				ReportPropertyChanging("esPuertoCOM");
				_esPuertoCOM = value;
				ReportPropertyChanged("esPuertoCOM");
			}
		}
		private Boolean? _esPuertoCOM;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_BalanzaModelo
		{
			get { return _id_BalanzaModelo; }
			set
			{
				ReportPropertyChanging("id_BalanzaModelo");
				_id_BalanzaModelo = value;
				ReportPropertyChanged("id_BalanzaModelo");
			}
		}
		private Int64? _id_BalanzaModelo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_BalanzaVendor
		{
			get { return _id_BalanzaVendor; }
			set
			{
				ReportPropertyChanging("id_BalanzaVendor");
				_id_BalanzaVendor = value;
				ReportPropertyChanged("id_BalanzaVendor");
			}
		}
		private Int64? _id_BalanzaVendor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estacion
		{
			get { return _id_Estacion; }
			set
			{
				ReportPropertyChanging("id_Estacion");
				_id_Estacion = value;
				ReportPropertyChanged("id_Estacion");
			}
		}
		private Int64? _id_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombrePuerto
		{
			get { return _NombrePuerto; }
			set
			{
				ReportPropertyChanging("NombrePuerto");
				_NombrePuerto = value;
				ReportPropertyChanged("NombrePuerto");
			}
		}
		private String _NombrePuerto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Parametros
		{
			get { return _Parametros; }
			set
			{
				ReportPropertyChanging("Parametros");
				_Parametros = value;
				ReportPropertyChanged("Parametros");
			}
		}
		private String _Parametros;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionFinCodigoArticulo
		{
			get { return _PosicionFinCodigoArticulo; }
			set
			{
				ReportPropertyChanging("PosicionFinCodigoArticulo");
				_PosicionFinCodigoArticulo = value;
				ReportPropertyChanged("PosicionFinCodigoArticulo");
			}
		}
		private Int64? _PosicionFinCodigoArticulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionFinPesoDecimal
		{
			get { return _PosicionFinPesoDecimal; }
			set
			{
				ReportPropertyChanging("PosicionFinPesoDecimal");
				_PosicionFinPesoDecimal = value;
				ReportPropertyChanged("PosicionFinPesoDecimal");
			}
		}
		private Int64? _PosicionFinPesoDecimal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionFinPesoEntero
		{
			get { return _PosicionFinPesoEntero; }
			set
			{
				ReportPropertyChanging("PosicionFinPesoEntero");
				_PosicionFinPesoEntero = value;
				ReportPropertyChanged("PosicionFinPesoEntero");
			}
		}
		private Int64? _PosicionFinPesoEntero;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionIniCodigoArticulo
		{
			get { return _PosicionIniCodigoArticulo; }
			set
			{
				ReportPropertyChanging("PosicionIniCodigoArticulo");
				_PosicionIniCodigoArticulo = value;
				ReportPropertyChanged("PosicionIniCodigoArticulo");
			}
		}
		private Int64? _PosicionIniCodigoArticulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionIniPesoDecimal
		{
			get { return _PosicionIniPesoDecimal; }
			set
			{
				ReportPropertyChanging("PosicionIniPesoDecimal");
				_PosicionIniPesoDecimal = value;
				ReportPropertyChanged("PosicionIniPesoDecimal");
			}
		}
		private Int64? _PosicionIniPesoDecimal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? PosicionIniPesoEntero
		{
			get { return _PosicionIniPesoEntero; }
			set
			{
				ReportPropertyChanging("PosicionIniPesoEntero");
				_PosicionIniPesoEntero = value;
				ReportPropertyChanged("PosicionIniPesoEntero");
			}
		}
		private Int64? _PosicionIniPesoEntero;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivo_Impresora")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivo_Impresora : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado1
		{
			get { return _Encabezado1; }
			set
			{
				ReportPropertyChanging("Encabezado1");
				_Encabezado1 = value;
				ReportPropertyChanged("Encabezado1");
			}
		}
		private String _Encabezado1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado2
		{
			get { return _Encabezado2; }
			set
			{
				ReportPropertyChanging("Encabezado2");
				_Encabezado2 = value;
				ReportPropertyChanged("Encabezado2");
			}
		}
		private String _Encabezado2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado3
		{
			get { return _Encabezado3; }
			set
			{
				ReportPropertyChanging("Encabezado3");
				_Encabezado3 = value;
				ReportPropertyChanged("Encabezado3");
			}
		}
		private String _Encabezado3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado4
		{
			get { return _Encabezado4; }
			set
			{
				ReportPropertyChanging("Encabezado4");
				_Encabezado4 = value;
				ReportPropertyChanged("Encabezado4");
			}
		}
		private String _Encabezado4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado5
		{
			get { return _Encabezado5; }
			set
			{
				ReportPropertyChanging("Encabezado5");
				_Encabezado5 = value;
				ReportPropertyChanged("Encabezado5");
			}
		}
		private String _Encabezado5;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Encabezado6
		{
			get { return _Encabezado6; }
			set
			{
				ReportPropertyChanging("Encabezado6");
				_Encabezado6 = value;
				ReportPropertyChanged("Encabezado6");
			}
		}
		private String _Encabezado6;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCommPort
		{
			get { return _esCommPort; }
			set
			{
				ReportPropertyChanging("esCommPort");
				_esCommPort = value;
				ReportPropertyChanged("esCommPort");
			}
		}
		private Boolean? _esCommPort;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esIFiscal
		{
			get { return _esIFiscal; }
			set
			{
				ReportPropertyChanging("esIFiscal");
				_esIFiscal = value;
				ReportPropertyChanged("esIFiscal");
			}
		}
		private Boolean? _esIFiscal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esImprimirDatosEmpresa
		{
			get { return _esImprimirDatosEmpresa; }
			set
			{
				ReportPropertyChanging("esImprimirDatosEmpresa");
				_esImprimirDatosEmpresa = value;
				ReportPropertyChanged("esImprimirDatosEmpresa");
			}
		}
		private Boolean? _esImprimirDatosEmpresa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esImprimirEmpleado
		{
			get { return _esImprimirEmpleado; }
			set
			{
				ReportPropertyChanging("esImprimirEmpleado");
				_esImprimirEmpleado = value;
				ReportPropertyChanged("esImprimirEmpleado");
			}
		}
		private Boolean? _esImprimirEmpleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esImprimirNropedido
		{
			get { return _esImprimirNropedido; }
			set
			{
				ReportPropertyChanging("esImprimirNropedido");
				_esImprimirNropedido = value;
				ReportPropertyChanged("esImprimirNropedido");
			}
		}
		private Boolean? _esImprimirNropedido;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esMsjPiePagina
		{
			get { return _esMsjPiePagina; }
			set
			{
				ReportPropertyChanging("esMsjPiePagina");
				_esMsjPiePagina = value;
				ReportPropertyChanged("esMsjPiePagina");
			}
		}
		private Boolean? _esMsjPiePagina;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esNConsumo
		{
			get { return _esNConsumo; }
			set
			{
				ReportPropertyChanging("esNConsumo");
				_esNConsumo = value;
				ReportPropertyChanged("esNConsumo");
			}
		}
		private Boolean? _esNConsumo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esRemoto
		{
			get { return _esRemoto; }
			set
			{
				ReportPropertyChanging("esRemoto");
				_esRemoto = value;
				ReportPropertyChanged("esRemoto");
			}
		}
		private Boolean? _esRemoto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esUsaSpooler
		{
			get { return _esUsaSpooler; }
			set
			{
				ReportPropertyChanging("esUsaSpooler");
				_esUsaSpooler = value;
				ReportPropertyChanged("esUsaSpooler");
			}
		}
		private Boolean? _esUsaSpooler;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estacion
		{
			get { return _id_Estacion; }
			set
			{
				ReportPropertyChanging("id_Estacion");
				_id_Estacion = value;
				ReportPropertyChanged("id_Estacion");
			}
		}
		private Int64? _id_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ImpresoraModelo
		{
			get { return _id_ImpresoraModelo; }
			set
			{
				ReportPropertyChanging("id_ImpresoraModelo");
				_id_ImpresoraModelo = value;
				ReportPropertyChanged("id_ImpresoraModelo");
			}
		}
		private Int64? _id_ImpresoraModelo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ImpresoraVendor
		{
			get { return _id_ImpresoraVendor; }
			set
			{
				ReportPropertyChanging("id_ImpresoraVendor");
				_id_ImpresoraVendor = value;
				ReportPropertyChanged("id_ImpresoraVendor");
			}
		}
		private Int64? _id_ImpresoraVendor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String id_TipoImpresora
		{
			get { return _id_TipoImpresora; }
			set
			{
				ReportPropertyChanging("id_TipoImpresora");
				_id_TipoImpresora = value;
				ReportPropertyChanged("id_TipoImpresora");
			}
		}
		private String _id_TipoImpresora;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nColumnas
		{
			get { return _nColumnas; }
			set
			{
				ReportPropertyChanging("nColumnas");
				_nColumnas = value;
				ReportPropertyChanged("nColumnas");
			}
		}
		private Int64? _nColumnas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esForzarImpresion
		{
			get { return _Nconsumo_esForzarImpresion; }
			set
			{
				ReportPropertyChanging("Nconsumo_esForzarImpresion");
				_Nconsumo_esForzarImpresion = value;
				ReportPropertyChanged("Nconsumo_esForzarImpresion");
			}
		}
		private Boolean _Nconsumo_esForzarImpresion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpEncabezado
		{
			get { return _Nconsumo_esImpEncabezado; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpEncabezado");
				_Nconsumo_esImpEncabezado = value;
				ReportPropertyChanged("Nconsumo_esImpEncabezado");
			}
		}
		private Boolean _Nconsumo_esImpEncabezado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpNombreEmpleado
		{
			get { return _Nconsumo_esImpNombreEmpleado; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpNombreEmpleado");
				_Nconsumo_esImpNombreEmpleado = value;
				ReportPropertyChanged("Nconsumo_esImpNombreEmpleado");
			}
		}
		private Boolean _Nconsumo_esImpNombreEmpleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpopcionPropina
		{
			get { return _Nconsumo_esImpopcionPropina; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpopcionPropina");
				_Nconsumo_esImpopcionPropina = value;
				ReportPropertyChanged("Nconsumo_esImpopcionPropina");
			}
		}
		private Boolean _Nconsumo_esImpopcionPropina;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpPieCliente
		{
			get { return _Nconsumo_esImpPieCliente; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpPieCliente");
				_Nconsumo_esImpPieCliente = value;
				ReportPropertyChanged("Nconsumo_esImpPieCliente");
			}
		}
		private Boolean _Nconsumo_esImpPieCliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpPrecios
		{
			get { return _Nconsumo_esImpPrecios; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpPrecios");
				_Nconsumo_esImpPrecios = value;
				ReportPropertyChanged("Nconsumo_esImpPrecios");
			}
		}
		private Boolean _Nconsumo_esImpPrecios;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpPreciosConIVA
		{
			get { return _Nconsumo_esImpPreciosConIVA; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpPreciosConIVA");
				_Nconsumo_esImpPreciosConIVA = value;
				ReportPropertyChanged("Nconsumo_esImpPreciosConIVA");
			}
		}
		private Boolean _Nconsumo_esImpPreciosConIVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_esImpTotalConIVA
		{
			get { return _Nconsumo_esImpTotalConIVA; }
			set
			{
				ReportPropertyChanging("Nconsumo_esImpTotalConIVA");
				_Nconsumo_esImpTotalConIVA = value;
				ReportPropertyChanged("Nconsumo_esImpTotalConIVA");
			}
		}
		private Boolean _Nconsumo_esImpTotalConIVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean Nconsumo_MsjPiePagina
		{
			get { return _Nconsumo_MsjPiePagina; }
			set
			{
				ReportPropertyChanging("Nconsumo_MsjPiePagina");
				_Nconsumo_MsjPiePagina = value;
				ReportPropertyChanged("Nconsumo_MsjPiePagina");
			}
		}
		private Boolean _Nconsumo_MsjPiePagina;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NConsumo_PuertoComunicaciones
		{
			get { return _NConsumo_PuertoComunicaciones; }
			set
			{
				ReportPropertyChanging("NConsumo_PuertoComunicaciones");
				_NConsumo_PuertoComunicaciones = value;
				ReportPropertyChanged("NConsumo_PuertoComunicaciones");
			}
		}
		private String _NConsumo_PuertoComunicaciones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombrePuerto
		{
			get { return _NombrePuerto; }
			set
			{
				ReportPropertyChanging("NombrePuerto");
				_NombrePuerto = value;
				ReportPropertyChanged("NombrePuerto");
			}
		}
		private String _NombrePuerto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina1
		{
			get { return _PiePagina1; }
			set
			{
				ReportPropertyChanging("PiePagina1");
				_PiePagina1 = value;
				ReportPropertyChanged("PiePagina1");
			}
		}
		private String _PiePagina1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina2
		{
			get { return _PiePagina2; }
			set
			{
				ReportPropertyChanging("PiePagina2");
				_PiePagina2 = value;
				ReportPropertyChanged("PiePagina2");
			}
		}
		private String _PiePagina2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina3
		{
			get { return _PiePagina3; }
			set
			{
				ReportPropertyChanging("PiePagina3");
				_PiePagina3 = value;
				ReportPropertyChanged("PiePagina3");
			}
		}
		private String _PiePagina3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina4
		{
			get { return _PiePagina4; }
			set
			{
				ReportPropertyChanging("PiePagina4");
				_PiePagina4 = value;
				ReportPropertyChanged("PiePagina4");
			}
		}
		private String _PiePagina4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina5
		{
			get { return _PiePagina5; }
			set
			{
				ReportPropertyChanging("PiePagina5");
				_PiePagina5 = value;
				ReportPropertyChanged("PiePagina5");
			}
		}
		private String _PiePagina5;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PiePagina6
		{
			get { return _PiePagina6; }
			set
			{
				ReportPropertyChanging("PiePagina6");
				_PiePagina6 = value;
				ReportPropertyChanged("PiePagina6");
			}
		}
		private String _PiePagina6;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Bus
		{
			get { return _Bus; }
			set
			{
				ReportPropertyChanging("Bus");
				_Bus = value;
				ReportPropertyChanged("Bus");
			}
		}
		private String _Bus;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String BusType
		{
			get { return _BusType; }
			set
			{
				ReportPropertyChanging("BusType");
				_BusType = value;
				ReportPropertyChanged("BusType");
			}
		}
		private String _BusType;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ClassName
		{
			get { return _ClassName; }
			set
			{
				ReportPropertyChanging("ClassName");
				_ClassName = value;
				ReportPropertyChanged("ClassName");
			}
		}
		private String _ClassName;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Device
		{
			get { return _Device; }
			set
			{
				ReportPropertyChanging("Device");
				_Device = value;
				ReportPropertyChanged("Device");
			}
		}
		private String _Device;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String SubSystemDeviceName
		{
			get { return _SubSystemDeviceName; }
			set
			{
				ReportPropertyChanging("SubSystemDeviceName");
				_SubSystemDeviceName = value;
				ReportPropertyChanged("SubSystemDeviceName");
			}
		}
		private String _SubSystemDeviceName;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String SubSystemVendor
		{
			get { return _SubSystemVendor; }
			set
			{
				ReportPropertyChanging("SubSystemVendor");
				_SubSystemVendor = value;
				ReportPropertyChanged("SubSystemVendor");
			}
		}
		private String _SubSystemVendor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Vendor
		{
			get { return _Vendor; }
			set
			{
				ReportPropertyChanging("Vendor");
				_Vendor = value;
				ReportPropertyChanged("Vendor");
			}
		}
		private String _Vendor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String WindowsName
		{
			get { return _WindowsName; }
			set
			{
				ReportPropertyChanging("WindowsName");
				_WindowsName = value;
				ReportPropertyChanged("WindowsName");
			}
		}
		private String _WindowsName;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivos_GavetaDinero")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivos_GavetaDinero : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Comando
		{
			get { return _Comando; }
			set
			{
				ReportPropertyChanging("Comando");
				_Comando = value;
				ReportPropertyChanged("Comando");
			}
		}
		private String _Comando;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esGavetaDineroFiscal
		{
			get { return _esGavetaDineroFiscal; }
			set
			{
				ReportPropertyChanging("esGavetaDineroFiscal");
				_esGavetaDineroFiscal = value;
				ReportPropertyChanged("esGavetaDineroFiscal");
			}
		}
		private Boolean _esGavetaDineroFiscal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estacion
		{
			get { return _id_Estacion; }
			set
			{
				ReportPropertyChanging("id_Estacion");
				_id_Estacion = value;
				ReportPropertyChanged("id_Estacion");
			}
		}
		private Int64? _id_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String PuertoComunicaciones
		{
			get { return _PuertoComunicaciones; }
			set
			{
				ReportPropertyChanging("PuertoComunicaciones");
				_PuertoComunicaciones = value;
				ReportPropertyChanged("PuertoComunicaciones");
			}
		}
		private String _PuertoComunicaciones;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Reportes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Reportes : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_CheckIn
		{
			get { return _arch_CheckIn; }
			set
			{
				ReportPropertyChanging("arch_CheckIn");
				_arch_CheckIn = value;
				ReportPropertyChanged("arch_CheckIn");
			}
		}
		private String _arch_CheckIn;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_CheckOut
		{
			get { return _arch_CheckOut; }
			set
			{
				ReportPropertyChanging("arch_CheckOut");
				_arch_CheckOut = value;
				ReportPropertyChanged("arch_CheckOut");
			}
		}
		private String _arch_CheckOut;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Clientes
		{
			get { return _arch_Clientes; }
			set
			{
				ReportPropertyChanging("arch_Clientes");
				_arch_Clientes = value;
				ReportPropertyChanged("arch_Clientes");
			}
		}
		private String _arch_Clientes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Facturas
		{
			get { return _arch_Facturas; }
			set
			{
				ReportPropertyChanging("arch_Facturas");
				_arch_Facturas = value;
				ReportPropertyChanged("arch_Facturas");
			}
		}
		private String _arch_Facturas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Habitaciones
		{
			get { return _arch_Habitaciones; }
			set
			{
				ReportPropertyChanging("arch_Habitaciones");
				_arch_Habitaciones = value;
				ReportPropertyChanged("arch_Habitaciones");
			}
		}
		private String _arch_Habitaciones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Movimientos
		{
			get { return _arch_Movimientos; }
			set
			{
				ReportPropertyChanging("arch_Movimientos");
				_arch_Movimientos = value;
				ReportPropertyChanged("arch_Movimientos");
			}
		}
		private String _arch_Movimientos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_PlanesTarifas
		{
			get { return _arch_PlanesTarifas; }
			set
			{
				ReportPropertyChanging("arch_PlanesTarifas");
				_arch_PlanesTarifas = value;
				ReportPropertyChanged("arch_PlanesTarifas");
			}
		}
		private String _arch_PlanesTarifas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Reservas
		{
			get { return _arch_Reservas; }
			set
			{
				ReportPropertyChanging("arch_Reservas");
				_arch_Reservas = value;
				ReportPropertyChanged("arch_Reservas");
			}
		}
		private String _arch_Reservas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String arch_Servicios
		{
			get { return _arch_Servicios; }
			set
			{
				ReportPropertyChanging("arch_Servicios");
				_arch_Servicios = value;
				ReportPropertyChanged("arch_Servicios");
			}
		}
		private String _arch_Servicios;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_Estacion
		{
			get { return _ID_Estacion; }
			set
			{
				ReportPropertyChanging("ID_Estacion");
				_ID_Estacion = value;
				ReportPropertyChanged("ID_Estacion");
			}
		}
		private Int64? _ID_Estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_CheckIn
		{
			get { return _ImpReporte_CheckIn; }
			set
			{
				ReportPropertyChanging("ImpReporte_CheckIn");
				_ImpReporte_CheckIn = value;
				ReportPropertyChanged("ImpReporte_CheckIn");
			}
		}
		private String _ImpReporte_CheckIn;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_CheckOut
		{
			get { return _ImpReporte_CheckOut; }
			set
			{
				ReportPropertyChanging("ImpReporte_CheckOut");
				_ImpReporte_CheckOut = value;
				ReportPropertyChanged("ImpReporte_CheckOut");
			}
		}
		private String _ImpReporte_CheckOut;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Clientes
		{
			get { return _ImpReporte_Clientes; }
			set
			{
				ReportPropertyChanging("ImpReporte_Clientes");
				_ImpReporte_Clientes = value;
				ReportPropertyChanged("ImpReporte_Clientes");
			}
		}
		private String _ImpReporte_Clientes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Facturas
		{
			get { return _ImpReporte_Facturas; }
			set
			{
				ReportPropertyChanging("ImpReporte_Facturas");
				_ImpReporte_Facturas = value;
				ReportPropertyChanged("ImpReporte_Facturas");
			}
		}
		private String _ImpReporte_Facturas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Habitaciones
		{
			get { return _ImpReporte_Habitaciones; }
			set
			{
				ReportPropertyChanging("ImpReporte_Habitaciones");
				_ImpReporte_Habitaciones = value;
				ReportPropertyChanged("ImpReporte_Habitaciones");
			}
		}
		private String _ImpReporte_Habitaciones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Movimientos
		{
			get { return _ImpReporte_Movimientos; }
			set
			{
				ReportPropertyChanging("ImpReporte_Movimientos");
				_ImpReporte_Movimientos = value;
				ReportPropertyChanged("ImpReporte_Movimientos");
			}
		}
		private String _ImpReporte_Movimientos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_PlanesTarifas
		{
			get { return _ImpReporte_PlanesTarifas; }
			set
			{
				ReportPropertyChanging("ImpReporte_PlanesTarifas");
				_ImpReporte_PlanesTarifas = value;
				ReportPropertyChanged("ImpReporte_PlanesTarifas");
			}
		}
		private String _ImpReporte_PlanesTarifas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Reservas
		{
			get { return _ImpReporte_Reservas; }
			set
			{
				ReportPropertyChanging("ImpReporte_Reservas");
				_ImpReporte_Reservas = value;
				ReportPropertyChanged("ImpReporte_Reservas");
			}
		}
		private String _ImpReporte_Reservas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImpReporte_Servicios
		{
			get { return _ImpReporte_Servicios; }
			set
			{
				ReportPropertyChanging("ImpReporte_Servicios");
				_ImpReporte_Servicios = value;
				ReportPropertyChanged("ImpReporte_Servicios");
			}
		}
		private String _ImpReporte_Servicios;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_CheckIn
		{
			get { return _nCopias_CheckIn; }
			set
			{
				ReportPropertyChanging("nCopias_CheckIn");
				_nCopias_CheckIn = value;
				ReportPropertyChanged("nCopias_CheckIn");
			}
		}
		private Int64 _nCopias_CheckIn;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Checkout
		{
			get { return _nCopias_Checkout; }
			set
			{
				ReportPropertyChanging("nCopias_Checkout");
				_nCopias_Checkout = value;
				ReportPropertyChanged("nCopias_Checkout");
			}
		}
		private Int64 _nCopias_Checkout;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Clientes
		{
			get { return _nCopias_Clientes; }
			set
			{
				ReportPropertyChanging("nCopias_Clientes");
				_nCopias_Clientes = value;
				ReportPropertyChanged("nCopias_Clientes");
			}
		}
		private Int64 _nCopias_Clientes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Facturas
		{
			get { return _nCopias_Facturas; }
			set
			{
				ReportPropertyChanging("nCopias_Facturas");
				_nCopias_Facturas = value;
				ReportPropertyChanged("nCopias_Facturas");
			}
		}
		private Int64 _nCopias_Facturas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Habitaciones
		{
			get { return _nCopias_Habitaciones; }
			set
			{
				ReportPropertyChanging("nCopias_Habitaciones");
				_nCopias_Habitaciones = value;
				ReportPropertyChanged("nCopias_Habitaciones");
			}
		}
		private Int64 _nCopias_Habitaciones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Movimientos
		{
			get { return _nCopias_Movimientos; }
			set
			{
				ReportPropertyChanging("nCopias_Movimientos");
				_nCopias_Movimientos = value;
				ReportPropertyChanged("nCopias_Movimientos");
			}
		}
		private Int64 _nCopias_Movimientos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_PlanesTarifas
		{
			get { return _nCopias_PlanesTarifas; }
			set
			{
				ReportPropertyChanging("nCopias_PlanesTarifas");
				_nCopias_PlanesTarifas = value;
				ReportPropertyChanged("nCopias_PlanesTarifas");
			}
		}
		private Int64 _nCopias_PlanesTarifas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Reservas
		{
			get { return _nCopias_Reservas; }
			set
			{
				ReportPropertyChanging("nCopias_Reservas");
				_nCopias_Reservas = value;
				ReportPropertyChanged("nCopias_Reservas");
			}
		}
		private Int64 _nCopias_Reservas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nCopias_Servicios
		{
			get { return _nCopias_Servicios; }
			set
			{
				ReportPropertyChanging("nCopias_Servicios");
				_nCopias_Servicios = value;
				ReportPropertyChanged("nCopias_Servicios");
			}
		}
		private Int64 _nCopias_Servicios;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Sesiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Sesiones : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEstacionActiva
		{
			get { return _esEstacionActiva; }
			set
			{
				ReportPropertyChanging("esEstacionActiva");
				_esEstacionActiva = value;
				ReportPropertyChanged("esEstacionActiva");
			}
		}
		private Boolean? _esEstacionActiva;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime? _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaFin
		{
			get { return _FechaFin; }
			set
			{
				ReportPropertyChanging("FechaFin");
				_FechaFin = value;
				ReportPropertyChanged("FechaFin");
			}
		}
		private DateTime? _FechaFin;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Empleado
		{
			get { return _id_Empleado; }
			set
			{
				ReportPropertyChanging("id_Empleado");
				_id_Empleado = value;
				ReportPropertyChanged("id_Empleado");
			}
		}
		private Int64? _id_Empleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_estacion
		{
			get { return _id_estacion; }
			set
			{
				ReportPropertyChanging("id_estacion");
				_id_estacion = value;
				ReportPropertyChanged("id_estacion");
			}
		}
		private Int64? _id_estacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_Licencia
		{
			get { return _ID_Licencia; }
			set
			{
				ReportPropertyChanging("ID_Licencia");
				_ID_Licencia = value;
				ReportPropertyChanged("ID_Licencia");
			}
		}
		private Int64? _ID_Licencia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Usuario
		{
			get { return _id_Usuario; }
			set
			{
				ReportPropertyChanging("id_Usuario");
				_id_Usuario = value;
				ReportPropertyChanged("id_Usuario");
			}
		}
		private Int64? _id_Usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String IPEstacion
		{
			get { return _IPEstacion; }
			set
			{
				ReportPropertyChanging("IPEstacion");
				_IPEstacion = value;
				ReportPropertyChanged("IPEstacion");
			}
		}
		private String _IPEstacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ModuloActual
		{
			get { return _ModuloActual; }
			set
			{
				ReportPropertyChanging("ModuloActual");
				_ModuloActual = value;
				ReportPropertyChanged("ModuloActual");
			}
		}
		private String _ModuloActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreEquipo
		{
			get { return _NombreEquipo; }
			set
			{
				ReportPropertyChanging("NombreEquipo");
				_NombreEquipo = value;
				ReportPropertyChanged("NombreEquipo");
			}
		}
		private String _NombreEquipo;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Sesiones_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Sesiones_Detalle : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? esActualizar
		{
			get { return _esActualizar; }
			set
			{
				ReportPropertyChanging("esActualizar");
				_esActualizar = value;
				ReportPropertyChanged("esActualizar");
			}
		}
		private Double? _esActualizar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAgregar
		{
			get { return _esAgregar; }
			set
			{
				ReportPropertyChanging("esAgregar");
				_esAgregar = value;
				ReportPropertyChanged("esAgregar");
			}
		}
		private Boolean? _esAgregar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEditar
		{
			get { return _esEditar; }
			set
			{
				ReportPropertyChanging("esEditar");
				_esEditar = value;
				ReportPropertyChanged("esEditar");
			}
		}
		private Boolean? _esEditar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEliminar
		{
			get { return _esEliminar; }
			set
			{
				ReportPropertyChanging("esEliminar");
				_esEliminar = value;
				ReportPropertyChanged("esEliminar");
			}
		}
		private Boolean? _esEliminar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaFinal
		{
			get { return _FechaFinal; }
			set
			{
				ReportPropertyChanging("FechaFinal");
				_FechaFinal = value;
				ReportPropertyChanged("FechaFinal");
			}
		}
		private DateTime? _FechaFinal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaInicial
		{
			get { return _FechaInicial; }
			set
			{
				ReportPropertyChanging("FechaInicial");
				_FechaInicial = value;
				ReportPropertyChanged("FechaInicial");
			}
		}
		private DateTime? _FechaInicial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_Caja
		{
			get { return _ID_Caja; }
			set
			{
				ReportPropertyChanging("ID_Caja");
				_ID_Caja = value;
				ReportPropertyChanged("ID_Caja");
			}
		}
		private Int64? _ID_Caja;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Estaciones_Sesiones
		{
			get { return _id_Estaciones_Sesiones; }
			set
			{
				ReportPropertyChanging("id_Estaciones_Sesiones");
				_id_Estaciones_Sesiones = value;
				ReportPropertyChanged("id_Estaciones_Sesiones");
			}
		}
		private Int64? _id_Estaciones_Sesiones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_RegistroPpal
		{
			get { return _ID_RegistroPpal; }
			set
			{
				ReportPropertyChanging("ID_RegistroPpal");
				_ID_RegistroPpal = value;
				ReportPropertyChanged("ID_RegistroPpal");
			}
		}
		private Int64? _ID_RegistroPpal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ModuloLocacion
		{
			get { return _ModuloLocacion; }
			set
			{
				ReportPropertyChanging("ModuloLocacion");
				_ModuloLocacion = value;
				ReportPropertyChanged("ModuloLocacion");
			}
		}
		private String _ModuloLocacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreModulo
		{
			get { return _NombreModulo; }
			set
			{
				ReportPropertyChanging("NombreModulo");
				_NombreModulo = value;
				ReportPropertyChanged("NombreModulo");
			}
		}
		private String _NombreModulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String RegistroFinal
		{
			get { return _RegistroFinal; }
			set
			{
				ReportPropertyChanging("RegistroFinal");
				_RegistroFinal = value;
				ReportPropertyChanged("RegistroFinal");
			}
		}
		private String _RegistroFinal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String RegistroOriginal
		{
			get { return _RegistroOriginal; }
			set
			{
				ReportPropertyChanging("RegistroOriginal");
				_RegistroOriginal = value;
				ReportPropertyChanged("RegistroOriginal");
			}
		}
		private String _RegistroOriginal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Tabla_RegistroPpal
		{
			get { return _Tabla_RegistroPpal; }
			set
			{
				ReportPropertyChanging("Tabla_RegistroPpal");
				_Tabla_RegistroPpal = value;
				ReportPropertyChanged("Tabla_RegistroPpal");
			}
		}
		private String _Tabla_RegistroPpal;


	}

	[EdmEntityTypeAttribute(Name = "Facturas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Comentarios
		{
			get { return _Comentarios; }
			set
			{
				ReportPropertyChanging("Comentarios");
				_Comentarios = value;
				ReportPropertyChanged("Comentarios");
			}
		}
		private String _Comentarios;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaFactura
		{
			get { return _FechaFactura; }
			set
			{
				ReportPropertyChanging("FechaFactura");
				_FechaFactura = value;
				ReportPropertyChanged("FechaFactura");
			}
		}
		private DateTime _FechaFactura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Caja
		{
			get { return _Id_Caja; }
			set
			{
				ReportPropertyChanging("Id_Caja");
				_Id_Caja = value;
				ReportPropertyChanged("Id_Caja");
			}
		}
		private Int64? _Id_Caja;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Cliente
		{
			get { return _Id_Cliente; }
			set
			{
				ReportPropertyChanging("Id_Cliente");
				_Id_Cliente = value;
				ReportPropertyChanged("Id_Cliente");
			}
		}
		private Int64? _Id_Cliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_corteZ
		{
			get { return _id_corteZ; }
			set
			{
				ReportPropertyChanging("id_corteZ");
				_id_corteZ = value;
				ReportPropertyChanged("id_corteZ");
			}
		}
		private Int64? _id_corteZ;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Empleado
		{
			get { return _Id_Empleado; }
			set
			{
				ReportPropertyChanging("Id_Empleado");
				_Id_Empleado = value;
				ReportPropertyChanged("Id_Empleado");
			}
		}
		private Int64? _Id_Empleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_tipoEnumSatusFactura
		{
			get { return _id_tipoEnumSatusFactura; }
			set
			{
				ReportPropertyChanging("id_tipoEnumSatusFactura");
				_id_tipoEnumSatusFactura = value;
				ReportPropertyChanged("id_tipoEnumSatusFactura");
			}
		}
		private Int64 _id_tipoEnumSatusFactura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroFactura
		{
			get { return _nroFactura; }
			set
			{
				ReportPropertyChanging("nroFactura");
				_nroFactura = value;
				ReportPropertyChanged("nroFactura");
			}
		}
		private Int64 _nroFactura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroFacturaIF
		{
			get { return _nroFacturaIF; }
			set
			{
				ReportPropertyChanging("nroFacturaIF");
				_nroFacturaIF = value;
				ReportPropertyChanged("nroFacturaIF");
			}
		}
		private String _nroFacturaIF;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Descuentos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Descuentos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Descuento
		{
			get { return _Id_Descuento; }
			set
			{
				ReportPropertyChanging("Id_Descuento");
				_Id_Descuento = value;
				ReportPropertyChanged("Id_Descuento");
			}
		}
		private Int64 _Id_Descuento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? TasaValor
		{
			get { return _TasaValor; }
			set
			{
				ReportPropertyChanging("TasaValor");
				_TasaValor = value;
				ReportPropertyChanged("TasaValor");
			}
		}
		private Double? _TasaValor;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Cantidad
		{
			get { return _Cantidad; }
			set
			{
				ReportPropertyChanging("Cantidad");
				_Cantidad = value;
				ReportPropertyChanged("Cantidad");
			}
		}
		private Double _Cantidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Comentario
		{
			get { return _Comentario; }
			set
			{
				ReportPropertyChanging("Comentario");
				_Comentario = value;
				ReportPropertyChanged("Comentario");
			}
		}
		private String _Comentario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Producto
		{
			get { return _Id_Producto; }
			set
			{
				ReportPropertyChanging("Id_Producto");
				_Id_Producto = value;
				ReportPropertyChanged("Id_Producto");
			}
		}
		private Int64 _Id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_tipoProducto
		{
			get { return _id_tipoProducto; }
			set
			{
				ReportPropertyChanging("id_tipoProducto");
				_id_tipoProducto = value;
				ReportPropertyChanged("id_tipoProducto");
			}
		}
		private Int64? _id_tipoProducto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoPrecio
		{
			get { return _MontoPrecio; }
			set
			{
				ReportPropertyChanging("MontoPrecio");
				_MontoPrecio = value;
				ReportPropertyChanged("MontoPrecio");
			}
		}
		private Double _MontoPrecio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nPrecio
		{
			get { return _nPrecio; }
			set
			{
				ReportPropertyChanging("nPrecio");
				_nPrecio = value;
				ReportPropertyChanged("nPrecio");
			}
		}
		private Int64 _nPrecio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nroItem
		{
			get { return _nroItem; }
			set
			{
				ReportPropertyChanging("nroItem");
				_nroItem = value;
				ReportPropertyChanged("nroItem");
			}
		}
		private Int64 _nroItem;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle_Descuentos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle_Descuentos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Descuento
		{
			get { return _Id_Descuento; }
			set
			{
				ReportPropertyChanging("Id_Descuento");
				_Id_Descuento = value;
				ReportPropertyChanged("Id_Descuento");
			}
		}
		private Int64? _Id_Descuento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_FacturaDetalle
		{
			get { return _Id_FacturaDetalle; }
			set
			{
				ReportPropertyChanging("Id_FacturaDetalle");
				_Id_FacturaDetalle = value;
				ReportPropertyChanged("Id_FacturaDetalle");
			}
		}
		private Int64 _Id_FacturaDetalle;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? Tasa
		{
			get { return _Tasa; }
			set
			{
				ReportPropertyChanging("Tasa");
				_Tasa = value;
				ReportPropertyChanged("Tasa");
			}
		}
		private Double? _Tasa;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle_Impuestos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_FacturaDetalle
		{
			get { return _Id_FacturaDetalle; }
			set
			{
				ReportPropertyChanging("Id_FacturaDetalle");
				_Id_FacturaDetalle = value;
				ReportPropertyChanged("Id_FacturaDetalle");
			}
		}
		private Int64 _Id_FacturaDetalle;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_impuesto
		{
			get { return _Id_impuesto; }
			set
			{
				ReportPropertyChanging("Id_impuesto");
				_Id_impuesto = value;
				ReportPropertyChanged("Id_impuesto");
			}
		}
		private Int64 _Id_impuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Tasa
		{
			get { return _Tasa; }
			set
			{
				ReportPropertyChanging("Tasa");
				_Tasa = value;
				ReportPropertyChanged("Tasa");
			}
		}
		private Double _Tasa;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_FormasPago")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_FormasPago : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DescripicionDocumento
		{
			get { return _DescripicionDocumento; }
			set
			{
				ReportPropertyChanging("DescripicionDocumento");
				_DescripicionDocumento = value;
				ReportPropertyChanged("DescripicionDocumento");
			}
		}
		private String _DescripicionDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime? _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_banco
		{
			get { return _Id_banco; }
			set
			{
				ReportPropertyChanging("Id_banco");
				_Id_banco = value;
				ReportPropertyChanged("Id_banco");
			}
		}
		private Int64? _Id_banco;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_TipoPago
		{
			get { return _Id_TipoPago; }
			set
			{
				ReportPropertyChanging("Id_TipoPago");
				_Id_TipoPago = value;
				ReportPropertyChanged("Id_TipoPago");
			}
		}
		private Int64 _Id_TipoPago;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Monto
		{
			get { return _Monto; }
			set
			{
				ReportPropertyChanging("Monto");
				_Monto = value;
				ReportPropertyChanged("Monto");
			}
		}
		private Double _Monto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroAprobacion
		{
			get { return _nroAprobacion; }
			set
			{
				ReportPropertyChanging("nroAprobacion");
				_nroAprobacion = value;
				ReportPropertyChanged("nroAprobacion");
			}
		}
		private String _nroAprobacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroDocumento
		{
			get { return _nroDocumento; }
			set
			{
				ReportPropertyChanging("nroDocumento");
				_nroDocumento = value;
				ReportPropertyChanged("nroDocumento");
			}
		}
		private String _nroDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroRecibo
		{
			get { return _nroRecibo; }
			set
			{
				ReportPropertyChanging("nroRecibo");
				_nroRecibo = value;
				ReportPropertyChanged("nroRecibo");
			}
		}
		private String _nroRecibo;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_IF")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_IF : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaIF
		{
			get { return _FechaIF; }
			set
			{
				ReportPropertyChanging("FechaIF");
				_FechaIF = value;
				ReportPropertyChanged("FechaIF");
			}
		}
		private DateTime? _FechaIF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Nro_IF
		{
			get { return _Nro_IF; }
			set
			{
				ReportPropertyChanging("Nro_IF");
				_Nro_IF = value;
				ReportPropertyChanged("Nro_IF");
			}
		}
		private Int64 _Nro_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String RIF_IF
		{
			get { return _RIF_IF; }
			set
			{
				ReportPropertyChanging("RIF_IF");
				_RIF_IF = value;
				ReportPropertyChanged("RIF_IF");
			}
		}
		private String _RIF_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String SerialIF
		{
			get { return _SerialIF; }
			set
			{
				ReportPropertyChanging("SerialIF");
				_SerialIF = value;
				ReportPropertyChanged("SerialIF");
			}
		}
		private String _SerialIF;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Impuestos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Impuesto
		{
			get { return _Id_Impuesto; }
			set
			{
				ReportPropertyChanging("Id_Impuesto");
				_Id_Impuesto = value;
				ReportPropertyChanged("Id_Impuesto");
			}
		}
		private Int64 _Id_Impuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? Tasa
		{
			get { return _Tasa; }
			set
			{
				ReportPropertyChanging("Tasa");
				_Tasa = value;
				ReportPropertyChanged("Tasa");
			}
		}
		private Double? _Tasa;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Modificadas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Modificadas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Comentario
		{
			get { return _Comentario; }
			set
			{
				ReportPropertyChanging("Comentario");
				_Comentario = value;
				ReportPropertyChanged("Comentario");
			}
		}
		private String _Comentario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Estaciones_Sesiones
		{
			get { return _id_Estaciones_Sesiones; }
			set
			{
				ReportPropertyChanging("id_Estaciones_Sesiones");
				_id_Estaciones_Sesiones = value;
				ReportPropertyChanged("id_Estaciones_Sesiones");
			}
		}
		private Int64 _id_Estaciones_Sesiones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_factura
		{
			get { return _id_factura; }
			set
			{
				ReportPropertyChanging("id_factura");
				_id_factura = value;
				ReportPropertyChanged("id_factura");
			}
		}
		private Int64 _id_factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_TipoModificacion
		{
			get { return _id_TipoModificacion; }
			set
			{
				ReportPropertyChanging("id_TipoModificacion");
				_id_TipoModificacion = value;
				ReportPropertyChanged("id_TipoModificacion");
			}
		}
		private Int64 _id_TipoModificacion;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Modificadas_IF")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Modificadas_IF : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_IF
		{
			get { return _Fecha_IF; }
			set
			{
				ReportPropertyChanging("Fecha_IF");
				_Fecha_IF = value;
				ReportPropertyChanged("Fecha_IF");
			}
		}
		private DateTime? _Fecha_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Facturas_Modificadas
		{
			get { return _id_Facturas_Modificadas; }
			set
			{
				ReportPropertyChanging("id_Facturas_Modificadas");
				_id_Facturas_Modificadas = value;
				ReportPropertyChanged("id_Facturas_Modificadas");
			}
		}
		private Int64 _id_Facturas_Modificadas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoTotal1
		{
			get { return _MontoTotal1; }
			set
			{
				ReportPropertyChanging("MontoTotal1");
				_MontoTotal1 = value;
				ReportPropertyChanged("MontoTotal1");
			}
		}
		private Double _MontoTotal1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoTotal2
		{
			get { return _MontoTotal2; }
			set
			{
				ReportPropertyChanging("MontoTotal2");
				_MontoTotal2 = value;
				ReportPropertyChanged("MontoTotal2");
			}
		}
		private Double? _MontoTotal2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoTotal3
		{
			get { return _MontoTotal3; }
			set
			{
				ReportPropertyChanging("MontoTotal3");
				_MontoTotal3 = value;
				ReportPropertyChanged("MontoTotal3");
			}
		}
		private Double? _MontoTotal3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 nro_IF
		{
			get { return _nro_IF; }
			set
			{
				ReportPropertyChanging("nro_IF");
				_nro_IF = value;
				ReportPropertyChanged("nro_IF");
			}
		}
		private Int64 _nro_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroSerial_IF
		{
			get { return _nroSerial_IF; }
			set
			{
				ReportPropertyChanging("nroSerial_IF");
				_nroSerial_IF = value;
				ReportPropertyChanged("nroSerial_IF");
			}
		}
		private String _nroSerial_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String RIF_IF
		{
			get { return _RIF_IF; }
			set
			{
				ReportPropertyChanging("RIF_IF");
				_RIF_IF = value;
				ReportPropertyChanged("RIF_IF");
			}
		}
		private String _RIF_IF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Tasa1
		{
			get { return _Tasa1; }
			set
			{
				ReportPropertyChanging("Tasa1");
				_Tasa1 = value;
				ReportPropertyChanged("Tasa1");
			}
		}
		private Double _Tasa1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? Tasa2
		{
			get { return _Tasa2; }
			set
			{
				ReportPropertyChanging("Tasa2");
				_Tasa2 = value;
				ReportPropertyChanged("Tasa2");
			}
		}
		private Double? _Tasa2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? Tasa3
		{
			get { return _Tasa3; }
			set
			{
				ReportPropertyChanging("Tasa3");
				_Tasa3 = value;
				ReportPropertyChanged("Tasa3");
			}
		}
		private Double? _Tasa3;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Servicios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Servicios : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Comentarios
		{
			get { return _Comentarios; }
			set
			{
				ReportPropertyChanging("Comentarios");
				_Comentarios = value;
				ReportPropertyChanged("Comentarios");
			}
		}
		private String _Comentarios;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaAtendido
		{
			get { return _FechaAtendido; }
			set
			{
				ReportPropertyChanging("FechaAtendido");
				_FechaAtendido = value;
				ReportPropertyChanged("FechaAtendido");
			}
		}
		private DateTime? _FechaAtendido;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaEntrada
		{
			get { return _FechaEntrada; }
			set
			{
				ReportPropertyChanging("FechaEntrada");
				_FechaEntrada = value;
				ReportPropertyChanged("FechaEntrada");
			}
		}
		private DateTime? _FechaEntrada;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaEntrega
		{
			get { return _FechaEntrega; }
			set
			{
				ReportPropertyChanging("FechaEntrega");
				_FechaEntrega = value;
				ReportPropertyChanged("FechaEntrega");
			}
		}
		private DateTime? _FechaEntrega;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaTentativaEntrega
		{
			get { return _FechaTentativaEntrega; }
			set
			{
				ReportPropertyChanging("FechaTentativaEntrega");
				_FechaTentativaEntrega = value;
				ReportPropertyChanged("FechaTentativaEntrega");
			}
		}
		private DateTime? _FechaTentativaEntrega;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_EmpleadoEntrega
		{
			get { return _id_EmpleadoEntrega; }
			set
			{
				ReportPropertyChanging("id_EmpleadoEntrega");
				_id_EmpleadoEntrega = value;
				ReportPropertyChanged("id_EmpleadoEntrega");
			}
		}
		private Int64? _id_EmpleadoEntrega;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Factura
		{
			get { return _Id_Factura; }
			set
			{
				ReportPropertyChanging("Id_Factura");
				_Id_Factura = value;
				ReportPropertyChanged("Id_Factura");
			}
		}
		private Int64 _Id_Factura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_status
		{
			get { return _id_status; }
			set
			{
				ReportPropertyChanging("id_status");
				_id_status = value;
				ReportPropertyChanged("id_status");
			}
		}
		private Int64? _id_status;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreRecibe
		{
			get { return _NombreRecibe; }
			set
			{
				ReportPropertyChanging("NombreRecibe");
				_NombreRecibe = value;
				ReportPropertyChanged("NombreRecibe");
			}
		}
		private String _NombreRecibe;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nroDiasGarantia
		{
			get { return _nroDiasGarantia; }
			set
			{
				ReportPropertyChanging("nroDiasGarantia");
				_nroDiasGarantia = value;
				ReportPropertyChanged("nroDiasGarantia");
			}
		}
		private Int64? _nroDiasGarantia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nroRecibo
		{
			get { return _nroRecibo; }
			set
			{
				ReportPropertyChanging("nroRecibo");
				_nroRecibo = value;
				ReportPropertyChanged("nroRecibo");
			}
		}
		private Int64? _nroRecibo;


	}

	[EdmEntityTypeAttribute(Name = "World_idiomas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class World_idiomas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String codigo
		{
			get { return _codigo; }
			set
			{
				ReportPropertyChanging("codigo");
				_codigo = value;
				ReportPropertyChanged("codigo");
			}
		}
		private String _codigo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean estado
		{
			get { return _estado; }
			set
			{
				ReportPropertyChanging("estado");
				_estado = value;
				ReportPropertyChanged("estado");
			}
		}
		private Boolean _estado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Impuestos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esIncluido
		{
			get { return _esIncluido; }
			set
			{
				ReportPropertyChanging("esIncluido");
				_esIncluido = value;
				ReportPropertyChanged("esIncluido");
			}
		}
		private Boolean _esIncluido;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public DateTime FachaModificado
		{
			get { return _FachaModificado; }
			set
			{
				ReportPropertyChanging("FachaModificado");
				_FachaModificado = value;
				ReportPropertyChanged("FachaModificado");
			}
		}
		private DateTime _FachaModificado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Impuesto
		{
			get { return _Impuesto; }
			set
			{
				ReportPropertyChanging("Impuesto");
				_Impuesto = value;
				ReportPropertyChanged("Impuesto");
			}
		}
		private String _Impuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Tasa
		{
			get { return _Tasa; }
			set
			{
				ReportPropertyChanging("Tasa");
				_Tasa = value;
				ReportPropertyChanged("Tasa");
			}
		}
		private Double _Tasa;


	}

	[EdmEntityTypeAttribute(Name = "Licencias")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Licencias : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String CodigoActivacion
		{
			get { return _CodigoActivacion; }
			set
			{
				ReportPropertyChanging("CodigoActivacion");
				_CodigoActivacion = value;
				ReportPropertyChanged("CodigoActivacion");
			}
		}
		private String _CodigoActivacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String CodigoRequerido
		{
			get { return _CodigoRequerido; }
			set
			{
				ReportPropertyChanging("CodigoRequerido");
				_CodigoRequerido = value;
				ReportPropertyChanged("CodigoRequerido");
			}
		}
		private String _CodigoRequerido;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String CodigoSerial
		{
			get { return _CodigoSerial; }
			set
			{
				ReportPropertyChanging("CodigoSerial");
				_CodigoSerial = value;
				ReportPropertyChanged("CodigoSerial");
			}
		}
		private String _CodigoSerial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esOnline
		{
			get { return _esOnline; }
			set
			{
				ReportPropertyChanging("esOnline");
				_esOnline = value;
				ReportPropertyChanged("esOnline");
			}
		}
		private Boolean? _esOnline;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String hdd_Serial
		{
			get { return _hdd_Serial; }
			set
			{
				ReportPropertyChanging("hdd_Serial");
				_hdd_Serial = value;
				ReportPropertyChanged("hdd_Serial");
			}
		}
		private String _hdd_Serial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String MotherBoard_Serial
		{
			get { return _MotherBoard_Serial; }
			set
			{
				ReportPropertyChanging("MotherBoard_Serial");
				_MotherBoard_Serial = value;
				ReportPropertyChanged("MotherBoard_Serial");
			}
		}
		private String _MotherBoard_Serial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NombreEquipo
		{
			get { return _NombreEquipo; }
			set
			{
				ReportPropertyChanging("NombreEquipo");
				_NombreEquipo = value;
				ReportPropertyChanged("NombreEquipo");
			}
		}
		private String _NombreEquipo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String SistemaOperativo
		{
			get { return _SistemaOperativo; }
			set
			{
				ReportPropertyChanging("SistemaOperativo");
				_SistemaOperativo = value;
				ReportPropertyChanged("SistemaOperativo");
			}
		}
		private String _SistemaOperativo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String SO_Version
		{
			get { return _SO_Version; }
			set
			{
				ReportPropertyChanging("SO_Version");
				_SO_Version = value;
				ReportPropertyChanged("SO_Version");
			}
		}
		private String _SO_Version;


	}

	[EdmEntityTypeAttribute(Name = "modulos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class modulos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _height
		{
			get { return __height; }
			set
			{
				ReportPropertyChanging("_height");
				__height = value;
				ReportPropertyChanged("_height");
			}
		}
		private Int64? __height;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _left
		{
			get { return __left; }
			set
			{
				ReportPropertyChanging("_left");
				__left = value;
				ReportPropertyChanged("_left");
			}
		}
		private Int64? __left;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? _modal
		{
			get { return __modal; }
			set
			{
				ReportPropertyChanging("_modal");
				__modal = value;
				ReportPropertyChanged("_modal");
			}
		}
		private Decimal? __modal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _startposition
		{
			get { return __startposition; }
			set
			{
				ReportPropertyChanging("_startposition");
				__startposition = value;
				ReportPropertyChanged("_startposition");
			}
		}
		private Int64? __startposition;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _top
		{
			get { return __top; }
			set
			{
				ReportPropertyChanging("_top");
				__top = value;
				ReportPropertyChanged("_top");
			}
		}
		private Int64? __top;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? _top_most
		{
			get { return __top_most; }
			set
			{
				ReportPropertyChanging("_top_most");
				__top_most = value;
				ReportPropertyChanged("_top_most");
			}
		}
		private Decimal? __top_most;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _width
		{
			get { return __width; }
			set
			{
				ReportPropertyChanging("_width");
				__width = value;
				ReportPropertyChanged("_width");
			}
		}
		private Int64? __width;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? _windowstate
		{
			get { return __windowstate; }
			set
			{
				ReportPropertyChanging("_windowstate");
				__windowstate = value;
				ReportPropertyChanged("_windowstate");
			}
		}
		private Int64? __windowstate;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_tema_modulo
		{
			get { return _id_tema_modulo; }
			set
			{
				ReportPropertyChanging("id_tema_modulo");
				_id_tema_modulo = value;
				ReportPropertyChanged("id_tema_modulo");
			}
		}
		private Int64? _id_tema_modulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String modulo
		{
			get { return _modulo; }
			set
			{
				ReportPropertyChanging("modulo");
				_modulo = value;
				ReportPropertyChanged("modulo");
			}
		}
		private String _modulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nombre_archivo
		{
			get { return _nombre_archivo; }
			set
			{
				ReportPropertyChanging("nombre_archivo");
				_nombre_archivo = value;
				ReportPropertyChanged("nombre_archivo");
			}
		}
		private String _nombre_archivo;


	}

	[EdmEntityTypeAttribute(Name = "Productos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cantidadUnidadVenta
		{
			get { return _cantidadUnidadVenta; }
			set
			{
				ReportPropertyChanging("cantidadUnidadVenta");
				_cantidadUnidadVenta = value;
				ReportPropertyChanged("cantidadUnidadVenta");
			}
		}
		private Double? _cantidadUnidadVenta;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String CodigoAdicional
		{
			get { return _CodigoAdicional; }
			set
			{
				ReportPropertyChanging("CodigoAdicional");
				_CodigoAdicional = value;
				ReportPropertyChanged("CodigoAdicional");
			}
		}
		private String _CodigoAdicional;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CodigoBarras
		{
			get { return _CodigoBarras; }
			set
			{
				ReportPropertyChanging("CodigoBarras");
				_CodigoBarras = value;
				ReportPropertyChanged("CodigoBarras");
			}
		}
		private String _CodigoBarras;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CodigoInterno
		{
			get { return _CodigoInterno; }
			set
			{
				ReportPropertyChanging("CodigoInterno");
				_CodigoInterno = value;
				ReportPropertyChanged("CodigoInterno");
			}
		}
		private String _CodigoInterno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCodigoAlterno
		{
			get { return _esCodigoAlterno; }
			set
			{
				ReportPropertyChanging("esCodigoAlterno");
				_esCodigoAlterno = value;
				ReportPropertyChanged("esCodigoAlterno");
			}
		}
		private Boolean? _esCodigoAlterno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCompuesto
		{
			get { return _esCompuesto; }
			set
			{
				ReportPropertyChanging("esCompuesto");
				_esCompuesto = value;
				ReportPropertyChanged("esCompuesto");
			}
		}
		private Boolean? _esCompuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esFavorito
		{
			get { return _esFavorito; }
			set
			{
				ReportPropertyChanging("esFavorito");
				_esFavorito = value;
				ReportPropertyChanged("esFavorito");
			}
		}
		private Boolean? _esFavorito;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esGarantia
		{
			get { return _esGarantia; }
			set
			{
				ReportPropertyChanging("esGarantia");
				_esGarantia = value;
				ReportPropertyChanged("esGarantia");
			}
		}
		private Boolean? _esGarantia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esImportado
		{
			get { return _esImportado; }
			set
			{
				ReportPropertyChanging("esImportado");
				_esImportado = value;
				ReportPropertyChanged("esImportado");
			}
		}
		private Boolean? _esImportado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esInventario
		{
			get { return _esInventario; }
			set
			{
				ReportPropertyChanging("esInventario");
				_esInventario = value;
				ReportPropertyChanged("esInventario");
			}
		}
		private Boolean? _esInventario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPideComentario
		{
			get { return _esPideComentario; }
			set
			{
				ReportPropertyChanging("esPideComentario");
				_esPideComentario = value;
				ReportPropertyChanged("esPideComentario");
			}
		}
		private Boolean? _esPideComentario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPidePeso
		{
			get { return _esPidePeso; }
			set
			{
				ReportPropertyChanging("esPidePeso");
				_esPidePeso = value;
				ReportPropertyChanged("esPidePeso");
			}
		}
		private Boolean? _esPidePeso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPidePrecio
		{
			get { return _esPidePrecio; }
			set
			{
				ReportPropertyChanging("esPidePrecio");
				_esPidePrecio = value;
				ReportPropertyChanged("esPidePrecio");
			}
		}
		private Boolean? _esPidePrecio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPideTipoProducto
		{
			get { return _esPideTipoProducto; }
			set
			{
				ReportPropertyChanging("esPideTipoProducto");
				_esPideTipoProducto = value;
				ReportPropertyChanged("esPideTipoProducto");
			}
		}
		private Boolean? _esPideTipoProducto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esUsoInterno
		{
			get { return _esUsoInterno; }
			set
			{
				ReportPropertyChanging("esUsoInterno");
				_esUsoInterno = value;
				ReportPropertyChanged("esUsoInterno");
			}
		}
		private Boolean? _esUsoInterno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaCreacion
		{
			get { return _FechaCreacion; }
			set
			{
				ReportPropertyChanging("FechaCreacion");
				_FechaCreacion = value;
				ReportPropertyChanged("FechaCreacion");
			}
		}
		private DateTime? _FechaCreacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaUltimaCompra
		{
			get { return _FechaUltimaCompra; }
			set
			{
				ReportPropertyChanging("FechaUltimaCompra");
				_FechaUltimaCompra = value;
				ReportPropertyChanged("FechaUltimaCompra");
			}
		}
		private DateTime? _FechaUltimaCompra;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaUltimaModificacion
		{
			get { return _FechaUltimaModificacion; }
			set
			{
				ReportPropertyChanging("FechaUltimaModificacion");
				_FechaUltimaModificacion = value;
				ReportPropertyChanged("FechaUltimaModificacion");
			}
		}
		private DateTime? _FechaUltimaModificacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaUltimaVenta
		{
			get { return _FechaUltimaVenta; }
			set
			{
				ReportPropertyChanging("FechaUltimaVenta");
				_FechaUltimaVenta = value;
				ReportPropertyChanged("FechaUltimaVenta");
			}
		}
		private DateTime? _FechaUltimaVenta;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_familiaProducto
		{
			get { return _id_familiaProducto; }
			set
			{
				ReportPropertyChanging("id_familiaProducto");
				_id_familiaProducto = value;
				ReportPropertyChanged("id_familiaProducto");
			}
		}
		private Int64 _id_familiaProducto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Marca
		{
			get { return _id_Marca; }
			set
			{
				ReportPropertyChanging("id_Marca");
				_id_Marca = value;
				ReportPropertyChanged("id_Marca");
			}
		}
		private Int64? _id_Marca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_unidadMedida
		{
			get { return _id_unidadMedida; }
			set
			{
				ReportPropertyChanging("id_unidadMedida");
				_id_unidadMedida = value;
				ReportPropertyChanged("id_unidadMedida");
			}
		}
		private Int64 _id_unidadMedida;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MargenGananciaPrecio1
		{
			get { return _MargenGananciaPrecio1; }
			set
			{
				ReportPropertyChanging("MargenGananciaPrecio1");
				_MargenGananciaPrecio1 = value;
				ReportPropertyChanged("MargenGananciaPrecio1");
			}
		}
		private Double? _MargenGananciaPrecio1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MargenGananciaPrecio2
		{
			get { return _MargenGananciaPrecio2; }
			set
			{
				ReportPropertyChanging("MargenGananciaPrecio2");
				_MargenGananciaPrecio2 = value;
				ReportPropertyChanged("MargenGananciaPrecio2");
			}
		}
		private Double? _MargenGananciaPrecio2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MargenGananciaPrecio3
		{
			get { return _MargenGananciaPrecio3; }
			set
			{
				ReportPropertyChanging("MargenGananciaPrecio3");
				_MargenGananciaPrecio3 = value;
				ReportPropertyChanged("MargenGananciaPrecio3");
			}
		}
		private Double? _MargenGananciaPrecio3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MedidaAlto
		{
			get { return _MedidaAlto; }
			set
			{
				ReportPropertyChanging("MedidaAlto");
				_MedidaAlto = value;
				ReportPropertyChanged("MedidaAlto");
			}
		}
		private Double? _MedidaAlto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MedidaAncho
		{
			get { return _MedidaAncho; }
			set
			{
				ReportPropertyChanging("MedidaAncho");
				_MedidaAncho = value;
				ReportPropertyChanged("MedidaAncho");
			}
		}
		private Double? _MedidaAncho;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MedidaLargo
		{
			get { return _MedidaLargo; }
			set
			{
				ReportPropertyChanging("MedidaLargo");
				_MedidaLargo = value;
				ReportPropertyChanged("MedidaLargo");
			}
		}
		private Double? _MedidaLargo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoCostoPromedio
		{
			get { return _MontoCostoPromedio; }
			set
			{
				ReportPropertyChanging("MontoCostoPromedio");
				_MontoCostoPromedio = value;
				ReportPropertyChanged("MontoCostoPromedio");
			}
		}
		private Double? _MontoCostoPromedio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoPrecio1
		{
			get { return _MontoPrecio1; }
			set
			{
				ReportPropertyChanging("MontoPrecio1");
				_MontoPrecio1 = value;
				ReportPropertyChanged("MontoPrecio1");
			}
		}
		private Double _MontoPrecio1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoPrecio2
		{
			get { return _MontoPrecio2; }
			set
			{
				ReportPropertyChanging("MontoPrecio2");
				_MontoPrecio2 = value;
				ReportPropertyChanged("MontoPrecio2");
			}
		}
		private Double? _MontoPrecio2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoPrecio3
		{
			get { return _MontoPrecio3; }
			set
			{
				ReportPropertyChanging("MontoPrecio3");
				_MontoPrecio3 = value;
				ReportPropertyChanged("MontoPrecio3");
			}
		}
		private Double? _MontoPrecio3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoUltimoCosto
		{
			get { return _MontoUltimoCosto; }
			set
			{
				ReportPropertyChanging("MontoUltimoCosto");
				_MontoUltimoCosto = value;
				ReportPropertyChanged("MontoUltimoCosto");
			}
		}
		private Double? _MontoUltimoCosto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nDiasGarantia
		{
			get { return _nDiasGarantia; }
			set
			{
				ReportPropertyChanging("nDiasGarantia");
				_nDiasGarantia = value;
				ReportPropertyChanged("nDiasGarantia");
			}
		}
		private Int64? _nDiasGarantia;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Producto
		{
			get { return _Producto; }
			set
			{
				ReportPropertyChanging("Producto");
				_Producto = value;
				ReportPropertyChanged("Producto");
			}
		}
		private String _Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Producto_DescripcionLarga
		{
			get { return _Producto_DescripcionLarga; }
			set
			{
				ReportPropertyChanging("Producto_DescripcionLarga");
				_Producto_DescripcionLarga = value;
				ReportPropertyChanged("Producto_DescripcionLarga");
			}
		}
		private String _Producto_DescripcionLarga;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Producto_LinkWeb
		{
			get { return _Producto_LinkWeb; }
			set
			{
				ReportPropertyChanging("Producto_LinkWeb");
				_Producto_LinkWeb = value;
				ReportPropertyChanged("Producto_LinkWeb");
			}
		}
		private String _Producto_LinkWeb;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Calzado")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Calzado : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCalzado
		{
			get { return _esCalzado; }
			set
			{
				ReportPropertyChanging("esCalzado");
				_esCalzado = value;
				ReportPropertyChanged("esCalzado");
			}
		}
		private Boolean? _esCalzado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esUsaColores
		{
			get { return _esUsaColores; }
			set
			{
				ReportPropertyChanging("esUsaColores");
				_esUsaColores = value;
				ReportPropertyChanged("esUsaColores");
			}
		}
		private Boolean? _esUsaColores;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esUsaTallas
		{
			get { return _esUsaTallas; }
			set
			{
				ReportPropertyChanging("esUsaTallas");
				_esUsaTallas = value;
				ReportPropertyChanged("esUsaTallas");
			}
		}
		private Boolean? _esUsaTallas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Lote
		{
			get { return _Id_Lote; }
			set
			{
				ReportPropertyChanging("Id_Lote");
				_Id_Lote = value;
				ReportPropertyChanged("Id_Lote");
			}
		}
		private Int64? _Id_Lote;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_producto
		{
			get { return _Id_producto; }
			set
			{
				ReportPropertyChanging("Id_producto");
				_Id_producto = value;
				ReportPropertyChanged("Id_producto");
			}
		}
		private Int64 _Id_producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "productos_Compuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class productos_Compuestos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double Cantidad
		{
			get { return _Cantidad; }
			set
			{
				ReportPropertyChanging("Cantidad");
				_Cantidad = value;
				ReportPropertyChanged("Cantidad");
			}
		}
		private Double _Cantidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Descripcion
		{
			get { return _Descripcion; }
			set
			{
				ReportPropertyChanging("Descripcion");
				_Descripcion = value;
				ReportPropertyChanged("Descripcion");
			}
		}
		private String _Descripcion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_producto
		{
			get { return _id_producto; }
			set
			{
				ReportPropertyChanging("id_producto");
				_id_producto = value;
				ReportPropertyChanged("id_producto");
			}
		}
		private Int64 _id_producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_unidadMedida
		{
			get { return _id_unidadMedida; }
			set
			{
				ReportPropertyChanging("id_unidadMedida");
				_id_unidadMedida = value;
				ReportPropertyChanged("id_unidadMedida");
			}
		}
		private Int64 _id_unidadMedida;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Familias")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Familias : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String FamiliaProducto
		{
			get { return _FamiliaProducto; }
			set
			{
				ReportPropertyChanging("FamiliaProducto");
				_FamiliaProducto = value;
				ReportPropertyChanged("FamiliaProducto");
			}
		}
		private String _FamiliaProducto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Farmacia")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Farmacia : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideRecipeMedico
		{
			get { return _esPideRecipeMedico; }
			set
			{
				ReportPropertyChanging("esPideRecipeMedico");
				_esPideRecipeMedico = value;
				ReportPropertyChanged("esPideRecipeMedico");
			}
		}
		private Boolean _esPideRecipeMedico;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaVencimiento
		{
			get { return _FechaVencimiento; }
			set
			{
				ReportPropertyChanging("FechaVencimiento");
				_FechaVencimiento = value;
				ReportPropertyChanged("FechaVencimiento");
			}
		}
		private DateTime? _FechaVencimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Lote
		{
			get { return _Id_Lote; }
			set
			{
				ReportPropertyChanging("Id_Lote");
				_Id_Lote = value;
				ReportPropertyChanged("Id_Lote");
			}
		}
		private Int64 _Id_Lote;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Producto
		{
			get { return _Id_Producto; }
			set
			{
				ReportPropertyChanging("Id_Producto");
				_Id_Producto = value;
				ReportPropertyChanged("Id_Producto");
			}
		}
		private Int64 _Id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_TipoRecipeMedico
		{
			get { return _Id_TipoRecipeMedico; }
			set
			{
				ReportPropertyChanging("Id_TipoRecipeMedico");
				_Id_TipoRecipeMedico = value;
				ReportPropertyChanged("Id_TipoRecipeMedico");
			}
		}
		private Int64 _Id_TipoRecipeMedico;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Impuestos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Impuesto
		{
			get { return _Id_Impuesto; }
			set
			{
				ReportPropertyChanging("Id_Impuesto");
				_Id_Impuesto = value;
				ReportPropertyChanged("Id_Impuesto");
			}
		}
		private Int64 _Id_Impuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Producto
		{
			get { return _Id_Producto; }
			set
			{
				ReportPropertyChanging("Id_Producto");
				_Id_Producto = value;
				ReportPropertyChanged("Id_Producto");
			}
		}
		private Int64 _Id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "tipoComercios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class tipoComercios : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String tipoComercio
		{
			get { return _tipoComercio; }
			set
			{
				ReportPropertyChanging("tipoComercio");
				_tipoComercio = value;
				ReportPropertyChanged("tipoComercio");
			}
		}
		private String _tipoComercio;


	}

	[EdmEntityTypeAttribute(Name = "TipoEgreso_Caja")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoEgreso_Caja : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esFiscal
		{
			get { return _esFiscal; }
			set
			{
				ReportPropertyChanging("esFiscal");
				_esFiscal = value;
				ReportPropertyChanged("esFiscal");
			}
		}
		private Boolean _esFiscal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esImprimeRecibo
		{
			get { return _esImprimeRecibo; }
			set
			{
				ReportPropertyChanging("esImprimeRecibo");
				_esImprimeRecibo = value;
				ReportPropertyChanged("esImprimeRecibo");
			}
		}
		private Boolean _esImprimeRecibo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideAutorizacion
		{
			get { return _esPideAutorizacion; }
			set
			{
				ReportPropertyChanging("esPideAutorizacion");
				_esPideAutorizacion = value;
				ReportPropertyChanged("esPideAutorizacion");
			}
		}
		private Boolean _esPideAutorizacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideComentario
		{
			get { return _esPideComentario; }
			set
			{
				ReportPropertyChanging("esPideComentario");
				_esPideComentario = value;
				ReportPropertyChanged("esPideComentario");
			}
		}
		private Boolean _esPideComentario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideID_asociado
		{
			get { return _esPideID_asociado; }
			set
			{
				ReportPropertyChanging("esPideID_asociado");
				_esPideID_asociado = value;
				ReportPropertyChanged("esPideID_asociado");
			}
		}
		private Boolean _esPideID_asociado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideNombreEntrega
		{
			get { return _esPideNombreEntrega; }
			set
			{
				ReportPropertyChanging("esPideNombreEntrega");
				_esPideNombreEntrega = value;
				ReportPropertyChanged("esPideNombreEntrega");
			}
		}
		private Boolean _esPideNombreEntrega;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideNombreRecibe
		{
			get { return _esPideNombreRecibe; }
			set
			{
				ReportPropertyChanging("esPideNombreRecibe");
				_esPideNombreRecibe = value;
				ReportPropertyChanged("esPideNombreRecibe");
			}
		}
		private Boolean _esPideNombreRecibe;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esPideNroDoc_Asociado
		{
			get { return _esPideNroDoc_Asociado; }
			set
			{
				ReportPropertyChanging("esPideNroDoc_Asociado");
				_esPideNroDoc_Asociado = value;
				ReportPropertyChanged("esPideNroDoc_Asociado");
			}
		}
		private Boolean _esPideNroDoc_Asociado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoMaximo
		{
			get { return _MontoMaximo; }
			set
			{
				ReportPropertyChanging("MontoMaximo");
				_MontoMaximo = value;
				ReportPropertyChanged("MontoMaximo");
			}
		}
		private Double _MontoMaximo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MontoMinimo
		{
			get { return _MontoMinimo; }
			set
			{
				ReportPropertyChanging("MontoMinimo");
				_MontoMinimo = value;
				ReportPropertyChanged("MontoMinimo");
			}
		}
		private Double _MontoMinimo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TablaAsociada
		{
			get { return _TablaAsociada; }
			set
			{
				ReportPropertyChanging("TablaAsociada");
				_TablaAsociada = value;
				ReportPropertyChanged("TablaAsociada");
			}
		}
		private String _TablaAsociada;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String TipoEgreso
		{
			get { return _TipoEgreso; }
			set
			{
				ReportPropertyChanging("TipoEgreso");
				_TipoEgreso = value;
				ReportPropertyChanged("TipoEgreso");
			}
		}
		private String _TipoEgreso;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Supermercado")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Supermercado : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Producto
		{
			get { return _Id_Producto; }
			set
			{
				ReportPropertyChanging("Id_Producto");
				_Id_Producto = value;
				ReportPropertyChanged("Id_Producto");
			}
		}
		private Int64 _Id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAlimento
		{
			get { return _esAlimento; }
			set
			{
				ReportPropertyChanging("esAlimento");
				_esAlimento = value;
				ReportPropertyChanged("esAlimento");
			}
		}
		private Boolean? _esAlimento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esPerecedero
		{
			get { return _esPerecedero; }
			set
			{
				ReportPropertyChanging("esPerecedero");
				_esPerecedero = value;
				ReportPropertyChanged("esPerecedero");
			}
		}
		private Boolean? _esPerecedero;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaVencimiento
		{
			get { return _FechaVencimiento; }
			set
			{
				ReportPropertyChanging("FechaVencimiento");
				_FechaVencimiento = value;
				ReportPropertyChanged("FechaVencimiento");
			}
		}
		private DateTime? _FechaVencimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esControlado
		{
			get { return _esControlado; }
			set
			{
				ReportPropertyChanging("esControlado");
				_esControlado = value;
				ReportPropertyChanged("esControlado");
			}
		}
		private Boolean? _esControlado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Marcas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Marcas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Marca
		{
			get { return _Marca; }
			set
			{
				ReportPropertyChanging("Marca");
				_Marca = value;
				ReportPropertyChanged("Marca");
			}
		}
		private String _Marca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Fabricante
		{
			get { return _Fabricante; }
			set
			{
				ReportPropertyChanging("Fabricante");
				_Fabricante = value;
				ReportPropertyChanged("Fabricante");
			}
		}
		private String _Fabricante;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DireccionWebFabricante
		{
			get { return _DireccionWebFabricante; }
			set
			{
				ReportPropertyChanging("DireccionWebFabricante");
				_DireccionWebFabricante = value;
				ReportPropertyChanged("DireccionWebFabricante");
			}
		}
		private String _DireccionWebFabricante;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "TipoPago")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoPago : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esBonoAlimentacion
		{
			get { return _esBonoAlimentacion; }
			set
			{
				ReportPropertyChanging("esBonoAlimentacion");
				_esBonoAlimentacion = value;
				ReportPropertyChanged("esBonoAlimentacion");
			}
		}
		private Boolean? _esBonoAlimentacion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCredito
		{
			get { return _esCredito; }
			set
			{
				ReportPropertyChanging("esCredito");
				_esCredito = value;
				ReportPropertyChanged("esCredito");
			}
		}
		private Boolean? _esCredito;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_TipoPago_Doc
		{
			get { return _id_TipoPago_Doc; }
			set
			{
				ReportPropertyChanging("id_TipoPago_Doc");
				_id_TipoPago_Doc = value;
				ReportPropertyChanged("id_TipoPago_Doc");
			}
		}
		private Int64 _id_TipoPago_Doc;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String ImagenArchivo
		{
			get { return _ImagenArchivo; }
			set
			{
				ReportPropertyChanging("ImagenArchivo");
				_ImagenArchivo = value;
				ReportPropertyChanged("ImagenArchivo");
			}
		}
		private String _ImagenArchivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? PorcentajeBanco
		{
			get { return _PorcentajeBanco; }
			set
			{
				ReportPropertyChanging("PorcentajeBanco");
				_PorcentajeBanco = value;
				ReportPropertyChanged("PorcentajeBanco");
			}
		}
		private Decimal? _PorcentajeBanco;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String tipoPago
		{
			get { return _tipoPago; }
			set
			{
				ReportPropertyChanging("tipoPago");
				_tipoPago = value;
				ReportPropertyChanged("tipoPago");
			}
		}
		private String _tipoPago;


	}

	[EdmEntityTypeAttribute(Name = "TipoPago_Doc")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoPago_Doc : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TipoPago_Doc_
		{
			get { return _TipoPago_Doc_; }
			set
			{
				ReportPropertyChanging("TipoPago_Doc_");
				_TipoPago_Doc_ = value;
				ReportPropertyChanged("TipoPago_Doc_");
			}
		}
		private String _TipoPago_Doc_;


	}

	[EdmEntityTypeAttribute(Name = "tipoProductos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class tipoProductos : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String tipoProducto
		{
			get { return _tipoProducto; }
			set
			{
				ReportPropertyChanging("tipoProducto");
				_tipoProducto = value;
				ReportPropertyChanged("tipoProducto");
			}
		}
		private String _tipoProducto;


	}

	[EdmEntityTypeAttribute(Name = "tipoServicio_Status")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class tipoServicio_Status : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Status
		{
			get { return _Status; }
			set
			{
				ReportPropertyChanging("Status");
				_Status = value;
				ReportPropertyChanged("Status");
			}
		}
		private String _Status;


	}

	[EdmEntityTypeAttribute(Name = "UnidadesMedida")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class UnidadesMedida : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CantidadPredeterminada
		{
			get { return _CantidadPredeterminada; }
			set
			{
				ReportPropertyChanging("CantidadPredeterminada");
				_CantidadPredeterminada = value;
				ReportPropertyChanged("CantidadPredeterminada");
			}
		}
		private Double _CantidadPredeterminada;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_UnidadMedidaUniversal
		{
			get { return _id_UnidadMedidaUniversal; }
			set
			{
				ReportPropertyChanging("id_UnidadMedidaUniversal");
				_id_UnidadMedidaUniversal = value;
				ReportPropertyChanged("id_UnidadMedidaUniversal");
			}
		}
		private Int64? _id_UnidadMedidaUniversal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String UnidadMedida
		{
			get { return _UnidadMedida; }
			set
			{
				ReportPropertyChanging("UnidadMedida");
				_UnidadMedida = value;
				ReportPropertyChanged("UnidadMedida");
			}
		}
		private String _UnidadMedida;


	}

	[EdmEntityTypeAttribute(Name = "usuarios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class usuarios : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esCaduca
		{
			get { return _esCaduca; }
			set
			{
				ReportPropertyChanging("esCaduca");
				_esCaduca = value;
				ReportPropertyChanged("esCaduca");
			}
		}
		private Boolean? _esCaduca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esLogged
		{
			get { return _esLogged; }
			set
			{
				ReportPropertyChanging("esLogged");
				_esLogged = value;
				ReportPropertyChanged("esLogged");
			}
		}
		private Boolean? _esLogged;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fecha_caduca
		{
			get { return _fecha_caduca; }
			set
			{
				ReportPropertyChanging("fecha_caduca");
				_fecha_caduca = value;
				ReportPropertyChanged("fecha_caduca");
			}
		}
		private DateTime? _fecha_caduca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fecha_fin
		{
			get { return _fecha_fin; }
			set
			{
				ReportPropertyChanging("fecha_fin");
				_fecha_fin = value;
				ReportPropertyChanged("fecha_fin");
			}
		}
		private DateTime? _fecha_fin;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fecha_inicio
		{
			get { return _fecha_inicio; }
			set
			{
				ReportPropertyChanging("fecha_inicio");
				_fecha_inicio = value;
				ReportPropertyChanged("fecha_inicio");
			}
		}
		private DateTime? _fecha_inicio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Empleado
		{
			get { return _id_Empleado; }
			set
			{
				ReportPropertyChanging("id_Empleado");
				_id_Empleado = value;
				ReportPropertyChanged("id_Empleado");
			}
		}
		private Int64? _id_Empleado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_grupo_usuario
		{
			get { return _id_grupo_usuario; }
			set
			{
				ReportPropertyChanging("id_grupo_usuario");
				_id_grupo_usuario = value;
				ReportPropertyChanged("id_grupo_usuario");
			}
		}
		private Int64 _id_grupo_usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_nivelAcceso
		{
			get { return _id_nivelAcceso; }
			set
			{
				ReportPropertyChanging("id_nivelAcceso");
				_id_nivelAcceso = value;
				ReportPropertyChanged("id_nivelAcceso");
			}
		}
		private Int64 _id_nivelAcceso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String password
		{
			get { return _password; }
			set
			{
				ReportPropertyChanging("password");
				_password = value;
				ReportPropertyChanged("password");
			}
		}
		private String _password;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String usuario
		{
			get { return _usuario; }
			set
			{
				ReportPropertyChanging("usuario");
				_usuario = value;
				ReportPropertyChanged("usuario");
			}
		}
		private String _usuario;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Club : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Producto
		{
			get { return _Id_Producto; }
			set
			{
				ReportPropertyChanging("Id_Producto");
				_Id_Producto = value;
				ReportPropertyChanged("Id_Producto");
			}
		}
		private Int64 _Id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? idDefTipoPrograma
		{
			get { return _idDefTipoPrograma; }
			set
			{
				ReportPropertyChanging("idDefTipoPrograma");
				_idDefTipoPrograma = value;
				ReportPropertyChanged("idDefTipoPrograma");
			}
		}
		private Int64? _idDefTipoPrograma;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private DateTime? _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaInicio
		{
			get { return _FechaInicio; }
			set
			{
				ReportPropertyChanging("FechaInicio");
				_FechaInicio = value;
				ReportPropertyChanged("FechaInicio");
			}
		}
		private DateTime? _FechaInicio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaVencimiento
		{
			get { return _FechaVencimiento; }
			set
			{
				ReportPropertyChanging("FechaVencimiento");
				_FechaVencimiento = value;
				ReportPropertyChanged("FechaVencimiento");
			}
		}
		private DateTime? _FechaVencimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? diasPreVencimiento
		{
			get { return _diasPreVencimiento; }
			set
			{
				ReportPropertyChanging("diasPreVencimiento");
				_diasPreVencimiento = value;
				ReportPropertyChanged("diasPreVencimiento");
			}
		}
		private Int64? _diasPreVencimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? diasPostvencimiento
		{
			get { return _diasPostvencimiento; }
			set
			{
				ReportPropertyChanging("diasPostvencimiento");
				_diasPostvencimiento = value;
				ReportPropertyChanged("diasPostvencimiento");
			}
		}
		private Int64? _diasPostvencimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nroVisitas
		{
			get { return _nroVisitas; }
			set
			{
				ReportPropertyChanging("nroVisitas");
				_nroVisitas = value;
				ReportPropertyChanged("nroVisitas");
			}
		}
		private Int64? _nroVisitas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? minVisitantes
		{
			get { return _minVisitantes; }
			set
			{
				ReportPropertyChanging("minVisitantes");
				_minVisitantes = value;
				ReportPropertyChanged("minVisitantes");
			}
		}
		private Int64? _minVisitantes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? maxVisitantes
		{
			get { return _maxVisitantes; }
			set
			{
				ReportPropertyChanging("maxVisitantes");
				_maxVisitantes = value;
				ReportPropertyChanged("maxVisitantes");
			}
		}
		private Int64? _maxVisitantes;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "Empleados_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empleados_Club : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CodigoBarras
		{
			get { return _CodigoBarras; }
			set
			{
				ReportPropertyChanging("CodigoBarras");
				_CodigoBarras = value;
				ReportPropertyChanged("CodigoBarras");
			}
		}
		private String _CodigoBarras;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Emerg1
		{
			get { return _Telefono_Emerg1; }
			set
			{
				ReportPropertyChanging("Telefono_Emerg1");
				_Telefono_Emerg1 = value;
				ReportPropertyChanged("Telefono_Emerg1");
			}
		}
		private String _Telefono_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TelefonoTrabajo_Emerg1
		{
			get { return _TelefonoTrabajo_Emerg1; }
			set
			{
				ReportPropertyChanging("TelefonoTrabajo_Emerg1");
				_TelefonoTrabajo_Emerg1 = value;
				ReportPropertyChanged("TelefonoTrabajo_Emerg1");
			}
		}
		private String _TelefonoTrabajo_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Direccion_Emerg1
		{
			get { return _Direccion_Emerg1; }
			set
			{
				ReportPropertyChanging("Direccion_Emerg1");
				_Direccion_Emerg1 = value;
				ReportPropertyChanged("Direccion_Emerg1");
			}
		}
		private String _Direccion_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Contacto_Emerg2
		{
			get { return _Contacto_Emerg2; }
			set
			{
				ReportPropertyChanging("Contacto_Emerg2");
				_Contacto_Emerg2 = value;
				ReportPropertyChanged("Contacto_Emerg2");
			}
		}
		private String _Contacto_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Emerg2
		{
			get { return _Telefono_Emerg2; }
			set
			{
				ReportPropertyChanging("Telefono_Emerg2");
				_Telefono_Emerg2 = value;
				ReportPropertyChanged("Telefono_Emerg2");
			}
		}
		private String _Telefono_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TelefonoTrabajo_Emerg2
		{
			get { return _TelefonoTrabajo_Emerg2; }
			set
			{
				ReportPropertyChanging("TelefonoTrabajo_Emerg2");
				_TelefonoTrabajo_Emerg2 = value;
				ReportPropertyChanged("TelefonoTrabajo_Emerg2");
			}
		}
		private String _TelefonoTrabajo_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Direccion_Emerg2
		{
			get { return _Direccion_Emerg2; }
			set
			{
				ReportPropertyChanging("Direccion_Emerg2");
				_Direccion_Emerg2 = value;
				ReportPropertyChanged("Direccion_Emerg2");
			}
		}
		private String _Direccion_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Contacto_Emerg1
		{
			get { return _Contacto_Emerg1; }
			set
			{
				ReportPropertyChanging("Contacto_Emerg1");
				_Contacto_Emerg1 = value;
				ReportPropertyChanged("Contacto_Emerg1");
			}
		}
		private String _Contacto_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? Id_Banco
		{
			get { return _Id_Banco; }
			set
			{
				ReportPropertyChanging("Id_Banco");
				_Id_Banco = value;
				ReportPropertyChanged("Id_Banco");
			}
		}
		private Int64? _Id_Banco;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroTarjetaCredito
		{
			get { return _nroTarjetaCredito; }
			set
			{
				ReportPropertyChanging("nroTarjetaCredito");
				_nroTarjetaCredito = value;
				ReportPropertyChanged("nroTarjetaCredito");
			}
		}
		private String _nroTarjetaCredito;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Condicion_Medica
		{
			get { return _Condicion_Medica; }
			set
			{
				ReportPropertyChanging("Condicion_Medica");
				_Condicion_Medica = value;
				ReportPropertyChanged("Condicion_Medica");
			}
		}
		private String _Condicion_Medica;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nombre_Medico
		{
			get { return _Nombre_Medico; }
			set
			{
				ReportPropertyChanging("Nombre_Medico");
				_Nombre_Medico = value;
				ReportPropertyChanged("Nombre_Medico");
			}
		}
		private String _Nombre_Medico;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Medico
		{
			get { return _Telefono_Medico; }
			set
			{
				ReportPropertyChanging("Telefono_Medico");
				_Telefono_Medico = value;
				ReportPropertyChanged("Telefono_Medico");
			}
		}
		private String _Telefono_Medico;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nota
		{
			get { return _Nota; }
			set
			{
				ReportPropertyChanging("Nota");
				_Nota = value;
				ReportPropertyChanged("Nota");
			}
		}
		private String _Nota;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Foto_Archivo
		{
			get { return _Foto_Archivo; }
			set
			{
				ReportPropertyChanging("Foto_Archivo");
				_Foto_Archivo = value;
				ReportPropertyChanged("Foto_Archivo");
			}
		}
		private String _Foto_Archivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? idDefTipoPersonal
		{
			get { return _idDefTipoPersonal; }
			set
			{
				ReportPropertyChanging("idDefTipoPersonal");
				_idDefTipoPersonal = value;
				ReportPropertyChanged("idDefTipoPersonal");
			}
		}
		private Int64? _idDefTipoPersonal;


	}

	[EdmEntityTypeAttribute(Name = "Areas_Comunes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Areas_Comunes : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String AreaComun
		{
			get { return _AreaComun; }
			set
			{
				ReportPropertyChanging("AreaComun");
				_AreaComun = value;
				ReportPropertyChanged("AreaComun");
			}
		}
		private String _AreaComun;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;


	}

	[EdmEntityTypeAttribute(Name = "usuarios_detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class usuarios_detalle : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Descripcion
		{
			get { return _Descripcion; }
			set
			{
				ReportPropertyChanging("Descripcion");
				_Descripcion = value;
				ReportPropertyChanged("Descripcion");
			}
		}
		private String _Descripcion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean esLogeado
		{
			get { return _esLogeado; }
			set
			{
				ReportPropertyChanging("esLogeado");
				_esLogeado = value;
				ReportPropertyChanged("esLogeado");
			}
		}
		private Boolean _esLogeado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_login
		{
			get { return _Fecha_login; }
			set
			{
				ReportPropertyChanging("Fecha_login");
				_Fecha_login = value;
				ReportPropertyChanged("Fecha_login");
			}
		}
		private DateTime? _Fecha_login;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_UltimoAcceso
		{
			get { return _Fecha_UltimoAcceso; }
			set
			{
				ReportPropertyChanging("Fecha_UltimoAcceso");
				_Fecha_UltimoAcceso = value;
				ReportPropertyChanged("Fecha_UltimoAcceso");
			}
		}
		private DateTime? _Fecha_UltimoAcceso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_modulo
		{
			get { return _id_modulo; }
			set
			{
				ReportPropertyChanging("id_modulo");
				_id_modulo = value;
				ReportPropertyChanged("id_modulo");
			}
		}
		private Int64 _id_modulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_usuario
		{
			get { return _id_usuario; }
			set
			{
				ReportPropertyChanging("id_usuario");
				_id_usuario = value;
				ReportPropertyChanged("id_usuario");
			}
		}
		private Int64 _id_usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_UsuarioOperacion
		{
			get { return _id_UsuarioOperacion; }
			set
			{
				ReportPropertyChanging("id_UsuarioOperacion");
				_id_UsuarioOperacion = value;
				ReportPropertyChanged("id_UsuarioOperacion");
			}
		}
		private Int64 _id_UsuarioOperacion;


	}

	[EdmEntityTypeAttribute(Name = "Usuarios_Grupo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios_Grupo : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAccesoremoto
		{
			get { return _esAccesoremoto; }
			set
			{
				ReportPropertyChanging("esAccesoremoto");
				_esAccesoremoto = value;
				ReportPropertyChanged("esAccesoremoto");
			}
		}
		private Boolean? _esAccesoremoto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAgregar
		{
			get { return _esAgregar; }
			set
			{
				ReportPropertyChanging("esAgregar");
				_esAgregar = value;
				ReportPropertyChanged("esAgregar");
			}
		}
		private Boolean? _esAgregar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEliminar
		{
			get { return _esEliminar; }
			set
			{
				ReportPropertyChanging("esEliminar");
				_esEliminar = value;
				ReportPropertyChanged("esEliminar");
			}
		}
		private Boolean? _esEliminar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esListar
		{
			get { return _esListar; }
			set
			{
				ReportPropertyChanging("esListar");
				_esListar = value;
				ReportPropertyChanged("esListar");
			}
		}
		private Boolean? _esListar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esModificar
		{
			get { return _esModificar; }
			set
			{
				ReportPropertyChanging("esModificar");
				_esModificar = value;
				ReportPropertyChanged("esModificar");
			}
		}
		private Boolean? _esModificar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esroot
		{
			get { return _esroot; }
			set
			{
				ReportPropertyChanging("esroot");
				_esroot = value;
				ReportPropertyChanged("esroot");
			}
		}
		private Boolean? _esroot;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String grupo_usuario
		{
			get { return _grupo_usuario; }
			set
			{
				ReportPropertyChanging("grupo_usuario");
				_grupo_usuario = value;
				ReportPropertyChanged("grupo_usuario");
			}
		}
		private String _grupo_usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_enuTipoUsuarioNivel
		{
			get { return _id_enuTipoUsuarioNivel; }
			set
			{
				ReportPropertyChanging("id_enuTipoUsuarioNivel");
				_id_enuTipoUsuarioNivel = value;
				ReportPropertyChanged("id_enuTipoUsuarioNivel");
			}
		}
		private Int64? _id_enuTipoUsuarioNivel;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "usuarios_roles")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class usuarios_roles : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAccesoremoto
		{
			get { return _esAccesoremoto; }
			set
			{
				ReportPropertyChanging("esAccesoremoto");
				_esAccesoremoto = value;
				ReportPropertyChanged("esAccesoremoto");
			}
		}
		private Boolean? _esAccesoremoto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAgregar
		{
			get { return _esAgregar; }
			set
			{
				ReportPropertyChanging("esAgregar");
				_esAgregar = value;
				ReportPropertyChanged("esAgregar");
			}
		}
		private Boolean? _esAgregar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEliminar
		{
			get { return _esEliminar; }
			set
			{
				ReportPropertyChanging("esEliminar");
				_esEliminar = value;
				ReportPropertyChanged("esEliminar");
			}
		}
		private Boolean? _esEliminar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esModificar
		{
			get { return _esModificar; }
			set
			{
				ReportPropertyChanging("esModificar");
				_esModificar = value;
				ReportPropertyChanged("esModificar");
			}
		}
		private Boolean? _esModificar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_usuario
		{
			get { return _id_usuario; }
			set
			{
				ReportPropertyChanging("id_usuario");
				_id_usuario = value;
				ReportPropertyChanged("id_usuario");
			}
		}
		private Int64? _id_usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "usuarios_rolesModulo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class usuarios_rolesModulo : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String control_tag
		{
			get { return _control_tag; }
			set
			{
				ReportPropertyChanging("control_tag");
				_control_tag = value;
				ReportPropertyChanged("control_tag");
			}
		}
		private String _control_tag;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Decimal? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esAgregar
		{
			get { return _esAgregar; }
			set
			{
				ReportPropertyChanging("esAgregar");
				_esAgregar = value;
				ReportPropertyChanged("esAgregar");
			}
		}
		private Decimal? _esAgregar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esConsultar
		{
			get { return _esConsultar; }
			set
			{
				ReportPropertyChanging("esConsultar");
				_esConsultar = value;
				ReportPropertyChanged("esConsultar");
			}
		}
		private Decimal? _esConsultar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esEliminar
		{
			get { return _esEliminar; }
			set
			{
				ReportPropertyChanging("esEliminar");
				_esEliminar = value;
				ReportPropertyChanged("esEliminar");
			}
		}
		private Decimal? _esEliminar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esEnabled
		{
			get { return _esEnabled; }
			set
			{
				ReportPropertyChanging("esEnabled");
				_esEnabled = value;
				ReportPropertyChanged("esEnabled");
			}
		}
		private Decimal? _esEnabled;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esModificar
		{
			get { return _esModificar; }
			set
			{
				ReportPropertyChanging("esModificar");
				_esModificar = value;
				ReportPropertyChanged("esModificar");
			}
		}
		private Decimal? _esModificar;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? esVisible
		{
			get { return _esVisible; }
			set
			{
				ReportPropertyChanging("esVisible");
				_esVisible = value;
				ReportPropertyChanged("esVisible");
			}
		}
		private Decimal? _esVisible;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_modulo
		{
			get { return _id_modulo; }
			set
			{
				ReportPropertyChanging("id_modulo");
				_id_modulo = value;
				ReportPropertyChanged("id_modulo");
			}
		}
		private Int64 _id_modulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_usuario
		{
			get { return _id_usuario; }
			set
			{
				ReportPropertyChanging("id_usuario");
				_id_usuario = value;
				ReportPropertyChanged("id_usuario");
			}
		}
		private Int64 _id_usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "ven_municipios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class ven_municipios : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_estado
		{
			get { return _id_estado; }
			set
			{
				ReportPropertyChanging("id_estado");
				_id_estado = value;
				ReportPropertyChanged("id_estado");
			}
		}
		private Int64? _id_estado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String municipio
		{
			get { return _municipio; }
			set
			{
				ReportPropertyChanging("municipio");
				_municipio = value;
				ReportPropertyChanged("municipio");
			}
		}
		private String _municipio;


	}

	[EdmEntityTypeAttribute(Name = "ven_parroquias")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class ven_parroquias : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_municipio
		{
			get { return _id_municipio; }
			set
			{
				ReportPropertyChanging("id_municipio");
				_id_municipio = value;
				ReportPropertyChanged("id_municipio");
			}
		}
		private Int64 _id_municipio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parroquia
		{
			get { return _parroquia; }
			set
			{
				ReportPropertyChanging("parroquia");
				_parroquia = value;
				ReportPropertyChanged("parroquia");
			}
		}
		private String _parroquia;


	}

	[EdmEntityTypeAttribute(Name = "world_localidades")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_localidades : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? exacto
		{
			get { return _exacto; }
			set
			{
				ReportPropertyChanging("exacto");
				_exacto = value;
				ReportPropertyChanged("exacto");
			}
		}
		private Boolean? _exacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_idioma
		{
			get { return _id_idioma; }
			set
			{
				ReportPropertyChanging("id_idioma");
				_id_idioma = value;
				ReportPropertyChanged("id_idioma");
			}
		}
		private Int64 _id_idioma;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_pais
		{
			get { return _id_pais; }
			set
			{
				ReportPropertyChanging("id_pais");
				_id_pais = value;
				ReportPropertyChanged("id_pais");
			}
		}
		private Int64 _id_pais;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_region
		{
			get { return _id_region; }
			set
			{
				ReportPropertyChanging("id_region");
				_id_region = value;
				ReportPropertyChanged("id_region");
			}
		}
		private Int64 _id_region;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Localidad
		{
			get { return _Localidad; }
			set
			{
				ReportPropertyChanging("Localidad");
				_Localidad = value;
				ReportPropertyChanged("Localidad");
			}
		}
		private String _Localidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double x
		{
			get { return _x; }
			set
			{
				ReportPropertyChanging("x");
				_x = value;
				ReportPropertyChanged("x");
			}
		}
		private Double _x;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double y
		{
			get { return _y; }
			set
			{
				ReportPropertyChanging("y");
				_y = value;
				ReportPropertyChanged("y");
			}
		}
		private Double _y;


	}

	[EdmEntityTypeAttribute(Name = "World_UnidadesMedida")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class World_UnidadesMedida : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String UnidadMedida
		{
			get { return _UnidadMedida; }
			set
			{
				ReportPropertyChanging("UnidadMedida");
				_UnidadMedida = value;
				ReportPropertyChanged("UnidadMedida");
			}
		}
		private String _UnidadMedida;


	}

	[EdmEntityTypeAttribute(Name = "world_profesiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_profesiones : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Profesiones
		{
			get { return _Profesiones; }
			set
			{
				ReportPropertyChanging("Profesiones");
				_Profesiones = value;
				ReportPropertyChanged("Profesiones");
			}
		}
		private String _Profesiones;


	}

	[EdmEntityTypeAttribute(Name = "Registros_Visitas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Registros_Visitas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEntrada
		{
			get { return _esEntrada; }
			set
			{
				ReportPropertyChanging("esEntrada");
				_esEntrada = value;
				ReportPropertyChanged("esEntrada");
			}
		}
		private Boolean? _esEntrada;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaIngreso
		{
			get { return _FechaIngreso; }
			set
			{
				ReportPropertyChanging("FechaIngreso");
				_FechaIngreso = value;
				ReportPropertyChanged("FechaIngreso");
			}
		}
		private DateTime? _FechaIngreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaSalida
		{
			get { return _FechaSalida; }
			set
			{
				ReportPropertyChanging("FechaSalida");
				_FechaSalida = value;
				ReportPropertyChanged("FechaSalida");
			}
		}
		private DateTime? _FechaSalida;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Cliente
		{
			get { return _Id_Cliente; }
			set
			{
				ReportPropertyChanging("Id_Cliente");
				_Id_Cliente = value;
				ReportPropertyChanged("Id_Cliente");
			}
		}
		private Int64 _Id_Cliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Estaciones_Sesion
		{
			get { return _id_Estaciones_Sesion; }
			set
			{
				ReportPropertyChanging("id_Estaciones_Sesion");
				_id_Estaciones_Sesion = value;
				ReportPropertyChanged("id_Estaciones_Sesion");
			}
		}
		private Int64 _id_Estaciones_Sesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nota
		{
			get { return _Nota; }
			set
			{
				ReportPropertyChanging("Nota");
				_Nota = value;
				ReportPropertyChanged("Nota");
			}
		}
		private String _Nota;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Foto_Archivo
		{
			get { return _Foto_Archivo; }
			set
			{
				ReportPropertyChanging("Foto_Archivo");
				_Foto_Archivo = value;
				ReportPropertyChanged("Foto_Archivo");
			}
		}
		private String _Foto_Archivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;


	}

	[EdmEntityTypeAttribute(Name = "Clientes_Medidas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Medidas : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? espalda
		{
			get { return _espalda; }
			set
			{
				ReportPropertyChanging("espalda");
				_espalda = value;
				ReportPropertyChanged("espalda");
			}
		}
		private Double? _espalda;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? busto
		{
			get { return _busto; }
			set
			{
				ReportPropertyChanging("busto");
				_busto = value;
				ReportPropertyChanged("busto");
			}
		}
		private Double? _busto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? brazo
		{
			get { return _brazo; }
			set
			{
				ReportPropertyChanging("brazo");
				_brazo = value;
				ReportPropertyChanged("brazo");
			}
		}
		private Double? _brazo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? pecho
		{
			get { return _pecho; }
			set
			{
				ReportPropertyChanging("pecho");
				_pecho = value;
				ReportPropertyChanged("pecho");
			}
		}
		private Double? _pecho;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cintura
		{
			get { return _cintura; }
			set
			{
				ReportPropertyChanging("cintura");
				_cintura = value;
				ReportPropertyChanged("cintura");
			}
		}
		private Double? _cintura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? caderas
		{
			get { return _caderas; }
			set
			{
				ReportPropertyChanging("caderas");
				_caderas = value;
				ReportPropertyChanged("caderas");
			}
		}
		private Double? _caderas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? gluteos
		{
			get { return _gluteos; }
			set
			{
				ReportPropertyChanging("gluteos");
				_gluteos = value;
				ReportPropertyChanged("gluteos");
			}
		}
		private Double? _gluteos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? muslo_superior
		{
			get { return _muslo_superior; }
			set
			{
				ReportPropertyChanging("muslo_superior");
				_muslo_superior = value;
				ReportPropertyChanged("muslo_superior");
			}
		}
		private Double? _muslo_superior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? muslo_medio
		{
			get { return _muslo_medio; }
			set
			{
				ReportPropertyChanging("muslo_medio");
				_muslo_medio = value;
				ReportPropertyChanged("muslo_medio");
			}
		}
		private Double? _muslo_medio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? pantorrilla
		{
			get { return _pantorrilla; }
			set
			{
				ReportPropertyChanging("pantorrilla");
				_pantorrilla = value;
				ReportPropertyChanged("pantorrilla");
			}
		}
		private Double? _pantorrilla;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? biceps
		{
			get { return _biceps; }
			set
			{
				ReportPropertyChanging("biceps");
				_biceps = value;
				ReportPropertyChanged("biceps");
			}
		}
		private Double? _biceps;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? triceps
		{
			get { return _triceps; }
			set
			{
				ReportPropertyChanging("triceps");
				_triceps = value;
				ReportPropertyChanged("triceps");
			}
		}
		private Double? _triceps;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? subescapular
		{
			get { return _subescapular; }
			set
			{
				ReportPropertyChanging("subescapular");
				_subescapular = value;
				ReportPropertyChanged("subescapular");
			}
		}
		private Double? _subescapular;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cresta_iliaca
		{
			get { return _cresta_iliaca; }
			set
			{
				ReportPropertyChanging("cresta_iliaca");
				_cresta_iliaca = value;
				ReportPropertyChanged("cresta_iliaca");
			}
		}
		private Double? _cresta_iliaca;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cuerpo_rapido
		{
			get { return _cuerpo_rapido; }
			set
			{
				ReportPropertyChanging("cuerpo_rapido");
				_cuerpo_rapido = value;
				ReportPropertyChanged("cuerpo_rapido");
			}
		}
		private Double? _cuerpo_rapido;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? masa_grasa
		{
			get { return _masa_grasa; }
			set
			{
				ReportPropertyChanging("masa_grasa");
				_masa_grasa = value;
				ReportPropertyChanged("masa_grasa");
			}
		}
		private Double? _masa_grasa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? masa_magra
		{
			get { return _masa_magra; }
			set
			{
				ReportPropertyChanging("masa_magra");
				_masa_magra = value;
				ReportPropertyChanged("masa_magra");
			}
		}
		private Double? _masa_magra;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? indice_masa_corporal
		{
			get { return _indice_masa_corporal; }
			set
			{
				ReportPropertyChanging("indice_masa_corporal");
				_indice_masa_corporal = value;
				ReportPropertyChanged("indice_masa_corporal");
			}
		}
		private Double? _indice_masa_corporal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? consumo_maximo_oxigeno
		{
			get { return _consumo_maximo_oxigeno; }
			set
			{
				ReportPropertyChanging("consumo_maximo_oxigeno");
				_consumo_maximo_oxigeno = value;
				ReportPropertyChanged("consumo_maximo_oxigeno");
			}
		}
		private Double? _consumo_maximo_oxigeno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? espalda_check
		{
			get { return _espalda_check; }
			set
			{
				ReportPropertyChanging("espalda_check");
				_espalda_check = value;
				ReportPropertyChanged("espalda_check");
			}
		}
		private Boolean? _espalda_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? busto_check
		{
			get { return _busto_check; }
			set
			{
				ReportPropertyChanging("busto_check");
				_busto_check = value;
				ReportPropertyChanged("busto_check");
			}
		}
		private Boolean? _busto_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? brazo_check
		{
			get { return _brazo_check; }
			set
			{
				ReportPropertyChanging("brazo_check");
				_brazo_check = value;
				ReportPropertyChanged("brazo_check");
			}
		}
		private Boolean? _brazo_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? pecho_check
		{
			get { return _pecho_check; }
			set
			{
				ReportPropertyChanging("pecho_check");
				_pecho_check = value;
				ReportPropertyChanged("pecho_check");
			}
		}
		private Boolean? _pecho_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? cintura_check
		{
			get { return _cintura_check; }
			set
			{
				ReportPropertyChanging("cintura_check");
				_cintura_check = value;
				ReportPropertyChanged("cintura_check");
			}
		}
		private Boolean? _cintura_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? caderas_check
		{
			get { return _caderas_check; }
			set
			{
				ReportPropertyChanging("caderas_check");
				_caderas_check = value;
				ReportPropertyChanged("caderas_check");
			}
		}
		private Boolean? _caderas_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? gluteos_check
		{
			get { return _gluteos_check; }
			set
			{
				ReportPropertyChanging("gluteos_check");
				_gluteos_check = value;
				ReportPropertyChanged("gluteos_check");
			}
		}
		private Boolean? _gluteos_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? muslo_superior_check
		{
			get { return _muslo_superior_check; }
			set
			{
				ReportPropertyChanging("muslo_superior_check");
				_muslo_superior_check = value;
				ReportPropertyChanged("muslo_superior_check");
			}
		}
		private Boolean? _muslo_superior_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? muslo_medio_check
		{
			get { return _muslo_medio_check; }
			set
			{
				ReportPropertyChanging("muslo_medio_check");
				_muslo_medio_check = value;
				ReportPropertyChanged("muslo_medio_check");
			}
		}
		private Boolean? _muslo_medio_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? pantorrilla_check
		{
			get { return _pantorrilla_check; }
			set
			{
				ReportPropertyChanging("pantorrilla_check");
				_pantorrilla_check = value;
				ReportPropertyChanged("pantorrilla_check");
			}
		}
		private Boolean? _pantorrilla_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? biceps_check
		{
			get { return _biceps_check; }
			set
			{
				ReportPropertyChanging("biceps_check");
				_biceps_check = value;
				ReportPropertyChanged("biceps_check");
			}
		}
		private Boolean? _biceps_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? triceps_check
		{
			get { return _triceps_check; }
			set
			{
				ReportPropertyChanging("triceps_check");
				_triceps_check = value;
				ReportPropertyChanged("triceps_check");
			}
		}
		private Boolean? _triceps_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? subescapular_check
		{
			get { return _subescapular_check; }
			set
			{
				ReportPropertyChanging("subescapular_check");
				_subescapular_check = value;
				ReportPropertyChanged("subescapular_check");
			}
		}
		private Boolean? _subescapular_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? cresta_iliaca_check
		{
			get { return _cresta_iliaca_check; }
			set
			{
				ReportPropertyChanging("cresta_iliaca_check");
				_cresta_iliaca_check = value;
				ReportPropertyChanged("cresta_iliaca_check");
			}
		}
		private Boolean? _cresta_iliaca_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? cuerpo_rapido_check
		{
			get { return _cuerpo_rapido_check; }
			set
			{
				ReportPropertyChanging("cuerpo_rapido_check");
				_cuerpo_rapido_check = value;
				ReportPropertyChanged("cuerpo_rapido_check");
			}
		}
		private Boolean? _cuerpo_rapido_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? masa_grasa_check
		{
			get { return _masa_grasa_check; }
			set
			{
				ReportPropertyChanging("masa_grasa_check");
				_masa_grasa_check = value;
				ReportPropertyChanged("masa_grasa_check");
			}
		}
		private Boolean? _masa_grasa_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? masa_magra_check
		{
			get { return _masa_magra_check; }
			set
			{
				ReportPropertyChanging("masa_magra_check");
				_masa_magra_check = value;
				ReportPropertyChanged("masa_magra_check");
			}
		}
		private Boolean? _masa_magra_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? indice_masa_corporal_check
		{
			get { return _indice_masa_corporal_check; }
			set
			{
				ReportPropertyChanging("indice_masa_corporal_check");
				_indice_masa_corporal_check = value;
				ReportPropertyChanged("indice_masa_corporal_check");
			}
		}
		private Boolean? _indice_masa_corporal_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? consumo_maximo_oxigeno_check
		{
			get { return _consumo_maximo_oxigeno_check; }
			set
			{
				ReportPropertyChanging("consumo_maximo_oxigeno_check");
				_consumo_maximo_oxigeno_check = value;
				ReportPropertyChanged("consumo_maximo_oxigeno_check");
			}
		}
		private Boolean? _consumo_maximo_oxigeno_check;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public System.Object FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private System.Object _FechaActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 Id_Cliente
		{
			get { return _Id_Cliente; }
			set
			{
				ReportPropertyChanging("Id_Cliente");
				_Id_Cliente = value;
				ReportPropertyChanged("Id_Cliente");
			}
		}
		private Int64 _Id_Cliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Estaciones_Sesion
		{
			get { return _id_Estaciones_Sesion; }
			set
			{
				ReportPropertyChanging("id_Estaciones_Sesion");
				_id_Estaciones_Sesion = value;
				ReportPropertyChanged("id_Estaciones_Sesion");
			}
		}
		private Int64 _id_Estaciones_Sesion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID = value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nota
		{
			get { return _Nota; }
			set
			{
				ReportPropertyChanging("Nota");
				_Nota = value;
				ReportPropertyChanged("Nota");
			}
		}
		private String _Nota;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Foto_Archivo
		{
			get { return _Foto_Archivo; }
			set
			{
				ReportPropertyChanging("Foto_Archivo");
				_Foto_Archivo = value;
				ReportPropertyChanged("Foto_Archivo");
			}
		}
		private String _Foto_Archivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;


	}

	[EdmEntityTypeAttribute(Name = "Clientes_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Club : kssSocialClubBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String CodigoBarras
		{
			get { return _CodigoBarras; }
			set
			{
				ReportPropertyChanging("CodigoBarras");
				_CodigoBarras = value;
				ReportPropertyChanged("CodigoBarras");
			}
		}
		private String _CodigoBarras;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Condicion_Medica
		{
			get { return _Condicion_Medica; }
			set
			{
				ReportPropertyChanging("Condicion_Medica");
				_Condicion_Medica = value;
				ReportPropertyChanged("Condicion_Medica");
			}
		}
		private String _Condicion_Medica;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Contacto_Emerg1
		{
			get { return _Contacto_Emerg1; }
			set
			{
				ReportPropertyChanging("Contacto_Emerg1");
				_Contacto_Emerg1 = value;
				ReportPropertyChanged("Contacto_Emerg1");
			}
		}
		private String _Contacto_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Contacto_Emerg2
		{
			get { return _Contacto_Emerg2; }
			set
			{
				ReportPropertyChanging("Contacto_Emerg2");
				_Contacto_Emerg2 = value;
				ReportPropertyChanged("Contacto_Emerg2");
			}
		}
		private String _Contacto_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Direccion_Emerg1
		{
			get { return _Direccion_Emerg1; }
			set
			{
				ReportPropertyChanging("Direccion_Emerg1");
				_Direccion_Emerg1 = value;
				ReportPropertyChanged("Direccion_Emerg1");
			}
		}
		private String _Direccion_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Direccion_Emerg2
		{
			get { return _Direccion_Emerg2; }
			set
			{
				ReportPropertyChanging("Direccion_Emerg2");
				_Direccion_Emerg2 = value;
				ReportPropertyChanged("Direccion_Emerg2");
			}
		}
		private String _Direccion_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esActivo
		{
			get { return _esActivo; }
			set
			{
				ReportPropertyChanging("esActivo");
				_esActivo = value;
				ReportPropertyChanged("esActivo");
			}
		}
		private Boolean? _esActivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_Ingreso
		{
			get { return _Fecha_Ingreso; }
			set
			{
				ReportPropertyChanging("Fecha_Ingreso");
				_Fecha_Ingreso = value;
				ReportPropertyChanged("Fecha_Ingreso");
			}
		}
		private DateTime? _Fecha_Ingreso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? Fecha_Nacimiento
		{
			get { return _Fecha_Nacimiento; }
			set
			{
				ReportPropertyChanging("Fecha_Nacimiento");
				_Fecha_Nacimiento = value;
				ReportPropertyChanged("Fecha_Nacimiento");
			}
		}
		private DateTime? _Fecha_Nacimiento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Foto_Archivo
		{
			get { return _Foto_Archivo; }
			set
			{
				ReportPropertyChanging("Foto_Archivo");
				_Foto_Archivo = value;
				ReportPropertyChanged("Foto_Archivo");
			}
		}
		private String _Foto_Archivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
		[DataMember]
		public Int64 ID
		{
			get { return _ID; }
			set
			{
				ReportPropertyChanging("ID");
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_AreaComunAcceso
		{
			get { return _id_AreaComunAcceso; }
			set
			{
				ReportPropertyChanging("id_AreaComunAcceso");
				_id_AreaComunAcceso = value;
				ReportPropertyChanged("id_AreaComunAcceso");
			}
		}
		private Int64? _id_AreaComunAcceso;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Banco
		{
			get { return _id_Banco; }
			set
			{
				ReportPropertyChanging("id_Banco");
				_id_Banco = value;
				ReportPropertyChanged("id_Banco");
			}
		}
		private Int64? _id_Banco;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? idDefTipoPersonal
		{
			get { return _idDefTipoPersonal; }
			set
			{
				ReportPropertyChanging("idDefTipoPersonal");
				_idDefTipoPersonal = value;
				ReportPropertyChanged("idDefTipoPersonal");
			}
		}
		private Int64? _idDefTipoPersonal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nombre_Medico
		{
			get { return _Nombre_Medico; }
			set
			{
				ReportPropertyChanging("Nombre_Medico");
				_Nombre_Medico = value;
				ReportPropertyChanged("Nombre_Medico");
			}
		}
		private String _Nombre_Medico;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nota
		{
			get { return _Nota; }
			set
			{
				ReportPropertyChanging("Nota");
				_Nota = value;
				ReportPropertyChanged("Nota");
			}
		}
		private String _Nota;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nroTarjetaCredito
		{
			get { return _nroTarjetaCredito; }
			set
			{
				ReportPropertyChanging("nroTarjetaCredito");
				_nroTarjetaCredito = value;
				ReportPropertyChanged("nroTarjetaCredito");
			}
		}
		private String _nroTarjetaCredito;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Emerg1
		{
			get { return _Telefono_Emerg1; }
			set
			{
				ReportPropertyChanging("Telefono_Emerg1");
				_Telefono_Emerg1 = value;
				ReportPropertyChanged("Telefono_Emerg1");
			}
		}
		private String _Telefono_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Emerg2
		{
			get { return _Telefono_Emerg2; }
			set
			{
				ReportPropertyChanging("Telefono_Emerg2");
				_Telefono_Emerg2 = value;
				ReportPropertyChanged("Telefono_Emerg2");
			}
		}
		private String _Telefono_Emerg2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefono_Medico
		{
			get { return _Telefono_Medico; }
			set
			{
				ReportPropertyChanging("Telefono_Medico");
				_Telefono_Medico = value;
				ReportPropertyChanged("Telefono_Medico");
			}
		}
		private String _Telefono_Medico;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TelefonoTrabajo_Emerg1
		{
			get { return _TelefonoTrabajo_Emerg1; }
			set
			{
				ReportPropertyChanging("TelefonoTrabajo_Emerg1");
				_TelefonoTrabajo_Emerg1 = value;
				ReportPropertyChanged("TelefonoTrabajo_Emerg1");
			}
		}
		private String _TelefonoTrabajo_Emerg1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TelefonoTrabajo_Emerg2
		{
			get { return _TelefonoTrabajo_Emerg2; }
			set
			{
				ReportPropertyChanging("TelefonoTrabajo_Emerg2");
				_TelefonoTrabajo_Emerg2 = value;
				ReportPropertyChanged("TelefonoTrabajo_Emerg2");
			}
		}
		private String _TelefonoTrabajo_Emerg2;


	}

}
