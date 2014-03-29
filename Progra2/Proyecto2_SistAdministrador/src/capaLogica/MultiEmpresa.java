package capaLogica;

import java.sql.*;
import java.io.*;
import java.util.*;
import java.sql.SQLException;
import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;
public class MultiEmpresa {
	
	public Empresa crearEmpresa(String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa)throws Exception{
		Empresa empresa=null;
		String sql;
		sql="INSERT INTO TEmpresa "+
		"VALUES ('"+pnumEmpresa+"','"+pnomEmpresa+"','"+pdirecEmpresa+"','"+ptelEmpresa+"','"+pcontactoEmpresa+"');";
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			empresa=new Empresa( pnumEmpresa, pnomEmpresa, pdirecEmpresa, ptelEmpresa, pcontactoEmpresa);
		}catch(Exception e){
			throw new Exception ("La Empresa ya esta registrado");
		}		
		return empresa;
	}
	
	public Empresa buscarEmpresa(String pnumEmpresa) throws java.sql.SQLException,Exception{
		Empresa empresa=null;
		java.sql.ResultSet rs;
		String sql;
		sql="SELECT numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa "+
		"FROM TEmpresa "+
		"WHERE numEmpresa='"+ pnumEmpresa +"';";
		//System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			empresa = new Empresa (rs.getString("numEmpresa"), rs.getString("nomEmpresa"),rs.getString("direcEmpresa"), rs.getString("telEmpresa"),rs.getString("contactoEmpresa"));
		} else {
			throw new Exception ("La Empresa no está registrado.");
		}
		rs.close();
		return empresa;
	}
	public Empresa buscarEmpresaPorNombre(String pnomEmpresa) throws java.sql.SQLException,Exception{
		Empresa empresa=null;
		java.sql.ResultSet rs;
		String sql;
		sql="SELECT numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa "+
		"FROM TEmpresa "+
		"WHERE nomEmpresa='"+ pnomEmpresa +"';";
		System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			empresa = new Empresa (rs.getString("numEmpresa"), rs.getString("nomEmpresa"),rs.getString("direcEmpresa"), rs.getString("telEmpresa"),rs.getString("contactoEmpresa"));
		} else {
			throw new Exception ("La Empresa no está registrada.");
		}
		rs.close();
		return empresa;
	}
	
	public void modificarEmpresa(Empresa pempresa) throws java.sql.SQLException,Exception{	
		String sql;
		//numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa
		sql = "UPDATE TEmpresa "+
		"SET numEmpresa='"+pempresa.getNumEmpresa()+"', nomEmpresa='"+pempresa.getNomEmpresa()+"',direcEmpresa='"+pempresa.getDirecEmpresa()+"',telEmpresa='"+pempresa.getTelEmpresa()+"',contactoEmpresa='"+pempresa.getContactoEmpresa()+"' "+
		"WHERE numEmpresa='"+pempresa.getNumEmpresa()+"';";
		//System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La Empresa no está registrado.");
		}		
	}
	
	public Vector<Empresa> obtenerTodosLasEmpresas(){
		Vector<Empresa> empresas = new Vector<Empresa>();
		
		Empresa empresa = null;
		ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa " +
			"FROM TEmpresa";	
		//System.out.println(sql);
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				empresa = new Empresa (rs.getString("numEmpresa"), rs.getString("nomEmpresa"),rs.getString("direcEmpresa"), rs.getString("telEmpresa"),rs.getString("contactoEmpresa"));
				empresas.add(empresa);
			}
			rs.close();	
		} catch (Exception e) {}
		return empresas;
	}
	
	

}
