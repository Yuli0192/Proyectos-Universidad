Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

Public Class ClsGestor

#Region "Atributos"
    Dim _usuario As String = "948230984"
    Dim _clsClientePersist As New ClsClientePersist() 'declacara y instancia una variable tipo cliente persistente.
    Dim _clsPlanVentaPersist As New ClsPlanVentaPersist() 'declacara y instancia una variable tipo plan venta persistente.
    Dim _clsServicioPersist As New ClsServicioPersist() 'declacara y instancia una variable tipo servicio persistente.
    Dim _clsGrupoDeVentaPersist As New ClsGrupoDeventaPersist() 'declacara y instancia una variable tipo grupo de ventas persistente.
    Dim _clsUsuarioPersist As New ClsUsuarioPersist() 'declacara y instancia una variable tipo usuario persistente.
    Dim _clsFacturaPersist As New ClsFacturaPersist() 'declacara y instancia una variable tipo factura persistente.
    Dim _clsComisionPersist As New ClsComisionPersist() 'declacara y instancia una variable tipo comisión persistente.
    Dim _usuarios As New List(Of ClsUsuario) 'declarar una variable tipo lista genérica de la clase ClsUsuario
    Dim _clientes As New List(Of ClsCliente) 'declarar una variable tipo lista genérica de la clase ClsCliente
    Dim _planesVentas As New List(Of ClsPlanVenta) 'declarar una variable tipo lista genérica de la clase ClsPlanVenta
    Dim _grupoDeVentas As New List(Of ClsGrupoDeVenta) 'declarar una variable tipo lista genérica de la clase ClsGrupoDeVenta
    Dim _servicios As New List(Of ClsServicio) 'declarar una variable tipo lista genérica de la clase ClsServicio
    Dim _listaFacturas As New List(Of ClsFactura) 'Declara una variable tipo lista genérica de la clase ClsFactura
    Dim _clsPermisoPersist As New ClsPermisoPersist() 'Declara una variable tipo lista genérica de la clase ClsPermiso
    Dim _disponibles As New List(Of ClsUsuario) 'declarar una variable tipo lista genérica de la clase ClsPermisos
    Dim _permisos As New List(Of ClsPermiso) 'declarar una variable tipo lista genérica de la clase ClsPermisos
    Dim _clsComisioPorProductoPersist As New ClsComisionPorProductoPersist() 'declacara y instancia una variable tipo servicio persistente.
    Dim _calculos As New List(Of ClsComisionPorProducto) 'declarar una variable tipo lista genérica de la clase ClsServicio
    Dim _arreglo As New List(Of Array)
#End Region

#Region "Identificar Usuario"

    ''' <summary>
    ''' identificarUsuario
    ''' </summary>
    ''' <param name="pcorreo">correo ingresado por el usuario </param>
    ''' <param name="ppasswordEncript">Clave ingresada por el usuario </param>
    ''' <returns name = "result">Boolean</returns>
    ''' <remarks>Creado por: Emilio Ponce</remarks>
    Public Function identificarUsuario(ByVal pcorreo As String, ByVal ppasswordEncript As String) As Boolean

        Dim result As Boolean = False

        Try
            'Se verifica la existencia del usuario con el correo ingresado
            Dim usuarioActual As ClsUsuario = _clsUsuarioPersist.buscarPorCorreoYContrasenna(pcorreo, ppasswordEncript)

            If Not usuarioActual Is Nothing Then
                result = True
            End If

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

        'retorna resultado de la comnparacion
        Return result

    End Function

#End Region

#Region "Sesion"

    ''' <summary>
    ''' iniciarSession
    ''' </summary>
    ''' <param name="pcorreo">correo ingresado por el usuario </param>
    ''' <param name="ppassword">Clave ingresada por el usuario </param>
    ''' <returns name = "_listaPermisos">List(Of String())</returns>
    ''' <remarks>Creado por: Emilio Ponce</remarks>
    Public Function iniciarSession(ByVal pcorreo As String, ByVal ppassword As String) As ArrayList

        Dim _datos As New ArrayList ' se declara variable que sera retornada
        Dim _result As Boolean ' Variable para el resultado de la comprobacion de los credenciales del usuario a ingresar
        Dim _passwordEncript As String

        _passwordEncript = encriptarPassword(ppassword)

        Try
            '_result = identificarUsuario(pcorreo, _passwordEncript)

            'If _result Then
            Dim usuarioActual As ClsUsuario = _clsUsuarioPersist.buscarPorCorreoYContrasenna(pcorreo, _passwordEncript)

            If Not usuarioActual Is Nothing Then

                _datos.Add(usuarioActual.nombre)
                _datos.Add(usuarioActual.apellido1)
                _datos.Add(usuarioActual.apellido2)
                _datos.Add(usuarioActual.cedula)
                _datos.Add(usuarioActual.rol)
            End If
            ' End If
            Return _datos ' se retorna lista con los permisos del usuario actual.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function encriptarPassword(ByVal ppassword As String) As String

        Try
            Dim cifrar As New UnicodeEncoding()
            Dim byteTexto() As Byte = cifrar.GetBytes(ppassword)
            Dim md5 As New MD5CryptoServiceProvider()
            Dim byteHash() As Byte = md5.ComputeHash(byteTexto)
            Return Convert.ToBase64String(byteHash)
            'cifrar = Nothing
            'byteTexto = Nothing
        Catch ex As Exception
            Throw New Exception("Error al encriptar contraseña: " + ex.Message)
        End Try

    End Function

#End Region

