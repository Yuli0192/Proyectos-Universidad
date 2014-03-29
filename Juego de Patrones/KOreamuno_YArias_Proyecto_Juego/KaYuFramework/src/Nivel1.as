package  
{
	import org.kayu.KYEstadoNivel;
	import org.kayu.KYNivel;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Nivel1 extends KYNivel
	{		
		
		public function Nivel1() 
		{
			super(new Nivel1EstadoInicial(), new Nivel1Interfaz() );
		}
		
	}
}

