using kss_SocialClub.Entities;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;

namespace kss_SocialClub
{
    public class kssSocialClubEntities : ObjectContext
	{
		public kssSocialClubEntities()
			: base("name=kssSocialClubEntities", "kssSocialClubEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public kssSocialClubEntities(string connectionString)
			: base(connectionString, "kssSocialClubEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public kssSocialClubEntities(EntityConnection connection)
			: base(connection, "kssSocialClubEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public override int SaveChanges(SaveOptions options)
		{
			return base.SaveChanges(options);
		}


		private ObjectSet<sqlite_sp_functions> _sqlite_sp_functions;
		public ObjectSet<sqlite_sp_functions> sqlite_sp_functions
		{
			get
			{
				return _sqlite_sp_functions ?? (_sqlite_sp_functions = base.CreateObjectSet<sqlite_sp_functions>());
			}
		}

		private ObjectSet<sqlite_vs_links_names> _sqlite_vs_links_names;
		public ObjectSet<sqlite_vs_links_names> sqlite_vs_links_names
		{
			get
			{
				return _sqlite_vs_links_names ?? (_sqlite_vs_links_names = base.CreateObjectSet<sqlite_vs_links_names>());
			}
		}

		private ObjectSet<sqlite_vs_properties> _sqlite_vs_properties;
		public ObjectSet<sqlite_vs_properties> sqlite_vs_properties
		{
			get
			{
				return _sqlite_vs_properties ?? (_sqlite_vs_properties = base.CreateObjectSet<sqlite_vs_properties>());
			}
		}

		private ObjectSet<sqlite_stat1> _sqlite_stat1;
		public ObjectSet<sqlite_stat1> sqlite_stat1
		{
			get
			{
				return _sqlite_stat1 ?? (_sqlite_stat1 = base.CreateObjectSet<sqlite_stat1>());
			}
		}

		private ObjectSet<sqlite_stat4> _sqlite_stat4;
		public ObjectSet<sqlite_stat4> sqlite_stat4
		{
			get
			{
				return _sqlite_stat4 ?? (_sqlite_stat4 = base.CreateObjectSet<sqlite_stat4>());
			}
		}

		private ObjectSet<sqlite_sequence> _sqlite_sequence;
		public ObjectSet<sqlite_sequence> sqlite_sequence
		{
			get
			{
				return _sqlite_sequence ?? (_sqlite_sequence = base.CreateObjectSet<sqlite_sequence>());
			}
		}

		private ObjectSet<world_paises> _world_paises;
		public ObjectSet<world_paises> world_paises
		{
			get
			{
				return _world_paises ?? (_world_paises = base.CreateObjectSet<world_paises>());
			}
		}

		private ObjectSet<world_regiones> _world_regiones;
		public ObjectSet<world_regiones> world_regiones
		{
			get
			{
				return _world_regiones ?? (_world_regiones = base.CreateObjectSet<world_regiones>());
			}
		}

		private ObjectSet<Clientes> _Clientes;
		public ObjectSet<Clientes> Clientes
		{
			get
			{
				return _Clientes ?? (_Clientes = base.CreateObjectSet<Clientes>());
			}
		}

		private ObjectSet<Empleados> _Empleados;
		public ObjectSet<Empleados> Empleados
		{
			get
			{
				return _Empleados ?? (_Empleados = base.CreateObjectSet<Empleados>());
			}
		}

		private ObjectSet<Cajas> _Cajas;
		public ObjectSet<Cajas> Cajas
		{
			get
			{
				return _Cajas ?? (_Cajas = base.CreateObjectSet<Cajas>());
			}
		}

		private ObjectSet<Cajas_Cortes> _Cajas_Cortes;
		public ObjectSet<Cajas_Cortes> Cajas_Cortes
		{
			get
			{
				return _Cajas_Cortes ?? (_Cajas_Cortes = base.CreateObjectSet<Cajas_Cortes>());
			}
		}

		private ObjectSet<Cajas_Cortes_DetalleEgreso> _Cajas_Cortes_DetalleEgreso;
		public ObjectSet<Cajas_Cortes_DetalleEgreso> Cajas_Cortes_DetalleEgreso
		{
			get
			{
				return _Cajas_Cortes_DetalleEgreso ?? (_Cajas_Cortes_DetalleEgreso = base.CreateObjectSet<Cajas_Cortes_DetalleEgreso>());
			}
		}

		private ObjectSet<Cajas_Cortes_DetalleIngreso> _Cajas_Cortes_DetalleIngreso;
		public ObjectSet<Cajas_Cortes_DetalleIngreso> Cajas_Cortes_DetalleIngreso
		{
			get
			{
				return _Cajas_Cortes_DetalleIngreso ?? (_Cajas_Cortes_DetalleIngreso = base.CreateObjectSet<Cajas_Cortes_DetalleIngreso>());
			}
		}

		private ObjectSet<Cajas_Cortes_IF> _Cajas_Cortes_IF;
		public ObjectSet<Cajas_Cortes_IF> Cajas_Cortes_IF
		{
			get
			{
				return _Cajas_Cortes_IF ?? (_Cajas_Cortes_IF = base.CreateObjectSet<Cajas_Cortes_IF>());
			}
		}

		private ObjectSet<Cajas_Egresos> _Cajas_Egresos;
		public ObjectSet<Cajas_Egresos> Cajas_Egresos
		{
			get
			{
				return _Cajas_Egresos ?? (_Cajas_Egresos = base.CreateObjectSet<Cajas_Egresos>());
			}
		}

		private ObjectSet<Empresa> _Empresa;
		public ObjectSet<Empresa> Empresa
		{
			get
			{
				return _Empresa ?? (_Empresa = base.CreateObjectSet<Empresa>());
			}
		}

		private ObjectSet<Estaciones> _Estaciones;
		public ObjectSet<Estaciones> Estaciones
		{
			get
			{
				return _Estaciones ?? (_Estaciones = base.CreateObjectSet<Estaciones>());
			}
		}

		private ObjectSet<Estaciones_Dipositivo_VisorPrecios> _Estaciones_Dipositivo_VisorPrecios;
		public ObjectSet<Estaciones_Dipositivo_VisorPrecios> Estaciones_Dipositivo_VisorPrecios
		{
			get
			{
				return _Estaciones_Dipositivo_VisorPrecios ?? (_Estaciones_Dipositivo_VisorPrecios = base.CreateObjectSet<Estaciones_Dipositivo_VisorPrecios>());
			}
		}

		private ObjectSet<Estaciones_Dispositivo_Balanza> _Estaciones_Dispositivo_Balanza;
		public ObjectSet<Estaciones_Dispositivo_Balanza> Estaciones_Dispositivo_Balanza
		{
			get
			{
				return _Estaciones_Dispositivo_Balanza ?? (_Estaciones_Dispositivo_Balanza = base.CreateObjectSet<Estaciones_Dispositivo_Balanza>());
			}
		}

		private ObjectSet<Estaciones_Dispositivo_Impresora> _Estaciones_Dispositivo_Impresora;
		public ObjectSet<Estaciones_Dispositivo_Impresora> Estaciones_Dispositivo_Impresora
		{
			get
			{
				return _Estaciones_Dispositivo_Impresora ?? (_Estaciones_Dispositivo_Impresora = base.CreateObjectSet<Estaciones_Dispositivo_Impresora>());
			}
		}

		private ObjectSet<Estaciones_Dispositivos> _Estaciones_Dispositivos;
		public ObjectSet<Estaciones_Dispositivos> Estaciones_Dispositivos
		{
			get
			{
				return _Estaciones_Dispositivos ?? (_Estaciones_Dispositivos = base.CreateObjectSet<Estaciones_Dispositivos>());
			}
		}

		private ObjectSet<Estaciones_Dispositivos_GavetaDinero> _Estaciones_Dispositivos_GavetaDinero;
		public ObjectSet<Estaciones_Dispositivos_GavetaDinero> Estaciones_Dispositivos_GavetaDinero
		{
			get
			{
				return _Estaciones_Dispositivos_GavetaDinero ?? (_Estaciones_Dispositivos_GavetaDinero = base.CreateObjectSet<Estaciones_Dispositivos_GavetaDinero>());
			}
		}

		private ObjectSet<Estaciones_Reportes> _Estaciones_Reportes;
		public ObjectSet<Estaciones_Reportes> Estaciones_Reportes
		{
			get
			{
				return _Estaciones_Reportes ?? (_Estaciones_Reportes = base.CreateObjectSet<Estaciones_Reportes>());
			}
		}

		private ObjectSet<Estaciones_Sesiones> _Estaciones_Sesiones;
		public ObjectSet<Estaciones_Sesiones> Estaciones_Sesiones
		{
			get
			{
				return _Estaciones_Sesiones ?? (_Estaciones_Sesiones = base.CreateObjectSet<Estaciones_Sesiones>());
			}
		}

		private ObjectSet<Estaciones_Sesiones_Detalle> _Estaciones_Sesiones_Detalle;
		public ObjectSet<Estaciones_Sesiones_Detalle> Estaciones_Sesiones_Detalle
		{
			get
			{
				return _Estaciones_Sesiones_Detalle ?? (_Estaciones_Sesiones_Detalle = base.CreateObjectSet<Estaciones_Sesiones_Detalle>());
			}
		}

		private ObjectSet<Facturas> _Facturas;
		public ObjectSet<Facturas> Facturas
		{
			get
			{
				return _Facturas ?? (_Facturas = base.CreateObjectSet<Facturas>());
			}
		}

		private ObjectSet<Facturas_Descuentos> _Facturas_Descuentos;
		public ObjectSet<Facturas_Descuentos> Facturas_Descuentos
		{
			get
			{
				return _Facturas_Descuentos ?? (_Facturas_Descuentos = base.CreateObjectSet<Facturas_Descuentos>());
			}
		}

		private ObjectSet<Facturas_Detalle> _Facturas_Detalle;
		public ObjectSet<Facturas_Detalle> Facturas_Detalle
		{
			get
			{
				return _Facturas_Detalle ?? (_Facturas_Detalle = base.CreateObjectSet<Facturas_Detalle>());
			}
		}

		private ObjectSet<Facturas_Detalle_Descuentos> _Facturas_Detalle_Descuentos;
		public ObjectSet<Facturas_Detalle_Descuentos> Facturas_Detalle_Descuentos
		{
			get
			{
				return _Facturas_Detalle_Descuentos ?? (_Facturas_Detalle_Descuentos = base.CreateObjectSet<Facturas_Detalle_Descuentos>());
			}
		}

		private ObjectSet<Facturas_Detalle_Impuestos> _Facturas_Detalle_Impuestos;
		public ObjectSet<Facturas_Detalle_Impuestos> Facturas_Detalle_Impuestos
		{
			get
			{
				return _Facturas_Detalle_Impuestos ?? (_Facturas_Detalle_Impuestos = base.CreateObjectSet<Facturas_Detalle_Impuestos>());
			}
		}

		private ObjectSet<Facturas_FormasPago> _Facturas_FormasPago;
		public ObjectSet<Facturas_FormasPago> Facturas_FormasPago
		{
			get
			{
				return _Facturas_FormasPago ?? (_Facturas_FormasPago = base.CreateObjectSet<Facturas_FormasPago>());
			}
		}

		private ObjectSet<Facturas_IF> _Facturas_IF;
		public ObjectSet<Facturas_IF> Facturas_IF
		{
			get
			{
				return _Facturas_IF ?? (_Facturas_IF = base.CreateObjectSet<Facturas_IF>());
			}
		}

		private ObjectSet<Facturas_Impuestos> _Facturas_Impuestos;
		public ObjectSet<Facturas_Impuestos> Facturas_Impuestos
		{
			get
			{
				return _Facturas_Impuestos ?? (_Facturas_Impuestos = base.CreateObjectSet<Facturas_Impuestos>());
			}
		}

		private ObjectSet<Facturas_Modificadas> _Facturas_Modificadas;
		public ObjectSet<Facturas_Modificadas> Facturas_Modificadas
		{
			get
			{
				return _Facturas_Modificadas ?? (_Facturas_Modificadas = base.CreateObjectSet<Facturas_Modificadas>());
			}
		}

		private ObjectSet<Facturas_Modificadas_IF> _Facturas_Modificadas_IF;
		public ObjectSet<Facturas_Modificadas_IF> Facturas_Modificadas_IF
		{
			get
			{
				return _Facturas_Modificadas_IF ?? (_Facturas_Modificadas_IF = base.CreateObjectSet<Facturas_Modificadas_IF>());
			}
		}

		private ObjectSet<Facturas_Servicios> _Facturas_Servicios;
		public ObjectSet<Facturas_Servicios> Facturas_Servicios
		{
			get
			{
				return _Facturas_Servicios ?? (_Facturas_Servicios = base.CreateObjectSet<Facturas_Servicios>());
			}
		}

		private ObjectSet<World_idiomas> _World_idiomas;
		public ObjectSet<World_idiomas> World_idiomas
		{
			get
			{
				return _World_idiomas ?? (_World_idiomas = base.CreateObjectSet<World_idiomas>());
			}
		}

		private ObjectSet<Impuestos> _Impuestos;
		public ObjectSet<Impuestos> Impuestos
		{
			get
			{
				return _Impuestos ?? (_Impuestos = base.CreateObjectSet<Impuestos>());
			}
		}

		private ObjectSet<Licencias> _Licencias;
		public ObjectSet<Licencias> Licencias
		{
			get
			{
				return _Licencias ?? (_Licencias = base.CreateObjectSet<Licencias>());
			}
		}

		private ObjectSet<modulos> _modulos;
		public ObjectSet<modulos> modulos
		{
			get
			{
				return _modulos ?? (_modulos = base.CreateObjectSet<modulos>());
			}
		}

		private ObjectSet<Productos> _Productos;
		public ObjectSet<Productos> Productos
		{
			get
			{
				return _Productos ?? (_Productos = base.CreateObjectSet<Productos>());
			}
		}

		private ObjectSet<Productos_Calzado> _Productos_Calzado;
		public ObjectSet<Productos_Calzado> Productos_Calzado
		{
			get
			{
				return _Productos_Calzado ?? (_Productos_Calzado = base.CreateObjectSet<Productos_Calzado>());
			}
		}

		private ObjectSet<productos_Compuestos> _productos_Compuestos;
		public ObjectSet<productos_Compuestos> productos_Compuestos
		{
			get
			{
				return _productos_Compuestos ?? (_productos_Compuestos = base.CreateObjectSet<productos_Compuestos>());
			}
		}

		private ObjectSet<Productos_Familias> _Productos_Familias;
		public ObjectSet<Productos_Familias> Productos_Familias
		{
			get
			{
				return _Productos_Familias ?? (_Productos_Familias = base.CreateObjectSet<Productos_Familias>());
			}
		}

		private ObjectSet<Productos_Farmacia> _Productos_Farmacia;
		public ObjectSet<Productos_Farmacia> Productos_Farmacia
		{
			get
			{
				return _Productos_Farmacia ?? (_Productos_Farmacia = base.CreateObjectSet<Productos_Farmacia>());
			}
		}

		private ObjectSet<Productos_Impuestos> _Productos_Impuestos;
		public ObjectSet<Productos_Impuestos> Productos_Impuestos
		{
			get
			{
				return _Productos_Impuestos ?? (_Productos_Impuestos = base.CreateObjectSet<Productos_Impuestos>());
			}
		}

		private ObjectSet<tipoComercios> _tipoComercios;
		public ObjectSet<tipoComercios> tipoComercios
		{
			get
			{
				return _tipoComercios ?? (_tipoComercios = base.CreateObjectSet<tipoComercios>());
			}
		}

		private ObjectSet<TipoEgreso_Caja> _TipoEgreso_Caja;
		public ObjectSet<TipoEgreso_Caja> TipoEgreso_Caja
		{
			get
			{
				return _TipoEgreso_Caja ?? (_TipoEgreso_Caja = base.CreateObjectSet<TipoEgreso_Caja>());
			}
		}

		private ObjectSet<Productos_Supermercado> _Productos_Supermercado;
		public ObjectSet<Productos_Supermercado> Productos_Supermercado
		{
			get
			{
				return _Productos_Supermercado ?? (_Productos_Supermercado = base.CreateObjectSet<Productos_Supermercado>());
			}
		}

		private ObjectSet<Productos_Marcas> _Productos_Marcas;
		public ObjectSet<Productos_Marcas> Productos_Marcas
		{
			get
			{
				return _Productos_Marcas ?? (_Productos_Marcas = base.CreateObjectSet<Productos_Marcas>());
			}
		}

		private ObjectSet<TipoPago> _TipoPago;
		public ObjectSet<TipoPago> TipoPago
		{
			get
			{
				return _TipoPago ?? (_TipoPago = base.CreateObjectSet<TipoPago>());
			}
		}

		private ObjectSet<TipoPago_Doc> _TipoPago_Doc;
		public ObjectSet<TipoPago_Doc> TipoPago_Doc
		{
			get
			{
				return _TipoPago_Doc ?? (_TipoPago_Doc = base.CreateObjectSet<TipoPago_Doc>());
			}
		}

		private ObjectSet<tipoProductos> _tipoProductos;
		public ObjectSet<tipoProductos> tipoProductos
		{
			get
			{
				return _tipoProductos ?? (_tipoProductos = base.CreateObjectSet<tipoProductos>());
			}
		}

		private ObjectSet<tipoServicio_Status> _tipoServicio_Status;
		public ObjectSet<tipoServicio_Status> tipoServicio_Status
		{
			get
			{
				return _tipoServicio_Status ?? (_tipoServicio_Status = base.CreateObjectSet<tipoServicio_Status>());
			}
		}

		private ObjectSet<UnidadesMedida> _UnidadesMedida;
		public ObjectSet<UnidadesMedida> UnidadesMedida
		{
			get
			{
				return _UnidadesMedida ?? (_UnidadesMedida = base.CreateObjectSet<UnidadesMedida>());
			}
		}

		private ObjectSet<usuarios> _usuarios;
		public ObjectSet<usuarios> usuarios
		{
			get
			{
				return _usuarios ?? (_usuarios = base.CreateObjectSet<usuarios>());
			}
		}

		private ObjectSet<Productos_Club> _Productos_Club;
		public ObjectSet<Productos_Club> Productos_Club
		{
			get
			{
				return _Productos_Club ?? (_Productos_Club = base.CreateObjectSet<Productos_Club>());
			}
		}

		private ObjectSet<Empleados_Club> _Empleados_Club;
		public ObjectSet<Empleados_Club> Empleados_Club
		{
			get
			{
				return _Empleados_Club ?? (_Empleados_Club = base.CreateObjectSet<Empleados_Club>());
			}
		}

		private ObjectSet<Areas_Comunes> _Areas_Comunes;
		public ObjectSet<Areas_Comunes> Areas_Comunes
		{
			get
			{
				return _Areas_Comunes ?? (_Areas_Comunes = base.CreateObjectSet<Areas_Comunes>());
			}
		}

		private ObjectSet<usuarios_detalle> _usuarios_detalle;
		public ObjectSet<usuarios_detalle> usuarios_detalle
		{
			get
			{
				return _usuarios_detalle ?? (_usuarios_detalle = base.CreateObjectSet<usuarios_detalle>());
			}
		}

		private ObjectSet<Usuarios_Grupo> _Usuarios_Grupo;
		public ObjectSet<Usuarios_Grupo> Usuarios_Grupo
		{
			get
			{
				return _Usuarios_Grupo ?? (_Usuarios_Grupo = base.CreateObjectSet<Usuarios_Grupo>());
			}
		}

		private ObjectSet<usuarios_roles> _usuarios_roles;
		public ObjectSet<usuarios_roles> usuarios_roles
		{
			get
			{
				return _usuarios_roles ?? (_usuarios_roles = base.CreateObjectSet<usuarios_roles>());
			}
		}

		private ObjectSet<usuarios_rolesModulo> _usuarios_rolesModulo;
		public ObjectSet<usuarios_rolesModulo> usuarios_rolesModulo
		{
			get
			{
				return _usuarios_rolesModulo ?? (_usuarios_rolesModulo = base.CreateObjectSet<usuarios_rolesModulo>());
			}
		}

		private ObjectSet<ven_municipios> _ven_municipios;
		public ObjectSet<ven_municipios> ven_municipios
		{
			get
			{
				return _ven_municipios ?? (_ven_municipios = base.CreateObjectSet<ven_municipios>());
			}
		}

		private ObjectSet<ven_parroquias> _ven_parroquias;
		public ObjectSet<ven_parroquias> ven_parroquias
		{
			get
			{
				return _ven_parroquias ?? (_ven_parroquias = base.CreateObjectSet<ven_parroquias>());
			}
		}

		private ObjectSet<world_localidades> _world_localidades;
		public ObjectSet<world_localidades> world_localidades
		{
			get
			{
				return _world_localidades ?? (_world_localidades = base.CreateObjectSet<world_localidades>());
			}
		}

		private ObjectSet<World_UnidadesMedida> _World_UnidadesMedida;
		public ObjectSet<World_UnidadesMedida> World_UnidadesMedida
		{
			get
			{
				return _World_UnidadesMedida ?? (_World_UnidadesMedida = base.CreateObjectSet<World_UnidadesMedida>());
			}
		}

		private ObjectSet<world_profesiones> _world_profesiones;
		public ObjectSet<world_profesiones> world_profesiones
		{
			get
			{
				return _world_profesiones ?? (_world_profesiones = base.CreateObjectSet<world_profesiones>());
			}
		}

		private ObjectSet<Registros_Visitas> _Registros_Visitas;
		public ObjectSet<Registros_Visitas> Registros_Visitas
		{
			get
			{
				return _Registros_Visitas ?? (_Registros_Visitas = base.CreateObjectSet<Registros_Visitas>());
			}
		}

		private ObjectSet<Clientes_Medidas> _Clientes_Medidas;
		public ObjectSet<Clientes_Medidas> Clientes_Medidas
		{
			get
			{
				return _Clientes_Medidas ?? (_Clientes_Medidas = base.CreateObjectSet<Clientes_Medidas>());
			}
		}

		private ObjectSet<Clientes_Club> _Clientes_Club;
		public ObjectSet<Clientes_Club> Clientes_Club
		{
			get
			{
				return _Clientes_Club ?? (_Clientes_Club = base.CreateObjectSet<Clientes_Club>());
			}
		}

	}
}
