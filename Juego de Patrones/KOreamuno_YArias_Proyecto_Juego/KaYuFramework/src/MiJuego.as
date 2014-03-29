package
{
	import org.kayu.KYConfigJuego;
	import org.kayu.KYJuego;
	import org.kayu.KYNivel;
	import org.kayu.KYNivelFabrica;
	import org.flixel.FlxG;
	
	[SWF(width="1200", height="600", backgroundColor="#000000")]

	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class MiJuego extends KYJuego
	{
		private var objFabricaNivel:NivelFabrica;
		
		public function MiJuego()
		{
			super();
			objFabricaNivel = new NivelFabrica();
			var objNivel:KYNivel = objFabricaNivel.crearNivel(1);
			setNivelActual(objNivel);
			iniciarJuego();
		}
	}
}
