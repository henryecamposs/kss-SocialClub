using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using kss_DataObjects.Entities;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.EntityClient;

namespace kss_DataObjects
{
	public class kssDBEntities : ObjectContext
	{
		public kssDBEntities()
			: base("name=kssDBEntities", "kssDBEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public kssDBEntities(string connectionString)
			: base(connectionString, "kssDBEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public kssDBEntities(EntityConnection connection)
			: base(connection, "kssDBEntities")
		{
			this.ContextOptions.LazyLoadingEnabled = true;
		}

		public override int SaveChanges(SaveOptions options)
		{
			return base.SaveChanges(options);
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

		private ObjectSet<Estaciones_Dipositivo_VisorPrecios> _Estaciones_Dipositivo_VisorPrecios;
		public ObjectSet<Estaciones_Dipositivo_VisorPrecios> Estaciones_Dipositivo_VisorPrecios
		{
			get
			{
				return _Estaciones_Dipositivo_VisorPrecios ?? (_Estaciones_Dipositivo_VisorPrecios = base.CreateObjectSet<Estaciones_Dipositivo_VisorPrecios>());
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

		private ObjectSet<Empleados_Club> _Empleados_Club;
		public ObjectSet<Empleados_Club> Empleados_Club
		{
			get
			{
				return _Empleados_Club ?? (_Empleados_Club = base.CreateObjectSet<Empleados_Club>());
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

		private ObjectSet<Empleados> _Empleados;
		public ObjectSet<Empleados> Empleados
		{
			get
			{
				return _Empleados ?? (_Empleados = base.CreateObjectSet<Empleados>());
			}
		}

		private ObjectSet<Cajas_EgresosIngresos> _Cajas_EgresosIngresos;
		public ObjectSet<Cajas_EgresosIngresos> Cajas_EgresosIngresos
		{
			get
			{
				return _Cajas_EgresosIngresos ?? (_Cajas_EgresosIngresos = base.CreateObjectSet<Cajas_EgresosIngresos>());
			}
		}

		private ObjectSet<Clientes_Grupo> _Clientes_Grupo;
		public ObjectSet<Clientes_Grupo> Clientes_Grupo
		{
			get
			{
				return _Clientes_Grupo ?? (_Clientes_Grupo = base.CreateObjectSet<Clientes_Grupo>());
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

		private ObjectSet<TipoMoneda_denominaciones> _TipoMoneda_denominaciones;
		public ObjectSet<TipoMoneda_denominaciones> TipoMoneda_denominaciones
		{
			get
			{
				return _TipoMoneda_denominaciones ?? (_TipoMoneda_denominaciones = base.CreateObjectSet<TipoMoneda_denominaciones>());
			}
		}

		private ObjectSet<TipoProductos> _TipoProductos;
		public ObjectSet<TipoProductos> TipoProductos
		{
			get
			{
				return _TipoProductos ?? (_TipoProductos = base.CreateObjectSet<TipoProductos>());
			}
		}

		private ObjectSet<TipoUnidadesMedida> _TipoUnidadesMedida;
		public ObjectSet<TipoUnidadesMedida> TipoUnidadesMedida
		{
			get
			{
				return _TipoUnidadesMedida ?? (_TipoUnidadesMedida = base.CreateObjectSet<TipoUnidadesMedida>());
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

		private ObjectSet<world_paises> _world_paises;
		public ObjectSet<world_paises> world_paises
		{
			get
			{
				return _world_paises ?? (_world_paises = base.CreateObjectSet<world_paises>());
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

		private ObjectSet<world_regiones> _world_regiones;
		public ObjectSet<world_regiones> world_regiones
		{
			get
			{
				return _world_regiones ?? (_world_regiones = base.CreateObjectSet<world_regiones>());
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

		private ObjectSet<Usuarios_Roles> _Usuarios_Roles;
		public ObjectSet<Usuarios_Roles> Usuarios_Roles
		{
			get
			{
				return _Usuarios_Roles ?? (_Usuarios_Roles = base.CreateObjectSet<Usuarios_Roles>());
			}
		}

		private ObjectSet<Usuarios> _Usuarios;
		public ObjectSet<Usuarios> Usuarios
		{
			get
			{
				return _Usuarios ?? (_Usuarios = base.CreateObjectSet<Usuarios>());
			}
		}

		private ObjectSet<Usuarios_RolesModulos> _Usuarios_RolesModulos;
		public ObjectSet<Usuarios_RolesModulos> Usuarios_RolesModulos
		{
			get
			{
				return _Usuarios_RolesModulos ?? (_Usuarios_RolesModulos = base.CreateObjectSet<Usuarios_RolesModulos>());
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

		private ObjectSet<Usuarios_Grupo> _Usuarios_Grupo;
		public ObjectSet<Usuarios_Grupo> Usuarios_Grupo
		{
			get
			{
				return _Usuarios_Grupo ?? (_Usuarios_Grupo = base.CreateObjectSet<Usuarios_Grupo>());
			}
		}

		private ObjectSet<TipoPromociones> _TipoPromociones;
		public ObjectSet<TipoPromociones> TipoPromociones
		{
			get
			{
				return _TipoPromociones ?? (_TipoPromociones = base.CreateObjectSet<TipoPromociones>());
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

		private ObjectSet<Cajas_Cortes> _Cajas_Cortes;
		public ObjectSet<Cajas_Cortes> Cajas_Cortes
		{
			get
			{
				return _Cajas_Cortes ?? (_Cajas_Cortes = base.CreateObjectSet<Cajas_Cortes>());
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

		private ObjectSet<Clientes_Club_Medidas> _Clientes_Club_Medidas;
		public ObjectSet<Clientes_Club_Medidas> Clientes_Club_Medidas
		{
			get
			{
				return _Clientes_Club_Medidas ?? (_Clientes_Club_Medidas = base.CreateObjectSet<Clientes_Club_Medidas>());
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

		private ObjectSet<Productos_Compuestos_Detalle> _Productos_Compuestos_Detalle;
		public ObjectSet<Productos_Compuestos_Detalle> Productos_Compuestos_Detalle
		{
			get
			{
				return _Productos_Compuestos_Detalle ?? (_Productos_Compuestos_Detalle = base.CreateObjectSet<Productos_Compuestos_Detalle>());
			}
		}

		private ObjectSet<TipoDescuentos> _TipoDescuentos;
		public ObjectSet<TipoDescuentos> TipoDescuentos
		{
			get
			{
				return _TipoDescuentos ?? (_TipoDescuentos = base.CreateObjectSet<TipoDescuentos>());
			}
		}

		private ObjectSet<TipoOfertas> _TipoOfertas;
		public ObjectSet<TipoOfertas> TipoOfertas
		{
			get
			{
				return _TipoOfertas ?? (_TipoOfertas = base.CreateObjectSet<TipoOfertas>());
			}
		}

		private ObjectSet<Usuarios_Detalle> _Usuarios_Detalle;
		public ObjectSet<Usuarios_Detalle> Usuarios_Detalle
		{
			get
			{
				return _Usuarios_Detalle ?? (_Usuarios_Detalle = base.CreateObjectSet<Usuarios_Detalle>());
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

		private ObjectSet<Zonas> _Zonas;
		public ObjectSet<Zonas> Zonas
		{
			get
			{
				return _Zonas ?? (_Zonas = base.CreateObjectSet<Zonas>());
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

		private ObjectSet<Impuestos_Detalle> _Impuestos_Detalle;
		public ObjectSet<Impuestos_Detalle> Impuestos_Detalle
		{
			get
			{
				return _Impuestos_Detalle ?? (_Impuestos_Detalle = base.CreateObjectSet<Impuestos_Detalle>());
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

		private ObjectSet<TipoServicioStatus> _TipoServicioStatus;
		public ObjectSet<TipoServicioStatus> TipoServicioStatus
		{
			get
			{
				return _TipoServicioStatus ?? (_TipoServicioStatus = base.CreateObjectSet<TipoServicioStatus>());
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

		private ObjectSet<TipoMoneda_Detalle> _TipoMoneda_Detalle;
		public ObjectSet<TipoMoneda_Detalle> TipoMoneda_Detalle
		{
			get
			{
				return _TipoMoneda_Detalle ?? (_TipoMoneda_Detalle = base.CreateObjectSet<TipoMoneda_Detalle>());
			}
		}

		private ObjectSet<TipoMoneda> _TipoMoneda;
		public ObjectSet<TipoMoneda> TipoMoneda
		{
			get
			{
				return _TipoMoneda ?? (_TipoMoneda = base.CreateObjectSet<TipoMoneda>());
			}
		}

		private ObjectSet<TipoEgresoIngreso_Caja> _TipoEgresoIngreso_Caja;
		public ObjectSet<TipoEgresoIngreso_Caja> TipoEgresoIngreso_Caja
		{
			get
			{
				return _TipoEgresoIngreso_Caja ?? (_TipoEgresoIngreso_Caja = base.CreateObjectSet<TipoEgresoIngreso_Caja>());
			}
		}

		private ObjectSet<TipoDescuentos_Detalle> _TipoDescuentos_Detalle;
		public ObjectSet<TipoDescuentos_Detalle> TipoDescuentos_Detalle
		{
			get
			{
				return _TipoDescuentos_Detalle ?? (_TipoDescuentos_Detalle = base.CreateObjectSet<TipoDescuentos_Detalle>());
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

		private ObjectSet<Proveedores> _Proveedores;
		public ObjectSet<Proveedores> Proveedores
		{
			get
			{
				return _Proveedores ?? (_Proveedores = base.CreateObjectSet<Proveedores>());
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

		private ObjectSet<Productos_Oferta> _Productos_Oferta;
		public ObjectSet<Productos_Oferta> Productos_Oferta
		{
			get
			{
				return _Productos_Oferta ?? (_Productos_Oferta = base.CreateObjectSet<Productos_Oferta>());
			}
		}

		private ObjectSet<Productos_Promociones> _Productos_Promociones;
		public ObjectSet<Productos_Promociones> Productos_Promociones
		{
			get
			{
				return _Productos_Promociones ?? (_Productos_Promociones = base.CreateObjectSet<Productos_Promociones>());
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

		private ObjectSet<Productos_Impuestos> _Productos_Impuestos;
		public ObjectSet<Productos_Impuestos> Productos_Impuestos
		{
			get
			{
				return _Productos_Impuestos ?? (_Productos_Impuestos = base.CreateObjectSet<Productos_Impuestos>());
			}
		}

		private ObjectSet<Productos_Grupo> _Productos_Grupo;
		public ObjectSet<Productos_Grupo> Productos_Grupo
		{
			get
			{
				return _Productos_Grupo ?? (_Productos_Grupo = base.CreateObjectSet<Productos_Grupo>());
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

		private ObjectSet<Productos_Compuestos> _Productos_Compuestos;
		public ObjectSet<Productos_Compuestos> Productos_Compuestos
		{
			get
			{
				return _Productos_Compuestos ?? (_Productos_Compuestos = base.CreateObjectSet<Productos_Compuestos>());
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

		private ObjectSet<Productos_Calzado> _Productos_Calzado;
		public ObjectSet<Productos_Calzado> Productos_Calzado
		{
			get
			{
				return _Productos_Calzado ?? (_Productos_Calzado = base.CreateObjectSet<Productos_Calzado>());
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

		private ObjectSet<Productos_MateriaPrima> _Productos_MateriaPrima;
		public ObjectSet<Productos_MateriaPrima> Productos_MateriaPrima
		{
			get
			{
				return _Productos_MateriaPrima ?? (_Productos_MateriaPrima = base.CreateObjectSet<Productos_MateriaPrima>());
			}
		}

		private ObjectSet<TipoComercio> _TipoComercio;
		public ObjectSet<TipoComercio> TipoComercio
		{
			get
			{
				return _TipoComercio ?? (_TipoComercio = base.CreateObjectSet<TipoComercio>());
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

		private ObjectSet<Impuestos> _Impuestos;
		public ObjectSet<Impuestos> Impuestos
		{
			get
			{
				return _Impuestos ?? (_Impuestos = base.CreateObjectSet<Impuestos>());
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

		private ObjectSet<Facturas_Modificadas_IF> _Facturas_Modificadas_IF;
		public ObjectSet<Facturas_Modificadas_IF> Facturas_Modificadas_IF
		{
			get
			{
				return _Facturas_Modificadas_IF ?? (_Facturas_Modificadas_IF = base.CreateObjectSet<Facturas_Modificadas_IF>());
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

		private ObjectSet<Facturas_Impuestos> _Facturas_Impuestos;
		public ObjectSet<Facturas_Impuestos> Facturas_Impuestos
		{
			get
			{
				return _Facturas_Impuestos ?? (_Facturas_Impuestos = base.CreateObjectSet<Facturas_Impuestos>());
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

		private ObjectSet<Facturas_FormasPago> _Facturas_FormasPago;
		public ObjectSet<Facturas_FormasPago> Facturas_FormasPago
		{
			get
			{
				return _Facturas_FormasPago ?? (_Facturas_FormasPago = base.CreateObjectSet<Facturas_FormasPago>());
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

		private ObjectSet<Facturas_Detalle_Descuentos> _Facturas_Detalle_Descuentos;
		public ObjectSet<Facturas_Detalle_Descuentos> Facturas_Detalle_Descuentos
		{
			get
			{
				return _Facturas_Detalle_Descuentos ?? (_Facturas_Detalle_Descuentos = base.CreateObjectSet<Facturas_Detalle_Descuentos>());
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

		private ObjectSet<Facturas_Descuentos> _Facturas_Descuentos;
		public ObjectSet<Facturas_Descuentos> Facturas_Descuentos
		{
			get
			{
				return _Facturas_Descuentos ?? (_Facturas_Descuentos = base.CreateObjectSet<Facturas_Descuentos>());
			}
		}

		private ObjectSet<Modulos> _Modulos;
		public ObjectSet<Modulos> Modulos
		{
			get
			{
				return _Modulos ?? (_Modulos = base.CreateObjectSet<Modulos>());
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

		private ObjectSet<Almacenes> _Almacenes;
		public ObjectSet<Almacenes> Almacenes
		{
			get
			{
				return _Almacenes ?? (_Almacenes = base.CreateObjectSet<Almacenes>());
			}
		}

		private ObjectSet<Almacenes_Ajuste> _Almacenes_Ajuste;
		public ObjectSet<Almacenes_Ajuste> Almacenes_Ajuste
		{
			get
			{
				return _Almacenes_Ajuste ?? (_Almacenes_Ajuste = base.CreateObjectSet<Almacenes_Ajuste>());
			}
		}

		private ObjectSet<Clientes_Ret_ISRL> _Clientes_Ret_ISRL;
		public ObjectSet<Clientes_Ret_ISRL> Clientes_Ret_ISRL
		{
			get
			{
				return _Clientes_Ret_ISRL ?? (_Clientes_Ret_ISRL = base.CreateObjectSet<Clientes_Ret_ISRL>());
			}
		}

		private ObjectSet<Clientes_Ret_IVA> _Clientes_Ret_IVA;
		public ObjectSet<Clientes_Ret_IVA> Clientes_Ret_IVA
		{
			get
			{
				return _Clientes_Ret_IVA ?? (_Clientes_Ret_IVA = base.CreateObjectSet<Clientes_Ret_IVA>());
			}
		}

		private ObjectSet<Clientes_Saldo> _Clientes_Saldo;
		public ObjectSet<Clientes_Saldo> Clientes_Saldo
		{
			get
			{
				return _Clientes_Saldo ?? (_Clientes_Saldo = base.CreateObjectSet<Clientes_Saldo>());
			}
		}

		private ObjectSet<Vendedores> _Vendedores;
		public ObjectSet<Vendedores> Vendedores
		{
			get
			{
				return _Vendedores ?? (_Vendedores = base.CreateObjectSet<Vendedores>());
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

		private ObjectSet<Compras> _Compras;
		public ObjectSet<Compras> Compras
		{
			get
			{
				return _Compras ?? (_Compras = base.CreateObjectSet<Compras>());
			}
		}

		private ObjectSet<Compras_Detalle> _Compras_Detalle;
		public ObjectSet<Compras_Detalle> Compras_Detalle
		{
			get
			{
				return _Compras_Detalle ?? (_Compras_Detalle = base.CreateObjectSet<Compras_Detalle>());
			}
		}

		private ObjectSet<Compras_Impuestos> _Compras_Impuestos;
		public ObjectSet<Compras_Impuestos> Compras_Impuestos
		{
			get
			{
				return _Compras_Impuestos ?? (_Compras_Impuestos = base.CreateObjectSet<Compras_Impuestos>());
			}
		}

	}
}
