package capaLogica;

public class Propiedad {

	private String numPropiedad;
	private String areaPropiedad;
	private String ubicaPropiedad;
	private String numComunidad;
	private String nomPropietario;
	private String direccionPropietario;
	private String telefonoPropietario;
	private String estadoPropiedad;
	
	private String idTipoPropiedad;
	
	public Propiedad(String pnumPropiedad, String pareaPropiedad, String pubicaPropiedad, String pnumComunidad, String pnomPropietario,String pdireccionPropietario, String ptelefonoPropietario, String pestadoPropiedad,String pidTipoPropiedad){
		setNumPropiedad(pnumPropiedad);
		setAreaPropiedad(pareaPropiedad);
		setUbicaPropiedad(pubicaPropiedad);
		setNumComunidad(pnumComunidad);
		setNomPropietario(pnomPropietario);
		setDireccionPropietario(pdireccionPropietario);
		setTelefonoPropietario(ptelefonoPropietario) ;
		setEstadoPropiedad(pestadoPropiedad) ;
		setIdTipoPropiedad(pidTipoPropiedad);
	}

	public String getNumPropiedad() {
		return numPropiedad;
	}

	public void setNumPropiedad(String pnumPropiedad) {
		this.numPropiedad = pnumPropiedad;
	}

	public String getAreaPropiedad() {
		return areaPropiedad;
	}

	public void setAreaPropiedad(String pareaPropiedad) {
		this.areaPropiedad = pareaPropiedad;
	}

	public String getUbicaPropiedad() {
		return ubicaPropiedad;
	}

	public void setUbicaPropiedad(String pubicaPropiedad) {
		this.ubicaPropiedad = pubicaPropiedad;
	}

	public String getNumComunidad() {
		return numComunidad;
	}

	public void setNumComunidad(String pnumComunidad) {
		this.numComunidad = pnumComunidad;
	}

	public String getNomPropietario() {
		return nomPropietario;
	}

	public void setNomPropietario(String pnomPropietario) {
		this.nomPropietario = pnomPropietario;
	}

	public String getDireccionPropietario() {
		return direccionPropietario;
	}

	public void setDireccionPropietario(String pdireccionPropietario) {
		this.direccionPropietario = pdireccionPropietario;
	}

	public String getTelefonoPropietario() {
		return telefonoPropietario;
	}

	public void setTelefonoPropietario(String ptelefonoPropietario) {
		this.telefonoPropietario = ptelefonoPropietario;
	}

	public String getEstadoPropiedad() {
		return estadoPropiedad;
	}

	public void setEstadoPropiedad(String pestadoPropiedad) {
		this.estadoPropiedad = pestadoPropiedad;
	}


	public String getIdTipoPropiedad() {
		return idTipoPropiedad;
	}

	public void setIdTipoPropiedad(String pidTipoPropiedad) {
		this.idTipoPropiedad = pidTipoPropiedad;
	}




	
}
