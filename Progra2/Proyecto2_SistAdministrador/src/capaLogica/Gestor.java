package capaLogica;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.TreeMap;
import java.util.Vector;

import java.io.*;		//Importamos bibliotecas externas
import java.util.*;
import java.text.*;

public class Gestor {
	
	public String AgregarAdministrador(String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado) throws Exception {	
		Administrador administrador;
		String msj="El Administrador se agrego con exito";	
		try{		
			administrador = (new MultiAdministrador()).crearAdministrador(pnumIdentAdministrador,pnomAdministrador,pnumColegiado);
		}
		catch (Exception ex) {		
			msj= "El numero del Administrador ya existe";					
		}
		return msj;
	}
	
	public String AgregarCuenta(String pnumCuenta,String pnumComunidad,String pfecha,int pmonto) throws Exception {	
		Cuenta cuenta;
		String msj="La Cuenta se Registro con exito";	
		try{		
			cuenta = (new MultiCuenta()).crearCuenta(pnumCuenta,pnumComunidad,pfecha,pmonto);
		}
		catch (Exception ex) {		
			msj= "El numero de Cuenta ya existe";					
		}
		return msj;
	}
	
	public String AgregarPropiedad(String pnumPropiedad, String pareaPropiedad, String pubicaPropiedad, String pnumComunidad, String pnomPropietario,String pdireccionPropietario, String ptelefonoPropietario, String pestadoPropiedad,String pidTipoPropiedad) throws Exception {	
		Propiedad propiedad;
		String msj="La propiedad agrego con exito";	
		try{		
			propiedad = (new MultiPropiedad()).crearPropiedad(pnumPropiedad, pareaPropiedad, pubicaPropiedad, pnumComunidad, pnomPropietario,pdireccionPropietario, ptelefonoPropietario, pestadoPropiedad,pidTipoPropiedad);
		}
		catch (Exception ex) {		
			msj= "El numero de la propiedad ya existe";					
		}
		return msj;
	}
	public String AgregarComunidad(String pnumComunidad,String pnomComunidad,String pcodPostalComunidad,String pnomAbogado,int pcantPoblacion)throws Exception {	
		Comunidad comunidad;
		String msj="La comunidad se agrego con exito";	
		try{		
			comunidad = (new MultiComunidad()).crearComunidad(pnumComunidad,pnomComunidad,pcodPostalComunidad,pnomAbogado,pcantPoblacion);
		}
		catch (Exception ex) {		
			msj= "El numero de la comunidad ya existe";					
		}
		return msj;
	}
	
	public String AgregarEmpresa(String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa)throws Exception {	
		Empresa empresa;
		String msj="La empresa se agrego con exito";	
		try{		
			empresa = (new MultiEmpresa()).crearEmpresa(pnumEmpresa, pnomEmpresa, pdirecEmpresa, ptelEmpresa, pcontactoEmpresa);
		}
		catch (Exception ex) {		
			msj= "El numero de la empresa ya existe";					
		}
		return msj;
	}
	public String obtenerFechaHoy(){
		Calendar calendario;
		
		Date fecha;
		
		calendario = Calendar.getInstance();
    	fecha = calendario.getTime();
    	String fechaString =obtenerFechaEnString(fecha);
    	return fechaString;    	
	}
	public static String obtenerFechaEnString(Date pfecha){
		
		SimpleDateFormat mascara= new SimpleDateFormat("dd/MM/yy");
		return mascara.format(pfecha);
	}

	
	public Administrador buscarAdministrador(String pidentificacion) throws Exception {

		Administrador administrador=null;

		administrador = (new MultiAdministrador()).buscarAdministrador(pidentificacion);

		return administrador;
	}
	
	public Propiedad buscarPropiedad(String pnumPropiedad) throws Exception {

		Propiedad propiedad=null;

		propiedad = (new MultiPropiedad()).buscarPropiedad(pnumPropiedad);

		return propiedad;
	}
	
