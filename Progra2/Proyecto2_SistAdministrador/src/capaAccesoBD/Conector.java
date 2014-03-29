package capaAccesoBD;


public class Conector{

	private static AccesoBD conectorBD = null;
 
	public static AccesoBD getConector() throws 
	java.sql.SQLException,Exception{
		if (conectorBD == null){			
			conectorBD = new AccesoBD("sun.jdbc.odbc.JdbcOdbcDriver","jdbc:odbc:ODBCFincas","","");

		}
		return conectorBD;
	}
	
}
