package capaLogica;

import java.util.Vector;

import capaAccesoBD.AccesoBD;
import capaAccesoBD.Conector;

public class MultiRecibo {

	public Recibo crearRecibo(String pnumRecibo,String pfecha,int pimporte,String pestado,String pidAdministrador,String pnumEmpresa)throws Exception{
		Recibo recibo=null;
		String sql;
		sql="INSERT INTO TRecibo "+
		"VALUES  ('"+pnumRecibo+"','"+pfecha+"',"+pimporte+",'"+pestado+"','"+pidAdministrador+"','"+pnumEmpresa+"');";

		try{
			AccesoBD objABD= Conector.getConector();
			objABD.ejecutarSQL(sql);
			recibo=new Recibo(pnumRecibo,pfecha,pimporte,pestado,pidAdministrador,pnumEmpresa);
		}catch(Exception e){
			throw new Exception ("El numero de la recibo ya esta registrado");
		}		
		return recibo;
	}
	
	/*public  Vector buscarPorAdministrador(String pidentificacionAdminis) throws java.sql.SQLException,Exception{
		java.sql.ResultSet rs;
		String sql;
		Recibo recibo=null;
		Vector recibos=null;
		sql="SELECT * "+
		"FROM TRecibo "+
		"WHERE idAdministrador='"+pidentificacionAdminis+"';";
		Conector.getConector().ejecutarSQL(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);
		recibos = new Vector();
		while (rs.next()){
			recibo = new Recibo(
				rs.getString("numRecibo"),
				rs.getString("fechaRecibo"),
				rs.getInt("importe"),
				rs.getString("estado"),
				rs.getString("idAdministrador"));
				recibos.add(recibo);
		}
		rs.close();
		return recibos;
	}*/
	
	public Recibo buscarRecibo(String pnumRecibo) throws java.sql.SQLException,Exception{
		Recibo recibo=null;
		java.sql.ResultSet rs;
		String sql;
		//String numRecibo,String fecha,int importe,String estado,String idAdministrador
		sql="SELECT numRecibo, fechaRecibo, importe, estado, idAdministrador, numEmpresa "+
		"FROM TRecibo "+
		"where numRecibo='"+ pnumRecibo +"';";
		System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql,true);   
		if (rs.next()) {
			recibo = new Recibo(
					rs.getString("numRecibo"),
					rs.getString("fechaRecibo"),
					rs.getInt("importe"),
					rs.getString("estado"),
					rs.getString("idAdministrador"),
					rs.getString("numEmpresa"));
		} else {
			throw new Exception ("El Recibo no está registrado.");
		}
		rs.close();
		return recibo;
	}
	
	
}
