package capaLogica;

import java.sql.*;
import java.io.*;
import java.util.*;
import java.sql.SQLException;
import java.util.ArrayList;
import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiAdministrador {


	public Administrador crearAdministrador(String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado)throws Exception{
		Administrador administrador=null;
		String sql;
		//String pnomAdministrador,String pnumIdentAdministrador, String pnumColegiado
		sql="INSERT INTO TAbogado "+
		"VALUES ('"+pnumIdentAdministrador+"','"+pnomAdministrador+"','"+pnumColegiado+"');";
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			administrador=new Administrador(pnumIdentAdministrador,pnomAdministrador, pnumColegiado);
		}catch(Exception e){
			throw new Exception ("El numero del Administrador ya esta registrado");
		}		
		return administrador;
	} 
	
	public Administrador buscarAdministrador(String pidentificacion) throws java.sql.SQLException,Exception{
		Administrador administrador=null;
		java.sql.ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT numIdentificacion, nomAbogado, numColegiado "+
		"FROM TAbogado "+
		"where numIdentificacion='"+ pidentificacion +"';";
		System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			administrador = new Administrador (rs.getString("numIdentificacion"),rs.getString("nomAbogado"),rs.getString("numColegiado"));
		} else {
			throw new Exception ("El Abogado no está registrado.");
		}
		rs.close();
		return administrador;
	}
	
	public Administrador buscarAdministradorPorNombre(String pnomAbogado) throws java.sql.SQLException,Exception{
		Administrador administrador=null;
		java.sql.ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT numIdentificacion, nomAbogado, numColegiado "+
		"FROM TAbogado "+
		"where nomAbogado='"+ pnomAbogado +"';";
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			administrador = new Administrador (rs.getString("numIdentificacion"), rs.getString("nomAbogado"),rs.getString("numColegiado"));
		} else {
			throw new Exception ("El Abogado no está registrado.");
		}
		rs.close();
		return administrador;
	}
	
	public void modificarAdministrador(Administrador padministrador) throws java.sql.SQLException,Exception{	
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql = "UPDATE TAbogado "+
		"SET  numIdentificacion='"+padministrador.getNumIdentAdministrador()+"', nomAbogado='"+padministrador.getNomAdministrador()+"',numColegiado='"+padministrador.getNumColegiado()+"' "+
		"WHERE numIdentificacion='"+padministrador.getNumIdentAdministrador()+"';";
		//System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("El Administrador no está registrado.");
		}
		
	}

	
	
	public Vector<Administrador> obtenerTodosLosAdministrador(){
		Vector<Administrador> administradores = new Vector<Administrador>();
		
		Administrador administrador = null;
		ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT numIdentificacion, nomAbogado, numColegiado " +
			"FROM TAbogado";	
		//System.out.println(sql);
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				administrador = new Administrador(rs.getString("numIdentificacion"), rs.getString("nomAbogado"),rs.getString("numColegiado"));
				administradores.add(administrador);
			}
			rs.close();	
		} catch (Exception e) {}
		return administradores;
	}
	
	public  void borrar(Administrador padministrador) throws java.sql.SQLException,Exception{
		String sql;
		sql = "DELETE FROM TAbogado "+
		"WHERE numIdentificacion='"+padministrador.getNumIdentAdministrador()+"';";
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("El Administrador no existe.");
		}
	}
}