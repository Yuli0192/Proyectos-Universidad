package capaLogica;

public class Administrador {
	private String nomAdministrador;
	private String numIdentAdministrador;
	private String numColegiado;
	public Administrador(String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado) {
    	setNomAdministrador(pnomAdministrador);
    	setNumIdentAdministrador(pnumIdentAdministrador);
    	setNumColegiado(pnumColegiado);  
    }

	public String getNomAdministrador() {
		return nomAdministrador;
	}
	public String getNumIdentAdministrador() {
		return numIdentAdministrador;
	}
	public String getNumColegiado() {
		return numColegiado;
	}
	public void setNomAdministrador(String pnomAdministrador){
    	nomAdministrador=pnomAdministrador;
    }
    public void  setNumIdentAdministrador(String pnumIdentAdministrador){
    	numIdentAdministrador=pnumIdentAdministrador;
    }
    public void setNumColegiado(String pnumColegiado){
    	numColegiado=pnumColegiado;
    }

}