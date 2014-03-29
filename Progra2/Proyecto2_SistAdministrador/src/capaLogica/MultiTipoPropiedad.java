package capaLogica;

import java.sql.ResultSet;
import java.util.Vector;

import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiTipoPropiedad {
	
	public TipoPropiedad crearTipoPropiedad(String pidTipoPropiedad,String ptipo)throws Exception{
		TipoPropiedad tipoPropiedad=null;
		String sql;
		
		sql="INSERT INTO TipoPropiedad "+
		"VALUES ('"+pidTipoPropiedad+"','"+ptipo+"');";
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			tipoPropiedad=new TipoPropiedad(pidTipoPropiedad,ptipo);
		}catch(Exception e){
			throw new Exception ("Tipo de Propiedad ya esta registrada");
		}		
		return tipoPropiedad;
	} 
	
	public Vector<TipoPropiedad> obtenerTodosLosTiposPropiedades(){
		Vector<TipoPropiedad> tipoPropiedades = new Vector<TipoPropiedad>();
		
		TipoPropiedad tipoPropiedad = null;
		ResultSet rs;
		String sql;
		sql="SELECT idTipoPropiedad, tipo "+
			"FROM TTipoPropiedad";	
		//System.out.println(sql);
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				tipoPropiedad = new TipoPropiedad(rs.getString("idTipoPropiedad"),rs.getString("tipo"));
				tipoPropiedades.add(tipoPropiedad);
			}
			rs.close();	
		} catch (Exception e) {}
		return tipoPropiedades;
	}
	
	public TipoPropiedad buscarTipoPropiedad(String pnomPropiedad) throws java.sql.SQLException,Exception{
		TipoPropiedad tipoPropiedad=null;
		java.sql.ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT idTipoPropiedad, tipo "+
		"FROM TTipoPropiedad "+
		"WHERE tipo='"+pnomPropiedad+"'";
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			tipoPropiedad = new TipoPropiedad(rs.getString("idTipoPropiedad"),rs.getString("tipo"));
		} else {
			throw new Exception ("El tipo de propiedad");
		}
		rs.close();
		return tipoPropiedad;
	}
	
	
	
	

}
