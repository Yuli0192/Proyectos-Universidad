package  
{
	import org.kayu.KYNivelFabrica;
	import org.kayu.KYNivel;
	
	/**
	 * ...
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class NivelFabrica extends KYNivelFabrica
	{
		
		public function NivelFabrica() 
		{}
		
		public override function crearNivel(pnivel:Number):KYNivel 
		{
			var objNivel:KYNivel;
			switch(pnivel) {
				case 1: 
					objNivel = new Nivel1();
					break;
				case 2:
					//objNivel = new Nivel2();
					break;
			}
			return objNivel;
		}
	}

}