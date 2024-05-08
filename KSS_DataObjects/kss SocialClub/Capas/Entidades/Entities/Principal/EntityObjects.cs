using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using kss_DataObjects.Base;
using System.Data.Entity.Core.Objects.DataClasses;

namespace kss_DataObjects.Entities
{

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes_DetalleEgreso")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes_DetalleEgreso : kssDBBaseEntity
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
	public partial class Cajas_Cortes_DetalleIngreso : kssDBBaseEntity
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
	public partial class Cajas_Cortes_IF : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Estaciones_Dipositivo_VisorPrecios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dipositivo_VisorPrecios : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivos_GavetaDinero")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivos_GavetaDinero : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Empleados_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empleados_Club : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Clientes_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Club : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Empleados")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empleados : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Cajas_EgresosIngresos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_EgresosIngresos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Clientes_Grupo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Grupo : kssDBBaseEntity
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
		public String Descirpcion
		{
			get { return _Descirpcion; }
			set
			{
				ReportPropertyChanging("Descirpcion");
				_Descirpcion = value;
				ReportPropertyChanged("Descirpcion");
			}
		}
		private String _Descirpcion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Zona
		{
			get { return _id_Zona; }
			set
			{
				ReportPropertyChanging("id_Zona");
				_id_Zona = value;
				ReportPropertyChanged("id_Zona");
			}
		}
		private Int64? _id_Zona;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones : kssDBBaseEntity
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
		public String Descirpcion
		{
			get { return _Descirpcion; }
			set
			{
				ReportPropertyChanging("Descirpcion");
				_Descirpcion = value;
				ReportPropertyChanged("Descirpcion");
			}
		}
		private String _Descirpcion;


	}

	[EdmEntityTypeAttribute(Name = "TipoMoneda_denominaciones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoMoneda_denominaciones : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esBillete
		{
			get { return _esBillete; }
			set
			{
				ReportPropertyChanging("esBillete");
				_esBillete = value;
				ReportPropertyChanged("esBillete");
			}
		}
		private Boolean? _esBillete;

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
		public Double? Valor
		{
			get { return _Valor; }
			set
			{
				ReportPropertyChanging("Valor");
				_Valor = value;
				ReportPropertyChanged("Valor");
			}
		}
		private Double? _Valor;


	}

	[EdmEntityTypeAttribute(Name = "TipoProductos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoProductos : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "TipoUnidadesMedida")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoUnidadesMedida : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public String Abreviatura
		{
			get { return _Abreviatura; }
			set
			{
				ReportPropertyChanging("Abreviatura");
				_Abreviatura = value;
				ReportPropertyChanged("Abreviatura");
			}
		}
		private String _Abreviatura;


	}

	[EdmEntityTypeAttribute(Name = "ven_municipios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class ven_municipios : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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


	}

	[EdmEntityTypeAttribute(Name = "ven_parroquias")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class ven_parroquias : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "world_localidades")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_localidades : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "world_paises")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_paises : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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

	[EdmEntityTypeAttribute(Name = "world_profesiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_profesiones : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "world_regiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class world_regiones : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "World_UnidadesMedida")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class World_UnidadesMedida : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cantidadPredeterminada
		{
			get { return _cantidadPredeterminada; }
			set
			{
				ReportPropertyChanging("cantidadPredeterminada");
				_cantidadPredeterminada = value;
				ReportPropertyChanged("cantidadPredeterminada");
			}
		}
		private Double? _cantidadPredeterminada;


	}

	[EdmEntityTypeAttribute(Name = "Usuarios_Roles")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios_Roles : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Usuarios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "Usuarios_RolesModulos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios_RolesModulos : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ControlTag
		{
			get { return _id_ControlTag; }
			set
			{
				ReportPropertyChanging("id_ControlTag");
				_id_ControlTag = value;
				ReportPropertyChanged("id_ControlTag");
			}
		}
		private Int64? _id_ControlTag;

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

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_defAccionModulo
		{
			get { return _id_defAccionModulo; }
			set
			{
				ReportPropertyChanging("id_defAccionModulo");
				_id_defAccionModulo = value;
				ReportPropertyChanged("id_defAccionModulo");
			}
		}
		private Int64 _id_defAccionModulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String AccionModulo
		{
			get { return _AccionModulo; }
			set
			{
				ReportPropertyChanging("AccionModulo");
				_AccionModulo = value;
				ReportPropertyChanged("AccionModulo");
			}
		}
		private String _AccionModulo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Parametro1
		{
			get { return _Parametro1; }
			set
			{
				ReportPropertyChanging("Parametro1");
				_Parametro1 = value;
				ReportPropertyChanged("Parametro1");
			}
		}
		private String _Parametro1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Parametro2
		{
			get { return _Parametro2; }
			set
			{
				ReportPropertyChanging("Parametro2");
				_Parametro2 = value;
				ReportPropertyChanged("Parametro2");
			}
		}
		private String _Parametro2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Parametro3
		{
			get { return _Parametro3; }
			set
			{
				ReportPropertyChanging("Parametro3");
				_Parametro3 = value;
				ReportPropertyChanged("Parametro3");
			}
		}
		private String _Parametro3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Parametro4
		{
			get { return _Parametro4; }
			set
			{
				ReportPropertyChanging("Parametro4");
				_Parametro4 = value;
				ReportPropertyChanged("Parametro4");
			}
		}
		private String _Parametro4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAccion
		{
			get { return _esAccion; }
			set
			{
				ReportPropertyChanging("esAccion");
				_esAccion = value;
				ReportPropertyChanged("esAccion");
			}
		}
		private Boolean? _esAccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defAccionModulo_padre
		{
			get { return _id_defAccionModulo_padre; }
			set
			{
				ReportPropertyChanging("id_defAccionModulo_padre");
				_id_defAccionModulo_padre = value;
				ReportPropertyChanged("id_defAccionModulo_padre");
			}
		}
		private Int64? _id_defAccionModulo_padre;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String AccionModulo_padre
		{
			get { return _AccionModulo_padre; }
			set
			{
				ReportPropertyChanging("AccionModulo_padre");
				_AccionModulo_padre = value;
				ReportPropertyChanged("AccionModulo_padre");
			}
		}
		private String _AccionModulo_padre;


	}

	[EdmEntityTypeAttribute(Name = "Clientes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fechaNac
		{
			get { return _fechaNac; }
			set
			{
				ReportPropertyChanging("fechaNac");
				_fechaNac = value;
				ReportPropertyChanged("fechaNac");
			}
		}
		private DateTime? _fechaNac;


	}

	[EdmEntityTypeAttribute(Name = "Usuarios_Grupo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios_Grupo : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoUsuarioNivel
		{
			get { return _id_defTipoUsuarioNivel; }
			set
			{
				ReportPropertyChanging("id_defTipoUsuarioNivel");
				_id_defTipoUsuarioNivel = value;
				ReportPropertyChanged("id_defTipoUsuarioNivel");
			}
		}
		private Int64? _id_defTipoUsuarioNivel;

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

	[EdmEntityTypeAttribute(Name = "TipoPromociones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoPromociones : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaIni
		{
			get { return _FechaIni; }
			set
			{
				ReportPropertyChanging("FechaIni");
				_FechaIni = value;
				ReportPropertyChanged("FechaIni");
			}
		}
		private DateTime? _FechaIni;

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
		public DateTime? FechaModificado
		{
			get { return _FechaModificado; }
			set
			{
				ReportPropertyChanging("FechaModificado");
				_FechaModificado = value;
				ReportPropertyChanged("FechaModificado");
			}
		}
		private DateTime? _FechaModificado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAplicaFactura
		{
			get { return _esAplicaFactura; }
			set
			{
				ReportPropertyChanging("esAplicaFactura");
				_esAplicaFactura = value;
				ReportPropertyChanged("esAplicaFactura");
			}
		}
		private Boolean? _esAplicaFactura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esTasaValorPorcentual
		{
			get { return _esTasaValorPorcentual; }
			set
			{
				ReportPropertyChanging("esTasaValorPorcentual");
				_esTasaValorPorcentual = value;
				ReportPropertyChanged("esTasaValorPorcentual");
			}
		}
		private Boolean? _esTasaValorPorcentual;

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
		public Decimal? HoraIni
		{
			get { return _HoraIni; }
			set
			{
				ReportPropertyChanging("HoraIni");
				_HoraIni = value;
				ReportPropertyChanged("HoraIni");
			}
		}
		private Decimal? _HoraIni;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? HoraFin
		{
			get { return _HoraFin; }
			set
			{
				ReportPropertyChanging("HoraFin");
				_HoraFin = value;
				ReportPropertyChanged("HoraFin");
			}
		}
		private Decimal? _HoraFin;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_tipodefPromociones
		{
			get { return _id_tipodefPromociones; }
			set
			{
				ReportPropertyChanging("id_tipodefPromociones");
				_id_tipodefPromociones = value;
				ReportPropertyChanged("id_tipodefPromociones");
			}
		}
		private Int64? _id_tipodefPromociones;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parametro1
		{
			get { return _parametro1; }
			set
			{
				ReportPropertyChanging("parametro1");
				_parametro1 = value;
				ReportPropertyChanged("parametro1");
			}
		}
		private String _parametro1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parametro2
		{
			get { return _parametro2; }
			set
			{
				ReportPropertyChanging("parametro2");
				_parametro2 = value;
				ReportPropertyChanged("parametro2");
			}
		}
		private String _parametro2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String parametro3
		{
			get { return _parametro3; }
			set
			{
				ReportPropertyChanging("parametro3");
				_parametro3 = value;
				ReportPropertyChanged("parametro3");
			}
		}
		private String _parametro3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DiasSemana
		{
			get { return _DiasSemana; }
			set
			{
				ReportPropertyChanging("DiasSemana");
				_DiasSemana = value;
				ReportPropertyChanged("DiasSemana");
			}
		}
		private String _DiasSemana;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DiasPromocion
		{
			get { return _DiasPromocion; }
			set
			{
				ReportPropertyChanging("DiasPromocion");
				_DiasPromocion = value;
				ReportPropertyChanged("DiasPromocion");
			}
		}
		private String _DiasPromocion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String idEstacionesPermitidas
		{
			get { return _idEstacionesPermitidas; }
			set
			{
				ReportPropertyChanging("idEstacionesPermitidas");
				_idEstacionesPermitidas = value;
				ReportPropertyChanged("idEstacionesPermitidas");
			}
		}
		private String _idEstacionesPermitidas;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String idFormasPagoPermitidas
		{
			get { return _idFormasPagoPermitidas; }
			set
			{
				ReportPropertyChanging("idFormasPagoPermitidas");
				_idFormasPagoPermitidas = value;
				ReportPropertyChanged("idFormasPagoPermitidas");
			}
		}
		private String _idFormasPagoPermitidas;


	}

	[EdmEntityTypeAttribute(Name = "Areas_Comunes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Areas_Comunes : kssDBBaseEntity
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
		public String Descirpcion
		{
			get { return _Descirpcion; }
			set
			{
				ReportPropertyChanging("Descirpcion");
				_Descirpcion = value;
				ReportPropertyChanged("Descirpcion");
			}
		}
		private String _Descirpcion;

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

	[EdmEntityTypeAttribute(Name = "Cajas_Cortes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas_Cortes : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Empresa")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Empresa : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Clientes_Club_Medidas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Club_Medidas : kssDBBaseEntity
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
		public Double? FechaActual
		{
			get { return _FechaActual; }
			set
			{
				ReportPropertyChanging("FechaActual");
				_FechaActual = value;
				ReportPropertyChanged("FechaActual");
			}
		}
		private Double? _FechaActual;

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

	[EdmEntityTypeAttribute(Name = "Estaciones_Dispositivo_Balanza")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Dispositivo_Balanza : kssDBBaseEntity
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
	public partial class Estaciones_Dispositivo_Impresora : kssDBBaseEntity
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
	public partial class Estaciones_Dispositivos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Estaciones_Sesiones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Sesiones : kssDBBaseEntity
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
	public partial class Estaciones_Sesiones_Detalle : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Productos_Compuestos_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Compuestos_Detalle : kssDBBaseEntity
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
		public Int64 id_Productos_Compuestos
		{
			get { return _id_Productos_Compuestos; }
			set
			{
				ReportPropertyChanging("id_Productos_Compuestos");
				_id_Productos_Compuestos = value;
				ReportPropertyChanged("id_Productos_Compuestos");
			}
		}
		private Int64 _id_Productos_Compuestos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CantidadUnidad
		{
			get { return _CantidadUnidad; }
			set
			{
				ReportPropertyChanging("CantidadUnidad");
				_CantidadUnidad = value;
				ReportPropertyChanged("CantidadUnidad");
			}
		}
		private Double _CantidadUnidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_TipoUnidad
		{
			get { return _id_TipoUnidad; }
			set
			{
				ReportPropertyChanging("id_TipoUnidad");
				_id_TipoUnidad = value;
				ReportPropertyChanged("id_TipoUnidad");
			}
		}
		private Int64? _id_TipoUnidad;


	}

	[EdmEntityTypeAttribute(Name = "TipoDescuentos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoDescuentos : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esDescuento
		{
			get { return _esDescuento; }
			set
			{
				ReportPropertyChanging("esDescuento");
				_esDescuento = value;
				ReportPropertyChanged("esDescuento");
			}
		}
		private Boolean? _esDescuento;

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

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esTasaValorPorcentual
		{
			get { return _esTasaValorPorcentual; }
			set
			{
				ReportPropertyChanging("esTasaValorPorcentual");
				_esTasaValorPorcentual = value;
				ReportPropertyChanged("esTasaValorPorcentual");
			}
		}
		private Boolean? _esTasaValorPorcentual;

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
		public DateTime? FechaModificado
		{
			get { return _FechaModificado; }
			set
			{
				ReportPropertyChanging("FechaModificado");
				_FechaModificado = value;
				ReportPropertyChanged("FechaModificado");
			}
		}
		private DateTime? _FechaModificado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaIni
		{
			get { return _FechaIni; }
			set
			{
				ReportPropertyChanging("FechaIni");
				_FechaIni = value;
				ReportPropertyChanged("FechaIni");
			}
		}
		private DateTime? _FechaIni;

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
		public Boolean? esPorItem
		{
			get { return _esPorItem; }
			set
			{
				ReportPropertyChanging("esPorItem");
				_esPorItem = value;
				ReportPropertyChanged("esPorItem");
			}
		}
		private Boolean? _esPorItem;


	}

	[EdmEntityTypeAttribute(Name = "TipoOfertas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoOfertas : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaIni
		{
			get { return _FechaIni; }
			set
			{
				ReportPropertyChanging("FechaIni");
				_FechaIni = value;
				ReportPropertyChanged("FechaIni");
			}
		}
		private DateTime? _FechaIni;

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
		public DateTime? FechaModificado
		{
			get { return _FechaModificado; }
			set
			{
				ReportPropertyChanging("FechaModificado");
				_FechaModificado = value;
				ReportPropertyChanged("FechaModificado");
			}
		}
		private DateTime? _FechaModificado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esAplicaFactura
		{
			get { return _esAplicaFactura; }
			set
			{
				ReportPropertyChanging("esAplicaFactura");
				_esAplicaFactura = value;
				ReportPropertyChanged("esAplicaFactura");
			}
		}
		private Boolean? _esAplicaFactura;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esTasaValorPorcentual
		{
			get { return _esTasaValorPorcentual; }
			set
			{
				ReportPropertyChanging("esTasaValorPorcentual");
				_esTasaValorPorcentual = value;
				ReportPropertyChanged("esTasaValorPorcentual");
			}
		}
		private Boolean? _esTasaValorPorcentual;

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

	[EdmEntityTypeAttribute(Name = "Usuarios_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Usuarios_Detalle : kssDBBaseEntity
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
		public Int64? id_defUsuarioOperacion
		{
			get { return _id_defUsuarioOperacion; }
			set
			{
				ReportPropertyChanging("id_defUsuarioOperacion");
				_id_defUsuarioOperacion = value;
				ReportPropertyChanged("id_defUsuarioOperacion");
			}
		}
		private Int64? _id_defUsuarioOperacion;


	}

	[EdmEntityTypeAttribute(Name = "World_idiomas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class World_idiomas : kssDBBaseEntity
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
				_ID =value;
				ReportPropertyChanged("ID");
			}
		}
		private Int64 _ID;


	}

	[EdmEntityTypeAttribute(Name = "Zonas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Zonas : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Decimal Descripcion
		{
			get { return _Descripcion; }
			set
			{
				ReportPropertyChanging("Descripcion");
				_Descripcion = value;
				ReportPropertyChanged("Descripcion");
			}
		}
		private Decimal _Descripcion;

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
		public Int64? id_Localidad
		{
			get { return _id_Localidad; }
			set
			{
				ReportPropertyChanging("id_Localidad");
				_id_Localidad = value;
				ReportPropertyChanged("id_Localidad");
			}
		}
		private Int64? _id_Localidad;


	}

	[EdmEntityTypeAttribute(Name = "Estaciones_Reportes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Estaciones_Reportes : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_Estacion
		{
			get { return _ID_Estacion; }
			set
			{
				ReportPropertyChanging("ID_Estacion");
				_ID_Estacion = value;
				ReportPropertyChanged("ID_Estacion");
			}
		}
		private Int64 _ID_Estacion;

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

	[EdmEntityTypeAttribute(Name = "Impuestos_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Impuestos_Detalle : kssDBBaseEntity
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
		public Double? tasaAnterior
		{
			get { return _tasaAnterior; }
			set
			{
				ReportPropertyChanging("tasaAnterior");
				_tasaAnterior = value;
				ReportPropertyChanged("tasaAnterior");
			}
		}
		private Double? _tasaAnterior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? tasaNueva
		{
			get { return _tasaNueva; }
			set
			{
				ReportPropertyChanging("tasaNueva");
				_tasaNueva = value;
				ReportPropertyChanged("tasaNueva");
			}
		}
		private Double? _tasaNueva;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NomenclaturaAnterior
		{
			get { return _NomenclaturaAnterior; }
			set
			{
				ReportPropertyChanging("NomenclaturaAnterior");
				_NomenclaturaAnterior = value;
				ReportPropertyChanged("NomenclaturaAnterior");
			}
		}
		private String _NomenclaturaAnterior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NomenclaturaNueva
		{
			get { return _NomenclaturaNueva; }
			set
			{
				ReportPropertyChanging("NomenclaturaNueva");
				_NomenclaturaNueva = value;
				ReportPropertyChanged("NomenclaturaNueva");
			}
		}
		private String _NomenclaturaNueva;

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


	}

	[EdmEntityTypeAttribute(Name = "Cajas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Cajas : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Descirpcion
		{
			get { return _Descirpcion; }
			set
			{
				ReportPropertyChanging("Descirpcion");
				_Descirpcion = value;
				ReportPropertyChanged("Descirpcion");
			}
		}
		private String _Descirpcion;

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

	[EdmEntityTypeAttribute(Name = "TipoServicioStatus")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoServicioStatus : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "TipoPago_Doc")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoPago_Doc : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "TipoMoneda_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoMoneda_Detalle : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FactorAnterior
		{
			get { return _FactorAnterior; }
			set
			{
				ReportPropertyChanging("FactorAnterior");
				_FactorAnterior = value;
				ReportPropertyChanged("FactorAnterior");
			}
		}
		private Double? _FactorAnterior;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FactorNuevo
		{
			get { return _FactorNuevo; }
			set
			{
				ReportPropertyChanging("FactorNuevo");
				_FactorNuevo = value;
				ReportPropertyChanged("FactorNuevo");
			}
		}
		private Double? _FactorNuevo;

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


	}

	[EdmEntityTypeAttribute(Name = "TipoMoneda")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoMoneda : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? Factor
		{
			get { return _Factor; }
			set
			{
				ReportPropertyChanging("Factor");
				_Factor = value;
				ReportPropertyChanged("Factor");
			}
		}
		private Double? _Factor;

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
		public String URLReferencia
		{
			get { return _URLReferencia; }
			set
			{
				ReportPropertyChanging("URLReferencia");
				_URLReferencia = value;
				ReportPropertyChanged("URLReferencia");
			}
		}
		private String _URLReferencia;

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
		public Boolean? esDivide
		{
			get { return _esDivide; }
			set
			{
				ReportPropertyChanging("esDivide");
				_esDivide = value;
				ReportPropertyChanged("esDivide");
			}
		}
		private Boolean? _esDivide;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String esLocal
		{
			get { return _esLocal; }
			set
			{
				ReportPropertyChanging("esLocal");
				_esLocal = value;
				ReportPropertyChanged("esLocal");
			}
		}
		private String _esLocal;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Nomenclatura
		{
			get { return _Nomenclatura; }
			set
			{
				ReportPropertyChanging("Nomenclatura");
				_Nomenclatura = value;
				ReportPropertyChanged("Nomenclatura");
			}
		}
		private String _Nomenclatura;


	}

	[EdmEntityTypeAttribute(Name = "TipoEgresoIngreso_Caja")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoEgresoIngreso_Caja : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "TipoDescuentos_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoDescuentos_Detalle : kssDBBaseEntity
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
		public Int64 id_TipoDescuento
		{
			get { return _id_TipoDescuento; }
			set
			{
				ReportPropertyChanging("id_TipoDescuento");
				_id_TipoDescuento = value;
				ReportPropertyChanged("id_TipoDescuento");
			}
		}
		private Int64 _id_TipoDescuento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Producto
		{
			get { return _id_Producto; }
			set
			{
				ReportPropertyChanging("id_Producto");
				_id_Producto = value;
				ReportPropertyChanged("id_Producto");
			}
		}
		private Int64? _id_Producto;

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


	}

	[EdmEntityTypeAttribute(Name = "Registros_Visitas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Registros_Visitas : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Proveedores")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Proveedores : kssDBBaseEntity
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
		public Int64 id_tipoComercio
		{
			get { return _id_tipoComercio; }
			set
			{
				ReportPropertyChanging("id_tipoComercio");
				_id_tipoComercio = value;
				ReportPropertyChanged("id_tipoComercio");
			}
		}
		private Int64 _id_tipoComercio;

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
		public String telefonoContacto
		{
			get { return _telefonoContacto; }
			set
			{
				ReportPropertyChanging("telefonoContacto");
				_telefonoContacto = value;
				ReportPropertyChanged("telefonoContacto");
			}
		}
		private String _telefonoContacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String emailContacto
		{
			get { return _emailContacto; }
			set
			{
				ReportPropertyChanging("emailContacto");
				_emailContacto = value;
				ReportPropertyChanged("emailContacto");
			}
		}
		private String _emailContacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String emailGerente
		{
			get { return _emailGerente; }
			set
			{
				ReportPropertyChanging("emailGerente");
				_emailGerente = value;
				ReportPropertyChanged("emailGerente");
			}
		}
		private String _emailGerente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String fax
		{
			get { return _fax; }
			set
			{
				ReportPropertyChanging("fax");
				_fax = value;
				ReportPropertyChanged("fax");
			}
		}
		private String _fax;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fechaNacGerente
		{
			get { return _fechaNacGerente; }
			set
			{
				ReportPropertyChanging("fechaNacGerente");
				_fechaNacGerente = value;
				ReportPropertyChanged("fechaNacGerente");
			}
		}
		private DateTime? _fechaNacGerente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Byte[] fechaNacContacto
		{
			get { return _fechaNacContacto; }
			set
			{
				ReportPropertyChanging("fechaNacContacto");
				_fechaNacContacto = value;
				ReportPropertyChanged("fechaNacContacto");
			}
		}
		private Byte[] _fechaNacContacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoOrigenProveedor
		{
			get { return _id_defTipoOrigenProveedor; }
			set
			{
				ReportPropertyChanging("id_defTipoOrigenProveedor");
				_id_defTipoOrigenProveedor = value;
				ReportPropertyChanged("id_defTipoOrigenProveedor");
			}
		}
		private Int64? _id_defTipoOrigenProveedor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoProveedor
		{
			get { return _id_defTipoProveedor; }
			set
			{
				ReportPropertyChanging("id_defTipoProveedor");
				_id_defTipoProveedor = value;
				ReportPropertyChanged("id_defTipoProveedor");
			}
		}
		private Int64? _id_defTipoProveedor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String telefonoGerente
		{
			get { return _telefonoGerente; }
			set
			{
				ReportPropertyChanging("telefonoGerente");
				_telefonoGerente = value;
				ReportPropertyChanged("telefonoGerente");
			}
		}
		private String _telefonoGerente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nombreContacto
		{
			get { return _nombreContacto; }
			set
			{
				ReportPropertyChanging("nombreContacto");
				_nombreContacto = value;
				ReportPropertyChanged("nombreContacto");
			}
		}
		private String _nombreContacto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String nombreGerente
		{
			get { return _nombreGerente; }
			set
			{
				ReportPropertyChanging("nombreGerente");
				_nombreGerente = value;
				ReportPropertyChanged("nombreGerente");
			}
		}
		private String _nombreGerente;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Supermercado")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Supermercado : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "Productos_Oferta")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Oferta : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_producto
		{
			get { return _id_producto; }
			set
			{
				ReportPropertyChanging("id_producto");
				_id_producto = value;
				ReportPropertyChanged("id_producto");
			}
		}
		private Int64? _id_producto;

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
		public DateTime? FechaUltima
		{
			get { return _FechaUltima; }
			set
			{
				ReportPropertyChanging("FechaUltima");
				_FechaUltima = value;
				ReportPropertyChanged("FechaUltima");
			}
		}
		private DateTime? _FechaUltima;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_tipoOferta
		{
			get { return _id_tipoOferta; }
			set
			{
				ReportPropertyChanging("id_tipoOferta");
				_id_tipoOferta = value;
				ReportPropertyChanged("id_tipoOferta");
			}
		}
		private Int64? _id_tipoOferta;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Promociones")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Promociones : kssDBBaseEntity
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
		public String descripcion
		{
			get { return _descripcion; }
			set
			{
				ReportPropertyChanging("descripcion");
				_descripcion = value;
				ReportPropertyChanged("descripcion");
			}
		}
		private String _descripcion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_tipoPromocion
		{
			get { return _id_tipoPromocion; }
			set
			{
				ReportPropertyChanging("id_tipoPromocion");
				_id_tipoPromocion = value;
				ReportPropertyChanged("id_tipoPromocion");
			}
		}
		private Int64 _id_tipoPromocion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_producto
		{
			get { return _id_producto; }
			set
			{
				ReportPropertyChanging("id_producto");
				_id_producto = value;
				ReportPropertyChanged("id_producto");
			}
		}
		private Int64? _id_producto;

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
		public DateTime? FechaUltima
		{
			get { return _FechaUltima; }
			set
			{
				ReportPropertyChanging("FechaUltima");
				_FechaUltima = value;
				ReportPropertyChanged("FechaUltima");
			}
		}
		private DateTime? _FechaUltima;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Marcas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Marcas : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "Productos_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Impuestos : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "Productos_Grupo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Grupo : kssDBBaseEntity
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
		public String CodigoRef
		{
			get { return _CodigoRef; }
			set
			{
				ReportPropertyChanging("CodigoRef");
				_CodigoRef = value;
				ReportPropertyChanged("CodigoRef");
			}
		}
		private String _CodigoRef;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Farmacia")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Farmacia : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Productos_Compuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Compuestos : kssDBBaseEntity
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
		public Double CantidadUnidad
		{
			get { return _CantidadUnidad; }
			set
			{
				ReportPropertyChanging("CantidadUnidad");
				_CantidadUnidad = value;
				ReportPropertyChanged("CantidadUnidad");
			}
		}
		private Double _CantidadUnidad;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public Int64 id_TipoUnidadMedida
		{
			get { return _id_TipoUnidadMedida; }
			set
			{
				ReportPropertyChanging("id_TipoUnidadMedida");
				_id_TipoUnidadMedida = value;
				ReportPropertyChanged("id_TipoUnidadMedida");
			}
		}
		private Int64 _id_TipoUnidadMedida;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esactivo
		{
			get { return _esactivo; }
			set
			{
				ReportPropertyChanging("esactivo");
				_esactivo = value;
				ReportPropertyChanged("esactivo");
			}
		}
		private Boolean? _esactivo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fechaCreado
		{
			get { return _fechaCreado; }
			set
			{
				ReportPropertyChanging("fechaCreado");
				_fechaCreado = value;
				ReportPropertyChanged("fechaCreado");
			}
		}
		private DateTime? _fechaCreado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? fechaModificado
		{
			get { return _fechaModificado; }
			set
			{
				ReportPropertyChanging("fechaModificado");
				_fechaModificado = value;
				ReportPropertyChanged("fechaModificado");
			}
		}
		private DateTime? _fechaModificado;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Decimal? codigoReferencia
		{
			get { return _codigoReferencia; }
			set
			{
				ReportPropertyChanging("codigoReferencia");
				_codigoReferencia = value;
				ReportPropertyChanged("codigoReferencia");
			}
		}
		private Decimal? _codigoReferencia;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Club")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Club : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Empleado_Club
		{
			get { return _id_Empleado_Club; }
			set
			{
				ReportPropertyChanging("id_Empleado_Club");
				_id_Empleado_Club = value;
				ReportPropertyChanged("id_Empleado_Club");
			}
		}
		private Int64? _id_Empleado_Club;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraInicio_PrimerTurno
		{
			get { return _HoraInicio_PrimerTurno; }
			set
			{
				ReportPropertyChanging("HoraInicio_PrimerTurno");
				_HoraInicio_PrimerTurno = value;
				ReportPropertyChanged("HoraInicio_PrimerTurno");
			}
		}
		private DateTime? _HoraInicio_PrimerTurno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraFin_PrimerTurno
		{
			get { return _HoraFin_PrimerTurno; }
			set
			{
				ReportPropertyChanging("HoraFin_PrimerTurno");
				_HoraFin_PrimerTurno = value;
				ReportPropertyChanged("HoraFin_PrimerTurno");
			}
		}
		private DateTime? _HoraFin_PrimerTurno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraInico_SegundoTurno
		{
			get { return _HoraInico_SegundoTurno; }
			set
			{
				ReportPropertyChanging("HoraInico_SegundoTurno");
				_HoraInico_SegundoTurno = value;
				ReportPropertyChanged("HoraInico_SegundoTurno");
			}
		}
		private DateTime? _HoraInico_SegundoTurno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraFin_SegundoTurno
		{
			get { return _HoraFin_SegundoTurno; }
			set
			{
				ReportPropertyChanging("HoraFin_SegundoTurno");
				_HoraFin_SegundoTurno = value;
				ReportPropertyChanged("HoraFin_SegundoTurno");
			}
		}
		private DateTime? _HoraFin_SegundoTurno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraInicio_TercerTurno
		{
			get { return _HoraInicio_TercerTurno; }
			set
			{
				ReportPropertyChanging("HoraInicio_TercerTurno");
				_HoraInicio_TercerTurno = value;
				ReportPropertyChanged("HoraInicio_TercerTurno");
			}
		}
		private DateTime? _HoraInicio_TercerTurno;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? HoraFin_TercerTurno
		{
			get { return _HoraFin_TercerTurno; }
			set
			{
				ReportPropertyChanging("HoraFin_TercerTurno");
				_HoraFin_TercerTurno = value;
				ReportPropertyChanged("HoraFin_TercerTurno");
			}
		}
		private DateTime? _HoraFin_TercerTurno;


	}

	[EdmEntityTypeAttribute(Name = "Productos_Calzado")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_Calzado : kssDBBaseEntity
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


	}

	[EdmEntityTypeAttribute(Name = "Productos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos : kssDBBaseEntity
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
		public Double? cantidadUnidad
		{
			get { return _cantidadUnidad; }
			set
			{
				ReportPropertyChanging("cantidadUnidad");
				_cantidadUnidad = value;
				ReportPropertyChanged("cantidadUnidad");
			}
		}
		private Double? _cantidadUnidad;

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

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? minStock
		{
			get { return _minStock; }
			set
			{
				ReportPropertyChanging("minStock");
				_minStock = value;
				ReportPropertyChanged("minStock");
			}
		}
		private Double? _minStock;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? maxStock
		{
			get { return _maxStock; }
			set
			{
				ReportPropertyChanging("maxStock");
				_maxStock = value;
				ReportPropertyChanged("maxStock");
			}
		}
		private Double? _maxStock;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esVenderSinStock
		{
			get { return _esVenderSinStock; }
			set
			{
				ReportPropertyChanging("esVenderSinStock");
				_esVenderSinStock = value;
				ReportPropertyChanged("esVenderSinStock");
			}
		}
		private Boolean? _esVenderSinStock;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esMultiplesImpuestos
		{
			get { return _esMultiplesImpuestos; }
			set
			{
				ReportPropertyChanging("esMultiplesImpuestos");
				_esMultiplesImpuestos = value;
				ReportPropertyChanged("esMultiplesImpuestos");
			}
		}
		private Boolean? _esMultiplesImpuestos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ProductoCompuesto
		{
			get { return _id_ProductoCompuesto; }
			set
			{
				ReportPropertyChanging("id_ProductoCompuesto");
				_id_ProductoCompuesto = value;
				ReportPropertyChanged("id_ProductoCompuesto");
			}
		}
		private Int64? _id_ProductoCompuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_UnidadEmpaque
		{
			get { return _id_UnidadEmpaque; }
			set
			{
				ReportPropertyChanging("id_UnidadEmpaque");
				_id_UnidadEmpaque = value;
				ReportPropertyChanged("id_UnidadEmpaque");
			}
		}
		private Int64? _id_UnidadEmpaque;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? cantidadEmpaque
		{
			get { return _cantidadEmpaque; }
			set
			{
				ReportPropertyChanging("cantidadEmpaque");
				_cantidadEmpaque = value;
				ReportPropertyChanged("cantidadEmpaque");
			}
		}
		private Double? _cantidadEmpaque;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoPrecioDivisa
		{
			get { return _MontoPrecioDivisa; }
			set
			{
				ReportPropertyChanging("MontoPrecioDivisa");
				_MontoPrecioDivisa = value;
				ReportPropertyChanged("MontoPrecioDivisa");
			}
		}
		private Double? _MontoPrecioDivisa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoCostoDivisa
		{
			get { return _MontoCostoDivisa; }
			set
			{
				ReportPropertyChanging("MontoCostoDivisa");
				_MontoCostoDivisa = value;
				ReportPropertyChanged("MontoCostoDivisa");
			}
		}
		private Double? _MontoCostoDivisa;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esRegulado
		{
			get { return _esRegulado; }
			set
			{
				ReportPropertyChanging("esRegulado");
				_esRegulado = value;
				ReportPropertyChanged("esRegulado");
			}
		}
		private Boolean? _esRegulado;

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
		/// Productos_MateriaPrima - id_Producto
		/// </summary>
		[Display(Name = "Productos_MateriaPrima")]
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public virtual IList<Productos_MateriaPrima> Productos_MateriaPrima { get; set; }

	}

	[EdmEntityTypeAttribute(Name = "Productos_MateriaPrima")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Productos_MateriaPrima : kssDBBaseEntity
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
		public Int64 id_Producto
		{
			get { return _id_Producto; }
			set
			{
				ReportPropertyChanging("id_Producto");
				_id_Producto = value;
				ReportPropertyChanged("id_Producto");
			}
		}
		private Int64 _id_Producto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CantidadDesperdicio
		{
			get { return _CantidadDesperdicio; }
			set
			{
				ReportPropertyChanging("CantidadDesperdicio");
				_CantidadDesperdicio = value;
				ReportPropertyChanged("CantidadDesperdicio");
			}
		}
		private Double? _CantidadDesperdicio;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_TipoUnidadCompuesto
		{
			get { return _id_TipoUnidadCompuesto; }
			set
			{
				ReportPropertyChanging("id_TipoUnidadCompuesto");
				_id_TipoUnidadCompuesto = value;
				ReportPropertyChanged("id_TipoUnidadCompuesto");
			}
		}
		private Int64 _id_TipoUnidadCompuesto;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CantidadManejo
		{
			get { return _CantidadManejo; }
			set
			{
				ReportPropertyChanging("CantidadManejo");
				_CantidadManejo = value;
				ReportPropertyChanged("CantidadManejo");
			}
		}
		private Double? _CantidadManejo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CantidadOperativos
		{
			get { return _CantidadOperativos; }
			set
			{
				ReportPropertyChanging("CantidadOperativos");
				_CantidadOperativos = value;
				ReportPropertyChanged("CantidadOperativos");
			}
		}
		private Double? _CantidadOperativos;


		/// <summary>
		/// Productos - id_Producto
		/// </summary>
		[Display(Name = "Productos")]
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public virtual Productos Productos { get; set; }

	}

	[EdmEntityTypeAttribute(Name = "TipoComercio")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoComercio : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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


	}

	[EdmEntityTypeAttribute(Name = "Licencias")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Licencias : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Impuestos : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Descirpcion
		{
			get { return _Descirpcion; }
			set
			{
				ReportPropertyChanging("Descirpcion");
				_Descirpcion = value;
				ReportPropertyChanged("Descirpcion");
			}
		}
		private String _Descirpcion;

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

	[EdmEntityTypeAttribute(Name = "Facturas_Servicios")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Servicios : kssDBBaseEntity
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
		public DateTime? FechaRecibe
		{
			get { return _FechaRecibe; }
			set
			{
				ReportPropertyChanging("FechaRecibe");
				_FechaRecibe = value;
				ReportPropertyChanged("FechaRecibe");
			}
		}
		private DateTime? _FechaRecibe;

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

	[EdmEntityTypeAttribute(Name = "Facturas_Modificadas_IF")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Modificadas_IF : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_Modificadas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Modificadas : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_defTipoModificacion
		{
			get { return _id_defTipoModificacion; }
			set
			{
				ReportPropertyChanging("id_defTipoModificacion");
				_id_defTipoModificacion = value;
				ReportPropertyChanged("id_defTipoModificacion");
			}
		}
		private Int64 _id_defTipoModificacion;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Impuestos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_IF")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_IF : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_FormasPago")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_FormasPago : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle_Impuestos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle_Descuentos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle_Descuentos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Facturas_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Detalle : kssDBBaseEntity
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

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? esDevolucion
		{
			get { return _esDevolucion; }
			set
			{
				ReportPropertyChanging("esDevolucion");
				_esDevolucion = value;
				ReportPropertyChanged("esDevolucion");
			}
		}
		private Double? _esDevolucion;


	}

	[EdmEntityTypeAttribute(Name = "Facturas_Descuentos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas_Descuentos : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Modulos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Modulos : kssDBBaseEntity
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
		public Boolean? _modal
		{
			get { return __modal; }
			set
			{
				ReportPropertyChanging("_modal");
				__modal = value;
				ReportPropertyChanged("_modal");
			}
		}
		private Boolean? __modal;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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

	[EdmEntityTypeAttribute(Name = "Facturas")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Facturas : kssDBBaseEntity
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

	[EdmEntityTypeAttribute(Name = "Almacenes")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Almacenes : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public String Direccion
		{
			get { return _Direccion; }
			set
			{
				ReportPropertyChanging("Direccion");
				_Direccion = value;
				ReportPropertyChanged("Direccion");
			}
		}
		private String _Direccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Responsable
		{
			get { return _Responsable; }
			set
			{
				ReportPropertyChanging("Responsable");
				_Responsable = value;
				ReportPropertyChanged("Responsable");
			}
		}
		private String _Responsable;


	}

	[EdmEntityTypeAttribute(Name = "Almacenes_Ajuste")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Almacenes_Ajuste : kssDBBaseEntity
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
		public Int64? id_Almacen
		{
			get { return _id_Almacen; }
			set
			{
				ReportPropertyChanging("id_Almacen");
				_id_Almacen = value;
				ReportPropertyChanged("id_Almacen");
			}
		}
		private Int64? _id_Almacen;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Proveedor
		{
			get { return _id_Proveedor; }
			set
			{
				ReportPropertyChanging("id_Proveedor");
				_id_Proveedor = value;
				ReportPropertyChanged("id_Proveedor");
			}
		}
		private Int64? _id_Proveedor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_Usuario
		{
			get { return _id_Usuario; }
			set
			{
				ReportPropertyChanging("id_Usuario");
				_id_Usuario = value;
				ReportPropertyChanged("id_Usuario");
			}
		}
		private Int64 _id_Usuario;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Responsable
		{
			get { return _Responsable; }
			set
			{
				ReportPropertyChanging("Responsable");
				_Responsable = value;
				ReportPropertyChanged("Responsable");
			}
		}
		private String _Responsable;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NroDocumento
		{
			get { return _NroDocumento; }
			set
			{
				ReportPropertyChanging("NroDocumento");
				_NroDocumento = value;
				ReportPropertyChanged("NroDocumento");
			}
		}
		private String _NroDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? NroControl
		{
			get { return _NroControl; }
			set
			{
				ReportPropertyChanging("NroControl");
				_NroControl = value;
				ReportPropertyChanged("NroControl");
			}
		}
		private Int64? _NroControl;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaAjuste
		{
			get { return _FechaAjuste; }
			set
			{
				ReportPropertyChanging("FechaAjuste");
				_FechaAjuste = value;
				ReportPropertyChanged("FechaAjuste");
			}
		}
		private DateTime? _FechaAjuste;

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
		public Int64? nroItems
		{
			get { return _nroItems; }
			set
			{
				ReportPropertyChanging("nroItems");
				_nroItems = value;
				ReportPropertyChanged("nroItems");
			}
		}
		private Int64? _nroItems;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoAjuste
		{
			get { return _id_defTipoAjuste; }
			set
			{
				ReportPropertyChanging("id_defTipoAjuste");
				_id_defTipoAjuste = value;
				ReportPropertyChanged("id_defTipoAjuste");
			}
		}
		private Int64? _id_defTipoAjuste;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEnEspera
		{
			get { return _esEnEspera; }
			set
			{
				ReportPropertyChanging("esEnEspera");
				_esEnEspera = value;
				ReportPropertyChanged("esEnEspera");
			}
		}
		private Boolean? _esEnEspera;


	}

	[EdmEntityTypeAttribute(Name = "Clientes_Ret_ISRL")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Ret_ISRL : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String Nro_Documento
		{
			get { return _Nro_Documento; }
			set
			{
				ReportPropertyChanging("Nro_Documento");
				_Nro_Documento = value;
				ReportPropertyChanged("Nro_Documento");
			}
		}
		private String _Nro_Documento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoDocumento
		{
			get { return _id_defTipoDocumento; }
			set
			{
				ReportPropertyChanging("id_defTipoDocumento");
				_id_defTipoDocumento = value;
				ReportPropertyChanged("id_defTipoDocumento");
			}
		}
		private Int64? _id_defTipoDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Cliente
		{
			get { return _id_Cliente; }
			set
			{
				ReportPropertyChanging("id_Cliente");
				_id_Cliente = value;
				ReportPropertyChanged("id_Cliente");
			}
		}
		private Int64? _id_Cliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoBase
		{
			get { return _MontoBase; }
			set
			{
				ReportPropertyChanging("MontoBase");
				_MontoBase = value;
				ReportPropertyChanged("MontoBase");
			}
		}
		private Double? _MontoBase;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoIVA
		{
			get { return _MontoIVA; }
			set
			{
				ReportPropertyChanging("MontoIVA");
				_MontoIVA = value;
				ReportPropertyChanged("MontoIVA");
			}
		}
		private Double? _MontoIVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoExento
		{
			get { return _MontoExento; }
			set
			{
				ReportPropertyChanging("MontoExento");
				_MontoExento = value;
				ReportPropertyChanged("MontoExento");
			}
		}
		private Double? _MontoExento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoBaseRetencion
		{
			get { return _MontoBaseRetencion; }
			set
			{
				ReportPropertyChanging("MontoBaseRetencion");
				_MontoBaseRetencion = value;
				ReportPropertyChanged("MontoBaseRetencion");
			}
		}
		private Double? _MontoBaseRetencion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoRetencionAplicada
		{
			get { return _MontoRetencionAplicada; }
			set
			{
				ReportPropertyChanging("MontoRetencionAplicada");
				_MontoRetencionAplicada = value;
				ReportPropertyChanged("MontoRetencionAplicada");
			}
		}
		private Double? _MontoRetencionAplicada;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nroItems
		{
			get { return _nroItems; }
			set
			{
				ReportPropertyChanging("nroItems");
				_nroItems = value;
				ReportPropertyChanged("nroItems");
			}
		}
		private Int64? _nroItems;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoImpresion
		{
			get { return _id_defTipoImpresion; }
			set
			{
				ReportPropertyChanging("id_defTipoImpresion");
				_id_defTipoImpresion = value;
				ReportPropertyChanged("id_defTipoImpresion");
			}
		}
		private Int64? _id_defTipoImpresion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEnEspera
		{
			get { return _esEnEspera; }
			set
			{
				ReportPropertyChanging("esEnEspera");
				_esEnEspera = value;
				ReportPropertyChanged("esEnEspera");
			}
		}
		private Boolean? _esEnEspera;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaEmision
		{
			get { return _FechaEmision; }
			set
			{
				ReportPropertyChanging("FechaEmision");
				_FechaEmision = value;
				ReportPropertyChanged("FechaEmision");
			}
		}
		private DateTime? _FechaEmision;

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


	}

	[EdmEntityTypeAttribute(Name = "Clientes_Ret_IVA")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Ret_IVA : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String NroDocumento
		{
			get { return _NroDocumento; }
			set
			{
				ReportPropertyChanging("NroDocumento");
				_NroDocumento = value;
				ReportPropertyChanged("NroDocumento");
			}
		}
		private String _NroDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoDocumento
		{
			get { return _id_defTipoDocumento; }
			set
			{
				ReportPropertyChanging("id_defTipoDocumento");
				_id_defTipoDocumento = value;
				ReportPropertyChanged("id_defTipoDocumento");
			}
		}
		private Int64? _id_defTipoDocumento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Cliente
		{
			get { return _id_Cliente; }
			set
			{
				ReportPropertyChanging("id_Cliente");
				_id_Cliente = value;
				ReportPropertyChanged("id_Cliente");
			}
		}
		private Int64? _id_Cliente;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoBase
		{
			get { return _MontoBase; }
			set
			{
				ReportPropertyChanging("MontoBase");
				_MontoBase = value;
				ReportPropertyChanged("MontoBase");
			}
		}
		private Double? _MontoBase;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoIVA
		{
			get { return _MontoIVA; }
			set
			{
				ReportPropertyChanging("MontoIVA");
				_MontoIVA = value;
				ReportPropertyChanged("MontoIVA");
			}
		}
		private Double? _MontoIVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoExento
		{
			get { return _MontoExento; }
			set
			{
				ReportPropertyChanging("MontoExento");
				_MontoExento = value;
				ReportPropertyChanged("MontoExento");
			}
		}
		private Double? _MontoExento;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoBaseRetencion
		{
			get { return _MontoBaseRetencion; }
			set
			{
				ReportPropertyChanging("MontoBaseRetencion");
				_MontoBaseRetencion = value;
				ReportPropertyChanged("MontoBaseRetencion");
			}
		}
		private Double? _MontoBaseRetencion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoRetencionIVA
		{
			get { return _MontoRetencionIVA; }
			set
			{
				ReportPropertyChanging("MontoRetencionIVA");
				_MontoRetencionIVA = value;
				ReportPropertyChanged("MontoRetencionIVA");
			}
		}
		private Double? _MontoRetencionIVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? nroDocumentos
		{
			get { return _nroDocumentos; }
			set
			{
				ReportPropertyChanging("nroDocumentos");
				_nroDocumentos = value;
				ReportPropertyChanged("nroDocumentos");
			}
		}
		private Int64? _nroDocumentos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_defTipoImpresion
		{
			get { return _id_defTipoImpresion; }
			set
			{
				ReportPropertyChanging("id_defTipoImpresion");
				_id_defTipoImpresion = value;
				ReportPropertyChanged("id_defTipoImpresion");
			}
		}
		private Int64? _id_defTipoImpresion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Boolean? esEnEspera
		{
			get { return _esEnEspera; }
			set
			{
				ReportPropertyChanging("esEnEspera");
				_esEnEspera = value;
				ReportPropertyChanged("esEnEspera");
			}
		}
		private Boolean? _esEnEspera;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FechaEmision
		{
			get { return _FechaEmision; }
			set
			{
				ReportPropertyChanging("FechaEmision");
				_FechaEmision = value;
				ReportPropertyChanged("FechaEmision");
			}
		}
		private DateTime? _FechaEmision;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_Usuraio
		{
			get { return _id_Usuraio; }
			set
			{
				ReportPropertyChanging("id_Usuraio");
				_id_Usuraio = value;
				ReportPropertyChanged("id_Usuraio");
			}
		}
		private Int64? _id_Usuraio;


	}

	[EdmEntityTypeAttribute(Name = "Clientes_Saldo")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Clientes_Saldo : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public String PeriodoMensualCobro
		{
			get { return _PeriodoMensualCobro; }
			set
			{
				ReportPropertyChanging("PeriodoMensualCobro");
				_PeriodoMensualCobro = value;
				ReportPropertyChanged("PeriodoMensualCobro");
			}
		}
		private String _PeriodoMensualCobro;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? SaldoInicial
		{
			get { return _SaldoInicial; }
			set
			{
				ReportPropertyChanging("SaldoInicial");
				_SaldoInicial = value;
				ReportPropertyChanged("SaldoInicial");
			}
		}
		private Double? _SaldoInicial;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoDebitos
		{
			get { return _MontoDebitos; }
			set
			{
				ReportPropertyChanging("MontoDebitos");
				_MontoDebitos = value;
				ReportPropertyChanged("MontoDebitos");
			}
		}
		private Double? _MontoDebitos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoCreditos
		{
			get { return _MontoCreditos; }
			set
			{
				ReportPropertyChanging("MontoCreditos");
				_MontoCreditos = value;
				ReportPropertyChanged("MontoCreditos");
			}
		}
		private Double? _MontoCreditos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoSaldoActual
		{
			get { return _MontoSaldoActual; }
			set
			{
				ReportPropertyChanging("MontoSaldoActual");
				_MontoSaldoActual = value;
				ReportPropertyChanged("MontoSaldoActual");
			}
		}
		private Double? _MontoSaldoActual;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoAnticipos
		{
			get { return _MontoAnticipos; }
			set
			{
				ReportPropertyChanging("MontoAnticipos");
				_MontoAnticipos = value;
				ReportPropertyChanged("MontoAnticipos");
			}
		}
		private Double? _MontoAnticipos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoSaldoAnticipos
		{
			get { return _MontoSaldoAnticipos; }
			set
			{
				ReportPropertyChanging("MontoSaldoAnticipos");
				_MontoSaldoAnticipos = value;
				ReportPropertyChanged("MontoSaldoAnticipos");
			}
		}
		private Double? _MontoSaldoAnticipos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? MontoSaldoNotasCredito
		{
			get { return _MontoSaldoNotasCredito; }
			set
			{
				ReportPropertyChanging("MontoSaldoNotasCredito");
				_MontoSaldoNotasCredito = value;
				ReportPropertyChanged("MontoSaldoNotasCredito");
			}
		}
		private Double? _MontoSaldoNotasCredito;


	}

	[EdmEntityTypeAttribute(Name = "Vendedores")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Vendedores : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public System.Object Codigo
		{
			get { return _Codigo; }
			set
			{
				ReportPropertyChanging("Codigo");
				_Codigo = value;
				ReportPropertyChanged("Codigo");
			}
		}
		private System.Object _Codigo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Direccion
		{
			get { return _Direccion; }
			set
			{
				ReportPropertyChanging("Direccion");
				_Direccion = value;
				ReportPropertyChanged("Direccion");
			}
		}
		private String _Direccion;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Telefonos
		{
			get { return _Telefonos; }
			set
			{
				ReportPropertyChanging("Telefonos");
				_Telefonos = value;
				ReportPropertyChanged("Telefonos");
			}
		}
		private String _Telefonos;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Fax
		{
			get { return _Fax; }
			set
			{
				ReportPropertyChanging("Fax");
				_Fax = value;
				ReportPropertyChanged("Fax");
			}
		}
		private String _Fax;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String Email
		{
			get { return _Email; }
			set
			{
				ReportPropertyChanging("Email");
				_Email = value;
				ReportPropertyChanged("Email");
			}
		}
		private String _Email;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionVentasPrecio1
		{
			get { return _PComisionVentasPrecio1; }
			set
			{
				ReportPropertyChanging("PComisionVentasPrecio1");
				_PComisionVentasPrecio1 = value;
				ReportPropertyChanged("PComisionVentasPrecio1");
			}
		}
		private Double? _PComisionVentasPrecio1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionVentasPrecio2
		{
			get { return _PComisionVentasPrecio2; }
			set
			{
				ReportPropertyChanging("PComisionVentasPrecio2");
				_PComisionVentasPrecio2 = value;
				ReportPropertyChanged("PComisionVentasPrecio2");
			}
		}
		private Double? _PComisionVentasPrecio2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionVentasPrecio3
		{
			get { return _PComisionVentasPrecio3; }
			set
			{
				ReportPropertyChanging("PComisionVentasPrecio3");
				_PComisionVentasPrecio3 = value;
				ReportPropertyChanged("PComisionVentasPrecio3");
			}
		}
		private Double? _PComisionVentasPrecio3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionVentasPrecioMayor
		{
			get { return _PComisionVentasPrecioMayor; }
			set
			{
				ReportPropertyChanging("PComisionVentasPrecioMayor");
				_PComisionVentasPrecioMayor = value;
				ReportPropertyChanged("PComisionVentasPrecioMayor");
			}
		}
		private Double? _PComisionVentasPrecioMayor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionVentasMinimo
		{
			get { return _PComisionVentasMinimo; }
			set
			{
				ReportPropertyChanging("PComisionVentasMinimo");
				_PComisionVentasMinimo = value;
				ReportPropertyChanged("PComisionVentasMinimo");
			}
		}
		private Double? _PComisionVentasMinimo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionCobroPrecio1
		{
			get { return _PComisionCobroPrecio1; }
			set
			{
				ReportPropertyChanging("PComisionCobroPrecio1");
				_PComisionCobroPrecio1 = value;
				ReportPropertyChanged("PComisionCobroPrecio1");
			}
		}
		private Double? _PComisionCobroPrecio1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionCobroPrecio2
		{
			get { return _PComisionCobroPrecio2; }
			set
			{
				ReportPropertyChanging("PComisionCobroPrecio2");
				_PComisionCobroPrecio2 = value;
				ReportPropertyChanged("PComisionCobroPrecio2");
			}
		}
		private Double? _PComisionCobroPrecio2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionCobroPrecio3
		{
			get { return _PComisionCobroPrecio3; }
			set
			{
				ReportPropertyChanging("PComisionCobroPrecio3");
				_PComisionCobroPrecio3 = value;
				ReportPropertyChanged("PComisionCobroPrecio3");
			}
		}
		private Double? _PComisionCobroPrecio3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionCobroPrecioMayor
		{
			get { return _PComisionCobroPrecioMayor; }
			set
			{
				ReportPropertyChanging("PComisionCobroPrecioMayor");
				_PComisionCobroPrecioMayor = value;
				ReportPropertyChanged("PComisionCobroPrecioMayor");
			}
		}
		private Double? _PComisionCobroPrecioMayor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionCobroMinimo
		{
			get { return _PComisionCobroMinimo; }
			set
			{
				ReportPropertyChanging("PComisionCobroMinimo");
				_PComisionCobroMinimo = value;
				ReportPropertyChanged("PComisionCobroMinimo");
			}
		}
		private Double? _PComisionCobroMinimo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionServicioPrecio1
		{
			get { return _PComisionServicioPrecio1; }
			set
			{
				ReportPropertyChanging("PComisionServicioPrecio1");
				_PComisionServicioPrecio1 = value;
				ReportPropertyChanged("PComisionServicioPrecio1");
			}
		}
		private Double? _PComisionServicioPrecio1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionServicioPrecio2
		{
			get { return _PComisionServicioPrecio2; }
			set
			{
				ReportPropertyChanging("PComisionServicioPrecio2");
				_PComisionServicioPrecio2 = value;
				ReportPropertyChanged("PComisionServicioPrecio2");
			}
		}
		private Double? _PComisionServicioPrecio2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionServicioPrecio3
		{
			get { return _PComisionServicioPrecio3; }
			set
			{
				ReportPropertyChanging("PComisionServicioPrecio3");
				_PComisionServicioPrecio3 = value;
				ReportPropertyChanged("PComisionServicioPrecio3");
			}
		}
		private Double? _PComisionServicioPrecio3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionServicioMayor
		{
			get { return _PComisionServicioMayor; }
			set
			{
				ReportPropertyChanging("PComisionServicioMayor");
				_PComisionServicioMayor = value;
				ReportPropertyChanged("PComisionServicioMayor");
			}
		}
		private Double? _PComisionServicioMayor;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionServicioPrecioMinimo
		{
			get { return _PComisionServicioPrecioMinimo; }
			set
			{
				ReportPropertyChanging("PComisionServicioPrecioMinimo");
				_PComisionServicioPrecioMinimo = value;
				ReportPropertyChanged("PComisionServicioPrecioMinimo");
			}
		}
		private Double? _PComisionServicioPrecioMinimo;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PComisionUtilidad
		{
			get { return _PComisionUtilidad; }
			set
			{
				ReportPropertyChanging("PComisionUtilidad");
				_PComisionUtilidad = value;
				ReportPropertyChanged("PComisionUtilidad");
			}
		}
		private Double? _PComisionUtilidad;

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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double PComisionCobroGral
		{
			get { return _PComisionCobroGral; }
			set
			{
				ReportPropertyChanging("PComisionCobroGral");
				_PComisionCobroGral = value;
				ReportPropertyChanged("PComisionCobroGral");
			}
		}
		private Double _PComisionCobroGral;


	}

	[EdmEntityTypeAttribute(Name = "TipoPago")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class TipoPago : kssDBBaseEntity
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
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_TipoMoneda
		{
			get { return _id_TipoMoneda; }
			set
			{
				ReportPropertyChanging("id_TipoMoneda");
				_id_TipoMoneda = value;
				ReportPropertyChanged("id_TipoMoneda");
			}
		}
		private Int64? _id_TipoMoneda;


	}

	[EdmEntityTypeAttribute(Name = "Compras")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Compras : kssDBBaseEntity
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
		public String DOCUMENTO
		{
			get { return _DOCUMENTO; }
			set
			{
				ReportPropertyChanging("DOCUMENTO");
				_DOCUMENTO = value;
				ReportPropertyChanged("DOCUMENTO");
			}
		}
		private String _DOCUMENTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? TIPO_DOCUMENTO
		{
			get { return _TIPO_DOCUMENTO; }
			set
			{
				ReportPropertyChanging("TIPO_DOCUMENTO");
				_TIPO_DOCUMENTO = value;
				ReportPropertyChanged("TIPO_DOCUMENTO");
			}
		}
		private Int64? _TIPO_DOCUMENTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NUMERO_CONTROL_FISCAL
		{
			get { return _NUMERO_CONTROL_FISCAL; }
			set
			{
				ReportPropertyChanging("NUMERO_CONTROL_FISCAL");
				_NUMERO_CONTROL_FISCAL = value;
				ReportPropertyChanged("NUMERO_CONTROL_FISCAL");
			}
		}
		private String _NUMERO_CONTROL_FISCAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String SERIAL_IMPRESORA_FISCAL
		{
			get { return _SERIAL_IMPRESORA_FISCAL; }
			set
			{
				ReportPropertyChanging("SERIAL_IMPRESORA_FISCAL");
				_SERIAL_IMPRESORA_FISCAL = value;
				ReportPropertyChanged("SERIAL_IMPRESORA_FISCAL");
			}
		}
		private String _SERIAL_IMPRESORA_FISCAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_PROVEEDOR
		{
			get { return _id_PROVEEDOR; }
			set
			{
				ReportPropertyChanging("id_PROVEEDOR");
				_id_PROVEEDOR = value;
				ReportPropertyChanged("id_PROVEEDOR");
			}
		}
		private Int64 _id_PROVEEDOR;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String NOMBRE_COMPRADOR
		{
			get { return _NOMBRE_COMPRADOR; }
			set
			{
				ReportPropertyChanging("NOMBRE_COMPRADOR");
				_NOMBRE_COMPRADOR = value;
				ReportPropertyChanged("NOMBRE_COMPRADOR");
			}
		}
		private String _NOMBRE_COMPRADOR;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DENOMINACION_FISCAL
		{
			get { return _DENOMINACION_FISCAL; }
			set
			{
				ReportPropertyChanging("DENOMINACION_FISCAL");
				_DENOMINACION_FISCAL = value;
				ReportPropertyChanged("DENOMINACION_FISCAL");
			}
		}
		private String _DENOMINACION_FISCAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_MONEDA
		{
			get { return _id_MONEDA; }
			set
			{
				ReportPropertyChanging("id_MONEDA");
				_id_MONEDA = value;
				ReportPropertyChanged("id_MONEDA");
			}
		}
		private Int64 _id_MONEDA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FACTOR_CAMBIO
		{
			get { return _FACTOR_CAMBIO; }
			set
			{
				ReportPropertyChanging("FACTOR_CAMBIO");
				_FACTOR_CAMBIO = value;
				ReportPropertyChanged("FACTOR_CAMBIO");
			}
		}
		private Double? _FACTOR_CAMBIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String REFERENCIA_DOCUMENTO
		{
			get { return _REFERENCIA_DOCUMENTO; }
			set
			{
				ReportPropertyChanging("REFERENCIA_DOCUMENTO");
				_REFERENCIA_DOCUMENTO = value;
				ReportPropertyChanged("REFERENCIA_DOCUMENTO");
			}
		}
		private String _REFERENCIA_DOCUMENTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FECHA_REGISTRO
		{
			get { return _FECHA_REGISTRO; }
			set
			{
				ReportPropertyChanging("FECHA_REGISTRO");
				_FECHA_REGISTRO = value;
				ReportPropertyChanged("FECHA_REGISTRO");
			}
		}
		private DateTime? _FECHA_REGISTRO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FECHA_EMISION
		{
			get { return _FECHA_EMISION; }
			set
			{
				ReportPropertyChanging("FECHA_EMISION");
				_FECHA_EMISION = value;
				ReportPropertyChanged("FECHA_EMISION");
			}
		}
		private DateTime? _FECHA_EMISION;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public System.Object HORA_EMISION
		{
			get { return _HORA_EMISION; }
			set
			{
				ReportPropertyChanging("HORA_EMISION");
				_HORA_EMISION = value;
				ReportPropertyChanged("HORA_EMISION");
			}
		}
		private System.Object _HORA_EMISION;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? DIAS_VENCIMIENTO
		{
			get { return _DIAS_VENCIMIENTO; }
			set
			{
				ReportPropertyChanging("DIAS_VENCIMIENTO");
				_DIAS_VENCIMIENTO = value;
				ReportPropertyChanged("DIAS_VENCIMIENTO");
			}
		}
		private Int64? _DIAS_VENCIMIENTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FECHA_VENCIMIENTO
		{
			get { return _FECHA_VENCIMIENTO; }
			set
			{
				ReportPropertyChanging("FECHA_VENCIMIENTO");
				_FECHA_VENCIMIENTO = value;
				ReportPropertyChanged("FECHA_VENCIMIENTO");
			}
		}
		private DateTime? _FECHA_VENCIMIENTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FECHA_ENTREGA
		{
			get { return _FECHA_ENTREGA; }
			set
			{
				ReportPropertyChanging("FECHA_ENTREGA");
				_FECHA_ENTREGA = value;
				ReportPropertyChanged("FECHA_ENTREGA");
			}
		}
		private DateTime? _FECHA_ENTREGA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_ALMACEN
		{
			get { return _id_ALMACEN; }
			set
			{
				ReportPropertyChanging("id_ALMACEN");
				_id_ALMACEN = value;
				ReportPropertyChanged("id_ALMACEN");
			}
		}
		private Int64 _id_ALMACEN;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTOS_LINEAS
		{
			get { return _TOTAL_DESCUENTOS_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTOS_LINEAS");
				_TOTAL_DESCUENTOS_LINEAS = value;
				ReportPropertyChanged("TOTAL_DESCUENTOS_LINEAS");
			}
		}
		private Double _TOTAL_DESCUENTOS_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_OTROS_COSTOS_LINEAS
		{
			get { return _TOTAL_OTROS_COSTOS_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_OTROS_COSTOS_LINEAS");
				_TOTAL_OTROS_COSTOS_LINEAS = value;
				ReportPropertyChanged("TOTAL_OTROS_COSTOS_LINEAS");
			}
		}
		private Double _TOTAL_OTROS_COSTOS_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_SDCF_LINEAS
		{
			get { return _TOTAL_SDCF_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_SDCF_LINEAS");
				_TOTAL_SDCF_LINEAS = value;
				ReportPropertyChanged("TOTAL_SDCF_LINEAS");
			}
		}
		private Double _TOTAL_SDCF_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_NETO_LINEAS
		{
			get { return _TOTAL_NETO_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_NETO_LINEAS");
				_TOTAL_NETO_LINEAS = value;
				ReportPropertyChanged("TOTAL_NETO_LINEAS");
			}
		}
		private Double _TOTAL_NETO_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO_LINEAS
		{
			get { return _TOTAL_IMPUESTO_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO_LINEAS");
				_TOTAL_IMPUESTO_LINEAS = value;
				ReportPropertyChanged("TOTAL_IMPUESTO_LINEAS");
			}
		}
		private Double _TOTAL_IMPUESTO_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_1
		{
			get { return _DESCUENTO_1; }
			set
			{
				ReportPropertyChanging("DESCUENTO_1");
				_DESCUENTO_1 = value;
				ReportPropertyChanged("DESCUENTO_1");
			}
		}
		private Double _DESCUENTO_1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_1
		{
			get { return _PORC_DESCUENTO_1; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_1");
				_PORC_DESCUENTO_1 = value;
				ReportPropertyChanged("PORC_DESCUENTO_1");
			}
		}
		private Double? _PORC_DESCUENTO_1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_2
		{
			get { return _DESCUENTO_2; }
			set
			{
				ReportPropertyChanging("DESCUENTO_2");
				_DESCUENTO_2 = value;
				ReportPropertyChanged("DESCUENTO_2");
			}
		}
		private Double _DESCUENTO_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_2
		{
			get { return _PORC_DESCUENTO_2; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_2");
				_PORC_DESCUENTO_2 = value;
				ReportPropertyChanged("PORC_DESCUENTO_2");
			}
		}
		private Double? _PORC_DESCUENTO_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double FLETE
		{
			get { return _FLETE; }
			set
			{
				ReportPropertyChanging("FLETE");
				_FLETE = value;
				ReportPropertyChanged("FLETE");
			}
		}
		private Double _FLETE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_FLETE
		{
			get { return _PORC_FLETE; }
			set
			{
				ReportPropertyChanging("PORC_FLETE");
				_PORC_FLETE = value;
				ReportPropertyChanged("PORC_FLETE");
			}
		}
		private Double? _PORC_FLETE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CARGOS_ADICIONALES
		{
			get { return _CARGOS_ADICIONALES; }
			set
			{
				ReportPropertyChanging("CARGOS_ADICIONALES");
				_CARGOS_ADICIONALES = value;
				ReportPropertyChanged("CARGOS_ADICIONALES");
			}
		}
		private Double _CARGOS_ADICIONALES;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTOS
		{
			get { return _TOTAL_DESCUENTOS; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTOS");
				_TOTAL_DESCUENTOS = value;
				ReportPropertyChanged("TOTAL_DESCUENTOS");
			}
		}
		private Double _TOTAL_DESCUENTOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_CARGOS
		{
			get { return _TOTAL_CARGOS; }
			set
			{
				ReportPropertyChanging("TOTAL_CARGOS");
				_TOTAL_CARGOS = value;
				ReportPropertyChanged("TOTAL_CARGOS");
			}
		}
		private Double _TOTAL_CARGOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_SDCF
		{
			get { return _TOTAL_SDCF; }
			set
			{
				ReportPropertyChanging("TOTAL_SDCF");
				_TOTAL_SDCF = value;
				ReportPropertyChanged("TOTAL_SDCF");
			}
		}
		private Double _TOTAL_SDCF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BASE_IMPONIBLE
		{
			get { return _TOTAL_BASE_IMPONIBLE; }
			set
			{
				ReportPropertyChanging("TOTAL_BASE_IMPONIBLE");
				_TOTAL_BASE_IMPONIBLE = value;
				ReportPropertyChanged("TOTAL_BASE_IMPONIBLE");
			}
		}
		private Double _TOTAL_BASE_IMPONIBLE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO
		{
			get { return _TOTAL_IMPUESTO; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO");
				_TOTAL_IMPUESTO = value;
				ReportPropertyChanged("TOTAL_IMPUESTO");
			}
		}
		private Double _TOTAL_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_OPERACION
		{
			get { return _TOTAL_OPERACION; }
			set
			{
				ReportPropertyChanging("TOTAL_OPERACION");
				_TOTAL_OPERACION = value;
				ReportPropertyChanged("TOTAL_OPERACION");
			}
		}
		private Double _TOTAL_OPERACION;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO_MUNICIPAL
		{
			get { return _TOTAL_IMPUESTO_MUNICIPAL; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO_MUNICIPAL");
				_TOTAL_IMPUESTO_MUNICIPAL = value;
				ReportPropertyChanged("TOTAL_IMPUESTO_MUNICIPAL");
			}
		}
		private Double _TOTAL_IMPUESTO_MUNICIPAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO_ADICIONAL
		{
			get { return _TOTAL_IMPUESTO_ADICIONAL; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO_ADICIONAL");
				_TOTAL_IMPUESTO_ADICIONAL = value;
				ReportPropertyChanged("TOTAL_IMPUESTO_ADICIONAL");
			}
		}
		private Double _TOTAL_IMPUESTO_ADICIONAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DOCUMENTO_REF_OTROS_CARGOS
		{
			get { return _DOCUMENTO_REF_OTROS_CARGOS; }
			set
			{
				ReportPropertyChanging("DOCUMENTO_REF_OTROS_CARGOS");
				_DOCUMENTO_REF_OTROS_CARGOS = value;
				ReportPropertyChanged("DOCUMENTO_REF_OTROS_CARGOS");
			}
		}
		private String _DOCUMENTO_REF_OTROS_CARGOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String DOCUMENTO_REFERENCIA_ADUANA
		{
			get { return _DOCUMENTO_REFERENCIA_ADUANA; }
			set
			{
				ReportPropertyChanging("DOCUMENTO_REFERENCIA_ADUANA");
				_DOCUMENTO_REFERENCIA_ADUANA = value;
				ReportPropertyChanged("DOCUMENTO_REFERENCIA_ADUANA");
			}
		}
		private String _DOCUMENTO_REFERENCIA_ADUANA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? RENGLONES_PRODUCTOS_IMPORTADOS
		{
			get { return _RENGLONES_PRODUCTOS_IMPORTADOS; }
			set
			{
				ReportPropertyChanging("RENGLONES_PRODUCTOS_IMPORTADOS");
				_RENGLONES_PRODUCTOS_IMPORTADOS = value;
				ReportPropertyChanged("RENGLONES_PRODUCTOS_IMPORTADOS");
			}
		}
		private Int64? _RENGLONES_PRODUCTOS_IMPORTADOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? RENGLONES_PRODUCTOS_NACIONALES
		{
			get { return _RENGLONES_PRODUCTOS_NACIONALES; }
			set
			{
				ReportPropertyChanging("RENGLONES_PRODUCTOS_NACIONALES");
				_RENGLONES_PRODUCTOS_NACIONALES = value;
				ReportPropertyChanged("RENGLONES_PRODUCTOS_NACIONALES");
			}
		}
		private Int64? _RENGLONES_PRODUCTOS_NACIONALES;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_RETENCION_ISLR
		{
			get { return _TOTAL_RETENCION_ISLR; }
			set
			{
				ReportPropertyChanging("TOTAL_RETENCION_ISLR");
				_TOTAL_RETENCION_ISLR = value;
				ReportPropertyChanged("TOTAL_RETENCION_ISLR");
			}
		}
		private Double _TOTAL_RETENCION_ISLR;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_RETENCION_IVA
		{
			get { return _TOTAL_RETENCION_IVA; }
			set
			{
				ReportPropertyChanging("TOTAL_RETENCION_IVA");
				_TOTAL_RETENCION_IVA = value;
				ReportPropertyChanged("TOTAL_RETENCION_IVA");
			}
		}
		private Double _TOTAL_RETENCION_IVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double PORC_RETENCION_IVA
		{
			get { return _PORC_RETENCION_IVA; }
			set
			{
				ReportPropertyChanging("PORC_RETENCION_IVA");
				_PORC_RETENCION_IVA = value;
				ReportPropertyChanged("PORC_RETENCION_IVA");
			}
		}
		private Double _PORC_RETENCION_IVA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double ANTICIPO_APLICADO
		{
			get { return _ANTICIPO_APLICADO; }
			set
			{
				ReportPropertyChanging("ANTICIPO_APLICADO");
				_ANTICIPO_APLICADO = value;
				ReportPropertyChanged("ANTICIPO_APLICADO");
			}
		}
		private Double _ANTICIPO_APLICADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double NOTA_CREDITO_APLICADA
		{
			get { return _NOTA_CREDITO_APLICADA; }
			set
			{
				ReportPropertyChanging("NOTA_CREDITO_APLICADA");
				_NOTA_CREDITO_APLICADA = value;
				ReportPropertyChanged("NOTA_CREDITO_APLICADA");
			}
		}
		private Double _NOTA_CREDITO_APLICADA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CONTADO
		{
			get { return _CONTADO; }
			set
			{
				ReportPropertyChanging("CONTADO");
				_CONTADO = value;
				ReportPropertyChanged("CONTADO");
			}
		}
		private Double _CONTADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double CREDITO
		{
			get { return _CREDITO; }
			set
			{
				ReportPropertyChanging("CREDITO");
				_CREDITO = value;
				ReportPropertyChanged("CREDITO");
			}
		}
		private Double _CREDITO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_CANCELADO
		{
			get { return _TOTAL_CANCELADO; }
			set
			{
				ReportPropertyChanging("TOTAL_CANCELADO");
				_TOTAL_CANCELADO = value;
				ReportPropertyChanged("TOTAL_CANCELADO");
			}
		}
		private Double _TOTAL_CANCELADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? CORRELATIVO_CXP
		{
			get { return _CORRELATIVO_CXP; }
			set
			{
				ReportPropertyChanging("CORRELATIVO_CXP");
				_CORRELATIVO_CXP = value;
				ReportPropertyChanged("CORRELATIVO_CXP");
			}
		}
		private Int64? _CORRELATIVO_CXP;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? CONDICIONES_PAGO
		{
			get { return _CONDICIONES_PAGO; }
			set
			{
				ReportPropertyChanging("CONDICIONES_PAGO");
				_CONDICIONES_PAGO = value;
				ReportPropertyChanged("CONDICIONES_PAGO");
			}
		}
		private Int64? _CONDICIONES_PAGO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_COSTOS_ASOCIADOS
		{
			get { return _TOTAL_COSTOS_ASOCIADOS; }
			set
			{
				ReportPropertyChanging("TOTAL_COSTOS_ASOCIADOS");
				_TOTAL_COSTOS_ASOCIADOS = value;
				ReportPropertyChanged("TOTAL_COSTOS_ASOCIADOS");
			}
		}
		private Double _TOTAL_COSTOS_ASOCIADOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double SALDO_ABONADO
		{
			get { return _SALDO_ABONADO; }
			set
			{
				ReportPropertyChanging("SALDO_ABONADO");
				_SALDO_ABONADO = value;
				ReportPropertyChanged("SALDO_ABONADO");
			}
		}
		private Double _SALDO_ABONADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? CLASIFICACION_CODIGO
		{
			get { return _CLASIFICACION_CODIGO; }
			set
			{
				ReportPropertyChanging("CLASIFICACION_CODIGO");
				_CLASIFICACION_CODIGO = value;
				ReportPropertyChanged("CLASIFICACION_CODIGO");
			}
		}
		private Int64? _CLASIFICACION_CODIGO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO_AL_LICOR
		{
			get { return _TOTAL_IMPUESTO_AL_LICOR; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO_AL_LICOR");
				_TOTAL_IMPUESTO_AL_LICOR = value;
				ReportPropertyChanged("TOTAL_IMPUESTO_AL_LICOR");
			}
		}
		private Double _TOTAL_IMPUESTO_AL_LICOR;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_MONTO_SUJETO_PRORRATEO
		{
			get { return _TOTAL_MONTO_SUJETO_PRORRATEO; }
			set
			{
				ReportPropertyChanging("TOTAL_MONTO_SUJETO_PRORRATEO");
				_TOTAL_MONTO_SUJETO_PRORRATEO = value;
				ReportPropertyChanged("TOTAL_MONTO_SUJETO_PRORRATEO");
			}
		}
		private Double _TOTAL_MONTO_SUJETO_PRORRATEO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean PENDIENTE
		{
			get { return _PENDIENTE; }
			set
			{
				ReportPropertyChanging("PENDIENTE");
				_PENDIENTE = value;
				ReportPropertyChanged("PENDIENTE");
			}
		}
		private Boolean _PENDIENTE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean TEMPORAL
		{
			get { return _TEMPORAL; }
			set
			{
				ReportPropertyChanging("TEMPORAL");
				_TEMPORAL = value;
				ReportPropertyChanged("TEMPORAL");
			}
		}
		private Boolean _TEMPORAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 id_USUARIO
		{
			get { return _id_USUARIO; }
			set
			{
				ReportPropertyChanging("id_USUARIO");
				_id_USUARIO = value;
				ReportPropertyChanged("id_USUARIO");
			}
		}
		private Int64 _id_USUARIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? id_ESTACION
		{
			get { return _id_ESTACION; }
			set
			{
				ReportPropertyChanging("id_ESTACION");
				_id_ESTACION = value;
				ReportPropertyChanged("id_ESTACION");
			}
		}
		private Int64? _id_ESTACION;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public DateTime? FECHA_HORA_REGISTRO
		{
			get { return _FECHA_HORA_REGISTRO; }
			set
			{
				ReportPropertyChanging("FECHA_HORA_REGISTRO");
				_FECHA_HORA_REGISTRO = value;
				ReportPropertyChanged("FECHA_HORA_REGISTRO");
			}
		}
		private DateTime? _FECHA_HORA_REGISTRO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_NETO
		{
			get { return _TOTAL_NETO; }
			set
			{
				ReportPropertyChanging("TOTAL_NETO");
				_TOTAL_NETO = value;
				ReportPropertyChanged("TOTAL_NETO");
			}
		}
		private Double _TOTAL_NETO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BASE_IMPONIBLE_LINEAS
		{
			get { return _TOTAL_BASE_IMPONIBLE_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_BASE_IMPONIBLE_LINEAS");
				_TOTAL_BASE_IMPONIBLE_LINEAS = value;
				ReportPropertyChanged("TOTAL_BASE_IMPONIBLE_LINEAS");
			}
		}
		private Double _TOTAL_BASE_IMPONIBLE_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BRUTO_LINEAS
		{
			get { return _TOTAL_BRUTO_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_BRUTO_LINEAS");
				_TOTAL_BRUTO_LINEAS = value;
				ReportPropertyChanged("TOTAL_BRUTO_LINEAS");
			}
		}
		private Double _TOTAL_BRUTO_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_LINEAS
		{
			get { return _TOTAL_LINEAS; }
			set
			{
				ReportPropertyChanging("TOTAL_LINEAS");
				_TOTAL_LINEAS = value;
				ReportPropertyChanged("TOTAL_LINEAS");
			}
		}
		private Double _TOTAL_LINEAS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String MOTIVO_DEVOLUCION
		{
			get { return _MOTIVO_DEVOLUCION; }
			set
			{
				ReportPropertyChanging("MOTIVO_DEVOLUCION");
				_MOTIVO_DEVOLUCION = value;
				ReportPropertyChanged("MOTIVO_DEVOLUCION");
			}
		}
		private String _MOTIVO_DEVOLUCION;


	}

	[EdmEntityTypeAttribute(Name = "Compras_Detalle")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Compras_Detalle : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public Int64 NRO_ITEM
		{
			get { return _NRO_ITEM; }
			set
			{
				ReportPropertyChanging("NRO_ITEM");
				_NRO_ITEM = value;
				ReportPropertyChanged("NRO_ITEM");
			}
		}
		private Int64 _NRO_ITEM;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_PRODUCTO
		{
			get { return _ID_PRODUCTO; }
			set
			{
				ReportPropertyChanging("ID_PRODUCTO");
				_ID_PRODUCTO = value;
				ReportPropertyChanged("ID_PRODUCTO");
			}
		}
		private Int64 _ID_PRODUCTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String REFERENCIA
		{
			get { return _REFERENCIA; }
			set
			{
				ReportPropertyChanging("REFERENCIA");
				_REFERENCIA = value;
				ReportPropertyChanged("REFERENCIA");
			}
		}
		private String _REFERENCIA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_MARCA
		{
			get { return _ID_MARCA; }
			set
			{
				ReportPropertyChanging("ID_MARCA");
				_ID_MARCA = value;
				ReportPropertyChanged("ID_MARCA");
			}
		}
		private Int64? _ID_MARCA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String MODELO
		{
			get { return _MODELO; }
			set
			{
				ReportPropertyChanging("MODELO");
				_MODELO = value;
				ReportPropertyChanged("MODELO");
			}
		}
		private String _MODELO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 CODIGO_PRODUCTO_BUSQUEDA
		{
			get { return _CODIGO_PRODUCTO_BUSQUEDA; }
			set
			{
				ReportPropertyChanging("CODIGO_PRODUCTO_BUSQUEDA");
				_CODIGO_PRODUCTO_BUSQUEDA = value;
				ReportPropertyChanged("CODIGO_PRODUCTO_BUSQUEDA");
			}
		}
		private Int64 _CODIGO_PRODUCTO_BUSQUEDA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_GRUPO
		{
			get { return _ID_GRUPO; }
			set
			{
				ReportPropertyChanging("ID_GRUPO");
				_ID_GRUPO = value;
				ReportPropertyChanged("ID_GRUPO");
			}
		}
		private Int64 _ID_GRUPO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_MONEDA
		{
			get { return _ID_MONEDA; }
			set
			{
				ReportPropertyChanging("ID_MONEDA");
				_ID_MONEDA = value;
				ReportPropertyChanged("ID_MONEDA");
			}
		}
		private Int64 _ID_MONEDA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FACTOR_CAMBIO
		{
			get { return _FACTOR_CAMBIO; }
			set
			{
				ReportPropertyChanging("FACTOR_CAMBIO");
				_FACTOR_CAMBIO = value;
				ReportPropertyChanged("FACTOR_CAMBIO");
			}
		}
		private Double? _FACTOR_CAMBIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 ID_ALMACEN
		{
			get { return _ID_ALMACEN; }
			set
			{
				ReportPropertyChanging("ID_ALMACEN");
				_ID_ALMACEN = value;
				ReportPropertyChanged("ID_ALMACEN");
			}
		}
		private Int64 _ID_ALMACEN;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean PRODUCTO_IMPORTADO
		{
			get { return _PRODUCTO_IMPORTADO; }
			set
			{
				ReportPropertyChanging("PRODUCTO_IMPORTADO");
				_PRODUCTO_IMPORTADO = value;
				ReportPropertyChanged("PRODUCTO_IMPORTADO");
			}
		}
		private Boolean _PRODUCTO_IMPORTADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Boolean PRODUCTO_EXENTO_IMPUESTO
		{
			get { return _PRODUCTO_EXENTO_IMPUESTO; }
			set
			{
				ReportPropertyChanging("PRODUCTO_EXENTO_IMPUESTO");
				_PRODUCTO_EXENTO_IMPUESTO = value;
				ReportPropertyChanged("PRODUCTO_EXENTO_IMPUESTO");
			}
		}
		private Boolean _PRODUCTO_EXENTO_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_TIPO_UNIDAD
		{
			get { return _ID_TIPO_UNIDAD; }
			set
			{
				ReportPropertyChanging("ID_TIPO_UNIDAD");
				_ID_TIPO_UNIDAD = value;
				ReportPropertyChanged("ID_TIPO_UNIDAD");
			}
		}
		private Int64? _ID_TIPO_UNIDAD;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FACTOR_UNIDAD
		{
			get { return _FACTOR_UNIDAD; }
			set
			{
				ReportPropertyChanging("FACTOR_UNIDAD");
				_FACTOR_UNIDAD = value;
				ReportPropertyChanged("FACTOR_UNIDAD");
			}
		}
		private Double? _FACTOR_UNIDAD;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public String TIPO_UNIDAD
		{
			get { return _TIPO_UNIDAD; }
			set
			{
				ReportPropertyChanging("TIPO_UNIDAD");
				_TIPO_UNIDAD = value;
				ReportPropertyChanged("TIPO_UNIDAD");
			}
		}
		private String _TIPO_UNIDAD;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_TIPO_UNIDAD_APLICADA
		{
			get { return _ID_TIPO_UNIDAD_APLICADA; }
			set
			{
				ReportPropertyChanging("ID_TIPO_UNIDAD_APLICADA");
				_ID_TIPO_UNIDAD_APLICADA = value;
				ReportPropertyChanged("ID_TIPO_UNIDAD_APLICADA");
			}
		}
		private Int64? _ID_TIPO_UNIDAD_APLICADA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? DIAS_DE_ENTREGA
		{
			get { return _DIAS_DE_ENTREGA; }
			set
			{
				ReportPropertyChanging("DIAS_DE_ENTREGA");
				_DIAS_DE_ENTREGA = value;
				ReportPropertyChanged("DIAS_DE_ENTREGA");
			}
		}
		private Int64? _DIAS_DE_ENTREGA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD
		{
			get { return _CANTIDAD; }
			set
			{
				ReportPropertyChanging("CANTIDAD");
				_CANTIDAD = value;
				ReportPropertyChanged("CANTIDAD");
			}
		}
		private Double? _CANTIDAD;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_2
		{
			get { return _CANTIDAD_2; }
			set
			{
				ReportPropertyChanging("CANTIDAD_2");
				_CANTIDAD_2 = value;
				ReportPropertyChanged("CANTIDAD_2");
			}
		}
		private Double? _CANTIDAD_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_BONIFICADA
		{
			get { return _CANTIDAD_BONIFICADA; }
			set
			{
				ReportPropertyChanging("CANTIDAD_BONIFICADA");
				_CANTIDAD_BONIFICADA = value;
				ReportPropertyChanged("CANTIDAD_BONIFICADA");
			}
		}
		private Double? _CANTIDAD_BONIFICADA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_BONIFICADA_2
		{
			get { return _CANTIDAD_BONIFICADA_2; }
			set
			{
				ReportPropertyChanging("CANTIDAD_BONIFICADA_2");
				_CANTIDAD_BONIFICADA_2 = value;
				ReportPropertyChanged("CANTIDAD_BONIFICADA_2");
			}
		}
		private Double? _CANTIDAD_BONIFICADA_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? TOTAL_CANTIDAD
		{
			get { return _TOTAL_CANTIDAD; }
			set
			{
				ReportPropertyChanging("TOTAL_CANTIDAD");
				_TOTAL_CANTIDAD = value;
				ReportPropertyChanged("TOTAL_CANTIDAD");
			}
		}
		private Double? _TOTAL_CANTIDAD;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_PENDIENTE
		{
			get { return _CANTIDAD_PENDIENTE; }
			set
			{
				ReportPropertyChanging("CANTIDAD_PENDIENTE");
				_CANTIDAD_PENDIENTE = value;
				ReportPropertyChanged("CANTIDAD_PENDIENTE");
			}
		}
		private Double? _CANTIDAD_PENDIENTE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTO_UNITARIO_BRUTO
		{
			get { return _COSTO_UNITARIO_BRUTO; }
			set
			{
				ReportPropertyChanging("COSTO_UNITARIO_BRUTO");
				_COSTO_UNITARIO_BRUTO = value;
				ReportPropertyChanged("COSTO_UNITARIO_BRUTO");
			}
		}
		private Double _COSTO_UNITARIO_BRUTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BRUTO
		{
			get { return _TOTAL_BRUTO; }
			set
			{
				ReportPropertyChanging("TOTAL_BRUTO");
				_TOTAL_BRUTO = value;
				ReportPropertyChanged("TOTAL_BRUTO");
			}
		}
		private Double _TOTAL_BRUTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_UNITARIO_1
		{
			get { return _DESCUENTO_UNITARIO_1; }
			set
			{
				ReportPropertyChanging("DESCUENTO_UNITARIO_1");
				_DESCUENTO_UNITARIO_1 = value;
				ReportPropertyChanged("DESCUENTO_UNITARIO_1");
			}
		}
		private Double _DESCUENTO_UNITARIO_1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_UNITARIO_1
		{
			get { return _PORC_DESCUENTO_UNITARIO_1; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_UNITARIO_1");
				_PORC_DESCUENTO_UNITARIO_1 = value;
				ReportPropertyChanged("PORC_DESCUENTO_UNITARIO_1");
			}
		}
		private Double? _PORC_DESCUENTO_UNITARIO_1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTO_1
		{
			get { return _TOTAL_DESCUENTO_1; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTO_1");
				_TOTAL_DESCUENTO_1 = value;
				ReportPropertyChanged("TOTAL_DESCUENTO_1");
			}
		}
		private Double _TOTAL_DESCUENTO_1;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_UNITARIO_2
		{
			get { return _DESCUENTO_UNITARIO_2; }
			set
			{
				ReportPropertyChanging("DESCUENTO_UNITARIO_2");
				_DESCUENTO_UNITARIO_2 = value;
				ReportPropertyChanged("DESCUENTO_UNITARIO_2");
			}
		}
		private Double _DESCUENTO_UNITARIO_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_UNITARIO_2
		{
			get { return _PORC_DESCUENTO_UNITARIO_2; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_UNITARIO_2");
				_PORC_DESCUENTO_UNITARIO_2 = value;
				ReportPropertyChanged("PORC_DESCUENTO_UNITARIO_2");
			}
		}
		private Double? _PORC_DESCUENTO_UNITARIO_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTO_2
		{
			get { return _TOTAL_DESCUENTO_2; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTO_2");
				_TOTAL_DESCUENTO_2 = value;
				ReportPropertyChanged("TOTAL_DESCUENTO_2");
			}
		}
		private Double _TOTAL_DESCUENTO_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_UNITARIO_3
		{
			get { return _DESCUENTO_UNITARIO_3; }
			set
			{
				ReportPropertyChanging("DESCUENTO_UNITARIO_3");
				_DESCUENTO_UNITARIO_3 = value;
				ReportPropertyChanged("DESCUENTO_UNITARIO_3");
			}
		}
		private Double _DESCUENTO_UNITARIO_3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_UNITARIO_3
		{
			get { return _PORC_DESCUENTO_UNITARIO_3; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_UNITARIO_3");
				_PORC_DESCUENTO_UNITARIO_3 = value;
				ReportPropertyChanged("PORC_DESCUENTO_UNITARIO_3");
			}
		}
		private Double? _PORC_DESCUENTO_UNITARIO_3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTO_3
		{
			get { return _TOTAL_DESCUENTO_3; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTO_3");
				_TOTAL_DESCUENTO_3 = value;
				ReportPropertyChanged("TOTAL_DESCUENTO_3");
			}
		}
		private Double _TOTAL_DESCUENTO_3;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_UNITARIO_4
		{
			get { return _DESCUENTO_UNITARIO_4; }
			set
			{
				ReportPropertyChanging("DESCUENTO_UNITARIO_4");
				_DESCUENTO_UNITARIO_4 = value;
				ReportPropertyChanged("DESCUENTO_UNITARIO_4");
			}
		}
		private Double _DESCUENTO_UNITARIO_4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_DESCUENTO_UNITARIO_4
		{
			get { return _PORC_DESCUENTO_UNITARIO_4; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_UNITARIO_4");
				_PORC_DESCUENTO_UNITARIO_4 = value;
				ReportPropertyChanged("PORC_DESCUENTO_UNITARIO_4");
			}
		}
		private Double? _PORC_DESCUENTO_UNITARIO_4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTO_4
		{
			get { return _TOTAL_DESCUENTO_4; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTO_4");
				_TOTAL_DESCUENTO_4 = value;
				ReportPropertyChanged("TOTAL_DESCUENTO_4");
			}
		}
		private Double _TOTAL_DESCUENTO_4;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double DESCUENTO_UNITARIO_BONIF
		{
			get { return _DESCUENTO_UNITARIO_BONIF; }
			set
			{
				ReportPropertyChanging("DESCUENTO_UNITARIO_BONIF");
				_DESCUENTO_UNITARIO_BONIF = value;
				ReportPropertyChanged("DESCUENTO_UNITARIO_BONIF");
			}
		}
		private Double _DESCUENTO_UNITARIO_BONIF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double PORC_DESCUENTO_BONIF
		{
			get { return _PORC_DESCUENTO_BONIF; }
			set
			{
				ReportPropertyChanging("PORC_DESCUENTO_BONIF");
				_PORC_DESCUENTO_BONIF = value;
				ReportPropertyChanged("PORC_DESCUENTO_BONIF");
			}
		}
		private Double _PORC_DESCUENTO_BONIF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTO_BONIF
		{
			get { return _TOTAL_DESCUENTO_BONIF; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTO_BONIF");
				_TOTAL_DESCUENTO_BONIF = value;
				ReportPropertyChanged("TOTAL_DESCUENTO_BONIF");
			}
		}
		private Double _TOTAL_DESCUENTO_BONIF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_DESCUENTOS
		{
			get { return _TOTAL_DESCUENTOS; }
			set
			{
				ReportPropertyChanging("TOTAL_DESCUENTOS");
				_TOTAL_DESCUENTOS = value;
				ReportPropertyChanged("TOTAL_DESCUENTOS");
			}
		}
		private Double _TOTAL_DESCUENTOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTO_UNITARIO
		{
			get { return _COSTO_UNITARIO; }
			set
			{
				ReportPropertyChanging("COSTO_UNITARIO");
				_COSTO_UNITARIO = value;
				ReportPropertyChanged("COSTO_UNITARIO");
			}
		}
		private Double _COSTO_UNITARIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTOS_DESPERDICIO
		{
			get { return _COSTOS_DESPERDICIO; }
			set
			{
				ReportPropertyChanging("COSTOS_DESPERDICIO");
				_COSTOS_DESPERDICIO = value;
				ReportPropertyChanged("COSTOS_DESPERDICIO");
			}
		}
		private Double _COSTOS_DESPERDICIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_COSTOS_DESPERDICIO
		{
			get { return _PORC_COSTOS_DESPERDICIO; }
			set
			{
				ReportPropertyChanging("PORC_COSTOS_DESPERDICIO");
				_PORC_COSTOS_DESPERDICIO = value;
				ReportPropertyChanged("PORC_COSTOS_DESPERDICIO");
			}
		}
		private Double? _PORC_COSTOS_DESPERDICIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTOS_MANEJO
		{
			get { return _COSTOS_MANEJO; }
			set
			{
				ReportPropertyChanging("COSTOS_MANEJO");
				_COSTOS_MANEJO = value;
				ReportPropertyChanged("COSTOS_MANEJO");
			}
		}
		private Double _COSTOS_MANEJO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_COSTOS_MANEJO
		{
			get { return _PORC_COSTOS_MANEJO; }
			set
			{
				ReportPropertyChanging("PORC_COSTOS_MANEJO");
				_PORC_COSTOS_MANEJO = value;
				ReportPropertyChanged("PORC_COSTOS_MANEJO");
			}
		}
		private Double? _PORC_COSTOS_MANEJO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTOS_OPERATIVOS
		{
			get { return _COSTOS_OPERATIVOS; }
			set
			{
				ReportPropertyChanging("COSTOS_OPERATIVOS");
				_COSTOS_OPERATIVOS = value;
				ReportPropertyChanged("COSTOS_OPERATIVOS");
			}
		}
		private Double _COSTOS_OPERATIVOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_COSTOS_OPERATIVOS
		{
			get { return _PORC_COSTOS_OPERATIVOS; }
			set
			{
				ReportPropertyChanging("PORC_COSTOS_OPERATIVOS");
				_PORC_COSTOS_OPERATIVOS = value;
				ReportPropertyChanged("PORC_COSTOS_OPERATIVOS");
			}
		}
		private Double? _PORC_COSTOS_OPERATIVOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_COSTOS_AGREGADOS
		{
			get { return _TOTAL_COSTOS_AGREGADOS; }
			set
			{
				ReportPropertyChanging("TOTAL_COSTOS_AGREGADOS");
				_TOTAL_COSTOS_AGREGADOS = value;
				ReportPropertyChanged("TOTAL_COSTOS_AGREGADOS");
			}
		}
		private Double _TOTAL_COSTOS_AGREGADOS;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTOS_ADICIONALES
		{
			get { return _COSTOS_ADICIONALES; }
			set
			{
				ReportPropertyChanging("COSTOS_ADICIONALES");
				_COSTOS_ADICIONALES = value;
				ReportPropertyChanged("COSTOS_ADICIONALES");
			}
		}
		private Double _COSTOS_ADICIONALES;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double COSTO_CALCULADO
		{
			get { return _COSTO_CALCULADO; }
			set
			{
				ReportPropertyChanging("COSTO_CALCULADO");
				_COSTO_CALCULADO = value;
				ReportPropertyChanged("COSTO_CALCULADO");
			}
		}
		private Double _COSTO_CALCULADO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_NETO
		{
			get { return _TOTAL_NETO; }
			set
			{
				ReportPropertyChanging("TOTAL_NETO");
				_TOTAL_NETO = value;
				ReportPropertyChanged("TOTAL_NETO");
			}
		}
		private Double _TOTAL_NETO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO
		{
			get { return _TOTAL_IMPUESTO; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO");
				_TOTAL_IMPUESTO = value;
				ReportPropertyChanged("TOTAL_IMPUESTO");
			}
		}
		private Double _TOTAL_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_IMPUESTO
		{
			get { return _PORC_IMPUESTO; }
			set
			{
				ReportPropertyChanging("PORC_IMPUESTO");
				_PORC_IMPUESTO = value;
				ReportPropertyChanged("PORC_IMPUESTO");
			}
		}
		private Double? _PORC_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MONTO_IMPUESTO_MUNICIPAL
		{
			get { return _MONTO_IMPUESTO_MUNICIPAL; }
			set
			{
				ReportPropertyChanging("MONTO_IMPUESTO_MUNICIPAL");
				_MONTO_IMPUESTO_MUNICIPAL = value;
				ReportPropertyChanged("MONTO_IMPUESTO_MUNICIPAL");
			}
		}
		private Double _MONTO_IMPUESTO_MUNICIPAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double MONTO_IMPUESTO_ADICIONAL
		{
			get { return _MONTO_IMPUESTO_ADICIONAL; }
			set
			{
				ReportPropertyChanging("MONTO_IMPUESTO_ADICIONAL");
				_MONTO_IMPUESTO_ADICIONAL = value;
				ReportPropertyChanged("MONTO_IMPUESTO_ADICIONAL");
			}
		}
		private Double _MONTO_IMPUESTO_ADICIONAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL
		{
			get { return _TOTAL; }
			set
			{
				ReportPropertyChanging("TOTAL");
				_TOTAL = value;
				ReportPropertyChanged("TOTAL");
			}
		}
		private Double _TOTAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BASE_IMPONIBLE
		{
			get { return _TOTAL_BASE_IMPONIBLE; }
			set
			{
				ReportPropertyChanging("TOTAL_BASE_IMPONIBLE");
				_TOTAL_BASE_IMPONIBLE = value;
				ReportPropertyChanged("TOTAL_BASE_IMPONIBLE");
			}
		}
		private Double _TOTAL_BASE_IMPONIBLE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO_FISCAL
		{
			get { return _TOTAL_IMPUESTO_FISCAL; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO_FISCAL");
				_TOTAL_IMPUESTO_FISCAL = value;
				ReportPropertyChanged("TOTAL_IMPUESTO_FISCAL");
			}
		}
		private Double _TOTAL_IMPUESTO_FISCAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_SDCF
		{
			get { return _TOTAL_SDCF; }
			set
			{
				ReportPropertyChanging("TOTAL_SDCF");
				_TOTAL_SDCF = value;
				ReportPropertyChanged("TOTAL_SDCF");
			}
		}
		private Double _TOTAL_SDCF;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? ID_PROVEEDOR
		{
			get { return _ID_PROVEEDOR; }
			set
			{
				ReportPropertyChanging("ID_PROVEEDOR");
				_ID_PROVEEDOR = value;
				ReportPropertyChanged("ID_PROVEEDOR");
			}
		}
		private Int64? _ID_PROVEEDOR;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Int64? DIAS_GARANTIA
		{
			get { return _DIAS_GARANTIA; }
			set
			{
				ReportPropertyChanging("DIAS_GARANTIA");
				_DIAS_GARANTIA = value;
				ReportPropertyChanged("DIAS_GARANTIA");
			}
		}
		private Int64? _DIAS_GARANTIA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? FACTOR_CAMBIO_PRECIO
		{
			get { return _FACTOR_CAMBIO_PRECIO; }
			set
			{
				ReportPropertyChanging("FACTOR_CAMBIO_PRECIO");
				_FACTOR_CAMBIO_PRECIO = value;
				ReportPropertyChanged("FACTOR_CAMBIO_PRECIO");
			}
		}
		private Double? _FACTOR_CAMBIO_PRECIO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? ID_IMPUESTO
		{
			get { return _ID_IMPUESTO; }
			set
			{
				ReportPropertyChanging("ID_IMPUESTO");
				_ID_IMPUESTO = value;
				ReportPropertyChanged("ID_IMPUESTO");
			}
		}
		private Double? _ID_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? EXISTENCIA_ACTUAL
		{
			get { return _EXISTENCIA_ACTUAL; }
			set
			{
				ReportPropertyChanging("EXISTENCIA_ACTUAL");
				_EXISTENCIA_ACTUAL = value;
				ReportPropertyChanged("EXISTENCIA_ACTUAL");
			}
		}
		private Double? _EXISTENCIA_ACTUAL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? EXISTENCIA_ACTUAL_2
		{
			get { return _EXISTENCIA_ACTUAL_2; }
			set
			{
				ReportPropertyChanging("EXISTENCIA_ACTUAL_2");
				_EXISTENCIA_ACTUAL_2 = value;
				ReportPropertyChanged("EXISTENCIA_ACTUAL_2");
			}
		}
		private Double? _EXISTENCIA_ACTUAL_2;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_LIBERADA
		{
			get { return _CANTIDAD_LIBERADA; }
			set
			{
				ReportPropertyChanging("CANTIDAD_LIBERADA");
				_CANTIDAD_LIBERADA = value;
				ReportPropertyChanged("CANTIDAD_LIBERADA");
			}
		}
		private Double? _CANTIDAD_LIBERADA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_2_LIBERADA
		{
			get { return _CANTIDAD_2_LIBERADA; }
			set
			{
				ReportPropertyChanging("CANTIDAD_2_LIBERADA");
				_CANTIDAD_2_LIBERADA = value;
				ReportPropertyChanged("CANTIDAD_2_LIBERADA");
			}
		}
		private Double? _CANTIDAD_2_LIBERADA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double RETENCION_ISRL
		{
			get { return _RETENCION_ISRL; }
			set
			{
				ReportPropertyChanging("RETENCION_ISRL");
				_RETENCION_ISRL = value;
				ReportPropertyChanged("RETENCION_ISRL");
			}
		}
		private Double _RETENCION_ISRL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_RETENCION_ISRL
		{
			get { return _PORC_RETENCION_ISRL; }
			set
			{
				ReportPropertyChanging("PORC_RETENCION_ISRL");
				_PORC_RETENCION_ISRL = value;
				ReportPropertyChanged("PORC_RETENCION_ISRL");
			}
		}
		private Double? _PORC_RETENCION_ISRL;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? PORC_COSTOS_ADICIONALES
		{
			get { return _PORC_COSTOS_ADICIONALES; }
			set
			{
				ReportPropertyChanging("PORC_COSTOS_ADICIONALES");
				_PORC_COSTOS_ADICIONALES = value;
				ReportPropertyChanged("PORC_COSTOS_ADICIONALES");
			}
		}
		private Double? _PORC_COSTOS_ADICIONALES;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
		[DataMember]
		public Double? CANTIDAD_BONIFICADA_PENDIENTE
		{
			get { return _CANTIDAD_BONIFICADA_PENDIENTE; }
			set
			{
				ReportPropertyChanging("CANTIDAD_BONIFICADA_PENDIENTE");
				_CANTIDAD_BONIFICADA_PENDIENTE = value;
				ReportPropertyChanged("CANTIDAD_BONIFICADA_PENDIENTE");
			}
		}
		private Double? _CANTIDAD_BONIFICADA_PENDIENTE;


	}

	[EdmEntityTypeAttribute(Name = "Compras_Impuestos")]
	[Serializable]
	[DataContractAttribute(IsReference = true)]
	public partial class Compras_Impuestos : kssDBBaseEntity
	{

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
		public Int64 ID_IMPUESTO
		{
			get { return _ID_IMPUESTO; }
			set
			{
				ReportPropertyChanging("ID_IMPUESTO");
				_ID_IMPUESTO = value;
				ReportPropertyChanged("ID_IMPUESTO");
			}
		}
		private Int64 _ID_IMPUESTO;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Int64 CLASIFICACION
		{
			get { return _CLASIFICACION; }
			set
			{
				ReportPropertyChanging("CLASIFICACION");
				_CLASIFICACION = value;
				ReportPropertyChanged("CLASIFICACION");
			}
		}
		private Int64 _CLASIFICACION;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double ALICUOTA
		{
			get { return _ALICUOTA; }
			set
			{
				ReportPropertyChanging("ALICUOTA");
				_ALICUOTA = value;
				ReportPropertyChanged("ALICUOTA");
			}
		}
		private Double _ALICUOTA;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_BASE_IMPONIBLE
		{
			get { return _TOTAL_BASE_IMPONIBLE; }
			set
			{
				ReportPropertyChanging("TOTAL_BASE_IMPONIBLE");
				_TOTAL_BASE_IMPONIBLE = value;
				ReportPropertyChanged("TOTAL_BASE_IMPONIBLE");
			}
		}
		private Double _TOTAL_BASE_IMPONIBLE;

		/// <summary>
		/// 
		/// </summary>
		[DisplayName(""), Description("")]
		[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
		[DataMember]
		public Double TOTAL_IMPUESTO
		{
			get { return _TOTAL_IMPUESTO; }
			set
			{
				ReportPropertyChanging("TOTAL_IMPUESTO");
				_TOTAL_IMPUESTO = value;
				ReportPropertyChanged("TOTAL_IMPUESTO");
			}
		}
		private Double _TOTAL_IMPUESTO;


	}

}
