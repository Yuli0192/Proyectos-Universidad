package capaLogica;

/**
 * @(#)Cuenta.java
 *
 *
 * @author 
 * @version 1.00 2011/4/8
 */


public class Cuenta {
	
	private String numCuenta;
	private String numComunidad;
	private String fecha;
	private int monto;
	
    public Cuenta(String pnumCuenta,String pnumComunidad,String pfecha,int pmonto) {
    	setNumCuenta(pnumCuenta);
    	setNumComunidad(pnumComunidad);
    	setFecha(pfecha);
    	setMonto(pmonto);
    }

	public String getNumCuenta() {
		return numCuenta;
	}

	public void setNumCuenta(String pnumCuenta) {
		numCuenta = pnumCuenta;
	}

	public String getNumComunidad() {
		return numComunidad;
	}

	public void setNumComunidad(String pnumComunidad) {
		numComunidad = pnumComunidad;
	}

	public String getFecha() {
		return fecha;
	}

	public void setFecha(String pfecha) {
		fecha = pfecha;
	}

	public int getMonto() {
		return monto;
	}

	public void setMonto(int pmonto) {
		monto = pmonto;
	}
    
    
}