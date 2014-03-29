package capaLogica;

public class Comunidad {
	private String numComunidad;
	private String nomComunidad;
	private String codPostalComunidad;
	private String nomAbogado;
	private int cantPoblacion;
	

	public Comunidad(String pnumComunidad,String pnomComunidad,String pcodPostalComunidad,String pnomAbogado,int pcantPoblacion) {
		setNumComunidad(pnumComunidad);
		setNomComunidad(pnomComunidad);
		setCodPostalComunidad(pcodPostalComunidad);
		setNomAbogado(pnomAbogado);
		setCantPoblacion(pcantPoblacion);
    }

	public String getNumComunidad() {
		return numComunidad;
	}

	public void setNumComunidad(String pnumComunidad) {
		numComunidad = pnumComunidad;
	}

	public String getNomComunidad() {
		return nomComunidad;
	}

	public void setNomComunidad(String pnomComunidad) {
		nomComunidad = pnomComunidad;
	}

	public String getCodPostalComunidad() {
		return codPostalComunidad;
	}

	public void setCodPostalComunidad(String pcodPostalComunidad) {
		codPostalComunidad = pcodPostalComunidad;
	}

	public String getNomAbogado() {
		return nomAbogado;
	}

	public void setNomAbogado(String pnomAbogado) {
		nomAbogado = pnomAbogado;
	}
	
	public int getCantPoblacion() {
		return cantPoblacion;
	}

	public void setCantPoblacion(int pcantPoblacion) {
		cantPoblacion = pcantPoblacion;
	}


   
    
    
}