	public Administrador buscarAbogadoPorNombre(String pnomAbogado) throws Exception {

		Administrador administrador=null;

		administrador = (new MultiAdministrador()).buscarAdministradorPorNombre(pnomAbogado);

		return administrador;
	}
	public Comunidad buscarComunidad(String pnumComunidad) throws Exception {
		Comunidad comunidad=null;
		comunidad = (new MultiComunidad()).buscarComunidad(pnumComunidad);
		return comunidad;
	}
	public Empresa buscarEmpresa(String pnumEmpresa) throws Exception {
		Empresa empresa=null;
		empresa = (new MultiEmpresa()).buscarEmpresa(pnumEmpresa);
		return empresa;
	}
	public Empresa buscarEmpresaPorNombre(String pnomEmpresa) throws Exception {
		Empresa empresa=null;
		empresa = (new MultiEmpresa()).buscarEmpresaPorNombre(pnomEmpresa);
		return empresa;
	}
	

	
	public String modificarAdministrador(String pnumIdentificacion, String pnomAdministrador, String pnumColegiado){
		Administrador administrador;
		String msj="El abogado se Modifico con exito";
		MultiAdministrador multiAdministrador=new MultiAdministrador();
		try{
			//String mjs2;
			administrador = (new MultiAdministrador()).buscarAdministrador(pnumIdentificacion);
			administrador.setNumIdentAdministrador(pnumIdentificacion);
			administrador.setNomAdministrador(pnomAdministrador);
			administrador.setNumColegiado(pnumColegiado);
			//mjs2=""+administrador.getNumIdentAdministrador()+administrador.getNomAdministrador()+administrador.getNumColegiado();
			//System.out.println(mjs2);
			multiAdministrador.modificarAdministrador(administrador);
		}
		catch (Exception ex) {		
			msj= "No se Modifico el Abogado";					
		}

		return msj;
	}
    
	public String modificarCuidad(String pnumComunidad,String pnomComunidad,String pcodPostalComunidad,int pcantPoblacion, String pnomAbogado){
		Comunidad comunidad;
		String msj="La comunidad se Modifico con exito";
		MultiComunidad multiComunidad=new MultiComunidad();
		try{		
			comunidad = (new MultiComunidad()).buscarComunidad(pnumComunidad);
			comunidad.setNumComunidad(pnumComunidad);
			comunidad.setNomComunidad(pnomComunidad);
			comunidad.setCodPostalComunidad(pcodPostalComunidad);
			comunidad.setCantPoblacion(pcantPoblacion);
			comunidad.setNomAbogado(pnomAbogado);
			multiComunidad.modificarComunidad(comunidad);
			
		}
		catch (Exception ex) {		
			msj= "No se Modifico el Abogado";					
		}
		return msj;
	}
	
	public String modificarPropiedad(String pnumPropiedad, String pareaPropiedad, String pubicaPropiedad, String pnumComunidad, String pnomPropietario,String pdireccionPropietario, String ptelefonoPropietario, String pestadoPropiedad,String pidTipoPropiedad){
		Propiedad propiedad;
		String msj="La propiedad se Modifico con exito";
		MultiPropiedad multiPropiedad=new MultiPropiedad();
		try{
			System.out.println(pnumPropiedad+"");
			propiedad = (new MultiPropiedad()).buscarPropiedad(pnumPropiedad);
			propiedad.setNumComunidad(pnumComunidad);
			propiedad.setAreaPropiedad(pareaPropiedad);
			propiedad.setUbicaPropiedad(pubicaPropiedad);
			propiedad.setNumComunidad(pnumComunidad);
			propiedad.setNomPropietario(pnomPropietario);
			propiedad.setDireccionPropietario(pdireccionPropietario);
			propiedad.setTelefonoPropietario(ptelefonoPropietario);
			propiedad.setIdTipoPropiedad(pidTipoPropiedad);
			System.out.println("hola 2");
			multiPropiedad.modificarPropiedad(propiedad);
			
		}
		catch (Exception ex) {		
			msj= "No se Modifico la propiedad";					
		}
		return msj;
	}
	
