package capaLogica;

import java.sql.*;
import java.io.*;
import java.util.*;
import java.sql.SQLException;
import java.util.ArrayList;
import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiCuenta {
	
	public Cuenta crearCuenta(String pnumCuenta,String pnumComunidad,String pfecha,int pmonto)throws Exception{
		Cuenta cuenta=null;
		String sql;
		//numCuenta,numComunidad='1',fecha='22',monto=1000
		//numCuenta,numComunidad,fecha,monto
		sql="INSERT INTO TCuenta "+
		"VALUES ('"+pnumCuenta+"','"+pnumComunidad+"','"+pfecha+"',"+pmonto+");";
		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			cuenta=new Cuenta(pnumCuenta,pnumComunidad,pfecha,pmonto);
		}catch(Exception e){
			throw new Exception ("El numero de Cuenta ya esta registrada");
		}		
		return cuenta;
	} 
	
	public Cuenta buscarCuenta(String pnumCuenta) throws java.sql.SQLException,Exception{
		Cuenta cuenta=null;
		java.sql.ResultSet rs;
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		sql="SELECT numCuenta,numComunidad,fecha,monto "+
		"FROM TCuenta "+
		"where numCuenta='"+ pnumCuenta +"';";
		//System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			cuenta = new Cuenta (rs.getString("numCuenta"),rs.getString("numComunidad"),rs.getString("fecha"),rs.getInt("monto"));
		} else {
			throw new Exception ("La cuenta no está registrada.");
		}
		rs.close();
		return cuenta;
	}

	public Vector<Cuenta> obtenerTodasLasCuentas(){
		Vector<Cuenta> listaCuentas = new Vector<Cuenta>();	
		Cuenta cuenta = null;
		ResultSet rs;
		String sql;		
		sql="SELECT * "+
			"FROM TCuenta";	
		//System.out.println(sql);
		//String numCuenta;
		try {
			rs = Conector.getConector().ejecutarSQL(sql, true);		
			while(rs.next()){
				//System.out.println(rs.getString("numCuenta")+" Aqui si sirve abajo no");
				//System.out.println(rs.getString("numCuenta")+"2");
				//numCuenta=rs.getString("numCuenta")+"";
				cuenta=new Cuenta(rs.getString("numCuenta"),rs.getString("numComunidad"),rs.getString("fecha"),rs.getInt("monto"));
				//System.out.println(cuenta.getNumCuenta()+"   "+cuenta.getNumComunidad()+"   "+cuenta.getFecha()+"   "+cuenta.getMonto());
				listaCuentas.add(cuenta);
			}
			rs.close();	
		} catch (Exception e) {}
		return listaCuentas;
	}
	
	
	public void pagarRecibo(Cuenta pcuenta) throws java.sql.SQLException,Exception{	
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		//System.out.println(pcuenta.getMonto()+" este es el monto nuevo de la cuenta");
		sql ="UPDATE TCuenta "+
		"SET numCuenta='"+pcuenta.getNumCuenta()+"', numComunidad='"+pcuenta.getNumComunidad()+"',fecha='"+pcuenta.getFecha()+"',monto="+pcuenta.getMonto()+" "+
		"WHERE numCuenta='"+pcuenta.getNumCuenta()+"';";
		//System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La cuenta no esta Registrada.");
		}
		
	}
	public void aumentarMontoCuenta(Cuenta pcuenta) throws java.sql.SQLException,Exception{	
		String sql;
		//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
		//System.out.println(pcuenta.getMonto()+" este es el monto nuevo de la cuenta");
		sql ="UPDATE TCuenta "+
		"SET numCuenta='"+pcuenta.getNumCuenta()+"', numComunidad='"+pcuenta.getNumComunidad()+"',fecha='"+pcuenta.getFecha()+"',monto="+pcuenta.getMonto()+" "+
		"WHERE numCuenta='"+pcuenta.getNumCuenta()+"';";
		System.out.print(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La cuenta no esta Registrada.");
		}
		
	}

}
