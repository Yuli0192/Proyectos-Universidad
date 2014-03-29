package capaLogica;

import java.sql.ResultSet;
import java.util.Vector;

import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiPropiedad {

	public Propiedad crearPropiedad(String pnumPropiedad, String pareaPropiedad, String pubicaPropiedad, String pnumComunidad, String pnomPropietario,String pdireccionPropietario, String ptelefonoPropietario, String pestadoPropiedad,String pidTipoPropiedad)throws Exception{
		Propiedad propiedad=null;
		String sql;
		
		sql="INSERT INTO TPropiedad "+
		"VALUES ('"+pnumPropiedad+"','"+pareaPropiedad+"','"+pubicaPropiedad+"','"+pnumComunidad+"','"+pnomPropietario+"','"+pdireccionPropietario+"','"+ptelefonoPropietario+"','"+pestadoPropiedad+"','"+pidTipoPropiedad+"');";
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			propiedad=new Propiedad(pnumPropiedad, pareaPropiedad, pubicaPropiedad, pnumComunidad, pnomPropietario,pdireccionPropietario, ptelefonoPropietario, pestadoPropiedad,pidTipoPropiedad);
		}catch(Exception e){
			throw new Exception ("El numero de la propiedad ya esta registrada");
		}		
		return propiedad;
	} 
	
	public Propiedad buscarPropiedad(String pnumPropiedad) throws java.sql.SQLException,Exception{
		Propiedad propiedad=null;
		java.sql.ResultSet rs;
		String sql;
		//String pnumPropiedad, String pareaPropiedad, String pubicaPropiedad, String pnumComunidad, String pnomPropietario,String pdireccionPropietario, String ptelefonoPropietario, String pestadoPropiedad,String pidTipoPropiedad
		sql="SELECT numPropiedad, areaPropiedad, ubicaPropiedad, numComunidad, nomPropietario, direccionPropietario, telefonoPropietario, estadoPropiedad,idTipoPropiedad "+
		"FROM TPropiedad "+
		"WHERE numPropiedad='"+ pnumPropiedad +"';";
		System.out.println(sql +"buscar propiedad");
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			propiedad = new Propiedad (rs.getString("numPropiedad"),rs.getString("areaPropiedad"),rs.getString("ubicaPropiedad"),rs.getString("numComunidad"),rs.getString("nomPropietario"),rs.getString("direccionPropietario"),rs.getString("telefonoPropietario"),rs.getString("estadoPropiedad"),rs.getString("idTipoPropiedad"));
			//System.out.println(propiedad.getNomPropietario()+"");
		} else {
			throw new Exception ("La Propiedad no esta registrada.");
		}
		rs.close();
		return propiedad;
	}
	
	public Vector<Propiedad> obtenerTodosLasPropiedades(){
		Vector<Propiedad> propiedades = new Vector<Propiedad>();	
		Propiedad propiedad = null;
		ResultSet rs;
		String sql;
		//System.out.println("hola 1");
		sql="SELECT numPropiedad,areaPropiedad,ubicaPropiedad,numComunidad,nomPropietario,direccionPropietario,telefonoPropietario,estadoPropiedad,idTipoPropiedad "+
			"FROM TPropiedad";	
		//System.out.println(sql);
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				propiedad = new Propiedad(rs.getString("numPropiedad"),rs.getString("areaPropiedad"),rs.getString("ubicaPropiedad"),rs.getString("numComunidad"),rs.getString("nomPropietario"),rs.getString("direccionPropietario"),rs.getString("telefonoPropietario"),rs.getString("estadoPropiedad"),rs.getString("idTipoPropiedad"));
			//	propiedades.add(propiedad);
			}
			rs.close();	
		} catch (Exception e) {}
		return propiedades;
	}
	
	public void modificarPropiedad(Propiedad ppropiedad) throws java.sql.SQLException,Exception{	
		String sql;
		
		sql ="UPDATE TPropiedad "+
		"SET numPropiedad='"+ppropiedad.getNumPropiedad()+"',areaPropiedad='"+ppropiedad.getAreaPropiedad()+"',ubicaPropiedad='"+ppropiedad.getUbicaPropiedad()+"',numComunidad='"+ppropiedad.getNumComunidad()+"',nomPropietario='"+ppropiedad.getNomPropietario()+"',direccionPropietario='"+ppropiedad.getDireccionPropietario()+"',telefonoPropietario='"+ppropiedad.getTelefonoPropietario()+"',estadoPropiedad='"+ppropiedad.getEstadoPropiedad()+"',idTipoPropiedad='"+ppropiedad.getIdTipoPropiedad()+"' "+
		"WHERE numPropiedad='"+ppropiedad.getNumPropiedad()+"';";
		//System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La Propiedad no está registrado.");
		}
		
	}
	
	
}