	public String modificarEmpresa(String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa){
		Empresa empresa;
		String msj="La Empresa se Modifico con exito";
		MultiEmpresa multiEmpresa=new MultiEmpresa();
		try{		
			empresa = (new MultiEmpresa()).buscarEmpresa(pnumEmpresa);
			empresa.setNumEmpresa(pnumEmpresa);
			empresa.setNomEmpresa(pnomEmpresa);
			empresa.setDirecEmpresa(pdirecEmpresa);
			empresa.setTelEmpresa(ptelEmpresa);
			empresa.setContactoEmpresa(pcontactoEmpresa);
			//System.out.println("por");
			multiEmpresa.modificarEmpresa(empresa);
		}
		catch (Exception ex) {		
			msj= "No se Modifico la Empresa";					
		}

		return msj;
	}
	
	public String[] obtenerAdministrador() {
		Administrador administrador;
        Vector<Administrador> administradores = null;
        
		try {
			administradores = (new MultiAdministrador()).obtenerTodosLosAdministrador();
		} catch (Exception e) { }
		
        String [] datosAdministradores = new String [administradores.size()];
        
        for(int i = 0; i < datosAdministradores.length; i++) {
        	administrador = administradores.get(i);
        	datosAdministradores[i] = administrador.getNomAdministrador();
        }
        return datosAdministradores;
	}

	public String[] obtenerTodasLasCuentas() {
		Cuenta cuenta;
        Vector<Cuenta> listaCuentas = null;
        
		try {
			listaCuentas = (new MultiCuenta()).obtenerTodasLasCuentas();
		} catch (Exception e) { }
		
        String [] listCuentas = new String [listaCuentas.size()];
        
        for(int i = 0; i < listCuentas.length; i++) {
        	cuenta = listaCuentas.get(i);
        	listCuentas[i] = cuenta.getNumCuenta();
        }
        return listCuentas;
	}
	
	public String[] obtenerTodasLasEmpresas() {
		Empresa empresa;
        Vector<Empresa> listaEmpresas = null;
        
		try {
			listaEmpresas = (new MultiEmpresa()).obtenerTodosLasEmpresas();
		} catch (Exception e) { }
		
        String [] listEmpresas = new String [listaEmpresas.size()];
        
        for(int i = 0; i < listEmpresas.length; i++) {
        	empresa = listaEmpresas.get(i);
        	listEmpresas[i] = empresa.getNomEmpresa();
        }
        return listEmpresas;
	}
	
	
	public String[] obtenerAdministradorIds() {
		Administrador administrador;
        Vector<Administrador> administradores = null;
        
		try {
			administradores = (new MultiAdministrador()).obtenerTodosLosAdministrador();
		} catch (Exception e) { }
		
        String [] datosAdministradores = new String [administradores.size()];
        
        for(int i = 0; i < datosAdministradores.length; i++) {
        	administrador = administradores.get(i);
        	datosAdministradores[i] = administrador.getNumIdentAdministrador();
        }
        return datosAdministradores;
	}
	
	public void borrarAdministrador(String pidentificacion) throws Exception {
		Administrador administrador;
		administrador = (new MultiAdministrador()).buscarAdministrador(pidentificacion);
		(new MultiAdministrador()).borrar(administrador);
	}
	public void borrarComunidad(String pnumComunidad) throws Exception {
		Comunidad comunidad;
		comunidad = (new MultiComunidad()).buscarComunidad(pnumComunidad);
		System.out.println(comunidad.getNumComunidad()+comunidad.getNomComunidad());
		(new MultiComunidad()).borrar(comunidad);
	}

	public String[] obtenerTodasLasPropiedades() {
		Propiedad propiedad;
        Vector<Propiedad> propiedades = null;
        
		try {
			propiedades = (new MultiPropiedad()).obtenerTodosLasPropiedades();
		} catch (Exception e) { }
		
        String [] datosPropiedades = new String [propiedades.size()];
        
        for(int i = 0; i < datosPropiedades.length; i++) {
        	propiedad = propiedades.get(i);
        	datosPropiedades[i] = propiedad.getNumPropiedad();
        }
        return datosPropiedades;
	}
	
