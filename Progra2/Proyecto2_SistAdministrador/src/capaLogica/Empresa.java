package capaLogica;

/**
 * @(#)empresa.java
 *
 *
 * @author 
 * @version 1.00 2011/4/8
 */


public class Empresa {
    String  numEmpresa;
    String nomEmpresa;
    String direcEmpresa;
    String telEmpresa;
    String contactoEmpresa;
    public Empresa(String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa) {
    	setNumEmpresa(pnumEmpresa);
    	setNomEmpresa(pnomEmpresa);
    	setDirecEmpresa(pdirecEmpresa);
    	setTelEmpresa(ptelEmpresa);
    	setContactoEmpresa(pcontactoEmpresa);
    }
	public String getNumEmpresa() {
		return numEmpresa;
	}
	public void setNumEmpresa(String pnumEmpresa) {
		this.numEmpresa = pnumEmpresa;
	}
	public String getNomEmpresa() {
		return nomEmpresa;
	}
	public void setNomEmpresa(String pnomEmpresa) {
		this.nomEmpresa = pnomEmpresa;
	}
	public String getDirecEmpresa() {
		return direcEmpresa;
	}
	public void setDirecEmpresa(String pdirecEmpresa) {
		this.direcEmpresa = pdirecEmpresa;
	}
	public String getTelEmpresa() {
		return telEmpresa;
	}
	public void setTelEmpresa(String ptelEmpresa) {
		this.telEmpresa = ptelEmpresa;
	}
	public String getContactoEmpresa() {
		return contactoEmpresa;
	}
	public void setContactoEmpresa(String pcontactoEmpresa) {
		this.contactoEmpresa = pcontactoEmpresa;
	}
    
    
}