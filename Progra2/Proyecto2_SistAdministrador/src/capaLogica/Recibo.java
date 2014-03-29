package capaLogica;

/**
 * @(#)Recibo.java
 *
 *
 * @author 
 * @version 1.00 2011/4/8
 */


public class Recibo {
	private String numRecibo;
	private String fecha;
	private int importe;
	private String estado;
	private String idAdministrador;
	private String numEmpresa;
	
    public Recibo(String pnumRecibo,String pfecha,int pimporte,String pestado,String pidAdministrador,String pnumEmpresa) {
    	setNumRecibo(pnumRecibo);
    	setFecha(pfecha);
    	setImporte(pimporte);
    	setEstado(pestado);
    	setIdAdministrador(pidAdministrador);
    	setNumEmpresa(pnumEmpresa);
    }
    
    public String getNumEmpresa() {
		return numEmpresa;
	}

	public void setNumEmpresa(String pnumEmpresa) {
		this.numEmpresa = pnumEmpresa;
	}

	public void setNumRecibo(String pnumRecibo){
    	this.numRecibo=pnumRecibo;
    }
    
    public String getNumRecibo(){
    	return numRecibo;
    }
    
    public void setFecha(String pfecha){
    	this.fecha=pfecha;
    }
    
    public String getFecha(){
    	return fecha;
    }
    
    public void setImporte(int pimporte){
    	this.importe=pimporte;
    }
    
    public double getImporte(){
    	return importe;
    }
    
    public void setEstado(String pestado){
    	this.estado=pestado;
    }
    
    public String getEstado(){
    	return estado;
    }
    
    public void setIdAdministrador(String pidAdministrador){
		idAdministrador=pidAdministrador;
	}
	
	public String getIdAdministrador(){
		return idAdministrador;
	}
    
}