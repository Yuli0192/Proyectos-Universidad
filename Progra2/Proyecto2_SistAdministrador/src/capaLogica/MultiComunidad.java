package capaLogica;

import java.sql.*;
import java.io.*;
import java.util.*;
import java.sql.SQLException;
import java.util.ArrayList;
import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiComunidad {
	
	public Comunidad crearComunidad(String pnumComunidad,String pnomComunidad,String pcodPostalComunidad,String pnomAbogado,int pcantPoblacion)throws Exception{
		Comunidad comunidad=null;
		String sql;
		sql="INSERT INTO TComunidad "+
		"VALUES ('"+pnumComunidad+"','"+pnomComunidad+"','"+pcodPostalComunidad+"','"+pnomAbogado+"',"+pcantPoblacion+");";
		System.out.println(sql);
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			comunidad=new Comunidad(pnumComunidad,pnomComunidad,pcodPostalComunidad,pnomAbogado,pcantPoblacion);
		}catch(Exception e){
			throw new Exception ("El numero de la comunidad ya esta registrado");
		}		
		return comunidad;
	} 
	
	public Comunidad buscarComunidad(String pnumComunidad) throws java.sql.SQLException,Exception{
		Comunidad comunidad=null;
		java.sql.ResultSet rs;
		String sql;  //pnumComunidad,pnomComunidad,pcodPostalComunidad,pcantPoblacion,pnomAbogado
		sql="select numComunidad, nomComunidad,codPostComunidad,cantPoblacion,nomAbogado "+
		"from TComunidad "+
		"where numComunidad='"+ pnumComunidad +"';";
		//System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			//String pnumComunidad,String pnomComunidad,String pcodPostalComunidad,int pcantPoblacion
			comunidad = new Comunidad (rs.getString("numComunidad"),rs.getString("nomComunidad"),rs.getString("codPostComunidad"),rs.getString("nomAbogado"),rs.getInt("cantPoblacion"));
		} else {
			throw new Exception ("La Comunidad no está registrado.");
		}
		rs.close();
		return comunidad;
	}

	
	public void modificarComunidad(Comunidad pcomunidad) throws java.sql.SQLException,Exception{	
		String sql;
		//numComunidad, nomComunidad,codPostComunidad,cantPoblacion
		sql ="UPDATE TComunidad "+
		"SET numComunidad='"+pcomunidad.getNumComunidad()+"', nomComunidad='"+pcomunidad.getNomComunidad()+"', codPostComunidad='"+pcomunidad.getCodPostalComunidad()+"', nomAbogado='"+pcomunidad.getNomAbogado()+"', cantPoblacion="+pcomunidad.getCantPoblacion()+" "+
		"WHERE numComunidad='"+pcomunidad.getNumComunidad()+"';";
		//System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La Comunidad no está registrado.");
		}
		
	}
	
	public Vector<Comunidad> obtenerTodosLasComunidades(){
		Vector<Comunidad> comunidades = new Vector<Comunidad>();
		
		Comunidad comunidad = null;
		ResultSet rs;
		String sql;
		sql="SELECT numComunidad, nomComunidad,codPostComunidad,cantPoblacion,nomAbogado "+
			"FROM TComunidad";	
		//System.out.println(sql);
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				comunidad = new Comunidad(rs.getString("numComunidad"),rs.getString("nomComunidad"),rs.getString("codPostComunidad"),rs.getString("nomAbogado"),rs.getInt("cantPoblacion"));
				comunidades.add(comunidad);
			}
			rs.close();	
		} catch (Exception e) {}
		return comunidades;
	}
	
	public  void borrar(Comunidad pcomunidad) throws java.sql.SQLException,Exception{
		String sql;
		///System.out.println(pcomunidad.getNumComunidad()+"");
		sql="DELETE FROM TComunidad "+
		"WHERE numComunidad='"+pcomunidad.getNumComunidad()+"';";
		System.out.println("hola");
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La comunidad no existe.");
		}
	}
	
}