#Region "Factura"

    Public Function buscarFacturaPorAprox(ByVal pnum As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()
        Dim _facturas As New List(Of ClsFactura)

        _facturas = _clsFacturaPersist.buscarPorAprox(pnum) 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _factura As ClsFactura In _facturas
            Dim _datos(9) As String

            _datos(0) = _factura.num.ToString()
            _datos(1) = _factura.idCliente.ToString()
            _datos(2) = _factura.idUsuario.ToString()
            _datos(3) = _factura.fechaFacturacion.ToString()
            _datos(4) = _factura.fechaCreacion.ToString()
            _datos(5) = _factura.fechaValidez.ToString()
            _datos(6) = _factura.moneda.ToString()
            _datos(7) = _factura.estado.ToString()
            _datos(8) = _factura.monto.ToString()
            _datos(9) = _factura.tipoDeCambio.ToString()

            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    Public Sub invalidarFacturas()

        Try
            _clsFacturaPersist.invalidarFacturasVencidas()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    Public Sub registrarFactura(ByVal pnum As String, ByVal pidCliente As String, ByVal pfechaValidez As Date, _
                                ByVal pmoneda As String, ByVal plineaDetalle As String())

        'Dim idUsuario As String = usuarioActual.cedula.ToString()
        Try
            _clsFacturaPersist.registrar(pnum, pidCliente, "123948594", pfechaValidez, _
                                         pmoneda, plineaDetalle)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    Public Function listarFacturas() As List(Of Array)
        Dim listaFacturas As New List(Of ClsFactura) 'Declara una variable tipo lista genérica de la clase ClsGrupoDeVenta
        Dim arreglo As List(Of Array) = New List(Of Array)

        listaFacturas = _clsFacturaPersist.listar()

        For Each _factura As ClsFactura In listaFacturas 'Declara e instancia cada grupo existente en la colección...
            Dim _datos(9) As String

            _datos(0) = _factura.num.ToString()
            _datos(1) = _factura.idCliente.ToString()
            _datos(2) = _factura.idUsuario.ToString()
            _datos(3) = _factura.fechaFacturacion.ToString()
            _datos(4) = _factura.fechaCreacion.ToString()
            _datos(5) = _factura.fechaValidez.ToString()
            _datos(6) = _factura.moneda.ToString()
            _datos(7) = _factura.estado.ToString()
            _datos(8) = _factura.monto.ToString()
            _datos(9) = _factura.tipoDeCambio.ToString()
            arreglo.Add(_datos)
        Next

        Return arreglo
    End Function

    Public Function buscarFacturasPorCliente(ByVal pidCliente As String) As List(Of String())

        Dim listaFacturas As New List(Of ClsFactura) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of String())

        listaFacturas = _clsFacturaPersist.buscarPorCliente(pidCliente)

        For Each _factura As ClsFactura In listaFacturas 'Declara e instancia cada usuario existente en la colección

            Dim _datos(9) As String

            _datos(0) = _factura.num.ToString()
            _datos(1) = _factura.idCliente.ToString()
            _datos(2) = _factura.idUsuario.ToString()
            _datos(3) = _factura.fechaFacturacion.ToString()
            _datos(4) = _factura.fechaCreacion.ToString()
            _datos(5) = _factura.fechaValidez.ToString()
            _datos(6) = _factura.moneda.ToString()
            _datos(7) = _factura.estado.ToString()
            _datos(8) = _factura.monto.ToString()
            _datos(9) = _factura.tipoDeCambio.ToString()

            arreglo.Add(_datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo

    End Function

    Public Function buscarFacturasPorVendedor(ByVal pidUsuario As String) As List(Of Array)

        Dim listaFacturas As New List(Of ClsFactura) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaFacturas = _clsFacturaPersist.buscarPorCliente(pidUsuario)

        For Each _factura As ClsFactura In listaFacturas 'Declara e instancia cada usuario existente en la colección

            Dim _datos(9) As String

            _datos(0) = _factura.num.ToString()
            _datos(1) = _factura.idCliente.ToString()
            _datos(2) = _factura.idUsuario.ToString()
            _datos(3) = _factura.fechaFacturacion.ToString()
            _datos(4) = _factura.fechaCreacion.ToString()
            _datos(5) = _factura.fechaValidez.ToString()
            _datos(6) = _factura.moneda.ToString()
            _datos(7) = _factura.estado.ToString()
            _datos(8) = _factura.monto.ToString()
            _datos(9) = _factura.tipoDeCambio.ToString()

            arreglo.Add(_datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

    Public Sub aceptarFactura(ByVal pnum As String, ByVal ptipoDeCambio As Decimal)
        Try
            _clsFacturaPersist.aceptar(pnum, ptipoDeCambio)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarFactura(ByVal pnum As String)
        Try
            _clsFacturaPersist.eliminar(pnum)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarLineaDetalle(ByVal pnum As String, ByVal plineaDetalle As String())

        Try
            _clsFacturaPersist.agregarLineaDeDetalle(pnum, plineaDetalle)

        Catch ex As Exception

            Throw New System.Exception(ex.Message)

        End Try

    End Sub

    Public Sub eliminarLineaDetalle(ByVal pnum As String, ByVal pcodServicio As String)

        Try
            _clsFacturaPersist.eliminarLineaDeDetalle(pnum, pcodServicio)

        Catch ex As Exception

            Throw New System.Exception(ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de las facturas 
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <remarks></remarks>
    Public Function buscarFacturasPorFecha(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _listaFacturas = _clsFacturaPersist.buscarPorFecha(pidUsuario, pfechaInicio, pfechaFin)

        For Each objFactura As ClsFactura In _listaFacturas 'Declara e instancia cada usuario existente en la colección
            Dim datosCliente As String() = buscarClienteId(objFactura.idCliente)(0)
            Dim datos As String() = {objFactura.num.ToString(), datosCliente(1), objFactura.idUsuario.ToString(), _
                                  objFactura.fechaFacturacion.ToString(), objFactura.fechaCreacion.ToString(), objFactura.fechaValidez.ToString() _
                                  , objFactura.moneda.ToString(), objFactura.estado.ToString(), objFactura.monto.ToString(), objFactura.tipoDeCambio.ToString()}
            _arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un cliente 
    ''' </summary>
    ''' <param name="pnum"></param>
    ''' <remarks></remarks>
    Public Function buscarFactura(ByVal pnum As String) As List(Of Array)
        ' Dim _arreglo As New List(Of Array)
        Dim _factura As ClsFactura 'declarar una variable de tipo de la clase ClsFactura
        Dim _arreglo As List(Of Array) = New List(Of Array)
        _factura = _clsFacturaPersist.buscar(pnum) 'llama el método buscar por id de la clase cliente persistente pasandole el dato del cliente.

        Dim _datos As String() = {_factura.num.ToString(), _factura.idCliente.ToString(), _factura.idUsuario.ToString(), _
                                  _factura.fechaFacturacion.ToString(), _factura.fechaCreacion.ToString(), _factura.fechaValidez.ToString() _
                                  , _factura.moneda.ToString(), _factura.estado.ToString(), _factura.monto.ToString(), _factura.tipoDeCambio.ToString()} 'declarar e instanciar la factura existente en la colección...

        _arreglo.Add(_datos) 'agregar cada factura de la colección al arreglo (una lista genérica de Array)
        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar las lineas de detalles de la factura
    ''' </summary>
    ''' <param name="pnum"></param>
    ''' <remarks></remarks>
    Public Function buscarDetalleFactura(ByVal pnum As String) As List(Of Array)

        Dim _detalle As New List(Of Array)
        _detalle = _clsFacturaPersist.buscarDetalle(pnum)
        Return _detalle

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de las facturas 
    ''' </summary>
    ''' <param name="pcodGrupo"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <remarks></remarks>
    Public Function obtenerVentasGeneralesGrupo(ByVal pcodGrupo As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of Array)

        Dim _arreglo As New List(Of Array)()
        _listaFacturas = _clsFacturaPersist.buscarPorFechaPorGrupo(pcodGrupo, pfechaInicio, pfechaFin)
        For Each objFactura As ClsFactura In _listaFacturas 'Declara e instancia cada usuario existente en la colección
            Dim datosCliente As String() = buscarClienteId(objFactura.idCliente)(0)
            Dim datosUsuario As String() = buscarUsuarioId(objFactura.idUsuario)(0)
            Dim datos As String() = {objFactura.num.ToString(), datosCliente(1), datosUsuario(1), _
                                  objFactura.fechaFacturacion.ToString(), objFactura.fechaCreacion.ToString(), objFactura.fechaValidez.ToString() _
                                  , objFactura.moneda.ToString(), objFactura.estado.ToString(), objFactura.monto.ToString(), objFactura.tipoDeCambio.ToString()}
            _arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de sumar los montos de las facturas den un grupo de ventas
    ''' </summary>
    ''' <remarks></remarks>
    Public Function obtenerMontoTotalVentasGeneralesGrupo() As Decimal

        Dim _montoTotal As Decimal = 0

        For Each objFactura As ClsFactura In _listaFacturas 'Declara e instancia cada usuario existente en la colección
            Dim datosCliente As String() = buscarClienteId(objFactura.idCliente)(0)
            Dim datosUsuario As String() = buscarUsuarioId(objFactura.idUsuario)(0)
            _montoTotal = _montoTotal + objFactura.monto.ToString()

        Next
        Return _montoTotal

    End Function

#End Region

#Region "Grupo de venta"

    Public Function buscarServicioDispParaGrupo(ByVal codGrupo As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _servicios = _clsServicioPersist.buscarServiciosDispGrupo(codGrupo) 'llama el método buscar por nombre de la clase servicio persistente pasandole el dato del plan de ventas.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.precioColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    Public Function buscarGrupoPorAprox(ByVal pcodGrupo As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()
        Dim _Grupos As New List(Of ClsGrupoDeVenta)

        _Grupos = _clsGrupoDeVentaPersist.buscarPorAprox(pcodGrupo) 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _grupo As ClsGrupoDeVenta In _Grupos
            Dim datos As String() = {_grupo.codigo.ToString(), _grupo.descripcion.ToString(), _
                                     _grupo.idEncargado.ToString}
            _arreglo.Add(datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    Public Function listarGrupos() As List(Of Array)
        Dim listaGrupos As New List(Of ClsGrupoDeVenta) 'Declara una variable tipo lista genérica de la clase ClsGrupoDeVenta
        Dim arreglo As List(Of Array) = New List(Of Array)

        listaGrupos = _clsGrupoDeVentaPersist.listar()

        For Each objGrupo As ClsGrupoDeVenta In listaGrupos 'Declara e instancia cada grupo existente en la colección...
            Dim datos As String() = {objGrupo.codigo.ToString(), objGrupo.descripcion.ToString(), _
                                     objGrupo.idEncargado.ToString}
            arreglo.Add(datos)
        Next

        Return arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los grupo de ventas 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarGrupoDeVenta() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _grupoDeVentas = _clsGrupoDeVentaPersist.listar() 'llama el método listar de la clase grupo de venta persistente.

        For Each _grupo As ClsGrupoDeVenta In _grupoDeVentas

            Dim _datos As String() = {_grupo.codigo.ToString(), _grupo.descripcion.ToString(), _grupo.encargado.ToString()} 'declarar e instanciar cada grupo de venta existente en la colección...

            _arreglo.Add(_datos) 'agregar cada grupo de venta de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    Public Sub registrarGrupoDeVenta(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado _
                                     As String, ByVal pidVendedores As ArrayList, ByVal pidServicios As ArrayList)

        Try
            _clsGrupoDeVentaPersist.registrar(pcodigo, pdescripcion, pidEncargado, pidVendedores, pidServicios)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    Public Function buscarGrupoDeVentaReturnArray(ByVal pcodigo As String) As List(Of Array)

        Dim _grupo As ClsGrupoDeVenta
        Dim _datos(2) As String
        Dim arreglo As List(Of Array) = New List(Of Array)

        _grupo = _clsGrupoDeVentaPersist.buscar(pcodigo)

        If Not _grupo Is Nothing Then

            _datos(0) = _grupo.codigo.ToString()
            _datos(1) = _grupo.descripcion.ToString()
            _datos(2) = _grupo.idEncargado.ToString()
        End If
        arreglo.Add(_datos)
        Return arreglo

    End Function

    Public Function buscarGrupoDeVenta(ByVal pcodigo As String) As String()

        Dim _grupo As ClsGrupoDeVenta
        Dim _datos(2) As String

        _grupo = _clsGrupoDeVentaPersist.buscar(pcodigo)

        If Not _grupo Is Nothing Then

            _datos(0) = _grupo.codigo.ToString()
            _datos(1) = _grupo.descripcion.ToString()
            _datos(2) = _grupo.idEncargado.ToString()
        End If

        Return _datos

    End Function

    Public Sub modificarGrupoDeVenta(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado As String)

        Try
            _clsGrupoDeVentaPersist.modificar(pcodigo, pdescripcion, pidEncargado)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarGrupoDeVenta(ByVal pcodigo As String)

        Try
            _clsGrupoDeVentaPersist.eliminar(pcodigo)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarVendedorAGrupoDeVenta(ByVal pcodigo As String, ByVal pidVendedor As String)

        Try
            _clsGrupoDeVentaPersist.agregarVendedorAGrupoDeVenta(pcodigo, pidVendedor)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarVendedorDeUnGrupoDeVenta(ByVal pcodigo As String, ByVal pidVendedor As String)

        Try
            _clsGrupoDeVentaPersist.eliminarVendedorDeGrupoDeVenta(pcodigo, pidVendedor)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarServicioAGrupoDeVenta(ByVal pcodigo As String, ByVal pidServicio As String)

        Try
            _clsGrupoDeVentaPersist.agregarServicioAGrupoDeVenta(pcodigo, pidServicio)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarServicioDeUnGrupoDeVenta(ByVal pcodigo As String, ByVal pidServicio As String)

        Try
            _clsGrupoDeVentaPersist.eliminarServicioDeGrupoDeVenta(pcodigo, pidServicio)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function buscarUsuariosDeUnGrupoDeVentas(ByVal pcodigo As String) As List(Of Array)

        Dim listaUsuarios As New List(Of ClsUsuario) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)

        listaUsuarios = _clsUsuarioPersist.buscarPorGrupoDeVentas(pcodigo)

        For Each objUsuario As ClsUsuario In listaUsuarios 'Declara e instancia cada usuario existente en la colección
            Dim datos As String() = {objUsuario.cedula.ToString(), objUsuario.nombre.ToString(), objUsuario.apellido1.ToString, _
                                     objUsuario.apellido2.ToString, objUsuario.correo.ToString, objUsuario.departamento, _
                                     objUsuario.rol}
            arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

    Public Function buscarServiciosDeUnGrupoDeVentas(ByVal pcodigo As String) As List(Of Array)

        Dim listaServicios As New List(Of ClsServicio) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaServicios = _clsServicioPersist.buscarPorGrupoDeVentas(pcodigo)

        For Each objServicio As ClsServicio In listaServicios 'Declara e instancia cada usuario existente en la colección
            Dim datos As String() = {objServicio.cod, objServicio.nombre, objServicio.descripcion, objServicio.precioColones, _
                                     objServicio.precioDolares, objServicio.porcentComisionJuniorColones, _
                                     objServicio.porcentComisionJuniorDolares, objServicio.porcentComisionMasterColones, _
                                     objServicio.porcentComisionMasterDolares, objServicio.porcentComisionSeniorColones, _
                                     objServicio.porcentComisionSeniorDolares}
            arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

#End Region

#Region "Usuario"

    Public Function buscarVendedorDispParaGrupo(ByVal codGrupo As String) As List(Of Array)

        Dim _vendedores As New List(Of ClsUsuario)

        Dim _arreglo As New List(Of Array)()

        _vendedores = _clsUsuarioPersist.buscarVendedoresDispGrupo(codGrupo) 'llama el método buscar por nombre de la clase servicio persistente pasandole el dato del plan de ventas.

        For Each objUsuario As ClsUsuario In _vendedores

            Dim datos As String() = {objUsuario.cedula.ToString(), objUsuario.nombre.ToString(), objUsuario.apellido1.ToString, objUsuario.apellido2.ToString, objUsuario.rol.ToString}

            _arreglo.Add(datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    Public Sub asignarCliente(ByVal pidCliente As String, ByVal pidUsuario As String)
        Try
            _clsClientePersist.asignarClienteUsuario(pidCliente, pidUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarmastersgerentesdisponibles() As List(Of Array)
        Dim _proc = My.Resources.proclistarmastersgerentesdisponibles.ToString()

        _arreglo.Clear()

        _disponibles = _clsUsuarioPersist.listarmastersgerentesdisponibles(_proc) 'llama el método listar de la clase permiso persistente.

        For Each _permiso As ClsUsuario In _disponibles

            Dim _datos As String() = {_permiso.cedula.ToString(), _permiso.nombre.ToString(), _permiso.apellido1.ToString(), _permiso.apellido2.ToString(), _permiso.rol.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    'Public Function listarmastersgerentesdisponibles() As List(Of Array)
    '    Dim _proc = My.Resources.proclistarmastersgerentesdisponibles.ToString()

    '    _arreglo.Clear()

    '    _disponibles = _clsUsuarioPersist.listarmastersgerentesdisponibles(_proc) 'llama el método listar de la clase permiso persistente.

    '    For Each _permiso As ClsUsuario In _disponibles

    '        Dim _datos As String() = {_permiso.cedula.ToString(), _permiso.nombre.ToString(), _permiso.apellido1.ToString(), _permiso.apellido2.ToString(), _permiso.rol.ToString()} 'declarar e instanciar cada servicio existente en la colección...

    '        _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
    '    Next

    '    Return _arreglo

    'End Function

    ''' <summary>
    ''' Función de la clase encargado de encriptar el texto que recibe por parámetro
    ''' </summary>
    ''' <param name="pCadena"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function stringEncript(ByVal pCadena As String) As String
        Dim _arrByte As Byte()
        Dim _hash As New SHA256CryptoServiceProvider()

        _arrByte = _hash.ComputeHash(Encoding.UTF8.GetBytes(pCadena))

        Return Convert.ToBase64String(_arrByte)
    End Function

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente los datos de un usuario a registrar
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcorreoElectronico"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <param name="prol"></param>
    ''' <param name="pdepartamento"></param>
    ''' <remarks></remarks>
    ''' 
    Public Sub registrarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, _
                                ByVal pcorreoElectronico As String, ByVal pcontrasenna As String, ByVal prol As String, ByVal pdepartamento As String)


        pcontrasenna = encriptarPassword(pcontrasenna) 'Se llama a una función para encontrar la contraseña

        Try
            _clsUsuarioPersist.registrar(pcedula, pnombre, papellido1, papellido2, pcorreoElectronico, pcontrasenna, prol, pdepartamento) 'Llama al sub de registrar usuario de la clase persistente
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    '''' <summary>
    '''' Función encargada de enviar al objeto persistente la identificación del usuario que se desea encontrar
    '''' </summary>
    '''' <param name="pidUsuario"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function buscarUsuarioId(ByVal pidUsuario As String) As String()

    '    Dim _datos(6) As String
    '    Dim objUsuario As ClsUsuario 'Declara una variable tipo ClsUsuario

    '    objUsuario = _clsUsuarioPersist.buscarPorId(pidUsuario)

    '    If Not objUsuario Is Nothing Then

    '        'Datos del usuario resultante de la búsqueda
    '        _datos(0) = objUsuario.cedula.ToString()
    '        _datos(1) = objUsuario.nombre.ToString()
    '        _datos(2) = objUsuario.apellido1.ToString()
    '        _datos(3) = objUsuario.apellido2.ToString()
    '        _datos(4) = objUsuario.correo.ToString()
    '        _datos(5) = objUsuario.departamento.ToString()
    '        _datos(6) = objUsuario.rol.ToString()

    '    End If

    '    Return _datos
    'End Function

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente la identificación del usuario que se desea encontrar
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarUsuarioId(ByVal pidUsuario As String) As List(Of Array)
        Dim listaUsuarios As New List(Of ClsUsuario) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaUsuarios = _clsUsuarioPersist.buscarXId(pidUsuario)

        For Each objUsuario As ClsUsuario In listaUsuarios 'Declara e instancia cada usuario existente en la colección
            Dim datos As String() = {objUsuario.cedula.ToString(), objUsuario.nombre.ToString(), objUsuario.apellido1.ToString, objUsuario.apellido2.ToString, objUsuario.correo.ToString, objUsuario.rol.ToString, objUsuario.coddepartamento.ToString(), objUsuario.departamento.ToString}
            arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

    Public Function buscarUsuarioIdReturnArray(ByVal pidUsuario As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)
        Dim _Usuario As ClsUsuario 'Declara una variable tipo ClsUsuario
        _Usuario = _clsUsuarioPersist.buscarPorId(pidUsuario) 'llama el método buscar por id de la clase cliente persistente pasandole el dato del cliente.

        Dim _datos As String() = {_Usuario.cedula.ToString(), _Usuario.nombre.ToString(), _Usuario.apellido1.ToString(), _
                                  _Usuario.apellido2.ToString(), _Usuario.correo.ToString(), _Usuario.departamento.ToString(), _
                                _Usuario.rol.ToString()} 'declarar e instanciar el cliente existente en la colección...

        _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)

        Return _arreglo
    End Function

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente el nombre o la aproximación del nombre que se desea encontrar
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarUsuarioPorNombre(ByVal pnombre As String) As List(Of Array)
        Dim listaUsuarios As New List(Of ClsUsuario) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaUsuarios = _clsUsuarioPersist.buscarPorNombre(pnombre)

        For Each objUsuario As ClsUsuario In listaUsuarios 'Declara e instancia cada usuario existente en la colección
            Dim datos As String() = {objUsuario.cedula.ToString(), objUsuario.nombre.ToString(), objUsuario.apellido1.ToString, objUsuario.apellido2.ToString, objUsuario.correo.ToString, objUsuario.rol.ToString, objUsuario.coddepartamento.ToString(), objUsuario.departamento.ToString}
            arreglo.Add(datos) 'Agrega cada Usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

    ''' <summary>
    ''' Función encargada de listar los usuarios registrados en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarUsuarios() As List(Of Array)
        Dim listaUsuarios As New List(Of ClsUsuario) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaUsuarios = _clsUsuarioPersist.listar()

        For Each objUsuario As ClsUsuario In listaUsuarios 'Declara e instancia cada usuario existente en la colección...
            Dim datos As String() = {objUsuario.cedula.ToString(), objUsuario.nombre.ToString(), objUsuario.apellido1.ToString, objUsuario.apellido2.ToString, objUsuario.correo.ToString, objUsuario.rol.ToString, objUsuario.coddepartamento.ToString(), objUsuario.departamento.ToString}
            arreglo.Add(datos) 'Agrega cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente los datos de un usuario a modificar
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcorreo"></param>
    ''' <param name="prol"></param>
    ''' <param name="pdepartamento"></param>
    ''' <remarks></remarks>
    Public Sub modificarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                                ByVal papellido2 As String, ByVal pcorreo As String, ByVal prol As String, ByVal pdepartamento As String)

        Try
            _clsUsuarioPersist.modificar(pcedula, pnombre, papellido1, papellido2, pcorreo, prol, pdepartamento) 'Llama al sub de modificar usuario de la clase persistente
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente los datos de un usuario a eliminar
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <remarks></remarks>
    Public Sub eliminarUsuario(ByVal pidUsuario As String)
        Try
            _clsUsuarioPersist.eliminar(pidUsuario) 'Llama al sub de eliminar usuario de la clase persistente
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Función encargada de enviar al objeto persistente la nueva contraseña que se desea asignar a un usuario
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <remarks></remarks>
    Public Sub cambiarContrasenna(ByVal pcedula As String, ByVal pcontrasenna As String)
        Try
            _clsUsuarioPersist.cambiarContrasenna(pcedula, pcontrasenna) 'Llama al sub de cambiar contraseña de usuario de la clase persistente
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los vendedores 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarVendedores() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _usuarios = _clsUsuarioPersist.listarVendedores() 'llama el método listar de la clase cliente persistente.

        For Each _usuario As ClsUsuario In _usuarios

            Dim _datos As String() = {_usuario.cedula.ToString(), _usuario.nombre.ToString(), _usuario.apellido1.ToString(), _usuario.apellido2.ToString(), _usuario.correo.ToString(), _usuario.departamento.ToString(), _usuario.rol.ToString()} 'declarar e instanciar cada usuario existente en la colección...

            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

#End Region

#Region "Permiso"

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermiso() As List(Of Array)

        Dim _permisos As New List(Of ClsPermiso) 'declarar una variable tipo lista genérica de la clase ClsPermisos
        Dim _arreglo As New List(Of Array)

        _permisos = _clsPermisoPersist.listar() 'llama el método listar de la clase permiso persistente.

        For Each _permiso As ClsPermiso In _permisos

            'declarar e instanciar cada servicio existente en la colección...
            Dim _datos As String() = {_permiso.cod.ToString(), _permiso.nombre.ToString(), _permiso.descripcion.ToString()}

            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

#End Region

#Region "Servicio"

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un servicio.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    ''' 
    Public Sub registrarservicio(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal)

        Dim _proc = My.Resources.procInsertServicio.ToString()

        Try
            _clsServicioPersist.registrar(pcod, pnombre, pdescripcion, ppreciocolones, ppreciodolares, pporcentcomisionjuniorcolones, _
                                          pporcentcomisionjuniordolares, pporcentcomisionseniorcolones, pporcentcomisionseniordolares, pporcentcomisionmastercolones, _
                                          pporcentcomisionmasterdolares, _proc) 'llama el método registrar de la clase servicio persistente pasandole los datos del servicio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un servicio 
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarServicioCodReturnString(ByVal pcod As String) As String()
        Dim _servicio As ClsServicio 'declarar una variable de tipo de la clase ClsServicio
        Dim _datos(10) As String

        _servicio = _clsServicioPersist.buscarPorCod(pcod) 'llama el método buscar por cod de la clase servicio persistente pasandole el dato del servicio.

        If Not _servicio Is Nothing Then

            _datos(0) = _servicio.cod.ToString()
            _datos(1) = _servicio.nombre.ToString()
            _datos(2) = _servicio.descripcion.ToString()
            _datos(3) = _servicio.precioColones.ToString()
            _datos(4) = _servicio.precioDolares.ToString()
            _datos(5) = _servicio.porcentComisionJuniorColones.ToString()
            _datos(6) = _servicio.porcentComisionJuniorDolares()
            _datos(7) = _servicio.porcentComisionSeniorColones.ToString()
            _datos(8) = _servicio.porcentComisionSeniorDolares.ToString()
            _datos(9) = _servicio.porcentComisionMasterColones.ToString()
            _datos(10) = _servicio.porcentComisionMasterDolares.ToString()

        End If

        Return _datos

    End Function

    Public Function buscarServicioCod(ByVal pcod As String) As List(Of Array)
        Dim _proc = My.Resources.procSelectServicioCod.ToString()

        _arreglo.Clear()

        _servicios = _clsServicioPersist.buscarPorCod(pcod, _proc) 'llama el método listar de la clase servicio persistente.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los servicios 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarServicios() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _servicios = _clsServicioPersist.listar() 'llama el método listar de la clase servicio persistente.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de un servicio.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    Public Sub modificarservicio(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal)

        Dim _proc = My.Resources.procUpdateServicio.ToString()

        Try
            _clsServicioPersist.modificar(pcod, pnombre, pdescripcion, ppreciocolones, ppreciodolares, pporcentcomisionjuniorcolones, _
                                          pporcentcomisionjuniordolares, pporcentcomisionseniorcolones, pporcentcomisionseniordolares, pporcentcomisionmastercolones, _
                                          pporcentcomisionmasterdolares, _proc) 'llama el método modificar de la clase servicio persistente pasandole los datos del servicio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un servicio.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarServicio(ByVal pcod As String)
        Dim _proc = My.Resources.procDeleteServicio.ToString()
        Try
            _clsServicioPersist.eliminar(pcod, _proc) 'llama el método eliminar de la clase servicio persistente pasandole los datos del servicio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un servicio 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Function buscarservicioPorNombre(ByVal pnombre As String) As List(Of Array)
        Dim _proc = My.Resources.procSelectServicioNombre.ToString()

        Dim _arreglo As New List(Of Array)()

        _servicios = _clsServicioPersist.buscarPorNombre(pnombre, _proc) 'llama el método buscar por nombre de la clase servicio persistente pasandole el dato del servicio.

        For Each _servicio As ClsServicio In _servicios
            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los servicios 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarServicio() As List(Of Array)
        Dim _proc = My.Resources.procListarServicios.ToString()

        _arreglo.Clear()

        _servicios = _clsServicioPersist.listar(_proc) 'llama el método listar de la clase servicio persistente.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function
#End Region

#Region "Cliente"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un cliente.
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreoCliente"></param>
    ''' <param name="pcontacto"></param>
    ''' <param name="pdireccion"></param>
    ''' <remarks></remarks>
    Public Sub registrarCliente(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, _
                                ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)
        Try
            _clsClientePersist.registrar(pidCliente, pnombre, ptelefono, pcorreoCliente, pcontacto, pdireccion) 'llama el método registrar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un cliente 
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <remarks></remarks>
    Public Function buscarClienteId(ByVal pidCliente As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)
        Dim _cliente As ClsCliente 'declarar una variable de tipo de la clase ClsCliente

        _cliente = _clsClientePersist.buscarPorId(pidCliente) 'llama el método buscar por id de la clase cliente persistente pasandole el dato del cliente.
        If Not _cliente Is Nothing Then
            Dim _datos As String() = {_cliente.idCliente.ToString(), _cliente.nombre.ToString(), _cliente.telefono.ToString(), _cliente.correoCliente.ToString(), _cliente.contacto.ToString(), _cliente.direccion.ToString()} 'declarar e instanciar el cliente existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        End If
        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un cliente 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Function buscarClientePorNombre(ByVal pnombre As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _clientes = _clsClientePersist.buscarPorNombre(pnombre) 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _cliente As ClsCliente In _clientes
            Dim _datos As String() = {_cliente.idCliente.ToString(), _cliente.nombre.ToString(), _cliente.telefono.ToString(), _cliente.correoCliente.ToString(), _cliente.contacto.ToString(), _cliente.direccion.ToString()} 'declarar e instanciar cada cliente existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarClientes() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _clientes = _clsClientePersist.listar() 'llama el método listar de la clase cliente persistente.

        For Each _cliente As ClsCliente In _clientes

            Dim _datos As String() = {_cliente.idCliente.ToString(), _cliente.nombre.ToString(), _cliente.telefono.ToString(), _cliente.correoCliente.ToString(), _cliente.contacto.ToString(), _cliente.direccion.ToString()} 'declarar e instanciar cada cliente existente en la colección...

            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de un cliente.
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreoCliente"></param>
    ''' <param name="pcontacto"></param>
    ''' <param name="pdireccion"></param>
    ''' <remarks></remarks>
    Public Sub modificarCliente(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)

        Try
            _clsClientePersist.modificar(pidCliente, pnombre, ptelefono, pcorreoCliente, pcontacto, pdireccion) 'llama el método modificar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un cliente.
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <remarks></remarks>
    Public Sub eliminarCliente(ByVal pidCliente As String)
        Try
            _clsClientePersist.eliminar(pidCliente) 'llama el método eliminar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "Comision"

    ''' <summary>
    ''' Se encarga de calcular las comisiones por ventas realizadas
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub calcularComisionVentasRealizadas()
        Dim objComisionPersist = New clsComisionPersist() 'Se crea una instancia del objeto persistente de comision

        Try
            'Invocar y ejecutar
            objComisionPersist.cCVentasRealizadas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo encargado de conectar con el objeto persistente de Comision para cancelar comisiones
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cancelarComision()
        Dim objComisionPersist = New clsComisionPersist() 'Se crea una instancia del objeto persistente de comision

        Try
            'Invocar y ejecutar
            objComisionPersist.cancelar()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Se encarga de extraer los datos de las comisiones recien calculadas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function extraerComisionesVentasRealizadas() As List(Of Array)
        Dim listaComisiones As New List(Of ClsComisionVentasRealizadas) 'Declara una variable tipo lista genérica de la clase ClsComisionVentasRealizadas
        Dim arreglo As New List(Of Array)()

        listaComisiones = New ClsComisionVentasRealizadasPersist().listar


        For Each objComision As ClsComisionVentasRealizadas In listaComisiones 'Declara e instancia cada comision existente en la colección...
            Dim datos As String() = {objComision.nombre.ToString, objComision.apellido1.ToString, objComision.apellido2.ToString, objComision.correo.ToString, objComision.porcentaje.ToString, objComision.montoapagar.ToString}
            arreglo.Add(datos) 'Agrega cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function


    Public Function calcularComisionPorProductoVendido() As List(Of Array)
        Dim _proc = My.Resources.procCalculoComisionPorProductoVendido.ToString()

        _arreglo.Clear()

        _calculos = _clsComisioPorProductoPersist.calcularComisionPorProductoVendido(_proc) 'llama el método listar de la clase permiso persistente.

        For Each _calculo As ClsComisionPorProducto In _calculos

            Dim _datos As String() = {_calculo.nombreServicio.ToString(), _calculo.rol.ToString(), _calculo.comisionColones.ToString(), _calculo.comisionDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de las facturas 
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <remarks></remarks>
    Public Function listarComisionPorVendedor(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of Array)

        Dim listaComisiones As New List(Of ClsComision) 'Declara una variable tipo lista genérica de la clase ClsFactura
        Dim _arreglo As New List(Of Array)()

        listaComisiones = _clsComisionPersist.listarComisionPorVendedor(pidUsuario, pfechaInicio, pfechaFin)

        For Each objComision As ClsComision In listaComisiones 'Declara e instancia cada comision existente en la colección
            Dim datos As String() = {objComision.codigo.ToString(), objComision.tipoComision.ToString(), objComision.fechaEmision.ToString(), _
                                     objComision.fechaInicial.ToString(), objComision.fechaFinal.ToString(), objComision.fechaCancelacion.ToString(), _
                                     objComision.porcentajeComision.ToString(), objComision.montoMeta.ToString(), objComision.montoAlcanzado.ToString(), _
                                     objComision.cantidadMeta.ToString(), objComision.cantidadAlcanzada.ToString(), objComision.montoPagado.ToString(), _
                                     objComision.estado.ToString(), objComision.idUsuario.ToString(), objComision.codGrupo.ToString(), objComision.periodoCancelacion.ToString()}
            _arreglo.Add(datos) 'Agrega cada comision de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function
#End Region

#Region "Plan de Ventas"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un plan de ventas.
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <param name="pplanServicios"></param>
    ''' <remarks></remarks>
    Public Sub registrarPlanVentas(ByVal pidPlanVenta As String, ByVal pdescripcion As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date, ByVal pplanServicios As List(Of ArrayList))

        Try
            _clsPlanVentaPersist.registrar(pidPlanVenta, pdescripcion, pfechaInicio, pfechaFin, pplanServicios) 'llama el método registrar de la clase plan venta persistente pasandole los datos del plan de ventas.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de plan de ventas 
    ''' </summary>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <remarks></remarks>
    Public Function buscarPlanVentaPorFecha(ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _planesventas = _clsPlanVentaPersist.buscarPorFecha(pfechaInicio, pfechaFin) 'llama el método buscar por nombre de la clase plan de venta persistente pasandole el dato del plan de ventas.

        For Each _planVenta As ClsPlanVenta In _planesventas
            Dim _datos As String() = {_planVenta.idPlanVenta.ToString(), _planVenta.descripcion.ToString(), _planVenta.fechaInicio.ToString(), _planVenta.fechaFin.ToString()} 'declarar e instanciar cada plan de ventas existente en la colección...
            _arreglo.Add(_datos) 'agregar cada plan de ventas de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los servicios de plan de ventas 
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <remarks></remarks>
    Public Function buscarPlanVentaServicio(ByVal pidPlanVenta As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _servicios = _clsServicioPersist.buscarServiciosPorPlanVentas(pidPlanVenta) 'llama el método buscar por nombre de la clase servicio persistente pasandole el dato del plan de ventas.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.precioColones.ToString(), _servicio.porcentComisionMasterDolares.ToString(), _servicio.ventasPlaneadas()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function
    ''' <summary>
    ''' Método de la clase encargada de buscar los servicios que no estan en ese plan 
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <remarks></remarks>
    Public Function buscarServicioSinPlan(ByVal pidPlanVenta As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _servicios = _clsServicioPersist.buscarServiciosSinPlan(pidPlanVenta) 'llama el método buscar por nombre de la clase servicio persistente pasandole el dato del plan de ventas.

        For Each _servicio As ClsServicio In _servicios

            Dim _datos As String() = {_servicio.cod.ToString(), _servicio.nombre.ToString(), _servicio.descripcion.ToString(), _servicio.precioColones.ToString(), _servicio.precioDolares.ToString(), _servicio.porcentComisionJuniorColones.ToString(), _servicio.porcentComisionJuniorDolares.ToString(), _servicio.porcentComisionSeniorColones.ToString(), _servicio.porcentComisionSeniorDolares.ToString(), _servicio.porcentComisionMasterColones.ToString(), _servicio.precioColones.ToString(), _servicio.porcentComisionMasterDolares.ToString()} 'declarar e instanciar cada servicio existente en la colección...

            _arreglo.Add(_datos) 'agregar cada servicio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function
    ''' <summary>
    ''' Método de la clase encargada de buscar todos los planes 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPlanes() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _planesventas = _clsPlanVentaPersist.listar() 'llama el método listar de la clase plan de ventas persistente.

        For Each _planVenta As ClsPlanVenta In _planesventas
            Dim _datos As String() = {_planVenta.idPlanVenta.ToString(), _planVenta.descripcion.ToString(), _planVenta.fechaInicio.ToString(), _planVenta.fechaFin.ToString()} 'declarar e instanciar cada plan de ventas existente en la colección...
            _arreglo.Add(_datos) 'agregar cada plan de ventas de la colección al arreglo (una lista genérica de Array)
        Next
        Return _arreglo
    End Function
    ''' <summary>
    ''' Método de la clase, encargada de modificar un servicio de plan de ventas.
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pcodServicio"></param>
    ''' <param name="pcantPlaneada"></param>
    ''' <remarks></remarks>
    Public Sub modificarPlanVentaServicio(ByVal pidPlanVenta As String, ByVal pcodServicio As String, ByVal pcantPlaneada As Decimal)

        Try
            _clsPlanVentaPersist.modificarServicioPlan(pidPlanVenta, pcodServicio, pcantPlaneada) 'llama el método modificar de la clase plan de venta persistente pasandole los datos del plan de venta servicio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un plan de ventas.
    ''' </summary>
    ''' <param name="pidPlan"></param>
    ''' <remarks></remarks>
    Public Sub eliminarPlanVenta(ByVal pidPlan As String)
        Try
            _clsPlanVentaPersist.eliminar(pidPlan) 'llama el método eliminar de la clase plan venta persistente pasandole los datos del plan de ventas.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar un servicio de un plan de ventas.
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pcodServicio"></param>
    ''' <remarks></remarks>
    Public Sub eliminarPlanVentaServicio(ByVal pidPlanVenta As String, ByVal pcodServicio As String)
        Try
            _clsPlanVentaPersist.eliminarPlanServicio(pidPlanVenta, pcodServicio) 'llama el método eliminar de la clase plan venta persistente pasandole los datos del plan de ventas.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "Rol"
    ''' <summary>
    ''' Función encargada de listar los usuarios registrados en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarRol() As List(Of Array)
        Dim ClsRolPersist As New ClsRolPersist()
        Dim listaUsuarios As New List(Of ClsRol) 'Declara una variable tipo lista genérica de la clase ClsUsuario
        Dim arreglo As New List(Of Array)()

        listaUsuarios = ClsRolPersist.listar()

        For Each rol As ClsRol In listaUsuarios 'Declara e instancia cada usuario existente en la colección...
            Dim datos As String() = {rol.nombre.ToString(), rol.descripcion.ToString}
            arreglo.Add(datos) 'Agrega cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return arreglo
    End Function
#End Region

#Region "Departamento"
    Public Function listarDepartamento() As List(Of Array)
        'declarar una variable tipo lista genérica de la clase ClsRol
        Dim _departamentos As New List(Of ClsDepartamento)
        Dim _clsDepartamentoPersist = New ClsDepartamentoPersist()
        Dim _arreglo As New List(Of Array)()

        _departamentos = _clsDepartamentoPersist.listar()

        For Each _departamento As ClsDepartamento In _departamentos
            'declarar e instanciar cada cliente existente en la colección...
            Dim _datos As String() = {_departamento.codigo.ToString(), _departamento.nombre.ToString()}
            'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
            _arreglo.Add(_datos)
        Next

        Return _arreglo

    End Function
#End Region



End Class

