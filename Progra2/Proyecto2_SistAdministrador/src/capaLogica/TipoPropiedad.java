package capaLogica;

public class TipoPropiedad {
	
	private String IdTipoPropiedad;
	private String tipo;
	
	public TipoPropiedad(String pidTipoPropiedad,String ptipo){
		setIdTipoPropiedad(pidTipoPropiedad);
		setTipo(ptipo);
	}

	public String getIdTipoPropiedad() {
		return IdTipoPropiedad;
	}

	public void setIdTipoPropiedad(String pidTipoPropiedad) {
		IdTipoPropiedad = pidTipoPropiedad;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String ptipo) {
		this.tipo = ptipo;
	}
	

}