	public String[] obtenerTodasLasComunidades() {
		Comunidad comunidad;
        Vector<Comunidad> comunidades = null;
        
		try {
			comunidades = (new MultiComunidad()).obtenerTodosLasComunidades();
		} catch (Exception e) { }
		
        String [] datosComunidades = new String [comunidades.size()];
        
        for(int i = 0; i < datosComunidades.length; i++) {
        	comunidad = comunidades.get(i);
        	datosComunidades[i] = comunidad.getNumComunidad();
        }
        return datosComunidades;
	}
	
	public String[] obtenerTodasLosTipos() {
		TipoPropiedad tipoPropiedad;
        Vector<TipoPropiedad> tipoPropiedades = null;
        
		try {
			tipoPropiedades = (new MultiTipoPropiedad()).obtenerTodosLosTiposPropiedades();
		} catch (Exception e) { }
		
        String [] datosTipoPropiedades = new String [tipoPropiedades.size()];
        
        for(int i = 0; i < datosTipoPropiedades.length; i++) {
        	tipoPropiedad = tipoPropiedades.get(i);
        	datosTipoPropiedades[i] = tipoPropiedad.getTipo();
        }
        return datosTipoPropiedades;
	}
	

	public TipoPropiedad buscarTipoPropiedad(String pnomPropiedad) throws Exception {

		TipoPropiedad tipoPropiedad=null;

		tipoPropiedad = (new MultiTipoPropiedad()).buscarTipoPropiedad(pnomPropiedad);

		return tipoPropiedad;
	}
	
	public String pagarRecibo(String pnumCuenta,int pmonto){
		Cuenta cuenta;
		int montoActual;
		int montoNuevo=0;
		String msj="Fue cancelado el Recibo con exicto";
		MultiCuenta multiCuenta=new MultiCuenta();
		try{
			cuenta = (new MultiCuenta()).buscarCuenta(pnumCuenta);
			montoActual=cuenta.getMonto();
			//System.out.println(montoActual);
			if(montoActual>=pmonto){
				montoNuevo=montoActual-pmonto;
				//System.out.println(montoNuevo+" monto nuevo cuenta");
				cuenta.setMonto(montoNuevo);
				multiCuenta.pagarRecibo(cuenta);		
			}
		
		}
		catch (Exception ex) {		
			msj= "El recibo no fue Cancelado";					
		}

		return msj;
	}
	
	public String aumentarMontoCuenta(String pnumCuenta,int pmonto){
		Cuenta cuenta;
		int montoActual;
		int montoNuevo=0;
		String msj="El monto fue Agregado";
		MultiCuenta multiCuenta=new MultiCuenta();
		try{
			cuenta = (new MultiCuenta()).buscarCuenta(pnumCuenta);
			montoActual=cuenta.getMonto();
			//System.out.println(montoActual);		
				montoNuevo=montoActual+pmonto;
				//System.out.println(montoNuevo+" monto nuevo cuenta");
				cuenta.setMonto(montoNuevo);
				multiCuenta.pagarRecibo(cuenta);				
		}
		catch (Exception ex) {		
			msj= "El monto no se Agrego";					
		}
		return msj;
	}
	
	public String AgregarRecibo(String pnumRecibo,String pfecha,int pimporte,String pestado,String pidAdministrador,String pnumCuenta, String pnumEmpresa) throws Exception {	
		Recibo recibo;
		String msj="El recibo se registro con exicto";
		try{		
			recibo = (new MultiRecibo()).crearRecibo(pnumRecibo, pfecha,pimporte,pestado, pidAdministrador, pnumEmpresa);
		}
		catch (Exception ex) {		
			msj= "El numero del recibo ya existe";					
		}
		return msj;
	}
	
	public boolean buscarRecibo(String pnumRecibo) throws Exception {	
		Recibo recibo;
		boolean resul=false;
		try{		
			recibo = (new MultiRecibo()).buscarRecibo(pnumRecibo);
			System.out.println(recibo.getNumRecibo()+"  "+pnumRecibo+"hola kjnn");
			///recibo.getNumRecibo();
			
			if(!recibo.getNumRecibo().equals(pnumRecibo)){
				resul=true;
				System.out.println(recibo.getNumRecibo()+"  "+pnumRecibo);
			}
		}
		catch (Exception ex) {		
						
		}
		return resul;
	}
}